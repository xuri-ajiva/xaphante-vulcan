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
    public unsafe struct ImageCreateInfo
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
        ///     A bitmask describing additional parameters of the image. See
        ///     ImageCreateFlagBits below for a description of the supported bits.
        /// </summary>
        public ImageCreateFlags Flags;

        /// <summary>
        ///     An ImageType specifying the basic dimensionality of the image, as
        ///     described below. Layers in array textures do not count as a
        ///     dimension for the purposes of the image type.
        /// </summary>
        public ImageType ImageType;

        /// <summary>
        ///     A Format describing the format and type of the data elements that
        ///     will be contained in the image.
        /// </summary>
        public Format Format;

        /// <summary>
        ///     A Extent3D describing the number of data elements in each dimension
        ///     of the base level.
        /// </summary>
        public Extent3D Extent;

        /// <summary>
        ///     mipLevels describes the number of levels of detail available for
        ///     minified sampling of the image.
        /// </summary>
        public uint MipLevels;

        /// <summary>
        ///     The number of layers in the image.
        /// </summary>
        public uint ArrayLayers;

        /// <summary>
        ///     The number of sub-data element samples in the image as defined in
        ///     SampleCountFlagBits. See Multisampling.
        /// </summary>
        public SampleCountFlags Samples;

        /// <summary>
        ///     An ImageTiling specifying the tiling arrangement of the data
        ///     elements in memory, as described below.
        /// </summary>
        public ImageTiling Tiling;

        /// <summary>
        ///     A bitmask describing the intended usage of the image. See
        ///     ImageUsageFlagBits below for a description of the supported bits.
        /// </summary>
        public ImageUsageFlags Usage;

        /// <summary>
        ///     The sharing mode of the image when it will be accessed by multiple
        ///     queue families, and must be one of the values described for
        ///     SharingMode in the Resource Sharing section below.
        /// </summary>
        public SharingMode SharingMode;

        /// <summary>
        ///     The number of entries in the pQueueFamilyIndices array.
        /// </summary>
        public uint QueueFamilyIndexCount;

        /// <summary>
        ///     A list of queue families that will access this image (ignored if
        ///     sharingMode is not VK_SHARING_MODE_CONCURRENT).
        /// </summary>
        public uint* QueueFamilyIndices;

        /// <summary>
        ///     initialLayout selects the initial ImageLayout state of all image
        ///     subresources of the image. See Image Layouts. initialLayout must be
        ///     VK_IMAGE_LAYOUT_UNDEFINED or VK_IMAGE_LAYOUT_PREINITIALIZED.
        /// </summary>
        public ImageLayout InitialLayout;
    }
}