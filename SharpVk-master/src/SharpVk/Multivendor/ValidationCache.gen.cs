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

namespace SharpVk.Multivendor
{
    /// <summary>
    /// </summary>
    public class ValidationCache
        : IDisposable
    {
        internal readonly CommandCache CommandCache;
        internal readonly Interop.Multivendor.ValidationCache Handle;

        internal readonly Device Parent;

        internal ValidationCache(Device parent, Interop.Multivendor.ValidationCache handle)
        {
            this.Handle = handle;
            this.Parent = parent;
            CommandCache = parent.CommandCache;
        }

        /// <summary>
        ///     The raw handle for this instance.
        /// </summary>
        public Interop.Multivendor.ValidationCache RawHandle => Handle;

        /// <summary>
        ///     Destroys the handles and releases any unmanaged resources
        ///     associated with it.
        /// </summary>
        public void Dispose()
        {
            Destroy();
        }

        /// <summary>
        /// </summary>
        /// <param name="allocator">
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
                var commandDelegate = CommandCache.Cache.VkDestroyValidationCacheExt;
                commandDelegate(Parent.Handle, Handle, marshalledAllocator);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="sourceCaches">
        /// </param>
        public unsafe void MergeValidationCaches(ArrayProxy<ValidationCache>? sourceCaches)
        {
            try
            {
                var marshalledSourceCaches = default(Interop.Multivendor.ValidationCache*);
                if (sourceCaches.IsNull())
                {
                    marshalledSourceCaches = null;
                }
                else
                {
                    if (sourceCaches.Value.Contents == ProxyContents.Single)
                    {
                        marshalledSourceCaches = (Interop.Multivendor.ValidationCache*)HeapUtil.Allocate<Interop.Multivendor.ValidationCache>();
                        *marshalledSourceCaches = sourceCaches.Value.GetSingleValue()?.Handle ?? default(Interop.Multivendor.ValidationCache);
                    }
                    else
                    {
                        var fieldPointer = (Interop.Multivendor.ValidationCache*)HeapUtil.AllocateAndClear<Interop.Multivendor.ValidationCache>(HeapUtil.GetLength(sourceCaches.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(sourceCaches.Value); index++) fieldPointer[index] = sourceCaches.Value[index]?.Handle ?? default(Interop.Multivendor.ValidationCache);
                        marshalledSourceCaches = fieldPointer;
                    }
                }
                var commandDelegate = CommandCache.Cache.VkMergeValidationCachesExt;
                var methodResult = commandDelegate(Parent.Handle, Handle, HeapUtil.GetLength(sourceCaches), marshalledSourceCaches);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        /// </summary>
        public unsafe byte[] GetData()
        {
            try
            {
                var result = default(byte[]);
                var marshalledDataSize = default(HostSize);
                var marshalledData = default(byte*);
                var commandDelegate = CommandCache.Cache.VkGetValidationCacheDataExt;
                var methodResult = commandDelegate(Parent.Handle, Handle, &marshalledDataSize, marshalledData);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                marshalledData = (byte*)HeapUtil.Allocate<byte>((uint)marshalledDataSize);
                commandDelegate(Parent.Handle, Handle, &marshalledDataSize, marshalledData);
                if (marshalledData != null)
                {
                    var fieldPointer = new byte[(uint)marshalledDataSize];
                    for (var index = 0; index < (uint)marshalledDataSize; index++) fieldPointer[index] = marshalledData[index];
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
    }
}
