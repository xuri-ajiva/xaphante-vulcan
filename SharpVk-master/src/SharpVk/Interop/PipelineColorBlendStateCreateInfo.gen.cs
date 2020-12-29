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

namespace SharpVk.Interop
{
    /// <summary>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct PipelineColorBlendStateCreateInfo
    {
        /// <summary>
        ///     The type of this structure.
        /// </summary>
        public StructureType SType;

        /// <summary>
        ///     Null or an extension-specific structure.
        /// </summary>
        public void* Next;

        /// <summary>
        ///     Reserved for future use.
        /// </summary>
        public PipelineColorBlendStateCreateFlags Flags;

        /// <summary>
        ///     logicOpEnable controls whether to apply Logical Operations.
        /// </summary>
        public Bool32 LogicOpEnable;

        /// <summary>
        ///     logicOp selects which logical operation to apply.
        /// </summary>
        public LogicOp LogicOp;

        /// <summary>
        ///     The number of PipelineColorBlendAttachmentState elements in
        ///     pAttachments. This value must equal the colorAttachmentCount for
        ///     the subpass in which this pipeline is used.
        /// </summary>
        public uint AttachmentCount;

        /// <summary>
        ///     pAttachments: is array of per target attachment states.
        /// </summary>
        public PipelineColorBlendAttachmentState* Attachments;

        /// <summary>
        ///     An array of four values used as the R, G, B, and A components of
        ///     the blend constant that are used in blending, depending on the
        ///     blend factor.
        /// </summary>
        public fixed float BlendConstants[4];
    }
}