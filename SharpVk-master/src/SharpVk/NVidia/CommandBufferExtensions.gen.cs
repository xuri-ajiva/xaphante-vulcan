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
    public static class CommandBufferExtensions
    {
        /// <summary>
        ///     Set the viewport W scaling on a command buffer.
        /// </summary>
        /// <param name="extendedHandle">
        ///     The CommandBuffer handle to extend.
        /// </param>
        /// <param name="firstViewport">
        /// </param>
        /// <param name="viewportWScalings">
        /// </param>
        public static unsafe void SetViewportWScaling(this CommandBuffer extendedHandle, uint firstViewport, ArrayProxy<ViewportWScaling>? viewportWScalings)
        {
            try
            {
                var commandCache = default(CommandCache);
                var marshalledViewportWScalings = default(ViewportWScaling*);
                commandCache = extendedHandle.commandCache;
                if (viewportWScalings.IsNull())
                {
                    marshalledViewportWScalings = null;
                }
                else
                {
                    if (viewportWScalings.Value.Contents == ProxyContents.Single)
                    {
                        marshalledViewportWScalings = (ViewportWScaling*)HeapUtil.Allocate<ViewportWScaling>();
                        *marshalledViewportWScalings = viewportWScalings.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (ViewportWScaling*)HeapUtil.AllocateAndClear<ViewportWScaling>(HeapUtil.GetLength(viewportWScalings.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(viewportWScalings.Value); index++) fieldPointer[index] = viewportWScalings.Value[index];
                        marshalledViewportWScalings = fieldPointer;
                    }
                }
                var commandDelegate = commandCache.Cache.vkCmdSetViewportWScalingNV;
                commandDelegate(extendedHandle.handle, firstViewport, HeapUtil.GetLength(viewportWScalings), marshalledViewportWScalings);
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
        /// <param name="imageView">
        /// </param>
        /// <param name="imageLayout">
        /// </param>
        public static void BindShadingRateImage(this CommandBuffer extendedHandle, ImageView imageView, ImageLayout imageLayout)
        {
            try
            {
                var commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                var commandDelegate = commandCache.Cache.vkCmdBindShadingRateImageNV;
                commandDelegate(extendedHandle.handle, imageView?.handle ?? default(Interop.ImageView), imageLayout);
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
        /// <param name="firstViewport">
        /// </param>
        /// <param name="shadingRatePalettes">
        /// </param>
        public static unsafe void SetViewportShadingRatePalette(this CommandBuffer extendedHandle, uint firstViewport, ArrayProxy<ShadingRatePalette>? shadingRatePalettes)
        {
            try
            {
                var commandCache = default(CommandCache);
                var marshalledShadingRatePalettes = default(Interop.NVidia.ShadingRatePalette*);
                commandCache = extendedHandle.commandCache;
                if (shadingRatePalettes.IsNull())
                {
                    marshalledShadingRatePalettes = null;
                }
                else
                {
                    if (shadingRatePalettes.Value.Contents == ProxyContents.Single)
                    {
                        marshalledShadingRatePalettes = (Interop.NVidia.ShadingRatePalette*)HeapUtil.Allocate<Interop.NVidia.ShadingRatePalette>();
                        shadingRatePalettes.Value.GetSingleValue().MarshalTo(&*marshalledShadingRatePalettes);
                    }
                    else
                    {
                        var fieldPointer = (Interop.NVidia.ShadingRatePalette*)HeapUtil.AllocateAndClear<Interop.NVidia.ShadingRatePalette>(HeapUtil.GetLength(shadingRatePalettes.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(shadingRatePalettes.Value); index++) shadingRatePalettes.Value[index].MarshalTo(&fieldPointer[index]);
                        marshalledShadingRatePalettes = fieldPointer;
                    }
                }
                var commandDelegate = commandCache.Cache.vkCmdSetViewportShadingRatePaletteNV;
                commandDelegate(extendedHandle.handle, firstViewport, HeapUtil.GetLength(shadingRatePalettes), marshalledShadingRatePalettes);
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
        /// <param name="sampleOrderType">
        /// </param>
        /// <param name="customSampleOrders">
        /// </param>
        public static unsafe void SetCoarseSampleOrder(this CommandBuffer extendedHandle, CoarseSampleOrderType sampleOrderType, ArrayProxy<CoarseSampleOrderCustom>? customSampleOrders)
        {
            try
            {
                var commandCache = default(CommandCache);
                var marshalledCustomSampleOrders = default(Interop.NVidia.CoarseSampleOrderCustom*);
                commandCache = extendedHandle.commandCache;
                if (customSampleOrders.IsNull())
                {
                    marshalledCustomSampleOrders = null;
                }
                else
                {
                    if (customSampleOrders.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCustomSampleOrders = (Interop.NVidia.CoarseSampleOrderCustom*)HeapUtil.Allocate<Interop.NVidia.CoarseSampleOrderCustom>();
                        customSampleOrders.Value.GetSingleValue().MarshalTo(&*marshalledCustomSampleOrders);
                    }
                    else
                    {
                        var fieldPointer = (Interop.NVidia.CoarseSampleOrderCustom*)HeapUtil.AllocateAndClear<Interop.NVidia.CoarseSampleOrderCustom>(HeapUtil.GetLength(customSampleOrders.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(customSampleOrders.Value); index++) customSampleOrders.Value[index].MarshalTo(&fieldPointer[index]);
                        marshalledCustomSampleOrders = fieldPointer;
                    }
                }
                var commandDelegate = commandCache.Cache.vkCmdSetCoarseSampleOrderNV;
                commandDelegate(extendedHandle.handle, sampleOrderType, HeapUtil.GetLength(customSampleOrders), marshalledCustomSampleOrders);
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
        /// <param name="info">
        /// </param>
        /// <param name="instanceData">
        /// </param>
        /// <param name="instanceOffset">
        /// </param>
        /// <param name="update">
        /// </param>
        /// <param name="destination">
        /// </param>
        /// <param name="source">
        /// </param>
        /// <param name="scratch">
        /// </param>
        /// <param name="scratchOffset">
        /// </param>
        public static unsafe void BuildAccelerationStructure(this CommandBuffer extendedHandle, AccelerationStructureInfo info, Buffer instanceData, ulong instanceOffset, bool update, AccelerationStructure destination, AccelerationStructure source, Buffer scratch, ulong scratchOffset)
        {
            try
            {
                var commandCache = default(CommandCache);
                var marshalledInfo = default(Interop.NVidia.AccelerationStructureInfo*);
                commandCache = extendedHandle.commandCache;
                marshalledInfo = (Interop.NVidia.AccelerationStructureInfo*)HeapUtil.Allocate<Interop.NVidia.AccelerationStructureInfo>();
                info.MarshalTo(marshalledInfo);
                var commandDelegate = commandCache.Cache.vkCmdBuildAccelerationStructureNV;
                commandDelegate(extendedHandle.handle, marshalledInfo, instanceData?.handle ?? default(Interop.Buffer), instanceOffset, update, destination?.handle ?? default(Interop.NVidia.AccelerationStructure), source?.handle ?? default(Interop.NVidia.AccelerationStructure), scratch?.handle ?? default(Interop.Buffer), scratchOffset);
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
        /// <param name="destination">
        /// </param>
        /// <param name="source">
        /// </param>
        /// <param name="mode">
        /// </param>
        public static void CopyAccelerationStructure(this CommandBuffer extendedHandle, AccelerationStructure destination, AccelerationStructure source, CopyAccelerationStructureMode mode)
        {
            try
            {
                var commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                var commandDelegate = commandCache.Cache.vkCmdCopyAccelerationStructureNV;
                commandDelegate(extendedHandle.handle, destination?.handle ?? default(Interop.NVidia.AccelerationStructure), source?.handle ?? default(Interop.NVidia.AccelerationStructure), mode);
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
        /// <param name="raygenShaderBindingTableBuffer">
        /// </param>
        /// <param name="raygenShaderBindingOffset">
        /// </param>
        /// <param name="missShaderBindingTableBuffer">
        /// </param>
        /// <param name="missShaderBindingOffset">
        /// </param>
        /// <param name="missShaderBindingStride">
        /// </param>
        /// <param name="hitShaderBindingTableBuffer">
        /// </param>
        /// <param name="hitShaderBindingOffset">
        /// </param>
        /// <param name="hitShaderBindingStride">
        /// </param>
        /// <param name="callableShaderBindingTableBuffer">
        /// </param>
        /// <param name="callableShaderBindingOffset">
        /// </param>
        /// <param name="callableShaderBindingStride">
        /// </param>
        /// <param name="width">
        /// </param>
        /// <param name="height">
        /// </param>
        /// <param name="depth">
        /// </param>
        public static void TraceRays(this CommandBuffer extendedHandle, Buffer raygenShaderBindingTableBuffer, ulong raygenShaderBindingOffset, Buffer missShaderBindingTableBuffer, ulong missShaderBindingOffset, ulong missShaderBindingStride, Buffer hitShaderBindingTableBuffer, ulong hitShaderBindingOffset, ulong hitShaderBindingStride, Buffer callableShaderBindingTableBuffer, ulong callableShaderBindingOffset, ulong callableShaderBindingStride, uint width, uint height, uint depth)
        {
            try
            {
                var commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                var commandDelegate = commandCache.Cache.vkCmdTraceRaysNV;
                commandDelegate(extendedHandle.handle, raygenShaderBindingTableBuffer?.handle ?? default(Interop.Buffer), raygenShaderBindingOffset, missShaderBindingTableBuffer?.handle ?? default(Interop.Buffer), missShaderBindingOffset, missShaderBindingStride, hitShaderBindingTableBuffer?.handle ?? default(Interop.Buffer), hitShaderBindingOffset, hitShaderBindingStride, callableShaderBindingTableBuffer?.handle ?? default(Interop.Buffer), callableShaderBindingOffset, callableShaderBindingStride, width, height, depth);
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
        /// <param name="accelerationStructures">
        /// </param>
        /// <param name="queryType">
        /// </param>
        /// <param name="queryPool">
        /// </param>
        /// <param name="firstQuery">
        /// </param>
        public static unsafe void WriteAccelerationStructuresProperties(this CommandBuffer extendedHandle, ArrayProxy<AccelerationStructure>? accelerationStructures, QueryType queryType, QueryPool queryPool, uint firstQuery)
        {
            try
            {
                var commandCache = default(CommandCache);
                var marshalledAccelerationStructures = default(Interop.NVidia.AccelerationStructure*);
                commandCache = extendedHandle.commandCache;
                if (accelerationStructures.IsNull())
                {
                    marshalledAccelerationStructures = null;
                }
                else
                {
                    if (accelerationStructures.Value.Contents == ProxyContents.Single)
                    {
                        marshalledAccelerationStructures = (Interop.NVidia.AccelerationStructure*)HeapUtil.Allocate<Interop.NVidia.AccelerationStructure>();
                        *marshalledAccelerationStructures = accelerationStructures.Value.GetSingleValue()?.handle ?? default(Interop.NVidia.AccelerationStructure);
                    }
                    else
                    {
                        var fieldPointer = (Interop.NVidia.AccelerationStructure*)HeapUtil.AllocateAndClear<Interop.NVidia.AccelerationStructure>(HeapUtil.GetLength(accelerationStructures.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(accelerationStructures.Value); index++) fieldPointer[index] = accelerationStructures.Value[index]?.handle ?? default(Interop.NVidia.AccelerationStructure);
                        marshalledAccelerationStructures = fieldPointer;
                    }
                }
                var commandDelegate = commandCache.Cache.vkCmdWriteAccelerationStructuresPropertiesNV;
                commandDelegate(extendedHandle.handle, HeapUtil.GetLength(accelerationStructures), marshalledAccelerationStructures, queryType, queryPool?.handle ?? default(Interop.QueryPool), firstQuery);
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
        /// <param name="taskCount">
        /// </param>
        /// <param name="firstTask">
        /// </param>
        public static void DrawMeshTasks(this CommandBuffer extendedHandle, uint taskCount, uint firstTask)
        {
            try
            {
                var commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                var commandDelegate = commandCache.Cache.vkCmdDrawMeshTasksNV;
                commandDelegate(extendedHandle.handle, taskCount, firstTask);
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
        /// <param name="drawCount">
        /// </param>
        /// <param name="stride">
        /// </param>
        public static void DrawMeshTasksIndirect(this CommandBuffer extendedHandle, Buffer buffer, ulong offset, uint drawCount, uint stride)
        {
            try
            {
                var commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                var commandDelegate = commandCache.Cache.vkCmdDrawMeshTasksIndirectNV;
                commandDelegate(extendedHandle.handle, buffer?.handle ?? default(Interop.Buffer), offset, drawCount, stride);
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
        /// <param name="countBuffer">
        /// </param>
        /// <param name="countBufferOffset">
        /// </param>
        /// <param name="maxDrawCount">
        /// </param>
        /// <param name="stride">
        /// </param>
        public static void DrawMeshTasksIndirectCount(this CommandBuffer extendedHandle, Buffer buffer, ulong offset, Buffer countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride)
        {
            try
            {
                var commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                var commandDelegate = commandCache.Cache.vkCmdDrawMeshTasksIndirectCountNV;
                commandDelegate(extendedHandle.handle, buffer?.handle ?? default(Interop.Buffer), offset, countBuffer?.handle ?? default(Interop.Buffer), countBufferOffset, maxDrawCount, stride);
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
        /// <param name="firstExclusiveScissor">
        /// </param>
        /// <param name="exclusiveScissors">
        /// </param>
        public static unsafe void SetExclusiveScissor(this CommandBuffer extendedHandle, uint firstExclusiveScissor, ArrayProxy<Rect2D>? exclusiveScissors)
        {
            try
            {
                var commandCache = default(CommandCache);
                var marshalledExclusiveScissors = default(Rect2D*);
                commandCache = extendedHandle.commandCache;
                if (exclusiveScissors.IsNull())
                {
                    marshalledExclusiveScissors = null;
                }
                else
                {
                    if (exclusiveScissors.Value.Contents == ProxyContents.Single)
                    {
                        marshalledExclusiveScissors = (Rect2D*)HeapUtil.Allocate<Rect2D>();
                        *marshalledExclusiveScissors = exclusiveScissors.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (Rect2D*)HeapUtil.AllocateAndClear<Rect2D>(HeapUtil.GetLength(exclusiveScissors.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(exclusiveScissors.Value); index++) fieldPointer[index] = exclusiveScissors.Value[index];
                        marshalledExclusiveScissors = fieldPointer;
                    }
                }
                var commandDelegate = commandCache.Cache.vkCmdSetExclusiveScissorNV;
                commandDelegate(extendedHandle.handle, firstExclusiveScissor, HeapUtil.GetLength(exclusiveScissors), marshalledExclusiveScissors);
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
        /// <param name="checkpointMarker">
        /// </param>
        public static unsafe void SetCheckpoint(this CommandBuffer extendedHandle, IntPtr checkpointMarker)
        {
            try
            {
                var commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                var commandDelegate = commandCache.Cache.vkCmdSetCheckpointNV;
                commandDelegate(extendedHandle.handle, checkpointMarker.ToPointer());
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }
    }
}