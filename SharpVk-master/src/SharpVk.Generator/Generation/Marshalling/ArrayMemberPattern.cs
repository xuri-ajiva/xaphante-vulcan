using SharpVk.Emit;
using SharpVk.Generator.Collation;
using SharpVk.Generator.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using static SharpVk.Emit.ExpressionBuilder;

namespace SharpVk.Generator.Generation.Marshalling
{
    public class ArrayMemberPattern
        : IMemberPatternRule
    {
        private readonly IEnumerable<IMarshalValueRule> marshallingRules;
        private readonly NameLookup nameLookup;
        private readonly ParsedExpressionBuilder expressionBuilder;
        private readonly CommentGenerator commentGenerator;

        public ArrayMemberPattern(IEnumerable<IMarshalValueRule> marshallingRules, NameLookup nameLookup, ParsedExpressionBuilder expressionBuilder, CommentGenerator commentGenerator)
        {
            this.marshallingRules = marshallingRules;
            this.nameLookup = nameLookup;
            this.expressionBuilder = expressionBuilder;
            this.commentGenerator = commentGenerator;
        }

        public bool Apply(IEnumerable<ITypedDeclaration> others, ITypedDeclaration source, MemberPatternContext context, MemberPatternInfo info)
        {
            if (source.Dimensions != null)
            {
                string typeName = this.nameLookup.Lookup(source.Type, true);

                info.Interop = new TypedDefinition
                {
                    Name = source.Name,
                    Type = typeName
                };

                if (source.Dimensions.Length == 2)
                {
                    info.Public.Add(new TypedDefinition
                    {
                        Name = source.Name,
                        Type = "ArrayProxy<string>" + (context.IsMethod ? "?" : ""),
                        DefaultValue = source.IsOptional ? Null : null,
                        Comment = this.commentGenerator.Lookup(context.VkName, source.VkName)
                    });

                    info.MarshalTo.Add((getTarget, getValue) =>
                    {
                        return new AssignAction
                        {
                            ValueExpression = StaticCall("Interop.HeapUtil", "MarshalTo", getValue(source.Name)),
                            TargetExpression = getTarget(source.Name),
                            MemberType = this.nameLookup.Lookup(source.Type, false),
                            Type = AssignActionType.Assign
                        };
                    });
                }
                else if (source.Dimensions.Length == 1)
                {
                    switch (source.Dimensions[0].Type)
                    {
                        case LenType.NullTerminated:
                            info.Public.Add(new TypedDefinition
                            {
                                Name = source.Name,
                                Comment = this.commentGenerator.Lookup(context.VkName, source.VkName),
                                Type = "string"
                            });

                            info.InteropFullType = typeName;

                            info.MarshalTo.Add((getTarget, getValue) => new AssignAction
                            {
                                ValueExpression = StaticCall("Interop.HeapUtil", "MarshalTo", getValue(source.Name)),
                                TargetExpression = getTarget(source.Name),
                                MemberType = this.nameLookup.Lookup(source.Type, false),
                                Type = AssignActionType.Assign
                            });

                            info.MarshalFrom.Add((getTarget, getValue) => new AssignAction
                            {
                                ValueExpression = StaticCall("Interop.HeapUtil", "MarshalStringFrom", getValue(source.Name)),
                                TargetExpression = getTarget(source.Name),
                                MemberType = this.nameLookup.Lookup(source.Type, false),
                                Type = AssignActionType.Assign
                            });

                            break;
                        case LenType.Expression:
                            var elementType = source.Type.Deref();
                            bool isDoubleMarshalled = false;
                            string semiMarshalledName = "semiMarshalled" + source.Name.FirstToUpper();
                            string semiMarshalType = this.nameLookup.Lookup(elementType, true);

                            if (elementType.PointerType.IsPointer())
                            {
                                info.MarshalTo.Add((getTarget, getValue) => new DeclarationAction
                                {
                                    MemberType = semiMarshalType,
                                    MemberName = semiMarshalledName
                                });

                                isDoubleMarshalled = true;
                                elementType = elementType.Deref();
                            }

                            if (elementType.VkName == "void")
                            {
                                elementType.VkName = "uint8_t";
                            }

                            var marshalling = this.marshallingRules.ApplyFirst(elementType);

                            info.Interop.Type = marshalling.InteropType + "*";
                            info.InteropFullType = marshalling.InteropType;

                            if (source.Type.PointerType.IsPointer())
                            {
                                info.InteropFullType += new string('*', source.Type.PointerType.GetPointerCount());
                            }

                            info.Interop = new TypedDefinition
                            {
                                Name = source.Name,
                                Type = info.InteropFullType
                            };

                            string arrayType = $"{marshalling.MemberType}[]";

                            if (context.IsMethod)
                            {
                                info.Public.Add(new TypedDefinition
                                {
                                    Name = source.Name,
                                    Type = $"ArrayProxy<{marshalling.MemberType}>?",
                                    Comment = new[] { "" }.ToList(),
                                    DefaultValue = source.IsOptional ? Null : null
                                });

                                info.ReturnType = arrayType;

                                info.MarshalTo.Add((getTarget, getValue) =>
                                {
                                    var proxyValue = Member(getValue(source.Name), "Value");

                                    var isNullOptional = new OptionalAction
                                    {
                                        CheckExpression = Call(getValue(source.Name), "IsNull")
                                    };

                                    var isSingleOptional = new OptionalAction
                                    {
                                        CheckExpression = IsEqual(Member(proxyValue, "Contents"), EnumField("ProxyContents", "Single"))
                                    };

                                    var loopAssign = new AssignAction
                                    {
                                        TargetExpression = isDoubleMarshalled ? Variable(semiMarshalledName) : getTarget(source.Name),
                                        MemberType = marshalling.InteropType,
                                        IsLoop = true,
                                        IndexName = "index",
                                        Type = marshalling.MarshalToActionType,
                                        LengthExpression = StaticCall("Interop.HeapUtil", "GetLength", proxyValue),
                                        ValueExpression = marshalling.BuildMarshalToValueExpression(Index(proxyValue, Variable("index")), context.GetHandle)
                                    };

                                    isSingleOptional.Actions.Add(new AssignAction
                                    {
                                        Type = AssignActionType.Alloc,
                                        TargetExpression = isDoubleMarshalled ? Variable(semiMarshalledName) : getTarget(source.Name),
                                        MemberType = marshalling.InteropType
                                    });

                                    isSingleOptional.Actions.Add(new AssignAction
                                    {
                                        Type = marshalling.MarshalToActionType,
                                        MemberType = marshalling.InteropType,
                                        ValueExpression = marshalling.BuildMarshalToValueExpression(Call(proxyValue, "GetSingleValue"), context.GetHandle),
                                        TargetExpression = Deref(Cast(marshalling.InteropType + "*", isDoubleMarshalled ? Variable(semiMarshalledName) : getTarget(source.Name)))
                                    });

                                    isSingleOptional.ElseActions.Add(loopAssign);

                                    if (isDoubleMarshalled)
                                    {
                                        isSingleOptional.ElseActions.Add(new AssignAction
                                        {
                                            TargetExpression = getTarget(source.Name),
                                            MemberType = semiMarshalType,
                                            IsLoop = true,
                                            IndexName = "index",
                                            Type = AssignActionType.Assign,
                                            LengthExpression = StaticCall("Interop.HeapUtil", "GetLength", proxyValue),
                                            ValueExpression = AddressOf(Index(Variable(semiMarshalledName), Variable("index"))),
                                            FieldPointerName = "marshalledFieldPointer"
                                        });
                                    }

                                    isNullOptional.Actions.Add(new AssignAction
                                    {
                                        TargetExpression = getTarget(source.Name),
                                        ValueExpression = Null
                                    });

                                    isNullOptional.ElseActions.Add(isSingleOptional);

                                    return isNullOptional;
                                });
                            }
                            else
                            {
                                info.Public.Add(new TypedDefinition
                                {
                                    Name = source.Name,
                                    Comment = this.commentGenerator.Lookup(context.VkName, source.VkName),
                                    Type = arrayType
                                });

                                info.MarshalTo.Add((getTarget, getValue) => new AssignAction
                                {
                                    TargetExpression = isDoubleMarshalled ? Variable(semiMarshalledName) : getTarget(source.Name),
                                    MemberType = marshalling.InteropType,
                                    IsLoop = true,
                                    IndexName = "index",
                                    Type = marshalling.MarshalToActionType,
                                    NullCheckExpression = IsNotEqual(getValue(source.Name), Null),
                                    LengthExpression = Member(getValue(source.Name), "Length"),
                                    ValueExpression = marshalling.BuildMarshalToValueExpression(Index(getValue(source.Name), Variable("index")), context.GetHandle)
                                });

                                if (isDoubleMarshalled)
                                {
                                    info.MarshalTo.Add((getTarget, getValue) => new AssignAction
                                    {
                                        TargetExpression = getTarget(source.Name),
                                        MemberType = semiMarshalType,
                                        IsLoop = true,
                                        IndexName = "index",
                                        Type = AssignActionType.Assign,
                                        NullCheckExpression = IsNotEqual(getValue(source.Name), Null),
                                        LengthExpression = Member(getValue(source.Name), "Length"),
                                        ValueExpression = AddressOf(Index(Variable(semiMarshalledName), Variable("index")))
                                    });
                                }
                            }

                            Func<Func<string, Action<ExpressionBuilder>>, Action<ExpressionBuilder>> lenValue = null;

                            if (source.Dimensions[0].Value is LenExpressionToken lenToken)
                            {
                                lenValue = getValue => getValue(others.Single(x => x.VkName == lenToken.Value).Name);
                            }
                            else
                            {
                                lenValue = getValue => this.expressionBuilder.Build(source.Dimensions[0].Value, x => others.Single(y => y.VkName == x));
                            }

                            info.MarshalFrom.Add((getTarget, getValue) => new AssignAction
                            {
                                TargetExpression = getTarget(source.Name),
                                MemberType = marshalling.MemberType,
                                IsLoop = true,
                                IsArray = true,
                                IndexName = "index",
                                Type = marshalling.MarshalFromActionType,
                                NullCheckExpression = IsNotEqual(getValue(source.Name), Null),
                                LengthExpression = lenValue(getValue),
                                ValueExpression = marshalling.BuildMarshalFromValueExpression(Index(getValue(source.Name), Variable("index")), context.GetHandle)
                            });

                            break;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
