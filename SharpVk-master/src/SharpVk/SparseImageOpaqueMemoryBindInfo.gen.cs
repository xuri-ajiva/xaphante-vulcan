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
    ///     Structure specifying sparse image opaque memory bind info.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct SparseImageOpaqueMemoryBindInfo
    {
        /// <summary>
        ///     The Image object to be bound.
        /// </summary>
        public Image Image
        {
            get;
            set;
        }

        /// <summary>
        ///     Array of SparseMemoryBind structures.
        /// </summary>
        public SparseMemoryBind[] Binds
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(Interop.SparseImageOpaqueMemoryBindInfo* pointer)
        {
            pointer->Image = Image?.handle ?? default(Interop.Image);
            pointer->BindCount = HeapUtil.GetLength(Binds);
            if (Binds != null)
            {
                var fieldPointer = (Interop.SparseMemoryBind*)HeapUtil.AllocateAndClear<Interop.SparseMemoryBind>(Binds.Length).ToPointer();
                for (var index = 0; index < (uint)Binds.Length; index++) Binds[index].MarshalTo(&fieldPointer[index]);
                pointer->Binds = fieldPointer;
            }
            else
            {
                pointer->Binds = null;
            }
        }
    }
}