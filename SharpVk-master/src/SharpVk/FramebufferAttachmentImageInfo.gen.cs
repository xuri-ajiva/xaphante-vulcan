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
    ///     Structure specifying parameters of an image that will be used with a
    ///     framebuffer.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct FramebufferAttachmentImageInfo
    {
        /// <summary>
        ///     A bitmask of ImageCreateFlags, matching the value of
        ///     VkImageCreateInfo::flags used to create an image that will be used
        ///     with this framebuffer.
        /// </summary>
        public ImageCreateFlags? Flags
        {
            get;
            set;
        }

        /// <summary>
        ///     A bitmask of ImageCreateFlags, matching the value of
        ///     VkImageCreateInfo::usage used to create an image used with this
        ///     framebuffer.
        /// </summary>
        public ImageUsageFlags Usage
        {
            get;
            set;
        }

        /// <summary>
        ///     The width of the image view used for rendering.
        /// </summary>
        public uint Width
        {
            get;
            set;
        }

        /// <summary>
        ///     The height of the image view used for rendering.
        /// </summary>
        public uint Height
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public uint LayerCount
        {
            get;
            set;
        }

        /// <summary>
        ///     An array which lists of all formats which can be used when creating
        ///     views of the image, matching the value of
        ///     VkImageFormatListCreateInfoKHR::pViewFormats used to create an
        ///     image used with this framebuffer.
        /// </summary>
        public Format[] ViewFormats
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(Interop.FramebufferAttachmentImageInfo* pointer)
        {
            pointer->SType = StructureType.FramebufferAttachmentImageInfoVersion;
            pointer->Next = null;
            if (Flags != null)
                pointer->Flags = Flags.Value;
            else
                pointer->Flags = default;
            pointer->Usage = Usage;
            pointer->Width = Width;
            pointer->Height = Height;
            pointer->LayerCount = LayerCount;
            pointer->ViewFormatCount = HeapUtil.GetLength(ViewFormats);
            if (ViewFormats != null)
            {
                var fieldPointer = (Format*)HeapUtil.AllocateAndClear<Format>(ViewFormats.Length).ToPointer();
                for (var index = 0; index < (uint)ViewFormats.Length; index++) fieldPointer[index] = ViewFormats[index];
                pointer->ViewFormats = fieldPointer;
            }
            else
            {
                pointer->ViewFormats = null;
            }
        }
    }
}