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
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct RenderPassCreateInfo2
    {
        /// <summary>
        /// </summary>
        public RenderPassCreateFlags? Flags
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public AttachmentDescription2[] Attachments
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public SubpassDescription2[] Subpasses
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public SubpassDependency2[] Dependencies
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public uint[] CorrelatedViewMasks
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(Interop.RenderPassCreateInfo2* pointer)
        {
            pointer->SType = StructureType.RenderPassCreateInfo2Version;
            pointer->Next = null;
            if (Flags != null)
                pointer->Flags = Flags.Value;
            else
                pointer->Flags = default;
            pointer->AttachmentCount = HeapUtil.GetLength(Attachments);
            if (Attachments != null)
            {
                var fieldPointer = (Interop.AttachmentDescription2*)HeapUtil.AllocateAndClear<Interop.AttachmentDescription2>(Attachments.Length).ToPointer();
                for (var index = 0; index < (uint)Attachments.Length; index++) Attachments[index].MarshalTo(&fieldPointer[index]);
                pointer->Attachments = fieldPointer;
            }
            else
            {
                pointer->Attachments = null;
            }
            pointer->SubpassCount = HeapUtil.GetLength(Subpasses);
            if (Subpasses != null)
            {
                var fieldPointer = (Interop.SubpassDescription2*)HeapUtil.AllocateAndClear<Interop.SubpassDescription2>(Subpasses.Length).ToPointer();
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
                var fieldPointer = (Interop.SubpassDependency2*)HeapUtil.AllocateAndClear<Interop.SubpassDependency2>(Dependencies.Length).ToPointer();
                for (var index = 0; index < (uint)Dependencies.Length; index++) Dependencies[index].MarshalTo(&fieldPointer[index]);
                pointer->Dependencies = fieldPointer;
            }
            else
            {
                pointer->Dependencies = null;
            }
            pointer->CorrelatedViewMaskCount = HeapUtil.GetLength(CorrelatedViewMasks);
            if (CorrelatedViewMasks != null)
            {
                var fieldPointer = (uint*)HeapUtil.AllocateAndClear<uint>(CorrelatedViewMasks.Length).ToPointer();
                for (var index = 0; index < (uint)CorrelatedViewMasks.Length; index++) fieldPointer[index] = CorrelatedViewMasks[index];
                pointer->CorrelatedViewMasks = fieldPointer;
            }
            else
            {
                pointer->CorrelatedViewMasks = null;
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe RenderPassCreateInfo2 MarshalFrom(Interop.RenderPassCreateInfo2* pointer)
        {
            var result = default(RenderPassCreateInfo2);
            result.Flags = pointer->Flags;
            if (pointer->Attachments != null)
            {
                var fieldPointer = new AttachmentDescription2[pointer->AttachmentCount];
                for (var index = 0; index < pointer->AttachmentCount; index++) fieldPointer[index] = AttachmentDescription2.MarshalFrom(&pointer->Attachments[index]);
                result.Attachments = fieldPointer;
            }
            else
            {
                result.Attachments = null;
            }
            if (pointer->Subpasses != null)
            {
                var fieldPointer = new SubpassDescription2[pointer->SubpassCount];
                for (var index = 0; index < pointer->SubpassCount; index++) fieldPointer[index] = SubpassDescription2.MarshalFrom(&pointer->Subpasses[index]);
                result.Subpasses = fieldPointer;
            }
            else
            {
                result.Subpasses = null;
            }
            if (pointer->Dependencies != null)
            {
                var fieldPointer = new SubpassDependency2[pointer->DependencyCount];
                for (var index = 0; index < pointer->DependencyCount; index++) fieldPointer[index] = SubpassDependency2.MarshalFrom(&pointer->Dependencies[index]);
                result.Dependencies = fieldPointer;
            }
            else
            {
                result.Dependencies = null;
            }
            if (pointer->CorrelatedViewMasks != null)
            {
                var fieldPointer = new uint[pointer->CorrelatedViewMaskCount];
                for (var index = 0; index < pointer->CorrelatedViewMaskCount; index++) fieldPointer[index] = pointer->CorrelatedViewMasks[index];
                result.CorrelatedViewMasks = fieldPointer;
            }
            else
            {
                result.CorrelatedViewMasks = null;
            }
            return result;
        }
    }
}