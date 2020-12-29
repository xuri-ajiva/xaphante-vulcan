using System.Runtime.InteropServices;

namespace SharpVk.Intel
{
    /// <summary>
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public unsafe struct PerformanceValueData
    {
        /// <summary>
        /// </summary>
        [FieldOffset(0)] public Bool32 ValueBool;

        /// <summary>
        /// </summary>
        [FieldOffset(0)] public float ValueFloat;

        /// <summary>
        /// </summary>
        [FieldOffset(0)] public uint Value32;

        /// <summary>
        /// </summary>
        [FieldOffset(0)] public ulong Value64;

        /// <summary>
        /// </summary>
        [FieldOffset(0)] public char* ValueString;
    }
}