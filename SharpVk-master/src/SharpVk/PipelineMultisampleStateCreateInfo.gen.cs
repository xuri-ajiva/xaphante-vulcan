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
    ///     Structure specifying parameters of a newly created pipeline multisample
    ///     state.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct PipelineMultisampleStateCreateInfo
    {
        /// <summary>
        ///     Reserved for future use.
        /// </summary>
        public PipelineMultisampleStateCreateFlags? Flags
        {
            get;
            set;
        }

        /// <summary>
        ///     A SampleCountFlagBits specifying the number of samples per pixel
        ///     used in rasterization.
        /// </summary>
        public SampleCountFlags RasterizationSamples
        {
            get;
            set;
        }

        /// <summary>
        ///     Specifies that fragment shading executes per-sample if VK_TRUE, or
        ///     per-fragment if VK_FALSE, as described in Sample Shading.
        /// </summary>
        public bool SampleShadingEnable
        {
            get;
            set;
        }

        /// <summary>
        ///     The minimum fraction of sample shading, as described in Sample
        ///     Shading.
        /// </summary>
        public float MinSampleShading
        {
            get;
            set;
        }

        /// <summary>
        ///     A bitmask of static coverage information that is ANDed with the
        ///     coverage information generated during rasterization, as described
        ///     in Sample Mask.
        /// </summary>
        public SampleMask[] SampleMask
        {
            get;
            set;
        }

        /// <summary>
        ///     alphaToCoverageEnable controls whether a temporary coverage value
        ///     is generated based on the alpha component of the fragment's first
        ///     color output as specified in the Multisample Coverage section.
        /// </summary>
        public bool AlphaToCoverageEnable
        {
            get;
            set;
        }

        /// <summary>
        ///     alphaToOneEnable controls whether the alpha component of the
        ///     fragment's first color output is replaced with one as described in
        ///     Multisample Coverage.
        /// </summary>
        public bool AlphaToOneEnable
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(Interop.PipelineMultisampleStateCreateInfo* pointer)
        {
            pointer->SType = StructureType.PipelineMultisampleStateCreateInfo;
            pointer->Next = null;
            if (Flags != null)
                pointer->Flags = Flags.Value;
            else
                pointer->Flags = default;
            pointer->RasterizationSamples = RasterizationSamples;
            pointer->SampleShadingEnable = SampleShadingEnable;
            pointer->MinSampleShading = MinSampleShading;
            if (SampleMask != null)
            {
                var fieldPointer = (SampleMask*)HeapUtil.AllocateAndClear<SampleMask>(SampleMask.Length).ToPointer();
                for (var index = 0; index < (uint)SampleMask.Length; index++) fieldPointer[index] = SampleMask[index];
                pointer->SampleMask = fieldPointer;
            }
            else
            {
                pointer->SampleMask = null;
            }
            pointer->AlphaToCoverageEnable = AlphaToCoverageEnable;
            pointer->AlphaToOneEnable = AlphaToOneEnable;
        }
    }
}