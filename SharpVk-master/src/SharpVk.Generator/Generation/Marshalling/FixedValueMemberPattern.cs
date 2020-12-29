using SharpVk.Emit;
using SharpVk.Generator.Collation;
using System;
using System.Collections.Generic;

using static SharpVk.Emit.ExpressionBuilder;

namespace SharpVk.Generator.Generation.Marshalling
{
    public class FixedValueMemberPattern
        : IMemberPatternRule
    {
        private readonly NameLookup nameLookup;
        private readonly Dictionary<string, EnumMapping> enumLookup;

        public FixedValueMemberPattern(NameLookup nameLookup, Dictionary<string, EnumMapping> enumLookup)
        {
            this.nameLookup = nameLookup;
            this.enumLookup = enumLookup;
        }

        public bool Apply(IEnumerable<ITypedDeclaration> others, ITypedDeclaration source, MemberPatternContext context, MemberPatternInfo info)
        {
            if (source.FixedValue != null)
            {
                var enumInfo = this.enumLookup[source.FixedValue];
                var enumTypeName = this.nameLookup.Lookup(enumInfo.TypeVkName);

                info.MarshalTo.Add((getTarget, getValue) => new AssignAction
                {
                    ValueExpression = EnumField(enumTypeName, enumInfo.FieldName),
                    TargetExpression = getTarget(source.Name)
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
