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
    ///     Structure specifying an attachment reference.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct AttachmentReference
    {
        /// <summary>
        /// </summary>
        public AttachmentReference(uint attachment, ImageLayout layout)
        {
            Attachment = attachment;
            Layout = layout;
        }

        /// <summary>
        ///     The index of the attachment of the render pass, and corresponds to
        ///     the index of the corresponding element in the attachments array of
        ///     Device.CreateRenderPass. If any color or depth/stencil attachments
        ///     are Attachment.Unused, then no writes occur for those attachments.
        /// </summary>
        public uint Attachment;

        /// <summary>
        ///     An ImageLayout value specifying the layout the attachment uses
        ///     during the subpass.
        /// </summary>
        public ImageLayout Layout;
    }
}