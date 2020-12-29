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

namespace SharpVk.Interop
{
    /// <summary>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct PhysicalDeviceVulkan12Properties
    {
        /// <summary>
        /// </summary>
        public StructureType SType;

        /// <summary>
        /// </summary>
        public void* Next;

        /// <summary>
        /// </summary>
        public DriverId DriverID;

        /// <summary>
        /// </summary>
        public fixed byte DriverName[Constants.MaxDriverNameSize];

        /// <summary>
        /// </summary>
        public fixed byte DriverInfo[Constants.MaxDriverInfoSize];

        /// <summary>
        /// </summary>
        public ConformanceVersion ConformanceVersion;

        /// <summary>
        /// </summary>
        public ShaderFloatControlsIndependence DenormBehaviorIndependence;

        /// <summary>
        /// </summary>
        public ShaderFloatControlsIndependence RoundingModeIndependence;

        /// <summary>
        /// </summary>
        public Bool32 ShaderSignedZeroInfNanPreserveFloat16;

        /// <summary>
        /// </summary>
        public Bool32 ShaderSignedZeroInfNanPreserveFloat32;

        /// <summary>
        /// </summary>
        public Bool32 ShaderSignedZeroInfNanPreserveFloat64;

        /// <summary>
        /// </summary>
        public Bool32 ShaderDenormPreserveFloat16;

        /// <summary>
        /// </summary>
        public Bool32 ShaderDenormPreserveFloat32;

        /// <summary>
        /// </summary>
        public Bool32 ShaderDenormPreserveFloat64;

        /// <summary>
        /// </summary>
        public Bool32 ShaderDenormFlushToZeroFloat16;

        /// <summary>
        /// </summary>
        public Bool32 ShaderDenormFlushToZeroFloat32;

        /// <summary>
        /// </summary>
        public Bool32 ShaderDenormFlushToZeroFloat64;

        /// <summary>
        /// </summary>
        public Bool32 ShaderRoundingModeRTEFloat16;

        /// <summary>
        /// </summary>
        public Bool32 ShaderRoundingModeRTEFloat32;

        /// <summary>
        /// </summary>
        public Bool32 ShaderRoundingModeRTEFloat64;

        /// <summary>
        /// </summary>
        public Bool32 ShaderRoundingModeRTZFloat16;

        /// <summary>
        /// </summary>
        public Bool32 ShaderRoundingModeRTZFloat32;

        /// <summary>
        /// </summary>
        public Bool32 ShaderRoundingModeRTZFloat64;

        /// <summary>
        /// </summary>
        public uint MaxUpdateAfterBindDescriptorsInAllPools;

        /// <summary>
        /// </summary>
        public Bool32 ShaderUniformBufferArrayNonUniformIndexingNative;

        /// <summary>
        /// </summary>
        public Bool32 ShaderSampledImageArrayNonUniformIndexingNative;

        /// <summary>
        /// </summary>
        public Bool32 ShaderStorageBufferArrayNonUniformIndexingNative;

        /// <summary>
        /// </summary>
        public Bool32 ShaderStorageImageArrayNonUniformIndexingNative;

        /// <summary>
        /// </summary>
        public Bool32 ShaderInputAttachmentArrayNonUniformIndexingNative;

        /// <summary>
        /// </summary>
        public Bool32 RobustBufferAccessUpdateAfterBind;

        /// <summary>
        /// </summary>
        public Bool32 QuadDivergentImplicitLod;

        /// <summary>
        /// </summary>
        public uint MaxPerStageDescriptorUpdateAfterBindSamplers;

        /// <summary>
        /// </summary>
        public uint MaxPerStageDescriptorUpdateAfterBindUniformBuffers;

        /// <summary>
        /// </summary>
        public uint MaxPerStageDescriptorUpdateAfterBindStorageBuffers;

        /// <summary>
        /// </summary>
        public uint MaxPerStageDescriptorUpdateAfterBindSampledImages;

        /// <summary>
        /// </summary>
        public uint MaxPerStageDescriptorUpdateAfterBindStorageImages;

        /// <summary>
        /// </summary>
        public uint MaxPerStageDescriptorUpdateAfterBindInputAttachments;

        /// <summary>
        /// </summary>
        public uint MaxPerStageUpdateAfterBindResources;

        /// <summary>
        /// </summary>
        public uint MaxDescriptorSetUpdateAfterBindSamplers;

        /// <summary>
        /// </summary>
        public uint MaxDescriptorSetUpdateAfterBindUniformBuffers;

        /// <summary>
        /// </summary>
        public uint MaxDescriptorSetUpdateAfterBindUniformBuffersDynamic;

        /// <summary>
        /// </summary>
        public uint MaxDescriptorSetUpdateAfterBindStorageBuffers;

        /// <summary>
        /// </summary>
        public uint MaxDescriptorSetUpdateAfterBindStorageBuffersDynamic;

        /// <summary>
        /// </summary>
        public uint MaxDescriptorSetUpdateAfterBindSampledImages;

        /// <summary>
        /// </summary>
        public uint MaxDescriptorSetUpdateAfterBindStorageImages;

        /// <summary>
        /// </summary>
        public uint MaxDescriptorSetUpdateAfterBindInputAttachments;

        /// <summary>
        /// </summary>
        public ResolveModeFlags SupportedDepthResolveModes;

        /// <summary>
        /// </summary>
        public ResolveModeFlags SupportedStencilResolveModes;

        /// <summary>
        /// </summary>
        public Bool32 IndependentResolveNone;

        /// <summary>
        /// </summary>
        public Bool32 IndependentResolve;

        /// <summary>
        /// </summary>
        public Bool32 FilterMinmaxSingleComponentFormats;

        /// <summary>
        /// </summary>
        public Bool32 FilterMinmaxImageComponentMapping;

        /// <summary>
        /// </summary>
        public ulong MaxTimelineSemaphoreValueDifference;

        /// <summary>
        /// </summary>
        public SampleCountFlags FramebufferIntegerColorSampleCounts;
    }
}