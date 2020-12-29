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
    public struct SubpassDescriptionDepthStencilResolve
    {
        /// <summary>
        /// </summary>
        public ResolveModeFlags DepthResolveMode
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public ResolveModeFlags StencilResolveMode
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public AttachmentReference2? DepthStencilResolveAttachment
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(Interop.SubpassDescriptionDepthStencilResolve* pointer)
        {
            pointer->SType = StructureType.SubpassDescriptionDepthStencilResolveVersion;
            pointer->Next = null;
            pointer->DepthResolveMode = DepthResolveMode;
            pointer->StencilResolveMode = StencilResolveMode;
            if (DepthStencilResolveAttachment != null)
            {
                pointer->DepthStencilResolveAttachment = (Interop.AttachmentReference2*)HeapUtil.Allocate<Interop.AttachmentReference2>();
                DepthStencilResolveAttachment.Value.MarshalTo(pointer->DepthStencilResolveAttachment);
            }
            else
            {
                pointer->DepthStencilResolveAttachment = default;
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe SubpassDescriptionDepthStencilResolve MarshalFrom(Interop.SubpassDescriptionDepthStencilResolve* pointer)
        {
            var result = default(SubpassDescriptionDepthStencilResolve);
            result.DepthResolveMode = pointer->DepthResolveMode;
            result.StencilResolveMode = pointer->StencilResolveMode;
            if (pointer->DepthStencilResolveAttachment != null)
                result.DepthStencilResolveAttachment = AttachmentReference2.MarshalFrom(pointer->DepthStencilResolveAttachment);
            else
                result.DepthStencilResolveAttachment = null;
            return result;
        }
    }
}