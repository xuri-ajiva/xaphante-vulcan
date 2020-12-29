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

namespace SharpVk.Khronos
{
    /// <summary>
    ///     Structure describing capabilities of a mode and plane combination.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct DisplayPlaneCapabilities
    {
        /// <summary>
        /// </summary>
        public DisplayPlaneCapabilities(DisplayPlaneAlphaFlags supportedAlpha, Offset2D minSourcePosition, Offset2D maxSourcePosition, Extent2D minSourceExtent, Extent2D maxSourceExtent, Offset2D minDestinationPosition, Offset2D maxDestinationPosition, Extent2D minDestinationExtent, Extent2D maxDestinationExtent)
        {
            SupportedAlpha = supportedAlpha;
            MinSourcePosition = minSourcePosition;
            MaxSourcePosition = maxSourcePosition;
            MinSourceExtent = minSourceExtent;
            MaxSourceExtent = maxSourceExtent;
            MinDestinationPosition = minDestinationPosition;
            MaxDestinationPosition = maxDestinationPosition;
            MinDestinationExtent = minDestinationExtent;
            MaxDestinationExtent = maxDestinationExtent;
        }

        /// <summary>
        ///     A bitmask of DisplayPlaneAlphaFlagBitsKHR describing the supported
        ///     alpha blending modes.
        /// </summary>
        public DisplayPlaneAlphaFlags SupportedAlpha;

        /// <summary>
        ///     The minimum source rectangle offset supported by this plane using
        ///     the specified mode.
        /// </summary>
        public Offset2D MinSourcePosition;

        /// <summary>
        ///     The maximum source rectangle offset supported by this plane using
        ///     the specified mode. The x and y components of maxSrcPosition must
        ///     each be greater than or equal to the x and y components of
        ///     minSrcPosition, respectively.
        /// </summary>
        public Offset2D MaxSourcePosition;

        /// <summary>
        ///     The minimum source rectangle size supported by this plane using the
        ///     specified mode.
        /// </summary>
        public Extent2D MinSourceExtent;

        /// <summary>
        ///     The maximum source rectangle size supported by this plane using the
        ///     specified mode.
        /// </summary>
        public Extent2D MaxSourceExtent;

        /// <summary>
        ///     minDstPosition, maxDstPosition, minDstExtent, maxDstExtent all have
        ///     similar semantics to their corresponding "Src" equivalents, but
        ///     apply to the output region within the mode rather than the input
        ///     region within the source image. Unlike the "Src" offsets,
        ///     minDstPosition and maxDstPosition may contain negative values.
        /// </summary>
        public Offset2D MinDestinationPosition;

        /// <summary>
        /// </summary>
        public Offset2D MaxDestinationPosition;

        /// <summary>
        /// </summary>
        public Extent2D MinDestinationExtent;

        /// <summary>
        /// </summary>
        public Extent2D MaxDestinationExtent;
    }
}