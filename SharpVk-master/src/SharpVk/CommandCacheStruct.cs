using System;
using System.Runtime.InteropServices;

namespace SharpVk
{
    public partial struct CommandCacheStruct
    {
        private static T GetDelegate<T>(IntPtr functionPointer)
            where T : Delegate
        {
            if (functionPointer == IntPtr.Zero)
                return null;
            return Marshal.GetDelegateForFunctionPointer<T>(functionPointer);
        }
    }
}