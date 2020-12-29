using SharpVk.Interop;

namespace SharpVk.Multivendor
{
    public partial struct DebugUtilsObjectNameInfo
    {
        /// <summary>
        /// </summary>
        internal static unsafe DebugUtilsObjectNameInfo MarshalFrom(Interop.Multivendor.DebugUtilsObjectNameInfo* pointer)
        {
            var result = default(DebugUtilsObjectNameInfo);
            result.ObjectType = pointer->ObjectType;
            result.ObjectHandle = pointer->ObjectHandle;
            result.ObjectName = HeapUtil.MarshalStringFrom(pointer->ObjectName);
            return result;
        }
    }
}