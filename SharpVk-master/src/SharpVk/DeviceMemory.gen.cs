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
    ///     Opaque handle to a device memory object.
    /// </summary>
    public class DeviceMemory
    {
        internal readonly CommandCache CommandCache;
        internal readonly Interop.DeviceMemory Handle;

        internal readonly Device Parent;

        internal DeviceMemory(Device parent, Interop.DeviceMemory handle)
        {
            this.Handle = handle;
            this.Parent = parent;
            CommandCache = parent.CommandCache;
        }

        /// <summary>
        ///     The raw handle for this instance.
        /// </summary>
        public Interop.DeviceMemory RawHandle => Handle;

        /// <summary>
        ///     Free GPU memory.
        /// </summary>
        /// <param name="allocator">
        ///     An optional AllocationCallbacks instance that controls host memory
        ///     allocation.
        /// </param>
        public unsafe void Free(AllocationCallbacks? allocator = default)
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
                var commandDelegate = CommandCache.Cache.VkFreeMemory;
                commandDelegate(Parent.Handle, Handle, marshalledAllocator);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Map a memory object into application address space.
        /// </summary>
        /// <param name="offset">
        /// </param>
        /// <param name="size">
        /// </param>
        /// <param name="flags">
        /// </param>
        public unsafe IntPtr Map(ulong offset, ulong size, MemoryMapFlags? flags = default)
        {
            try
            {
                var result = default(IntPtr);
                var marshalledFlags = default(MemoryMapFlags);
                var marshalledData = default(void*);
                if (flags != null)
                    marshalledFlags = flags.Value;
                else
                    marshalledFlags = default;
                var commandDelegate = CommandCache.Cache.VkMapMemory;
                var methodResult = commandDelegate(Parent.Handle, Handle, offset, size, marshalledFlags, &marshalledData);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                result = new(marshalledData);
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Unmap a previously mapped memory object.
        /// </summary>
        public void Unmap()
        {
            try
            {
                var commandDelegate = CommandCache.Cache.VkUnmapMemory;
                commandDelegate(Parent.Handle, Handle);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Query the current commitment for a DeviceMemory.
        /// </summary>
        public unsafe ulong GetCommitment()
        {
            try
            {
                var result = default(ulong);
                var marshalledCommittedMemoryInBytes = default(ulong);
                var commandDelegate = CommandCache.Cache.VkGetDeviceMemoryCommitment;
                commandDelegate(Parent.Handle, Handle, &marshalledCommittedMemoryInBytes);
                result = marshalledCommittedMemoryInBytes;
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }
    }
}
