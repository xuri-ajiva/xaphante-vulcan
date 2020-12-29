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
    ///     Structure specifying a buffer memory barrier.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct BufferMemoryBarrier
    {
        /// <summary>
        ///     srcAccessMask defines a source access mask.
        /// </summary>
        public AccessFlags SourceAccessMask
        {
            get;
            set;
        }

        /// <summary>
        ///     dstAccessMask defines a destination access mask.
        /// </summary>
        public AccessFlags DestinationAccessMask
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
        ///     A handle to the buffer whose backing memory is affected by the
        ///     barrier.
        /// </summary>
        public Buffer Buffer
        {
            get;
            set;
        }

        /// <summary>
        ///     An offset in bytes into the backing memory for buffer; this is
        ///     relative to the base offset as bound to the buffer (see
        ///     flink:vkBindBufferMemory).
        /// </summary>
        public ulong Offset
        {
            get;
            set;
        }

        /// <summary>
        ///     A size in bytes of the affected area of backing memory for buffer,
        ///     or Constants.WholeSize to use the range from offset to the end of
        ///     the buffer.
        /// </summary>
        public ulong Size
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(Interop.BufferMemoryBarrier* pointer)
        {
            pointer->SType = StructureType.BufferMemoryBarrier;
            pointer->Next = null;
            pointer->SourceAccessMask = SourceAccessMask;
            pointer->DestinationAccessMask = DestinationAccessMask;
            pointer->SourceQueueFamilyIndex = SourceQueueFamilyIndex;
            pointer->DestinationQueueFamilyIndex = DestinationQueueFamilyIndex;
            pointer->Buffer = Buffer?.Handle ?? default(Interop.Buffer);
            pointer->Offset = Offset;
            pointer->Size = Size;
        }

        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe BufferMemoryBarrier MarshalFrom(Interop.BufferMemoryBarrier* pointer)
        {
            var result = default(BufferMemoryBarrier);
            result.SourceAccessMask = pointer->SourceAccessMask;
            result.DestinationAccessMask = pointer->DestinationAccessMask;
            result.SourceQueueFamilyIndex = pointer->SourceQueueFamilyIndex;
            result.DestinationQueueFamilyIndex = pointer->DestinationQueueFamilyIndex;
            result.Buffer = new(default, pointer->Buffer);
            result.Offset = pointer->Offset;
            result.Size = pointer->Size;
            return result;
        }
    }
}
