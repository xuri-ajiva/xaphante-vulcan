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

namespace SharpVk.Interop.Khronos
{
    /// <summary>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct DisplayPresentInfo
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
        ///     A rectangular region of pixels to present. It must be a subset of
        ///     the image being presented. If DisplayPresentInfoKHR is not
        ///     specified, this region will be assumed to be the entire presentable
        ///     image.
        /// </summary>
        public Rect2D SourceRect;

        /// <summary>
        ///     A rectangular region within the visible region of the swapchain's
        ///     display mode. If DisplayPresentInfoKHR is not specified, this
        ///     region will be assumed to be the entire visible region of the
        ///     visible region of the swapchain's mode. If the specified rectangle
        ///     is a subset of the display mode's visible region, content from
        ///     display planes below the swapchain's plane will be visible outside
        ///     the rectangle. If there are no planes below the swapchain's, the
        ///     area outside the specified rectangle will be black. If portions of
        ///     the specified rectangle are outside of the display's visible
        ///     region, pixels mapping only to those portions of the rectangle will
        ///     be discarded.
        /// </summary>
        public Rect2D DestinationRect;

        /// <summary>
        ///     persistent: If this is true, the display engine will enable
        ///     buffered mode on displays that support it. This allows the display
        ///     engine to stop sending content to the display until a new image is
        ///     presented. The display will instead maintain a copy of the last
        ///     presented image. This allows less power to be used, but may
        ///     increase presentation latency. If DisplayPresentInfoKHR is not
        ///     specified, persistent mode will not be used.
        /// </summary>
        public Bool32 Persistent;
    }
}