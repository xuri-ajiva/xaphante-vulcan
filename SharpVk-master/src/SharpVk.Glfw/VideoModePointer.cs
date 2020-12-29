using System;
using System.Runtime.InteropServices;

namespace SharpVk.Glfw
{
    /// <summary>
    ///     Wraps a pointer to a VideoMode struct.
    /// </summary>
    public struct VideoModePointer
    {
        internal VideoModePointer(IntPtr pointer)
        {
            RawPointer = pointer;
        }

        /// <summary>
        ///     Gets the VideoMode value at the referenced memory location.
        /// </summary>
        public VideoMode Value => IsNull ? throw new NullReferenceException() : Marshal.PtrToStructure<VideoMode>(RawPointer);

        /// <summary>
        ///     Gets a value indicating whether the pointer wrapped by this
        ///     instance is null.
        /// </summary>
        public bool IsNull => RawPointer == IntPtr.Zero;

        /// <summary>
        ///     The underlying pointer wrapped by this instance.
        /// </summary>
        public IntPtr RawPointer { get; }
    }
}