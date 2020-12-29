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
    ///     Structure specifying the parameters of a descriptor set write
    ///     operation.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct WriteDescriptorSet
    {
        /// <summary>
        ///     The destination descriptor set to update.
        /// </summary>
        public DescriptorSet DestinationSet
        {
            get;
            set;
        }

        /// <summary>
        ///     The descriptor binding within that set.
        /// </summary>
        public uint DestinationBinding
        {
            get;
            set;
        }

        /// <summary>
        ///     The starting element in that array.
        /// </summary>
        public uint DestinationArrayElement
        {
            get;
            set;
        }

        /// <summary>
        ///     The number of descriptors to update (the number of elements in
        ///     pImageInfo, pBufferInfo, or pTexelBufferView).
        /// </summary>
        public uint DescriptorCount
        {
            get;
            set;
        }

        /// <summary>
        ///     A DescriptorType specifying the type of each descriptor in
        ///     pImageInfo, pBufferInfo, or pTexelBufferView, as described below.
        ///     It must be the same type as that specified in
        ///     DescriptorSetLayoutBinding for dstSet at dstBinding. The type of
        ///     the descriptor also controls which array the descriptors are taken
        ///     from.
        /// </summary>
        public DescriptorType DescriptorType
        {
            get;
            set;
        }

        /// <summary>
        ///     An array of DescriptorImageInfo structures or is ignored, as
        ///     described below.
        /// </summary>
        public DescriptorImageInfo[] ImageInfo
        {
            get;
            set;
        }

        /// <summary>
        ///     An array of DescriptorBufferInfo structures or is ignored, as
        ///     described below.
        /// </summary>
        public DescriptorBufferInfo[] BufferInfo
        {
            get;
            set;
        }

        /// <summary>
        ///     An array of BufferView handles as described in the Buffer Views
        ///     section or is ignored, as described below.
        /// </summary>
        public BufferView[] TexelBufferView
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(Interop.WriteDescriptorSet* pointer)
        {
            pointer->SType = StructureType.WriteDescriptorSet;
            pointer->Next = null;
            pointer->DestinationSet = DestinationSet?.handle ?? default(Interop.DescriptorSet);
            pointer->DestinationBinding = DestinationBinding;
            pointer->DestinationArrayElement = DestinationArrayElement;
            pointer->DescriptorCount = DescriptorCount;
            pointer->DescriptorType = DescriptorType;
            if (ImageInfo != null)
            {
                var fieldPointer = (Interop.DescriptorImageInfo*)HeapUtil.AllocateAndClear<Interop.DescriptorImageInfo>(ImageInfo.Length).ToPointer();
                for (var index = 0; index < (uint)ImageInfo.Length; index++) ImageInfo[index].MarshalTo(&fieldPointer[index]);
                pointer->ImageInfo = fieldPointer;
            }
            else
            {
                pointer->ImageInfo = null;
            }
            if (BufferInfo != null)
            {
                var fieldPointer = (Interop.DescriptorBufferInfo*)HeapUtil.AllocateAndClear<Interop.DescriptorBufferInfo>(BufferInfo.Length).ToPointer();
                for (var index = 0; index < (uint)BufferInfo.Length; index++) BufferInfo[index].MarshalTo(&fieldPointer[index]);
                pointer->BufferInfo = fieldPointer;
            }
            else
            {
                pointer->BufferInfo = null;
            }
            if (TexelBufferView != null)
            {
                var fieldPointer = (Interop.BufferView*)HeapUtil.AllocateAndClear<Interop.BufferView>(TexelBufferView.Length).ToPointer();
                for (var index = 0; index < (uint)TexelBufferView.Length; index++) fieldPointer[index] = TexelBufferView[index]?.handle ?? default(Interop.BufferView);
                pointer->TexelBufferView = fieldPointer;
            }
            else
            {
                pointer->TexelBufferView = null;
            }
        }
    }
}