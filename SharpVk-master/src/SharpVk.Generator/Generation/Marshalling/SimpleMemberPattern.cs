using SharpVk.Generator.Collation;
using SharpVk.Generator.Rules;
using System.Collections.Generic;

using static SharpVk.Emit.ExpressionBuilder;

namespace SharpVk.Generator.Generation.Marshalling
{
    public class SimpleMemberPattern
        : IMemberPatternRule
    {
        private readonly IEnumerable<IMarshalValueRule> marshallingRules;
        private readonly NameLookup nameLookup;
        private readonly Dictionary<string, TypeDeclaration> typeData;
        private readonly CommentGenerator commentGenerator;

        public SimpleMemberPattern(IEnumerable<IMarshalValueRule> marshallingRules, NameLookup nameLookup, Dictionary<string, TypeDeclaration> typeData, CommentGenerator commentGenerator)
        {
            this.marshallingRules = marshallingRules;
            this.nameLookup = nameLookup;
            this.typeData = typeData;
            this.commentGenerator = commentGenerator;
        }

        public bool Apply(IEnumerable<ITypedDeclaration> others, ITypedDeclaration source, MemberPatternContext context, MemberPatternInfo info)
        {
            var marshalling = this.marshallingRules.ApplyFirst(source.Type);

            bool isOptional = source.IsOptional && this.typeData[source.Type.VkName].Pattern != TypePattern.Delegate
                                                    && this.typeData[source.Type.VkName].Pattern != TypePattern.Handle;

            string memberType = marshalling.MemberType + (isOptional ? "?" : "");

            info.Public.Add(new TypedDefinition
            {
                Name = source.Name,
                Comment = this.commentGenerator.Lookup(context.VkName, source.VkName),
                Type = memberType,
                DefaultValue = isOptional ? Default(memberType) : null
            });

            string typeName = this.nameLookup.Lookup(source.Type, true);

            info.Interop = new TypedDefinition
            {
                Name = source.Name,
                Type = typeName
            };

            info.InteropFullType = marshalling.InteropType;

            if (marshalling.HandleType != null)
            {
                info.HandleLookup.Add((marshalling.HandleType, getValue => getValue(source.Name)));
            }

            if (source.Type.PointerType.IsPointer())
            {
                info.InteropFullType += new string('*', source.Type.PointerType.GetPointerCount());
            }

            info.MarshalTo.Add((getTarget, getValue) =>
            {
                var valueExpression = isOptional
                                        ? marshalling.BuildMarshalToValueExpression(Member(getValue(source.Name), "Value"), context.GetHandle)
                                        : marshalling.BuildMarshalToValueExpression(getValue(source.Name), context.GetHandle);
                var assignment = new AssignAction
                {
                    ValueExpression = valueExpression,
                    TargetExpression = getTarget(source.Name),
                    MemberType = marshalling.InteropType,
                    Type = marshalling.MarshalToActionType
                };

                if (isOptional)
                {
                    var result = new OptionalAction
                    {
                        CheckExpression = IsNotEqual(getValue(source.Name), Null)
                    };

                    result.Actions.Add(assignment);
                    result.ElseActions.Add(new AssignAction
                    {
                        Type = AssignActionType.Assign,
                        TargetExpression = getTarget(source.Name),
                        ValueExpression = Default(info.InteropFullType)
                    });

                    return result;
                }
                else
                {
                    return assignment;
                }
            });

            bool optionalMarshalFrom = isOptional && source.Type.PointerType != PointerType.Value;

            info.MarshalFrom.Add((getTarget, getValue) =>
            {
                var valueExpression = marshalling.BuildMarshalFromValueExpression(getValue(source.Name), context.GetHandle);

                var assignment = new AssignAction
                {
                    ValueExpression = valueExpression,
                    TargetExpression = getTarget(source.Name),
                    MemberType = marshalling.MemberType,
                    Type = marshalling.MarshalFromActionType
                };

                if (optionalMarshalFrom)
                {
                    var result = new OptionalAction
                    {
                        CheckExpression = IsNotEqual(getValue(source.Name), Null)
                    };

                    result.Actions.Add(assignment);
                    result.ElseActions.Add(new AssignAction
                    {
                        Type = AssignActionType.Assign,
                        TargetExpression = getTarget(source.Name),
                        ValueExpression = Null
                    });

                    return result;
                }
                else
                {
                    return assignment;
                }
            });

            return true;
        }
    }
}
