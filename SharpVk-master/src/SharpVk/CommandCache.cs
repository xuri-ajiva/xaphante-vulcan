using System;
using System.Runtime.InteropServices;

namespace SharpVk
{
    /// <summary>
    /// </summary>
    public class CommandCache
    {
        private readonly IProcLookup host;
        private readonly CommandCache parent;
        private readonly string type;

        internal CommandCache(IProcLookup host, string type, CommandCache parent)
        {
            this.host = host;
            this.type = type;
            this.parent = parent;
            Cache = parent?.Cache ?? default;
        }

        /// <summary>
        ///     Creates a new instance of CommandCache using the given IProcLookup
        ///     instance to load unmanaged Vulkan function pointers.
        /// </summary>
        /// <param name="procLookup">
        ///     An implementation of IProcLookup that can load the core Vulkan
        ///     commands.
        /// </param>
        public CommandCache(IProcLookup procLookup)
            : this(procLookup, "", null)
        {
        }

        public CommandCacheStruct Cache { get; private set; }

        /// <summary>
        ///     Build cache of function pointers from IProcLookup host.
        /// </summary>
        public void Initialise()
        {
            Cache = new(this);
        }

        /// <summary>
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public bool IsCommandAvailable(string name, string type)
        {
            if (type != this.type)
            {
                if (parent != null)
                    return parent.IsCommandAvailable(name, type);
                return false;
            }

            return host.GetProcedureAddress(name) != IntPtr.Zero;
        }

        /// <summary>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public T GetCommandDelegate<T>(string name, string type)
        {
            if (type != this.type)
            {
                if (parent != null)
                    return parent.GetCommandDelegate<T>(name, type);
                return default;
            }

            var functionPointer = host.GetProcedureAddress(name);

            if (functionPointer == IntPtr.Zero)
                return default;
            return Marshal.GetDelegateForFunctionPointer<T>(functionPointer);
        }
    }
}