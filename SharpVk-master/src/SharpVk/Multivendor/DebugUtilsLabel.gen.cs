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

namespace SharpVk.Multivendor
{
    /// <summary>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct DebugUtilsLabel
    {
        /// <summary>
        /// </summary>
        public string LabelName
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public (float, float, float, float) Color
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(Interop.Multivendor.DebugUtilsLabel* pointer)
        {
            pointer->SType = StructureType.DebugUtilsLabel;
            pointer->Next = null;
            pointer->LabelName = HeapUtil.MarshalTo(LabelName);
            pointer->Color[0] = Color.Item1;
            pointer->Color[1] = Color.Item2;
            pointer->Color[2] = Color.Item3;
            pointer->Color[3] = Color.Item4;
        }

        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe DebugUtilsLabel MarshalFrom(Interop.Multivendor.DebugUtilsLabel* pointer)
        {
            var result = default(DebugUtilsLabel);
            result.LabelName = HeapUtil.MarshalStringFrom(pointer->LabelName);
            result.Color = (pointer->Color[0], pointer->Color[1], pointer->Color[2], pointer->Color[3]);
            return result;
        }
    }
}