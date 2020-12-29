using System;

namespace SharpVk.Glfw
{
    /// <summary>
    ///     Opaque monitor handle.
    /// </summary>
    public struct MonitorHandle
    {
        internal MonitorHandle(IntPtr handle)
        {
            RawHandle = handle;
        }

        /// <summary>
        ///     Gets the underlying native pointer to the monitor object.
        /// </summary>
        public IntPtr RawHandle { get; }

        /// <summary>
        ///     A read-only field that represents a MonitorHandle that has been
        ///     inititalised to zero.
        /// </summary>
        public static readonly MonitorHandle Zero = new MonitorHandle(IntPtr.Zero);
    }
}