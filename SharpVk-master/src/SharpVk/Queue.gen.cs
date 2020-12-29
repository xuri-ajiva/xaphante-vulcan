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

namespace SharpVk
{
    /// <summary>
    ///     Opaque handle to a queue object.
    /// </summary>
    public class Queue
    {
        internal readonly CommandCache commandCache;
        internal readonly Interop.Queue handle;

        internal readonly Device parent;

        internal Queue(Device parent, Interop.Queue handle)
        {
            this.handle = handle;
            this.parent = parent;
            commandCache = parent.commandCache;
        }

        /// <summary>
        ///     The raw handle for this instance.
        /// </summary>
        public Interop.Queue RawHandle => handle;

        /// <summary>
        ///     Submits a sequence of semaphores or command buffers to a queue.
        /// </summary>
        /// <param name="submits">
        /// </param>
        /// <param name="fence">
        /// </param>
        public unsafe void Submit(ArrayProxy<SubmitInfo>? submits, Fence fence)
        {
            try
            {
                var marshalledSubmits = default(Interop.SubmitInfo*);
                if (submits.IsNull())
                {
                    marshalledSubmits = null;
                }
                else
                {
                    if (submits.Value.Contents == ProxyContents.Single)
                    {
                        marshalledSubmits = (Interop.SubmitInfo*)HeapUtil.Allocate<Interop.SubmitInfo>();
                        submits.Value.GetSingleValue().MarshalTo(&*marshalledSubmits);
                    }
                    else
                    {
                        var fieldPointer = (Interop.SubmitInfo*)HeapUtil.AllocateAndClear<Interop.SubmitInfo>(HeapUtil.GetLength(submits.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(submits.Value); index++) submits.Value[index].MarshalTo(&fieldPointer[index]);
                        marshalledSubmits = fieldPointer;
                    }
                }
                var commandDelegate = commandCache.Cache.vkQueueSubmit;
                var methodResult = commandDelegate(handle, HeapUtil.GetLength(submits), marshalledSubmits, fence?.handle ?? default(Interop.Fence));
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Wait for a queue to become idle.
        /// </summary>
        public void WaitIdle()
        {
            try
            {
                var commandDelegate = commandCache.Cache.vkQueueWaitIdle;
                var methodResult = commandDelegate(handle);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Bind device memory to a sparse resource object.
        /// </summary>
        /// <param name="bindInfo">
        /// </param>
        /// <param name="fence">
        /// </param>
        public unsafe void BindSparse(ArrayProxy<BindSparseInfo>? bindInfo, Fence fence)
        {
            try
            {
                var marshalledBindInfo = default(Interop.BindSparseInfo*);
                if (bindInfo.IsNull())
                {
                    marshalledBindInfo = null;
                }
                else
                {
                    if (bindInfo.Value.Contents == ProxyContents.Single)
                    {
                        marshalledBindInfo = (Interop.BindSparseInfo*)HeapUtil.Allocate<Interop.BindSparseInfo>();
                        bindInfo.Value.GetSingleValue().MarshalTo(&*marshalledBindInfo);
                    }
                    else
                    {
                        var fieldPointer = (Interop.BindSparseInfo*)HeapUtil.AllocateAndClear<Interop.BindSparseInfo>(HeapUtil.GetLength(bindInfo.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(bindInfo.Value); index++) bindInfo.Value[index].MarshalTo(&fieldPointer[index]);
                        marshalledBindInfo = fieldPointer;
                    }
                }
                var commandDelegate = commandCache.Cache.vkQueueBindSparse;
                var methodResult = commandDelegate(handle, HeapUtil.GetLength(bindInfo), marshalledBindInfo, fence?.handle ?? default(Interop.Fence));
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }
    }
}