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
    ///     Opaque handle to a query pool object.
    /// </summary>
    public class QueryPool
        : IDisposable
    {
        internal readonly CommandCache commandCache;
        internal readonly Interop.QueryPool handle;

        internal readonly Device parent;

        internal QueryPool(Device parent, Interop.QueryPool handle)
        {
            this.handle = handle;
            this.parent = parent;
            commandCache = parent.commandCache;
        }

        /// <summary>
        ///     The raw handle for this instance.
        /// </summary>
        public Interop.QueryPool RawHandle => handle;

        /// <summary>
        ///     Destroys the handles and releases any unmanaged resources
        ///     associated with it.
        /// </summary>
        public void Dispose()
        {
            Destroy();
        }

        /// <summary>
        ///     Destroy a query pool object.
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
                var commandDelegate = commandCache.Cache.vkDestroyQueryPool;
                commandDelegate(parent.handle, handle, marshalledAllocator);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Copy results of queries in a query pool to a host memory region.
        /// </summary>
        /// <param name="firstQuery">
        /// </param>
        /// <param name="queryCount">
        /// </param>
        /// <param name="data">
        /// </param>
        /// <param name="stride">
        /// </param>
        /// <param name="flags">
        /// </param>
        public unsafe Result GetResults(uint firstQuery, uint queryCount, ArrayProxy<byte>? data, ulong stride, QueryResultFlags? flags = default)
        {
            try
            {
                var result = default(Result);
                var marshalledData = default(byte*);
                var marshalledFlags = default(QueryResultFlags);
                if (data.IsNull())
                {
                    marshalledData = null;
                }
                else
                {
                    if (data.Value.Contents == ProxyContents.Single)
                    {
                        marshalledData = (byte*)HeapUtil.Allocate<byte>();
                        *marshalledData = data.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (byte*)HeapUtil.AllocateAndClear<byte>(HeapUtil.GetLength(data.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(data.Value); index++) fieldPointer[index] = data.Value[index];
                        marshalledData = fieldPointer;
                    }
                }
                if (flags != null)
                    marshalledFlags = flags.Value;
                else
                    marshalledFlags = default;
                var commandDelegate = commandCache.Cache.vkGetQueryPoolResults;
                result = commandDelegate(parent.handle, handle, firstQuery, queryCount, HeapUtil.GetLength(data), marshalledData, stride, marshalledFlags);
                if (SharpVkException.IsError(result)) throw SharpVkException.Create(result);
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="firstQuery">
        /// </param>
        /// <param name="queryCount">
        /// </param>
        public void Reset(uint firstQuery, uint queryCount)
        {
            try
            {
                var commandDelegate = commandCache.Cache.vkResetQueryPool;
                commandDelegate(parent.handle, handle, firstQuery, queryCount);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }
    }
}