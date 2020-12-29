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
    ///     Opaque handle to a event object.
    /// </summary>
    public class Event
        : IDisposable
    {
        internal readonly CommandCache commandCache;
        internal readonly Interop.Event handle;

        internal readonly Device parent;

        internal Event(Device parent, Interop.Event handle)
        {
            this.handle = handle;
            this.parent = parent;
            commandCache = parent.commandCache;
        }

        /// <summary>
        ///     The raw handle for this instance.
        /// </summary>
        public Interop.Event RawHandle => handle;

        /// <summary>
        ///     Destroys the handles and releases any unmanaged resources
        ///     associated with it.
        /// </summary>
        public void Dispose()
        {
            Destroy();
        }

        /// <summary>
        ///     Destroy an event object.
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
                var commandDelegate = commandCache.Cache.vkDestroyEvent;
                commandDelegate(parent.handle, handle, marshalledAllocator);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Retrieve the status of an event object.
        /// </summary>
        public Result GetStatus()
        {
            try
            {
                var result = default(Result);
                var commandDelegate = commandCache.Cache.vkGetEventStatus;
                result = commandDelegate(parent.handle, handle);
                if (SharpVkException.IsError(result)) throw SharpVkException.Create(result);
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Set an event to signaled state.
        /// </summary>
        public void Set()
        {
            try
            {
                var commandDelegate = commandCache.Cache.vkSetEvent;
                var methodResult = commandDelegate(parent.handle, handle);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Reset an event to non-signaled state.
        /// </summary>
        public void Reset()
        {
            try
            {
                var commandDelegate = commandCache.Cache.vkResetEvent;
                var methodResult = commandDelegate(parent.handle, handle);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }
    }
}