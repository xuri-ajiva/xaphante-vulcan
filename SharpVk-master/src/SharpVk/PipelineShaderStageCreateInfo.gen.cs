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
    ///     Structure specifying parameters of a newly created pipeline shader
    ///     stage.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct PipelineShaderStageCreateInfo
    {
        /// <summary>
        ///     Reserved for future use.
        /// </summary>
        public PipelineShaderStageCreateFlags? Flags
        {
            get;
            set;
        }

        /// <summary>
        ///     stage names a single pipeline stage. Bits which can be set include:
        ///     + --
        /// </summary>
        public ShaderStageFlags Stage
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public ShaderModule Module
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public SpecializationInfo? SpecializationInfo
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(Interop.PipelineShaderStageCreateInfo* pointer)
        {
            pointer->SType = StructureType.PipelineShaderStageCreateInfo;
            pointer->Next = null;
            if (Flags != null)
                pointer->Flags = Flags.Value;
            else
                pointer->Flags = default;
            pointer->Stage = Stage;
            pointer->Module = Module?.handle ?? default(Interop.ShaderModule);
            pointer->Name = HeapUtil.MarshalTo(Name);
            if (SpecializationInfo != null)
            {
                pointer->SpecializationInfo = (Interop.SpecializationInfo*)HeapUtil.Allocate<Interop.SpecializationInfo>();
                SpecializationInfo.Value.MarshalTo(pointer->SpecializationInfo);
            }
            else
            {
                pointer->SpecializationInfo = default;
            }
        }
    }
}