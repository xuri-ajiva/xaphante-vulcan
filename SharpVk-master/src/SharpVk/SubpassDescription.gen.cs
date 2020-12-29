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
    ///     Structure specifying a subpass description.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct SubpassDescription
    {
        /// <summary>
        ///     A bitmask indicating usage of the subpass. Bits which can be set
        ///     include: + --
        /// </summary>
        public SubpassDescriptionFlags? Flags
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public PipelineBindPoint PipelineBindPoint
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public AttachmentReference[] InputAttachments
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public AttachmentReference[] ColorAttachments
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public AttachmentReference[] ResolveAttachments
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public AttachmentReference? DepthStencilAttachment
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public uint[] PreserveAttachments
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(Interop.SubpassDescription* pointer)
        {
            if (Flags != null)
                pointer->Flags = Flags.Value;
            else
                pointer->Flags = default;
            pointer->PipelineBindPoint = PipelineBindPoint;
            pointer->InputAttachmentCount = HeapUtil.GetLength(InputAttachments);
            if (InputAttachments != null)
            {
                var fieldPointer = (AttachmentReference*)HeapUtil.AllocateAndClear<AttachmentReference>(InputAttachments.Length).ToPointer();
                for (var index = 0; index < (uint)InputAttachments.Length; index++) fieldPointer[index] = InputAttachments[index];
                pointer->InputAttachments = fieldPointer;
            }
            else
            {
                pointer->InputAttachments = null;
            }
            pointer->ColorAttachmentCount = HeapUtil.GetLength(ColorAttachments);
            if (ColorAttachments != null)
            {
                var fieldPointer = (AttachmentReference*)HeapUtil.AllocateAndClear<AttachmentReference>(ColorAttachments.Length).ToPointer();
                for (var index = 0; index < (uint)ColorAttachments.Length; index++) fieldPointer[index] = ColorAttachments[index];
                pointer->ColorAttachments = fieldPointer;
            }
            else
            {
                pointer->ColorAttachments = null;
            }
            if (ResolveAttachments != null)
            {
                var fieldPointer = (AttachmentReference*)HeapUtil.AllocateAndClear<AttachmentReference>(ResolveAttachments.Length).ToPointer();
                for (var index = 0; index < (uint)ResolveAttachments.Length; index++) fieldPointer[index] = ResolveAttachments[index];
                pointer->ResolveAttachments = fieldPointer;
            }
            else
            {
                pointer->ResolveAttachments = null;
            }
            if (DepthStencilAttachment != null)
            {
                pointer->DepthStencilAttachment = (AttachmentReference*)HeapUtil.Allocate<AttachmentReference>();
                *pointer->DepthStencilAttachment = DepthStencilAttachment.Value;
            }
            else
            {
                pointer->DepthStencilAttachment = default;
            }
            pointer->PreserveAttachmentCount = HeapUtil.GetLength(PreserveAttachments);
            if (PreserveAttachments != null)
            {
                var fieldPointer = (uint*)HeapUtil.AllocateAndClear<uint>(PreserveAttachments.Length).ToPointer();
                for (var index = 0; index < (uint)PreserveAttachments.Length; index++) fieldPointer[index] = PreserveAttachments[index];
                pointer->PreserveAttachments = fieldPointer;
            }
            else
            {
                pointer->PreserveAttachments = null;
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe SubpassDescription MarshalFrom(Interop.SubpassDescription* pointer)
        {
            var result = default(SubpassDescription);
            result.Flags = pointer->Flags;
            result.PipelineBindPoint = pointer->PipelineBindPoint;
            if (pointer->InputAttachments != null)
            {
                var fieldPointer = new AttachmentReference[pointer->InputAttachmentCount];
                for (var index = 0; index < pointer->InputAttachmentCount; index++) fieldPointer[index] = pointer->InputAttachments[index];
                result.InputAttachments = fieldPointer;
            }
            else
            {
                result.InputAttachments = null;
            }
            if (pointer->ColorAttachments != null)
            {
                var fieldPointer = new AttachmentReference[pointer->ColorAttachmentCount];
                for (var index = 0; index < pointer->ColorAttachmentCount; index++) fieldPointer[index] = pointer->ColorAttachments[index];
                result.ColorAttachments = fieldPointer;
            }
            else
            {
                result.ColorAttachments = null;
            }
            if (pointer->ResolveAttachments != null)
            {
                var fieldPointer = new AttachmentReference[pointer->ColorAttachmentCount];
                for (var index = 0; index < pointer->ColorAttachmentCount; index++) fieldPointer[index] = pointer->ResolveAttachments[index];
                result.ResolveAttachments = fieldPointer;
            }
            else
            {
                result.ResolveAttachments = null;
            }
            if (pointer->DepthStencilAttachment != null)
                result.DepthStencilAttachment = *pointer->DepthStencilAttachment;
            else
                result.DepthStencilAttachment = null;
            if (pointer->PreserveAttachments != null)
            {
                var fieldPointer = new uint[pointer->PreserveAttachmentCount];
                for (var index = 0; index < pointer->PreserveAttachmentCount; index++) fieldPointer[index] = pointer->PreserveAttachments[index];
                result.PreserveAttachments = fieldPointer;
            }
            else
            {
                result.PreserveAttachments = null;
            }
            return result;
        }
    }
}