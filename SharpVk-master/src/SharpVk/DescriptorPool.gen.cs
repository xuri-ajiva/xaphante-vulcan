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
    ///     Opaque handle to a descriptor pool object.
    /// </summary>
    public partial class DescriptorPool
        : IDisposable
    {
        internal readonly CommandCache CommandCache;
        internal readonly Interop.DescriptorPool Handle;

        internal readonly Device Parent;

        internal DescriptorPool(Device parent, Interop.DescriptorPool handle)
        {
            this.Handle = handle;
            this.Parent = parent;
            CommandCache = parent.CommandCache;
        }

        /// <summary>
        ///     The raw handle for this instance.
        /// </summary>
        public Interop.DescriptorPool RawHandle => Handle;

        /// <summary>
        ///     Destroys the handles and releases any unmanaged resources
        ///     associated with it.
        /// </summary>
        public void Dispose()
        {
            Destroy();
        }

        /// <summary>
        ///     Destroy a descriptor pool object.
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
                var commandDelegate = CommandCache.Cache.VkDestroyDescriptorPool;
                commandDelegate(Parent.Handle, Handle, marshalledAllocator);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Resets a descriptor pool object.
        /// </summary>
        /// <param name="flags">
        /// </param>
        public void Reset(DescriptorPoolResetFlags? flags = default)
        {
            try
            {
                var marshalledFlags = default(DescriptorPoolResetFlags);
                if (flags != null)
                    marshalledFlags = flags.Value;
                else
                    marshalledFlags = default;
                var commandDelegate = CommandCache.Cache.VkResetDescriptorPool;
                var methodResult = commandDelegate(Parent.Handle, Handle, marshalledFlags);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Free one or more descriptor sets.
        /// </summary>
        /// <param name="descriptorSets">
        /// </param>
        public unsafe void FreeDescriptorSets(ArrayProxy<DescriptorSet>? descriptorSets)
        {
            try
            {
                var marshalledDescriptorSets = default(Interop.DescriptorSet*);
                if (descriptorSets.IsNull())
                {
                    marshalledDescriptorSets = null;
                }
                else
                {
                    if (descriptorSets.Value.Contents == ProxyContents.Single)
                    {
                        marshalledDescriptorSets = (Interop.DescriptorSet*)HeapUtil.Allocate<Interop.DescriptorSet>();
                        *marshalledDescriptorSets = descriptorSets.Value.GetSingleValue()?.Handle ?? default(Interop.DescriptorSet);
                    }
                    else
                    {
                        var fieldPointer = (Interop.DescriptorSet*)HeapUtil.AllocateAndClear<Interop.DescriptorSet>(HeapUtil.GetLength(descriptorSets.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(descriptorSets.Value); index++) fieldPointer[index] = descriptorSets.Value[index]?.Handle ?? default(Interop.DescriptorSet);
                        marshalledDescriptorSets = fieldPointer;
                    }
                }
                var commandDelegate = CommandCache.Cache.VkFreeDescriptorSets;
                var methodResult = commandDelegate(Parent.Handle, Handle, HeapUtil.GetLength(descriptorSets), marshalledDescriptorSets);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }
    }
}
