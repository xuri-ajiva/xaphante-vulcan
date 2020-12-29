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
    ///     Structure specifying the parameters of a newly created pipeline layout
    ///     object.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct PipelineLayoutCreateInfo
    {
        /// <summary>
        ///     Reserved for future use.
        /// </summary>
        public PipelineLayoutCreateFlags? Flags
        {
            get;
            set;
        }

        /// <summary>
        ///     An array of DescriptorSetLayout objects.
        /// </summary>
        public DescriptorSetLayout[] SetLayouts
        {
            get;
            set;
        }

        /// <summary>
        ///     An array of PushConstantRange structures defining a set of push
        ///     constant ranges for use in a single pipeline layout. In addition to
        ///     descriptor set layouts, a pipeline layout also describes how many
        ///     push constants can be accessed by each stage of the pipeline. +
        ///     [NOTE] .Note ==== Push constants represent a high speed path to
        ///     modify constant data in pipelines that is expected to outperform
        ///     memory-backed resource updates. ====
        /// </summary>
        public PushConstantRange[] PushConstantRanges
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(Interop.PipelineLayoutCreateInfo* pointer)
        {
            pointer->SType = StructureType.PipelineLayoutCreateInfo;
            pointer->Next = null;
            if (Flags != null)
                pointer->Flags = Flags.Value;
            else
                pointer->Flags = default;
            pointer->SetLayoutCount = HeapUtil.GetLength(SetLayouts);
            if (SetLayouts != null)
            {
                var fieldPointer = (Interop.DescriptorSetLayout*)HeapUtil.AllocateAndClear<Interop.DescriptorSetLayout>(SetLayouts.Length).ToPointer();
                for (var index = 0; index < (uint)SetLayouts.Length; index++) fieldPointer[index] = SetLayouts[index]?.handle ?? default(Interop.DescriptorSetLayout);
                pointer->SetLayouts = fieldPointer;
            }
            else
            {
                pointer->SetLayouts = null;
            }
            pointer->PushConstantRangeCount = HeapUtil.GetLength(PushConstantRanges);
            if (PushConstantRanges != null)
            {
                var fieldPointer = (PushConstantRange*)HeapUtil.AllocateAndClear<PushConstantRange>(PushConstantRanges.Length).ToPointer();
                for (var index = 0; index < (uint)PushConstantRanges.Length; index++) fieldPointer[index] = PushConstantRanges[index];
                pointer->PushConstantRanges = fieldPointer;
            }
            else
            {
                pointer->PushConstantRanges = null;
            }
        }
    }
}