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
    ///     Structure specifying a sparse memory bind operation.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct SparseMemoryBind
    {
        /// <summary>
        ///     The offset into the resource.
        /// </summary>
        public ulong ResourceOffset
        {
            get;
            set;
        }

        /// <summary>
        ///     The size of the memory region to be bound.
        /// </summary>
        public ulong Size
        {
            get;
            set;
        }

        /// <summary>
        ///     The DeviceMemory object that the range of the resource is bound to.
        ///     If memory is null, the range is unbound.
        /// </summary>
        public DeviceMemory Memory
        {
            get;
            set;
        }

        /// <summary>
        ///     The offset into the DeviceMemory object to bind the resource range
        ///     to. If memory is null, this value is ignored.
        /// </summary>
        public ulong MemoryOffset
        {
            get;
            set;
        }

        /// <summary>
        ///     A bitmask specifying usage of the binding operation. Bits which can
        ///     be set include: + --
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
        internal unsafe void MarshalTo(Interop.SparseMemoryBind* pointer)
        {
            pointer->ResourceOffset = ResourceOffset;
            pointer->Size = Size;
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
        internal static unsafe SparseMemoryBind MarshalFrom(Interop.SparseMemoryBind* pointer)
        {
            var result = default(SparseMemoryBind);
            result.ResourceOffset = pointer->ResourceOffset;
            result.Size = pointer->Size;
            result.Memory = new(default, pointer->Memory);
            result.MemoryOffset = pointer->MemoryOffset;
            result.Flags = pointer->Flags;
            return result;
        }
    }
}