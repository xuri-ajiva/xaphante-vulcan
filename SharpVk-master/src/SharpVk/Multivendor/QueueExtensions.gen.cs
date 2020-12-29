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

namespace SharpVk.Multivendor
{
    /// <summary>
    /// </summary>
    public static class QueueExtensions
    {
        /// <summary>
        /// </summary>
        /// <param name="extendedHandle">
        ///     The Queue handle to extend.
        /// </param>
        /// <param name="labelInfo">
        /// </param>
        public static unsafe void BeginDebugUtilsLabel(this Queue extendedHandle, DebugUtilsLabel labelInfo)
        {
            try
            {
                var commandCache = default(CommandCache);
                var marshalledLabelInfo = default(Interop.Multivendor.DebugUtilsLabel*);
                commandCache = extendedHandle.CommandCache;
                marshalledLabelInfo = (Interop.Multivendor.DebugUtilsLabel*)HeapUtil.Allocate<Interop.Multivendor.DebugUtilsLabel>();
                labelInfo.MarshalTo(marshalledLabelInfo);
                var commandDelegate = commandCache.Cache.VkQueueBeginDebugUtilsLabelExt;
                commandDelegate(extendedHandle.Handle, marshalledLabelInfo);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="extendedHandle">
        ///     The Queue handle to extend.
        /// </param>
        public static void EndDebugUtilsLabel(this Queue extendedHandle)
        {
            try
            {
                var commandCache = default(CommandCache);
                commandCache = extendedHandle.CommandCache;
                var commandDelegate = commandCache.Cache.VkQueueEndDebugUtilsLabelExt;
                commandDelegate(extendedHandle.Handle);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="extendedHandle">
        ///     The Queue handle to extend.
        /// </param>
        /// <param name="labelInfo">
        /// </param>
        public static unsafe void InsertDebugUtilsLabel(this Queue extendedHandle, DebugUtilsLabel labelInfo)
        {
            try
            {
                var commandCache = default(CommandCache);
                var marshalledLabelInfo = default(Interop.Multivendor.DebugUtilsLabel*);
                commandCache = extendedHandle.CommandCache;
                marshalledLabelInfo = (Interop.Multivendor.DebugUtilsLabel*)HeapUtil.Allocate<Interop.Multivendor.DebugUtilsLabel>();
                labelInfo.MarshalTo(marshalledLabelInfo);
                var commandDelegate = commandCache.Cache.VkQueueInsertDebugUtilsLabelExt;
                commandDelegate(extendedHandle.Handle, marshalledLabelInfo);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }
    }
}
