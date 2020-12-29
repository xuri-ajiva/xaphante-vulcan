using SharpVk.Generator.Collation;
using System.Collections.Generic;

using static SharpVk.Emit.ExpressionBuilder;

namespace SharpVk.Generator.Generation.Marshalling
{
    public class MarshalDelegateValue
        : IMarshalValueRule
    {
        private readonly Dictionary<string, TypeDeclaration> typeData;
        private readonly NameLookup nameLookup;

        public MarshalDelegateValue(NameLookup nameLookup, Dictionary<string, TypeDeclaration> typeData)
        {
            this.nameLookup = nameLookup;
            this.typeData = typeData;
        }

        public bool Apply(TypeReference type, out MarshalInfo info)
        {
            var typePattern = this.typeData[type.VkName].Pattern;

            if (typePattern == TypePattern.Delegate)
            {
                info = new MarshalInfo
                {
                    MemberType = this.nameLookup.Lookup(type, false),
                    InteropType = "IntPtr",
                    MarshalToActionType = AssignActionType.Assign,
                    BuildMarshalToValueExpression = (value, getHandle) => StaticCall("System.Runtime.InteropServices.Marshal", "GetFunctionPointerForDelegate", value),
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
