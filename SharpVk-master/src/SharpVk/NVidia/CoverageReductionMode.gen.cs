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

namespace SharpVk.NVidia
{
    /// <summary>
    ///     Specify the coverage reduction mode
    /// </summary>
    public enum CoverageReductionMode
    {
        /// <summary>
        ///     In this mode, there is an implementation-dependent association of
        ///     each raster sample to a color sample. The reduced color sample mask
        ///     is computed such that the bit for each color sample is 1 if any of
        ///     the associated bits in the fragment’s coverage is on, and 0
        ///     otherwise.
        /// </summary>
        Merge = 0,

        /// <summary>
        ///     In this mode, only the first M raster samples are associated with
        ///     the color samples such that raster sample i maps to color sample i,
        ///     where M is the number of color samples.
        /// </summary>
        Truncate = 1
    }
}