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
    ///     Structure specifying parameters of a newly created pipeline depth
    ///     stencil state.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct PipelineDepthStencilStateCreateInfo
    {
        /// <summary>
        ///     Reserved for future use.
        /// </summary>
        public PipelineDepthStencilStateCreateFlags? Flags
        {
            get;
            set;
        }

        /// <summary>
        ///     depthTestEnable controls whether depth testing is enabled.
        /// </summary>
        public bool DepthTestEnable
        {
            get;
            set;
        }

        /// <summary>
        ///     depthWriteEnable controls whether depth writes are enabled.
        /// </summary>
        public bool DepthWriteEnable
        {
            get;
            set;
        }

        /// <summary>
        ///     The comparison operator used in the depth test.
        /// </summary>
        public CompareOp DepthCompareOp
        {
            get;
            set;
        }

        /// <summary>
        ///     depthBoundsTestEnable controls whether depth bounds testing is
        ///     enabled.
        /// </summary>
        public bool DepthBoundsTestEnable
        {
            get;
            set;
        }

        /// <summary>
        ///     stencilTestEnable controls whether stencil testing is enabled.
        /// </summary>
        public bool StencilTestEnable
        {
            get;
            set;
        }

        /// <summary>
        ///     front and back control the parameters of the stencil test.
        /// </summary>
        public StencilOpState Front
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public StencilOpState Back
        {
            get;
            set;
        }

        /// <summary>
        ///     minDepthBounds and maxDepthBounds define the range of values used
        ///     in the depth bounds test.
        /// </summary>
        public float MinDepthBounds
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public float MaxDepthBounds
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(Interop.PipelineDepthStencilStateCreateInfo* pointer)
        {
            pointer->SType = StructureType.PipelineDepthStencilStateCreateInfo;
            pointer->Next = null;
            if (Flags != null)
                pointer->Flags = Flags.Value;
            else
                pointer->Flags = default;
            pointer->DepthTestEnable = DepthTestEnable;
            pointer->DepthWriteEnable = DepthWriteEnable;
            pointer->DepthCompareOp = DepthCompareOp;
            pointer->DepthBoundsTestEnable = DepthBoundsTestEnable;
            pointer->StencilTestEnable = StencilTestEnable;
            pointer->Front = Front;
            pointer->Back = Back;
            pointer->MinDepthBounds = MinDepthBounds;
            pointer->MaxDepthBounds = MaxDepthBounds;
        }
    }
}