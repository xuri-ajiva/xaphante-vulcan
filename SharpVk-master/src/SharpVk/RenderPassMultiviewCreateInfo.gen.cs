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
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct RenderPassMultiviewCreateInfo
    {
        /// <summary>
        /// </summary>
        public uint[] ViewMasks
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public int[] ViewOffsets
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public uint[] CorrelationMasks
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(Interop.RenderPassMultiviewCreateInfo* pointer)
        {
            pointer->SType = StructureType.RenderPassMultiviewCreateInfoVersion;
            pointer->Next = null;
            pointer->SubpassCount = HeapUtil.GetLength(ViewMasks);
            if (ViewMasks != null)
            {
                var fieldPointer = (uint*)HeapUtil.AllocateAndClear<uint>(ViewMasks.Length).ToPointer();
                for (var index = 0; index < (uint)ViewMasks.Length; index++) fieldPointer[index] = ViewMasks[index];
                pointer->ViewMasks = fieldPointer;
            }
            else
            {
                pointer->ViewMasks = null;
            }
            pointer->DependencyCount = HeapUtil.GetLength(ViewOffsets);
            if (ViewOffsets != null)
            {
                var fieldPointer = (int*)HeapUtil.AllocateAndClear<int>(ViewOffsets.Length).ToPointer();
                for (var index = 0; index < (uint)ViewOffsets.Length; index++) fieldPointer[index] = ViewOffsets[index];
                pointer->ViewOffsets = fieldPointer;
            }
            else
            {
                pointer->ViewOffsets = null;
            }
            pointer->CorrelationMaskCount = HeapUtil.GetLength(CorrelationMasks);
            if (CorrelationMasks != null)
            {
                var fieldPointer = (uint*)HeapUtil.AllocateAndClear<uint>(CorrelationMasks.Length).ToPointer();
                for (var index = 0; index < (uint)CorrelationMasks.Length; index++) fieldPointer[index] = CorrelationMasks[index];
                pointer->CorrelationMasks = fieldPointer;
            }
            else
            {
                pointer->CorrelationMasks = null;
            }
        }
    }
}