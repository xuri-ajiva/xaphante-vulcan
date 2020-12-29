// The MIT License (MIT)
// 
// Copyright (c) Andrew Armstrong/FacticiusVir 2020
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

// This file was automatically generated and should not be edited directly.

using System;
using SharpVk.Interop;

namespace SharpVk
{
    /// <summary>
    ///     Buffers represent linear arrays of data which are used for various
    ///     purposes by binding them to a graphics or compute pipeline via
    ///     descriptor sets or via certain commands, or by directly specifying them
    ///     as parameters to certain commands.
    /// </summary>
    public partial class Buffer
        : IDisposable
    {
        internal readonly CommandCache commandCache;
        internal readonly Interop.Buffer handle;

        internal readonly Device parent;

        internal Buffer(Device parent, Interop.Buffer handle)
        {
            this.handle = handle;
            this.parent = parent;
            commandCache = parent.commandCache;
        }

        /// <summary>
        ///     The raw handle for this instance.
        /// </summary>
        public Interop.Buffer RawHandle => handle;

        /// <summary>
        ///     Bind device memory to a buffer object.
        /// </summary>
        /// <param name="memory">
        /// </param>
        /// <param name="memoryOffset">
        /// </param>
        public void BindMemory(DeviceMemory memory, ulong memoryOffset)
        {
            try
            {
                var commandDelegate = commandCache.Cache.vkBindBufferMemory;
                var methodResult = commandDelegate(parent.handle, handle, memory?.handle ?? default(Interop.DeviceMemory), memoryOffset);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Returns the memory requirements for specified Vulkan object.
        /// </summary>
        public unsafe MemoryRequirements GetMemoryRequirements()
        {
            try
            {
                var result = default(MemoryRequirements);
                var marshalledMemoryRequirements = default(MemoryRequirements);
                var commandDelegate = commandCache.Cache.vkGetBufferMemoryRequirements;
                commandDelegate(parent.handle, handle, &marshalledMemoryRequirements);
                result = marshalledMemoryRequirements;
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Destroys the handles and releases any unmanaged resources
        ///     associated with it.
        /// </summary>
        public void Dispose()
        {
            Destroy();
        }

        /// <summary>
        ///     Destroy a buffer object.
        /// </summary>
        /// <param name="allocator">
        ///     An optional AllocationCallbacks instance that controls host memory
        ///     allocation.
        /// </param>
        public unsafe void Destroy(AllocationCallbacks? allocator = default)
        {
            try
            {
                var marshalledAllocator = default(Interop.AllocationCallbacks*);
                if (allocator != null)
                {
                    marshalledAllocator = (Interop.AllocationCallbacks*)HeapUtil.Allocate<Interop.AllocationCallbacks>();
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default;
                }
                var commandDelegate = commandCache.Cache.vkDestroyBuffer;
                commandDelegate(parent.handle, handle, marshalledAllocator);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }
    }
}