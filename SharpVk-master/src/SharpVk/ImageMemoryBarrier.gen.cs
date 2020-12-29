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
    ///     Structure specifying the parameters of an image memory barrier.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct ImageMemoryBarrier
    {
        /// <summary>
        ///     Defines a source access mask.
        /// </summary>
        public AccessFlags SourceAccessMask
        {
            get;
            set;
        }

        /// <summary>
        ///     Defines a destination access mask.
        /// </summary>
        public AccessFlags DestinationAccessMask
        {
            get;
            set;
        }

        /// <summary>
        ///     The old layout in an image layout transition.
        /// </summary>
        public ImageLayout OldLayout
        {
            get;
            set;
        }

        /// <summary>
        ///     The new layout in an image layout transition.
        /// </summary>
        public ImageLayout NewLayout
        {
            get;
            set;
        }

        /// <summary>
        ///     The source queue family for a queue family ownership transfer.
        /// </summary>
        public uint SourceQueueFamilyIndex
        {
            get;
            set;
        }

        /// <summary>
        ///     The destination queue family for a queue family ownership transfer.
        /// </summary>
        public uint DestinationQueueFamilyIndex
        {
            get;
            set;
        }

        /// <summary>
        ///     A handle to the image affected by this barrier.
        /// </summary>
        public Image Image
        {
            get;
            set;
        }

        /// <summary>
        ///     Describes the image subresource range within image that is affected
        ///     by this barrier.
        /// </summary>
        public ImageSubresourceRange SubresourceRange
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(Interop.ImageMemoryBarrier* pointer)
        {
            pointer->SType = StructureType.ImageMemoryBarrier;
            pointer->Next = null;
            pointer->SourceAccessMask = SourceAccessMask;
            pointer->DestinationAccessMask = DestinationAccessMask;
            pointer->OldLayout = OldLayout;
            pointer->NewLayout = NewLayout;
            pointer->SourceQueueFamilyIndex = SourceQueueFamilyIndex;
            pointer->DestinationQueueFamilyIndex = DestinationQueueFamilyIndex;
            pointer->Image = Image?.Handle ?? default(Interop.Image);
            pointer->SubresourceRange = SubresourceRange;
        }

        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe ImageMemoryBarrier MarshalFrom(Interop.ImageMemoryBarrier* pointer)
        {
            var result = default(ImageMemoryBarrier);
            result.SourceAccessMask = pointer->SourceAccessMask;
            result.DestinationAccessMask = pointer->DestinationAccessMask;
            result.OldLayout = pointer->OldLayout;
            result.NewLayout = pointer->NewLayout;
            result.SourceQueueFamilyIndex = pointer->SourceQueueFamilyIndex;
            result.DestinationQueueFamilyIndex = pointer->DestinationQueueFamilyIndex;
            result.Image = new(default, pointer->Image);
            result.SubresourceRange = pointer->SubresourceRange;
            return result;
        }
    }
}
