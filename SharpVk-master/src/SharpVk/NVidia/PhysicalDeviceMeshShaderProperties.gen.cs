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

namespace SharpVk.NVidia
{
    /// <summary>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct PhysicalDeviceMeshShaderProperties
    {
        /// <summary>
        /// </summary>
        public uint MaxDrawMeshTasksCount
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public uint MaxTaskWorkGroupInvocations
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public (uint, uint, uint) MaxTaskWorkGroupSize
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public uint MaxTaskTotalMemorySize
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public uint MaxTaskOutputCount
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public uint MaxMeshWorkGroupInvocations
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public (uint, uint, uint) MaxMeshWorkGroupSize
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public uint MaxMeshTotalMemorySize
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public uint MaxMeshOutputVertices
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public uint MaxMeshOutputPrimitives
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public uint MaxMeshMultiviewViewCount
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public uint MeshOutputPerVertexGranularity
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public uint MeshOutputPerPrimitiveGranularity
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe PhysicalDeviceMeshShaderProperties MarshalFrom(Interop.NVidia.PhysicalDeviceMeshShaderProperties* pointer)
        {
            var result = default(PhysicalDeviceMeshShaderProperties);
            result.MaxDrawMeshTasksCount = pointer->MaxDrawMeshTasksCount;
            result.MaxTaskWorkGroupInvocations = pointer->MaxTaskWorkGroupInvocations;
            result.MaxTaskWorkGroupSize = (pointer->MaxTaskWorkGroupSize[0], pointer->MaxTaskWorkGroupSize[1], pointer->MaxTaskWorkGroupSize[2]);
            result.MaxTaskTotalMemorySize = pointer->MaxTaskTotalMemorySize;
            result.MaxTaskOutputCount = pointer->MaxTaskOutputCount;
            result.MaxMeshWorkGroupInvocations = pointer->MaxMeshWorkGroupInvocations;
            result.MaxMeshWorkGroupSize = (pointer->MaxMeshWorkGroupSize[0], pointer->MaxMeshWorkGroupSize[1], pointer->MaxMeshWorkGroupSize[2]);
            result.MaxMeshTotalMemorySize = pointer->MaxMeshTotalMemorySize;
            result.MaxMeshOutputVertices = pointer->MaxMeshOutputVertices;
            result.MaxMeshOutputPrimitives = pointer->MaxMeshOutputPrimitives;
            result.MaxMeshMultiviewViewCount = pointer->MaxMeshMultiviewViewCount;
            result.MeshOutputPerVertexGranularity = pointer->MeshOutputPerVertexGranularity;
            result.MeshOutputPerPrimitiveGranularity = pointer->MeshOutputPerPrimitiveGranularity;
            return result;
        }
    }
}