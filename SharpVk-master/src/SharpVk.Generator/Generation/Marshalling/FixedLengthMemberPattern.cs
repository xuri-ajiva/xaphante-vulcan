using SharpVk.Generator.Collation;
using SharpVk.Generator.Rules;
using System.Collections.Generic;
using System.Linq;

using static SharpVk.Emit.ExpressionBuilder;

namespace SharpVk.Generator.Generation.Marshalling
{
    public class FixedLengthMemberPattern
        : IMemberPatternRule
    {
        private readonly Dictionary<string, TypeDeclaration> typeData;
        private readonly NameLookup nameLookup;
        private readonly Dictionary<string, ConstantDeclaration> constantsLookup;
        private readonly IEnumerable<IMarshalValueRule> marshallingRules;
        private readonly CommentGenerator commentGenerator;

        public FixedLengthMemberPattern(Dictionary<string, TypeDeclaration> typeData, NameLookup nameLookup, IEnumerable<ConstantDeclaration> constants, IEnumerable<IMarshalValueRule> marshallingRules, CommentGenerator commentGenerator)
        {
            this.typeData = typeData;
            this.nameLookup = nameLookup;
            this.constantsLookup = constants.ToDictionary(x => x.VkName);
            this.marshallingRules = marshallingRules;
            this.commentGenerator = commentGenerator;
        }

        public bool Apply(IEnumerable<ITypedDeclaration> others, ITypedDeclaration source, MemberPatternContext context, MemberPatternInfo info)
        {
            if (source.Type.FixedLength.Type != FixedLengthType.None)
            {
                string name = source.Name;
                string memberType = this.nameLookup.Lookup(source.Type, false);
                string interopType = this.nameLookup.Lookup(source.Type, true);

                if (this.typeData[source.Type.VkName].Pattern == TypePattern.Primitive)
                {
                    string length = "1";

                    if (source.Type.FixedLength.Type == FixedLengthType.IntegerLiteral)
                    {
                        length = source.Type.FixedLength.Value;
                    }
                    else
                    {
                        var constant = this.constantsLookup[source.Type.FixedLength.Value];

                        length = $"Constants.{constant.Name}";
                    }

                    info.InteropFullType = interopType;

                    name += $"[{length}]";
                    interopType = "fixed " + interopType;

                    info.Interop = new TypedDefinition
                    {
                        Name = name,
                        Type = interopType
                    };

                    switch (source.Type.VkName)
                    {
                        case "char":
                            info.Public.Add(new TypedDefinition
                            {
                                Name = source.Name,
                                Comment = this.commentGenerator.Lookup(context.VkName, source.VkName),
                                Type = "string"
                            });

                            info.MarshalFrom.Add((getTarget, getValue) => new AssignAction
                            {
                                TargetExpression = getTarget(source.Name),
                                ValueExpression = StaticCall("Interop.HeapUtil", "MarshalStringFrom", getValue(source.Name), AsIs(length), Literal(true))
                            });
                            break;
                        default:
                            if (memberType == "byte" && source.Name.ToLower().EndsWith("uid"))
                            {
                                info.Public.Add(new TypedDefinition
                                {
                                    Name = source.Name,
                                    Comment = this.commentGenerator.Lookup(context.VkName, source.VkName),
                                    Type = "Guid"
                                });

                                info.MarshalFrom.Add((getTarget, getValue) => new AssignAction
                                {
                                    TargetExpression = getTarget(source.Name),
                                    ValueExpression = New("Guid", StaticCall("Interop.HeapUtil", "MarshalFrom", getValue(source.Name), AsIs(length)))
                                });

                                info.MarshalTo.Add((getTarget, getValue) => new AssignAction
                                {
                                    TargetExpression = getTarget(source.Name),
                                    ValueExpression = getValue(source.Name),
                                    Type = AssignActionType.FixedLengthMarshalTo,
                                    LengthExpression = AsIs(length)
                                });
                            }
                            else if(int.TryParse(length, out int count))
                            {
                                info.Public.Add(new TypedDefinition
                                {
                                    Name = source.Name,
                                    Comment = this.commentGenerator.Lookup(context.VkName, source.VkName),
                                    Type = "(" + string.Join(", ", Enumerable.Repeat(memberType, count)) + ")"
                                });

                                info.MarshalFrom.Add((getTarget, getValue) => new AssignAction
                                {
                                    TargetExpression = getTarget(source.Name),
                                    Type = AssignActionType.Assign,
                                    ValueExpression = NewValueTuple(Enumerable.Range(0, count).Select(x => Index(getValue(source.Name), Literal(x))).ToArray())
                                });

                                for (int index = 0; index < count; index++)
                                {
                                    string valueFieldName = "Item" + (index + 1);
                                    int fieldIndex = index;

                                    info.MarshalTo.Add((getTarget, getValue) => new AssignAction
                                    {
                                        TargetExpression = Index(getTarget(source.Name), Literal(fieldIndex)),
                                        Type = AssignActionType.Assign,
                                        ValueExpression = Member(getValue(source.Name), valueFieldName)
                                    });
                                }
                            }
                            else
                            {
                                info.Public.Add(new TypedDefinition
                                {
                                    Name = source.Name,
                                    Comment = this.commentGenerator.Lookup(context.VkName, source.VkName),
                                    Type = memberType + "[]"
                                });

                                info.MarshalFrom.Add((getTarget, getValue) => new AssignAction
                                {
                                    TargetExpression = getTarget(source.Name),
                                    ValueExpression = StaticCall("Interop.HeapUtil", "MarshalFrom", getValue(source.Name), AsIs(length))
                                });

                                info.MarshalTo.Add((getTarget, getValue) => new AssignAction
                                {
                                    TargetExpression = getTarget(source.Name),
                                    ValueExpression = getValue(source.Name),
                                    Type = AssignActionType.FixedLengthMarshalTo,
                                    LengthExpression = AsIs(length)
                                });
                            }
                            break;
                    }
                }
                else
                {
                    var elementType = source.Type.Deref();

                    var marshalling = this.marshallingRules.ApplyFirst(elementType);

                    int count = 1;

                    if (source.Type.FixedLength.Type == FixedLengthType.IntegerLiteral)
                    {
                        count = int.Parse(source.Type.FixedLength.Value);
                    }
                    else
                    {
                        var constant = this.constantsLookup[source.Type.FixedLength.Value];

                        count = int.Parse(constant.Value);
                    }

                    info.InteropFullType = interopType;

                    info.Interop = new TypedDefinition
                    {
                        Name = name,
                        Type = interopType,
                        Repeats = count
                    };

                    if (count > 8)
                    {
                        info.Public.Add(new TypedDefinition
                        {
                            Name = name,
                            Comment = this.commentGenerator.Lookup(context.VkName, source.VkName),
                            Type = memberType + "[]"
                        });

                        string countMemberName = source.Name.TrimEnd('s') + "Count";

                        info.MarshalFrom.Add((getTarget, getValue) => new AssignAction
                        {
                            TargetExpression = getTarget(source.Name),
                            MemberType = memberType,
                            IsLoop = true,
                            IsArray = true,
                            IndexName = "index",
                            Type = marshalling.MarshalFromActionType,
                            NullCheckExpression = IsNotEqual(getValue(countMemberName), Literal(0)),
                            LengthExpression = getValue(countMemberName),
                            ValueExpression = marshalling.BuildMarshalFromValueExpression(Index(Brackets(AddressOf(Brackets(getValue(source.Name + "_0")))), Variable("index")), context.GetHandle)
                        });

                        info.MarshalTo.Add((getTarget, getValue) =>
                        {
                            var marshalToAction = new OptionalAction
                            {
                                CheckExpression = LogicalAnd(IsNotEqual(getValue(source.Name), Null), GreaterThanEqualTo(Member(getValue(source.Name), "Length"), Literal(count)))
                            };

                            for (int index = 0; index < count; index++)
                            {
                                string targetFieldName = source.Name + "_" + index;
                                int valueIndex = index;

                                marshalToAction.Actions.Add(new AssignAction
                                {
                                    TargetExpression = getTarget(targetFieldName),
                                    Type = marshalling.MarshalToActionType,
                                    ValueExpression = marshalling.BuildMarshalToValueExpression(Index(getValue(source.Name), Literal(valueIndex)), context.GetHandle)
                                });
                            }

                            return marshalToAction;
                        });
                    }
                    else
                    {
                        info.Public.Add(new TypedDefinition
                        {
                            Name = name,
                            Comment = this.commentGenerator.Lookup(context.VkName, source.VkName),
                            Type = "(" + string.Join(", ", Enumerable.Repeat(memberType, count)) + ")"
                        });

                        info.MarshalFrom.Add((getTarget, getValue) => new AssignAction
                        {
                            TargetExpression = getTarget(source.Name),
                            Type = AssignActionType.Assign,
                            ValueExpression = NewValueTuple(Enumerable.Range(0, count).Select(x => getValue(source.Name + "_" + x)).ToArray())
                        });

                        for (int index = 0; index < count; index++)
                        {
                            string targetFieldName = source.Name + "_" + index;
                            string valueFieldName = "Item" + (index + 1);

                            info.MarshalTo.Add((getTarget, getValue) => new AssignAction
                            {
                                TargetExpression = getTarget(targetFieldName),
                                Type = marshalling.MarshalToActionType,
                                ValueExpression = marshalling.BuildMarshalToValueExpression(Member(getValue(source.Name), valueFieldName), context.GetHandle)
                            });
                        }
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
