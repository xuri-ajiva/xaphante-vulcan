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

using System;
using System.Runtime.InteropServices;

namespace SharpVk.Android
{
    /// <summary>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct NativeBuffer
    {
        /// <summary>
        /// </summary>
        public IntPtr Handle
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public int Stride
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public int Format
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public int Usage
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public NativeBufferUsage2 Usage2
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(Interop.Android.NativeBuffer* pointer)
        {
            pointer->SType = StructureType.NativeBuffer;
            pointer->Next = null;
            pointer->Handle = Handle.ToPointer();
            pointer->Stride = Stride;
            pointer->Format = Format;
            pointer->Usage = Usage;
            pointer->Usage2 = Usage2;
        }

        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe NativeBuffer MarshalFrom(Interop.Android.NativeBuffer* pointer)
        {
            var result = default(NativeBuffer);
            result.Handle = new(pointer->Handle);
            result.Stride = pointer->Stride;
            result.Format = pointer->Format;
            result.Usage = pointer->Usage;
            result.Usage2 = pointer->Usage2;
            return result;
        }
    }
}