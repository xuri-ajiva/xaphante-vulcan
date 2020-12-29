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
    public struct PhysicalDeviceVulkan12Properties
    {
        /// <summary>
        /// </summary>
        public DriverId DriverId
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public string DriverName
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public string DriverInfo
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public ConformanceVersion ConformanceVersion
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public ShaderFloatControlsIndependence DenormBehaviorIndependence
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public ShaderFloatControlsIndependence RoundingModeIndependence
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool ShaderSignedZeroInfNanPreserveFloat16
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool ShaderSignedZeroInfNanPreserveFloat32
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool ShaderSignedZeroInfNanPreserveFloat64
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool ShaderDenormPreserveFloat16
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool ShaderDenormPreserveFloat32
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool ShaderDenormPreserveFloat64
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool ShaderDenormFlushToZeroFloat16
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool ShaderDenormFlushToZeroFloat32
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool ShaderDenormFlushToZeroFloat64
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool ShaderRoundingModeRteFloat16
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool ShaderRoundingModeRteFloat32
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool ShaderRoundingModeRteFloat64
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool ShaderRoundingModeRtzFloat16
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool ShaderRoundingModeRtzFloat32
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool ShaderRoundingModeRtzFloat64
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public uint MaxUpdateAfterBindDescriptorsInAllPools
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool ShaderUniformBufferArrayNonUniformIndexingNative
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool ShaderSampledImageArrayNonUniformIndexingNative
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool ShaderStorageBufferArrayNonUniformIndexingNative
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool ShaderStorageImageArrayNonUniformIndexingNative
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool ShaderInputAttachmentArrayNonUniformIndexingNative
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool RobustBufferAccessUpdateAfterBind
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool QuadDivergentImplicitLod
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public uint MaxPerStageDescriptorUpdateAfterBindSamplers
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public uint MaxPerStageDescriptorUpdateAfterBindUniformBuffers
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public uint MaxPerStageDescriptorUpdateAfterBindStorageBuffers
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public uint MaxPerStageDescriptorUpdateAfterBindSampledImages
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public uint MaxPerStageDescriptorUpdateAfterBindStorageImages
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public uint MaxPerStageDescriptorUpdateAfterBindInputAttachments
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public uint MaxPerStageUpdateAfterBindResources
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public uint MaxDescriptorSetUpdateAfterBindSamplers
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public uint MaxDescriptorSetUpdateAfterBindUniformBuffers
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public uint MaxDescriptorSetUpdateAfterBindUniformBuffersDynamic
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public uint MaxDescriptorSetUpdateAfterBindStorageBuffers
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public uint MaxDescriptorSetUpdateAfterBindStorageBuffersDynamic
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public uint MaxDescriptorSetUpdateAfterBindSampledImages
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public uint MaxDescriptorSetUpdateAfterBindStorageImages
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public uint MaxDescriptorSetUpdateAfterBindInputAttachments
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public ResolveModeFlags SupportedDepthResolveModes
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public ResolveModeFlags SupportedStencilResolveModes
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool IndependentResolveNone
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool IndependentResolve
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool FilterMinmaxSingleComponentFormats
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool FilterMinmaxImageComponentMapping
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public ulong MaxTimelineSemaphoreValueDifference
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public SampleCountFlags? FramebufferIntegerColorSampleCounts
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(Interop.PhysicalDeviceVulkan12Properties* pointer)
        {
            pointer->SType = StructureType.PhysicalDeviceVulkan12Properties;
            pointer->Next = null;
            pointer->DriverID = DriverId;
            pointer->ConformanceVersion = ConformanceVersion;
            pointer->DenormBehaviorIndependence = DenormBehaviorIndependence;
            pointer->RoundingModeIndependence = RoundingModeIndependence;
            pointer->ShaderSignedZeroInfNanPreserveFloat16 = ShaderSignedZeroInfNanPreserveFloat16;
            pointer->ShaderSignedZeroInfNanPreserveFloat32 = ShaderSignedZeroInfNanPreserveFloat32;
            pointer->ShaderSignedZeroInfNanPreserveFloat64 = ShaderSignedZeroInfNanPreserveFloat64;
            pointer->ShaderDenormPreserveFloat16 = ShaderDenormPreserveFloat16;
            pointer->ShaderDenormPreserveFloat32 = ShaderDenormPreserveFloat32;
            pointer->ShaderDenormPreserveFloat64 = ShaderDenormPreserveFloat64;
            pointer->ShaderDenormFlushToZeroFloat16 = ShaderDenormFlushToZeroFloat16;
            pointer->ShaderDenormFlushToZeroFloat32 = ShaderDenormFlushToZeroFloat32;
            pointer->ShaderDenormFlushToZeroFloat64 = ShaderDenormFlushToZeroFloat64;
            pointer->ShaderRoundingModeRTEFloat16 = ShaderRoundingModeRteFloat16;
            pointer->ShaderRoundingModeRTEFloat32 = ShaderRoundingModeRteFloat32;
            pointer->ShaderRoundingModeRTEFloat64 = ShaderRoundingModeRteFloat64;
            pointer->ShaderRoundingModeRTZFloat16 = ShaderRoundingModeRtzFloat16;
            pointer->ShaderRoundingModeRTZFloat32 = ShaderRoundingModeRtzFloat32;
            pointer->ShaderRoundingModeRTZFloat64 = ShaderRoundingModeRtzFloat64;
            pointer->MaxUpdateAfterBindDescriptorsInAllPools = MaxUpdateAfterBindDescriptorsInAllPools;
            pointer->ShaderUniformBufferArrayNonUniformIndexingNative = ShaderUniformBufferArrayNonUniformIndexingNative;
            pointer->ShaderSampledImageArrayNonUniformIndexingNative = ShaderSampledImageArrayNonUniformIndexingNative;
            pointer->ShaderStorageBufferArrayNonUniformIndexingNative = ShaderStorageBufferArrayNonUniformIndexingNative;
            pointer->ShaderStorageImageArrayNonUniformIndexingNative = ShaderStorageImageArrayNonUniformIndexingNative;
            pointer->ShaderInputAttachmentArrayNonUniformIndexingNative = ShaderInputAttachmentArrayNonUniformIndexingNative;
            pointer->RobustBufferAccessUpdateAfterBind = RobustBufferAccessUpdateAfterBind;
            pointer->QuadDivergentImplicitLod = QuadDivergentImplicitLod;
            pointer->MaxPerStageDescriptorUpdateAfterBindSamplers = MaxPerStageDescriptorUpdateAfterBindSamplers;
            pointer->MaxPerStageDescriptorUpdateAfterBindUniformBuffers = MaxPerStageDescriptorUpdateAfterBindUniformBuffers;
            pointer->MaxPerStageDescriptorUpdateAfterBindStorageBuffers = MaxPerStageDescriptorUpdateAfterBindStorageBuffers;
            pointer->MaxPerStageDescriptorUpdateAfterBindSampledImages = MaxPerStageDescriptorUpdateAfterBindSampledImages;
            pointer->MaxPerStageDescriptorUpdateAfterBindStorageImages = MaxPerStageDescriptorUpdateAfterBindStorageImages;
            pointer->MaxPerStageDescriptorUpdateAfterBindInputAttachments = MaxPerStageDescriptorUpdateAfterBindInputAttachments;
            pointer->MaxPerStageUpdateAfterBindResources = MaxPerStageUpdateAfterBindResources;
            pointer->MaxDescriptorSetUpdateAfterBindSamplers = MaxDescriptorSetUpdateAfterBindSamplers;
            pointer->MaxDescriptorSetUpdateAfterBindUniformBuffers = MaxDescriptorSetUpdateAfterBindUniformBuffers;
            pointer->MaxDescriptorSetUpdateAfterBindUniformBuffersDynamic = MaxDescriptorSetUpdateAfterBindUniformBuffersDynamic;
            pointer->MaxDescriptorSetUpdateAfterBindStorageBuffers = MaxDescriptorSetUpdateAfterBindStorageBuffers;
            pointer->MaxDescriptorSetUpdateAfterBindStorageBuffersDynamic = MaxDescriptorSetUpdateAfterBindStorageBuffersDynamic;
            pointer->MaxDescriptorSetUpdateAfterBindSampledImages = MaxDescriptorSetUpdateAfterBindSampledImages;
            pointer->MaxDescriptorSetUpdateAfterBindStorageImages = MaxDescriptorSetUpdateAfterBindStorageImages;
            pointer->MaxDescriptorSetUpdateAfterBindInputAttachments = MaxDescriptorSetUpdateAfterBindInputAttachments;
            pointer->SupportedDepthResolveModes = SupportedDepthResolveModes;
            pointer->SupportedStencilResolveModes = SupportedStencilResolveModes;
            pointer->IndependentResolveNone = IndependentResolveNone;
            pointer->IndependentResolve = IndependentResolve;
            pointer->FilterMinmaxSingleComponentFormats = FilterMinmaxSingleComponentFormats;
            pointer->FilterMinmaxImageComponentMapping = FilterMinmaxImageComponentMapping;
            pointer->MaxTimelineSemaphoreValueDifference = MaxTimelineSemaphoreValueDifference;
            if (FramebufferIntegerColorSampleCounts != null)
                pointer->FramebufferIntegerColorSampleCounts = FramebufferIntegerColorSampleCounts.Value;
            else
                pointer->FramebufferIntegerColorSampleCounts = default;
        }

        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe PhysicalDeviceVulkan12Properties MarshalFrom(Interop.PhysicalDeviceVulkan12Properties* pointer)
        {
            var result = default(PhysicalDeviceVulkan12Properties);
            result.DriverId = pointer->DriverID;
            result.DriverName = HeapUtil.MarshalStringFrom(pointer->DriverName, Constants.MaxDriverNameSize, true);
            result.DriverInfo = HeapUtil.MarshalStringFrom(pointer->DriverInfo, Constants.MaxDriverInfoSize, true);
            result.ConformanceVersion = pointer->ConformanceVersion;
            result.DenormBehaviorIndependence = pointer->DenormBehaviorIndependence;
            result.RoundingModeIndependence = pointer->RoundingModeIndependence;
            result.ShaderSignedZeroInfNanPreserveFloat16 = pointer->ShaderSignedZeroInfNanPreserveFloat16;
            result.ShaderSignedZeroInfNanPreserveFloat32 = pointer->ShaderSignedZeroInfNanPreserveFloat32;
            result.ShaderSignedZeroInfNanPreserveFloat64 = pointer->ShaderSignedZeroInfNanPreserveFloat64;
            result.ShaderDenormPreserveFloat16 = pointer->ShaderDenormPreserveFloat16;
            result.ShaderDenormPreserveFloat32 = pointer->ShaderDenormPreserveFloat32;
            result.ShaderDenormPreserveFloat64 = pointer->ShaderDenormPreserveFloat64;
            result.ShaderDenormFlushToZeroFloat16 = pointer->ShaderDenormFlushToZeroFloat16;
            result.ShaderDenormFlushToZeroFloat32 = pointer->ShaderDenormFlushToZeroFloat32;
            result.ShaderDenormFlushToZeroFloat64 = pointer->ShaderDenormFlushToZeroFloat64;
            result.ShaderRoundingModeRteFloat16 = pointer->ShaderRoundingModeRTEFloat16;
            result.ShaderRoundingModeRteFloat32 = pointer->ShaderRoundingModeRTEFloat32;
            result.ShaderRoundingModeRteFloat64 = pointer->ShaderRoundingModeRTEFloat64;
            result.ShaderRoundingModeRtzFloat16 = pointer->ShaderRoundingModeRTZFloat16;
            result.ShaderRoundingModeRtzFloat32 = pointer->ShaderRoundingModeRTZFloat32;
            result.ShaderRoundingModeRtzFloat64 = pointer->ShaderRoundingModeRTZFloat64;
            result.MaxUpdateAfterBindDescriptorsInAllPools = pointer->MaxUpdateAfterBindDescriptorsInAllPools;
            result.ShaderUniformBufferArrayNonUniformIndexingNative = pointer->ShaderUniformBufferArrayNonUniformIndexingNative;
            result.ShaderSampledImageArrayNonUniformIndexingNative = pointer->ShaderSampledImageArrayNonUniformIndexingNative;
            result.ShaderStorageBufferArrayNonUniformIndexingNative = pointer->ShaderStorageBufferArrayNonUniformIndexingNative;
            result.ShaderStorageImageArrayNonUniformIndexingNative = pointer->ShaderStorageImageArrayNonUniformIndexingNative;
            result.ShaderInputAttachmentArrayNonUniformIndexingNative = pointer->ShaderInputAttachmentArrayNonUniformIndexingNative;
            result.RobustBufferAccessUpdateAfterBind = pointer->RobustBufferAccessUpdateAfterBind;
            result.QuadDivergentImplicitLod = pointer->QuadDivergentImplicitLod;
            result.MaxPerStageDescriptorUpdateAfterBindSamplers = pointer->MaxPerStageDescriptorUpdateAfterBindSamplers;
            result.MaxPerStageDescriptorUpdateAfterBindUniformBuffers = pointer->MaxPerStageDescriptorUpdateAfterBindUniformBuffers;
            result.MaxPerStageDescriptorUpdateAfterBindStorageBuffers = pointer->MaxPerStageDescriptorUpdateAfterBindStorageBuffers;
            result.MaxPerStageDescriptorUpdateAfterBindSampledImages = pointer->MaxPerStageDescriptorUpdateAfterBindSampledImages;
            result.MaxPerStageDescriptorUpdateAfterBindStorageImages = pointer->MaxPerStageDescriptorUpdateAfterBindStorageImages;
            result.MaxPerStageDescriptorUpdateAfterBindInputAttachments = pointer->MaxPerStageDescriptorUpdateAfterBindInputAttachments;
            result.MaxPerStageUpdateAfterBindResources = pointer->MaxPerStageUpdateAfterBindResources;
            result.MaxDescriptorSetUpdateAfterBindSamplers = pointer->MaxDescriptorSetUpdateAfterBindSamplers;
            result.MaxDescriptorSetUpdateAfterBindUniformBuffers = pointer->MaxDescriptorSetUpdateAfterBindUniformBuffers;
            result.MaxDescriptorSetUpdateAfterBindUniformBuffersDynamic = pointer->MaxDescriptorSetUpdateAfterBindUniformBuffersDynamic;
            result.MaxDescriptorSetUpdateAfterBindStorageBuffers = pointer->MaxDescriptorSetUpdateAfterBindStorageBuffers;
            result.MaxDescriptorSetUpdateAfterBindStorageBuffersDynamic = pointer->MaxDescriptorSetUpdateAfterBindStorageBuffersDynamic;
            result.MaxDescriptorSetUpdateAfterBindSampledImages = pointer->MaxDescriptorSetUpdateAfterBindSampledImages;
            result.MaxDescriptorSetUpdateAfterBindStorageImages = pointer->MaxDescriptorSetUpdateAfterBindStorageImages;
            result.MaxDescriptorSetUpdateAfterBindInputAttachments = pointer->MaxDescriptorSetUpdateAfterBindInputAttachments;
            result.SupportedDepthResolveModes = pointer->SupportedDepthResolveModes;
            result.SupportedStencilResolveModes = pointer->SupportedStencilResolveModes;
            result.IndependentResolveNone = pointer->IndependentResolveNone;
            result.IndependentResolve = pointer->IndependentResolve;
            result.FilterMinmaxSingleComponentFormats = pointer->FilterMinmaxSingleComponentFormats;
            result.FilterMinmaxImageComponentMapping = pointer->FilterMinmaxImageComponentMapping;
            result.MaxTimelineSemaphoreValueDifference = pointer->MaxTimelineSemaphoreValueDifference;
            result.FramebufferIntegerColorSampleCounts = pointer->FramebufferIntegerColorSampleCounts;
            return result;
        }
    }
}
