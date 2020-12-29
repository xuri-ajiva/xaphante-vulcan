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

namespace SharpVk.NVidia
{
    /// <summary>
    /// </summary>
    public class AccelerationStructure
        : IDisposable
    {
        internal readonly CommandCache commandCache;
        internal readonly Interop.NVidia.AccelerationStructure handle;

        internal readonly Device parent;

        internal AccelerationStructure(Device parent, Interop.NVidia.AccelerationStructure handle)
        {
            this.handle = handle;
            this.parent = parent;
            commandCache = parent.commandCache;
        }

        /// <summary>
        ///     The raw handle for this instance.
        /// </summary>
        public Interop.NVidia.AccelerationStructure RawHandle => handle;

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
                var commandDelegate = commandCache.Cache.vkDestroyAccelerationStructureNV;
                commandDelegate(parent.handle, handle, marshalledAllocator);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="dataSize">
        /// </param>
        public unsafe byte[] GetHandle(HostSize dataSize)
        {
            try
            {
                var result = default(byte[]);
                var marshalledDataSize = default(HostSize);
                var marshalledData = default(byte*);
                marshalledDataSize = dataSize;
                marshalledData = (byte*)HeapUtil.Allocate<byte>(marshalledDataSize);
                var commandDelegate = commandCache.Cache.vkGetAccelerationStructureHandleNV;
                var methodResult = commandDelegate(parent.handle, handle, marshalledDataSize, marshalledData);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
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