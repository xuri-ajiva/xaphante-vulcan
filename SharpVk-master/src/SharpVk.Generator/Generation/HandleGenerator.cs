using Microsoft.Extensions.DependencyInjection;
using SharpVk.Emit;
using SharpVk.Generator.Collation;
using SharpVk.Generator.Generation.Marshalling;
using SharpVk.Generator.Pipeline;
using SharpVk.Generator.Rules;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

using static SharpVk.Emit.ExpressionBuilder;

namespace SharpVk.Generator.Generation
{
    public class HandleGenerator
        : IWorker
    {
        private readonly Dictionary<string, TypeDeclaration> typeData;
        private readonly NameLookup nameLookup;
        private readonly Dictionary<string, IEnumerable<CommandDeclaration>> commands;
        private readonly Dictionary<string, ExtensionDeclaration> extensions;
        private readonly IEnumerable<IMarshalValueRule> marshallingRules;
        private readonly IEnumerable<IMemberPatternRule> memberPatternRules;
        private readonly ParsedExpressionTokenCheck tokenCheck;
        private readonly NamespaceMap namespaceMap;
        private readonly CommentGenerator commentGenerator;

        public HandleGenerator(Dictionary<string, TypeDeclaration> typeData,
                                NameLookup nameLookup,
                                IEnumerable<CommandDeclaration> commands,
                                IEnumerable<ExtensionDeclaration> extensions,
                                IEnumerable<IMarshalValueRule> marshallingRules,
                                IEnumerable<IMemberPatternRule> memberPatternRules,
                                ParsedExpressionTokenCheck tokenCheck,
                                NamespaceMap namespaceMap,
                                CommentGenerator commentGenerator)
        {
            this.typeData = typeData;
            this.nameLookup = nameLookup;
            this.commands = commands.GroupBy(x => x.HandleTypeName).ToDictionary(x => x.Key, x => x.AsEnumerable());
            this.extensions = extensions.ToDictionary(x => x.Name);
            this.marshallingRules = marshallingRules;
            this.memberPatternRules = memberPatternRules;
            this.tokenCheck = tokenCheck;
            this.namespaceMap = namespaceMap;
            this.commentGenerator = commentGenerator;
        }

        public void Execute(IServiceCollection services)
        {
            foreach (var typePair in this.typeData.Where(x => x.Value.Pattern == TypePattern.Handle))
            {
                var type = typePair.Value;

                var commands = this.commands.ContainsKey(typePair.Key)
                                        ? this.commands[typePair.Key]
                                            .Where(x => x.ExtensionNamespace?.ToLower() == type.Extension?.ToLower())
                                            .SelectMany(x => GenerateCommand(x, typePair.Key, typePair.Value)).ToList()
                                        : new List<MethodDefinition>();

                var parentType = type.Parent != null
                                        ? typeData[type.Parent]
                                        : null;

                var interfaces = new List<string>();
                string commandCacheType = null;

                if (commands.Any(x => x.Name == "GetProcedureAddress"))
                {
                    interfaces.Add("IProcLookup");
                    commandCacheType = type.Name.ToLower();
                }

                if (commands.Any(x => x.Name == "Destroy"))
                {
                    interfaces.Add("IDisposable");
                    commands.Add(new MethodDefinition
                    {
                        IsPublic = true,
                        Name = "Dispose",
                        Comment = new List<string> { "Destroys the handles and releases any unmanaged resources associated with it." },
                        ParamActions = new List<ParamActionDefinition>(),
                        MemberActions = new List<MethodAction>()
                        {
                            new InvokeAction
                            {
                                MethodName = "Destroy"
                            }
                        }
                    });
                }

                services.AddSingleton(new HandleDefinition
                {
                    Name = type.Name,
                    Parent = parentType?.Name,
                    Comment = this.commentGenerator.Lookup(typePair.Key),
                    Namespace = type.Extension != null ? this.namespaceMap.Map(type.Extension).ToArray() : null,
                    ParentNamespace = parentType?.Extension != null ? this.namespaceMap.Map(parentType.Extension).ToArray() : null,
                    IsDispatch = type.Type != "VK_DEFINE_NON_DISPATCHABLE_HANDLE",
                    CommandCacheType = commandCacheType,
                    Commands = commands,
                    Interfaces = interfaces
                });
            }
        }

        public IEnumerable<MethodDefinition> GenerateCommand(CommandDeclaration command, string handleTypeName, TypeDeclaration handleType, bool isExtension = false)
        {
            var lastParam = command.Params.Last();

            bool IsArray(ParamDeclaration param)
            {
                return param.Type.PointerType == PointerType.Pointer
                                            && param.Dimensions != null
                                            && param.Dimensions.Any(x => x.Type != LenType.NullTerminated);
            }

            bool lastParamIsArray = IsArray(lastParam);

            bool lastParamLenFieldByRef = lastParamIsArray
                                            && lastParam.Dimensions[0].Value is LenExpressionToken
                                            && command.Params.Single(x => x.VkName == ((LenExpressionToken)lastParam.Dimensions[0].Value).Value).Type.PointerType == PointerType.Pointer;

            bool lastParamReturns = !lastParam.Type.PointerType.IsConst()
                                        && (typeData[lastParam.Type.VkName].IsOutputOnly
                                            || lastParam.Type.PointerType.GetPointerCount() == 2
                                            || (typeData[lastParam.Type.VkName].Pattern != TypePattern.MarshalledStruct && typeData[lastParam.Type.VkName].Pattern != TypePattern.NonMarshalledStruct)
                                            || lastParamLenFieldByRef
                                            || command.Verb == "get")
                                        && (command.ReturnType == "VkResult" || command.ReturnType == "void");

            int returnParamsCount = 0;

            if (lastParamReturns)
            {
                returnParamsCount = Math.Max(1, command.Params.AsEnumerable().Reverse().TakeWhile(IsArray).Count());
            }

            bool enumeratePattern = (command.Verb == "enumerate" && lastParamIsArray) || (lastParamIsArray && lastParamLenFieldByRef);
            bool isBatchMethod = lastParamIsArray && !enumeratePattern && lastParam.Type.VkName != "void";

            yield return this.GenerateCommandVariant(command, handleTypeName, handleType, isExtension, enumeratePattern, lastParamIsArray, returnParamsCount, false);

            if (isBatchMethod)
            {
                yield return this.GenerateCommandVariant(command, handleTypeName, handleType, isExtension, enumeratePattern, lastParamIsArray, returnParamsCount, true);
            }
        }

        private MethodDefinition GenerateCommandVariant(CommandDeclaration command, string handleTypeName, TypeDeclaration handleType, bool isExtension, bool enumeratePattern, bool lastParamIsArray, int returnParamsCount, bool isBatchSingleMethod)
        {
            var handleExpression = isExtension ? Variable("extendedHandle") : This;

            var handleLookup = new Dictionary<string, Action<ExpressionBuilder>>
            {
                [handleTypeName] = handleExpression
            };

            if (handleType.Parent != null)
            {
                handleLookup.Add(handleType.Parent, Member(handleExpression, "parent"));
            }

            Action<ExpressionBuilder> GetHandle(string handleName)
            {
                if (!handleLookup.TryGetValue(handleName, out var result))
                {
                    return Default(this.typeData[handleName].Name);
                }

                return result;
            }

            string methodName = command.Name;

            if (isBatchSingleMethod && methodName.EndsWith("s"))
            {
                methodName = methodName.Substring(0, methodName.Length - 1);
            }

            var newMethod = new MethodDefinition
            {
                Name = methodName,
                ReturnType = "void",
                Comment = this.commentGenerator.Lookup(command.VkName),
                IsPublic = true,
                IsUnsafe = true,
                IsStatic = isExtension,
                AllocatesUnmanagedMemory = true
            };

            newMethod.ParamActions = new List<ParamActionDefinition>();
            newMethod.MemberActions = new List<MethodAction>();

            if (command.HandleParamsCount == 0)
            {
                Debug.Assert(returnParamsCount > 0);

                newMethod.IsStatic = true;
                newMethod.ParamActions.Add(new ParamActionDefinition
                {
                    Param = new ParamDefinition
                    {
                        Type = "CommandCache",
                        Name = "commandCache"
                    }
                });
            }

            int parameterIndex = 0;

            var marshalFromActions = new List<MethodAction>();
            var marshalMidActions = new List<MethodAction>();
            var marshalToActions = new List<MethodAction>();

            var marshalledValues = new List<Action<ExpressionBuilder>>();

            if (isExtension)
            {
                var extendedHandleType = this.nameLookup.Lookup(new TypeReference { VkName = handleTypeName }, false);

                newMethod.ParamActions.Add(new ParamActionDefinition
                {
                    Param = new ParamDefinition
                    {
                        Name = "extendedHandle",
                        Type = "this " + extendedHandleType,
                        Comment = new List<string>
                        {
                            $"The {handleType.Name} handle to extend."
                        }
                    }
                });

                marshalToActions.Add(new DeclarationAction
                {
                    MemberType = "CommandCache",
                    MemberName = "commandCache"
                });

                marshalToActions.Add(new AssignAction
                {
                    TargetExpression = Variable("commandCache"),
                    ValueExpression = Member(Variable("extendedHandle"), "commandCache")
                });
            }

            foreach (var parameter in command.Params)
            {
                var newParams = this.GenerateParameter(command, newMethod, parameter, parameterIndex, enumeratePattern, lastParamIsArray, returnParamsCount, isBatchSingleMethod, marshalFromActions, marshalMidActions, marshalToActions, marshalledValues, GetHandle, handleLookup);

                if (newParams != null)
                {
                    newMethod.ParamActions.AddRange(newParams);
                }

                parameterIndex++;
            }

            string invokeReturnType = null;
            string invokeReturnName = null; ;

            if (command.ReturnType == "VkResult")
            {
                if (command.MultipleSuccessCodes && newMethod.ReturnType == "void")
                {
                    newMethod.ReturnType = this.typeData["VkResult"].Name;
                    invokeReturnName = "result";
                }
                else
                {
                    invokeReturnType = this.typeData["VkResult"].Name;
                    invokeReturnName = "methodResult";
                }
            }
            else if (this.typeData[command.ReturnType].Pattern == TypePattern.Delegate)
            {
                newMethod.ReturnType = "IntPtr";
                invokeReturnName = "result";
            }

            newMethod.MemberActions.AddRange(marshalToActions);

            string delegateName = string.Join(".", new[] { "SharpVk", "Interop" }.Concat(this.namespaceMap.Map(command.ExtensionNamespace))) + $".{command.HandleTypeName}{command.Name}Delegate";
            string lookupScope = command.Extension != null ? this.extensions[command.Extension].Scope : "";

            newMethod.MemberActions.Add(new InvokeAction
            {
                TypeName = "Interop.Commands",
                MethodName = command.VkName,
                ReturnName = invokeReturnName,
                ReturnType = invokeReturnType,
                LookupDelegate = true,
                DelegateName = delegateName,
                LookupScope = lookupScope,
                Parameters = marshalledValues.ToArray()
            });

            if (command.ReturnType == "VkResult")
            {
                newMethod.MemberActions.Add(new ValidateAction
                {
                    VariableName = invokeReturnName
                });
            }

            if (enumeratePattern)
            {
                newMethod.MemberActions.AddRange(marshalMidActions);

                newMethod.MemberActions.Add(new InvokeAction
                {
                    TypeName = "Interop.Commands",
                    MethodName = command.VkName,
                    LookupDelegate = true,
                    Parameters = marshalledValues.ToArray()
                });
            }

            newMethod.MemberActions.AddRange(marshalFromActions);

            return newMethod;
        }

        private IEnumerable<ParamActionDefinition> GenerateParameter(CommandDeclaration command, MethodDefinition newMethod, ParamDeclaration parameter, int parameterIndex, bool isEnumeratePattern, bool isLastParamArray, int returnParamsCount, bool isBatchSingleMethod, List<MethodAction> marshalFromActions, List<MethodAction> marshalMidActions, List<MethodAction> marshalToActions, List<Action<ExpressionBuilder>> marshalledValues, Func<string, Action<ExpressionBuilder>> getHandle, Dictionary<string, Action<ExpressionBuilder>> handleLookup)
        {
            string paramName = parameter.Name;
            var paramType = typeData[parameter.Type.VkName];

            string GetMarshalledName(string baseName)
            {
                return "marshalled" + baseName.TrimStart('@').FirstToUpper();
            }

            var result = new List<ParamActionDefinition>();

            if (parameterIndex >= command.HandleParamsCount)
            {
                if (returnParamsCount > 0 && parameterIndex == command.Params.Count() - (returnParamsCount + 1) && isEnumeratePattern)
                {
                    string marshalledName = GetMarshalledName(paramName);

                    newMethod.MemberActions.Add(new DeclarationAction
                    {
                        MemberType = paramType.Name,
                        MemberName = marshalledName
                    });

                    marshalledValues.Add(AddressOf(Variable(marshalledName)));

                    for (int returnParamIndex = 0; returnParamIndex < returnParamsCount; returnParamIndex++)
                    {
                        var patternInfo = new MemberPatternInfo();

                        this.memberPatternRules.ApplyFirst(command.Params, command.Params.AsEnumerable().Reverse().Skip(returnParamIndex).First(), new MemberPatternContext(command.Verb, true, isBatchSingleMethod, returnParamsCount, command.ExtensionNamespace, getHandle, command.VkName), patternInfo);

                        string marshalledTargetName = GetMarshalledName(patternInfo.Interop.Name);

                        marshalMidActions.Add(new AssignAction
                        {
                            Type = AssignActionType.Alloc,
                            MemberType = patternInfo.InteropFullType.TrimEnd('*'),
                            TargetExpression = Variable(marshalledTargetName),
                            LengthExpression = Cast("uint", Variable(marshalledName))
                        });
                    }
                }
                else if (parameterIndex >= command.Params.Count() - returnParamsCount)
                {
                    if (isLastParamArray)
                    {
                        var patternInfo = new MemberPatternInfo();

                        this.memberPatternRules.ApplyFirst(command.Params, parameter, new MemberPatternContext(command.Verb, true, isBatchSingleMethod, returnParamsCount, command.ExtensionNamespace, getHandle, command.VkName), patternInfo);

                        var outputVariable = "result";

                        if (returnParamsCount > 1)
                        {
                            newMethod.ParamActions.Add(new ParamActionDefinition
                            {
                                Param = new ParamDefinition
                                {
                                    Name = paramName,
                                    Type = paramType.Name + "[]",
                                    IsOut = true
                                }
                            });

                            outputVariable = paramName;
                        }

                        string marshalledName = GetMarshalledName(patternInfo.Interop.Name);

                        marshalToActions.Add(new DeclarationAction
                        {
                            MemberType = patternInfo.InteropFullType,
                            MemberName = marshalledName
                        });

                        var newMarshalFrom = patternInfo.MarshalFrom.Select(action => action(targetName => Variable(outputVariable), valueName => Variable(GetMarshalledName(valueName)))).ToArray();

                        if (!isEnumeratePattern)
                        {
                            var lengthExpression = isBatchSingleMethod
                                                        ? Literal(1)
                                                        : newMarshalFrom.OfType<AssignAction>().First(x => x.IsLoop).LengthExpression;

                            marshalToActions.Add(new AssignAction
                            {
                                Type = AssignActionType.Alloc,
                                MemberType = patternInfo.InteropFullType.TrimEnd('*'),
                                TargetExpression = Variable(marshalledName),
                                LengthExpression = lengthExpression
                            });
                        }

                        marshalFromActions.AddRange(newMarshalFrom);

                        marshalledValues.Add(Variable(marshalledName));

                        if (returnParamsCount == 1)
                        {
                            newMethod.ReturnType = patternInfo.ReturnType ?? patternInfo.Public.Single().Type;
                        }
                        else
                        {
                            newMethod.ReturnType = "void";
                        }
                    }
                    else
                    {
                        var patternInfo = new MemberPatternInfo();

                        var effectiveParam = new ParamDeclaration
                        {
                            Name = parameter.Name,
                            Type = parameter.Type.Deref(),
                            Dimensions = parameter.Dimensions,
                            VkName = parameter.VkName
                        };

                        this.memberPatternRules.ApplyFirst(command.Params, effectiveParam, new MemberPatternContext(command.Verb, true, isBatchSingleMethod, returnParamsCount, command.ExtensionNamespace, getHandle, command.VkName), patternInfo);

                        string marshalledName = GetMarshalledName(patternInfo.Interop.Name);

                        marshalToActions.Add(new DeclarationAction
                        {
                            MemberType = patternInfo.InteropFullType,
                            MemberName = marshalledName
                        });

                        marshalFromActions.AddRange(patternInfo.MarshalFrom.Select(action => action(targetName => Variable("result"), valueName => Variable(GetMarshalledName(valueName)))));

                        marshalledValues.Add(AddressOf(Variable(marshalledName)));

                        newMethod.ReturnType = patternInfo.Public.Single().Type;
                    }
                }
                else
                {
                    var patternInfo = new MemberPatternInfo();

                    this.memberPatternRules.ApplyFirst(command.Params, parameter, new MemberPatternContext(command.Verb, true, isBatchSingleMethod, returnParamsCount, command.ExtensionNamespace, getHandle, command.VkName), patternInfo);

                    var actionList = marshalToActions;

                    Func<string, Action<ExpressionBuilder>> getValue = valueName => Variable(valueName);

                    foreach (var publicMember in patternInfo.Public)
                    {
                        result.Add(new ParamActionDefinition
                        {
                            Param = new ParamDefinition
                            {
                                Name = publicMember.Name,
                                Comment = publicMember.Comment,
                                Type = publicMember.Type,
                                DefaultValue = publicMember.DefaultValue
                            }
                        });
                    }

                    if (patternInfo.MarshalTo.Any())
                    {
                        string marshalledName = GetMarshalledName(patternInfo.Interop.Name);

                        var newMarshalToActions = patternInfo.MarshalTo.Select(action => action(targetName => Variable(marshalledName), getValue));

                        var lastParam = command.Params.Last();
                        bool isLenForLastParam = returnParamsCount > 0 && lastParam.Dimensions != null && lastParam.Dimensions.Any(dimension => dimension.Type == LenType.Expression && this.tokenCheck.Check(dimension.Value, parameter.VkName));

                        if (!isLenForLastParam
                                && newMarshalToActions.Count() == 1
                                && newMarshalToActions.First() is AssignAction newAssignAction
                                && newAssignAction.Type == AssignActionType.Assign
                                && !newAssignAction.IsLoop)
                        {
                            marshalledValues.Add(newAssignAction.ValueExpression);
                        }
                        else
                        {
                            marshalToActions.Add(new DeclarationAction
                            {
                                MemberType = patternInfo.InteropFullType,
                                MemberName = marshalledName
                            });

                            marshalledValues.Add(Variable(marshalledName));

                            actionList.AddRange(newMarshalToActions);
                        }
                    }

                    foreach (var lookup in patternInfo.HandleLookup)
                    {
                        handleLookup[lookup.Item1] = lookup.Item2(getValue);
                    }
                }
            }
            else
            {
                marshalledValues.Add(Member(getHandle(parameter.Type.VkName), "handle"));
            }

            return result;
        }
    }
}
