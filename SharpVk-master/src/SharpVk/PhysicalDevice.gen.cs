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

using SharpVk.Amd;
using SharpVk.Intel;
using SharpVk.Interop;
using SharpVk.Khronos;
using SharpVk.Multivendor;
using SharpVk.NVidia;

namespace SharpVk
{
    /// <summary>
    ///     Opaque handle to a physical device object.
    /// </summary>
    public partial class PhysicalDevice
    {
        internal readonly CommandCache commandCache;
        internal readonly Interop.PhysicalDevice handle;

        internal readonly Instance parent;

        internal PhysicalDevice(Instance parent, Interop.PhysicalDevice handle)
        {
            this.handle = handle;
            this.parent = parent;
            commandCache = parent.commandCache;
        }

        /// <summary>
        ///     The raw handle for this instance.
        /// </summary>
        public Interop.PhysicalDevice RawHandle => handle;

        /// <summary>
        ///     Reports capabilities of a physical device.
        /// </summary>
        public unsafe PhysicalDeviceFeatures GetFeatures()
        {
            try
            {
                var result = default(PhysicalDeviceFeatures);
                var marshalledFeatures = default(Interop.PhysicalDeviceFeatures);
                var commandDelegate = commandCache.Cache.vkGetPhysicalDeviceFeatures;
                commandDelegate(handle, &marshalledFeatures);
                result = PhysicalDeviceFeatures.MarshalFrom(&marshalledFeatures);
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Lists physical device's format capabilities.
        /// </summary>
        /// <param name="format">
        /// </param>
        public unsafe FormatProperties GetFormatProperties(Format format)
        {
            try
            {
                var result = default(FormatProperties);
                var marshalledFormatProperties = default(FormatProperties);
                var commandDelegate = commandCache.Cache.vkGetPhysicalDeviceFormatProperties;
                commandDelegate(handle, format, &marshalledFormatProperties);
                result = marshalledFormatProperties;
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Lists physical device's image format capabilities.
        /// </summary>
        /// <param name="format">
        /// </param>
        /// <param name="type">
        /// </param>
        /// <param name="tiling">
        /// </param>
        /// <param name="usage">
        /// </param>
        /// <param name="flags">
        /// </param>
        public unsafe ImageFormatProperties GetImageFormatProperties(Format format, ImageType type, ImageTiling tiling, ImageUsageFlags usage, ImageCreateFlags? flags = default)
        {
            try
            {
                var result = default(ImageFormatProperties);
                var marshalledFlags = default(ImageCreateFlags);
                var marshalledImageFormatProperties = default(ImageFormatProperties);
                if (flags != null)
                    marshalledFlags = flags.Value;
                else
                    marshalledFlags = default;
                var commandDelegate = commandCache.Cache.vkGetPhysicalDeviceImageFormatProperties;
                var methodResult = commandDelegate(handle, format, type, tiling, usage, marshalledFlags, &marshalledImageFormatProperties);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                result = marshalledImageFormatProperties;
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Returns properties of a physical device.
        /// </summary>
        public unsafe PhysicalDeviceProperties GetProperties()
        {
            try
            {
                var result = default(PhysicalDeviceProperties);
                var marshalledProperties = default(Interop.PhysicalDeviceProperties);
                var commandDelegate = commandCache.Cache.vkGetPhysicalDeviceProperties;
                commandDelegate(handle, &marshalledProperties);
                result = PhysicalDeviceProperties.MarshalFrom(&marshalledProperties);
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Reports properties of the queues of the specified physical device.
        /// </summary>
        public unsafe QueueFamilyProperties[] GetQueueFamilyProperties()
        {
            try
            {
                var result = default(QueueFamilyProperties[]);
                var marshalledQueueFamilyPropertyCount = default(uint);
                var marshalledQueueFamilyProperties = default(QueueFamilyProperties*);
                var commandDelegate = commandCache.Cache.vkGetPhysicalDeviceQueueFamilyProperties;
                commandDelegate(handle, &marshalledQueueFamilyPropertyCount, marshalledQueueFamilyProperties);
                marshalledQueueFamilyProperties = (QueueFamilyProperties*)HeapUtil.Allocate<QueueFamilyProperties>(marshalledQueueFamilyPropertyCount);
                commandDelegate(handle, &marshalledQueueFamilyPropertyCount, marshalledQueueFamilyProperties);
                if (marshalledQueueFamilyProperties != null)
                {
                    var fieldPointer = new QueueFamilyProperties[marshalledQueueFamilyPropertyCount];
                    for (var index = 0; index < marshalledQueueFamilyPropertyCount; index++) fieldPointer[index] = marshalledQueueFamilyProperties[index];
                    result = fieldPointer;
                }
                else
                {
                    result = null;
                }
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Reports memory information for the specified physical device.
        /// </summary>
        public unsafe PhysicalDeviceMemoryProperties GetMemoryProperties()
        {
            try
            {
                var result = default(PhysicalDeviceMemoryProperties);
                var marshalledMemoryProperties = default(Interop.PhysicalDeviceMemoryProperties);
                var commandDelegate = commandCache.Cache.vkGetPhysicalDeviceMemoryProperties;
                commandDelegate(handle, &marshalledMemoryProperties);
                result = PhysicalDeviceMemoryProperties.MarshalFrom(&marshalledMemoryProperties);
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Create a new device instance.
        /// </summary>
        /// <param name="flags">
        ///     Reserved for future use.
        /// </param>
        /// <param name="queueCreateInfos">
        /// </param>
        /// <param name="enabledLayerNames">
        ///     ppEnabledLayerNames is deprecated and ignored.
        /// </param>
        /// <param name="enabledExtensionNames">
        ///     An array of enabledExtensionCount strings containing the names of
        ///     extensions to enable for the created device.
        /// </param>
        /// <param name="enabledFeatures">
        ///     Null or a PhysicalDeviceFeatures structure that contains boolean
        ///     indicators of all the features to be enabled.
        /// </param>
        /// <param name="physicalDeviceFeatures2">
        ///     Extension struct
        /// </param>
        /// <param name="physicalDeviceVariablePointersFeatures">
        ///     Extension struct
        /// </param>
        /// <param name="physicalDeviceMultiviewFeatures">
        ///     Extension struct
        /// </param>
        /// <param name="deviceGroupDeviceCreateInfo">
        ///     Extension struct
        /// </param>
        /// <param name="physicalDevice16BitStorageFeatures">
        ///     Extension struct
        /// </param>
        /// <param name="physicalDeviceShaderSubgroupExtendedTypesFeatures">
        ///     Extension struct
        /// </param>
        /// <param name="physicalDeviceSamplerYcbcrConversionFeatures">
        ///     Extension struct
        /// </param>
        /// <param name="physicalDeviceProtectedMemoryFeatures">
        ///     Extension struct
        /// </param>
        /// <param name="physicalDeviceBlendOperationAdvancedFeaturesExt">
        ///     Extension struct
        /// </param>
        /// <param name="physicalDeviceInlineUniformBlockFeaturesExt">
        ///     Extension struct
        /// </param>
        /// <param name="physicalDeviceShaderDrawParametersFeatures">
        ///     Extension struct
        /// </param>
        /// <param name="physicalDeviceShaderFloat16Int8Features">
        ///     Extension struct
        /// </param>
        /// <param name="physicalDeviceHostQueryResetFeatures">
        ///     Extension struct
        /// </param>
        /// <param name="physicalDeviceDescriptorIndexingFeatures">
        ///     Extension struct
        /// </param>
        /// <param name="physicalDeviceTimelineSemaphoreFeatures">
        ///     Extension struct
        /// </param>
        /// <param name="physicalDevice8BitStorageFeatures">
        ///     Extension struct
        /// </param>
        /// <param name="physicalDeviceConditionalRenderingFeaturesExt">
        ///     Extension struct
        /// </param>
        /// <param name="physicalDeviceVulkanMemoryModelFeatures">
        ///     Extension struct
        /// </param>
        /// <param name="physicalDeviceShaderAtomicInt64Features">
        ///     Extension struct
        /// </param>
        /// <param name="physicalDeviceVertexAttributeDivisorFeaturesExt">
        ///     Extension struct
        /// </param>
        /// <param name="physicalDeviceASTCDecodeFeaturesExt">
        ///     Extension struct
        /// </param>
        /// <param name="physicalDeviceTransformFeedbackFeaturesExt">
        ///     Extension struct
        /// </param>
        /// <param name="physicalDeviceRepresentativeFragmentTestFeaturesNv">
        ///     Extension struct
        /// </param>
        /// <param name="physicalDeviceExclusiveScissorFeaturesNv">
        ///     Extension struct
        /// </param>
        /// <param name="physicalDeviceCornerSampledImageFeaturesNv">
        ///     Extension struct
        /// </param>
        /// <param name="physicalDeviceComputeShaderDerivativesFeaturesNv">
        ///     Extension struct
        /// </param>
        /// <param name="physicalDeviceFragmentShaderBarycentricFeaturesNv">
        ///     Extension struct
        /// </param>
        /// <param name="physicalDeviceShaderImageFootprintFeaturesNv">
        ///     Extension struct
        /// </param>
        /// <param name="physicalDeviceDedicatedAllocationImageAliasingFeaturesNv">
        ///     Extension struct
        /// </param>
        /// <param name="physicalDeviceShadingRateImageFeaturesNv">
        ///     Extension struct
        /// </param>
        /// <param name="physicalDeviceMeshShaderFeaturesNv">
        ///     Extension struct
        /// </param>
        /// <param name="deviceMemoryOverallocationCreateInfoAmd">
        ///     Extension struct
        /// </param>
        /// <param name="physicalDeviceFragmentDensityMapFeaturesExt">
        ///     Extension struct
        /// </param>
        /// <param name="physicalDeviceScalarBlockLayoutFeatures">
        ///     Extension struct
        /// </param>
        /// <param name="physicalDeviceUniformBufferStandardLayoutFeatures">
        ///     Extension struct
        /// </param>
        /// <param name="physicalDeviceDepthClipEnableFeaturesExt">
        ///     Extension struct
        /// </param>
        /// <param name="physicalDeviceMemoryPriorityFeaturesExt">
        ///     Extension struct
        /// </param>
        /// <param name="physicalDeviceBufferDeviceAddressFeatures">
        ///     Extension struct
        /// </param>
        /// <param name="physicalDeviceBufferDeviceAddressFeaturesExt">
        ///     Extension struct
        /// </param>
        /// <param name="physicalDeviceImagelessFramebufferFeatures">
        ///     Extension struct
        /// </param>
        /// <param name="physicalDeviceTextureCompressionASTCHDRFeaturesExt">
        ///     Extension struct
        /// </param>
        /// <param name="physicalDeviceCooperativeMatrixFeaturesNv">
        ///     Extension struct
        /// </param>
        /// <param name="physicalDeviceYcbcrImageArraysFeaturesExt">
        ///     Extension struct
        /// </param>
        /// <param name="physicalDevicePerformanceQueryFeaturesKhr">
        ///     Extension struct
        /// </param>
        /// <param name="physicalDeviceCoverageReductionModeFeaturesNv">
        ///     Extension struct
        /// </param>
        /// <param name="physicalDeviceShaderIntegerFunctions2FeaturesIntel">
        ///     Extension struct
        /// </param>
        /// <param name="physicalDeviceShaderClockFeaturesKhr">
        ///     Extension struct
        /// </param>
        /// <param name="physicalDeviceIndexTypeUint8FeaturesExt">
        ///     Extension struct
        /// </param>
        /// <param name="physicalDeviceShaderSMBuiltinsFeaturesNv">
        ///     Extension struct
        /// </param>
        /// <param name="physicalDeviceFragmentShaderInterlockFeaturesExt">
        ///     Extension struct
        /// </param>
        /// <param name="physicalDeviceSeparateDepthStencilLayoutsFeatures">
        ///     Extension struct
        /// </param>
        /// <param name="physicalDevicePipelineExecutablePropertiesFeaturesKhr">
        ///     Extension struct
        /// </param>
        /// <param name="physicalDeviceShaderDemoteToHelperInvocationFeaturesExt">
        ///     Extension struct
        /// </param>
        /// <param name="physicalDeviceTexelBufferAlignmentFeaturesExt">
        ///     Extension struct
        /// </param>
        /// <param name="physicalDeviceSubgroupSizeControlFeaturesExt">
        ///     Extension struct
        /// </param>
        /// <param name="physicalDeviceLineRasterizationFeaturesExt">
        ///     Extension struct
        /// </param>
        /// <param name="physicalDeviceVulkan11Features">
        ///     Extension struct
        /// </param>
        /// <param name="physicalDeviceVulkan12Features">
        ///     Extension struct
        /// </param>
        /// <param name="physicalDeviceCoherentMemoryFeaturesAmd">
        ///     Extension struct
        /// </param>
        /// <param name="allocator">
        ///     An optional AllocationCallbacks instance that controls host memory
        ///     allocation.
        /// </param>
        public unsafe Device CreateDevice(ArrayProxy<DeviceQueueCreateInfo>? queueCreateInfos, ArrayProxy<string>? enabledLayerNames, ArrayProxy<string>? enabledExtensionNames, DeviceCreateFlags? flags = default, PhysicalDeviceFeatures? enabledFeatures = default, PhysicalDeviceFeatures2? physicalDeviceFeatures2 = null, PhysicalDeviceVariablePointersFeatures? physicalDeviceVariablePointersFeatures = null, PhysicalDeviceMultiviewFeatures? physicalDeviceMultiviewFeatures = null, DeviceGroupDeviceCreateInfo? deviceGroupDeviceCreateInfo = null, PhysicalDevice16BitStorageFeatures? physicalDevice16BitStorageFeatures = null,
            PhysicalDeviceShaderSubgroupExtendedTypesFeatures? physicalDeviceShaderSubgroupExtendedTypesFeatures = null, PhysicalDeviceSamplerYcbcrConversionFeatures? physicalDeviceSamplerYcbcrConversionFeatures = null, PhysicalDeviceProtectedMemoryFeatures? physicalDeviceProtectedMemoryFeatures = null, PhysicalDeviceBlendOperationAdvancedFeatures? physicalDeviceBlendOperationAdvancedFeaturesExt = null, PhysicalDeviceInlineUniformBlockFeatures? physicalDeviceInlineUniformBlockFeaturesExt = null, PhysicalDeviceShaderDrawParametersFeatures? physicalDeviceShaderDrawParametersFeatures = null,
            PhysicalDeviceShaderFloat16Int8Features? physicalDeviceShaderFloat16Int8Features = null, PhysicalDeviceHostQueryResetFeatures? physicalDeviceHostQueryResetFeatures = null, PhysicalDeviceDescriptorIndexingFeatures? physicalDeviceDescriptorIndexingFeatures = null, PhysicalDeviceTimelineSemaphoreFeatures? physicalDeviceTimelineSemaphoreFeatures = null, PhysicalDevice8BitStorageFeatures? physicalDevice8BitStorageFeatures = null, PhysicalDeviceConditionalRenderingFeatures? physicalDeviceConditionalRenderingFeaturesExt = null, PhysicalDeviceVulkanMemoryModelFeatures? physicalDeviceVulkanMemoryModelFeatures = null,
            PhysicalDeviceShaderAtomicInt64Features? physicalDeviceShaderAtomicInt64Features = null, PhysicalDeviceVertexAttributeDivisorFeatures? physicalDeviceVertexAttributeDivisorFeaturesExt = null, PhysicalDeviceASTCDecodeFeatures? physicalDeviceASTCDecodeFeaturesExt = null, PhysicalDeviceTransformFeedbackFeatures? physicalDeviceTransformFeedbackFeaturesExt = null, PhysicalDeviceRepresentativeFragmentTestFeatures? physicalDeviceRepresentativeFragmentTestFeaturesNv = null, PhysicalDeviceExclusiveScissorFeatures? physicalDeviceExclusiveScissorFeaturesNv = null,
            PhysicalDeviceCornerSampledImageFeatures? physicalDeviceCornerSampledImageFeaturesNv = null, PhysicalDeviceComputeShaderDerivativesFeatures? physicalDeviceComputeShaderDerivativesFeaturesNv = null, PhysicalDeviceFragmentShaderBarycentricFeatures? physicalDeviceFragmentShaderBarycentricFeaturesNv = null, PhysicalDeviceShaderImageFootprintFeatures? physicalDeviceShaderImageFootprintFeaturesNv = null, PhysicalDeviceDedicatedAllocationImageAliasingFeatures? physicalDeviceDedicatedAllocationImageAliasingFeaturesNv = null, PhysicalDeviceShadingRateImageFeatures? physicalDeviceShadingRateImageFeaturesNv = null,
            PhysicalDeviceMeshShaderFeatures? physicalDeviceMeshShaderFeaturesNv = null, DeviceMemoryOverallocationCreateInfo? deviceMemoryOverallocationCreateInfoAmd = null, PhysicalDeviceFragmentDensityMapFeatures? physicalDeviceFragmentDensityMapFeaturesExt = null, PhysicalDeviceScalarBlockLayoutFeatures? physicalDeviceScalarBlockLayoutFeatures = null, PhysicalDeviceUniformBufferStandardLayoutFeatures? physicalDeviceUniformBufferStandardLayoutFeatures = null, PhysicalDeviceDepthClipEnableFeatures? physicalDeviceDepthClipEnableFeaturesExt = null,
            PhysicalDeviceMemoryPriorityFeatures? physicalDeviceMemoryPriorityFeaturesExt = null, PhysicalDeviceBufferDeviceAddressFeatures? physicalDeviceBufferDeviceAddressFeatures = null, Multivendor.PhysicalDeviceBufferDeviceAddressFeatures? physicalDeviceBufferDeviceAddressFeaturesExt = null, PhysicalDeviceImagelessFramebufferFeatures? physicalDeviceImagelessFramebufferFeatures = null, PhysicalDeviceTextureCompressionASTCHDRFeatures? physicalDeviceTextureCompressionASTCHDRFeaturesExt = null, PhysicalDeviceCooperativeMatrixFeatures? physicalDeviceCooperativeMatrixFeaturesNv = null,
            PhysicalDeviceYcbcrImageArraysFeatures? physicalDeviceYcbcrImageArraysFeaturesExt = null, PhysicalDevicePerformanceQueryFeatures? physicalDevicePerformanceQueryFeaturesKhr = null, PhysicalDeviceCoverageReductionModeFeatures? physicalDeviceCoverageReductionModeFeaturesNv = null, PhysicalDeviceShaderIntegerFunctions2Features? physicalDeviceShaderIntegerFunctions2FeaturesIntel = null, PhysicalDeviceShaderClockFeatures? physicalDeviceShaderClockFeaturesKhr = null, PhysicalDeviceIndexTypeUint8Features? physicalDeviceIndexTypeUint8FeaturesExt = null,
            PhysicalDeviceShaderSMBuiltinsFeatures? physicalDeviceShaderSMBuiltinsFeaturesNv = null, PhysicalDeviceFragmentShaderInterlockFeatures? physicalDeviceFragmentShaderInterlockFeaturesExt = null, PhysicalDeviceSeparateDepthStencilLayoutsFeatures? physicalDeviceSeparateDepthStencilLayoutsFeatures = null, PhysicalDevicePipelineExecutablePropertiesFeatures? physicalDevicePipelineExecutablePropertiesFeaturesKhr = null, PhysicalDeviceShaderDemoteToHelperInvocationFeatures? physicalDeviceShaderDemoteToHelperInvocationFeaturesExt = null,
            PhysicalDeviceTexelBufferAlignmentFeatures? physicalDeviceTexelBufferAlignmentFeaturesExt = null, PhysicalDeviceSubgroupSizeControlFeatures? physicalDeviceSubgroupSizeControlFeaturesExt = null, PhysicalDeviceLineRasterizationFeatures? physicalDeviceLineRasterizationFeaturesExt = null, PhysicalDeviceVulkan11Features? physicalDeviceVulkan11Features = null, PhysicalDeviceVulkan12Features? physicalDeviceVulkan12Features = null, PhysicalDeviceCoherentMemoryFeatures? physicalDeviceCoherentMemoryFeaturesAmd = null, AllocationCallbacks? allocator = default)
        {
            try
            {
                var result = default(Device);
                var marshalledCreateInfo = default(Interop.DeviceCreateInfo*);
                var vkDeviceCreateInfoNextPointer = default(void*);
                var marshalledAllocator = default(Interop.AllocationCallbacks*);
                var marshalledDevice = default(Interop.Device);
                if (physicalDeviceFeatures2 != null)
                {
                    var extensionPointer = default(Interop.PhysicalDeviceFeatures2*);
                    extensionPointer = (Interop.PhysicalDeviceFeatures2*)HeapUtil.Allocate<Interop.PhysicalDeviceFeatures2>();
                    physicalDeviceFeatures2.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceVariablePointersFeatures != null)
                {
                    var extensionPointer = default(Interop.PhysicalDeviceVariablePointersFeatures*);
                    extensionPointer = (Interop.PhysicalDeviceVariablePointersFeatures*)HeapUtil.Allocate<Interop.PhysicalDeviceVariablePointersFeatures>();
                    physicalDeviceVariablePointersFeatures.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceMultiviewFeatures != null)
                {
                    var extensionPointer = default(Interop.PhysicalDeviceMultiviewFeatures*);
                    extensionPointer = (Interop.PhysicalDeviceMultiviewFeatures*)HeapUtil.Allocate<Interop.PhysicalDeviceMultiviewFeatures>();
                    physicalDeviceMultiviewFeatures.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (deviceGroupDeviceCreateInfo != null)
                {
                    var extensionPointer = default(Interop.DeviceGroupDeviceCreateInfo*);
                    extensionPointer = (Interop.DeviceGroupDeviceCreateInfo*)HeapUtil.Allocate<Interop.DeviceGroupDeviceCreateInfo>();
                    deviceGroupDeviceCreateInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDevice16BitStorageFeatures != null)
                {
                    var extensionPointer = default(Interop.PhysicalDevice16BitStorageFeatures*);
                    extensionPointer = (Interop.PhysicalDevice16BitStorageFeatures*)HeapUtil.Allocate<Interop.PhysicalDevice16BitStorageFeatures>();
                    physicalDevice16BitStorageFeatures.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceShaderSubgroupExtendedTypesFeatures != null)
                {
                    var extensionPointer = default(Interop.PhysicalDeviceShaderSubgroupExtendedTypesFeatures*);
                    extensionPointer = (Interop.PhysicalDeviceShaderSubgroupExtendedTypesFeatures*)HeapUtil.Allocate<Interop.PhysicalDeviceShaderSubgroupExtendedTypesFeatures>();
                    physicalDeviceShaderSubgroupExtendedTypesFeatures.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceSamplerYcbcrConversionFeatures != null)
                {
                    var extensionPointer = default(Interop.PhysicalDeviceSamplerYcbcrConversionFeatures*);
                    extensionPointer = (Interop.PhysicalDeviceSamplerYcbcrConversionFeatures*)HeapUtil.Allocate<Interop.PhysicalDeviceSamplerYcbcrConversionFeatures>();
                    physicalDeviceSamplerYcbcrConversionFeatures.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceProtectedMemoryFeatures != null)
                {
                    var extensionPointer = default(Interop.PhysicalDeviceProtectedMemoryFeatures*);
                    extensionPointer = (Interop.PhysicalDeviceProtectedMemoryFeatures*)HeapUtil.Allocate<Interop.PhysicalDeviceProtectedMemoryFeatures>();
                    physicalDeviceProtectedMemoryFeatures.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceBlendOperationAdvancedFeaturesExt != null)
                {
                    var extensionPointer = default(Interop.Multivendor.PhysicalDeviceBlendOperationAdvancedFeatures*);
                    extensionPointer = (Interop.Multivendor.PhysicalDeviceBlendOperationAdvancedFeatures*)HeapUtil.Allocate<Interop.Multivendor.PhysicalDeviceBlendOperationAdvancedFeatures>();
                    physicalDeviceBlendOperationAdvancedFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceInlineUniformBlockFeaturesExt != null)
                {
                    var extensionPointer = default(Interop.Multivendor.PhysicalDeviceInlineUniformBlockFeatures*);
                    extensionPointer = (Interop.Multivendor.PhysicalDeviceInlineUniformBlockFeatures*)HeapUtil.Allocate<Interop.Multivendor.PhysicalDeviceInlineUniformBlockFeatures>();
                    physicalDeviceInlineUniformBlockFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceShaderDrawParametersFeatures != null)
                {
                    var extensionPointer = default(Interop.PhysicalDeviceShaderDrawParametersFeatures*);
                    extensionPointer = (Interop.PhysicalDeviceShaderDrawParametersFeatures*)HeapUtil.Allocate<Interop.PhysicalDeviceShaderDrawParametersFeatures>();
                    physicalDeviceShaderDrawParametersFeatures.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceShaderFloat16Int8Features != null)
                {
                    var extensionPointer = default(Interop.PhysicalDeviceShaderFloat16Int8Features*);
                    extensionPointer = (Interop.PhysicalDeviceShaderFloat16Int8Features*)HeapUtil.Allocate<Interop.PhysicalDeviceShaderFloat16Int8Features>();
                    physicalDeviceShaderFloat16Int8Features.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceHostQueryResetFeatures != null)
                {
                    var extensionPointer = default(Interop.PhysicalDeviceHostQueryResetFeatures*);
                    extensionPointer = (Interop.PhysicalDeviceHostQueryResetFeatures*)HeapUtil.Allocate<Interop.PhysicalDeviceHostQueryResetFeatures>();
                    physicalDeviceHostQueryResetFeatures.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceDescriptorIndexingFeatures != null)
                {
                    var extensionPointer = default(Interop.PhysicalDeviceDescriptorIndexingFeatures*);
                    extensionPointer = (Interop.PhysicalDeviceDescriptorIndexingFeatures*)HeapUtil.Allocate<Interop.PhysicalDeviceDescriptorIndexingFeatures>();
                    physicalDeviceDescriptorIndexingFeatures.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceTimelineSemaphoreFeatures != null)
                {
                    var extensionPointer = default(Interop.PhysicalDeviceTimelineSemaphoreFeatures*);
                    extensionPointer = (Interop.PhysicalDeviceTimelineSemaphoreFeatures*)HeapUtil.Allocate<Interop.PhysicalDeviceTimelineSemaphoreFeatures>();
                    physicalDeviceTimelineSemaphoreFeatures.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDevice8BitStorageFeatures != null)
                {
                    var extensionPointer = default(Interop.PhysicalDevice8BitStorageFeatures*);
                    extensionPointer = (Interop.PhysicalDevice8BitStorageFeatures*)HeapUtil.Allocate<Interop.PhysicalDevice8BitStorageFeatures>();
                    physicalDevice8BitStorageFeatures.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceConditionalRenderingFeaturesExt != null)
                {
                    var extensionPointer = default(Interop.Multivendor.PhysicalDeviceConditionalRenderingFeatures*);
                    extensionPointer = (Interop.Multivendor.PhysicalDeviceConditionalRenderingFeatures*)HeapUtil.Allocate<Interop.Multivendor.PhysicalDeviceConditionalRenderingFeatures>();
                    physicalDeviceConditionalRenderingFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceVulkanMemoryModelFeatures != null)
                {
                    var extensionPointer = default(Interop.PhysicalDeviceVulkanMemoryModelFeatures*);
                    extensionPointer = (Interop.PhysicalDeviceVulkanMemoryModelFeatures*)HeapUtil.Allocate<Interop.PhysicalDeviceVulkanMemoryModelFeatures>();
                    physicalDeviceVulkanMemoryModelFeatures.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceShaderAtomicInt64Features != null)
                {
                    var extensionPointer = default(Interop.PhysicalDeviceShaderAtomicInt64Features*);
                    extensionPointer = (Interop.PhysicalDeviceShaderAtomicInt64Features*)HeapUtil.Allocate<Interop.PhysicalDeviceShaderAtomicInt64Features>();
                    physicalDeviceShaderAtomicInt64Features.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceVertexAttributeDivisorFeaturesExt != null)
                {
                    var extensionPointer = default(Interop.Multivendor.PhysicalDeviceVertexAttributeDivisorFeatures*);
                    extensionPointer = (Interop.Multivendor.PhysicalDeviceVertexAttributeDivisorFeatures*)HeapUtil.Allocate<Interop.Multivendor.PhysicalDeviceVertexAttributeDivisorFeatures>();
                    physicalDeviceVertexAttributeDivisorFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceASTCDecodeFeaturesExt != null)
                {
                    var extensionPointer = default(Interop.Multivendor.PhysicalDeviceASTCDecodeFeatures*);
                    extensionPointer = (Interop.Multivendor.PhysicalDeviceASTCDecodeFeatures*)HeapUtil.Allocate<Interop.Multivendor.PhysicalDeviceASTCDecodeFeatures>();
                    physicalDeviceASTCDecodeFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceTransformFeedbackFeaturesExt != null)
                {
                    var extensionPointer = default(Interop.Multivendor.PhysicalDeviceTransformFeedbackFeatures*);
                    extensionPointer = (Interop.Multivendor.PhysicalDeviceTransformFeedbackFeatures*)HeapUtil.Allocate<Interop.Multivendor.PhysicalDeviceTransformFeedbackFeatures>();
                    physicalDeviceTransformFeedbackFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceRepresentativeFragmentTestFeaturesNv != null)
                {
                    var extensionPointer = default(Interop.NVidia.PhysicalDeviceRepresentativeFragmentTestFeatures*);
                    extensionPointer = (Interop.NVidia.PhysicalDeviceRepresentativeFragmentTestFeatures*)HeapUtil.Allocate<Interop.NVidia.PhysicalDeviceRepresentativeFragmentTestFeatures>();
                    physicalDeviceRepresentativeFragmentTestFeaturesNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceExclusiveScissorFeaturesNv != null)
                {
                    var extensionPointer = default(Interop.NVidia.PhysicalDeviceExclusiveScissorFeatures*);
                    extensionPointer = (Interop.NVidia.PhysicalDeviceExclusiveScissorFeatures*)HeapUtil.Allocate<Interop.NVidia.PhysicalDeviceExclusiveScissorFeatures>();
                    physicalDeviceExclusiveScissorFeaturesNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceCornerSampledImageFeaturesNv != null)
                {
                    var extensionPointer = default(Interop.NVidia.PhysicalDeviceCornerSampledImageFeatures*);
                    extensionPointer = (Interop.NVidia.PhysicalDeviceCornerSampledImageFeatures*)HeapUtil.Allocate<Interop.NVidia.PhysicalDeviceCornerSampledImageFeatures>();
                    physicalDeviceCornerSampledImageFeaturesNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceComputeShaderDerivativesFeaturesNv != null)
                {
                    var extensionPointer = default(Interop.NVidia.PhysicalDeviceComputeShaderDerivativesFeatures*);
                    extensionPointer = (Interop.NVidia.PhysicalDeviceComputeShaderDerivativesFeatures*)HeapUtil.Allocate<Interop.NVidia.PhysicalDeviceComputeShaderDerivativesFeatures>();
                    physicalDeviceComputeShaderDerivativesFeaturesNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceFragmentShaderBarycentricFeaturesNv != null)
                {
                    var extensionPointer = default(Interop.NVidia.PhysicalDeviceFragmentShaderBarycentricFeatures*);
                    extensionPointer = (Interop.NVidia.PhysicalDeviceFragmentShaderBarycentricFeatures*)HeapUtil.Allocate<Interop.NVidia.PhysicalDeviceFragmentShaderBarycentricFeatures>();
                    physicalDeviceFragmentShaderBarycentricFeaturesNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceShaderImageFootprintFeaturesNv != null)
                {
                    var extensionPointer = default(Interop.NVidia.PhysicalDeviceShaderImageFootprintFeatures*);
                    extensionPointer = (Interop.NVidia.PhysicalDeviceShaderImageFootprintFeatures*)HeapUtil.Allocate<Interop.NVidia.PhysicalDeviceShaderImageFootprintFeatures>();
                    physicalDeviceShaderImageFootprintFeaturesNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceDedicatedAllocationImageAliasingFeaturesNv != null)
                {
                    var extensionPointer = default(Interop.NVidia.PhysicalDeviceDedicatedAllocationImageAliasingFeatures*);
                    extensionPointer = (Interop.NVidia.PhysicalDeviceDedicatedAllocationImageAliasingFeatures*)HeapUtil.Allocate<Interop.NVidia.PhysicalDeviceDedicatedAllocationImageAliasingFeatures>();
                    physicalDeviceDedicatedAllocationImageAliasingFeaturesNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceShadingRateImageFeaturesNv != null)
                {
                    var extensionPointer = default(Interop.NVidia.PhysicalDeviceShadingRateImageFeatures*);
                    extensionPointer = (Interop.NVidia.PhysicalDeviceShadingRateImageFeatures*)HeapUtil.Allocate<Interop.NVidia.PhysicalDeviceShadingRateImageFeatures>();
                    physicalDeviceShadingRateImageFeaturesNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceMeshShaderFeaturesNv != null)
                {
                    var extensionPointer = default(Interop.NVidia.PhysicalDeviceMeshShaderFeatures*);
                    extensionPointer = (Interop.NVidia.PhysicalDeviceMeshShaderFeatures*)HeapUtil.Allocate<Interop.NVidia.PhysicalDeviceMeshShaderFeatures>();
                    physicalDeviceMeshShaderFeaturesNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (deviceMemoryOverallocationCreateInfoAmd != null)
                {
                    var extensionPointer = default(Interop.Amd.DeviceMemoryOverallocationCreateInfo*);
                    extensionPointer = (Interop.Amd.DeviceMemoryOverallocationCreateInfo*)HeapUtil.Allocate<Interop.Amd.DeviceMemoryOverallocationCreateInfo>();
                    deviceMemoryOverallocationCreateInfoAmd.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceFragmentDensityMapFeaturesExt != null)
                {
                    var extensionPointer = default(Interop.Multivendor.PhysicalDeviceFragmentDensityMapFeatures*);
                    extensionPointer = (Interop.Multivendor.PhysicalDeviceFragmentDensityMapFeatures*)HeapUtil.Allocate<Interop.Multivendor.PhysicalDeviceFragmentDensityMapFeatures>();
                    physicalDeviceFragmentDensityMapFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceScalarBlockLayoutFeatures != null)
                {
                    var extensionPointer = default(Interop.PhysicalDeviceScalarBlockLayoutFeatures*);
                    extensionPointer = (Interop.PhysicalDeviceScalarBlockLayoutFeatures*)HeapUtil.Allocate<Interop.PhysicalDeviceScalarBlockLayoutFeatures>();
                    physicalDeviceScalarBlockLayoutFeatures.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceUniformBufferStandardLayoutFeatures != null)
                {
                    var extensionPointer = default(Interop.PhysicalDeviceUniformBufferStandardLayoutFeatures*);
                    extensionPointer = (Interop.PhysicalDeviceUniformBufferStandardLayoutFeatures*)HeapUtil.Allocate<Interop.PhysicalDeviceUniformBufferStandardLayoutFeatures>();
                    physicalDeviceUniformBufferStandardLayoutFeatures.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceDepthClipEnableFeaturesExt != null)
                {
                    var extensionPointer = default(Interop.Multivendor.PhysicalDeviceDepthClipEnableFeatures*);
                    extensionPointer = (Interop.Multivendor.PhysicalDeviceDepthClipEnableFeatures*)HeapUtil.Allocate<Interop.Multivendor.PhysicalDeviceDepthClipEnableFeatures>();
                    physicalDeviceDepthClipEnableFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceMemoryPriorityFeaturesExt != null)
                {
                    var extensionPointer = default(Interop.Multivendor.PhysicalDeviceMemoryPriorityFeatures*);
                    extensionPointer = (Interop.Multivendor.PhysicalDeviceMemoryPriorityFeatures*)HeapUtil.Allocate<Interop.Multivendor.PhysicalDeviceMemoryPriorityFeatures>();
                    physicalDeviceMemoryPriorityFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceBufferDeviceAddressFeatures != null)
                {
                    var extensionPointer = default(Interop.PhysicalDeviceBufferDeviceAddressFeatures*);
                    extensionPointer = (Interop.PhysicalDeviceBufferDeviceAddressFeatures*)HeapUtil.Allocate<Interop.PhysicalDeviceBufferDeviceAddressFeatures>();
                    physicalDeviceBufferDeviceAddressFeatures.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceBufferDeviceAddressFeaturesExt != null)
                {
                    var extensionPointer = default(Interop.Multivendor.PhysicalDeviceBufferDeviceAddressFeatures*);
                    extensionPointer = (Interop.Multivendor.PhysicalDeviceBufferDeviceAddressFeatures*)HeapUtil.Allocate<Interop.Multivendor.PhysicalDeviceBufferDeviceAddressFeatures>();
                    physicalDeviceBufferDeviceAddressFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceImagelessFramebufferFeatures != null)
                {
                    var extensionPointer = default(Interop.PhysicalDeviceImagelessFramebufferFeatures*);
                    extensionPointer = (Interop.PhysicalDeviceImagelessFramebufferFeatures*)HeapUtil.Allocate<Interop.PhysicalDeviceImagelessFramebufferFeatures>();
                    physicalDeviceImagelessFramebufferFeatures.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceTextureCompressionASTCHDRFeaturesExt != null)
                {
                    var extensionPointer = default(Interop.Multivendor.PhysicalDeviceTextureCompressionASTCHDRFeatures*);
                    extensionPointer = (Interop.Multivendor.PhysicalDeviceTextureCompressionASTCHDRFeatures*)HeapUtil.Allocate<Interop.Multivendor.PhysicalDeviceTextureCompressionASTCHDRFeatures>();
                    physicalDeviceTextureCompressionASTCHDRFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceCooperativeMatrixFeaturesNv != null)
                {
                    var extensionPointer = default(Interop.NVidia.PhysicalDeviceCooperativeMatrixFeatures*);
                    extensionPointer = (Interop.NVidia.PhysicalDeviceCooperativeMatrixFeatures*)HeapUtil.Allocate<Interop.NVidia.PhysicalDeviceCooperativeMatrixFeatures>();
                    physicalDeviceCooperativeMatrixFeaturesNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceYcbcrImageArraysFeaturesExt != null)
                {
                    var extensionPointer = default(Interop.Multivendor.PhysicalDeviceYcbcrImageArraysFeatures*);
                    extensionPointer = (Interop.Multivendor.PhysicalDeviceYcbcrImageArraysFeatures*)HeapUtil.Allocate<Interop.Multivendor.PhysicalDeviceYcbcrImageArraysFeatures>();
                    physicalDeviceYcbcrImageArraysFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDevicePerformanceQueryFeaturesKhr != null)
                {
                    var extensionPointer = default(Interop.Khronos.PhysicalDevicePerformanceQueryFeatures*);
                    extensionPointer = (Interop.Khronos.PhysicalDevicePerformanceQueryFeatures*)HeapUtil.Allocate<Interop.Khronos.PhysicalDevicePerformanceQueryFeatures>();
                    physicalDevicePerformanceQueryFeaturesKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceCoverageReductionModeFeaturesNv != null)
                {
                    var extensionPointer = default(Interop.NVidia.PhysicalDeviceCoverageReductionModeFeatures*);
                    extensionPointer = (Interop.NVidia.PhysicalDeviceCoverageReductionModeFeatures*)HeapUtil.Allocate<Interop.NVidia.PhysicalDeviceCoverageReductionModeFeatures>();
                    physicalDeviceCoverageReductionModeFeaturesNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceShaderIntegerFunctions2FeaturesIntel != null)
                {
                    var extensionPointer = default(Interop.Intel.PhysicalDeviceShaderIntegerFunctions2Features*);
                    extensionPointer = (Interop.Intel.PhysicalDeviceShaderIntegerFunctions2Features*)HeapUtil.Allocate<Interop.Intel.PhysicalDeviceShaderIntegerFunctions2Features>();
                    physicalDeviceShaderIntegerFunctions2FeaturesIntel.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceShaderClockFeaturesKhr != null)
                {
                    var extensionPointer = default(Interop.Khronos.PhysicalDeviceShaderClockFeatures*);
                    extensionPointer = (Interop.Khronos.PhysicalDeviceShaderClockFeatures*)HeapUtil.Allocate<Interop.Khronos.PhysicalDeviceShaderClockFeatures>();
                    physicalDeviceShaderClockFeaturesKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceIndexTypeUint8FeaturesExt != null)
                {
                    var extensionPointer = default(Interop.Multivendor.PhysicalDeviceIndexTypeUint8Features*);
                    extensionPointer = (Interop.Multivendor.PhysicalDeviceIndexTypeUint8Features*)HeapUtil.Allocate<Interop.Multivendor.PhysicalDeviceIndexTypeUint8Features>();
                    physicalDeviceIndexTypeUint8FeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceShaderSMBuiltinsFeaturesNv != null)
                {
                    var extensionPointer = default(Interop.NVidia.PhysicalDeviceShaderSMBuiltinsFeatures*);
                    extensionPointer = (Interop.NVidia.PhysicalDeviceShaderSMBuiltinsFeatures*)HeapUtil.Allocate<Interop.NVidia.PhysicalDeviceShaderSMBuiltinsFeatures>();
                    physicalDeviceShaderSMBuiltinsFeaturesNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceFragmentShaderInterlockFeaturesExt != null)
                {
                    var extensionPointer = default(Interop.Multivendor.PhysicalDeviceFragmentShaderInterlockFeatures*);
                    extensionPointer = (Interop.Multivendor.PhysicalDeviceFragmentShaderInterlockFeatures*)HeapUtil.Allocate<Interop.Multivendor.PhysicalDeviceFragmentShaderInterlockFeatures>();
                    physicalDeviceFragmentShaderInterlockFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceSeparateDepthStencilLayoutsFeatures != null)
                {
                    var extensionPointer = default(Interop.PhysicalDeviceSeparateDepthStencilLayoutsFeatures*);
                    extensionPointer = (Interop.PhysicalDeviceSeparateDepthStencilLayoutsFeatures*)HeapUtil.Allocate<Interop.PhysicalDeviceSeparateDepthStencilLayoutsFeatures>();
                    physicalDeviceSeparateDepthStencilLayoutsFeatures.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDevicePipelineExecutablePropertiesFeaturesKhr != null)
                {
                    var extensionPointer = default(Interop.Khronos.PhysicalDevicePipelineExecutablePropertiesFeatures*);
                    extensionPointer = (Interop.Khronos.PhysicalDevicePipelineExecutablePropertiesFeatures*)HeapUtil.Allocate<Interop.Khronos.PhysicalDevicePipelineExecutablePropertiesFeatures>();
                    physicalDevicePipelineExecutablePropertiesFeaturesKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceShaderDemoteToHelperInvocationFeaturesExt != null)
                {
                    var extensionPointer = default(Interop.Multivendor.PhysicalDeviceShaderDemoteToHelperInvocationFeatures*);
                    extensionPointer = (Interop.Multivendor.PhysicalDeviceShaderDemoteToHelperInvocationFeatures*)HeapUtil.Allocate<Interop.Multivendor.PhysicalDeviceShaderDemoteToHelperInvocationFeatures>();
                    physicalDeviceShaderDemoteToHelperInvocationFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceTexelBufferAlignmentFeaturesExt != null)
                {
                    var extensionPointer = default(Interop.Multivendor.PhysicalDeviceTexelBufferAlignmentFeatures*);
                    extensionPointer = (Interop.Multivendor.PhysicalDeviceTexelBufferAlignmentFeatures*)HeapUtil.Allocate<Interop.Multivendor.PhysicalDeviceTexelBufferAlignmentFeatures>();
                    physicalDeviceTexelBufferAlignmentFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceSubgroupSizeControlFeaturesExt != null)
                {
                    var extensionPointer = default(Interop.Multivendor.PhysicalDeviceSubgroupSizeControlFeatures*);
                    extensionPointer = (Interop.Multivendor.PhysicalDeviceSubgroupSizeControlFeatures*)HeapUtil.Allocate<Interop.Multivendor.PhysicalDeviceSubgroupSizeControlFeatures>();
                    physicalDeviceSubgroupSizeControlFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceLineRasterizationFeaturesExt != null)
                {
                    var extensionPointer = default(Interop.Multivendor.PhysicalDeviceLineRasterizationFeatures*);
                    extensionPointer = (Interop.Multivendor.PhysicalDeviceLineRasterizationFeatures*)HeapUtil.Allocate<Interop.Multivendor.PhysicalDeviceLineRasterizationFeatures>();
                    physicalDeviceLineRasterizationFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceVulkan11Features != null)
                {
                    var extensionPointer = default(Interop.PhysicalDeviceVulkan11Features*);
                    extensionPointer = (Interop.PhysicalDeviceVulkan11Features*)HeapUtil.Allocate<Interop.PhysicalDeviceVulkan11Features>();
                    physicalDeviceVulkan11Features.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceVulkan12Features != null)
                {
                    var extensionPointer = default(Interop.PhysicalDeviceVulkan12Features*);
                    extensionPointer = (Interop.PhysicalDeviceVulkan12Features*)HeapUtil.Allocate<Interop.PhysicalDeviceVulkan12Features>();
                    physicalDeviceVulkan12Features.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceCoherentMemoryFeaturesAmd != null)
                {
                    var extensionPointer = default(Interop.Amd.PhysicalDeviceCoherentMemoryFeatures*);
                    extensionPointer = (Interop.Amd.PhysicalDeviceCoherentMemoryFeatures*)HeapUtil.Allocate<Interop.Amd.PhysicalDeviceCoherentMemoryFeatures>();
                    physicalDeviceCoherentMemoryFeaturesAmd.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                marshalledCreateInfo = (Interop.DeviceCreateInfo*)HeapUtil.Allocate<Interop.DeviceCreateInfo>();
                marshalledCreateInfo->SType = StructureType.DeviceCreateInfo;
                marshalledCreateInfo->Next = vkDeviceCreateInfoNextPointer;
                if (flags != null)
                    marshalledCreateInfo->Flags = flags.Value;
                else
                    marshalledCreateInfo->Flags = default;
                marshalledCreateInfo->QueueCreateInfoCount = HeapUtil.GetLength(queueCreateInfos);
                if (queueCreateInfos.IsNull())
                {
                    marshalledCreateInfo->QueueCreateInfos = null;
                }
                else
                {
                    if (queueCreateInfos.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfo->QueueCreateInfos = (Interop.DeviceQueueCreateInfo*)HeapUtil.Allocate<Interop.DeviceQueueCreateInfo>();
                        queueCreateInfos.Value.GetSingleValue().MarshalTo(&*marshalledCreateInfo->QueueCreateInfos);
                    }
                    else
                    {
                        var fieldPointer = (Interop.DeviceQueueCreateInfo*)HeapUtil.AllocateAndClear<Interop.DeviceQueueCreateInfo>(HeapUtil.GetLength(queueCreateInfos.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(queueCreateInfos.Value); index++) queueCreateInfos.Value[index].MarshalTo(&fieldPointer[index]);
                        marshalledCreateInfo->QueueCreateInfos = fieldPointer;
                    }
                }
                marshalledCreateInfo->EnabledLayerCount = HeapUtil.GetLength(enabledLayerNames);
                marshalledCreateInfo->EnabledLayerNames = HeapUtil.MarshalTo(enabledLayerNames);
                marshalledCreateInfo->EnabledExtensionCount = HeapUtil.GetLength(enabledExtensionNames);
                marshalledCreateInfo->EnabledExtensionNames = HeapUtil.MarshalTo(enabledExtensionNames);
                if (enabledFeatures != null)
                {
                    marshalledCreateInfo->EnabledFeatures = (Interop.PhysicalDeviceFeatures*)HeapUtil.Allocate<Interop.PhysicalDeviceFeatures>();
                    enabledFeatures.Value.MarshalTo(marshalledCreateInfo->EnabledFeatures);
                }
                else
                {
                    marshalledCreateInfo->EnabledFeatures = default;
                }
                if (allocator != null)
                {
                    marshalledAllocator = (Interop.AllocationCallbacks*)HeapUtil.Allocate<Interop.AllocationCallbacks>();
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default;
                }
                var commandDelegate = commandCache.Cache.vkCreateDevice;
                var methodResult = commandDelegate(handle, marshalledCreateInfo, marshalledAllocator, &marshalledDevice);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                result = new(this, marshalledDevice);
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Returns properties of available physical device extensions.
        /// </summary>
        /// <param name="layerName">
        /// </param>
        public unsafe ExtensionProperties[] EnumerateDeviceExtensionProperties(string layerName)
        {
            try
            {
                var result = default(ExtensionProperties[]);
                var marshalledPropertyCount = default(uint);
                var marshalledProperties = default(Interop.ExtensionProperties*);
                var commandDelegate = commandCache.Cache.vkEnumerateDeviceExtensionProperties;
                var methodResult = commandDelegate(handle, HeapUtil.MarshalTo(layerName), &marshalledPropertyCount, marshalledProperties);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                marshalledProperties = (Interop.ExtensionProperties*)HeapUtil.Allocate<Interop.ExtensionProperties>(marshalledPropertyCount);
                commandDelegate(handle, HeapUtil.MarshalTo(layerName), &marshalledPropertyCount, marshalledProperties);
                if (marshalledProperties != null)
                {
                    var fieldPointer = new ExtensionProperties[marshalledPropertyCount];
                    for (var index = 0; index < marshalledPropertyCount; index++) fieldPointer[index] = ExtensionProperties.MarshalFrom(&marshalledProperties[index]);
                    result = fieldPointer;
                }
                else
                {
                    result = null;
                }
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Returns properties of available physical device layers.
        /// </summary>
        public unsafe LayerProperties[] EnumerateDeviceLayerProperties()
        {
            try
            {
                var result = default(LayerProperties[]);
                var marshalledPropertyCount = default(uint);
                var marshalledProperties = default(Interop.LayerProperties*);
                var commandDelegate = commandCache.Cache.vkEnumerateDeviceLayerProperties;
                var methodResult = commandDelegate(handle, &marshalledPropertyCount, marshalledProperties);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                marshalledProperties = (Interop.LayerProperties*)HeapUtil.Allocate<Interop.LayerProperties>(marshalledPropertyCount);
                commandDelegate(handle, &marshalledPropertyCount, marshalledProperties);
                if (marshalledProperties != null)
                {
                    var fieldPointer = new LayerProperties[marshalledPropertyCount];
                    for (var index = 0; index < marshalledPropertyCount; index++) fieldPointer[index] = LayerProperties.MarshalFrom(&marshalledProperties[index]);
                    result = fieldPointer;
                }
                else
                {
                    result = null;
                }
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Retrieve properties of an image format applied to sparse images.
        /// </summary>
        /// <param name="format">
        /// </param>
        /// <param name="type">
        /// </param>
        /// <param name="samples">
        /// </param>
        /// <param name="usage">
        /// </param>
        /// <param name="tiling">
        /// </param>
        public unsafe SparseImageFormatProperties[] GetSparseImageFormatProperties(Format format, ImageType type, SampleCountFlags samples, ImageUsageFlags usage, ImageTiling tiling)
        {
            try
            {
                var result = default(SparseImageFormatProperties[]);
                var marshalledPropertyCount = default(uint);
                var marshalledProperties = default(SparseImageFormatProperties*);
                var commandDelegate = commandCache.Cache.vkGetPhysicalDeviceSparseImageFormatProperties;
                commandDelegate(handle, format, type, samples, usage, tiling, &marshalledPropertyCount, marshalledProperties);
                marshalledProperties = (SparseImageFormatProperties*)HeapUtil.Allocate<SparseImageFormatProperties>(marshalledPropertyCount);
                commandDelegate(handle, format, type, samples, usage, tiling, &marshalledPropertyCount, marshalledProperties);
                if (marshalledProperties != null)
                {
                    var fieldPointer = new SparseImageFormatProperties[marshalledPropertyCount];
                    for (var index = 0; index < marshalledPropertyCount; index++) fieldPointer[index] = marshalledProperties[index];
                    result = fieldPointer;
                }
                else
                {
                    result = null;
                }
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        /// </summary>
        public unsafe PhysicalDeviceFeatures2 GetFeatures2()
        {
            try
            {
                var result = default(PhysicalDeviceFeatures2);
                var marshalledFeatures = default(Interop.PhysicalDeviceFeatures2);
                var commandDelegate = commandCache.Cache.vkGetPhysicalDeviceFeatures2;
                commandDelegate(handle, &marshalledFeatures);
                result = PhysicalDeviceFeatures2.MarshalFrom(&marshalledFeatures);
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        /// </summary>
        public unsafe PhysicalDeviceProperties2 GetProperties2()
        {
            try
            {
                var result = default(PhysicalDeviceProperties2);
                var marshalledProperties = default(Interop.PhysicalDeviceProperties2);
                var commandDelegate = commandCache.Cache.vkGetPhysicalDeviceProperties2;
                commandDelegate(handle, &marshalledProperties);
                result = PhysicalDeviceProperties2.MarshalFrom(&marshalledProperties);
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="format">
        /// </param>
        public unsafe FormatProperties2 GetFormatProperties2(Format format)
        {
            try
            {
                var result = default(FormatProperties2);
                var marshalledFormatProperties = default(Interop.FormatProperties2);
                var commandDelegate = commandCache.Cache.vkGetPhysicalDeviceFormatProperties2;
                commandDelegate(handle, format, &marshalledFormatProperties);
                result = FormatProperties2.MarshalFrom(&marshalledFormatProperties);
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="imageFormatInfo">
        /// </param>
        public unsafe ImageFormatProperties2 GetImageFormatProperties2(PhysicalDeviceImageFormatInfo2 imageFormatInfo)
        {
            try
            {
                var result = default(ImageFormatProperties2);
                var marshalledImageFormatInfo = default(Interop.PhysicalDeviceImageFormatInfo2*);
                var marshalledImageFormatProperties = default(Interop.ImageFormatProperties2);
                marshalledImageFormatInfo = (Interop.PhysicalDeviceImageFormatInfo2*)HeapUtil.Allocate<Interop.PhysicalDeviceImageFormatInfo2>();
                imageFormatInfo.MarshalTo(marshalledImageFormatInfo);
                var commandDelegate = commandCache.Cache.vkGetPhysicalDeviceImageFormatProperties2;
                var methodResult = commandDelegate(handle, marshalledImageFormatInfo, &marshalledImageFormatProperties);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                result = ImageFormatProperties2.MarshalFrom(&marshalledImageFormatProperties);
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        /// </summary>
        public unsafe QueueFamilyProperties2[] GetQueueFamilyProperties2()
        {
            try
            {
                var result = default(QueueFamilyProperties2[]);
                var marshalledQueueFamilyPropertyCount = default(uint);
                var marshalledQueueFamilyProperties = default(Interop.QueueFamilyProperties2*);
                var commandDelegate = commandCache.Cache.vkGetPhysicalDeviceQueueFamilyProperties2;
                commandDelegate(handle, &marshalledQueueFamilyPropertyCount, marshalledQueueFamilyProperties);
                marshalledQueueFamilyProperties = (Interop.QueueFamilyProperties2*)HeapUtil.Allocate<Interop.QueueFamilyProperties2>(marshalledQueueFamilyPropertyCount);
                commandDelegate(handle, &marshalledQueueFamilyPropertyCount, marshalledQueueFamilyProperties);
                if (marshalledQueueFamilyProperties != null)
                {
                    var fieldPointer = new QueueFamilyProperties2[marshalledQueueFamilyPropertyCount];
                    for (var index = 0; index < marshalledQueueFamilyPropertyCount; index++) fieldPointer[index] = QueueFamilyProperties2.MarshalFrom(&marshalledQueueFamilyProperties[index]);
                    result = fieldPointer;
                }
                else
                {
                    result = null;
                }
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        /// </summary>
        public unsafe PhysicalDeviceMemoryProperties2 GetMemoryProperties2()
        {
            try
            {
                var result = default(PhysicalDeviceMemoryProperties2);
                var marshalledMemoryProperties = default(Interop.PhysicalDeviceMemoryProperties2);
                var commandDelegate = commandCache.Cache.vkGetPhysicalDeviceMemoryProperties2;
                commandDelegate(handle, &marshalledMemoryProperties);
                result = PhysicalDeviceMemoryProperties2.MarshalFrom(&marshalledMemoryProperties);
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="formatInfo">
        /// </param>
        public unsafe SparseImageFormatProperties2[] GetSparseImageFormatProperties2(PhysicalDeviceSparseImageFormatInfo2 formatInfo)
        {
            try
            {
                var result = default(SparseImageFormatProperties2[]);
                var marshalledPropertyCount = default(uint);
                var marshalledFormatInfo = default(Interop.PhysicalDeviceSparseImageFormatInfo2*);
                var marshalledProperties = default(Interop.SparseImageFormatProperties2*);
                marshalledFormatInfo = (Interop.PhysicalDeviceSparseImageFormatInfo2*)HeapUtil.Allocate<Interop.PhysicalDeviceSparseImageFormatInfo2>();
                formatInfo.MarshalTo(marshalledFormatInfo);
                var commandDelegate = commandCache.Cache.vkGetPhysicalDeviceSparseImageFormatProperties2;
                commandDelegate(handle, marshalledFormatInfo, &marshalledPropertyCount, marshalledProperties);
                marshalledProperties = (Interop.SparseImageFormatProperties2*)HeapUtil.Allocate<Interop.SparseImageFormatProperties2>(marshalledPropertyCount);
                commandDelegate(handle, marshalledFormatInfo, &marshalledPropertyCount, marshalledProperties);
                if (marshalledProperties != null)
                {
                    var fieldPointer = new SparseImageFormatProperties2[marshalledPropertyCount];
                    for (var index = 0; index < marshalledPropertyCount; index++) fieldPointer[index] = SparseImageFormatProperties2.MarshalFrom(&marshalledProperties[index]);
                    result = fieldPointer;
                }
                else
                {
                    result = null;
                }
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="externalBufferInfo">
        /// </param>
        public unsafe ExternalBufferProperties GetExternalBufferProperties(PhysicalDeviceExternalBufferInfo externalBufferInfo)
        {
            try
            {
                var result = default(ExternalBufferProperties);
                var marshalledExternalBufferInfo = default(Interop.PhysicalDeviceExternalBufferInfo*);
                var marshalledExternalBufferProperties = default(Interop.ExternalBufferProperties);
                marshalledExternalBufferInfo = (Interop.PhysicalDeviceExternalBufferInfo*)HeapUtil.Allocate<Interop.PhysicalDeviceExternalBufferInfo>();
                externalBufferInfo.MarshalTo(marshalledExternalBufferInfo);
                var commandDelegate = commandCache.Cache.vkGetPhysicalDeviceExternalBufferProperties;
                commandDelegate(handle, marshalledExternalBufferInfo, &marshalledExternalBufferProperties);
                result = ExternalBufferProperties.MarshalFrom(&marshalledExternalBufferProperties);
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="externalFenceInfo">
        /// </param>
        public unsafe ExternalFenceProperties GetExternalFenceProperties(PhysicalDeviceExternalFenceInfo externalFenceInfo)
        {
            try
            {
                var result = default(ExternalFenceProperties);
                var marshalledExternalFenceInfo = default(Interop.PhysicalDeviceExternalFenceInfo*);
                var marshalledExternalFenceProperties = default(Interop.ExternalFenceProperties);
                marshalledExternalFenceInfo = (Interop.PhysicalDeviceExternalFenceInfo*)HeapUtil.Allocate<Interop.PhysicalDeviceExternalFenceInfo>();
                externalFenceInfo.MarshalTo(marshalledExternalFenceInfo);
                var commandDelegate = commandCache.Cache.vkGetPhysicalDeviceExternalFenceProperties;
                commandDelegate(handle, marshalledExternalFenceInfo, &marshalledExternalFenceProperties);
                result = ExternalFenceProperties.MarshalFrom(&marshalledExternalFenceProperties);
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="externalSemaphoreInfo">
        /// </param>
        public unsafe ExternalSemaphoreProperties GetExternalSemaphoreProperties(PhysicalDeviceExternalSemaphoreInfo externalSemaphoreInfo)
        {
            try
            {
                var result = default(ExternalSemaphoreProperties);
                var marshalledExternalSemaphoreInfo = default(Interop.PhysicalDeviceExternalSemaphoreInfo*);
                var marshalledExternalSemaphoreProperties = default(Interop.ExternalSemaphoreProperties);
                marshalledExternalSemaphoreInfo = (Interop.PhysicalDeviceExternalSemaphoreInfo*)HeapUtil.Allocate<Interop.PhysicalDeviceExternalSemaphoreInfo>();
                externalSemaphoreInfo.MarshalTo(marshalledExternalSemaphoreInfo);
                var commandDelegate = commandCache.Cache.vkGetPhysicalDeviceExternalSemaphoreProperties;
                commandDelegate(handle, marshalledExternalSemaphoreInfo, &marshalledExternalSemaphoreProperties);
                result = ExternalSemaphoreProperties.MarshalFrom(&marshalledExternalSemaphoreProperties);
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }
    }
}