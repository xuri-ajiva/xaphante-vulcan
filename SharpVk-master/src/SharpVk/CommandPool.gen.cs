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
    ///     Opaque handle to a command pool object.
    /// </summary>
    public class CommandPool
        : IDisposable
    {
        internal readonly CommandCache CommandCache;
        internal readonly Interop.CommandPool Handle;

        internal readonly Device Parent;

        internal CommandPool(Device parent, Interop.CommandPool handle)
        {
            this.Handle = handle;
            this.Parent = parent;
            CommandCache = parent.CommandCache;
        }

        /// <summary>
        ///     The raw handle for this instance.
        /// </summary>
        public Interop.CommandPool RawHandle => Handle;

        /// <summary>
        ///     Destroys the handles and releases any unmanaged resources
        ///     associated with it.
        /// </summary>
        public void Dispose()
        {
            Destroy();
        }

        /// <summary>
        ///     Destroy a command pool object.
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
                var commandDelegate = CommandCache.Cache.VkDestroyCommandPool;
                commandDelegate(Parent.Handle, Handle, marshalledAllocator);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Reset a command pool.
        /// </summary>
        /// <param name="flags">
        /// </param>
        public void Reset(CommandPoolResetFlags? flags = default)
        {
            try
            {
                var marshalledFlags = default(CommandPoolResetFlags);
                if (flags != null)
                    marshalledFlags = flags.Value;
                else
                    marshalledFlags = default;
                var commandDelegate = CommandCache.Cache.VkResetCommandPool;
                var methodResult = commandDelegate(Parent.Handle, Handle, marshalledFlags);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Free command buffers.
        /// </summary>
        /// <param name="commandBuffers">
        /// </param>
        public unsafe void FreeCommandBuffers(ArrayProxy<CommandBuffer>? commandBuffers)
        {
            try
            {
                var marshalledCommandBuffers = default(Interop.CommandBuffer*);
                if (commandBuffers.IsNull())
                {
                    marshalledCommandBuffers = null;
                }
                else
                {
                    if (commandBuffers.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCommandBuffers = (Interop.CommandBuffer*)HeapUtil.Allocate<Interop.CommandBuffer>();
                        *marshalledCommandBuffers = commandBuffers.Value.GetSingleValue()?.Handle ?? default(Interop.CommandBuffer);
                    }
                    else
                    {
                        var fieldPointer = (Interop.CommandBuffer*)HeapUtil.AllocateAndClear<Interop.CommandBuffer>(HeapUtil.GetLength(commandBuffers.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(commandBuffers.Value); index++) fieldPointer[index] = commandBuffers.Value[index]?.Handle ?? default(Interop.CommandBuffer);
                        marshalledCommandBuffers = fieldPointer;
                    }
                }
                var commandDelegate = CommandCache.Cache.VkFreeCommandBuffers;
                commandDelegate(Parent.Handle, Handle, HeapUtil.GetLength(commandBuffers), marshalledCommandBuffers);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="flags">
        /// </param>
        public void Trim(CommandPoolTrimFlags? flags = default)
        {
            try
            {
                var marshalledFlags = default(CommandPoolTrimFlags);
                if (flags != null)
                    marshalledFlags = flags.Value;
                else
                    marshalledFlags = default;
                var commandDelegate = CommandCache.Cache.VkTrimCommandPool;
                commandDelegate(Parent.Handle, Handle, marshalledFlags);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }
    }
}
