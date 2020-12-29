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
    ///     Structure specifying memory requirements.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct MemoryRequirements
    {
        /// <summary>
        /// </summary>
        public MemoryRequirements(ulong size, ulong alignment, uint memoryTypeBits)
        {
            Size = size;
            Alignment = alignment;
            MemoryTypeBits = memoryTypeBits;
        }

        /// <summary>
        ///     The size, in bytes, of the memory allocation required: for the
        ///     resource.
        /// </summary>
        public ulong Size;

        /// <summary>
        ///     The alignment, in bytes, of the offset within the allocation
        ///     required: for the resource.
        /// </summary>
        public ulong Alignment;

        /// <summary>
        ///     A bitmask and contains one bit set for every supported memory type
        ///     for the resource. Bit `i` is set if and only if the memory type `i`
        ///     in the PhysicalDeviceMemoryProperties structure for the physical
        ///     device is supported for the resource.
        /// </summary>
        public uint MemoryTypeBits;
    }
}