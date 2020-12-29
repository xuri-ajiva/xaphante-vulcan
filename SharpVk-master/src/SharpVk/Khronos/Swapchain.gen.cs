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

namespace SharpVk.Khronos
{
    /// <summary>
    /// </summary>
    public class Swapchain
        : IDisposable
    {
        internal readonly CommandCache commandCache;
        internal readonly Interop.Khronos.Swapchain handle;

        internal readonly Device parent;

        internal Swapchain(Device parent, Interop.Khronos.Swapchain handle)
        {
            this.handle = handle;
            this.parent = parent;
            commandCache = parent.commandCache;
        }

        /// <summary>
        ///     The raw handle for this instance.
        /// </summary>
        public Interop.Khronos.Swapchain RawHandle => handle;

        /// <summary>
        ///     Destroys the handles and releases any unmanaged resources
        ///     associated with it.
        /// </summary>
        public void Dispose()
        {
            Destroy();
        }

        /// <summary>
        ///     Destroy a swapchain object.
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
                var commandDelegate = commandCache.Cache.vkDestroySwapchainKHR;
                commandDelegate(parent.handle, handle, marshalledAllocator);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Obtain the array of presentable images associated with a swapchain.
        /// </summary>
        public unsafe Image[] GetImages()
        {
            try
            {
                var result = default(Image[]);
                var marshalledSwapchainImageCount = default(uint);
                var marshalledSwapchainImages = default(Interop.Image*);
                var commandDelegate = commandCache.Cache.vkGetSwapchainImagesKHR;
                var methodResult = commandDelegate(parent.handle, handle, &marshalledSwapchainImageCount, marshalledSwapchainImages);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                marshalledSwapchainImages = (Interop.Image*)HeapUtil.Allocate<Interop.Image>(marshalledSwapchainImageCount);
                commandDelegate(parent.handle, handle, &marshalledSwapchainImageCount, marshalledSwapchainImages);
                if (marshalledSwapchainImages != null)
                {
                    var fieldPointer = new Image[marshalledSwapchainImageCount];
                    for (var index = 0; index < marshalledSwapchainImageCount; index++) fieldPointer[index] = new(parent, marshalledSwapchainImages[index]);
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
        ///     Retrieve the index of the next available presentable image.
        /// </summary>
        /// <param name="timeout">
        ///     Indicates how long the function waits, in nanoseconds, if no image
        ///     is available.
        /// </param>
        /// <param name="semaphore">
        ///     Null or a semaphore to signal.
        /// </param>
        /// <param name="fence">
        ///     Null or a fence to signal.
        /// </param>
        public unsafe uint AcquireNextImage(ulong timeout, Semaphore semaphore, Fence fence)
        {
            try
            {
                var result = default(uint);
                var marshalledImageIndex = default(uint);
                var commandDelegate = commandCache.Cache.vkAcquireNextImageKHR;
                var methodResult = commandDelegate(parent.handle, handle, timeout, semaphore?.handle ?? default(Interop.Semaphore), fence?.handle ?? default(Interop.Fence), &marshalledImageIndex);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                result = marshalledImageIndex;
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        /// </summary>
        public Result GetStatus()
        {
            try
            {
                var result = default(Result);
                var commandDelegate = commandCache.Cache.vkGetSwapchainStatusKHR;
                result = commandDelegate(parent.handle, handle);
                if (SharpVkException.IsError(result)) throw SharpVkException.Create(result);
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }
    }
}