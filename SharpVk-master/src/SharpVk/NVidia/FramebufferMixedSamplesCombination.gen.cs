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

namespace SharpVk.NVidia
{
    /// <summary>
    ///     Structure specifying a supported sample count combination
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct FramebufferMixedSamplesCombination
    {
        /// <summary>
        ///     Specifies the coverage reduction mode and is of type
        ///     VkCoverageReductionModeNV.
        /// </summary>
        public CoverageReductionMode CoverageReductionMode
        {
            get;
            set;
        }

        /// <summary>
        ///     Specifies the number of rasterization samples in the supported
        ///     combination.
        /// </summary>
        public SampleCountFlags RasterizationSamples
        {
            get;
            set;
        }

        /// <summary>
        ///     Specifies the number of samples in the depth stencil attachment in
        ///     the supported combination. A value of 0 indicates the combination
        ///     does not have a depth stencil attachment.
        /// </summary>
        public SampleCountFlags DepthStencilSamples
        {
            get;
            set;
        }

        /// <summary>
        ///     Specifies the number of color samples in a color attachment in the
        ///     supported combination. A value of 0 indicates the combination does
        ///     not have a color attachment.
        /// </summary>
        public SampleCountFlags ColorSamples
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe FramebufferMixedSamplesCombination MarshalFrom(Interop.NVidia.FramebufferMixedSamplesCombination* pointer)
        {
            var result = default(FramebufferMixedSamplesCombination);
            result.CoverageReductionMode = pointer->CoverageReductionMode;
            result.RasterizationSamples = pointer->RasterizationSamples;
            result.DepthStencilSamples = pointer->DepthStencilSamples;
            result.ColorSamples = pointer->ColorSamples;
            return result;
        }
    }
}