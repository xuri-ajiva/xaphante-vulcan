using SharpVk.Emit;
using System;

namespace SharpVk.Generator.Generation.Marshalling
{
    public class MarshalSimpleValue
        : IMarshalValueRule
    {
        private readonly NameLookup nameLookup;

        public MarshalSimpleValue(NameLookup nameLookup)
        {
            this.nameLookup = nameLookup;
        }

        public bool Apply(TypeReference type, out MarshalInfo info)
        {
            info = new MarshalInfo
            {
                MemberType = this.nameLookup.Lookup(type, false),
                InteropType = this.nameLookup.Lookup(type, true),
                BuildMarshalToValueExpression = (value, getHandle) => value,
                BuildMarshalFromValueExpression = (value, getHandle) => value
            };

            return true;
        }
    }
}
