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

namespace SharpVk.Multivendor
{
    /// <summary>
    ///     Structure describing the texel buffer alignment requirements supported
    ///     by an implementation.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct PhysicalDeviceTexelBufferAlignmentProperties
    {
        /// <summary>
        ///     A byte alignment that is sufficient for a storage texel buffer of
        ///     any format.
        /// </summary>
        public ulong StorageTexelBufferOffsetAlignmentBytes
        {
            get;
            set;
        }

        /// <summary>
        ///     Indicates whether single texel alignment is sufficient for a
        ///     storage texel buffer of any format.
        /// </summary>
        public bool StorageTexelBufferOffsetSingleTexelAlignment
        {
            get;
            set;
        }

        /// <summary>
        ///     A byte alignment that is sufficient for a uniform texel buffer of
        ///     any format.
        /// </summary>
        public ulong UniformTexelBufferOffsetAlignmentBytes
        {
            get;
            set;
        }

        /// <summary>
        ///     Indicates whether single texel alignment is sufficient for a
        ///     uniform texel buffer of any format.
        /// </summary>
        public bool UniformTexelBufferOffsetSingleTexelAlignment
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe PhysicalDeviceTexelBufferAlignmentProperties MarshalFrom(Interop.Multivendor.PhysicalDeviceTexelBufferAlignmentProperties* pointer)
        {
            var result = default(PhysicalDeviceTexelBufferAlignmentProperties);
            result.StorageTexelBufferOffsetAlignmentBytes = pointer->StorageTexelBufferOffsetAlignmentBytes;
            result.StorageTexelBufferOffsetSingleTexelAlignment = pointer->StorageTexelBufferOffsetSingleTexelAlignment;
            result.UniformTexelBufferOffsetAlignmentBytes = pointer->UniformTexelBufferOffsetAlignmentBytes;
            result.UniformTexelBufferOffsetSingleTexelAlignment = pointer->UniformTexelBufferOffsetSingleTexelAlignment;
            return result;
        }
    }
}