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

using System.Runtime.InteropServices;
using SharpVk.Interop;

namespace SharpVk
{
    /// <summary>
    ///     Structure specifying parameters of a newly created graphics pipeline.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct GraphicsPipelineCreateInfo
    {
        /// <summary>
        ///     A bitmask of PipelineCreateFlagBits controlling how the pipeline
        ///     will be generated, as described below.
        /// </summary>
        public PipelineCreateFlags? Flags
        {
            get;
            set;
        }

        /// <summary>
        ///     An array of size stageCount structures of type
        ///     PipelineShaderStageCreateInfo describing the set of the shader
        ///     stages to be included in the graphics pipeline.
        /// </summary>
        public PipelineShaderStageCreateInfo[] Stages
        {
            get;
            set;
        }

        /// <summary>
        ///     An instance of the PipelineVertexInputStateCreateInfo structure.
        /// </summary>
        public PipelineVertexInputStateCreateInfo? VertexInputState
        {
            get;
            set;
        }

        /// <summary>
        ///     An instance of the PipelineInputAssemblyStateCreateInfo structure
        ///     which determines input assembly behavior.
        /// </summary>
        public PipelineInputAssemblyStateCreateInfo? InputAssemblyState
        {
            get;
            set;
        }

        /// <summary>
        ///     An instance of the PipelineTessellationStateCreateInfo structure,
        ///     or Null if the pipeline does not include a tessellation control
        ///     shader stage and tessellation evaluation shader stage.
        /// </summary>
        public PipelineTessellationStateCreateInfo? TessellationState
        {
            get;
            set;
        }

        /// <summary>
        ///     An instance of the PipelineViewportStateCreateInfo structure, or
        ///     Null if the pipeline has rasterization disabled.
        /// </summary>
        public PipelineViewportStateCreateInfo? ViewportState
        {
            get;
            set;
        }

        /// <summary>
        ///     An instance of the PipelineRasterizationStateCreateInfo structure.
        /// </summary>
        public PipelineRasterizationStateCreateInfo RasterizationState
        {
            get;
            set;
        }

        /// <summary>
        ///     An instance of the PipelineMultisampleStateCreateInfo, or Null if
        ///     the pipeline has rasterization disabled.
        /// </summary>
        public PipelineMultisampleStateCreateInfo? MultisampleState
        {
            get;
            set;
        }

        /// <summary>
        ///     An instance of the PipelineDepthStencilStateCreateInfo structure,
        ///     or Null if the pipeline has rasterization disabled or if the
        ///     subpass of the render pass the pipeline is created against does not
        ///     use a depth/stencil attachment.
        /// </summary>
        public PipelineDepthStencilStateCreateInfo? DepthStencilState
        {
            get;
            set;
        }

        /// <summary>
        ///     An instance of the PipelineColorBlendStateCreateInfo structure, or
        ///     Null if the pipeline has rasterization disabled or if the subpass
        ///     of the render pass the pipeline is created against does not use any
        ///     color attachments.
        /// </summary>
        public PipelineColorBlendStateCreateInfo? ColorBlendState
        {
            get;
            set;
        }

        /// <summary>
        ///     A pointer to PipelineDynamicStateCreateInfo and is used to indicate
        ///     which properties of the pipeline state object are dynamic and can
        ///     be changed independently of the pipeline state. This can be Null,
        ///     which means no state in the pipeline is considered dynamic.
        /// </summary>
        public PipelineDynamicStateCreateInfo? DynamicState
        {
            get;
            set;
        }

        /// <summary>
        ///     The description of binding locations used by both the pipeline and
        ///     descriptor sets used with the pipeline.
        /// </summary>
        public PipelineLayout Layout
        {
            get;
            set;
        }

        /// <summary>
        ///     A handle to a render pass object describing the environment in
        ///     which the pipeline will be used; the pipeline must only be used
        ///     with an instance of any render pass compatible with the one
        ///     provided.
        /// </summary>
        public RenderPass RenderPass
        {
            get;
            set;
        }

        /// <summary>
        ///     The index of the subpass in the render pass where this pipeline
        ///     will be used.
        /// </summary>
        public uint Subpass
        {
            get;
            set;
        }

        /// <summary>
        ///     A pipeline to derive from.
        /// </summary>
        public Pipeline BasePipelineHandle
        {
            get;
            set;
        }

        /// <summary>
        ///     An index into the pCreateInfos parameter to use as a pipeline to
        ///     derive from.
        /// </summary>
        public int BasePipelineIndex
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(Interop.GraphicsPipelineCreateInfo* pointer)
        {
            pointer->SType = StructureType.GraphicsPipelineCreateInfo;
            pointer->Next = null;
            if (Flags != null)
                pointer->Flags = Flags.Value;
            else
                pointer->Flags = default;
            pointer->StageCount = HeapUtil.GetLength(Stages);
            if (Stages != null)
            {
                var fieldPointer = (Interop.PipelineShaderStageCreateInfo*)HeapUtil.AllocateAndClear<Interop.PipelineShaderStageCreateInfo>(Stages.Length).ToPointer();
                for (var index = 0; index < (uint)Stages.Length; index++) Stages[index].MarshalTo(&fieldPointer[index]);
                pointer->Stages = fieldPointer;
            }
            else
            {
                pointer->Stages = null;
            }
            if (VertexInputState != null)
            {
                pointer->VertexInputState = (Interop.PipelineVertexInputStateCreateInfo*)HeapUtil.Allocate<Interop.PipelineVertexInputStateCreateInfo>();
                VertexInputState.Value.MarshalTo(pointer->VertexInputState);
            }
            else
            {
                pointer->VertexInputState = default;
            }
            if (InputAssemblyState != null)
            {
                pointer->InputAssemblyState = (Interop.PipelineInputAssemblyStateCreateInfo*)HeapUtil.Allocate<Interop.PipelineInputAssemblyStateCreateInfo>();
                InputAssemblyState.Value.MarshalTo(pointer->InputAssemblyState);
            }
            else
            {
                pointer->InputAssemblyState = default;
            }
            if (TessellationState != null)
            {
                pointer->TessellationState = (Interop.PipelineTessellationStateCreateInfo*)HeapUtil.Allocate<Interop.PipelineTessellationStateCreateInfo>();
                TessellationState.Value.MarshalTo(pointer->TessellationState);
            }
            else
            {
                pointer->TessellationState = default;
            }
            if (ViewportState != null)
            {
                pointer->ViewportState = (Interop.PipelineViewportStateCreateInfo*)HeapUtil.Allocate<Interop.PipelineViewportStateCreateInfo>();
                ViewportState.Value.MarshalTo(pointer->ViewportState);
            }
            else
            {
                pointer->ViewportState = default;
            }
            pointer->RasterizationState = (Interop.PipelineRasterizationStateCreateInfo*)HeapUtil.Allocate<Interop.PipelineRasterizationStateCreateInfo>();
            RasterizationState.MarshalTo(pointer->RasterizationState);
            if (MultisampleState != null)
            {
                pointer->MultisampleState = (Interop.PipelineMultisampleStateCreateInfo*)HeapUtil.Allocate<Interop.PipelineMultisampleStateCreateInfo>();
                MultisampleState.Value.MarshalTo(pointer->MultisampleState);
            }
            else
            {
                pointer->MultisampleState = default;
            }
            if (DepthStencilState != null)
            {
                pointer->DepthStencilState = (Interop.PipelineDepthStencilStateCreateInfo*)HeapUtil.Allocate<Interop.PipelineDepthStencilStateCreateInfo>();
                DepthStencilState.Value.MarshalTo(pointer->DepthStencilState);
            }
            else
            {
                pointer->DepthStencilState = default;
            }
            if (ColorBlendState != null)
            {
                pointer->ColorBlendState = (Interop.PipelineColorBlendStateCreateInfo*)HeapUtil.Allocate<Interop.PipelineColorBlendStateCreateInfo>();
                ColorBlendState.Value.MarshalTo(pointer->ColorBlendState);
            }
            else
            {
                pointer->ColorBlendState = default;
            }
            if (DynamicState != null)
            {
                pointer->DynamicState = (Interop.PipelineDynamicStateCreateInfo*)HeapUtil.Allocate<Interop.PipelineDynamicStateCreateInfo>();
                DynamicState.Value.MarshalTo(pointer->DynamicState);
            }
            else
            {
                pointer->DynamicState = default;
            }
            pointer->Layout = Layout?.handle ?? default(Interop.PipelineLayout);
            pointer->RenderPass = RenderPass?.handle ?? default(Interop.RenderPass);
            pointer->Subpass = Subpass;
            pointer->BasePipelineHandle = BasePipelineHandle?.handle ?? default(Interop.Pipeline);
            pointer->BasePipelineIndex = BasePipelineIndex;
        }
    }
}