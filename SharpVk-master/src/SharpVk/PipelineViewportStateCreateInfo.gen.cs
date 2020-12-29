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
    ///     Structure specifying parameters of a newly created pipeline viewport
    ///     state.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct PipelineViewportStateCreateInfo
    {
        /// <summary>
        ///     Reserved for future use.
        /// </summary>
        public PipelineViewportStateCreateFlags? Flags
        {
            get;
            set;
        }

        /// <summary>
        ///     An array of Viewport structures, defining the viewport transforms.
        ///     If the viewport state is dynamic, this member is ignored.
        /// </summary>
        public Viewport[] Viewports
        {
            get;
            set;
        }

        /// <summary>
        ///     An array of Rect2D structures which define the rectangular bounds
        ///     of the scissor for the corresponding viewport. If the scissor state
        ///     is dynamic, this member is ignored.
        /// </summary>
        public Rect2D[] Scissors
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(Interop.PipelineViewportStateCreateInfo* pointer)
        {
            pointer->SType = StructureType.PipelineViewportStateCreateInfo;
            pointer->Next = null;
            if (Flags != null)
                pointer->Flags = Flags.Value;
            else
                pointer->Flags = default;
            pointer->ViewportCount = HeapUtil.GetLength(Viewports);
            if (Viewports != null)
            {
                var fieldPointer = (Viewport*)HeapUtil.AllocateAndClear<Viewport>(Viewports.Length).ToPointer();
                for (var index = 0; index < (uint)Viewports.Length; index++) fieldPointer[index] = Viewports[index];
                pointer->Viewports = fieldPointer;
            }
            else
            {
                pointer->Viewports = null;
            }
            pointer->ScissorCount = HeapUtil.GetLength(Scissors);
            if (Scissors != null)
            {
                var fieldPointer = (Rect2D*)HeapUtil.AllocateAndClear<Rect2D>(Scissors.Length).ToPointer();
                for (var index = 0; index < (uint)Scissors.Length; index++) fieldPointer[index] = Scissors[index];
                pointer->Scissors = fieldPointer;
            }
            else
            {
                pointer->Scissors = null;
            }
        }
    }
}