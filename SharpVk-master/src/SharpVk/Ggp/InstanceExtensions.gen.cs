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

using SharpVk.Interop;
using SharpVk.Khronos;

namespace SharpVk.Ggp
{
    /// <summary>
    /// </summary>
    public static class InstanceExtensions
    {
        /// <summary>
        ///     Create a Surface object for a Google Games Platform stream
        /// </summary>
        /// <param name="extendedHandle">
        ///     The Instance handle to extend.
        /// </param>
        /// <param name="flags">
        /// </param>
        /// <param name="streamDescriptor">
        /// </param>
        /// <param name="allocator">
        ///     The allocator used for host memory allocated for the surface object
        ///     when there is no more specific allocator available.
        /// </param>
        public static unsafe Surface CreateStreamDescriptorSurface(this Instance extendedHandle, uint streamDescriptor, StreamDescriptorSurfaceCreateFlags? flags = default, AllocationCallbacks? allocator = default)
        {
            try
            {
                var result = default(Surface);
                var commandCache = default(CommandCache);
                var marshalledCreateInfo = default(Interop.Ggp.StreamDescriptorSurfaceCreateInfo*);
                var vkStreamDescriptorSurfaceCreateInfoGgpNextPointer = default(void*);
                var marshalledAllocator = default(Interop.AllocationCallbacks*);
                var marshalledSurface = default(Interop.Khronos.Surface);
                commandCache = extendedHandle.CommandCache;
                marshalledCreateInfo = (Interop.Ggp.StreamDescriptorSurfaceCreateInfo*)HeapUtil.Allocate<Interop.Ggp.StreamDescriptorSurfaceCreateInfo>();
                marshalledCreateInfo->SType = StructureType.StreamDescriptorSurfaceCreateInfo;
                marshalledCreateInfo->Next = vkStreamDescriptorSurfaceCreateInfoGgpNextPointer;
                if (flags != null)
                    marshalledCreateInfo->Flags = flags.Value;
                else
                    marshalledCreateInfo->Flags = default;
                marshalledCreateInfo->StreamDescriptor = streamDescriptor;
                if (allocator != null)
                {
                    marshalledAllocator = (Interop.AllocationCallbacks*)HeapUtil.Allocate<Interop.AllocationCallbacks>();
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default;
                }
                var commandDelegate = commandCache.Cache.VkCreateStreamDescriptorSurfaceGgp;
                var methodResult = commandDelegate(extendedHandle.Handle, marshalledCreateInfo, marshalledAllocator, &marshalledSurface);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                result = new(extendedHandle, marshalledSurface);
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }
    }
}
