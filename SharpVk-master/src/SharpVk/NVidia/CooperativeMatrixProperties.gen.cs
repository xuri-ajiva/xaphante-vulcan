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
    ///     Structure specifying cooperative matrix properties
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CooperativeMatrixProperties
    {
        /// <summary>
        ///     The number of rows in matrices A, C, and D.
        /// </summary>
        public uint MSize
        {
            get;
            set;
        }

        /// <summary>
        ///     The number of columns in matrices B, C, D.
        /// </summary>
        public uint NSize
        {
            get;
            set;
        }

        /// <summary>
        ///     The number of columns in matrix A and rows in matrix B.
        /// </summary>
        public uint KSize
        {
            get;
            set;
        }

        /// <summary>
        ///     The component type of matrix A, of type VkComponentTypeNV.
        /// </summary>
        public ComponentType AType
        {
            get;
            set;
        }

        /// <summary>
        ///     The component type of matrix B, of type VkComponentTypeNV.
        /// </summary>
        public ComponentType BType
        {
            get;
            set;
        }

        /// <summary>
        ///     The component type of matrix C, of type VkComponentTypeNV.
        /// </summary>
        public ComponentType CType
        {
            get;
            set;
        }

        /// <summary>
        ///     The component type of matrix D, of type VkComponentTypeNV.
        /// </summary>
        public ComponentType DType
        {
            get;
            set;
        }

        /// <summary>
        ///     The scope of all the matrix types, of type VkScopeNV.
        /// </summary>
        public Scope Scope
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(Interop.NVidia.CooperativeMatrixProperties* pointer)
        {
            pointer->SType = StructureType.CooperativeMatrixProperties;
            pointer->Next = null;
            pointer->MSize = MSize;
            pointer->NSize = NSize;
            pointer->KSize = KSize;
            pointer->AType = AType;
            pointer->BType = BType;
            pointer->CType = CType;
            pointer->DType = DType;
            pointer->Scope = Scope;
        }

        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe CooperativeMatrixProperties MarshalFrom(Interop.NVidia.CooperativeMatrixProperties* pointer)
        {
            var result = default(CooperativeMatrixProperties);
            result.MSize = pointer->MSize;
            result.NSize = pointer->NSize;
            result.KSize = pointer->KSize;
            result.AType = pointer->AType;
            result.BType = pointer->BType;
            result.CType = pointer->CType;
            result.DType = pointer->DType;
            result.Scope = pointer->Scope;
            return result;
        }
    }
}