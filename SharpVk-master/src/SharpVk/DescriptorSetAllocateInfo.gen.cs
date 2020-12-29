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
    ///     Structure specifying the allocation parameters for descriptor sets.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct DescriptorSetAllocateInfo
    {
        /// <summary>
        ///     The pool which the sets will be allocated from.
        /// </summary>
        public DescriptorPool DescriptorPool
        {
            get;
            set;
        }

        /// <summary>
        ///     An array of descriptor set layouts, with each member specifying how
        ///     the corresponding descriptor set is allocated.
        /// </summary>
        public DescriptorSetLayout[] SetLayouts
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(Interop.DescriptorSetAllocateInfo* pointer)
        {
            pointer->SType = StructureType.DescriptorSetAllocateInfo;
            pointer->Next = null;
            pointer->DescriptorPool = DescriptorPool?.Handle ?? default(Interop.DescriptorPool);
            pointer->DescriptorSetCount = HeapUtil.GetLength(SetLayouts);
            if (SetLayouts != null)
            {
                var fieldPointer = (Interop.DescriptorSetLayout*)HeapUtil.AllocateAndClear<Interop.DescriptorSetLayout>(SetLayouts.Length).ToPointer();
                for (var index = 0; index < (uint)SetLayouts.Length; index++) fieldPointer[index] = SetLayouts[index]?.Handle ?? default(Interop.DescriptorSetLayout);
                pointer->SetLayouts = fieldPointer;
            }
            else
            {
                pointer->SetLayouts = null;
            }
        }
    }
}
