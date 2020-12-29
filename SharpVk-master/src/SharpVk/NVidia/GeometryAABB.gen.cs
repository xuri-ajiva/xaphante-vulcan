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

namespace SharpVk.NVidia
{
    /// <summary>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct GeometryAabb
    {
        /// <summary>
        /// </summary>
        public Buffer AabbData
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public uint NumAabBs
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public uint Stride
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public ulong Offset
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(Interop.NVidia.GeometryAabb* pointer)
        {
            pointer->SType = StructureType.GeometryAabb;
            pointer->Next = null;
            pointer->AabbData = AabbData?.Handle ?? default(Interop.Buffer);
            pointer->NumAABBs = NumAabBs;
            pointer->Stride = Stride;
            pointer->Offset = Offset;
        }

        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe GeometryAabb MarshalFrom(Interop.NVidia.GeometryAabb* pointer)
        {
            var result = default(GeometryAabb);
            result.AabbData = new(default, pointer->AabbData);
            result.NumAabBs = pointer->NumAABBs;
            result.Stride = pointer->Stride;
            result.Offset = pointer->Offset;
            return result;
        }
    }
}
