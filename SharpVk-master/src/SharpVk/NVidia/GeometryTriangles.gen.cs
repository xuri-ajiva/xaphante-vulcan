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
    public struct GeometryTriangles
    {
        /// <summary>
        /// </summary>
        public Buffer VertexData
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public ulong VertexOffset
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public uint VertexCount
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public ulong VertexStride
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public Format VertexFormat
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public Buffer IndexData
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public ulong IndexOffset
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public uint IndexCount
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public IndexType IndexType
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public Buffer TransformData
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public ulong TransformOffset
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(Interop.NVidia.GeometryTriangles* pointer)
        {
            pointer->SType = StructureType.GeometryTriangles;
            pointer->Next = null;
            pointer->VertexData = VertexData?.handle ?? default(Interop.Buffer);
            pointer->VertexOffset = VertexOffset;
            pointer->VertexCount = VertexCount;
            pointer->VertexStride = VertexStride;
            pointer->VertexFormat = VertexFormat;
            pointer->IndexData = IndexData?.handle ?? default(Interop.Buffer);
            pointer->IndexOffset = IndexOffset;
            pointer->IndexCount = IndexCount;
            pointer->IndexType = IndexType;
            pointer->TransformData = TransformData?.handle ?? default(Interop.Buffer);
            pointer->TransformOffset = TransformOffset;
        }

        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe GeometryTriangles MarshalFrom(Interop.NVidia.GeometryTriangles* pointer)
        {
            var result = default(GeometryTriangles);
            result.VertexData = new(default, pointer->VertexData);
            result.VertexOffset = pointer->VertexOffset;
            result.VertexCount = pointer->VertexCount;
            result.VertexStride = pointer->VertexStride;
            result.VertexFormat = pointer->VertexFormat;
            result.IndexData = new(default, pointer->IndexData);
            result.IndexOffset = pointer->IndexOffset;
            result.IndexCount = pointer->IndexCount;
            result.IndexType = pointer->IndexType;
            result.TransformData = new(default, pointer->TransformData);
            result.TransformOffset = pointer->TransformOffset;
            return result;
        }
    }
}