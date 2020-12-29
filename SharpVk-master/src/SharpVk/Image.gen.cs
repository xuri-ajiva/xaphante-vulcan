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
    ///     Opaque handle to a image object.
    /// </summary>
    public partial class Image
        : IDisposable
    {
        internal readonly CommandCache commandCache;
        internal readonly Interop.Image handle;

        internal readonly Device parent;

        internal Image(Device parent, Interop.Image handle)
        {
            this.handle = handle;
            this.parent = parent;
            commandCache = parent.commandCache;
        }

        /// <summary>
        ///     The raw handle for this instance.
        /// </summary>
        public Interop.Image RawHandle => handle;

        /// <summary>
        ///     Destroys the handles and releases any unmanaged resources
        ///     associated with it.
        /// </summary>
        public void Dispose()
        {
            Destroy();
        }

        /// <summary>
        ///     Bind device memory to an image object.
        /// </summary>
        /// <param name="memory">
        /// </param>
        /// <param name="memoryOffset">
        /// </param>
        public void BindMemory(DeviceMemory memory, ulong memoryOffset)
        {
            try
            {
                var commandDelegate = commandCache.Cache.vkBindImageMemory;
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
                var commandDelegate = commandCache.Cache.vkGetImageMemoryRequirements;
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
        ///     Query the memory requirements for a sparse image.
        /// </summary>
        public unsafe SparseImageMemoryRequirements[] GetSparseMemoryRequirements()
        {
            try
            {
                var result = default(SparseImageMemoryRequirements[]);
                var marshalledSparseMemoryRequirementCount = default(uint);
                var marshalledSparseMemoryRequirements = default(SparseImageMemoryRequirements*);
                var commandDelegate = commandCache.Cache.vkGetImageSparseMemoryRequirements;
                commandDelegate(parent.handle, handle, &marshalledSparseMemoryRequirementCount, marshalledSparseMemoryRequirements);
                marshalledSparseMemoryRequirements = (SparseImageMemoryRequirements*)HeapUtil.Allocate<SparseImageMemoryRequirements>(marshalledSparseMemoryRequirementCount);
                commandDelegate(parent.handle, handle, &marshalledSparseMemoryRequirementCount, marshalledSparseMemoryRequirements);
                if (marshalledSparseMemoryRequirements != null)
                {
                    var fieldPointer = new SparseImageMemoryRequirements[marshalledSparseMemoryRequirementCount];
                    for (var index = 0; index < marshalledSparseMemoryRequirementCount; index++) fieldPointer[index] = marshalledSparseMemoryRequirements[index];
                    result = fieldPointer;
                }
                else
                {
                    result = null;
                }
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Destroy an image object.
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
                var commandDelegate = commandCache.Cache.vkDestroyImage;
                commandDelegate(parent.handle, handle, marshalledAllocator);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Retrieve information about an image subresource.
        /// </summary>
        /// <param name="subresource">
        /// </param>
        public unsafe SubresourceLayout GetSubresourceLayout(ImageSubresource subresource)
        {
            try
            {
                var result = default(SubresourceLayout);
                var marshalledSubresource = default(ImageSubresource*);
                var marshalledLayout = default(SubresourceLayout);
                marshalledSubresource = (ImageSubresource*)HeapUtil.Allocate<ImageSubresource>();
                *marshalledSubresource = subresource;
                var commandDelegate = commandCache.Cache.vkGetImageSubresourceLayout;
                commandDelegate(parent.handle, handle, marshalledSubresource, &marshalledLayout);
                result = marshalledLayout;
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }
    }
}