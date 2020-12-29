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

namespace SharpVk.Intel
{
    /// <summary>
    /// </summary>
    public static class CommandBufferExtensions
    {
        /// <summary>
        ///     Set markers into the command buffer.
        /// </summary>
        /// <param name="extendedHandle">
        ///     The CommandBuffer handle to extend.
        /// </param>
        /// <param name="markerInfo">
        ///     The performance markers to set.
        /// </param>
        public static unsafe void SetPerformanceMarker(this CommandBuffer extendedHandle, PerformanceMarkerInfo markerInfo)
        {
            try
            {
                var commandCache = default(CommandCache);
                var marshalledMarkerInfo = default(Interop.Intel.PerformanceMarkerInfo*);
                commandCache = extendedHandle.CommandCache;
                marshalledMarkerInfo = (Interop.Intel.PerformanceMarkerInfo*)HeapUtil.Allocate<Interop.Intel.PerformanceMarkerInfo>();
                markerInfo.MarshalTo(marshalledMarkerInfo);
                var commandDelegate = commandCache.Cache.VkCmdSetPerformanceMarkerIntel;
                var methodResult = commandDelegate(extendedHandle.Handle, marshalledMarkerInfo);
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
        ///     The CommandBuffer handle to extend.
        /// </param>
        /// <param name="markerInfo">
        /// </param>
        public static unsafe void SetPerformanceStreamMarker(this CommandBuffer extendedHandle, PerformanceStreamMarkerInfo markerInfo)
        {
            try
            {
                var commandCache = default(CommandCache);
                var marshalledMarkerInfo = default(Interop.Intel.PerformanceStreamMarkerInfo*);
                commandCache = extendedHandle.CommandCache;
                marshalledMarkerInfo = (Interop.Intel.PerformanceStreamMarkerInfo*)HeapUtil.Allocate<Interop.Intel.PerformanceStreamMarkerInfo>();
                markerInfo.MarshalTo(marshalledMarkerInfo);
                var commandDelegate = commandCache.Cache.VkCmdSetPerformanceStreamMarkerIntel;
                var methodResult = commandDelegate(extendedHandle.Handle, marshalledMarkerInfo);
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
        ///     The CommandBuffer handle to extend.
        /// </param>
        /// <param name="overrideInfo">
        /// </param>
        public static unsafe void SetPerformanceOverride(this CommandBuffer extendedHandle, PerformanceOverrideInfo overrideInfo)
        {
            try
            {
                var commandCache = default(CommandCache);
                var marshalledOverrideInfo = default(Interop.Intel.PerformanceOverrideInfo*);
                commandCache = extendedHandle.CommandCache;
                marshalledOverrideInfo = (Interop.Intel.PerformanceOverrideInfo*)HeapUtil.Allocate<Interop.Intel.PerformanceOverrideInfo>();
                overrideInfo.MarshalTo(marshalledOverrideInfo);
                var commandDelegate = commandCache.Cache.VkCmdSetPerformanceOverrideIntel;
                var methodResult = commandDelegate(extendedHandle.Handle, marshalledOverrideInfo);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }
    }
}
