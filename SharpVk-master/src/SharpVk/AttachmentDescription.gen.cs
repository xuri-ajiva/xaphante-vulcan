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
    ///     Structure specifying an attachment description.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct AttachmentDescription
    {
        /// <summary>
        /// </summary>
        public AttachmentDescription(AttachmentDescriptionFlags flags, Format format, SampleCountFlags samples, AttachmentLoadOp loadOp, AttachmentStoreOp storeOp, AttachmentLoadOp stencilLoadOp, AttachmentStoreOp stencilStoreOp, ImageLayout initialLayout, ImageLayout finalLayout)
        {
            Flags = flags;
            Format = format;
            Samples = samples;
            LoadOp = loadOp;
            StoreOp = storeOp;
            StencilLoadOp = stencilLoadOp;
            StencilStoreOp = stencilStoreOp;
            InitialLayout = initialLayout;
            FinalLayout = finalLayout;
        }

        /// <summary>
        ///     A bitmask describing additional properties of the attachment.
        /// </summary>
        public AttachmentDescriptionFlags Flags;

        /// <summary>
        ///     A Format value specifying the format of the image that will be used
        ///     for the attachment.
        /// </summary>
        public Format Format;

        /// <summary>
        ///     The number of samples of the image as defined in SampleCountFlags.
        /// </summary>
        public SampleCountFlags Samples;

        /// <summary>
        ///     An AttachmentLoadOp value specifying how the contents of color and
        ///     depth components of the attachment are treated at the beginning of
        ///     the subpass where it is first used.
        /// </summary>
        public AttachmentLoadOp LoadOp;

        /// <summary>
        ///     An AttachmentStoreOp value specifying how the contents of color and
        ///     depth components of the attachment are treated at the end of the
        ///     subpass where it is last used.
        /// </summary>
        public AttachmentStoreOp StoreOp;

        /// <summary>
        ///     An AttachmentLoadOp value specifying how the contents of stencil
        ///     components of the attachment are treated at the beginning of the
        ///     subpass where it is first used.
        /// </summary>
        public AttachmentLoadOp StencilLoadOp;

        /// <summary>
        ///     An AttachmentStoreOp value specifying how the contents of stencil
        ///     components of the attachment are treated at the end of the last
        ///     subpass where it is used.
        /// </summary>
        public AttachmentStoreOp StencilStoreOp;

        /// <summary>
        ///     The layout the attachment image subresource will be in when a
        ///     render pass instance begins.
        /// </summary>
        public ImageLayout InitialLayout;

        /// <summary>
        ///     The layout the attachment image subresource will be transitioned to
        ///     when a render pass instance ends.
        /// </summary>
        public ImageLayout FinalLayout;
    }
}