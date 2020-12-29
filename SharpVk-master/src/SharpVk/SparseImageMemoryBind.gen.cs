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
    ///     Structure specifying sparse image memory bind.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct SparseImageMemoryBind
    {
        /// <summary>
        ///     The aspectMask and region of interest in the image.
        /// </summary>
        public ImageSubresource Subresource
        {
            get;
            set;
        }

        /// <summary>
        ///     offset are the coordinates of the first texel within the image
        ///     subresource to bind.
        /// </summary>
        public Offset3D Offset
        {
            get;
            set;
        }

        /// <summary>
        ///     The size in texels of the region within the image subresource to
        ///     bind. The extent must be a multiple of the sparse image block
        ///     dimensions, except when binding sparse image blocks along the edge
        ///     of an image subresource it can instead be such that any coordinate
        ///     of [eq]#offset + extent# equals the corresponding dimensions of the
        ///     image subresource.
        /// </summary>
        public Extent3D Extent
        {
            get;
            set;
        }

        /// <summary>
        ///     The DeviceMemory object that the sparse image blocks of the image
        ///     are bound to. If memory is null, the sparse image blocks are
        ///     unbound.
        /// </summary>
        public DeviceMemory Memory
        {
            get;
            set;
        }

        /// <summary>
        ///     An offset into DeviceMemory object. If memory is null, this value
        ///     is ignored.
        /// </summary>
        public ulong MemoryOffset
        {
            get;
            set;
        }

        /// <summary>
        ///     flags are sparse memory binding flags.
        /// </summary>
        public SparseMemoryBindFlags? Flags
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(Interop.SparseImageMemoryBind* pointer)
        {
            pointer->Subresource = Subresource;
            pointer->Offset = Offset;
            pointer->Extent = Extent;
            pointer->Memory = Memory?.handle ?? default(Interop.DeviceMemory);
            pointer->MemoryOffset = MemoryOffset;
            if (Flags != null)
                pointer->Flags = Flags.Value;
            else
                pointer->Flags = default;
        }

        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe SparseImageMemoryBind MarshalFrom(Interop.SparseImageMemoryBind* pointer)
        {
            var result = default(SparseImageMemoryBind);
            result.Subresource = pointer->Subresource;
            result.Offset = pointer->Offset;
            result.Extent = pointer->Extent;
            result.Memory = new(default, pointer->Memory);
            result.MemoryOffset = pointer->MemoryOffset;
            result.Flags = pointer->Flags;
            return result;
        }
    }
}