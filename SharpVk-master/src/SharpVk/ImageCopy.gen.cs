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

namespace SharpVk
{
    /// <summary>
    ///     Structure specifying an image copy operation.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct ImageCopy
    {
        /// <summary>
        /// </summary>
        public ImageCopy(ImageSubresourceLayers sourceSubresource, Offset3D sourceOffset, ImageSubresourceLayers destinationSubresource, Offset3D destinationOffset, Extent3D extent)
        {
            SourceSubresource = sourceSubresource;
            SourceOffset = sourceOffset;
            DestinationSubresource = destinationSubresource;
            DestinationOffset = destinationOffset;
            Extent = extent;
        }

        /// <summary>
        ///     ImageSubresourceLayer structure specifying the image subresources
        ///     of the images used for the source image data.
        /// </summary>
        public ImageSubresourceLayers SourceSubresource;

        /// <summary>
        ///     The initial x, y, and z offsets in texels of the sub-regions of the
        ///     source image data.
        /// </summary>
        public Offset3D SourceOffset;

        /// <summary>
        ///     ImageSubresourceLayer structure specifying the image subresources
        ///     of the images used for the destination image data.
        /// </summary>
        public ImageSubresourceLayers DestinationSubresource;

        /// <summary>
        ///     The initial x, y, and z offsets in texels of the sub-regions of the
        ///     destination image data.
        /// </summary>
        public Offset3D DestinationOffset;

        /// <summary>
        ///     The size in texels of the source image to copy in width, height and
        ///     depth.
        /// </summary>
        public Extent3D Extent;
    }
}