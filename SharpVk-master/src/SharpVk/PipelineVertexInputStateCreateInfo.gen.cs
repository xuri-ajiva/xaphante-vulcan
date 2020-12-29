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
    ///     Structure specifying parameters of a newly created pipeline vertex
    ///     input state.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct PipelineVertexInputStateCreateInfo
    {
        /// <summary>
        ///     Reserved for future use.
        /// </summary>
        public PipelineVertexInputStateCreateFlags? Flags
        {
            get;
            set;
        }

        /// <summary>
        ///     An array of VertexInputBindingDescription structures.
        /// </summary>
        public VertexInputBindingDescription[] VertexBindingDescriptions
        {
            get;
            set;
        }

        /// <summary>
        ///     An array of VertexInputAttributeDescription structures.
        /// </summary>
        public VertexInputAttributeDescription[] VertexAttributeDescriptions
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(Interop.PipelineVertexInputStateCreateInfo* pointer)
        {
            pointer->SType = StructureType.PipelineVertexInputStateCreateInfo;
            pointer->Next = null;
            if (Flags != null)
                pointer->Flags = Flags.Value;
            else
                pointer->Flags = default;
            pointer->VertexBindingDescriptionCount = HeapUtil.GetLength(VertexBindingDescriptions);
            if (VertexBindingDescriptions != null)
            {
                var fieldPointer = (VertexInputBindingDescription*)HeapUtil.AllocateAndClear<VertexInputBindingDescription>(VertexBindingDescriptions.Length).ToPointer();
                for (var index = 0; index < (uint)VertexBindingDescriptions.Length; index++) fieldPointer[index] = VertexBindingDescriptions[index];
                pointer->VertexBindingDescriptions = fieldPointer;
            }
            else
            {
                pointer->VertexBindingDescriptions = null;
            }
            pointer->VertexAttributeDescriptionCount = HeapUtil.GetLength(VertexAttributeDescriptions);
            if (VertexAttributeDescriptions != null)
            {
                var fieldPointer = (VertexInputAttributeDescription*)HeapUtil.AllocateAndClear<VertexInputAttributeDescription>(VertexAttributeDescriptions.Length).ToPointer();
                for (var index = 0; index < (uint)VertexAttributeDescriptions.Length; index++) fieldPointer[index] = VertexAttributeDescriptions[index];
                pointer->VertexAttributeDescriptions = fieldPointer;
            }
            else
            {
                pointer->VertexAttributeDescriptions = null;
            }
        }
    }
}