using SharpVk.Emit;
using SharpVk.Generator.Collation;
using System;
using System.Collections.Generic;

using static SharpVk.Emit.ExpressionBuilder;

namespace SharpVk.Generator.Generation.Marshalling
{
    public class MarshalStructValue
        : IMarshalValueRule
    {
        private readonly Dictionary<string, TypeDeclaration> typeData;
        private readonly NameLookup nameLookup;

        public MarshalStructValue(NameLookup nameLookup, Dictionary<string, TypeDeclaration> typeData)
        {
            this.nameLookup = nameLookup;
            this.typeData = typeData;
        }

        public bool Apply(TypeReference type, out MarshalInfo info)
        {
            var typePattern = this.typeData[type.VkName].Pattern;

            if (typePattern == TypePattern.MarshalledStruct)
            {
                AssignActionType toAction = type.PointerType.IsPointer()
                                                ? AssignActionType.MarshalTo
                                                : AssignActionType.MarshalToAddressOf;

                AssignActionType fromAction = type.PointerType.IsPointer()
                                                    ? AssignActionType.MarshalFrom
                                                    : AssignActionType.MarshalFromAddressOf;

                info = new MarshalInfo
                {
                    MemberType = this.nameLookup.Lookup(type, false),
                    InteropType = this.nameLookup.Lookup(type, true, false),
                    MarshalToActionType = toAction,
                    MarshalFromActionType = fromAction,
                    BuildMarshalToValueExpression = (value, getHandle) => value,
                    BuildMarshalFromValueExpression = (value, getHandle) => value
                };

                return true;
            }
            else
            {
                info = new MarshalInfo();

                return false;
            }
        }
    }
}
