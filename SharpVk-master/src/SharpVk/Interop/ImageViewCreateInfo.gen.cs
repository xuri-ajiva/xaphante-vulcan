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
    public unsafe struct ImageViewCreateInfo
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
        public ImageViewCreateFlags Flags;

        /// <summary>
        ///     An Image on which the view will be created.
        /// </summary>
        public Image Image;

        /// <summary>
        ///     The type of the image view.
        /// </summary>
        public ImageViewType ViewType;

        /// <summary>
        ///     A Format describing the format and type used to interpret data
        ///     elements in the image.
        /// </summary>
        public Format Format;

        /// <summary>
        ///     Specifies a remapping of color components (or of depth or stencil
        ///     components after they have been converted into color components).
        /// </summary>
        public ComponentMapping Components;

        /// <summary>
        ///     An ImageSubresourceRange selecting the set of mipmap levels and
        ///     array layers to be accessible to the view.
        /// </summary>
        public ImageSubresourceRange SubresourceRange;
    }
}