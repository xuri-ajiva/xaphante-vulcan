using static SharpVk.Emit.ExpressionBuilder;

namespace SharpVk.Generator.Generation.Marshalling
{
    public class MarshalVoidPointerValue
        : IMarshalValueRule
    {
        public bool Apply(TypeReference type, out MarshalInfo info)
        {
            if (type.VkName == "void" && type.PointerType.IsPointer())
            {
                info = new MarshalInfo
                {
                    MemberType = "IntPtr",
                    InteropType = "void",
                    MarshalToActionType = AssignActionType.Assign,
                    BuildMarshalToValueExpression = (value, getHandle) => Call(value, "ToPointer"),
                    BuildMarshalFromValueExpression = (value, getHandle) => New("IntPtr", value)
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
