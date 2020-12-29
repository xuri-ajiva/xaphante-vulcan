using System;

namespace SharpVk.Glfw
{
    /// <summary>
    ///     Opaque window handle.
    /// </summary>
    public struct WindowHandle
    {
        internal WindowHandle(IntPtr handle)
        {
            RawHandle = handle;
        }

        /// <summary>
        ///     Gets the underlying native pointer to the window object.
        /// </summary>
        public IntPtr RawHandle { get; }

        /// <summary>
        ///     A read-only field that represents a WindowHandle that has been
        ///     inititalised to zero.
        /// </summary>
        public static readonly WindowHandle Zero = new WindowHandle(IntPtr.Zero);
    }
}