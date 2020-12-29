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
    public unsafe struct BufferCreateInfo
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
        ///     A bitmask describing additional parameters of the buffer.
        /// </summary>
        public BufferCreateFlags Flags;

        /// <summary>
        ///     The size in bytes of the buffer to be created.
        /// </summary>
        public ulong Size;

        /// <summary>
        ///     A bitmask describing the allowed usages of the buffer.
        /// </summary>
        public BufferUsageFlags Usage;

        /// <summary>
        ///     The sharing mode of the buffer when it will be accessed by multiple
        ///     queue families.
        /// </summary>
        public SharingMode SharingMode;

        /// <summary>
        ///     The number of entries in the queueFamilyIndices array.
        /// </summary>
        public uint QueueFamilyIndexCount;

        /// <summary>
        ///     A list of queue families that will access this buffer (ignored if
        ///     sharingMode is not Concurrent).
        /// </summary>
        public uint* QueueFamilyIndices;
    }
}