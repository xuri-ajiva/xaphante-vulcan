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
    ///     Structure specifying parameters of a newly created pipeline color blend
    ///     state.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct PipelineColorBlendStateCreateInfo
    {
        /// <summary>
        ///     Reserved for future use.
        /// </summary>
        public PipelineColorBlendStateCreateFlags? Flags
        {
            get;
            set;
        }

        /// <summary>
        ///     logicOpEnable controls whether to apply Logical Operations.
        /// </summary>
        public bool LogicOpEnable
        {
            get;
            set;
        }

        /// <summary>
        ///     logicOp selects which logical operation to apply.
        /// </summary>
        public LogicOp LogicOp
        {
            get;
            set;
        }

        /// <summary>
        ///     pAttachments: is array of per target attachment states.
        /// </summary>
        public PipelineColorBlendAttachmentState[] Attachments
        {
            get;
            set;
        }

        /// <summary>
        ///     An array of four values used as the R, G, B, and A components of
        ///     the blend constant that are used in blending, depending on the
        ///     blend factor.
        /// </summary>
        public (float, float, float, float) BlendConstants
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(Interop.PipelineColorBlendStateCreateInfo* pointer)
        {
            pointer->SType = StructureType.PipelineColorBlendStateCreateInfo;
            pointer->Next = null;
            if (Flags != null)
                pointer->Flags = Flags.Value;
            else
                pointer->Flags = default;
            pointer->LogicOpEnable = LogicOpEnable;
            pointer->LogicOp = LogicOp;
            pointer->AttachmentCount = HeapUtil.GetLength(Attachments);
            if (Attachments != null)
            {
                var fieldPointer = (Interop.PipelineColorBlendAttachmentState*)HeapUtil.AllocateAndClear<Interop.PipelineColorBlendAttachmentState>(Attachments.Length).ToPointer();
                for (var index = 0; index < (uint)Attachments.Length; index++) Attachments[index].MarshalTo(&fieldPointer[index]);
                pointer->Attachments = fieldPointer;
            }
            else
            {
                pointer->Attachments = null;
            }
            pointer->BlendConstants[0] = BlendConstants.Item1;
            pointer->BlendConstants[1] = BlendConstants.Item2;
            pointer->BlendConstants[2] = BlendConstants.Item3;
            pointer->BlendConstants[3] = BlendConstants.Item4;
        }
    }
}