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
    ///     Structure describing the fine-grained features that can be supported by
    ///     an implementation.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct PhysicalDeviceFeatures
    {
        /// <summary>
        /// </summary>
        public bool RobustBufferAccess
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool FullDrawIndexUint32
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool ImageCubeArray
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool IndependentBlend
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool GeometryShader
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool TessellationShader
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool SampleRateShading
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool DualSourceBlend
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool LogicOp
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool MultiDrawIndirect
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool DrawIndirectFirstInstance
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool DepthClamp
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool DepthBiasClamp
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool FillModeNonSolid
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool DepthBounds
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool WideLines
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool LargePoints
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool AlphaToOne
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool MultiViewport
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool SamplerAnisotropy
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool TextureCompressionETC2
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool TexturecompressionastcLdr
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool TextureCompressionBC
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool OcclusionQueryPrecise
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool PipelineStatisticsQuery
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool VertexPipelineStoresAndAtomics
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool FragmentStoresAndAtomics
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool ShaderTessellationAndGeometryPointSize
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool ShaderImageGatherExtended
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool ShaderStorageImageExtendedFormats
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool ShaderStorageImageMultisample
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool ShaderStorageImageReadWithoutFormat
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool ShaderStorageImageWriteWithoutFormat
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool ShaderUniformBufferArrayDynamicIndexing
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool ShaderSampledImageArrayDynamicIndexing
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool ShaderStorageBufferArrayDynamicIndexing
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool ShaderStorageImageArrayDynamicIndexing
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool ShaderClipDistance
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool ShaderCullDistance
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool ShaderFloat64
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool ShaderInt64
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool ShaderInt16
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool ShaderResourceResidency
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool ShaderResourceMinLod
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool SparseBinding
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool SparseResidencyBuffer
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool SparseResidencyImage2D
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool SparseResidencyImage3D
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool SparseResidency2Samples
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool SparseResidency4Samples
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool SparseResidency8Samples
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool SparseResidency16Samples
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool SparseResidencyAliased
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool VariableMultisampleRate
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool InheritedQueries
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(Interop.PhysicalDeviceFeatures* pointer)
        {
            pointer->RobustBufferAccess = RobustBufferAccess;
            pointer->FullDrawIndexUint32 = FullDrawIndexUint32;
            pointer->ImageCubeArray = ImageCubeArray;
            pointer->IndependentBlend = IndependentBlend;
            pointer->GeometryShader = GeometryShader;
            pointer->TessellationShader = TessellationShader;
            pointer->SampleRateShading = SampleRateShading;
            pointer->DualSourceBlend = DualSourceBlend;
            pointer->LogicOp = LogicOp;
            pointer->MultiDrawIndirect = MultiDrawIndirect;
            pointer->DrawIndirectFirstInstance = DrawIndirectFirstInstance;
            pointer->DepthClamp = DepthClamp;
            pointer->DepthBiasClamp = DepthBiasClamp;
            pointer->FillModeNonSolid = FillModeNonSolid;
            pointer->DepthBounds = DepthBounds;
            pointer->WideLines = WideLines;
            pointer->LargePoints = LargePoints;
            pointer->AlphaToOne = AlphaToOne;
            pointer->MultiViewport = MultiViewport;
            pointer->SamplerAnisotropy = SamplerAnisotropy;
            pointer->TextureCompressionETC2 = TextureCompressionETC2;
            pointer->TexturecompressionastcLdr = TexturecompressionastcLdr;
            pointer->TextureCompressionBC = TextureCompressionBC;
            pointer->OcclusionQueryPrecise = OcclusionQueryPrecise;
            pointer->PipelineStatisticsQuery = PipelineStatisticsQuery;
            pointer->VertexPipelineStoresAndAtomics = VertexPipelineStoresAndAtomics;
            pointer->FragmentStoresAndAtomics = FragmentStoresAndAtomics;
            pointer->ShaderTessellationAndGeometryPointSize = ShaderTessellationAndGeometryPointSize;
            pointer->ShaderImageGatherExtended = ShaderImageGatherExtended;
            pointer->ShaderStorageImageExtendedFormats = ShaderStorageImageExtendedFormats;
            pointer->ShaderStorageImageMultisample = ShaderStorageImageMultisample;
            pointer->ShaderStorageImageReadWithoutFormat = ShaderStorageImageReadWithoutFormat;
            pointer->ShaderStorageImageWriteWithoutFormat = ShaderStorageImageWriteWithoutFormat;
            pointer->ShaderUniformBufferArrayDynamicIndexing = ShaderUniformBufferArrayDynamicIndexing;
            pointer->ShaderSampledImageArrayDynamicIndexing = ShaderSampledImageArrayDynamicIndexing;
            pointer->ShaderStorageBufferArrayDynamicIndexing = ShaderStorageBufferArrayDynamicIndexing;
            pointer->ShaderStorageImageArrayDynamicIndexing = ShaderStorageImageArrayDynamicIndexing;
            pointer->ShaderClipDistance = ShaderClipDistance;
            pointer->ShaderCullDistance = ShaderCullDistance;
            pointer->ShaderFloat64 = ShaderFloat64;
            pointer->ShaderInt64 = ShaderInt64;
            pointer->ShaderInt16 = ShaderInt16;
            pointer->ShaderResourceResidency = ShaderResourceResidency;
            pointer->ShaderResourceMinLod = ShaderResourceMinLod;
            pointer->SparseBinding = SparseBinding;
            pointer->SparseResidencyBuffer = SparseResidencyBuffer;
            pointer->SparseResidencyImage2D = SparseResidencyImage2D;
            pointer->SparseResidencyImage3D = SparseResidencyImage3D;
            pointer->SparseResidency2Samples = SparseResidency2Samples;
            pointer->SparseResidency4Samples = SparseResidency4Samples;
            pointer->SparseResidency8Samples = SparseResidency8Samples;
            pointer->SparseResidency16Samples = SparseResidency16Samples;
            pointer->SparseResidencyAliased = SparseResidencyAliased;
            pointer->VariableMultisampleRate = VariableMultisampleRate;
            pointer->InheritedQueries = InheritedQueries;
        }

        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe PhysicalDeviceFeatures MarshalFrom(Interop.PhysicalDeviceFeatures* pointer)
        {
            var result = default(PhysicalDeviceFeatures);
            result.RobustBufferAccess = pointer->RobustBufferAccess;
            result.FullDrawIndexUint32 = pointer->FullDrawIndexUint32;
            result.ImageCubeArray = pointer->ImageCubeArray;
            result.IndependentBlend = pointer->IndependentBlend;
            result.GeometryShader = pointer->GeometryShader;
            result.TessellationShader = pointer->TessellationShader;
            result.SampleRateShading = pointer->SampleRateShading;
            result.DualSourceBlend = pointer->DualSourceBlend;
            result.LogicOp = pointer->LogicOp;
            result.MultiDrawIndirect = pointer->MultiDrawIndirect;
            result.DrawIndirectFirstInstance = pointer->DrawIndirectFirstInstance;
            result.DepthClamp = pointer->DepthClamp;
            result.DepthBiasClamp = pointer->DepthBiasClamp;
            result.FillModeNonSolid = pointer->FillModeNonSolid;
            result.DepthBounds = pointer->DepthBounds;
            result.WideLines = pointer->WideLines;
            result.LargePoints = pointer->LargePoints;
            result.AlphaToOne = pointer->AlphaToOne;
            result.MultiViewport = pointer->MultiViewport;
            result.SamplerAnisotropy = pointer->SamplerAnisotropy;
            result.TextureCompressionETC2 = pointer->TextureCompressionETC2;
            result.TexturecompressionastcLdr = pointer->TexturecompressionastcLdr;
            result.TextureCompressionBC = pointer->TextureCompressionBC;
            result.OcclusionQueryPrecise = pointer->OcclusionQueryPrecise;
            result.PipelineStatisticsQuery = pointer->PipelineStatisticsQuery;
            result.VertexPipelineStoresAndAtomics = pointer->VertexPipelineStoresAndAtomics;
            result.FragmentStoresAndAtomics = pointer->FragmentStoresAndAtomics;
            result.ShaderTessellationAndGeometryPointSize = pointer->ShaderTessellationAndGeometryPointSize;
            result.ShaderImageGatherExtended = pointer->ShaderImageGatherExtended;
            result.ShaderStorageImageExtendedFormats = pointer->ShaderStorageImageExtendedFormats;
            result.ShaderStorageImageMultisample = pointer->ShaderStorageImageMultisample;
            result.ShaderStorageImageReadWithoutFormat = pointer->ShaderStorageImageReadWithoutFormat;
            result.ShaderStorageImageWriteWithoutFormat = pointer->ShaderStorageImageWriteWithoutFormat;
            result.ShaderUniformBufferArrayDynamicIndexing = pointer->ShaderUniformBufferArrayDynamicIndexing;
            result.ShaderSampledImageArrayDynamicIndexing = pointer->ShaderSampledImageArrayDynamicIndexing;
            result.ShaderStorageBufferArrayDynamicIndexing = pointer->ShaderStorageBufferArrayDynamicIndexing;
            result.ShaderStorageImageArrayDynamicIndexing = pointer->ShaderStorageImageArrayDynamicIndexing;
            result.ShaderClipDistance = pointer->ShaderClipDistance;
            result.ShaderCullDistance = pointer->ShaderCullDistance;
            result.ShaderFloat64 = pointer->ShaderFloat64;
            result.ShaderInt64 = pointer->ShaderInt64;
            result.ShaderInt16 = pointer->ShaderInt16;
            result.ShaderResourceResidency = pointer->ShaderResourceResidency;
            result.ShaderResourceMinLod = pointer->ShaderResourceMinLod;
            result.SparseBinding = pointer->SparseBinding;
            result.SparseResidencyBuffer = pointer->SparseResidencyBuffer;
            result.SparseResidencyImage2D = pointer->SparseResidencyImage2D;
            result.SparseResidencyImage3D = pointer->SparseResidencyImage3D;
            result.SparseResidency2Samples = pointer->SparseResidency2Samples;
            result.SparseResidency4Samples = pointer->SparseResidency4Samples;
            result.SparseResidency8Samples = pointer->SparseResidency8Samples;
            result.SparseResidency16Samples = pointer->SparseResidency16Samples;
            result.SparseResidencyAliased = pointer->SparseResidencyAliased;
            result.VariableMultisampleRate = pointer->VariableMultisampleRate;
            result.InheritedQueries = pointer->InheritedQueries;
            return result;
        }
    }
}