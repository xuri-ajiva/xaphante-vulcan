using SharpVk.Emit;
using SharpVk.Generator.Collation;
using System;
using System.Collections.Generic;
using static SharpVk.Emit.ExpressionBuilder;

namespace SharpVk.Generator.Generation.Marshalling
{
    public class VersionMemberPattern
        : IMemberPatternRule
    {
        private readonly NameLookup nameLookup;
        private readonly CommentGenerator commentGenerator;

        public VersionMemberPattern(NameLookup nameLookup, CommentGenerator commentGenerator)
        {
            this.nameLookup = nameLookup;
            this.commentGenerator = commentGenerator;
        }

        public bool Apply(IEnumerable<ITypedDeclaration> others, ITypedDeclaration source, MemberPatternContext context, MemberPatternInfo info)
        {
            if (source.Name.EndsWith("Version") && source.Type.VkName.StartsWith("uint32"))
            {
                info.Public.Add(new TypedDefinition
                {
                    Name = source.Name,
                    Comment = this.commentGenerator.Lookup(context.VkName, source.VkName),
                    Type = "Version"
                });

                info.MarshalFrom.Add((getTarget, getValue) => new AssignAction
                {
                    ValueExpression = Cast("Version", getValue(source.Name)),
                    TargetExpression = getTarget(source.Name),
                });

                info.MarshalTo.Add((getTarget, getValue) => new AssignAction
                {
                    ValueExpression = Cast("uint", getValue(source.Name)),
                    TargetExpression = getTarget(source.Name),
                });

                string typeName = this.nameLookup.Lookup(source.Type, true);

                info.Interop = new TypedDefinition
                {
                    Name = source.Name,
                    Type = typeName
                };

                info.InteropFullType = typeName;

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
