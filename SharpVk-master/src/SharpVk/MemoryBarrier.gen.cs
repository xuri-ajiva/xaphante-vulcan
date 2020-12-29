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
    ///     Structure specifying a global memory barrier.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct MemoryBarrier
    {
        /// <summary>
        ///     srcAccessMask defines a source access mask.
        /// </summary>
        public AccessFlags? SourceAccessMask
        {
            get;
            set;
        }

        /// <summary>
        ///     dstAccessMask defines a destination access mask.
        /// </summary>
        public AccessFlags? DestinationAccessMask
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(Interop.MemoryBarrier* pointer)
        {
            pointer->SType = StructureType.MemoryBarrier;
            pointer->Next = null;
            if (SourceAccessMask != null)
                pointer->SourceAccessMask = SourceAccessMask.Value;
            else
                pointer->SourceAccessMask = default;
            if (DestinationAccessMask != null)
                pointer->DestinationAccessMask = DestinationAccessMask.Value;
            else
                pointer->DestinationAccessMask = default;
        }

        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe MemoryBarrier MarshalFrom(Interop.MemoryBarrier* pointer)
        {
            var result = default(MemoryBarrier);
            result.SourceAccessMask = pointer->SourceAccessMask;
            result.DestinationAccessMask = pointer->DestinationAccessMask;
            return result;
        }
    }
}