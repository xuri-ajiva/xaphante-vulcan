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

namespace SharpVk.Android
{
    /// <summary>
    /// </summary>
    public static class DeviceExtensions
    {
        /// <summary>
        /// </summary>
        /// <param name="extendedHandle">
        ///     The Device handle to extend.
        /// </param>
        /// <param name="buffer">
        /// </param>
        public static unsafe AndroidHardwareBufferProperties GetAndroidHardwareBufferProperties(this Device extendedHandle, IntPtr buffer)
        {
            try
            {
                var result = default(AndroidHardwareBufferProperties);
                var commandCache = default(CommandCache);
                var marshalledBuffer = default(IntPtr*);
                var marshalledProperties = default(Interop.Android.AndroidHardwareBufferProperties);
                commandCache = extendedHandle.CommandCache;
                marshalledBuffer = (IntPtr*)HeapUtil.Allocate<IntPtr>();
                *marshalledBuffer = buffer;
                var commandDelegate = commandCache.Cache.VkGetAndroidHardwareBufferPropertiesAndroid;
                var methodResult = commandDelegate(extendedHandle.Handle, marshalledBuffer, &marshalledProperties);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                result = AndroidHardwareBufferProperties.MarshalFrom(&marshalledProperties);
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="extendedHandle">
        ///     The Device handle to extend.
        /// </param>
        /// <param name="info">
        /// </param>
        /// <param name="buffer">
        /// </param>
        public static unsafe void GetMemoryAndroidHardwareBuffer(this Device extendedHandle, MemoryGetAndroidHardwareBufferInfo info, IntPtr buffer)
        {
            try
            {
                var commandCache = default(CommandCache);
                var marshalledInfo = default(Interop.Android.MemoryGetAndroidHardwareBufferInfo*);
                var marshalledBuffer = default(IntPtr*);
                commandCache = extendedHandle.CommandCache;
                marshalledInfo = (Interop.Android.MemoryGetAndroidHardwareBufferInfo*)HeapUtil.Allocate<Interop.Android.MemoryGetAndroidHardwareBufferInfo>();
                info.MarshalTo(marshalledInfo);
                marshalledBuffer = (IntPtr*)HeapUtil.Allocate<IntPtr>();
                *marshalledBuffer = buffer;
                var commandDelegate = commandCache.Cache.VkGetMemoryAndroidHardwareBufferAndroid;
                var methodResult = commandDelegate(extendedHandle.Handle, marshalledInfo, marshalledBuffer);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }
    }
}
