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
    ///     Structure specifying parameters of a newly created framebuffer.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct FramebufferCreateInfo
    {
        /// <summary>
        ///     Reserved for future use.
        /// </summary>
        public FramebufferCreateFlags? Flags
        {
            get;
            set;
        }

        /// <summary>
        ///     A render pass that defines what render passes the framebuffer will
        ///     be compatible with.
        /// </summary>
        public RenderPass RenderPass
        {
            get;
            set;
        }

        /// <summary>
        ///     An array of ImageView handles, each of which will be used as the
        ///     corresponding attachment in a render pass instance.
        /// </summary>
        public ImageView[] Attachments
        {
            get;
            set;
        }

        /// <summary>
        ///     width, height and layers define the dimensions of the framebuffer.
        ///     If the render pass uses multiview, then layers must be one and each
        ///     attachment requires a number of layers that is greater than the
        ///     maximum bit index set in the view mask in the subpasses in which it
        ///     is used.
        /// </summary>
        public uint Width
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public uint Height
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public uint Layers
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(Interop.FramebufferCreateInfo* pointer)
        {
            pointer->SType = StructureType.FramebufferCreateInfo;
            pointer->Next = null;
            if (Flags != null)
                pointer->Flags = Flags.Value;
            else
                pointer->Flags = default;
            pointer->RenderPass = RenderPass?.Handle ?? default(Interop.RenderPass);
            pointer->AttachmentCount = HeapUtil.GetLength(Attachments);
            if (Attachments != null)
            {
                var fieldPointer = (Interop.ImageView*)HeapUtil.AllocateAndClear<Interop.ImageView>(Attachments.Length).ToPointer();
                for (var index = 0; index < (uint)Attachments.Length; index++) fieldPointer[index] = Attachments[index]?.Handle ?? default(Interop.ImageView);
                pointer->Attachments = fieldPointer;
            }
            else
            {
                pointer->Attachments = null;
            }
            pointer->Width = Width;
            pointer->Height = Height;
            pointer->Layers = Layers;
        }
    }
}
