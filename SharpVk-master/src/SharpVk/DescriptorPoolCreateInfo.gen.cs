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
using SharpVk.Interop;

namespace SharpVk
{
    /// <summary>
    ///     Structure specifying parameters of a newly created descriptor pool.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct DescriptorPoolCreateInfo
    {
        /// <summary>
        ///     Specifies certain supported operations on the pool. Bits which can
        ///     be set include: + --
        /// </summary>
        public DescriptorPoolCreateFlags? Flags
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public uint MaxSets
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public DescriptorPoolSize[] PoolSizes
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(Interop.DescriptorPoolCreateInfo* pointer)
        {
            pointer->SType = StructureType.DescriptorPoolCreateInfo;
            pointer->Next = null;
            if (Flags != null)
                pointer->Flags = Flags.Value;
            else
                pointer->Flags = default;
            pointer->MaxSets = MaxSets;
            pointer->PoolSizeCount = HeapUtil.GetLength(PoolSizes);
            if (PoolSizes != null)
            {
                var fieldPointer = (DescriptorPoolSize*)HeapUtil.AllocateAndClear<DescriptorPoolSize>(PoolSizes.Length).ToPointer();
                for (var index = 0; index < (uint)PoolSizes.Length; index++) fieldPointer[index] = PoolSizes[index];
                pointer->PoolSizes = fieldPointer;
            }
            else
            {
                pointer->PoolSizes = null;
            }
        }
    }
}