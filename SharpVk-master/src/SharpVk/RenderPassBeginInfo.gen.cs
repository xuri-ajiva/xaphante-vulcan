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
    ///     Structure specifying render pass begin info.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct RenderPassBeginInfo
    {
        /// <summary>
        ///     The render pass to begin an instance of.
        /// </summary>
        public RenderPass RenderPass
        {
            get;
            set;
        }

        /// <summary>
        ///     The framebuffer containing the attachments that are used with the
        ///     render pass.
        /// </summary>
        public Framebuffer Framebuffer
        {
            get;
            set;
        }

        /// <summary>
        ///     The render area that is affected by the render pass instance, and
        ///     is described in more detail below.
        /// </summary>
        public Rect2D RenderArea
        {
            get;
            set;
        }

        /// <summary>
        ///     An array of ClearValue structures that contains clear values for
        ///     each attachment, if the attachment uses a loadOp value of
        ///     VK_ATTACHMENT_LOAD_OP_CLEAR or if the attachment has a
        ///     depth/stencil format and uses a stencilLoadOp value of
        ///     VK_ATTACHMENT_LOAD_OP_CLEAR. The array is indexed by attachment
        ///     number. Only elements corresponding to cleared attachments are
        ///     used. Other elements of pClearValues are ignored.
        /// </summary>
        public ClearValue[] ClearValues
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(Interop.RenderPassBeginInfo* pointer)
        {
            pointer->SType = StructureType.RenderPassBeginInfo;
            pointer->Next = null;
            pointer->RenderPass = RenderPass?.Handle ?? default(Interop.RenderPass);
            pointer->Framebuffer = Framebuffer?.Handle ?? default(Interop.Framebuffer);
            pointer->RenderArea = RenderArea;
            pointer->ClearValueCount = HeapUtil.GetLength(ClearValues);
            if (ClearValues != null)
            {
                var fieldPointer = (ClearValue*)HeapUtil.AllocateAndClear<ClearValue>(ClearValues.Length).ToPointer();
                for (var index = 0; index < (uint)ClearValues.Length; index++) fieldPointer[index] = ClearValues[index];
                pointer->ClearValues = fieldPointer;
            }
            else
            {
                pointer->ClearValues = null;
            }
        }
    }
}
