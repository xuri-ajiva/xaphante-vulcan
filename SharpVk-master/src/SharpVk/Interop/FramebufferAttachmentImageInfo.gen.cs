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
    public unsafe struct FramebufferAttachmentImageInfo
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
        ///     A bitmask of ImageCreateFlags, matching the value of
        ///     VkImageCreateInfo::flags used to create an image that will be used
        ///     with this framebuffer.
        /// </summary>
        public ImageCreateFlags Flags;

        /// <summary>
        ///     A bitmask of ImageCreateFlags, matching the value of
        ///     VkImageCreateInfo::usage used to create an image used with this
        ///     framebuffer.
        /// </summary>
        public ImageUsageFlags Usage;

        /// <summary>
        ///     The width of the image view used for rendering.
        /// </summary>
        public uint Width;

        /// <summary>
        ///     The height of the image view used for rendering.
        /// </summary>
        public uint Height;

        /// <summary>
        /// </summary>
        public uint LayerCount;

        /// <summary>
        ///     The number of entries in the pViewFormats array, matching the value
        ///     of VkImageFormatListCreateInfoKHR::viewFormatCount used to create
        ///     an image used with this framebuffer.
        /// </summary>
        public uint ViewFormatCount;

        /// <summary>
        ///     An array which lists of all formats which can be used when creating
        ///     views of the image, matching the value of
        ///     VkImageFormatListCreateInfoKHR::pViewFormats used to create an
        ///     image used with this framebuffer.
        /// </summary>
        public Format* ViewFormats;
    }
}