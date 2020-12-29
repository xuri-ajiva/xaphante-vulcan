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

namespace SharpVk
{
    /// <summary>
    ///     Structure specifying a copy descriptor set operation.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CopyDescriptorSet
    {
        /// <summary>
        ///     srcSet, srcBinding, and srcArrayElement are the source set,
        ///     binding, and array element, respectively.
        /// </summary>
        public DescriptorSet SourceSet
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public uint SourceBinding
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public uint SourceArrayElement
        {
            get;
            set;
        }

        /// <summary>
        ///     dstSet, dstBinding, and dstArrayElement are the destination set,
        ///     binding, and array element, respectively.
        /// </summary>
        public DescriptorSet DestinationSet
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public uint DestinationBinding
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public uint DestinationArrayElement
        {
            get;
            set;
        }

        /// <summary>
        ///     The number of descriptors to copy from the source to destination.
        ///     If descriptorCount is greater than the number of remaining array
        ///     elements in the source or destination binding, those affect
        ///     consecutive bindings in a manner similar to WriteDescriptorSet
        ///     above.
        /// </summary>
        public uint DescriptorCount
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(Interop.CopyDescriptorSet* pointer)
        {
            pointer->SType = StructureType.CopyDescriptorSet;
            pointer->Next = null;
            pointer->SourceSet = SourceSet?.handle ?? default(Interop.DescriptorSet);
            pointer->SourceBinding = SourceBinding;
            pointer->SourceArrayElement = SourceArrayElement;
            pointer->DestinationSet = DestinationSet?.handle ?? default(Interop.DescriptorSet);
            pointer->DestinationBinding = DestinationBinding;
            pointer->DestinationArrayElement = DestinationArrayElement;
            pointer->DescriptorCount = DescriptorCount;
        }

        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe CopyDescriptorSet MarshalFrom(Interop.CopyDescriptorSet* pointer)
        {
            var result = default(CopyDescriptorSet);
            result.SourceSet = new(default, pointer->SourceSet);
            result.SourceBinding = pointer->SourceBinding;
            result.SourceArrayElement = pointer->SourceArrayElement;
            result.DestinationSet = new(default, pointer->DestinationSet);
            result.DestinationBinding = pointer->DestinationBinding;
            result.DestinationArrayElement = pointer->DestinationArrayElement;
            result.DescriptorCount = pointer->DescriptorCount;
            return result;
        }
    }
}