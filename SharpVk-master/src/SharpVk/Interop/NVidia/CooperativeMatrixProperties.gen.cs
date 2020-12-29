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
using SharpVk.NVidia;

namespace SharpVk.Interop.NVidia
{
    /// <summary>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct CooperativeMatrixProperties
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
        ///     The number of rows in matrices A, C, and D.
        /// </summary>
        public uint MSize;

        /// <summary>
        ///     The number of columns in matrices B, C, D.
        /// </summary>
        public uint NSize;

        /// <summary>
        ///     The number of columns in matrix A and rows in matrix B.
        /// </summary>
        public uint KSize;

        /// <summary>
        ///     The component type of matrix A, of type VkComponentTypeNV.
        /// </summary>
        public ComponentType AType;

        /// <summary>
        ///     The component type of matrix B, of type VkComponentTypeNV.
        /// </summary>
        public ComponentType BType;

        /// <summary>
        ///     The component type of matrix C, of type VkComponentTypeNV.
        /// </summary>
        public ComponentType CType;

        /// <summary>
        ///     The component type of matrix D, of type VkComponentTypeNV.
        /// </summary>
        public ComponentType DType;

        /// <summary>
        ///     The scope of all the matrix types, of type VkScopeNV.
        /// </summary>
        public Scope Scope;
    }
}