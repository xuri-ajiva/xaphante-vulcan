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

namespace SharpVk.Fuchsia
{
    /// <summary>
    /// </summary>
    public static class InstanceExtensions
    {
        /// <summary>
        /// </summary>
        /// <param name="extendedHandle">
        ///     The Instance handle to extend.
        /// </param>
        /// <param name="flags">
        /// </param>
        /// <param name="imagePipeHandle">
        /// </param>
        /// <param name="allocator">
        /// </param>
        public static unsafe Surface CreateImagePipeSurface(this Instance extendedHandle, uint imagePipeHandle, ImagePipeSurfaceCreateFlags? flags = default, AllocationCallbacks? allocator = default)
        {
            try
            {
                var result = default(Surface);
                var commandCache = default(CommandCache);
                var marshalledCreateInfo = default(Interop.Fuchsia.ImagePipeSurfaceCreateInfo*);
                var vkImagePipeSurfaceCreateInfoFUCHSIANextPointer = default(void*);
                var marshalledAllocator = default(Interop.AllocationCallbacks*);
                var marshalledSurface = default(Interop.Khronos.Surface);
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfo = (Interop.Fuchsia.ImagePipeSurfaceCreateInfo*)HeapUtil.Allocate<Interop.Fuchsia.ImagePipeSurfaceCreateInfo>();
                marshalledCreateInfo->SType = StructureType.ImagepipeSurfaceCreateInfo;
                marshalledCreateInfo->Next = vkImagePipeSurfaceCreateInfoFUCHSIANextPointer;
                if (flags != null)
                    marshalledCreateInfo->Flags = flags.Value;
                else
                    marshalledCreateInfo->Flags = default;
                marshalledCreateInfo->ImagePipeHandle = imagePipeHandle;
                if (allocator != null)
                {
                    marshalledAllocator = (Interop.AllocationCallbacks*)HeapUtil.Allocate<Interop.AllocationCallbacks>();
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default;
                }
                var commandDelegate = commandCache.Cache.vkCreateImagePipeSurfaceFUCHSIA;
                var methodResult = commandDelegate(extendedHandle.handle, marshalledCreateInfo, marshalledAllocator, &marshalledSurface);
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