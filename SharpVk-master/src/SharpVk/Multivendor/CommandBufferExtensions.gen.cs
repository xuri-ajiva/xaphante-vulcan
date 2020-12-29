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
    public static class CommandBufferExtensions
    {
        /// <summary>
        /// </summary>
        /// <param name="extendedHandle">
        ///     The CommandBuffer handle to extend.
        /// </param>
        /// <param name="firstBinding">
        /// </param>
        /// <param name="buffers">
        /// </param>
        /// <param name="offsets">
        /// </param>
        /// <param name="sizes">
        /// </param>
        public static unsafe void BindTransformFeedbackBuffers(this CommandBuffer extendedHandle, uint firstBinding, ArrayProxy<Buffer>? buffers, ArrayProxy<ulong>? offsets, ArrayProxy<ulong>? sizes = null)
        {
            try
            {
                var commandCache = default(CommandCache);
                var marshalledBuffers = default(Interop.Buffer*);
                var marshalledOffsets = default(ulong*);
                var marshalledSizes = default(ulong*);
                commandCache = extendedHandle.commandCache;
                if (buffers.IsNull())
                {
                    marshalledBuffers = null;
                }
                else
                {
                    if (buffers.Value.Contents == ProxyContents.Single)
                    {
                        marshalledBuffers = (Interop.Buffer*)HeapUtil.Allocate<Interop.Buffer>();
                        *marshalledBuffers = buffers.Value.GetSingleValue()?.handle ?? default(Interop.Buffer);
                    }
                    else
                    {
                        var fieldPointer = (Interop.Buffer*)HeapUtil.AllocateAndClear<Interop.Buffer>(HeapUtil.GetLength(buffers.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(buffers.Value); index++) fieldPointer[index] = buffers.Value[index]?.handle ?? default(Interop.Buffer);
                        marshalledBuffers = fieldPointer;
                    }
                }
                if (offsets.IsNull())
                {
                    marshalledOffsets = null;
                }
                else
                {
                    if (offsets.Value.Contents == ProxyContents.Single)
                    {
                        marshalledOffsets = (ulong*)HeapUtil.Allocate<ulong>();
                        *marshalledOffsets = offsets.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (ulong*)HeapUtil.AllocateAndClear<ulong>(HeapUtil.GetLength(offsets.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(offsets.Value); index++) fieldPointer[index] = offsets.Value[index];
                        marshalledOffsets = fieldPointer;
                    }
                }
                if (sizes.IsNull())
                {
                    marshalledSizes = null;
                }
                else
                {
                    if (sizes.Value.Contents == ProxyContents.Single)
                    {
                        marshalledSizes = (ulong*)HeapUtil.Allocate<ulong>();
                        *marshalledSizes = sizes.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (ulong*)HeapUtil.AllocateAndClear<ulong>(HeapUtil.GetLength(sizes.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(sizes.Value); index++) fieldPointer[index] = sizes.Value[index];
                        marshalledSizes = fieldPointer;
                    }
                }
                var commandDelegate = commandCache.Cache.vkCmdBindTransformFeedbackBuffersEXT;
                commandDelegate(extendedHandle.handle, firstBinding, HeapUtil.GetLength(buffers), marshalledBuffers, marshalledOffsets, marshalledSizes);
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
        /// <param name="firstCounterBuffer">
        /// </param>
        /// <param name="counterBuffers">
        /// </param>
        /// <param name="counterBufferOffsets">
        /// </param>
        public static unsafe void BeginTransformFeedback(this CommandBuffer extendedHandle, uint firstCounterBuffer, ArrayProxy<Buffer>? counterBuffers, ArrayProxy<ulong>? counterBufferOffsets = null)
        {
            try
            {
                var commandCache = default(CommandCache);
                var marshalledCounterBuffers = default(Interop.Buffer*);
                var marshalledCounterBufferOffsets = default(ulong*);
                commandCache = extendedHandle.commandCache;
                if (counterBuffers.IsNull())
                {
                    marshalledCounterBuffers = null;
                }
                else
                {
                    if (counterBuffers.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCounterBuffers = (Interop.Buffer*)HeapUtil.Allocate<Interop.Buffer>();
                        *marshalledCounterBuffers = counterBuffers.Value.GetSingleValue()?.handle ?? default(Interop.Buffer);
                    }
                    else
                    {
                        var fieldPointer = (Interop.Buffer*)HeapUtil.AllocateAndClear<Interop.Buffer>(HeapUtil.GetLength(counterBuffers.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(counterBuffers.Value); index++) fieldPointer[index] = counterBuffers.Value[index]?.handle ?? default(Interop.Buffer);
                        marshalledCounterBuffers = fieldPointer;
                    }
                }
                if (counterBufferOffsets.IsNull())
                {
                    marshalledCounterBufferOffsets = null;
                }
                else
                {
                    if (counterBufferOffsets.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCounterBufferOffsets = (ulong*)HeapUtil.Allocate<ulong>();
                        *marshalledCounterBufferOffsets = counterBufferOffsets.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (ulong*)HeapUtil.AllocateAndClear<ulong>(HeapUtil.GetLength(counterBufferOffsets.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(counterBufferOffsets.Value); index++) fieldPointer[index] = counterBufferOffsets.Value[index];
                        marshalledCounterBufferOffsets = fieldPointer;
                    }
                }
                var commandDelegate = commandCache.Cache.vkCmdBeginTransformFeedbackEXT;
                commandDelegate(extendedHandle.handle, firstCounterBuffer, HeapUtil.GetLength(counterBuffers), marshalledCounterBuffers, marshalledCounterBufferOffsets);
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
        /// <param name="firstCounterBuffer">
        /// </param>
        /// <param name="counterBuffers">
        /// </param>
        /// <param name="counterBufferOffsets">
        /// </param>
        public static unsafe void EndTransformFeedback(this CommandBuffer extendedHandle, uint firstCounterBuffer, ArrayProxy<Buffer>? counterBuffers, ArrayProxy<ulong>? counterBufferOffsets = null)
        {
            try
            {
                var commandCache = default(CommandCache);
                var marshalledCounterBuffers = default(Interop.Buffer*);
                var marshalledCounterBufferOffsets = default(ulong*);
                commandCache = extendedHandle.commandCache;
                if (counterBuffers.IsNull())
                {
                    marshalledCounterBuffers = null;
                }
                else
                {
                    if (counterBuffers.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCounterBuffers = (Interop.Buffer*)HeapUtil.Allocate<Interop.Buffer>();
                        *marshalledCounterBuffers = counterBuffers.Value.GetSingleValue()?.handle ?? default(Interop.Buffer);
                    }
                    else
                    {
                        var fieldPointer = (Interop.Buffer*)HeapUtil.AllocateAndClear<Interop.Buffer>(HeapUtil.GetLength(counterBuffers.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(counterBuffers.Value); index++) fieldPointer[index] = counterBuffers.Value[index]?.handle ?? default(Interop.Buffer);
                        marshalledCounterBuffers = fieldPointer;
                    }
                }
                if (counterBufferOffsets.IsNull())
                {
                    marshalledCounterBufferOffsets = null;
                }
                else
                {
                    if (counterBufferOffsets.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCounterBufferOffsets = (ulong*)HeapUtil.Allocate<ulong>();
                        *marshalledCounterBufferOffsets = counterBufferOffsets.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (ulong*)HeapUtil.AllocateAndClear<ulong>(HeapUtil.GetLength(counterBufferOffsets.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(counterBufferOffsets.Value); index++) fieldPointer[index] = counterBufferOffsets.Value[index];
                        marshalledCounterBufferOffsets = fieldPointer;
                    }
                }
                var commandDelegate = commandCache.Cache.vkCmdEndTransformFeedbackEXT;
                commandDelegate(extendedHandle.handle, firstCounterBuffer, HeapUtil.GetLength(counterBuffers), marshalledCounterBuffers, marshalledCounterBufferOffsets);
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
        /// <param name="queryPool">
        /// </param>
        /// <param name="query">
        /// </param>
        /// <param name="flags">
        /// </param>
        /// <param name="index">
        /// </param>
        public static void BeginQueryIndexed(this CommandBuffer extendedHandle, QueryPool queryPool, uint query, uint index, QueryControlFlags? flags = default)
        {
            try
            {
                var commandCache = default(CommandCache);
                var marshalledFlags = default(QueryControlFlags);
                commandCache = extendedHandle.commandCache;
                if (flags != null)
                    marshalledFlags = flags.Value;
                else
                    marshalledFlags = default;
                var commandDelegate = commandCache.Cache.vkCmdBeginQueryIndexedEXT;
                commandDelegate(extendedHandle.handle, queryPool?.handle ?? default(Interop.QueryPool), query, marshalledFlags, index);
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
        /// <param name="queryPool">
        /// </param>
        /// <param name="query">
        /// </param>
        /// <param name="index">
        /// </param>
        public static void EndQueryIndexed(this CommandBuffer extendedHandle, QueryPool queryPool, uint query, uint index)
        {
            try
            {
                var commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                var commandDelegate = commandCache.Cache.vkCmdEndQueryIndexedEXT;
                commandDelegate(extendedHandle.handle, queryPool?.handle ?? default(Interop.QueryPool), query, index);
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
        /// <param name="instanceCount">
        /// </param>
        /// <param name="firstInstance">
        /// </param>
        /// <param name="counterBuffer">
        /// </param>
        /// <param name="counterBufferOffset">
        /// </param>
        /// <param name="counterOffset">
        /// </param>
        /// <param name="vertexStride">
        /// </param>
        public static void DrawIndirectByteCount(this CommandBuffer extendedHandle, uint instanceCount, uint firstInstance, Buffer counterBuffer, ulong counterBufferOffset, uint counterOffset, uint vertexStride)
        {
            try
            {
                var commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                var commandDelegate = commandCache.Cache.vkCmdDrawIndirectByteCountEXT;
                commandDelegate(extendedHandle.handle, instanceCount, firstInstance, counterBuffer?.handle ?? default(Interop.Buffer), counterBufferOffset, counterOffset, vertexStride);
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
        /// <param name="buffer">
        /// </param>
        /// <param name="offset">
        /// </param>
        /// <param name="flags">
        /// </param>
        public static unsafe void BeginConditionalRendering(this CommandBuffer extendedHandle, Buffer buffer, ulong offset, ConditionalRenderingFlags? flags = default)
        {
            try
            {
                var commandCache = default(CommandCache);
                var marshalledConditionalRenderingBegin = default(Interop.Multivendor.ConditionalRenderingBeginInfo*);
                var vkConditionalRenderingBeginInfoEXTNextPointer = default(void*);
                commandCache = extendedHandle.commandCache;
                marshalledConditionalRenderingBegin = (Interop.Multivendor.ConditionalRenderingBeginInfo*)HeapUtil.Allocate<Interop.Multivendor.ConditionalRenderingBeginInfo>();
                marshalledConditionalRenderingBegin->SType = StructureType.ConditionalRenderingBeginInfo;
                marshalledConditionalRenderingBegin->Next = vkConditionalRenderingBeginInfoEXTNextPointer;
                marshalledConditionalRenderingBegin->Buffer = buffer?.handle ?? default(Interop.Buffer);
                marshalledConditionalRenderingBegin->Offset = offset;
                if (flags != null)
                    marshalledConditionalRenderingBegin->Flags = flags.Value;
                else
                    marshalledConditionalRenderingBegin->Flags = default;
                var commandDelegate = commandCache.Cache.vkCmdBeginConditionalRenderingEXT;
                commandDelegate(extendedHandle.handle, marshalledConditionalRenderingBegin);
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
        public static void EndConditionalRendering(this CommandBuffer extendedHandle)
        {
            try
            {
                var commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                var commandDelegate = commandCache.Cache.vkCmdEndConditionalRenderingEXT;
                commandDelegate(extendedHandle.handle);
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
        /// <param name="firstDiscardRectangle">
        /// </param>
        /// <param name="discardRectangles">
        /// </param>
        public static unsafe void SetDiscardRectangle(this CommandBuffer extendedHandle, uint firstDiscardRectangle, ArrayProxy<Rect2D>? discardRectangles)
        {
            try
            {
                var commandCache = default(CommandCache);
                var marshalledDiscardRectangles = default(Rect2D*);
                commandCache = extendedHandle.commandCache;
                if (discardRectangles.IsNull())
                {
                    marshalledDiscardRectangles = null;
                }
                else
                {
                    if (discardRectangles.Value.Contents == ProxyContents.Single)
                    {
                        marshalledDiscardRectangles = (Rect2D*)HeapUtil.Allocate<Rect2D>();
                        *marshalledDiscardRectangles = discardRectangles.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (Rect2D*)HeapUtil.AllocateAndClear<Rect2D>(HeapUtil.GetLength(discardRectangles.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(discardRectangles.Value); index++) fieldPointer[index] = discardRectangles.Value[index];
                        marshalledDiscardRectangles = fieldPointer;
                    }
                }
                var commandDelegate = commandCache.Cache.vkCmdSetDiscardRectangleEXT;
                commandDelegate(extendedHandle.handle, firstDiscardRectangle, HeapUtil.GetLength(discardRectangles), marshalledDiscardRectangles);
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
        /// <param name="labelInfo">
        /// </param>
        public static unsafe void BeginDebugUtilsLabel(this CommandBuffer extendedHandle, DebugUtilsLabel labelInfo)
        {
            try
            {
                var commandCache = default(CommandCache);
                var marshalledLabelInfo = default(Interop.Multivendor.DebugUtilsLabel*);
                commandCache = extendedHandle.commandCache;
                marshalledLabelInfo = (Interop.Multivendor.DebugUtilsLabel*)HeapUtil.Allocate<Interop.Multivendor.DebugUtilsLabel>();
                labelInfo.MarshalTo(marshalledLabelInfo);
                var commandDelegate = commandCache.Cache.vkCmdBeginDebugUtilsLabelEXT;
                commandDelegate(extendedHandle.handle, marshalledLabelInfo);
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
        public static void EndDebugUtilsLabel(this CommandBuffer extendedHandle)
        {
            try
            {
                var commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                var commandDelegate = commandCache.Cache.vkCmdEndDebugUtilsLabelEXT;
                commandDelegate(extendedHandle.handle);
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
        /// <param name="labelInfo">
        /// </param>
        public static unsafe void InsertDebugUtilsLabel(this CommandBuffer extendedHandle, DebugUtilsLabel labelInfo)
        {
            try
            {
                var commandCache = default(CommandCache);
                var marshalledLabelInfo = default(Interop.Multivendor.DebugUtilsLabel*);
                commandCache = extendedHandle.commandCache;
                marshalledLabelInfo = (Interop.Multivendor.DebugUtilsLabel*)HeapUtil.Allocate<Interop.Multivendor.DebugUtilsLabel>();
                labelInfo.MarshalTo(marshalledLabelInfo);
                var commandDelegate = commandCache.Cache.vkCmdInsertDebugUtilsLabelEXT;
                commandDelegate(extendedHandle.handle, marshalledLabelInfo);
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
        /// <param name="sampleLocationsInfo">
        /// </param>
        public static unsafe void SetSampleLocations(this CommandBuffer extendedHandle, SampleLocationsInfo sampleLocationsInfo)
        {
            try
            {
                var commandCache = default(CommandCache);
                var marshalledSampleLocationsInfo = default(Interop.Multivendor.SampleLocationsInfo*);
                commandCache = extendedHandle.commandCache;
                marshalledSampleLocationsInfo = (Interop.Multivendor.SampleLocationsInfo*)HeapUtil.Allocate<Interop.Multivendor.SampleLocationsInfo>();
                sampleLocationsInfo.MarshalTo(marshalledSampleLocationsInfo);
                var commandDelegate = commandCache.Cache.vkCmdSetSampleLocationsEXT;
                commandDelegate(extendedHandle.handle, marshalledSampleLocationsInfo);
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
        /// <param name="lineStippleFactor">
        /// </param>
        /// <param name="lineStipplePattern">
        /// </param>
        public static void SetLineStipple(this CommandBuffer extendedHandle, uint lineStippleFactor, ushort lineStipplePattern)
        {
            try
            {
                var commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                var commandDelegate = commandCache.Cache.vkCmdSetLineStippleEXT;
                commandDelegate(extendedHandle.handle, lineStippleFactor, lineStipplePattern);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }
    }
}