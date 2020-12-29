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
using SharpVk.Multivendor;

namespace SharpVk
{
    /// <summary>
    ///     Opaque handle to a command buffer object.
    /// </summary>
    public partial class CommandBuffer
    {
        internal readonly CommandCache commandCache;
        internal readonly Interop.CommandBuffer handle;

        internal readonly CommandPool parent;

        internal CommandBuffer(CommandPool parent, Interop.CommandBuffer handle)
        {
            this.handle = handle;
            this.parent = parent;
            commandCache = parent.commandCache;
        }

        /// <summary>
        ///     The raw handle for this instance.
        /// </summary>
        public Interop.CommandBuffer RawHandle => handle;

        /// <summary>
        ///     Start recording a command buffer.
        /// </summary>
        /// <param name="flags">
        ///     A bitmask indicating usage behavior for the command buffer. Bits
        ///     which can be set include: + --
        /// </param>
        /// <param name="inheritanceInfo">
        /// </param>
        /// <param name="deviceGroupCommandBufferBeginInfo">
        ///     Extension struct
        /// </param>
        public unsafe void Begin(CommandBufferUsageFlags? flags = default, CommandBufferInheritanceInfo? inheritanceInfo = default, DeviceGroupCommandBufferBeginInfo? deviceGroupCommandBufferBeginInfo = null)
        {
            try
            {
                var marshalledBeginInfo = default(Interop.CommandBufferBeginInfo*);
                var vkCommandBufferBeginInfoNextPointer = default(void*);
                if (deviceGroupCommandBufferBeginInfo != null)
                {
                    var extensionPointer = default(Interop.DeviceGroupCommandBufferBeginInfo*);
                    extensionPointer = (Interop.DeviceGroupCommandBufferBeginInfo*)HeapUtil.Allocate<Interop.DeviceGroupCommandBufferBeginInfo>();
                    deviceGroupCommandBufferBeginInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkCommandBufferBeginInfoNextPointer;
                    vkCommandBufferBeginInfoNextPointer = extensionPointer;
                }
                marshalledBeginInfo = (Interop.CommandBufferBeginInfo*)HeapUtil.Allocate<Interop.CommandBufferBeginInfo>();
                marshalledBeginInfo->SType = StructureType.CommandBufferBeginInfo;
                marshalledBeginInfo->Next = vkCommandBufferBeginInfoNextPointer;
                if (flags != null)
                    marshalledBeginInfo->Flags = flags.Value;
                else
                    marshalledBeginInfo->Flags = default;
                if (inheritanceInfo != null)
                {
                    marshalledBeginInfo->InheritanceInfo = (Interop.CommandBufferInheritanceInfo*)HeapUtil.Allocate<Interop.CommandBufferInheritanceInfo>();
                    inheritanceInfo.Value.MarshalTo(marshalledBeginInfo->InheritanceInfo);
                }
                else
                {
                    marshalledBeginInfo->InheritanceInfo = default;
                }
                var commandDelegate = commandCache.Cache.vkBeginCommandBuffer;
                var methodResult = commandDelegate(handle, marshalledBeginInfo);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Finish recording a command buffer.
        /// </summary>
        public void End()
        {
            try
            {
                var commandDelegate = commandCache.Cache.vkEndCommandBuffer;
                var methodResult = commandDelegate(handle);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Reset a command buffer.
        /// </summary>
        /// <param name="flags">
        /// </param>
        public void Reset(CommandBufferResetFlags? flags = default)
        {
            try
            {
                var marshalledFlags = default(CommandBufferResetFlags);
                if (flags != null)
                    marshalledFlags = flags.Value;
                else
                    marshalledFlags = default;
                var commandDelegate = commandCache.Cache.vkResetCommandBuffer;
                var methodResult = commandDelegate(handle, marshalledFlags);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Bind a pipeline object to a command buffer.
        /// </summary>
        /// <param name="pipelineBindPoint">
        /// </param>
        /// <param name="pipeline">
        /// </param>
        public void BindPipeline(PipelineBindPoint pipelineBindPoint, Pipeline pipeline)
        {
            try
            {
                var commandDelegate = commandCache.Cache.vkCmdBindPipeline;
                commandDelegate(handle, pipelineBindPoint, pipeline?.handle ?? default(Interop.Pipeline));
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Set the viewport on a command buffer.
        /// </summary>
        /// <param name="firstViewport">
        /// </param>
        /// <param name="viewports">
        /// </param>
        public unsafe void SetViewport(uint firstViewport, ArrayProxy<Viewport>? viewports)
        {
            try
            {
                var marshalledViewports = default(Viewport*);
                if (viewports.IsNull())
                {
                    marshalledViewports = null;
                }
                else
                {
                    if (viewports.Value.Contents == ProxyContents.Single)
                    {
                        marshalledViewports = (Viewport*)HeapUtil.Allocate<Viewport>();
                        *marshalledViewports = viewports.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (Viewport*)HeapUtil.AllocateAndClear<Viewport>(HeapUtil.GetLength(viewports.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(viewports.Value); index++) fieldPointer[index] = viewports.Value[index];
                        marshalledViewports = fieldPointer;
                    }
                }
                var commandDelegate = commandCache.Cache.vkCmdSetViewport;
                commandDelegate(handle, firstViewport, HeapUtil.GetLength(viewports), marshalledViewports);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Set the dynamic scissor rectangles on a command buffer.
        /// </summary>
        /// <param name="firstScissor">
        /// </param>
        /// <param name="scissors">
        /// </param>
        public unsafe void SetScissor(uint firstScissor, ArrayProxy<Rect2D>? scissors)
        {
            try
            {
                var marshalledScissors = default(Rect2D*);
                if (scissors.IsNull())
                {
                    marshalledScissors = null;
                }
                else
                {
                    if (scissors.Value.Contents == ProxyContents.Single)
                    {
                        marshalledScissors = (Rect2D*)HeapUtil.Allocate<Rect2D>();
                        *marshalledScissors = scissors.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (Rect2D*)HeapUtil.AllocateAndClear<Rect2D>(HeapUtil.GetLength(scissors.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(scissors.Value); index++) fieldPointer[index] = scissors.Value[index];
                        marshalledScissors = fieldPointer;
                    }
                }
                var commandDelegate = commandCache.Cache.vkCmdSetScissor;
                commandDelegate(handle, firstScissor, HeapUtil.GetLength(scissors), marshalledScissors);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Set the dynamic line width state.
        /// </summary>
        /// <param name="lineWidth">
        /// </param>
        public void SetLineWidth(float lineWidth)
        {
            try
            {
                var commandDelegate = commandCache.Cache.vkCmdSetLineWidth;
                commandDelegate(handle, lineWidth);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Set the depth bias dynamic state.
        /// </summary>
        /// <param name="depthBiasConstantFactor">
        /// </param>
        /// <param name="depthBiasClamp">
        /// </param>
        /// <param name="depthBiasSlopeFactor">
        /// </param>
        public void SetDepthBias(float depthBiasConstantFactor, float depthBiasClamp, float depthBiasSlopeFactor)
        {
            try
            {
                var commandDelegate = commandCache.Cache.vkCmdSetDepthBias;
                commandDelegate(handle, depthBiasConstantFactor, depthBiasClamp, depthBiasSlopeFactor);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Set the values of blend constants.
        /// </summary>
        /// <param name="blendConstants">
        /// </param>
        public void SetBlendConstants(float blendConstants)
        {
            try
            {
                var commandDelegate = commandCache.Cache.vkCmdSetBlendConstants;
                commandDelegate(handle, blendConstants);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Set the depth bounds test values for a command buffer.
        /// </summary>
        /// <param name="minDepthBounds">
        /// </param>
        /// <param name="maxDepthBounds">
        /// </param>
        public void SetDepthBounds(float minDepthBounds, float maxDepthBounds)
        {
            try
            {
                var commandDelegate = commandCache.Cache.vkCmdSetDepthBounds;
                commandDelegate(handle, minDepthBounds, maxDepthBounds);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Set the stencil compare mask dynamic state.
        /// </summary>
        /// <param name="faceMask">
        /// </param>
        /// <param name="compareMask">
        /// </param>
        public void SetStencilCompareMask(StencilFaceFlags faceMask, uint compareMask)
        {
            try
            {
                var commandDelegate = commandCache.Cache.vkCmdSetStencilCompareMask;
                commandDelegate(handle, faceMask, compareMask);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Set the stencil write mask dynamic state.
        /// </summary>
        /// <param name="faceMask">
        /// </param>
        /// <param name="writeMask">
        /// </param>
        public void SetStencilWriteMask(StencilFaceFlags faceMask, uint writeMask)
        {
            try
            {
                var commandDelegate = commandCache.Cache.vkCmdSetStencilWriteMask;
                commandDelegate(handle, faceMask, writeMask);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Set the stencil reference dynamic state.
        /// </summary>
        /// <param name="faceMask">
        /// </param>
        /// <param name="reference">
        /// </param>
        public void SetStencilReference(StencilFaceFlags faceMask, uint reference)
        {
            try
            {
                var commandDelegate = commandCache.Cache.vkCmdSetStencilReference;
                commandDelegate(handle, faceMask, reference);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Binds descriptor sets to a command buffer.
        /// </summary>
        /// <param name="pipelineBindPoint">
        /// </param>
        /// <param name="layout">
        /// </param>
        /// <param name="firstSet">
        /// </param>
        /// <param name="descriptorSets">
        /// </param>
        /// <param name="dynamicOffsets">
        /// </param>
        public unsafe void BindDescriptorSets(PipelineBindPoint pipelineBindPoint, PipelineLayout layout, uint firstSet, ArrayProxy<DescriptorSet>? descriptorSets, ArrayProxy<uint>? dynamicOffsets)
        {
            try
            {
                var marshalledDescriptorSets = default(Interop.DescriptorSet*);
                var marshalledDynamicOffsets = default(uint*);
                if (descriptorSets.IsNull())
                {
                    marshalledDescriptorSets = null;
                }
                else
                {
                    if (descriptorSets.Value.Contents == ProxyContents.Single)
                    {
                        marshalledDescriptorSets = (Interop.DescriptorSet*)HeapUtil.Allocate<Interop.DescriptorSet>();
                        *marshalledDescriptorSets = descriptorSets.Value.GetSingleValue()?.handle ?? default(Interop.DescriptorSet);
                    }
                    else
                    {
                        var fieldPointer = (Interop.DescriptorSet*)HeapUtil.AllocateAndClear<Interop.DescriptorSet>(HeapUtil.GetLength(descriptorSets.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(descriptorSets.Value); index++) fieldPointer[index] = descriptorSets.Value[index]?.handle ?? default(Interop.DescriptorSet);
                        marshalledDescriptorSets = fieldPointer;
                    }
                }
                if (dynamicOffsets.IsNull())
                {
                    marshalledDynamicOffsets = null;
                }
                else
                {
                    if (dynamicOffsets.Value.Contents == ProxyContents.Single)
                    {
                        marshalledDynamicOffsets = (uint*)HeapUtil.Allocate<uint>();
                        *marshalledDynamicOffsets = dynamicOffsets.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (uint*)HeapUtil.AllocateAndClear<uint>(HeapUtil.GetLength(dynamicOffsets.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(dynamicOffsets.Value); index++) fieldPointer[index] = dynamicOffsets.Value[index];
                        marshalledDynamicOffsets = fieldPointer;
                    }
                }
                var commandDelegate = commandCache.Cache.vkCmdBindDescriptorSets;
                commandDelegate(handle, pipelineBindPoint, layout?.handle ?? default(Interop.PipelineLayout), firstSet, HeapUtil.GetLength(descriptorSets), marshalledDescriptorSets, HeapUtil.GetLength(dynamicOffsets), marshalledDynamicOffsets);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Bind an index buffer to a command buffer.
        /// </summary>
        /// <param name="buffer">
        /// </param>
        /// <param name="offset">
        /// </param>
        /// <param name="indexType">
        /// </param>
        public void BindIndexBuffer(Buffer buffer, ulong offset, IndexType indexType)
        {
            try
            {
                var commandDelegate = commandCache.Cache.vkCmdBindIndexBuffer;
                commandDelegate(handle, buffer?.handle ?? default(Interop.Buffer), offset, indexType);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Bind vertex buffers to a command buffer.
        /// </summary>
        /// <param name="firstBinding">
        /// </param>
        /// <param name="buffers">
        /// </param>
        /// <param name="offsets">
        /// </param>
        public unsafe void BindVertexBuffers(uint firstBinding, ArrayProxy<Buffer>? buffers, ArrayProxy<ulong>? offsets)
        {
            try
            {
                var marshalledBuffers = default(Interop.Buffer*);
                var marshalledOffsets = default(ulong*);
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
                var commandDelegate = commandCache.Cache.vkCmdBindVertexBuffers;
                commandDelegate(handle, firstBinding, HeapUtil.GetLength(buffers), marshalledBuffers, marshalledOffsets);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Draw primitives.
        /// </summary>
        /// <param name="vertexCount">
        /// </param>
        /// <param name="instanceCount">
        /// </param>
        /// <param name="firstVertex">
        /// </param>
        /// <param name="firstInstance">
        /// </param>
        public void Draw(uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance)
        {
            try
            {
                var commandDelegate = commandCache.Cache.vkCmdDraw;
                commandDelegate(handle, vertexCount, instanceCount, firstVertex, firstInstance);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Issue an indexed draw into a command buffer.
        /// </summary>
        /// <param name="indexCount">
        /// </param>
        /// <param name="instanceCount">
        /// </param>
        /// <param name="firstIndex">
        /// </param>
        /// <param name="vertexOffset">
        /// </param>
        /// <param name="firstInstance">
        /// </param>
        public void DrawIndexed(uint indexCount, uint instanceCount, uint firstIndex, int vertexOffset, uint firstInstance)
        {
            try
            {
                var commandDelegate = commandCache.Cache.vkCmdDrawIndexed;
                commandDelegate(handle, indexCount, instanceCount, firstIndex, vertexOffset, firstInstance);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Issue an indirect draw into a command buffer.
        /// </summary>
        /// <param name="buffer">
        /// </param>
        /// <param name="offset">
        /// </param>
        /// <param name="drawCount">
        /// </param>
        /// <param name="stride">
        /// </param>
        public void DrawIndirect(Buffer buffer, ulong offset, uint drawCount, uint stride)
        {
            try
            {
                var commandDelegate = commandCache.Cache.vkCmdDrawIndirect;
                commandDelegate(handle, buffer?.handle ?? default(Interop.Buffer), offset, drawCount, stride);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Perform an indexed indirect draw.
        /// </summary>
        /// <param name="buffer">
        /// </param>
        /// <param name="offset">
        /// </param>
        /// <param name="drawCount">
        /// </param>
        /// <param name="stride">
        /// </param>
        public void DrawIndexedIndirect(Buffer buffer, ulong offset, uint drawCount, uint stride)
        {
            try
            {
                var commandDelegate = commandCache.Cache.vkCmdDrawIndexedIndirect;
                commandDelegate(handle, buffer?.handle ?? default(Interop.Buffer), offset, drawCount, stride);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Dispatch compute work items.
        /// </summary>
        /// <param name="groupCountX">
        /// </param>
        /// <param name="groupCountY">
        /// </param>
        /// <param name="groupCountZ">
        /// </param>
        public void Dispatch(uint groupCountX, uint groupCountY, uint groupCountZ)
        {
            try
            {
                var commandDelegate = commandCache.Cache.vkCmdDispatch;
                commandDelegate(handle, groupCountX, groupCountY, groupCountZ);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Dispatch compute work items using indirect parameters.
        /// </summary>
        /// <param name="buffer">
        /// </param>
        /// <param name="offset">
        /// </param>
        public void DispatchIndirect(Buffer buffer, ulong offset)
        {
            try
            {
                var commandDelegate = commandCache.Cache.vkCmdDispatchIndirect;
                commandDelegate(handle, buffer?.handle ?? default(Interop.Buffer), offset);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Copy data between buffer regions.
        /// </summary>
        /// <param name="sourceBuffer">
        /// </param>
        /// <param name="destinationBuffer">
        /// </param>
        /// <param name="regions">
        /// </param>
        public unsafe void CopyBuffer(Buffer sourceBuffer, Buffer destinationBuffer, ArrayProxy<BufferCopy>? regions)
        {
            try
            {
                var marshalledRegions = default(BufferCopy*);
                if (regions.IsNull())
                {
                    marshalledRegions = null;
                }
                else
                {
                    if (regions.Value.Contents == ProxyContents.Single)
                    {
                        marshalledRegions = (BufferCopy*)HeapUtil.Allocate<BufferCopy>();
                        *marshalledRegions = regions.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (BufferCopy*)HeapUtil.AllocateAndClear<BufferCopy>(HeapUtil.GetLength(regions.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(regions.Value); index++) fieldPointer[index] = regions.Value[index];
                        marshalledRegions = fieldPointer;
                    }
                }
                var commandDelegate = commandCache.Cache.vkCmdCopyBuffer;
                commandDelegate(handle, sourceBuffer?.handle ?? default(Interop.Buffer), destinationBuffer?.handle ?? default(Interop.Buffer), HeapUtil.GetLength(regions), marshalledRegions);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Copy data between images.
        /// </summary>
        /// <param name="sourceImage">
        /// </param>
        /// <param name="sourceImageLayout">
        /// </param>
        /// <param name="destinationImage">
        /// </param>
        /// <param name="destinationImageLayout">
        /// </param>
        /// <param name="regions">
        /// </param>
        public unsafe void CopyImage(Image sourceImage, ImageLayout sourceImageLayout, Image destinationImage, ImageLayout destinationImageLayout, ArrayProxy<ImageCopy>? regions)
        {
            try
            {
                var marshalledRegions = default(ImageCopy*);
                if (regions.IsNull())
                {
                    marshalledRegions = null;
                }
                else
                {
                    if (regions.Value.Contents == ProxyContents.Single)
                    {
                        marshalledRegions = (ImageCopy*)HeapUtil.Allocate<ImageCopy>();
                        *marshalledRegions = regions.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (ImageCopy*)HeapUtil.AllocateAndClear<ImageCopy>(HeapUtil.GetLength(regions.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(regions.Value); index++) fieldPointer[index] = regions.Value[index];
                        marshalledRegions = fieldPointer;
                    }
                }
                var commandDelegate = commandCache.Cache.vkCmdCopyImage;
                commandDelegate(handle, sourceImage?.handle ?? default(Interop.Image), sourceImageLayout, destinationImage?.handle ?? default(Interop.Image), destinationImageLayout, HeapUtil.GetLength(regions), marshalledRegions);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Copy regions of an image, potentially performing format
        ///     conversion,.
        /// </summary>
        /// <param name="sourceImage">
        /// </param>
        /// <param name="sourceImageLayout">
        /// </param>
        /// <param name="destinationImage">
        /// </param>
        /// <param name="destinationImageLayout">
        /// </param>
        /// <param name="regions">
        /// </param>
        /// <param name="filter">
        /// </param>
        public unsafe void BlitImage(Image sourceImage, ImageLayout sourceImageLayout, Image destinationImage, ImageLayout destinationImageLayout, ArrayProxy<ImageBlit>? regions, Filter filter)
        {
            try
            {
                var marshalledRegions = default(Interop.ImageBlit*);
                if (regions.IsNull())
                {
                    marshalledRegions = null;
                }
                else
                {
                    if (regions.Value.Contents == ProxyContents.Single)
                    {
                        marshalledRegions = (Interop.ImageBlit*)HeapUtil.Allocate<Interop.ImageBlit>();
                        regions.Value.GetSingleValue().MarshalTo(&*marshalledRegions);
                    }
                    else
                    {
                        var fieldPointer = (Interop.ImageBlit*)HeapUtil.AllocateAndClear<Interop.ImageBlit>(HeapUtil.GetLength(regions.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(regions.Value); index++) regions.Value[index].MarshalTo(&fieldPointer[index]);
                        marshalledRegions = fieldPointer;
                    }
                }
                var commandDelegate = commandCache.Cache.vkCmdBlitImage;
                commandDelegate(handle, sourceImage?.handle ?? default(Interop.Image), sourceImageLayout, destinationImage?.handle ?? default(Interop.Image), destinationImageLayout, HeapUtil.GetLength(regions), marshalledRegions, filter);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Copy data from a buffer into an image.
        /// </summary>
        /// <param name="sourceBuffer">
        /// </param>
        /// <param name="destinationImage">
        /// </param>
        /// <param name="destinationImageLayout">
        /// </param>
        /// <param name="regions">
        /// </param>
        public unsafe void CopyBufferToImage(Buffer sourceBuffer, Image destinationImage, ImageLayout destinationImageLayout, ArrayProxy<BufferImageCopy>? regions)
        {
            try
            {
                var marshalledRegions = default(BufferImageCopy*);
                if (regions.IsNull())
                {
                    marshalledRegions = null;
                }
                else
                {
                    if (regions.Value.Contents == ProxyContents.Single)
                    {
                        marshalledRegions = (BufferImageCopy*)HeapUtil.Allocate<BufferImageCopy>();
                        *marshalledRegions = regions.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (BufferImageCopy*)HeapUtil.AllocateAndClear<BufferImageCopy>(HeapUtil.GetLength(regions.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(regions.Value); index++) fieldPointer[index] = regions.Value[index];
                        marshalledRegions = fieldPointer;
                    }
                }
                var commandDelegate = commandCache.Cache.vkCmdCopyBufferToImage;
                commandDelegate(handle, sourceBuffer?.handle ?? default(Interop.Buffer), destinationImage?.handle ?? default(Interop.Image), destinationImageLayout, HeapUtil.GetLength(regions), marshalledRegions);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Copy image data into a buffer.
        /// </summary>
        /// <param name="sourceImage">
        /// </param>
        /// <param name="sourceImageLayout">
        /// </param>
        /// <param name="destinationBuffer">
        /// </param>
        /// <param name="regions">
        /// </param>
        public unsafe void CopyImageToBuffer(Image sourceImage, ImageLayout sourceImageLayout, Buffer destinationBuffer, ArrayProxy<BufferImageCopy>? regions)
        {
            try
            {
                var marshalledRegions = default(BufferImageCopy*);
                if (regions.IsNull())
                {
                    marshalledRegions = null;
                }
                else
                {
                    if (regions.Value.Contents == ProxyContents.Single)
                    {
                        marshalledRegions = (BufferImageCopy*)HeapUtil.Allocate<BufferImageCopy>();
                        *marshalledRegions = regions.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (BufferImageCopy*)HeapUtil.AllocateAndClear<BufferImageCopy>(HeapUtil.GetLength(regions.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(regions.Value); index++) fieldPointer[index] = regions.Value[index];
                        marshalledRegions = fieldPointer;
                    }
                }
                var commandDelegate = commandCache.Cache.vkCmdCopyImageToBuffer;
                commandDelegate(handle, sourceImage?.handle ?? default(Interop.Image), sourceImageLayout, destinationBuffer?.handle ?? default(Interop.Buffer), HeapUtil.GetLength(regions), marshalledRegions);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Update a buffer's contents from host memory.
        /// </summary>
        /// <param name="destinationBuffer">
        /// </param>
        /// <param name="destinationOffset">
        /// </param>
        /// <param name="data">
        /// </param>
        public unsafe void UpdateBuffer(Buffer destinationBuffer, ulong destinationOffset, ArrayProxy<byte>? data)
        {
            try
            {
                var marshalledData = default(byte*);
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
                var commandDelegate = commandCache.Cache.vkCmdUpdateBuffer;
                commandDelegate(handle, destinationBuffer?.handle ?? default(Interop.Buffer), destinationOffset, HeapUtil.GetLength(data), marshalledData);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Fill a region of a buffer with a fixed value.
        /// </summary>
        /// <param name="destinationBuffer">
        /// </param>
        /// <param name="destinationOffset">
        /// </param>
        /// <param name="size">
        /// </param>
        /// <param name="data">
        /// </param>
        public void FillBuffer(Buffer destinationBuffer, ulong destinationOffset, ulong size, uint data)
        {
            try
            {
                var commandDelegate = commandCache.Cache.vkCmdFillBuffer;
                commandDelegate(handle, destinationBuffer?.handle ?? default(Interop.Buffer), destinationOffset, size, data);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Clear regions of a color image.
        /// </summary>
        /// <param name="image">
        /// </param>
        /// <param name="imageLayout">
        /// </param>
        /// <param name="color">
        /// </param>
        /// <param name="ranges">
        /// </param>
        public unsafe void ClearColorImage(Image image, ImageLayout imageLayout, ClearColorValue color, ArrayProxy<ImageSubresourceRange>? ranges)
        {
            try
            {
                var marshalledColor = default(ClearColorValue*);
                var marshalledRanges = default(ImageSubresourceRange*);
                marshalledColor = (ClearColorValue*)HeapUtil.Allocate<ClearColorValue>();
                *marshalledColor = color;
                if (ranges.IsNull())
                {
                    marshalledRanges = null;
                }
                else
                {
                    if (ranges.Value.Contents == ProxyContents.Single)
                    {
                        marshalledRanges = (ImageSubresourceRange*)HeapUtil.Allocate<ImageSubresourceRange>();
                        *marshalledRanges = ranges.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (ImageSubresourceRange*)HeapUtil.AllocateAndClear<ImageSubresourceRange>(HeapUtil.GetLength(ranges.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(ranges.Value); index++) fieldPointer[index] = ranges.Value[index];
                        marshalledRanges = fieldPointer;
                    }
                }
                var commandDelegate = commandCache.Cache.vkCmdClearColorImage;
                commandDelegate(handle, image?.handle ?? default(Interop.Image), imageLayout, marshalledColor, HeapUtil.GetLength(ranges), marshalledRanges);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Fill regions of a combined depth/stencil image.
        /// </summary>
        /// <param name="image">
        /// </param>
        /// <param name="imageLayout">
        /// </param>
        /// <param name="depthStencil">
        /// </param>
        /// <param name="ranges">
        /// </param>
        public unsafe void ClearDepthStencilImage(Image image, ImageLayout imageLayout, ClearDepthStencilValue depthStencil, ArrayProxy<ImageSubresourceRange>? ranges)
        {
            try
            {
                var marshalledDepthStencil = default(ClearDepthStencilValue*);
                var marshalledRanges = default(ImageSubresourceRange*);
                marshalledDepthStencil = (ClearDepthStencilValue*)HeapUtil.Allocate<ClearDepthStencilValue>();
                *marshalledDepthStencil = depthStencil;
                if (ranges.IsNull())
                {
                    marshalledRanges = null;
                }
                else
                {
                    if (ranges.Value.Contents == ProxyContents.Single)
                    {
                        marshalledRanges = (ImageSubresourceRange*)HeapUtil.Allocate<ImageSubresourceRange>();
                        *marshalledRanges = ranges.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (ImageSubresourceRange*)HeapUtil.AllocateAndClear<ImageSubresourceRange>(HeapUtil.GetLength(ranges.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(ranges.Value); index++) fieldPointer[index] = ranges.Value[index];
                        marshalledRanges = fieldPointer;
                    }
                }
                var commandDelegate = commandCache.Cache.vkCmdClearDepthStencilImage;
                commandDelegate(handle, image?.handle ?? default(Interop.Image), imageLayout, marshalledDepthStencil, HeapUtil.GetLength(ranges), marshalledRanges);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Clear regions within currently bound framebuffer attachments.
        /// </summary>
        /// <param name="attachments">
        /// </param>
        /// <param name="rects">
        /// </param>
        public unsafe void ClearAttachments(ArrayProxy<ClearAttachment>? attachments, ArrayProxy<ClearRect>? rects)
        {
            try
            {
                var marshalledAttachments = default(ClearAttachment*);
                var marshalledRects = default(ClearRect*);
                if (attachments.IsNull())
                {
                    marshalledAttachments = null;
                }
                else
                {
                    if (attachments.Value.Contents == ProxyContents.Single)
                    {
                        marshalledAttachments = (ClearAttachment*)HeapUtil.Allocate<ClearAttachment>();
                        *marshalledAttachments = attachments.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (ClearAttachment*)HeapUtil.AllocateAndClear<ClearAttachment>(HeapUtil.GetLength(attachments.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(attachments.Value); index++) fieldPointer[index] = attachments.Value[index];
                        marshalledAttachments = fieldPointer;
                    }
                }
                if (rects.IsNull())
                {
                    marshalledRects = null;
                }
                else
                {
                    if (rects.Value.Contents == ProxyContents.Single)
                    {
                        marshalledRects = (ClearRect*)HeapUtil.Allocate<ClearRect>();
                        *marshalledRects = rects.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (ClearRect*)HeapUtil.AllocateAndClear<ClearRect>(HeapUtil.GetLength(rects.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(rects.Value); index++) fieldPointer[index] = rects.Value[index];
                        marshalledRects = fieldPointer;
                    }
                }
                var commandDelegate = commandCache.Cache.vkCmdClearAttachments;
                commandDelegate(handle, HeapUtil.GetLength(attachments), marshalledAttachments, HeapUtil.GetLength(rects), marshalledRects);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Resolve regions of an image.
        /// </summary>
        /// <param name="sourceImage">
        /// </param>
        /// <param name="sourceImageLayout">
        /// </param>
        /// <param name="destinationImage">
        /// </param>
        /// <param name="destinationImageLayout">
        /// </param>
        /// <param name="regions">
        /// </param>
        public unsafe void ResolveImage(Image sourceImage, ImageLayout sourceImageLayout, Image destinationImage, ImageLayout destinationImageLayout, ArrayProxy<ImageResolve>? regions)
        {
            try
            {
                var marshalledRegions = default(ImageResolve*);
                if (regions.IsNull())
                {
                    marshalledRegions = null;
                }
                else
                {
                    if (regions.Value.Contents == ProxyContents.Single)
                    {
                        marshalledRegions = (ImageResolve*)HeapUtil.Allocate<ImageResolve>();
                        *marshalledRegions = regions.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (ImageResolve*)HeapUtil.AllocateAndClear<ImageResolve>(HeapUtil.GetLength(regions.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(regions.Value); index++) fieldPointer[index] = regions.Value[index];
                        marshalledRegions = fieldPointer;
                    }
                }
                var commandDelegate = commandCache.Cache.vkCmdResolveImage;
                commandDelegate(handle, sourceImage?.handle ?? default(Interop.Image), sourceImageLayout, destinationImage?.handle ?? default(Interop.Image), destinationImageLayout, HeapUtil.GetLength(regions), marshalledRegions);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Set an event object to signaled state.
        /// </summary>
        /// <param name="event">
        /// </param>
        /// <param name="stageMask">
        /// </param>
        public void SetEvent(Event @event, PipelineStageFlags stageMask)
        {
            try
            {
                var commandDelegate = commandCache.Cache.vkCmdSetEvent;
                commandDelegate(handle, @event?.handle ?? default(Interop.Event), stageMask);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Reset an event object to non-signaled state.
        /// </summary>
        /// <param name="event">
        /// </param>
        /// <param name="stageMask">
        /// </param>
        public void ResetEvent(Event @event, PipelineStageFlags stageMask)
        {
            try
            {
                var commandDelegate = commandCache.Cache.vkCmdResetEvent;
                commandDelegate(handle, @event?.handle ?? default(Interop.Event), stageMask);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Wait for one or more events and insert a set of memory.
        /// </summary>
        /// <param name="events">
        /// </param>
        /// <param name="sourceStageMask">
        /// </param>
        /// <param name="destinationStageMask">
        /// </param>
        /// <param name="memoryBarriers">
        /// </param>
        /// <param name="bufferMemoryBarriers">
        /// </param>
        /// <param name="imageMemoryBarriers">
        /// </param>
        public unsafe void WaitEvents(ArrayProxy<Event>? events, PipelineStageFlags sourceStageMask, PipelineStageFlags destinationStageMask, ArrayProxy<MemoryBarrier>? memoryBarriers, ArrayProxy<BufferMemoryBarrier>? bufferMemoryBarriers, ArrayProxy<ImageMemoryBarrier>? imageMemoryBarriers)
        {
            try
            {
                var marshalledEvents = default(Interop.Event*);
                var marshalledMemoryBarriers = default(Interop.MemoryBarrier*);
                var marshalledBufferMemoryBarriers = default(Interop.BufferMemoryBarrier*);
                var marshalledImageMemoryBarriers = default(Interop.ImageMemoryBarrier*);
                if (events.IsNull())
                {
                    marshalledEvents = null;
                }
                else
                {
                    if (events.Value.Contents == ProxyContents.Single)
                    {
                        marshalledEvents = (Interop.Event*)HeapUtil.Allocate<Interop.Event>();
                        *marshalledEvents = events.Value.GetSingleValue()?.handle ?? default(Interop.Event);
                    }
                    else
                    {
                        var fieldPointer = (Interop.Event*)HeapUtil.AllocateAndClear<Interop.Event>(HeapUtil.GetLength(events.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(events.Value); index++) fieldPointer[index] = events.Value[index]?.handle ?? default(Interop.Event);
                        marshalledEvents = fieldPointer;
                    }
                }
                if (memoryBarriers.IsNull())
                {
                    marshalledMemoryBarriers = null;
                }
                else
                {
                    if (memoryBarriers.Value.Contents == ProxyContents.Single)
                    {
                        marshalledMemoryBarriers = (Interop.MemoryBarrier*)HeapUtil.Allocate<Interop.MemoryBarrier>();
                        memoryBarriers.Value.GetSingleValue().MarshalTo(&*marshalledMemoryBarriers);
                    }
                    else
                    {
                        var fieldPointer = (Interop.MemoryBarrier*)HeapUtil.AllocateAndClear<Interop.MemoryBarrier>(HeapUtil.GetLength(memoryBarriers.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(memoryBarriers.Value); index++) memoryBarriers.Value[index].MarshalTo(&fieldPointer[index]);
                        marshalledMemoryBarriers = fieldPointer;
                    }
                }
                if (bufferMemoryBarriers.IsNull())
                {
                    marshalledBufferMemoryBarriers = null;
                }
                else
                {
                    if (bufferMemoryBarriers.Value.Contents == ProxyContents.Single)
                    {
                        marshalledBufferMemoryBarriers = (Interop.BufferMemoryBarrier*)HeapUtil.Allocate<Interop.BufferMemoryBarrier>();
                        bufferMemoryBarriers.Value.GetSingleValue().MarshalTo(&*marshalledBufferMemoryBarriers);
                    }
                    else
                    {
                        var fieldPointer = (Interop.BufferMemoryBarrier*)HeapUtil.AllocateAndClear<Interop.BufferMemoryBarrier>(HeapUtil.GetLength(bufferMemoryBarriers.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(bufferMemoryBarriers.Value); index++) bufferMemoryBarriers.Value[index].MarshalTo(&fieldPointer[index]);
                        marshalledBufferMemoryBarriers = fieldPointer;
                    }
                }
                if (imageMemoryBarriers.IsNull())
                {
                    marshalledImageMemoryBarriers = null;
                }
                else
                {
                    if (imageMemoryBarriers.Value.Contents == ProxyContents.Single)
                    {
                        marshalledImageMemoryBarriers = (Interop.ImageMemoryBarrier*)HeapUtil.Allocate<Interop.ImageMemoryBarrier>();
                        imageMemoryBarriers.Value.GetSingleValue().MarshalTo(&*marshalledImageMemoryBarriers);
                    }
                    else
                    {
                        var fieldPointer = (Interop.ImageMemoryBarrier*)HeapUtil.AllocateAndClear<Interop.ImageMemoryBarrier>(HeapUtil.GetLength(imageMemoryBarriers.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(imageMemoryBarriers.Value); index++) imageMemoryBarriers.Value[index].MarshalTo(&fieldPointer[index]);
                        marshalledImageMemoryBarriers = fieldPointer;
                    }
                }
                var commandDelegate = commandCache.Cache.vkCmdWaitEvents;
                commandDelegate(handle, HeapUtil.GetLength(events), marshalledEvents, sourceStageMask, destinationStageMask, HeapUtil.GetLength(memoryBarriers), marshalledMemoryBarriers, HeapUtil.GetLength(bufferMemoryBarriers), marshalledBufferMemoryBarriers, HeapUtil.GetLength(imageMemoryBarriers), marshalledImageMemoryBarriers);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Insert a memory dependency.
        /// </summary>
        /// <param name="sourceStageMask">
        /// </param>
        /// <param name="destinationStageMask">
        /// </param>
        /// <param name="dependencyFlags">
        /// </param>
        /// <param name="memoryBarriers">
        /// </param>
        /// <param name="bufferMemoryBarriers">
        /// </param>
        /// <param name="imageMemoryBarriers">
        /// </param>
        public unsafe void PipelineBarrier(PipelineStageFlags sourceStageMask, PipelineStageFlags destinationStageMask, ArrayProxy<MemoryBarrier>? memoryBarriers, ArrayProxy<BufferMemoryBarrier>? bufferMemoryBarriers, ArrayProxy<ImageMemoryBarrier>? imageMemoryBarriers, DependencyFlags? dependencyFlags = default)
        {
            try
            {
                var marshalledDependencyFlags = default(DependencyFlags);
                var marshalledMemoryBarriers = default(Interop.MemoryBarrier*);
                var marshalledBufferMemoryBarriers = default(Interop.BufferMemoryBarrier*);
                var marshalledImageMemoryBarriers = default(Interop.ImageMemoryBarrier*);
                if (dependencyFlags != null)
                    marshalledDependencyFlags = dependencyFlags.Value;
                else
                    marshalledDependencyFlags = default;
                if (memoryBarriers.IsNull())
                {
                    marshalledMemoryBarriers = null;
                }
                else
                {
                    if (memoryBarriers.Value.Contents == ProxyContents.Single)
                    {
                        marshalledMemoryBarriers = (Interop.MemoryBarrier*)HeapUtil.Allocate<Interop.MemoryBarrier>();
                        memoryBarriers.Value.GetSingleValue().MarshalTo(&*marshalledMemoryBarriers);
                    }
                    else
                    {
                        var fieldPointer = (Interop.MemoryBarrier*)HeapUtil.AllocateAndClear<Interop.MemoryBarrier>(HeapUtil.GetLength(memoryBarriers.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(memoryBarriers.Value); index++) memoryBarriers.Value[index].MarshalTo(&fieldPointer[index]);
                        marshalledMemoryBarriers = fieldPointer;
                    }
                }
                if (bufferMemoryBarriers.IsNull())
                {
                    marshalledBufferMemoryBarriers = null;
                }
                else
                {
                    if (bufferMemoryBarriers.Value.Contents == ProxyContents.Single)
                    {
                        marshalledBufferMemoryBarriers = (Interop.BufferMemoryBarrier*)HeapUtil.Allocate<Interop.BufferMemoryBarrier>();
                        bufferMemoryBarriers.Value.GetSingleValue().MarshalTo(&*marshalledBufferMemoryBarriers);
                    }
                    else
                    {
                        var fieldPointer = (Interop.BufferMemoryBarrier*)HeapUtil.AllocateAndClear<Interop.BufferMemoryBarrier>(HeapUtil.GetLength(bufferMemoryBarriers.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(bufferMemoryBarriers.Value); index++) bufferMemoryBarriers.Value[index].MarshalTo(&fieldPointer[index]);
                        marshalledBufferMemoryBarriers = fieldPointer;
                    }
                }
                if (imageMemoryBarriers.IsNull())
                {
                    marshalledImageMemoryBarriers = null;
                }
                else
                {
                    if (imageMemoryBarriers.Value.Contents == ProxyContents.Single)
                    {
                        marshalledImageMemoryBarriers = (Interop.ImageMemoryBarrier*)HeapUtil.Allocate<Interop.ImageMemoryBarrier>();
                        imageMemoryBarriers.Value.GetSingleValue().MarshalTo(&*marshalledImageMemoryBarriers);
                    }
                    else
                    {
                        var fieldPointer = (Interop.ImageMemoryBarrier*)HeapUtil.AllocateAndClear<Interop.ImageMemoryBarrier>(HeapUtil.GetLength(imageMemoryBarriers.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(imageMemoryBarriers.Value); index++) imageMemoryBarriers.Value[index].MarshalTo(&fieldPointer[index]);
                        marshalledImageMemoryBarriers = fieldPointer;
                    }
                }
                var commandDelegate = commandCache.Cache.vkCmdPipelineBarrier;
                commandDelegate(handle, sourceStageMask, destinationStageMask, marshalledDependencyFlags, HeapUtil.GetLength(memoryBarriers), marshalledMemoryBarriers, HeapUtil.GetLength(bufferMemoryBarriers), marshalledBufferMemoryBarriers, HeapUtil.GetLength(imageMemoryBarriers), marshalledImageMemoryBarriers);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Begin a query.
        /// </summary>
        /// <param name="queryPool">
        /// </param>
        /// <param name="query">
        /// </param>
        /// <param name="flags">
        /// </param>
        public void BeginQuery(QueryPool queryPool, uint query, QueryControlFlags? flags = default)
        {
            try
            {
                var marshalledFlags = default(QueryControlFlags);
                if (flags != null)
                    marshalledFlags = flags.Value;
                else
                    marshalledFlags = default;
                var commandDelegate = commandCache.Cache.vkCmdBeginQuery;
                commandDelegate(handle, queryPool?.handle ?? default(Interop.QueryPool), query, marshalledFlags);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Ends a query.
        /// </summary>
        /// <param name="queryPool">
        /// </param>
        /// <param name="query">
        /// </param>
        public void EndQuery(QueryPool queryPool, uint query)
        {
            try
            {
                var commandDelegate = commandCache.Cache.vkCmdEndQuery;
                commandDelegate(handle, queryPool?.handle ?? default(Interop.QueryPool), query);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Reset queries in a query pool.
        /// </summary>
        /// <param name="queryPool">
        /// </param>
        /// <param name="firstQuery">
        /// </param>
        /// <param name="queryCount">
        /// </param>
        public void ResetQueryPool(QueryPool queryPool, uint firstQuery, uint queryCount)
        {
            try
            {
                var commandDelegate = commandCache.Cache.vkCmdResetQueryPool;
                commandDelegate(handle, queryPool?.handle ?? default(Interop.QueryPool), firstQuery, queryCount);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Write a device timestamp into a query object.
        /// </summary>
        /// <param name="pipelineStage">
        /// </param>
        /// <param name="queryPool">
        /// </param>
        /// <param name="query">
        /// </param>
        public void WriteTimestamp(PipelineStageFlags pipelineStage, QueryPool queryPool, uint query)
        {
            try
            {
                var commandDelegate = commandCache.Cache.vkCmdWriteTimestamp;
                commandDelegate(handle, pipelineStage, queryPool?.handle ?? default(Interop.QueryPool), query);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Copy the results of queries in a query pool to a buffer object.
        /// </summary>
        /// <param name="queryPool">
        /// </param>
        /// <param name="firstQuery">
        /// </param>
        /// <param name="queryCount">
        /// </param>
        /// <param name="destinationBuffer">
        /// </param>
        /// <param name="destinationOffset">
        /// </param>
        /// <param name="stride">
        /// </param>
        /// <param name="flags">
        /// </param>
        public void CopyQueryPoolResults(QueryPool queryPool, uint firstQuery, uint queryCount, Buffer destinationBuffer, ulong destinationOffset, ulong stride, QueryResultFlags? flags = default)
        {
            try
            {
                var marshalledFlags = default(QueryResultFlags);
                if (flags != null)
                    marshalledFlags = flags.Value;
                else
                    marshalledFlags = default;
                var commandDelegate = commandCache.Cache.vkCmdCopyQueryPoolResults;
                commandDelegate(handle, queryPool?.handle ?? default(Interop.QueryPool), firstQuery, queryCount, destinationBuffer?.handle ?? default(Interop.Buffer), destinationOffset, stride, marshalledFlags);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Update the values of push constants.
        /// </summary>
        /// <param name="layout">
        /// </param>
        /// <param name="stageFlags">
        /// </param>
        /// <param name="offset">
        /// </param>
        /// <param name="values">
        /// </param>
        public unsafe void PushConstants(PipelineLayout layout, ShaderStageFlags stageFlags, uint offset, ArrayProxy<byte>? values)
        {
            try
            {
                var marshalledValues = default(byte*);
                if (values.IsNull())
                {
                    marshalledValues = null;
                }
                else
                {
                    if (values.Value.Contents == ProxyContents.Single)
                    {
                        marshalledValues = (byte*)HeapUtil.Allocate<byte>();
                        *marshalledValues = values.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (byte*)HeapUtil.AllocateAndClear<byte>(HeapUtil.GetLength(values.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(values.Value); index++) fieldPointer[index] = values.Value[index];
                        marshalledValues = fieldPointer;
                    }
                }
                var commandDelegate = commandCache.Cache.vkCmdPushConstants;
                commandDelegate(handle, layout?.handle ?? default(Interop.PipelineLayout), stageFlags, offset, HeapUtil.GetLength(values), marshalledValues);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Begin a new render pass.
        /// </summary>
        /// <param name="renderPass">
        ///     The render pass to begin an instance of.
        /// </param>
        /// <param name="framebuffer">
        ///     The framebuffer containing the attachments that are used with the
        ///     render pass.
        /// </param>
        /// <param name="renderArea">
        ///     The render area that is affected by the render pass instance, and
        ///     is described in more detail below.
        /// </param>
        /// <param name="clearValues">
        /// </param>
        /// <param name="deviceGroupRenderPassBeginInfo">
        ///     Extension struct
        /// </param>
        /// <param name="renderPassSampleLocationsBeginInfoExt">
        ///     Extension struct
        /// </param>
        /// <param name="renderPassAttachmentBeginInfo">
        ///     Extension struct
        /// </param>
        /// <param name="contents">
        /// </param>
        public unsafe void BeginRenderPass(RenderPass renderPass, Framebuffer framebuffer, Rect2D renderArea, ArrayProxy<ClearValue>? clearValues, SubpassContents contents, DeviceGroupRenderPassBeginInfo? deviceGroupRenderPassBeginInfo = null, RenderPassSampleLocationsBeginInfo? renderPassSampleLocationsBeginInfoExt = null, RenderPassAttachmentBeginInfo? renderPassAttachmentBeginInfo = null)
        {
            try
            {
                var marshalledRenderPassBegin = default(Interop.RenderPassBeginInfo*);
                var vkRenderPassBeginInfoNextPointer = default(void*);
                if (deviceGroupRenderPassBeginInfo != null)
                {
                    var extensionPointer = default(Interop.DeviceGroupRenderPassBeginInfo*);
                    extensionPointer = (Interop.DeviceGroupRenderPassBeginInfo*)HeapUtil.Allocate<Interop.DeviceGroupRenderPassBeginInfo>();
                    deviceGroupRenderPassBeginInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkRenderPassBeginInfoNextPointer;
                    vkRenderPassBeginInfoNextPointer = extensionPointer;
                }
                if (renderPassSampleLocationsBeginInfoExt != null)
                {
                    var extensionPointer = default(Interop.Multivendor.RenderPassSampleLocationsBeginInfo*);
                    extensionPointer = (Interop.Multivendor.RenderPassSampleLocationsBeginInfo*)HeapUtil.Allocate<Interop.Multivendor.RenderPassSampleLocationsBeginInfo>();
                    renderPassSampleLocationsBeginInfoExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkRenderPassBeginInfoNextPointer;
                    vkRenderPassBeginInfoNextPointer = extensionPointer;
                }
                if (renderPassAttachmentBeginInfo != null)
                {
                    var extensionPointer = default(Interop.RenderPassAttachmentBeginInfo*);
                    extensionPointer = (Interop.RenderPassAttachmentBeginInfo*)HeapUtil.Allocate<Interop.RenderPassAttachmentBeginInfo>();
                    renderPassAttachmentBeginInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkRenderPassBeginInfoNextPointer;
                    vkRenderPassBeginInfoNextPointer = extensionPointer;
                }
                marshalledRenderPassBegin = (Interop.RenderPassBeginInfo*)HeapUtil.Allocate<Interop.RenderPassBeginInfo>();
                marshalledRenderPassBegin->SType = StructureType.RenderPassBeginInfo;
                marshalledRenderPassBegin->Next = vkRenderPassBeginInfoNextPointer;
                marshalledRenderPassBegin->RenderPass = renderPass?.handle ?? default(Interop.RenderPass);
                marshalledRenderPassBegin->Framebuffer = framebuffer?.handle ?? default(Interop.Framebuffer);
                marshalledRenderPassBegin->RenderArea = renderArea;
                marshalledRenderPassBegin->ClearValueCount = HeapUtil.GetLength(clearValues);
                if (clearValues.IsNull())
                {
                    marshalledRenderPassBegin->ClearValues = null;
                }
                else
                {
                    if (clearValues.Value.Contents == ProxyContents.Single)
                    {
                        marshalledRenderPassBegin->ClearValues = (ClearValue*)HeapUtil.Allocate<ClearValue>();
                        *marshalledRenderPassBegin->ClearValues = clearValues.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (ClearValue*)HeapUtil.AllocateAndClear<ClearValue>(HeapUtil.GetLength(clearValues.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(clearValues.Value); index++) fieldPointer[index] = clearValues.Value[index];
                        marshalledRenderPassBegin->ClearValues = fieldPointer;
                    }
                }
                var commandDelegate = commandCache.Cache.vkCmdBeginRenderPass;
                commandDelegate(handle, marshalledRenderPassBegin, contents);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Transition to the next subpass of a render pass.
        /// </summary>
        /// <param name="contents">
        /// </param>
        public void NextSubpass(SubpassContents contents)
        {
            try
            {
                var commandDelegate = commandCache.Cache.vkCmdNextSubpass;
                commandDelegate(handle, contents);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     End the current render pass.
        /// </summary>
        public void EndRenderPass()
        {
            try
            {
                var commandDelegate = commandCache.Cache.vkCmdEndRenderPass;
                commandDelegate(handle);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Execute a secondary command buffer from a primary command buffer.
        /// </summary>
        /// <param name="commandBuffers">
        /// </param>
        public unsafe void ExecuteCommands(ArrayProxy<CommandBuffer>? commandBuffers)
        {
            try
            {
                var marshalledCommandBuffers = default(Interop.CommandBuffer*);
                if (commandBuffers.IsNull())
                {
                    marshalledCommandBuffers = null;
                }
                else
                {
                    if (commandBuffers.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCommandBuffers = (Interop.CommandBuffer*)HeapUtil.Allocate<Interop.CommandBuffer>();
                        *marshalledCommandBuffers = commandBuffers.Value.GetSingleValue()?.handle ?? default(Interop.CommandBuffer);
                    }
                    else
                    {
                        var fieldPointer = (Interop.CommandBuffer*)HeapUtil.AllocateAndClear<Interop.CommandBuffer>(HeapUtil.GetLength(commandBuffers.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(commandBuffers.Value); index++) fieldPointer[index] = commandBuffers.Value[index]?.handle ?? default(Interop.CommandBuffer);
                        marshalledCommandBuffers = fieldPointer;
                    }
                }
                var commandDelegate = commandCache.Cache.vkCmdExecuteCommands;
                commandDelegate(handle, HeapUtil.GetLength(commandBuffers), marshalledCommandBuffers);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="deviceMask">
        /// </param>
        public void SetDeviceMask(uint deviceMask)
        {
            try
            {
                var commandDelegate = commandCache.Cache.vkCmdSetDeviceMask;
                commandDelegate(handle, deviceMask);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="baseGroupX">
        /// </param>
        /// <param name="baseGroupY">
        /// </param>
        /// <param name="baseGroupZ">
        /// </param>
        /// <param name="groupCountX">
        /// </param>
        /// <param name="groupCountY">
        /// </param>
        /// <param name="groupCountZ">
        /// </param>
        public void DispatchBase(uint baseGroupX, uint baseGroupY, uint baseGroupZ, uint groupCountX, uint groupCountY, uint groupCountZ)
        {
            try
            {
                var commandDelegate = commandCache.Cache.vkCmdDispatchBase;
                commandDelegate(handle, baseGroupX, baseGroupY, baseGroupZ, groupCountX, groupCountY, groupCountZ);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        /// </summary>
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
        public void DrawIndirectCount(Buffer buffer, ulong offset, Buffer countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride)
        {
            try
            {
                var commandDelegate = commandCache.Cache.vkCmdDrawIndirectCount;
                commandDelegate(handle, buffer?.handle ?? default(Interop.Buffer), offset, countBuffer?.handle ?? default(Interop.Buffer), countBufferOffset, maxDrawCount, stride);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        /// </summary>
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
        public void DrawIndexedIndirectCount(Buffer buffer, ulong offset, Buffer countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride)
        {
            try
            {
                var commandDelegate = commandCache.Cache.vkCmdDrawIndexedIndirectCount;
                commandDelegate(handle, buffer?.handle ?? default(Interop.Buffer), offset, countBuffer?.handle ?? default(Interop.Buffer), countBufferOffset, maxDrawCount, stride);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="renderPass">
        ///     The render pass to begin an instance of.
        /// </param>
        /// <param name="framebuffer">
        ///     The framebuffer containing the attachments that are used with the
        ///     render pass.
        /// </param>
        /// <param name="renderArea">
        ///     The render area that is affected by the render pass instance, and
        ///     is described in more detail below.
        /// </param>
        /// <param name="clearValues">
        /// </param>
        /// <param name="deviceGroupRenderPassBeginInfo">
        ///     Extension struct
        /// </param>
        /// <param name="renderPassSampleLocationsBeginInfoExt">
        ///     Extension struct
        /// </param>
        /// <param name="renderPassAttachmentBeginInfo">
        ///     Extension struct
        /// </param>
        /// <param name="contents">
        /// </param>
        public unsafe void BeginRenderPass2(RenderPass renderPass, Framebuffer framebuffer, Rect2D renderArea, ArrayProxy<ClearValue>? clearValues, SubpassContents contents, DeviceGroupRenderPassBeginInfo? deviceGroupRenderPassBeginInfo = null, RenderPassSampleLocationsBeginInfo? renderPassSampleLocationsBeginInfoExt = null, RenderPassAttachmentBeginInfo? renderPassAttachmentBeginInfo = null)
        {
            try
            {
                var marshalledRenderPassBegin = default(Interop.RenderPassBeginInfo*);
                var vkRenderPassBeginInfoNextPointer = default(void*);
                var marshalledSubpassBeginInfo = default(Interop.SubpassBeginInfo*);
                var vkSubpassBeginInfoNextPointer = default(void*);
                if (deviceGroupRenderPassBeginInfo != null)
                {
                    var extensionPointer = default(Interop.DeviceGroupRenderPassBeginInfo*);
                    extensionPointer = (Interop.DeviceGroupRenderPassBeginInfo*)HeapUtil.Allocate<Interop.DeviceGroupRenderPassBeginInfo>();
                    deviceGroupRenderPassBeginInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkRenderPassBeginInfoNextPointer;
                    vkRenderPassBeginInfoNextPointer = extensionPointer;
                }
                if (renderPassSampleLocationsBeginInfoExt != null)
                {
                    var extensionPointer = default(Interop.Multivendor.RenderPassSampleLocationsBeginInfo*);
                    extensionPointer = (Interop.Multivendor.RenderPassSampleLocationsBeginInfo*)HeapUtil.Allocate<Interop.Multivendor.RenderPassSampleLocationsBeginInfo>();
                    renderPassSampleLocationsBeginInfoExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkRenderPassBeginInfoNextPointer;
                    vkRenderPassBeginInfoNextPointer = extensionPointer;
                }
                if (renderPassAttachmentBeginInfo != null)
                {
                    var extensionPointer = default(Interop.RenderPassAttachmentBeginInfo*);
                    extensionPointer = (Interop.RenderPassAttachmentBeginInfo*)HeapUtil.Allocate<Interop.RenderPassAttachmentBeginInfo>();
                    renderPassAttachmentBeginInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkRenderPassBeginInfoNextPointer;
                    vkRenderPassBeginInfoNextPointer = extensionPointer;
                }
                marshalledRenderPassBegin = (Interop.RenderPassBeginInfo*)HeapUtil.Allocate<Interop.RenderPassBeginInfo>();
                marshalledRenderPassBegin->SType = StructureType.RenderPassBeginInfo;
                marshalledRenderPassBegin->Next = vkRenderPassBeginInfoNextPointer;
                marshalledRenderPassBegin->RenderPass = renderPass?.handle ?? default(Interop.RenderPass);
                marshalledRenderPassBegin->Framebuffer = framebuffer?.handle ?? default(Interop.Framebuffer);
                marshalledRenderPassBegin->RenderArea = renderArea;
                marshalledRenderPassBegin->ClearValueCount = HeapUtil.GetLength(clearValues);
                if (clearValues.IsNull())
                {
                    marshalledRenderPassBegin->ClearValues = null;
                }
                else
                {
                    if (clearValues.Value.Contents == ProxyContents.Single)
                    {
                        marshalledRenderPassBegin->ClearValues = (ClearValue*)HeapUtil.Allocate<ClearValue>();
                        *marshalledRenderPassBegin->ClearValues = clearValues.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (ClearValue*)HeapUtil.AllocateAndClear<ClearValue>(HeapUtil.GetLength(clearValues.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(clearValues.Value); index++) fieldPointer[index] = clearValues.Value[index];
                        marshalledRenderPassBegin->ClearValues = fieldPointer;
                    }
                }
                marshalledSubpassBeginInfo = (Interop.SubpassBeginInfo*)HeapUtil.Allocate<Interop.SubpassBeginInfo>();
                marshalledSubpassBeginInfo->SType = StructureType.SubpassBeginInfoVersion;
                marshalledSubpassBeginInfo->Next = vkSubpassBeginInfoNextPointer;
                marshalledSubpassBeginInfo->Contents = contents;
                var commandDelegate = commandCache.Cache.vkCmdBeginRenderPass2;
                commandDelegate(handle, marshalledRenderPassBegin, marshalledSubpassBeginInfo);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="subpassBeginInfo">
        /// </param>
        /// <param name="subpassEndInfo">
        /// </param>
        public unsafe void NextSubpass2(SubpassBeginInfo subpassBeginInfo, SubpassEndInfo subpassEndInfo)
        {
            try
            {
                var marshalledSubpassBeginInfo = default(Interop.SubpassBeginInfo*);
                var marshalledSubpassEndInfo = default(Interop.SubpassEndInfo*);
                marshalledSubpassBeginInfo = (Interop.SubpassBeginInfo*)HeapUtil.Allocate<Interop.SubpassBeginInfo>();
                subpassBeginInfo.MarshalTo(marshalledSubpassBeginInfo);
                marshalledSubpassEndInfo = (Interop.SubpassEndInfo*)HeapUtil.Allocate<Interop.SubpassEndInfo>();
                subpassEndInfo.MarshalTo(marshalledSubpassEndInfo);
                var commandDelegate = commandCache.Cache.vkCmdNextSubpass2;
                commandDelegate(handle, marshalledSubpassBeginInfo, marshalledSubpassEndInfo);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        /// </summary>
        public unsafe void EndRenderPass2()
        {
            try
            {
                var marshalledSubpassEndInfo = default(Interop.SubpassEndInfo*);
                var vkSubpassEndInfoNextPointer = default(void*);
                marshalledSubpassEndInfo = (Interop.SubpassEndInfo*)HeapUtil.Allocate<Interop.SubpassEndInfo>();
                marshalledSubpassEndInfo->SType = StructureType.SubpassEndInfoVersion;
                marshalledSubpassEndInfo->Next = vkSubpassEndInfoNextPointer;
                var commandDelegate = commandCache.Cache.vkCmdEndRenderPass2;
                commandDelegate(handle, marshalledSubpassEndInfo);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }
    }
}