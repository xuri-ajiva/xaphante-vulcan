using SharpVk.Emit;
using SharpVk.Generator.Collation;
using System;
using System.Collections.Generic;
using static SharpVk.Emit.ExpressionBuilder;

namespace SharpVk.Generator.Generation.Marshalling
{
    public class NextExtensionMemberPattern
        : IMemberPatternRule
    {
        private readonly NameLookup nameLookup;

        public NextExtensionMemberPattern(NameLookup nameLookup)
        {
            this.nameLookup = nameLookup;
        }

        public bool Apply(IEnumerable<ITypedDeclaration> others, ITypedDeclaration source, MemberPatternContext context, MemberPatternInfo info)
        {
            if (source.Name == "Next")
            {
                if (context.IsMethod)
                {
                    var variableName = (context.VkName + "NextPointer").FirstToLower();

                    info.MarshalTo.Add((getTarget, getValue) => new DeclarationAction
                    {
                        MemberType = "void*",
                        MemberName = variableName
                    });

                    info.MarshalTo.Add((getTarget, getValue) => new AssignAction
                    {
                        ValueExpression = Variable(variableName),
                        TargetExpression = getTarget(source.Name)
                    });
                }
                else
                {
                    info.MarshalTo.Add((getTarget, getValue) => new AssignAction
                    {
                        ValueExpression = Null,
                        TargetExpression = getTarget(source.Name)
                    });
                }

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
