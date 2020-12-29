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
using SharpVk.Khronos;

namespace SharpVk.Interop.Khronos
{
    /// <summary>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct SwapchainCreateInfo
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
        ///     A bitmask indicating parameters of swapchain creation. Bits which
        ///     can be set include: + --
        /// </summary>
        public SwapchainCreateFlags Flags;

        /// <summary>
        /// </summary>
        public Surface Surface;

        /// <summary>
        /// </summary>
        public uint MinImageCount;

        /// <summary>
        /// </summary>
        public Format ImageFormat;

        /// <summary>
        /// </summary>
        public ColorSpace ImageColorSpace;

        /// <summary>
        /// </summary>
        public Extent2D ImageExtent;

        /// <summary>
        /// </summary>
        public uint ImageArrayLayers;

        /// <summary>
        /// </summary>
        public ImageUsageFlags ImageUsage;

        /// <summary>
        /// </summary>
        public SharingMode ImageSharingMode;

        /// <summary>
        /// </summary>
        public uint QueueFamilyIndexCount;

        /// <summary>
        /// </summary>
        public uint* QueueFamilyIndices;

        /// <summary>
        /// </summary>
        public SurfaceTransformFlags PreTransform;

        /// <summary>
        /// </summary>
        public CompositeAlphaFlags CompositeAlpha;

        /// <summary>
        /// </summary>
        public PresentMode PresentMode;

        /// <summary>
        /// </summary>
        public Bool32 Clipped;

        /// <summary>
        /// </summary>
        public Swapchain OldSwapchain;
    }
}