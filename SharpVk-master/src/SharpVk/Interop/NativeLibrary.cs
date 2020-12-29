using System;
using System.Runtime.InteropServices;

namespace SharpVk.Interop
{
    /// <summary>
    /// </summary>
    public class NativeLibrary
        : IProcLookup
    {
        private readonly IntPtr library;

        /// <summary>
        /// </summary>
        public NativeLibrary()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                library = Kernel32.LoadLibrary("vulkan-1.dll");
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                library = LibDl.dlopen("libvulkan.so.1", LibDl.RtldNow);

                if (library == IntPtr.Zero) library = LibDl.dlopen("libvulkan.so", LibDl.RtldNow);
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                library = LibDlOSX.dlopen("libvulkan.dylib.1", LibDlOSX.RtldNow);

                if (library == IntPtr.Zero) library = LibDlOSX.dlopen("libvulkan.dylib", LibDlOSX.RtldNow);
            }
            else
            {
                throw new NotSupportedException($"{RuntimeInformation.OSDescription} is not a supported platform for SharpVK.");
            }
        }

        /// <summary>
        ///     Gets a function pointer for the specificed Vulkan command.
        /// </summary>
        /// <param name="name">
        ///     The name of the command.
        /// </param>
        /// <returns>
        ///     A function pointer to the native procedure call.
        /// </returns>
        public IntPtr GetProcedureAddress(string name)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                return Kernel32.GetProcAddress(library, name);
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                return LibDl.dlsym(library, name);
            if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                return LibDlOSX.dlsym(library, name);
            throw new NotSupportedException($"{RuntimeInformation.OSDescription} is not a supported platform for SharpVK.");
        }

        private static class Kernel32
        {
            [DllImport("kernel32")]
            public static extern IntPtr LoadLibrary(string fileName);

            [DllImport("kernel32")]
            public static extern IntPtr GetProcAddress(IntPtr module, string procName);
        }

        private static class LibDl
        {
            public const int RtldNow = 2;

            [DllImport("libdl.so")]
            public static extern IntPtr dlopen(string fileName, int flags);

            [DllImport("libdl.so")]
            public static extern IntPtr dlsym(IntPtr handle, string name);
        }

        private static class LibDlOSX
        {
            public const int RtldNow = 2;

            [DllImport("libdl.dylib")]
            public static extern IntPtr dlopen(string fileName, int flags);

            [DllImport("libdl.dylib")]
            public static extern IntPtr dlsym(IntPtr handle, string name);
        }
    }
}