using SharpVk.Emit;
using SharpVk.Generator.Generation;
using System;
using System.Collections.Generic;
using System.Linq;

using static SharpVk.Emit.AccessModifier;
using static SharpVk.Emit.ExpressionBuilder;

namespace SharpVk.Generator.Emission
{
    public class MethodEmitter
    {
        public void EmitConstructor(TypeBuilder typeBuilder, MethodDefinition constructor)
        {
            typeBuilder.EmitConstructor(BuildBody(constructor), BuildParams(constructor), Public);
        }

        public void Emit(TypeBuilder typeBuilder, MethodDefinition method)
        {
            var modifiers = MemberModifier.None;

            if (method.IsUnsafe)
            {
                modifiers |= MemberModifier.Unsafe;
            }

            if (method.IsStatic)
            {
                modifiers |= MemberModifier.Static;
            }

            Func<MethodDefinition, Action<CodeBlockBuilder>> bodyFunc = BuildBody;

            if (method.AllocatesUnmanagedMemory)
            {
                bodyFunc = x => body => body.EmitTry(BuildBody(x), finallyBlock =>
                     {
                         finallyBlock.EmitStaticCall("Interop.HeapUtil", "FreeAll");
                     });
            }

            typeBuilder.EmitMethod(method.ReturnType ?? "void",
                                        method.Name,
                                        bodyFunc(method),
                                        BuildParams(method),
                                        method.IsPublic ? Public : Internal,
                                        modifiers,
                                        summary: method.Comment,
                                        docs: docBuilder =>
                                        {
                                            foreach (var action in method.ParamActions)
                                            {
                                                if (action.Param.Comment != null && action.Param.Comment.Any())
                                                {
                                                    docBuilder.EmitParam(action.Param.Name.TrimStart('@'), string.Join(" ", action.Param.Comment));
                                                }
                                                else
                                                {
                                                    docBuilder.EmitParam(action.Param.Name.TrimStart('@'), "");
                                                }
                                            }
                                        });
        }

        private static Action<ParameterBuilder> BuildParams(MethodDefinition method)
        {
            return parameters =>
            {
                if (method.ParamActions != null)
                {
                    foreach (var action in method.ParamActions.Where(x => x.Param.DefaultValue == null).OrderBy(x => x.Param.IsOut))
                    {
                        parameters.EmitParam(action.Param.Type, action.Param.Name, action.Param.IsOut, action.Param.DefaultValue);
                    }

                    foreach (var action in method.ParamActions.Where(x => x.Param.DefaultValue != null))
                    {
                        parameters.EmitParam(action.Param.Type, action.Param.Name, action.Param.IsOut, action.Param.DefaultValue);
                    }
                }
            };
        }

        private static Action<CodeBlockBuilder> BuildBody(MethodDefinition method)
        {
            return body =>
            {
                if (IsNotNullOrVoid(method.ReturnType))
                {
                    body.EmitVariableDeclaration(method.ReturnType, "result", Default(method.ReturnType));
                }

                if (method.ParamActions != null)
                {
                    foreach (var action in method.ParamActions.Where(x => x.MemberName != null))
                    {
                        body.EmitAssignment(Member(This, action.MemberName), Variable(action.Param.Name));
                    }
                }

                if (method.MemberActions != null)
                {
                    EmitActions(body, method.MemberActions);
                }

                if (IsNotNullOrVoid(method.ReturnType))
                {
                    body.EmitReturn(Variable("result"));
                }
            };
        }

        private static void EmitActions(CodeBlockBuilder body, List<MethodAction> actions)
        {
            foreach (var action in actions.OfType<DeclarationAction>())
            {
                body.EmitVariableDeclaration(action.MemberType, action.MemberName, Default(action.MemberType));
            }

            foreach (var action in actions.OrderBy(x => x.Priority))
            {
                if (action is AssignAction assignAction)
                {
                    if (assignAction.IsLoop)
                    {
                        void BuildAssignBlock(CodeBlockBuilder ifBlock)
                        {
                            var fieldPointerName = assignAction.FieldPointerName ?? "fieldPointer";

                            if (assignAction.IsArray)
                            {
                                ifBlock.EmitVariableDeclaration("var", fieldPointerName, NewArray(assignAction.MemberType, Cast("uint", assignAction.LengthExpression)));
                            }
                            else
                            {
                                string allocationType = assignAction.MemberType.EndsWith("*")
                                                            ? "IntPtr"
                                                            : assignAction.MemberType;

                                ifBlock.EmitVariableDeclaration("var", fieldPointerName, Cast(assignAction.MemberType + "*", Call(StaticCall("Interop.HeapUtil", $"AllocateAndClear<{allocationType}>", assignAction.LengthExpression), "ToPointer")));
                            }

                            ifBlock.EmitForLoop(init => init.EmitVariableDeclaration("int", assignAction.IndexName, Literal(0)),
                                                LessThan(Variable(assignAction.IndexName), Cast("uint", assignAction.LengthExpression)),
                                                after => after.EmitStatement(assignAction.IndexName + "++"),
                                                loop =>
                                                {
                                                    EmitMarshalAction(loop, assignAction, Index(Variable(fieldPointerName), Variable(assignAction.IndexName)));
                                                });

                            ifBlock.EmitAssignment(assignAction.TargetExpression, Variable(fieldPointerName));
                        }

                        if (assignAction.NullCheckExpression != null)
                        {
                            body.EmitIfBlock(assignAction.NullCheckExpression,
                                BuildAssignBlock,
                                elseBlock =>
                                {
                                    elseBlock.EmitAssignment(assignAction.TargetExpression, Null);
                                });
                        }
                        else
                        {
                            BuildAssignBlock(body);
                        }
                    }
                    else
                    {
                        EmitMarshalAction(body, assignAction, assignAction.TargetExpression);
                    }
                }
                else if (action is InvokeAction invokeAction)
                {
                    var paramNames = (invokeAction.Parameters ?? Enumerable.Empty<Action<ExpressionBuilder>>().ToArray());

                    Action<ExpressionBuilder> invokeExpression = null;

                    if (invokeAction.LookupDelegate)
                    {
                        if (invokeAction.DelegateName != null)
                        {
                            body.EmitVariableDeclaration(invokeAction.DelegateName, "commandDelegate", Member(Variable("commandCache"), "Cache", invokeAction.MethodName));
                        }

                        invokeExpression = DelegateCall(Variable("commandDelegate"), paramNames);
                    }
                    else if (invokeAction.TypeName == null)
                    {
                        invokeExpression = Call(This, invokeAction.MethodName, paramNames);
                    }
                    else
                    {
                        invokeExpression = StaticCall(invokeAction.TypeName, invokeAction.MethodName, paramNames);
                    }

                    if (invokeAction.ReturnName != null)
                    {
                        if (invokeAction.ReturnType != null)
                        {
                            body.EmitVariableDeclaration(invokeAction.ReturnType, invokeAction.ReturnName, invokeExpression);
                        }
                        else
                        {
                            body.EmitAssignment(Variable(invokeAction.ReturnName), invokeExpression);
                        }
                    }
                    else
                    {
                        body.EmitCallExpression(invokeExpression);
                    }
                }
                else if (action is OptionalAction optionalAction)
                {
                    if (optionalAction.ElseActions.Any())
                    {
                        body.EmitIfBlock(optionalAction.CheckExpression,
                                ifBlock => EmitActions(ifBlock, optionalAction.Actions),
                                elseBlock => EmitActions(elseBlock, optionalAction.ElseActions));
                    }
                    else
                    {
                        body.EmitIfBlock(optionalAction.CheckExpression,
                                ifBlock => EmitActions(ifBlock, optionalAction.Actions));
                    }
                }
                else if (action is ValidateAction validationAction)
                {
                    body.EmitIfBlock(StaticCall("SharpVkException", "IsError", Variable(validationAction.VariableName)),
                        ifBlock =>
                        {
                            ifBlock.EmitThrow(StaticCall("SharpVkException", "Create", Variable(validationAction.VariableName)));
                        });
                }
            }
        }

        public static void EmitMarshalAction(CodeBlockBuilder codeBlock, Generation.AssignAction action, Action<ExpressionBuilder> targetExpression)
        {
            switch (action.Type)
            {
                case AssignActionType.Assign:
                    codeBlock.EmitAssignment(targetExpression, action.ValueExpression);
                    break;
                case AssignActionType.Alloc:
                    if (action.LengthExpression != null)
                    {
                        codeBlock.EmitAssignment(targetExpression,
                                            Cast(action.MemberType + "*", StaticCall("Interop.HeapUtil", $"Allocate<{action.MemberType}>", action.LengthExpression)));
                    }
                    else
                    {
                        codeBlock.EmitAssignment(targetExpression,
                                            Cast(action.MemberType + "*", StaticCall("Interop.HeapUtil", $"Allocate<{action.MemberType}>")));
                    }
                    break;
                case AssignActionType.AllocAndAssign:
                    codeBlock.EmitAssignment(targetExpression,
                                        Cast(action.MemberType + "*", StaticCall("Interop.HeapUtil", $"Allocate<{action.MemberType}>")));
                    codeBlock.EmitAssignment(Deref(targetExpression), action.ValueExpression);
                    break;
                case AssignActionType.MarshalToAddressOf:
                    codeBlock.EmitCall(action.ValueExpression, "MarshalTo", AddressOf(targetExpression));
                    break;
                case AssignActionType.MarshalTo:
                    codeBlock.EmitAssignment(targetExpression,
                                        Cast(action.MemberType + "*", StaticCall("Interop.HeapUtil", $"Allocate<{action.MemberType}>")));
                    codeBlock.EmitCall(action.ValueExpression, "MarshalTo", targetExpression);
                    break;
                case AssignActionType.MarshalFrom:
                    codeBlock.EmitAssignment(targetExpression,
                                        StaticCall(action.MemberType, "MarshalFrom", action.ValueExpression));
                    break;
                case AssignActionType.MarshalFromAddressOf:
                    codeBlock.EmitAssignment(targetExpression,
                                        StaticCall(action.MemberType, "MarshalFrom", AddressOf(action.ValueExpression)));
                    break;
                case AssignActionType.FixedLengthMarshalTo:
                    codeBlock.EmitStaticCall("Interop.HeapUtil", "MarshalTo", action.ValueExpression, action.LengthExpression, targetExpression);
                    break;
            }
        }

        private static bool IsNotNullOrVoid(string type)
        {
            return type != null
                    && type != "void";
        }
    }
}
