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
    ///     Structure specifying parameters of a newly created render pass.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct RenderPassCreateInfo
    {
        /// <summary>
        ///     Reserved for future use.
        /// </summary>
        public RenderPassCreateFlags? Flags
        {
            get;
            set;
        }

        /// <summary>
        ///     An array of attachmentCount number of AttachmentDescription
        ///     structures describing properties of the attachments, or Null if
        ///     attachmentCount is zero.
        /// </summary>
        public AttachmentDescription[] Attachments
        {
            get;
            set;
        }

        /// <summary>
        ///     An array of SubpassDescription structures describing properties of
        ///     the subpasses.
        /// </summary>
        public SubpassDescription[] Subpasses
        {
            get;
            set;
        }

        /// <summary>
        ///     An array of dependencyCount number of SubpassDependency structures
        ///     describing dependencies between pairs of subpasses, or Null if
        ///     dependencyCount is zero.
        /// </summary>
        public SubpassDependency[] Dependencies
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(Interop.RenderPassCreateInfo* pointer)
        {
            pointer->SType = StructureType.RenderPassCreateInfo;
            pointer->Next = null;
            if (Flags != null)
                pointer->Flags = Flags.Value;
            else
                pointer->Flags = default;
            pointer->AttachmentCount = HeapUtil.GetLength(Attachments);
            if (Attachments != null)
            {
                var fieldPointer = (AttachmentDescription*)HeapUtil.AllocateAndClear<AttachmentDescription>(Attachments.Length).ToPointer();
                for (var index = 0; index < (uint)Attachments.Length; index++) fieldPointer[index] = Attachments[index];
                pointer->Attachments = fieldPointer;
            }
            else
            {
                pointer->Attachments = null;
            }
            pointer->SubpassCount = HeapUtil.GetLength(Subpasses);
            if (Subpasses != null)
            {
                var fieldPointer = (Interop.SubpassDescription*)HeapUtil.AllocateAndClear<Interop.SubpassDescription>(Subpasses.Length).ToPointer();
                for (var index = 0; index < (uint)Subpasses.Length; index++) Subpasses[index].MarshalTo(&fieldPointer[index]);
                pointer->Subpasses = fieldPointer;
            }
            else
            {
                pointer->Subpasses = null;
            }
            pointer->DependencyCount = HeapUtil.GetLength(Dependencies);
            if (Dependencies != null)
            {
                var fieldPointer = (SubpassDependency*)HeapUtil.AllocateAndClear<SubpassDependency>(Dependencies.Length).ToPointer();
                for (var index = 0; index < (uint)Dependencies.Length; index++) fieldPointer[index] = Dependencies[index];
                pointer->Dependencies = fieldPointer;
            }
            else
            {
                pointer->Dependencies = null;
            }
        }
    }
}