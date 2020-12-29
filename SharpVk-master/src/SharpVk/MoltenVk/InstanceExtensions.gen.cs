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
using SharpVk.Khronos;

namespace SharpVk.MoltenVk
{
    /// <summary>
    /// </summary>
    public static class InstanceExtensions
    {
        /// <summary>
        ///     Create a SurfaceKHR object for an iOS UIView.
        /// </summary>
        /// <param name="extendedHandle">
        ///     The Instance handle to extend.
        /// </param>
        /// <param name="flags">
        ///     Reserved for future use.
        /// </param>
        /// <param name="view">
        ///     A reference to a UIView object which will display this surface.
        ///     This UIView must be backed by a CALayer instance of type
        ///     CAMetalLayer.
        /// </param>
        /// <param name="allocator">
        ///     An optional AllocationCallbacks instance that controls host memory
        ///     allocation.
        /// </param>
        public static unsafe Surface CreateIosSurface(this Instance extendedHandle, IntPtr view, IosSurfaceCreateFlags? flags = default, AllocationCallbacks? allocator = default)
        {
            try
            {
                var result = default(Surface);
                var commandCache = default(CommandCache);
                var marshalledCreateInfo = default(Interop.MoltenVk.IosSurfaceCreateInfo*);
                var vkIosSurfaceCreateInfoMvkNextPointer = default(void*);
                var marshalledAllocator = default(Interop.AllocationCallbacks*);
                var marshalledSurface = default(Interop.Khronos.Surface);
                commandCache = extendedHandle.CommandCache;
                marshalledCreateInfo = (Interop.MoltenVk.IosSurfaceCreateInfo*)HeapUtil.Allocate<Interop.MoltenVk.IosSurfaceCreateInfo>();
                marshalledCreateInfo->SType = StructureType.IosSurfaceCreateInfo;
                marshalledCreateInfo->Next = vkIosSurfaceCreateInfoMvkNextPointer;
                if (flags != null)
                    marshalledCreateInfo->Flags = flags.Value;
                else
                    marshalledCreateInfo->Flags = default;
                marshalledCreateInfo->View = view.ToPointer();
                if (allocator != null)
                {
                    marshalledAllocator = (Interop.AllocationCallbacks*)HeapUtil.Allocate<Interop.AllocationCallbacks>();
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default;
                }
                var commandDelegate = commandCache.Cache.VkCreateIosSurfaceMvk;
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

        /// <summary>
        ///     Create a SurfaceKHR object for a macOS NSView.
        /// </summary>
        /// <param name="extendedHandle">
        ///     The Instance handle to extend.
        /// </param>
        /// <param name="flags">
        ///     Reserved for future use.
        /// </param>
        /// <param name="view">
        ///     A reference to a NSView object which will display this surface.
        ///     This NSView must be backed by a CALayer instance of type
        ///     CAMetalLayer.
        /// </param>
        /// <param name="allocator">
        ///     An optional AllocationCallbacks instance that controls host memory
        ///     allocation.
        /// </param>
        public static unsafe Surface CreateMacOsSurface(this Instance extendedHandle, IntPtr view, MacOsSurfaceCreateFlags? flags = default, AllocationCallbacks? allocator = default)
        {
            try
            {
                var result = default(Surface);
                var commandCache = default(CommandCache);
                var marshalledCreateInfo = default(Interop.MoltenVk.MacOsSurfaceCreateInfo*);
                var vkMacOsSurfaceCreateInfoMvkNextPointer = default(void*);
                var marshalledAllocator = default(Interop.AllocationCallbacks*);
                var marshalledSurface = default(Interop.Khronos.Surface);
                commandCache = extendedHandle.CommandCache;
                marshalledCreateInfo = (Interop.MoltenVk.MacOsSurfaceCreateInfo*)HeapUtil.Allocate<Interop.MoltenVk.MacOsSurfaceCreateInfo>();
                marshalledCreateInfo->SType = StructureType.MacosSurfaceCreateInfo;
                marshalledCreateInfo->Next = vkMacOsSurfaceCreateInfoMvkNextPointer;
                if (flags != null)
                    marshalledCreateInfo->Flags = flags.Value;
                else
                    marshalledCreateInfo->Flags = default;
                marshalledCreateInfo->View = view.ToPointer();
                if (allocator != null)
                {
                    marshalledAllocator = (Interop.AllocationCallbacks*)HeapUtil.Allocate<Interop.AllocationCallbacks>();
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default;
                }
                var commandDelegate = commandCache.Cache.VkCreateMacOsSurfaceMvk;
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
