using System;
using System.Runtime.InteropServices;

namespace SharpVk.Glfw
{
    /// <summary>
    ///     Wraps a pointer to a native, null-terminated ANSI string.
    /// </summary>
    public struct NativeString
    {
        internal NativeString(IntPtr pointer)
        {
            RawPointer = pointer;
        }

        /// <summary>
        ///     Gets the marshalled string value for this native string.
        /// </summary>
        public string Value
        {
            get
            {
                if (IsNull) throw new NullReferenceException();

                return Marshal.PtrToStringAnsi(RawPointer);
            }
        }

        /// <summary>
        ///     Gets a value indicating whether the pointer wrapped by this
        ///     instance is null.
        /// </summary>
        public bool IsNull => RawPointer == IntPtr.Zero;

        /// <summary>
        ///     The underlying pointer wrapped by this instance.
        /// </summary>
        public IntPtr RawPointer { get; }

        public override string ToString()
        {
            return Value;
        }
    }
}