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

namespace SharpVk.Multivendor
{
    /// <summary>
    /// </summary>
    public static class SwapchainExtensions
    {
        /// <summary>
        ///     Query the current value of a surface counter.
        /// </summary>
        /// <param name="extendedHandle">
        ///     The Swapchain handle to extend.
        /// </param>
        /// <param name="counter">
        /// </param>
        public static unsafe ulong GetCounter(this Swapchain extendedHandle, SurfaceCounterFlags counter)
        {
            try
            {
                var result = default(ulong);
                var commandCache = default(CommandCache);
                var marshalledCounterValue = default(ulong);
                commandCache = extendedHandle.CommandCache;
                var commandDelegate = commandCache.Cache.VkGetSwapchainCounterExt;
                var methodResult = commandDelegate(extendedHandle.Parent.Handle, extendedHandle.Handle, counter, &marshalledCounterValue);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                result = marshalledCounterValue;
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Acquire full-screen exclusive mode for a swapchain
        /// </summary>
        /// <param name="extendedHandle">
        ///     The Swapchain handle to extend.
        /// </param>
        public static void AcquireFullScreenExclusiveMode(this Swapchain extendedHandle)
        {
            try
            {
                var commandCache = default(CommandCache);
                commandCache = extendedHandle.CommandCache;
                var commandDelegate = commandCache.Cache.VkAcquireFullScreenExclusiveModeExt;
                var methodResult = commandDelegate(extendedHandle.Parent.Handle, extendedHandle.Handle);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="extendedHandle">
        ///     The Swapchain handle to extend.
        /// </param>
        public static void ReleaseFullScreenExclusiveMode(this Swapchain extendedHandle)
        {
            try
            {
                var commandCache = default(CommandCache);
                commandCache = extendedHandle.CommandCache;
                var commandDelegate = commandCache.Cache.VkReleaseFullScreenExclusiveModeExt;
                var methodResult = commandDelegate(extendedHandle.Parent.Handle, extendedHandle.Handle);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }
    }
}
