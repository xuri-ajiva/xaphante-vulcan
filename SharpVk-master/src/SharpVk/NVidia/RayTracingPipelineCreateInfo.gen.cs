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

namespace SharpVk.NVidia
{
    /// <summary>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct RayTracingPipelineCreateInfo
    {
        /// <summary>
        /// </summary>
        public PipelineCreateFlags? Flags
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public PipelineShaderStageCreateInfo[] Stages
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public RayTracingShaderGroupCreateInfo[] Groups
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public uint MaxRecursionDepth
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public PipelineLayout Layout
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public Pipeline BasePipelineHandle
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public int BasePipelineIndex
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(Interop.NVidia.RayTracingPipelineCreateInfo* pointer)
        {
            pointer->SType = StructureType.RayTracingPipelineCreateInfo;
            pointer->Next = null;
            if (Flags != null)
                pointer->Flags = Flags.Value;
            else
                pointer->Flags = default;
            pointer->StageCount = HeapUtil.GetLength(Stages);
            if (Stages != null)
            {
                var fieldPointer = (Interop.PipelineShaderStageCreateInfo*)HeapUtil.AllocateAndClear<Interop.PipelineShaderStageCreateInfo>(Stages.Length).ToPointer();
                for (var index = 0; index < (uint)Stages.Length; index++) Stages[index].MarshalTo(&fieldPointer[index]);
                pointer->Stages = fieldPointer;
            }
            else
            {
                pointer->Stages = null;
            }
            pointer->GroupCount = HeapUtil.GetLength(Groups);
            if (Groups != null)
            {
                var fieldPointer = (Interop.NVidia.RayTracingShaderGroupCreateInfo*)HeapUtil.AllocateAndClear<Interop.NVidia.RayTracingShaderGroupCreateInfo>(Groups.Length).ToPointer();
                for (var index = 0; index < (uint)Groups.Length; index++) Groups[index].MarshalTo(&fieldPointer[index]);
                pointer->Groups = fieldPointer;
            }
            else
            {
                pointer->Groups = null;
            }
            pointer->MaxRecursionDepth = MaxRecursionDepth;
            pointer->Layout = Layout?.handle ?? default(Interop.PipelineLayout);
            pointer->BasePipelineHandle = BasePipelineHandle?.handle ?? default(Interop.Pipeline);
            pointer->BasePipelineIndex = BasePipelineIndex;
        }
    }
}