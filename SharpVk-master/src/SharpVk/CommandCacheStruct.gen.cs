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

using SharpVk.Interop;
using SharpVk.Interop.Amd;
using SharpVk.Interop.Android;
using SharpVk.Interop.Fuchsia;
using SharpVk.Interop.Ggp;
using SharpVk.Interop.Google;
using SharpVk.Interop.Intel;
using SharpVk.Interop.Khronos;
using SharpVk.Interop.MoltenVk;
using SharpVk.Interop.Multivendor;
using SharpVk.Interop.Nintendo;
using SharpVk.Interop.NVidia;
using SharpVk.Interop.NVidia.Experimental;
using VkPhysicalDeviceGetSurfaceCapabilities2Delegate = SharpVk.Interop.Multivendor.VkPhysicalDeviceGetSurfaceCapabilities2Delegate;

namespace SharpVk
{
    /// <summary>
    /// </summary>
    public partial struct CommandCacheStruct
    {
        /// <summary>
        /// </summary>
        public readonly VkInstanceCreateDelegate vkCreateInstance;

        /// <summary>
        /// </summary>
        public readonly VkInstanceDestroyDelegate vkDestroyInstance;

        /// <summary>
        /// </summary>
        public readonly VkInstanceEnumeratePhysicalDevicesDelegate vkEnumeratePhysicalDevices;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetFeaturesDelegate vkGetPhysicalDeviceFeatures;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetFormatPropertiesDelegate vkGetPhysicalDeviceFormatProperties;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetImageFormatPropertiesDelegate vkGetPhysicalDeviceImageFormatProperties;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetPropertiesDelegate vkGetPhysicalDeviceProperties;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetQueueFamilyPropertiesDelegate vkGetPhysicalDeviceQueueFamilyProperties;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetMemoryPropertiesDelegate vkGetPhysicalDeviceMemoryProperties;

        /// <summary>
        /// </summary>
        public readonly VkInstanceGetProcedureAddressDelegate vkGetInstanceProcAddr;

        /// <summary>
        /// </summary>
        public readonly VkDeviceGetProcedureAddressDelegate vkGetDeviceProcAddr;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceCreateDeviceDelegate vkCreateDevice;

        /// <summary>
        /// </summary>
        public readonly VkDeviceDestroyDelegate vkDestroyDevice;

        /// <summary>
        /// </summary>
        public readonly VkInstanceEnumerateExtensionPropertiesDelegate vkEnumerateInstanceExtensionProperties;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceEnumerateDeviceExtensionPropertiesDelegate vkEnumerateDeviceExtensionProperties;

        /// <summary>
        /// </summary>
        public readonly VkInstanceEnumerateLayerPropertiesDelegate vkEnumerateInstanceLayerProperties;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceEnumerateDeviceLayerPropertiesDelegate vkEnumerateDeviceLayerProperties;

        /// <summary>
        /// </summary>
        public readonly VkDeviceGetQueueDelegate vkGetDeviceQueue;

        /// <summary>
        /// </summary>
        public readonly VkQueueSubmitDelegate vkQueueSubmit;

        /// <summary>
        /// </summary>
        public readonly VkQueueWaitIdleDelegate vkQueueWaitIdle;

        /// <summary>
        /// </summary>
        public readonly VkDeviceWaitIdleDelegate vkDeviceWaitIdle;

        /// <summary>
        /// </summary>
        public readonly VkDeviceAllocateMemoryDelegate vkAllocateMemory;

        /// <summary>
        /// </summary>
        public readonly VkDeviceMemoryFreeDelegate vkFreeMemory;

        /// <summary>
        /// </summary>
        public readonly VkDeviceMemoryMapDelegate vkMapMemory;

        /// <summary>
        /// </summary>
        public readonly VkDeviceMemoryUnmapDelegate vkUnmapMemory;

        /// <summary>
        /// </summary>
        public readonly VkDeviceFlushMappedMemoryRangesDelegate vkFlushMappedMemoryRanges;

        /// <summary>
        /// </summary>
        public readonly VkDeviceInvalidateMappedMemoryRangesDelegate vkInvalidateMappedMemoryRanges;

        /// <summary>
        /// </summary>
        public readonly VkDeviceMemoryGetCommitmentDelegate vkGetDeviceMemoryCommitment;

        /// <summary>
        /// </summary>
        public readonly VkBufferBindMemoryDelegate vkBindBufferMemory;

        /// <summary>
        /// </summary>
        public readonly VkImageBindMemoryDelegate vkBindImageMemory;

        /// <summary>
        /// </summary>
        public readonly VkBufferGetMemoryRequirementsDelegate vkGetBufferMemoryRequirements;

        /// <summary>
        /// </summary>
        public readonly VkImageGetMemoryRequirementsDelegate vkGetImageMemoryRequirements;

        /// <summary>
        /// </summary>
        public readonly VkImageGetSparseMemoryRequirementsDelegate vkGetImageSparseMemoryRequirements;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetSparseImageFormatPropertiesDelegate vkGetPhysicalDeviceSparseImageFormatProperties;

        /// <summary>
        /// </summary>
        public readonly VkQueueBindSparseDelegate vkQueueBindSparse;

        /// <summary>
        /// </summary>
        public readonly VkDeviceCreateFenceDelegate vkCreateFence;

        /// <summary>
        /// </summary>
        public readonly VkFenceDestroyDelegate vkDestroyFence;

        /// <summary>
        /// </summary>
        public readonly VkDeviceResetFencesDelegate vkResetFences;

        /// <summary>
        /// </summary>
        public readonly VkFenceGetStatusDelegate vkGetFenceStatus;

        /// <summary>
        /// </summary>
        public readonly VkDeviceWaitForFencesDelegate vkWaitForFences;

        /// <summary>
        /// </summary>
        public readonly VkDeviceCreateSemaphoreDelegate vkCreateSemaphore;

        /// <summary>
        /// </summary>
        public readonly VkSemaphoreDestroyDelegate vkDestroySemaphore;

        /// <summary>
        /// </summary>
        public readonly VkDeviceCreateEventDelegate vkCreateEvent;

        /// <summary>
        /// </summary>
        public readonly VkEventDestroyDelegate vkDestroyEvent;

        /// <summary>
        /// </summary>
        public readonly VkEventGetStatusDelegate vkGetEventStatus;

        /// <summary>
        /// </summary>
        public readonly VkEventSetDelegate vkSetEvent;

        /// <summary>
        /// </summary>
        public readonly VkEventResetDelegate vkResetEvent;

        /// <summary>
        /// </summary>
        public readonly VkDeviceCreateQueryPoolDelegate vkCreateQueryPool;

        /// <summary>
        /// </summary>
        public readonly VkQueryPoolDestroyDelegate vkDestroyQueryPool;

        /// <summary>
        /// </summary>
        public readonly VkQueryPoolGetResultsDelegate vkGetQueryPoolResults;

        /// <summary>
        /// </summary>
        public readonly VkDeviceCreateBufferDelegate vkCreateBuffer;

        /// <summary>
        /// </summary>
        public readonly VkBufferDestroyDelegate vkDestroyBuffer;

        /// <summary>
        /// </summary>
        public readonly VkDeviceCreateBufferViewDelegate vkCreateBufferView;

        /// <summary>
        /// </summary>
        public readonly VkBufferViewDestroyDelegate vkDestroyBufferView;

        /// <summary>
        /// </summary>
        public readonly VkDeviceCreateImageDelegate vkCreateImage;

        /// <summary>
        /// </summary>
        public readonly VkImageDestroyDelegate vkDestroyImage;

        /// <summary>
        /// </summary>
        public readonly VkImageGetSubresourceLayoutDelegate vkGetImageSubresourceLayout;

        /// <summary>
        /// </summary>
        public readonly VkDeviceCreateImageViewDelegate vkCreateImageView;

        /// <summary>
        /// </summary>
        public readonly VkImageViewDestroyDelegate vkDestroyImageView;

        /// <summary>
        /// </summary>
        public readonly VkDeviceCreateShaderModuleDelegate vkCreateShaderModule;

        /// <summary>
        /// </summary>
        public readonly VkShaderModuleDestroyDelegate vkDestroyShaderModule;

        /// <summary>
        /// </summary>
        public readonly VkDeviceCreatePipelineCacheDelegate vkCreatePipelineCache;

        /// <summary>
        /// </summary>
        public readonly VkPipelineCacheDestroyDelegate vkDestroyPipelineCache;

        /// <summary>
        /// </summary>
        public readonly VkPipelineCacheGetDataDelegate vkGetPipelineCacheData;

        /// <summary>
        /// </summary>
        public readonly VkPipelineCacheMergePipelineCachesDelegate vkMergePipelineCaches;

        /// <summary>
        /// </summary>
        public readonly VkDeviceCreateGraphicsPipelinesDelegate vkCreateGraphicsPipelines;

        /// <summary>
        /// </summary>
        public readonly VkDeviceCreateComputePipelinesDelegate vkCreateComputePipelines;

        /// <summary>
        /// </summary>
        public readonly VkPipelineDestroyDelegate vkDestroyPipeline;

        /// <summary>
        /// </summary>
        public readonly VkDeviceCreatePipelineLayoutDelegate vkCreatePipelineLayout;

        /// <summary>
        /// </summary>
        public readonly VkPipelineLayoutDestroyDelegate vkDestroyPipelineLayout;

        /// <summary>
        /// </summary>
        public readonly VkDeviceCreateSamplerDelegate vkCreateSampler;

        /// <summary>
        /// </summary>
        public readonly VkSamplerDestroyDelegate vkDestroySampler;

        /// <summary>
        /// </summary>
        public readonly VkDeviceCreateDescriptorSetLayoutDelegate vkCreateDescriptorSetLayout;

        /// <summary>
        /// </summary>
        public readonly VkDescriptorSetLayoutDestroyDelegate vkDestroyDescriptorSetLayout;

        /// <summary>
        /// </summary>
        public readonly VkDeviceCreateDescriptorPoolDelegate vkCreateDescriptorPool;

        /// <summary>
        /// </summary>
        public readonly VkDescriptorPoolDestroyDelegate vkDestroyDescriptorPool;

        /// <summary>
        /// </summary>
        public readonly VkDescriptorPoolResetDelegate vkResetDescriptorPool;

        /// <summary>
        /// </summary>
        public readonly VkDeviceAllocateDescriptorSetsDelegate vkAllocateDescriptorSets;

        /// <summary>
        /// </summary>
        public readonly VkDescriptorPoolFreeDescriptorSetsDelegate vkFreeDescriptorSets;

        /// <summary>
        /// </summary>
        public readonly VkDeviceUpdateDescriptorSetsDelegate vkUpdateDescriptorSets;

        /// <summary>
        /// </summary>
        public readonly VkDeviceCreateFramebufferDelegate vkCreateFramebuffer;

        /// <summary>
        /// </summary>
        public readonly VkFramebufferDestroyDelegate vkDestroyFramebuffer;

        /// <summary>
        /// </summary>
        public readonly VkDeviceCreateRenderPassDelegate vkCreateRenderPass;

        /// <summary>
        /// </summary>
        public readonly VkRenderPassDestroyDelegate vkDestroyRenderPass;

        /// <summary>
        /// </summary>
        public readonly VkRenderPassGetRenderAreaGranularityDelegate vkGetRenderAreaGranularity;

        /// <summary>
        /// </summary>
        public readonly VkDeviceCreateCommandPoolDelegate vkCreateCommandPool;

        /// <summary>
        /// </summary>
        public readonly VkCommandPoolDestroyDelegate vkDestroyCommandPool;

        /// <summary>
        /// </summary>
        public readonly VkCommandPoolResetDelegate vkResetCommandPool;

        /// <summary>
        /// </summary>
        public readonly VkDeviceAllocateCommandBuffersDelegate vkAllocateCommandBuffers;

        /// <summary>
        /// </summary>
        public readonly VkCommandPoolFreeCommandBuffersDelegate vkFreeCommandBuffers;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferBeginDelegate vkBeginCommandBuffer;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferEndDelegate vkEndCommandBuffer;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferResetDelegate vkResetCommandBuffer;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferBindPipelineDelegate vkCmdBindPipeline;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferSetViewportDelegate vkCmdSetViewport;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferSetScissorDelegate vkCmdSetScissor;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferSetLineWidthDelegate vkCmdSetLineWidth;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferSetDepthBiasDelegate vkCmdSetDepthBias;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferSetBlendConstantsDelegate vkCmdSetBlendConstants;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferSetDepthBoundsDelegate vkCmdSetDepthBounds;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferSetStencilCompareMaskDelegate vkCmdSetStencilCompareMask;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferSetStencilWriteMaskDelegate vkCmdSetStencilWriteMask;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferSetStencilReferenceDelegate vkCmdSetStencilReference;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferBindDescriptorSetsDelegate vkCmdBindDescriptorSets;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferBindIndexBufferDelegate vkCmdBindIndexBuffer;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferBindVertexBuffersDelegate vkCmdBindVertexBuffers;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferDrawDelegate vkCmdDraw;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferDrawIndexedDelegate vkCmdDrawIndexed;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferDrawIndirectDelegate vkCmdDrawIndirect;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferDrawIndexedIndirectDelegate vkCmdDrawIndexedIndirect;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferDispatchDelegate vkCmdDispatch;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferDispatchIndirectDelegate vkCmdDispatchIndirect;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferCopyBufferDelegate vkCmdCopyBuffer;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferCopyImageDelegate vkCmdCopyImage;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferBlitImageDelegate vkCmdBlitImage;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferCopyBufferToImageDelegate vkCmdCopyBufferToImage;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferCopyImageToBufferDelegate vkCmdCopyImageToBuffer;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferUpdateBufferDelegate vkCmdUpdateBuffer;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferFillBufferDelegate vkCmdFillBuffer;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferClearColorImageDelegate vkCmdClearColorImage;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferClearDepthStencilImageDelegate vkCmdClearDepthStencilImage;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferClearAttachmentsDelegate vkCmdClearAttachments;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferResolveImageDelegate vkCmdResolveImage;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferSetEventDelegate vkCmdSetEvent;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferResetEventDelegate vkCmdResetEvent;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferWaitEventsDelegate vkCmdWaitEvents;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferPipelineBarrierDelegate vkCmdPipelineBarrier;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferBeginQueryDelegate vkCmdBeginQuery;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferEndQueryDelegate vkCmdEndQuery;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferResetQueryPoolDelegate vkCmdResetQueryPool;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferWriteTimestampDelegate vkCmdWriteTimestamp;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferCopyQueryPoolResultsDelegate vkCmdCopyQueryPoolResults;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferPushConstantsDelegate vkCmdPushConstants;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferBeginRenderPassDelegate vkCmdBeginRenderPass;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferNextSubpassDelegate vkCmdNextSubpass;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferEndRenderPassDelegate vkCmdEndRenderPass;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferExecuteCommandsDelegate vkCmdExecuteCommands;

        /// <summary>
        /// </summary>
        public readonly VkInstanceEnumerateVersionDelegate vkEnumerateInstanceVersion;

        /// <summary>
        /// </summary>
        public readonly VkDeviceBindBufferMemory2Delegate vkBindBufferMemory2;

        /// <summary>
        /// </summary>
        public readonly VkDeviceBindImageMemory2Delegate vkBindImageMemory2;

        /// <summary>
        /// </summary>
        public readonly VkDeviceGetGroupPeerMemoryFeaturesDelegate vkGetDeviceGroupPeerMemoryFeatures;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferSetDeviceMaskDelegate vkCmdSetDeviceMask;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferDispatchBaseDelegate vkCmdDispatchBase;

        /// <summary>
        /// </summary>
        public readonly VkInstanceEnumeratePhysicalDeviceGroupsDelegate vkEnumeratePhysicalDeviceGroups;

        /// <summary>
        /// </summary>
        public readonly VkDeviceGetImageMemoryRequirements2Delegate vkGetImageMemoryRequirements2;

        /// <summary>
        /// </summary>
        public readonly VkDeviceGetBufferMemoryRequirements2Delegate vkGetBufferMemoryRequirements2;

        /// <summary>
        /// </summary>
        public readonly VkDeviceGetImageSparseMemoryRequirements2Delegate vkGetImageSparseMemoryRequirements2;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetFeatures2Delegate vkGetPhysicalDeviceFeatures2;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetProperties2Delegate vkGetPhysicalDeviceProperties2;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetFormatProperties2Delegate vkGetPhysicalDeviceFormatProperties2;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetImageFormatProperties2Delegate vkGetPhysicalDeviceImageFormatProperties2;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetQueueFamilyProperties2Delegate vkGetPhysicalDeviceQueueFamilyProperties2;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetMemoryProperties2Delegate vkGetPhysicalDeviceMemoryProperties2;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetSparseImageFormatProperties2Delegate vkGetPhysicalDeviceSparseImageFormatProperties2;

        /// <summary>
        /// </summary>
        public readonly VkCommandPoolTrimDelegate vkTrimCommandPool;

        /// <summary>
        /// </summary>
        public readonly VkDeviceGetQueue2Delegate vkGetDeviceQueue2;

        /// <summary>
        /// </summary>
        public readonly VkDeviceCreateSamplerYcbcrConversionDelegate vkCreateSamplerYcbcrConversion;

        /// <summary>
        /// </summary>
        public readonly VkSamplerYcbcrConversionDestroyDelegate vkDestroySamplerYcbcrConversion;

        /// <summary>
        /// </summary>
        public readonly VkDeviceCreateDescriptorUpdateTemplateDelegate vkCreateDescriptorUpdateTemplate;

        /// <summary>
        /// </summary>
        public readonly VkDescriptorUpdateTemplateDestroyDelegate vkDestroyDescriptorUpdateTemplate;

        /// <summary>
        /// </summary>
        public readonly VkDeviceUpdateDescriptorSetWithTemplateDelegate vkUpdateDescriptorSetWithTemplate;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetExternalBufferPropertiesDelegate vkGetPhysicalDeviceExternalBufferProperties;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetExternalFencePropertiesDelegate vkGetPhysicalDeviceExternalFenceProperties;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetExternalSemaphorePropertiesDelegate vkGetPhysicalDeviceExternalSemaphoreProperties;

        /// <summary>
        /// </summary>
        public readonly VkDeviceGetDescriptorSetLayoutSupportDelegate vkGetDescriptorSetLayoutSupport;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferDrawIndirectCountDelegate vkCmdDrawIndirectCount;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferDrawIndexedIndirectCountDelegate vkCmdDrawIndexedIndirectCount;

        /// <summary>
        /// </summary>
        public readonly VkDeviceCreateRenderPass2Delegate vkCreateRenderPass2;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferBeginRenderPass2Delegate vkCmdBeginRenderPass2;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferNextSubpass2Delegate vkCmdNextSubpass2;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferEndRenderPass2Delegate vkCmdEndRenderPass2;

        /// <summary>
        /// </summary>
        public readonly VkQueryPoolResetDelegate vkResetQueryPool;

        /// <summary>
        /// </summary>
        public readonly VkSemaphoreGetCounterValueDelegate vkGetSemaphoreCounterValue;

        /// <summary>
        /// </summary>
        public readonly VkDeviceWaitSemaphoresDelegate vkWaitSemaphores;

        /// <summary>
        /// </summary>
        public readonly VkDeviceSignalSemaphoreDelegate vkSignalSemaphore;

        /// <summary>
        /// </summary>
        public readonly VkDeviceGetBufferDeviceAddressDelegate vkGetBufferDeviceAddress;

        /// <summary>
        /// </summary>
        public readonly VkDeviceGetBufferOpaqueCaptureAddressDelegate vkGetBufferOpaqueCaptureAddress;

        /// <summary>
        /// </summary>
        public readonly VkDeviceGetMemoryOpaqueCaptureAddressDelegate vkGetDeviceMemoryOpaqueCaptureAddress;

        /// <summary>
        /// </summary>
        public readonly VkSurfaceKHRDestroyDelegate vkDestroySurfaceKHR;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetSurfaceSupportDelegate vkGetPhysicalDeviceSurfaceSupportKHR;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetSurfaceCapabilitiesDelegate vkGetPhysicalDeviceSurfaceCapabilitiesKHR;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetSurfaceFormatsDelegate vkGetPhysicalDeviceSurfaceFormatsKHR;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetSurfacePresentModesDelegate vkGetPhysicalDeviceSurfacePresentModesKHR;

        /// <summary>
        /// </summary>
        public readonly VkDeviceCreateSwapchainDelegate vkCreateSwapchainKHR;

        /// <summary>
        /// </summary>
        public readonly VkSwapchainKHRDestroyDelegate vkDestroySwapchainKHR;

        /// <summary>
        /// </summary>
        public readonly VkSwapchainKHRGetImagesDelegate vkGetSwapchainImagesKHR;

        /// <summary>
        /// </summary>
        public readonly VkSwapchainKHRAcquireNextImageDelegate vkAcquireNextImageKHR;

        /// <summary>
        /// </summary>
        public readonly VkQueuePresentDelegate vkQueuePresentKHR;

        /// <summary>
        /// </summary>
        public readonly VkDeviceGetGroupPresentCapabilitiesDelegate vkGetDeviceGroupPresentCapabilitiesKHR;

        /// <summary>
        /// </summary>
        public readonly VkDeviceGetGroupSurfacePresentModesDelegate vkGetDeviceGroupSurfacePresentModesKHR;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetPresentRectanglesDelegate vkGetPhysicalDevicePresentRectanglesKHR;

        /// <summary>
        /// </summary>
        public readonly VkDeviceAcquireNextImage2Delegate vkAcquireNextImage2KHR;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetDisplayPropertiesDelegate vkGetPhysicalDeviceDisplayPropertiesKHR;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetDisplayPlanePropertiesDelegate vkGetPhysicalDeviceDisplayPlanePropertiesKHR;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetDisplayPlaneSupportedDisplaysDelegate vkGetDisplayPlaneSupportedDisplaysKHR;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetDisplayModePropertiesDelegate vkGetDisplayModePropertiesKHR;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceCreateDisplayModeDelegate vkCreateDisplayModeKHR;

        /// <summary>
        /// </summary>
        public readonly VkDisplayModeKHRGetDisplayPlaneCapabilitiesDelegate vkGetDisplayPlaneCapabilitiesKHR;

        /// <summary>
        /// </summary>
        public readonly VkInstanceCreateDisplayPlaneSurfaceDelegate vkCreateDisplayPlaneSurfaceKHR;

        /// <summary>
        /// </summary>
        public readonly VkDeviceCreateSharedSwapchainsDelegate vkCreateSharedSwapchainsKHR;

        /// <summary>
        /// </summary>
        public readonly VkInstanceCreateXlibSurfaceDelegate vkCreateXlibSurfaceKHR;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetXlibPresentationSupportDelegate vkGetPhysicalDeviceXlibPresentationSupportKHR;

        /// <summary>
        /// </summary>
        public readonly VkInstanceCreateXcbSurfaceDelegate vkCreateXcbSurfaceKHR;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetXcbPresentationSupportDelegate vkGetPhysicalDeviceXcbPresentationSupportKHR;

        /// <summary>
        /// </summary>
        public readonly VkInstanceCreateWaylandSurfaceDelegate vkCreateWaylandSurfaceKHR;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetWaylandPresentationSupportDelegate vkGetPhysicalDeviceWaylandPresentationSupportKHR;

        /// <summary>
        /// </summary>
        public readonly VkInstanceCreateAndroidSurfaceDelegate vkCreateAndroidSurfaceKHR;

        /// <summary>
        /// </summary>
        public readonly VkInstanceCreateWin32SurfaceDelegate vkCreateWin32SurfaceKHR;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetWin32PresentationSupportDelegate vkGetPhysicalDeviceWin32PresentationSupportKHR;

        /// <summary>
        /// </summary>
        public readonly VkInstanceCreateDebugReportCallbackDelegate vkCreateDebugReportCallbackEXT;

        /// <summary>
        /// </summary>
        public readonly VkDebugReportCallbackEXTDestroyDelegate vkDestroyDebugReportCallbackEXT;

        /// <summary>
        /// </summary>
        public readonly VkInstanceDebugReportMessageDelegate vkDebugReportMessageEXT;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferBindTransformFeedbackBuffersDelegate vkCmdBindTransformFeedbackBuffersEXT;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferBeginTransformFeedbackDelegate vkCmdBeginTransformFeedbackEXT;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferEndTransformFeedbackDelegate vkCmdEndTransformFeedbackEXT;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferBeginQueryIndexedDelegate vkCmdBeginQueryIndexedEXT;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferEndQueryIndexedDelegate vkCmdEndQueryIndexedEXT;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferDrawIndirectByteCountDelegate vkCmdDrawIndirectByteCountEXT;

        /// <summary>
        /// </summary>
        public readonly VkDeviceGetImageViewHandleDelegate vkGetImageViewHandleNVX;

        /// <summary>
        /// </summary>
        public readonly VkPipelineGetShaderInfoDelegate vkGetShaderInfoAMD;

        /// <summary>
        /// </summary>
        public readonly VkInstanceCreateStreamDescriptorSurfaceDelegate vkCreateStreamDescriptorSurfaceGGP;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetExternalImageFormatPropertiesDelegate vkGetPhysicalDeviceExternalImageFormatPropertiesNV;

        /// <summary>
        /// </summary>
        public readonly VkDeviceMemoryGetWin32HandleDelegate vkGetMemoryWin32HandleNV;

        /// <summary>
        /// </summary>
        public readonly VkInstanceCreateViSurfaceDelegate vkCreateViSurfaceNN;

        /// <summary>
        /// </summary>
        public readonly VkDeviceGetMemoryWin32HandleDelegate vkGetMemoryWin32HandleKHR;

        /// <summary>
        /// </summary>
        public readonly VkDeviceGetMemoryWin32HandlePropertiesDelegate vkGetMemoryWin32HandlePropertiesKHR;

        /// <summary>
        /// </summary>
        public readonly VkDeviceGetMemoryFileDescriptorDelegate vkGetMemoryFdKHR;

        /// <summary>
        /// </summary>
        public readonly VkDeviceGetMemoryFileDescriptorPropertiesDelegate vkGetMemoryFdPropertiesKHR;

        /// <summary>
        /// </summary>
        public readonly VkDeviceImportSemaphoreWin32HandleDelegate vkImportSemaphoreWin32HandleKHR;

        /// <summary>
        /// </summary>
        public readonly VkDeviceGetSemaphoreWin32HandleDelegate vkGetSemaphoreWin32HandleKHR;

        /// <summary>
        /// </summary>
        public readonly VkDeviceImportSemaphoreFileDescriptorDelegate vkImportSemaphoreFdKHR;

        /// <summary>
        /// </summary>
        public readonly VkDeviceGetSemaphoreFileDescriptorDelegate vkGetSemaphoreFdKHR;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferPushDescriptorSetDelegate vkCmdPushDescriptorSetKHR;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferPushDescriptorSetWithTemplateDelegate vkCmdPushDescriptorSetWithTemplateKHR;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferBeginConditionalRenderingDelegate vkCmdBeginConditionalRenderingEXT;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferEndConditionalRenderingDelegate vkCmdEndConditionalRenderingEXT;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferProcessCommandsDelegate vkCmdProcessCommandsNVX;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferReserveSpaceForCommandsDelegate vkCmdReserveSpaceForCommandsNVX;

        /// <summary>
        /// </summary>
        public readonly VkDeviceCreateIndirectCommandsLayoutDelegate vkCreateIndirectCommandsLayoutNVX;

        /// <summary>
        /// </summary>
        public readonly VkIndirectCommandsLayoutNVXDestroyDelegate vkDestroyIndirectCommandsLayoutNVX;

        /// <summary>
        /// </summary>
        public readonly VkDeviceCreateObjectTableDelegate vkCreateObjectTableNVX;

        /// <summary>
        /// </summary>
        public readonly VkObjectTableNVXDestroyDelegate vkDestroyObjectTableNVX;

        /// <summary>
        /// </summary>
        public readonly VkObjectTableNVXRegisterObjectsDelegate vkRegisterObjectsNVX;

        /// <summary>
        /// </summary>
        public readonly VkObjectTableNVXUnregisterObjectsDelegate vkUnregisterObjectsNVX;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetGeneratedCommandsPropertiesDelegate vkGetPhysicalDeviceGeneratedCommandsPropertiesNVX;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferSetViewportWScalingDelegate vkCmdSetViewportWScalingNV;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceReleaseDisplayDelegate vkReleaseDisplayEXT;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceAcquireXlibDisplayDelegate vkAcquireXlibDisplayEXT;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetRandROutputDisplayDelegate vkGetRandROutputDisplayEXT;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetSurfaceCapabilities2Delegate vkGetPhysicalDeviceSurfaceCapabilities2EXT;

        /// <summary>
        /// </summary>
        public readonly VkDeviceDisplayPowerControlDelegate vkDisplayPowerControlEXT;

        /// <summary>
        /// </summary>
        public readonly VkDeviceRegisterEventDelegate vkRegisterDeviceEventEXT;

        /// <summary>
        /// </summary>
        public readonly VkDeviceRegisterDisplayEventDelegate vkRegisterDisplayEventEXT;

        /// <summary>
        /// </summary>
        public readonly VkSwapchainKHRGetCounterDelegate vkGetSwapchainCounterEXT;

        /// <summary>
        /// </summary>
        public readonly VkSwapchainKHRGetRefreshCycleDurationDelegate vkGetRefreshCycleDurationGOOGLE;

        /// <summary>
        /// </summary>
        public readonly VkSwapchainKHRGetPastPresentationTimingDelegate vkGetPastPresentationTimingGOOGLE;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferSetDiscardRectangleDelegate vkCmdSetDiscardRectangleEXT;

        /// <summary>
        /// </summary>
        public readonly VkDeviceSetHdrMetadataDelegate vkSetHdrMetadataEXT;

        /// <summary>
        /// </summary>
        public readonly VkSwapchainKHRGetStatusDelegate vkGetSwapchainStatusKHR;

        /// <summary>
        /// </summary>
        public readonly VkDeviceImportFenceWin32HandleDelegate vkImportFenceWin32HandleKHR;

        /// <summary>
        /// </summary>
        public readonly VkDeviceGetFenceWin32HandleDelegate vkGetFenceWin32HandleKHR;

        /// <summary>
        /// </summary>
        public readonly VkDeviceImportFenceFileDescriptorDelegate vkImportFenceFdKHR;

        /// <summary>
        /// </summary>
        public readonly VkDeviceGetFenceFileDescriptorDelegate vkGetFenceFdKHR;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceEnumerateQueueFamilyPerformanceQueryCountersDelegate vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetQueueFamilyPerformanceQueryPassesDelegate vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR;

        /// <summary>
        /// </summary>
        public readonly VkDeviceAcquireProfilingLockDelegate vkAcquireProfilingLockKHR;

        /// <summary>
        /// </summary>
        public readonly VkDeviceReleaseProfilingLockDelegate vkReleaseProfilingLockKHR;

        /// <summary>
        /// </summary>
        public readonly Interop.Khronos.VkPhysicalDeviceGetSurfaceCapabilities2Delegate vkGetPhysicalDeviceSurfaceCapabilities2KHR;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetSurfaceFormats2Delegate vkGetPhysicalDeviceSurfaceFormats2KHR;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetDisplayProperties2Delegate vkGetPhysicalDeviceDisplayProperties2KHR;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetDisplayPlaneProperties2Delegate vkGetPhysicalDeviceDisplayPlaneProperties2KHR;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetDisplayModeProperties2Delegate vkGetDisplayModeProperties2KHR;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetDisplayPlaneCapabilities2Delegate vkGetDisplayPlaneCapabilities2KHR;

        /// <summary>
        /// </summary>
        public readonly VkInstanceCreateIOSSurfaceDelegate vkCreateIOSSurfaceMVK;

        /// <summary>
        /// </summary>
        public readonly VkInstanceCreateMacOSSurfaceDelegate vkCreateMacOSSurfaceMVK;

        /// <summary>
        /// </summary>
        public readonly VkDeviceSetDebugUtilsObjectNameDelegate vkSetDebugUtilsObjectNameEXT;

        /// <summary>
        /// </summary>
        public readonly VkDeviceSetDebugUtilsObjectTagDelegate vkSetDebugUtilsObjectTagEXT;

        /// <summary>
        /// </summary>
        public readonly VkQueueBeginDebugUtilsLabelDelegate vkQueueBeginDebugUtilsLabelEXT;

        /// <summary>
        /// </summary>
        public readonly VkQueueEndDebugUtilsLabelDelegate vkQueueEndDebugUtilsLabelEXT;

        /// <summary>
        /// </summary>
        public readonly VkQueueInsertDebugUtilsLabelDelegate vkQueueInsertDebugUtilsLabelEXT;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferBeginDebugUtilsLabelDelegate vkCmdBeginDebugUtilsLabelEXT;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferEndDebugUtilsLabelDelegate vkCmdEndDebugUtilsLabelEXT;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferInsertDebugUtilsLabelDelegate vkCmdInsertDebugUtilsLabelEXT;

        /// <summary>
        /// </summary>
        public readonly VkInstanceCreateDebugUtilsMessengerDelegate vkCreateDebugUtilsMessengerEXT;

        /// <summary>
        /// </summary>
        public readonly VkDebugUtilsMessengerEXTDestroyDelegate vkDestroyDebugUtilsMessengerEXT;

        /// <summary>
        /// </summary>
        public readonly VkInstanceSubmitDebugUtilsMessageDelegate vkSubmitDebugUtilsMessageEXT;

        /// <summary>
        /// </summary>
        public readonly VkDeviceGetAndroidHardwareBufferPropertiesDelegate vkGetAndroidHardwareBufferPropertiesANDROID;

        /// <summary>
        /// </summary>
        public readonly VkDeviceGetMemoryAndroidHardwareBufferDelegate vkGetMemoryAndroidHardwareBufferANDROID;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferSetSampleLocationsDelegate vkCmdSetSampleLocationsEXT;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetMultisamplePropertiesDelegate vkGetPhysicalDeviceMultisamplePropertiesEXT;

        /// <summary>
        /// </summary>
        public readonly VkImageGetDrmFormatModifierPropertiesDelegate vkGetImageDrmFormatModifierPropertiesEXT;

        /// <summary>
        /// </summary>
        public readonly VkDeviceCreateValidationCacheDelegate vkCreateValidationCacheEXT;

        /// <summary>
        /// </summary>
        public readonly VkValidationCacheEXTDestroyDelegate vkDestroyValidationCacheEXT;

        /// <summary>
        /// </summary>
        public readonly VkValidationCacheEXTMergeValidationCachesDelegate vkMergeValidationCachesEXT;

        /// <summary>
        /// </summary>
        public readonly VkValidationCacheEXTGetDataDelegate vkGetValidationCacheDataEXT;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferBindShadingRateImageDelegate vkCmdBindShadingRateImageNV;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferSetViewportShadingRatePaletteDelegate vkCmdSetViewportShadingRatePaletteNV;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferSetCoarseSampleOrderDelegate vkCmdSetCoarseSampleOrderNV;

        /// <summary>
        /// </summary>
        public readonly VkDeviceCreateAccelerationStructureDelegate vkCreateAccelerationStructureNV;

        /// <summary>
        /// </summary>
        public readonly VkAccelerationStructureNVDestroyDelegate vkDestroyAccelerationStructureNV;

        /// <summary>
        /// </summary>
        public readonly VkDeviceGetAccelerationStructureMemoryRequirementsDelegate vkGetAccelerationStructureMemoryRequirementsNV;

        /// <summary>
        /// </summary>
        public readonly VkDeviceBindAccelerationStructureMemoryDelegate vkBindAccelerationStructureMemoryNV;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferBuildAccelerationStructureDelegate vkCmdBuildAccelerationStructureNV;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferCopyAccelerationStructureDelegate vkCmdCopyAccelerationStructureNV;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferTraceRaysDelegate vkCmdTraceRaysNV;

        /// <summary>
        /// </summary>
        public readonly VkDeviceCreateRayTracingPipelinesDelegate vkCreateRayTracingPipelinesNV;

        /// <summary>
        /// </summary>
        public readonly VkPipelineGetRayTracingShaderGroupHandlesDelegate vkGetRayTracingShaderGroupHandlesNV;

        /// <summary>
        /// </summary>
        public readonly VkAccelerationStructureNVGetHandleDelegate vkGetAccelerationStructureHandleNV;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferWriteAccelerationStructuresPropertiesDelegate vkCmdWriteAccelerationStructuresPropertiesNV;

        /// <summary>
        /// </summary>
        public readonly VkPipelineCompileDeferredDelegate vkCompileDeferredNV;

        /// <summary>
        /// </summary>
        public readonly VkDeviceGetMemoryHostPointerPropertiesDelegate vkGetMemoryHostPointerPropertiesEXT;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferWriteBufferMarkerDelegate vkCmdWriteBufferMarkerAMD;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetCalibrateableTimeDomainsDelegate vkGetPhysicalDeviceCalibrateableTimeDomainsEXT;

        /// <summary>
        /// </summary>
        public readonly VkDeviceGetCalibratedTimestampsDelegate vkGetCalibratedTimestampsEXT;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferDrawMeshTasksDelegate vkCmdDrawMeshTasksNV;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferDrawMeshTasksIndirectDelegate vkCmdDrawMeshTasksIndirectNV;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferDrawMeshTasksIndirectCountDelegate vkCmdDrawMeshTasksIndirectCountNV;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferSetExclusiveScissorDelegate vkCmdSetExclusiveScissorNV;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferSetCheckpointDelegate vkCmdSetCheckpointNV;

        /// <summary>
        /// </summary>
        public readonly VkQueueGetCheckpointDataDelegate vkGetQueueCheckpointDataNV;

        /// <summary>
        /// </summary>
        public readonly VkDeviceInitializePerformanceApiDelegate vkInitializePerformanceApiINTEL;

        /// <summary>
        /// </summary>
        public readonly VkDeviceUninitializePerformanceApiDelegate vkUninitializePerformanceApiINTEL;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferSetPerformanceMarkerDelegate vkCmdSetPerformanceMarkerINTEL;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferSetPerformanceStreamMarkerDelegate vkCmdSetPerformanceStreamMarkerINTEL;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferSetPerformanceOverrideDelegate vkCmdSetPerformanceOverrideINTEL;

        /// <summary>
        /// </summary>
        public readonly VkDeviceAcquirePerformanceConfigurationDelegate vkAcquirePerformanceConfigurationINTEL;

        /// <summary>
        /// </summary>
        public readonly VkPerformanceConfigurationINTELReleaseDelegate vkReleasePerformanceConfigurationINTEL;

        /// <summary>
        /// </summary>
        public readonly VkQueueSetPerformanceConfigurationDelegate vkQueueSetPerformanceConfigurationINTEL;

        /// <summary>
        /// </summary>
        public readonly VkDeviceGetPerformanceParameterDelegate vkGetPerformanceParameterINTEL;

        /// <summary>
        /// </summary>
        public readonly VkSwapchainKHRSetLocalDimmingDelegate vkSetLocalDimmingAMD;

        /// <summary>
        /// </summary>
        public readonly VkInstanceCreateImagePipeSurfaceDelegate vkCreateImagePipeSurfaceFUCHSIA;

        /// <summary>
        /// </summary>
        public readonly VkInstanceCreateMetalSurfaceDelegate vkCreateMetalSurfaceEXT;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetToolPropertiesDelegate vkGetPhysicalDeviceToolPropertiesEXT;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetCooperativeMatrixPropertiesDelegate vkGetPhysicalDeviceCooperativeMatrixPropertiesNV;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetSupportedFramebufferMixedSamplesCombinationsDelegate vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetSurfacePresentModes2Delegate vkGetPhysicalDeviceSurfacePresentModes2EXT;

        /// <summary>
        /// </summary>
        public readonly VkSwapchainKHRAcquireFullScreenExclusiveModeDelegate vkAcquireFullScreenExclusiveModeEXT;

        /// <summary>
        /// </summary>
        public readonly VkSwapchainKHRReleaseFullScreenExclusiveModeDelegate vkReleaseFullScreenExclusiveModeEXT;

        /// <summary>
        /// </summary>
        public readonly VkDeviceGetGroupSurfacePresentModes2Delegate vkGetDeviceGroupSurfacePresentModes2EXT;

        /// <summary>
        /// </summary>
        public readonly VkInstanceCreateHeadlessSurfaceDelegate vkCreateHeadlessSurfaceEXT;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferSetLineStippleDelegate vkCmdSetLineStippleEXT;

        /// <summary>
        /// </summary>
        public readonly VkDeviceGetPipelineExecutablePropertiesDelegate vkGetPipelineExecutablePropertiesKHR;

        /// <summary>
        /// </summary>
        public readonly VkDeviceGetPipelineExecutableStatisticsDelegate vkGetPipelineExecutableStatisticsKHR;

        /// <summary>
        /// </summary>
        public readonly VkDeviceGetPipelineExecutableInternalRepresentationsDelegate vkGetPipelineExecutableInternalRepresentationsKHR;

        /// <summary>
        /// </summary>
        public CommandCacheStruct(CommandCache cache)
        {
            vkCreateInstance = cache.GetCommandDelegate<VkInstanceCreateDelegate>("vkCreateInstance", "");
            vkDestroyInstance = cache.GetCommandDelegate<VkInstanceDestroyDelegate>("vkDestroyInstance", "");
            vkEnumeratePhysicalDevices = cache.GetCommandDelegate<VkInstanceEnumeratePhysicalDevicesDelegate>("vkEnumeratePhysicalDevices", "");
            vkGetPhysicalDeviceFeatures = cache.GetCommandDelegate<VkPhysicalDeviceGetFeaturesDelegate>("vkGetPhysicalDeviceFeatures", "");
            vkGetPhysicalDeviceFormatProperties = cache.GetCommandDelegate<VkPhysicalDeviceGetFormatPropertiesDelegate>("vkGetPhysicalDeviceFormatProperties", "");
            vkGetPhysicalDeviceImageFormatProperties = cache.GetCommandDelegate<VkPhysicalDeviceGetImageFormatPropertiesDelegate>("vkGetPhysicalDeviceImageFormatProperties", "");
            vkGetPhysicalDeviceProperties = cache.GetCommandDelegate<VkPhysicalDeviceGetPropertiesDelegate>("vkGetPhysicalDeviceProperties", "");
            vkGetPhysicalDeviceQueueFamilyProperties = cache.GetCommandDelegate<VkPhysicalDeviceGetQueueFamilyPropertiesDelegate>("vkGetPhysicalDeviceQueueFamilyProperties", "");
            vkGetPhysicalDeviceMemoryProperties = cache.GetCommandDelegate<VkPhysicalDeviceGetMemoryPropertiesDelegate>("vkGetPhysicalDeviceMemoryProperties", "");
            vkGetInstanceProcAddr = cache.GetCommandDelegate<VkInstanceGetProcedureAddressDelegate>("vkGetInstanceProcAddr", "");
            vkGetDeviceProcAddr = cache.GetCommandDelegate<VkDeviceGetProcedureAddressDelegate>("vkGetDeviceProcAddr", "");
            vkCreateDevice = cache.GetCommandDelegate<VkPhysicalDeviceCreateDeviceDelegate>("vkCreateDevice", "");
            vkDestroyDevice = cache.GetCommandDelegate<VkDeviceDestroyDelegate>("vkDestroyDevice", "");
            vkEnumerateInstanceExtensionProperties = cache.GetCommandDelegate<VkInstanceEnumerateExtensionPropertiesDelegate>("vkEnumerateInstanceExtensionProperties", "");
            vkEnumerateDeviceExtensionProperties = cache.GetCommandDelegate<VkPhysicalDeviceEnumerateDeviceExtensionPropertiesDelegate>("vkEnumerateDeviceExtensionProperties", "");
            vkEnumerateInstanceLayerProperties = cache.GetCommandDelegate<VkInstanceEnumerateLayerPropertiesDelegate>("vkEnumerateInstanceLayerProperties", "");
            vkEnumerateDeviceLayerProperties = cache.GetCommandDelegate<VkPhysicalDeviceEnumerateDeviceLayerPropertiesDelegate>("vkEnumerateDeviceLayerProperties", "");
            vkGetDeviceQueue = cache.GetCommandDelegate<VkDeviceGetQueueDelegate>("vkGetDeviceQueue", "");
            vkQueueSubmit = cache.GetCommandDelegate<VkQueueSubmitDelegate>("vkQueueSubmit", "");
            vkQueueWaitIdle = cache.GetCommandDelegate<VkQueueWaitIdleDelegate>("vkQueueWaitIdle", "");
            vkDeviceWaitIdle = cache.GetCommandDelegate<VkDeviceWaitIdleDelegate>("vkDeviceWaitIdle", "");
            vkAllocateMemory = cache.GetCommandDelegate<VkDeviceAllocateMemoryDelegate>("vkAllocateMemory", "");
            vkFreeMemory = cache.GetCommandDelegate<VkDeviceMemoryFreeDelegate>("vkFreeMemory", "");
            vkMapMemory = cache.GetCommandDelegate<VkDeviceMemoryMapDelegate>("vkMapMemory", "");
            vkUnmapMemory = cache.GetCommandDelegate<VkDeviceMemoryUnmapDelegate>("vkUnmapMemory", "");
            vkFlushMappedMemoryRanges = cache.GetCommandDelegate<VkDeviceFlushMappedMemoryRangesDelegate>("vkFlushMappedMemoryRanges", "");
            vkInvalidateMappedMemoryRanges = cache.GetCommandDelegate<VkDeviceInvalidateMappedMemoryRangesDelegate>("vkInvalidateMappedMemoryRanges", "");
            vkGetDeviceMemoryCommitment = cache.GetCommandDelegate<VkDeviceMemoryGetCommitmentDelegate>("vkGetDeviceMemoryCommitment", "");
            vkBindBufferMemory = cache.GetCommandDelegate<VkBufferBindMemoryDelegate>("vkBindBufferMemory", "");
            vkBindImageMemory = cache.GetCommandDelegate<VkImageBindMemoryDelegate>("vkBindImageMemory", "");
            vkGetBufferMemoryRequirements = cache.GetCommandDelegate<VkBufferGetMemoryRequirementsDelegate>("vkGetBufferMemoryRequirements", "");
            vkGetImageMemoryRequirements = cache.GetCommandDelegate<VkImageGetMemoryRequirementsDelegate>("vkGetImageMemoryRequirements", "");
            vkGetImageSparseMemoryRequirements = cache.GetCommandDelegate<VkImageGetSparseMemoryRequirementsDelegate>("vkGetImageSparseMemoryRequirements", "");
            vkGetPhysicalDeviceSparseImageFormatProperties = cache.GetCommandDelegate<VkPhysicalDeviceGetSparseImageFormatPropertiesDelegate>("vkGetPhysicalDeviceSparseImageFormatProperties", "");
            vkQueueBindSparse = cache.GetCommandDelegate<VkQueueBindSparseDelegate>("vkQueueBindSparse", "");
            vkCreateFence = cache.GetCommandDelegate<VkDeviceCreateFenceDelegate>("vkCreateFence", "");
            vkDestroyFence = cache.GetCommandDelegate<VkFenceDestroyDelegate>("vkDestroyFence", "");
            vkResetFences = cache.GetCommandDelegate<VkDeviceResetFencesDelegate>("vkResetFences", "");
            vkGetFenceStatus = cache.GetCommandDelegate<VkFenceGetStatusDelegate>("vkGetFenceStatus", "");
            vkWaitForFences = cache.GetCommandDelegate<VkDeviceWaitForFencesDelegate>("vkWaitForFences", "");
            vkCreateSemaphore = cache.GetCommandDelegate<VkDeviceCreateSemaphoreDelegate>("vkCreateSemaphore", "");
            vkDestroySemaphore = cache.GetCommandDelegate<VkSemaphoreDestroyDelegate>("vkDestroySemaphore", "");
            vkCreateEvent = cache.GetCommandDelegate<VkDeviceCreateEventDelegate>("vkCreateEvent", "");
            vkDestroyEvent = cache.GetCommandDelegate<VkEventDestroyDelegate>("vkDestroyEvent", "");
            vkGetEventStatus = cache.GetCommandDelegate<VkEventGetStatusDelegate>("vkGetEventStatus", "");
            vkSetEvent = cache.GetCommandDelegate<VkEventSetDelegate>("vkSetEvent", "");
            vkResetEvent = cache.GetCommandDelegate<VkEventResetDelegate>("vkResetEvent", "");
            vkCreateQueryPool = cache.GetCommandDelegate<VkDeviceCreateQueryPoolDelegate>("vkCreateQueryPool", "");
            vkDestroyQueryPool = cache.GetCommandDelegate<VkQueryPoolDestroyDelegate>("vkDestroyQueryPool", "");
            vkGetQueryPoolResults = cache.GetCommandDelegate<VkQueryPoolGetResultsDelegate>("vkGetQueryPoolResults", "");
            vkCreateBuffer = cache.GetCommandDelegate<VkDeviceCreateBufferDelegate>("vkCreateBuffer", "");
            vkDestroyBuffer = cache.GetCommandDelegate<VkBufferDestroyDelegate>("vkDestroyBuffer", "");
            vkCreateBufferView = cache.GetCommandDelegate<VkDeviceCreateBufferViewDelegate>("vkCreateBufferView", "");
            vkDestroyBufferView = cache.GetCommandDelegate<VkBufferViewDestroyDelegate>("vkDestroyBufferView", "");
            vkCreateImage = cache.GetCommandDelegate<VkDeviceCreateImageDelegate>("vkCreateImage", "");
            vkDestroyImage = cache.GetCommandDelegate<VkImageDestroyDelegate>("vkDestroyImage", "");
            vkGetImageSubresourceLayout = cache.GetCommandDelegate<VkImageGetSubresourceLayoutDelegate>("vkGetImageSubresourceLayout", "");
            vkCreateImageView = cache.GetCommandDelegate<VkDeviceCreateImageViewDelegate>("vkCreateImageView", "");
            vkDestroyImageView = cache.GetCommandDelegate<VkImageViewDestroyDelegate>("vkDestroyImageView", "");
            vkCreateShaderModule = cache.GetCommandDelegate<VkDeviceCreateShaderModuleDelegate>("vkCreateShaderModule", "");
            vkDestroyShaderModule = cache.GetCommandDelegate<VkShaderModuleDestroyDelegate>("vkDestroyShaderModule", "");
            vkCreatePipelineCache = cache.GetCommandDelegate<VkDeviceCreatePipelineCacheDelegate>("vkCreatePipelineCache", "");
            vkDestroyPipelineCache = cache.GetCommandDelegate<VkPipelineCacheDestroyDelegate>("vkDestroyPipelineCache", "");
            vkGetPipelineCacheData = cache.GetCommandDelegate<VkPipelineCacheGetDataDelegate>("vkGetPipelineCacheData", "");
            vkMergePipelineCaches = cache.GetCommandDelegate<VkPipelineCacheMergePipelineCachesDelegate>("vkMergePipelineCaches", "");
            vkCreateGraphicsPipelines = cache.GetCommandDelegate<VkDeviceCreateGraphicsPipelinesDelegate>("vkCreateGraphicsPipelines", "");
            vkCreateComputePipelines = cache.GetCommandDelegate<VkDeviceCreateComputePipelinesDelegate>("vkCreateComputePipelines", "");
            vkDestroyPipeline = cache.GetCommandDelegate<VkPipelineDestroyDelegate>("vkDestroyPipeline", "");
            vkCreatePipelineLayout = cache.GetCommandDelegate<VkDeviceCreatePipelineLayoutDelegate>("vkCreatePipelineLayout", "");
            vkDestroyPipelineLayout = cache.GetCommandDelegate<VkPipelineLayoutDestroyDelegate>("vkDestroyPipelineLayout", "");
            vkCreateSampler = cache.GetCommandDelegate<VkDeviceCreateSamplerDelegate>("vkCreateSampler", "");
            vkDestroySampler = cache.GetCommandDelegate<VkSamplerDestroyDelegate>("vkDestroySampler", "");
            vkCreateDescriptorSetLayout = cache.GetCommandDelegate<VkDeviceCreateDescriptorSetLayoutDelegate>("vkCreateDescriptorSetLayout", "");
            vkDestroyDescriptorSetLayout = cache.GetCommandDelegate<VkDescriptorSetLayoutDestroyDelegate>("vkDestroyDescriptorSetLayout", "");
            vkCreateDescriptorPool = cache.GetCommandDelegate<VkDeviceCreateDescriptorPoolDelegate>("vkCreateDescriptorPool", "");
            vkDestroyDescriptorPool = cache.GetCommandDelegate<VkDescriptorPoolDestroyDelegate>("vkDestroyDescriptorPool", "");
            vkResetDescriptorPool = cache.GetCommandDelegate<VkDescriptorPoolResetDelegate>("vkResetDescriptorPool", "");
            vkAllocateDescriptorSets = cache.GetCommandDelegate<VkDeviceAllocateDescriptorSetsDelegate>("vkAllocateDescriptorSets", "");
            vkFreeDescriptorSets = cache.GetCommandDelegate<VkDescriptorPoolFreeDescriptorSetsDelegate>("vkFreeDescriptorSets", "");
            vkUpdateDescriptorSets = cache.GetCommandDelegate<VkDeviceUpdateDescriptorSetsDelegate>("vkUpdateDescriptorSets", "");
            vkCreateFramebuffer = cache.GetCommandDelegate<VkDeviceCreateFramebufferDelegate>("vkCreateFramebuffer", "");
            vkDestroyFramebuffer = cache.GetCommandDelegate<VkFramebufferDestroyDelegate>("vkDestroyFramebuffer", "");
            vkCreateRenderPass = cache.GetCommandDelegate<VkDeviceCreateRenderPassDelegate>("vkCreateRenderPass", "");
            vkDestroyRenderPass = cache.GetCommandDelegate<VkRenderPassDestroyDelegate>("vkDestroyRenderPass", "");
            vkGetRenderAreaGranularity = cache.GetCommandDelegate<VkRenderPassGetRenderAreaGranularityDelegate>("vkGetRenderAreaGranularity", "");
            vkCreateCommandPool = cache.GetCommandDelegate<VkDeviceCreateCommandPoolDelegate>("vkCreateCommandPool", "");
            vkDestroyCommandPool = cache.GetCommandDelegate<VkCommandPoolDestroyDelegate>("vkDestroyCommandPool", "");
            vkResetCommandPool = cache.GetCommandDelegate<VkCommandPoolResetDelegate>("vkResetCommandPool", "");
            vkAllocateCommandBuffers = cache.GetCommandDelegate<VkDeviceAllocateCommandBuffersDelegate>("vkAllocateCommandBuffers", "");
            vkFreeCommandBuffers = cache.GetCommandDelegate<VkCommandPoolFreeCommandBuffersDelegate>("vkFreeCommandBuffers", "");
            vkBeginCommandBuffer = cache.GetCommandDelegate<VkCommandBufferBeginDelegate>("vkBeginCommandBuffer", "");
            vkEndCommandBuffer = cache.GetCommandDelegate<VkCommandBufferEndDelegate>("vkEndCommandBuffer", "");
            vkResetCommandBuffer = cache.GetCommandDelegate<VkCommandBufferResetDelegate>("vkResetCommandBuffer", "");
            vkCmdBindPipeline = cache.GetCommandDelegate<VkCommandBufferBindPipelineDelegate>("vkCmdBindPipeline", "");
            vkCmdSetViewport = cache.GetCommandDelegate<VkCommandBufferSetViewportDelegate>("vkCmdSetViewport", "");
            vkCmdSetScissor = cache.GetCommandDelegate<VkCommandBufferSetScissorDelegate>("vkCmdSetScissor", "");
            vkCmdSetLineWidth = cache.GetCommandDelegate<VkCommandBufferSetLineWidthDelegate>("vkCmdSetLineWidth", "");
            vkCmdSetDepthBias = cache.GetCommandDelegate<VkCommandBufferSetDepthBiasDelegate>("vkCmdSetDepthBias", "");
            vkCmdSetBlendConstants = cache.GetCommandDelegate<VkCommandBufferSetBlendConstantsDelegate>("vkCmdSetBlendConstants", "");
            vkCmdSetDepthBounds = cache.GetCommandDelegate<VkCommandBufferSetDepthBoundsDelegate>("vkCmdSetDepthBounds", "");
            vkCmdSetStencilCompareMask = cache.GetCommandDelegate<VkCommandBufferSetStencilCompareMaskDelegate>("vkCmdSetStencilCompareMask", "");
            vkCmdSetStencilWriteMask = cache.GetCommandDelegate<VkCommandBufferSetStencilWriteMaskDelegate>("vkCmdSetStencilWriteMask", "");
            vkCmdSetStencilReference = cache.GetCommandDelegate<VkCommandBufferSetStencilReferenceDelegate>("vkCmdSetStencilReference", "");
            vkCmdBindDescriptorSets = cache.GetCommandDelegate<VkCommandBufferBindDescriptorSetsDelegate>("vkCmdBindDescriptorSets", "");
            vkCmdBindIndexBuffer = cache.GetCommandDelegate<VkCommandBufferBindIndexBufferDelegate>("vkCmdBindIndexBuffer", "");
            vkCmdBindVertexBuffers = cache.GetCommandDelegate<VkCommandBufferBindVertexBuffersDelegate>("vkCmdBindVertexBuffers", "");
            vkCmdDraw = cache.GetCommandDelegate<VkCommandBufferDrawDelegate>("vkCmdDraw", "");
            vkCmdDrawIndexed = cache.GetCommandDelegate<VkCommandBufferDrawIndexedDelegate>("vkCmdDrawIndexed", "");
            vkCmdDrawIndirect = cache.GetCommandDelegate<VkCommandBufferDrawIndirectDelegate>("vkCmdDrawIndirect", "");
            vkCmdDrawIndexedIndirect = cache.GetCommandDelegate<VkCommandBufferDrawIndexedIndirectDelegate>("vkCmdDrawIndexedIndirect", "");
            vkCmdDispatch = cache.GetCommandDelegate<VkCommandBufferDispatchDelegate>("vkCmdDispatch", "");
            vkCmdDispatchIndirect = cache.GetCommandDelegate<VkCommandBufferDispatchIndirectDelegate>("vkCmdDispatchIndirect", "");
            vkCmdCopyBuffer = cache.GetCommandDelegate<VkCommandBufferCopyBufferDelegate>("vkCmdCopyBuffer", "");
            vkCmdCopyImage = cache.GetCommandDelegate<VkCommandBufferCopyImageDelegate>("vkCmdCopyImage", "");
            vkCmdBlitImage = cache.GetCommandDelegate<VkCommandBufferBlitImageDelegate>("vkCmdBlitImage", "");
            vkCmdCopyBufferToImage = cache.GetCommandDelegate<VkCommandBufferCopyBufferToImageDelegate>("vkCmdCopyBufferToImage", "");
            vkCmdCopyImageToBuffer = cache.GetCommandDelegate<VkCommandBufferCopyImageToBufferDelegate>("vkCmdCopyImageToBuffer", "");
            vkCmdUpdateBuffer = cache.GetCommandDelegate<VkCommandBufferUpdateBufferDelegate>("vkCmdUpdateBuffer", "");
            vkCmdFillBuffer = cache.GetCommandDelegate<VkCommandBufferFillBufferDelegate>("vkCmdFillBuffer", "");
            vkCmdClearColorImage = cache.GetCommandDelegate<VkCommandBufferClearColorImageDelegate>("vkCmdClearColorImage", "");
            vkCmdClearDepthStencilImage = cache.GetCommandDelegate<VkCommandBufferClearDepthStencilImageDelegate>("vkCmdClearDepthStencilImage", "");
            vkCmdClearAttachments = cache.GetCommandDelegate<VkCommandBufferClearAttachmentsDelegate>("vkCmdClearAttachments", "");
            vkCmdResolveImage = cache.GetCommandDelegate<VkCommandBufferResolveImageDelegate>("vkCmdResolveImage", "");
            vkCmdSetEvent = cache.GetCommandDelegate<VkCommandBufferSetEventDelegate>("vkCmdSetEvent", "");
            vkCmdResetEvent = cache.GetCommandDelegate<VkCommandBufferResetEventDelegate>("vkCmdResetEvent", "");
            vkCmdWaitEvents = cache.GetCommandDelegate<VkCommandBufferWaitEventsDelegate>("vkCmdWaitEvents", "");
            vkCmdPipelineBarrier = cache.GetCommandDelegate<VkCommandBufferPipelineBarrierDelegate>("vkCmdPipelineBarrier", "");
            vkCmdBeginQuery = cache.GetCommandDelegate<VkCommandBufferBeginQueryDelegate>("vkCmdBeginQuery", "");
            vkCmdEndQuery = cache.GetCommandDelegate<VkCommandBufferEndQueryDelegate>("vkCmdEndQuery", "");
            vkCmdResetQueryPool = cache.GetCommandDelegate<VkCommandBufferResetQueryPoolDelegate>("vkCmdResetQueryPool", "");
            vkCmdWriteTimestamp = cache.GetCommandDelegate<VkCommandBufferWriteTimestampDelegate>("vkCmdWriteTimestamp", "");
            vkCmdCopyQueryPoolResults = cache.GetCommandDelegate<VkCommandBufferCopyQueryPoolResultsDelegate>("vkCmdCopyQueryPoolResults", "");
            vkCmdPushConstants = cache.GetCommandDelegate<VkCommandBufferPushConstantsDelegate>("vkCmdPushConstants", "");
            vkCmdBeginRenderPass = cache.GetCommandDelegate<VkCommandBufferBeginRenderPassDelegate>("vkCmdBeginRenderPass", "");
            vkCmdNextSubpass = cache.GetCommandDelegate<VkCommandBufferNextSubpassDelegate>("vkCmdNextSubpass", "");
            vkCmdEndRenderPass = cache.GetCommandDelegate<VkCommandBufferEndRenderPassDelegate>("vkCmdEndRenderPass", "");
            vkCmdExecuteCommands = cache.GetCommandDelegate<VkCommandBufferExecuteCommandsDelegate>("vkCmdExecuteCommands", "");
            vkEnumerateInstanceVersion = cache.GetCommandDelegate<VkInstanceEnumerateVersionDelegate>("vkEnumerateInstanceVersion", "");
            vkBindBufferMemory2 = cache.GetCommandDelegate<VkDeviceBindBufferMemory2Delegate>("vkBindBufferMemory2", "");
            vkBindImageMemory2 = cache.GetCommandDelegate<VkDeviceBindImageMemory2Delegate>("vkBindImageMemory2", "");
            vkGetDeviceGroupPeerMemoryFeatures = cache.GetCommandDelegate<VkDeviceGetGroupPeerMemoryFeaturesDelegate>("vkGetDeviceGroupPeerMemoryFeatures", "");
            vkCmdSetDeviceMask = cache.GetCommandDelegate<VkCommandBufferSetDeviceMaskDelegate>("vkCmdSetDeviceMask", "");
            vkCmdDispatchBase = cache.GetCommandDelegate<VkCommandBufferDispatchBaseDelegate>("vkCmdDispatchBase", "");
            vkEnumeratePhysicalDeviceGroups = cache.GetCommandDelegate<VkInstanceEnumeratePhysicalDeviceGroupsDelegate>("vkEnumeratePhysicalDeviceGroups", "");
            vkGetImageMemoryRequirements2 = cache.GetCommandDelegate<VkDeviceGetImageMemoryRequirements2Delegate>("vkGetImageMemoryRequirements2", "");
            vkGetBufferMemoryRequirements2 = cache.GetCommandDelegate<VkDeviceGetBufferMemoryRequirements2Delegate>("vkGetBufferMemoryRequirements2", "");
            vkGetImageSparseMemoryRequirements2 = cache.GetCommandDelegate<VkDeviceGetImageSparseMemoryRequirements2Delegate>("vkGetImageSparseMemoryRequirements2", "");
            vkGetPhysicalDeviceFeatures2 = cache.GetCommandDelegate<VkPhysicalDeviceGetFeatures2Delegate>("vkGetPhysicalDeviceFeatures2", "");
            vkGetPhysicalDeviceProperties2 = cache.GetCommandDelegate<VkPhysicalDeviceGetProperties2Delegate>("vkGetPhysicalDeviceProperties2", "");
            vkGetPhysicalDeviceFormatProperties2 = cache.GetCommandDelegate<VkPhysicalDeviceGetFormatProperties2Delegate>("vkGetPhysicalDeviceFormatProperties2", "");
            vkGetPhysicalDeviceImageFormatProperties2 = cache.GetCommandDelegate<VkPhysicalDeviceGetImageFormatProperties2Delegate>("vkGetPhysicalDeviceImageFormatProperties2", "");
            vkGetPhysicalDeviceQueueFamilyProperties2 = cache.GetCommandDelegate<VkPhysicalDeviceGetQueueFamilyProperties2Delegate>("vkGetPhysicalDeviceQueueFamilyProperties2", "");
            vkGetPhysicalDeviceMemoryProperties2 = cache.GetCommandDelegate<VkPhysicalDeviceGetMemoryProperties2Delegate>("vkGetPhysicalDeviceMemoryProperties2", "");
            vkGetPhysicalDeviceSparseImageFormatProperties2 = cache.GetCommandDelegate<VkPhysicalDeviceGetSparseImageFormatProperties2Delegate>("vkGetPhysicalDeviceSparseImageFormatProperties2", "");
            vkTrimCommandPool = cache.GetCommandDelegate<VkCommandPoolTrimDelegate>("vkTrimCommandPool", "");
            vkGetDeviceQueue2 = cache.GetCommandDelegate<VkDeviceGetQueue2Delegate>("vkGetDeviceQueue2", "");
            vkCreateSamplerYcbcrConversion = cache.GetCommandDelegate<VkDeviceCreateSamplerYcbcrConversionDelegate>("vkCreateSamplerYcbcrConversion", "");
            vkDestroySamplerYcbcrConversion = cache.GetCommandDelegate<VkSamplerYcbcrConversionDestroyDelegate>("vkDestroySamplerYcbcrConversion", "");
            vkCreateDescriptorUpdateTemplate = cache.GetCommandDelegate<VkDeviceCreateDescriptorUpdateTemplateDelegate>("vkCreateDescriptorUpdateTemplate", "");
            vkDestroyDescriptorUpdateTemplate = cache.GetCommandDelegate<VkDescriptorUpdateTemplateDestroyDelegate>("vkDestroyDescriptorUpdateTemplate", "");
            vkUpdateDescriptorSetWithTemplate = cache.GetCommandDelegate<VkDeviceUpdateDescriptorSetWithTemplateDelegate>("vkUpdateDescriptorSetWithTemplate", "");
            vkGetPhysicalDeviceExternalBufferProperties = cache.GetCommandDelegate<VkPhysicalDeviceGetExternalBufferPropertiesDelegate>("vkGetPhysicalDeviceExternalBufferProperties", "");
            vkGetPhysicalDeviceExternalFenceProperties = cache.GetCommandDelegate<VkPhysicalDeviceGetExternalFencePropertiesDelegate>("vkGetPhysicalDeviceExternalFenceProperties", "");
            vkGetPhysicalDeviceExternalSemaphoreProperties = cache.GetCommandDelegate<VkPhysicalDeviceGetExternalSemaphorePropertiesDelegate>("vkGetPhysicalDeviceExternalSemaphoreProperties", "");
            vkGetDescriptorSetLayoutSupport = cache.GetCommandDelegate<VkDeviceGetDescriptorSetLayoutSupportDelegate>("vkGetDescriptorSetLayoutSupport", "");
            vkCmdDrawIndirectCount = cache.GetCommandDelegate<VkCommandBufferDrawIndirectCountDelegate>("vkCmdDrawIndirectCount", "");
            vkCmdDrawIndexedIndirectCount = cache.GetCommandDelegate<VkCommandBufferDrawIndexedIndirectCountDelegate>("vkCmdDrawIndexedIndirectCount", "");
            vkCreateRenderPass2 = cache.GetCommandDelegate<VkDeviceCreateRenderPass2Delegate>("vkCreateRenderPass2", "");
            vkCmdBeginRenderPass2 = cache.GetCommandDelegate<VkCommandBufferBeginRenderPass2Delegate>("vkCmdBeginRenderPass2", "");
            vkCmdNextSubpass2 = cache.GetCommandDelegate<VkCommandBufferNextSubpass2Delegate>("vkCmdNextSubpass2", "");
            vkCmdEndRenderPass2 = cache.GetCommandDelegate<VkCommandBufferEndRenderPass2Delegate>("vkCmdEndRenderPass2", "");
            vkResetQueryPool = cache.GetCommandDelegate<VkQueryPoolResetDelegate>("vkResetQueryPool", "");
            vkGetSemaphoreCounterValue = cache.GetCommandDelegate<VkSemaphoreGetCounterValueDelegate>("vkGetSemaphoreCounterValue", "");
            vkWaitSemaphores = cache.GetCommandDelegate<VkDeviceWaitSemaphoresDelegate>("vkWaitSemaphores", "");
            vkSignalSemaphore = cache.GetCommandDelegate<VkDeviceSignalSemaphoreDelegate>("vkSignalSemaphore", "");
            vkGetBufferDeviceAddress = cache.GetCommandDelegate<VkDeviceGetBufferDeviceAddressDelegate>("vkGetBufferDeviceAddress", "");
            vkGetBufferOpaqueCaptureAddress = cache.GetCommandDelegate<VkDeviceGetBufferOpaqueCaptureAddressDelegate>("vkGetBufferOpaqueCaptureAddress", "");
            vkGetDeviceMemoryOpaqueCaptureAddress = cache.GetCommandDelegate<VkDeviceGetMemoryOpaqueCaptureAddressDelegate>("vkGetDeviceMemoryOpaqueCaptureAddress", "");
            vkDestroySurfaceKHR = cache.GetCommandDelegate<VkSurfaceKHRDestroyDelegate>("vkDestroySurfaceKHR", "instance");
            vkGetPhysicalDeviceSurfaceSupportKHR = cache.GetCommandDelegate<VkPhysicalDeviceGetSurfaceSupportDelegate>("vkGetPhysicalDeviceSurfaceSupportKHR", "instance");
            vkGetPhysicalDeviceSurfaceCapabilitiesKHR = cache.GetCommandDelegate<VkPhysicalDeviceGetSurfaceCapabilitiesDelegate>("vkGetPhysicalDeviceSurfaceCapabilitiesKHR", "instance");
            vkGetPhysicalDeviceSurfaceFormatsKHR = cache.GetCommandDelegate<VkPhysicalDeviceGetSurfaceFormatsDelegate>("vkGetPhysicalDeviceSurfaceFormatsKHR", "instance");
            vkGetPhysicalDeviceSurfacePresentModesKHR = cache.GetCommandDelegate<VkPhysicalDeviceGetSurfacePresentModesDelegate>("vkGetPhysicalDeviceSurfacePresentModesKHR", "instance");
            vkCreateSwapchainKHR = cache.GetCommandDelegate<VkDeviceCreateSwapchainDelegate>("vkCreateSwapchainKHR", "device");
            vkDestroySwapchainKHR = cache.GetCommandDelegate<VkSwapchainKHRDestroyDelegate>("vkDestroySwapchainKHR", "device");
            vkGetSwapchainImagesKHR = cache.GetCommandDelegate<VkSwapchainKHRGetImagesDelegate>("vkGetSwapchainImagesKHR", "device");
            vkAcquireNextImageKHR = cache.GetCommandDelegate<VkSwapchainKHRAcquireNextImageDelegate>("vkAcquireNextImageKHR", "device");
            vkQueuePresentKHR = cache.GetCommandDelegate<VkQueuePresentDelegate>("vkQueuePresentKHR", "device");
            vkGetDeviceGroupPresentCapabilitiesKHR = cache.GetCommandDelegate<VkDeviceGetGroupPresentCapabilitiesDelegate>("vkGetDeviceGroupPresentCapabilitiesKHR", "device");
            vkGetDeviceGroupSurfacePresentModesKHR = cache.GetCommandDelegate<VkDeviceGetGroupSurfacePresentModesDelegate>("vkGetDeviceGroupSurfacePresentModesKHR", "device");
            vkGetPhysicalDevicePresentRectanglesKHR = cache.GetCommandDelegate<VkPhysicalDeviceGetPresentRectanglesDelegate>("vkGetPhysicalDevicePresentRectanglesKHR", "device");
            vkAcquireNextImage2KHR = cache.GetCommandDelegate<VkDeviceAcquireNextImage2Delegate>("vkAcquireNextImage2KHR", "device");
            vkGetPhysicalDeviceDisplayPropertiesKHR = cache.GetCommandDelegate<VkPhysicalDeviceGetDisplayPropertiesDelegate>("vkGetPhysicalDeviceDisplayPropertiesKHR", "instance");
            vkGetPhysicalDeviceDisplayPlanePropertiesKHR = cache.GetCommandDelegate<VkPhysicalDeviceGetDisplayPlanePropertiesDelegate>("vkGetPhysicalDeviceDisplayPlanePropertiesKHR", "instance");
            vkGetDisplayPlaneSupportedDisplaysKHR = cache.GetCommandDelegate<VkPhysicalDeviceGetDisplayPlaneSupportedDisplaysDelegate>("vkGetDisplayPlaneSupportedDisplaysKHR", "instance");
            vkGetDisplayModePropertiesKHR = cache.GetCommandDelegate<VkPhysicalDeviceGetDisplayModePropertiesDelegate>("vkGetDisplayModePropertiesKHR", "instance");
            vkCreateDisplayModeKHR = cache.GetCommandDelegate<VkPhysicalDeviceCreateDisplayModeDelegate>("vkCreateDisplayModeKHR", "instance");
            vkGetDisplayPlaneCapabilitiesKHR = cache.GetCommandDelegate<VkDisplayModeKHRGetDisplayPlaneCapabilitiesDelegate>("vkGetDisplayPlaneCapabilitiesKHR", "instance");
            vkCreateDisplayPlaneSurfaceKHR = cache.GetCommandDelegate<VkInstanceCreateDisplayPlaneSurfaceDelegate>("vkCreateDisplayPlaneSurfaceKHR", "instance");
            vkCreateSharedSwapchainsKHR = cache.GetCommandDelegate<VkDeviceCreateSharedSwapchainsDelegate>("vkCreateSharedSwapchainsKHR", "device");
            vkCreateXlibSurfaceKHR = cache.GetCommandDelegate<VkInstanceCreateXlibSurfaceDelegate>("vkCreateXlibSurfaceKHR", "instance");
            vkGetPhysicalDeviceXlibPresentationSupportKHR = cache.GetCommandDelegate<VkPhysicalDeviceGetXlibPresentationSupportDelegate>("vkGetPhysicalDeviceXlibPresentationSupportKHR", "instance");
            vkCreateXcbSurfaceKHR = cache.GetCommandDelegate<VkInstanceCreateXcbSurfaceDelegate>("vkCreateXcbSurfaceKHR", "instance");
            vkGetPhysicalDeviceXcbPresentationSupportKHR = cache.GetCommandDelegate<VkPhysicalDeviceGetXcbPresentationSupportDelegate>("vkGetPhysicalDeviceXcbPresentationSupportKHR", "instance");
            vkCreateWaylandSurfaceKHR = cache.GetCommandDelegate<VkInstanceCreateWaylandSurfaceDelegate>("vkCreateWaylandSurfaceKHR", "instance");
            vkGetPhysicalDeviceWaylandPresentationSupportKHR = cache.GetCommandDelegate<VkPhysicalDeviceGetWaylandPresentationSupportDelegate>("vkGetPhysicalDeviceWaylandPresentationSupportKHR", "instance");
            vkCreateAndroidSurfaceKHR = cache.GetCommandDelegate<VkInstanceCreateAndroidSurfaceDelegate>("vkCreateAndroidSurfaceKHR", "instance");
            vkCreateWin32SurfaceKHR = cache.GetCommandDelegate<VkInstanceCreateWin32SurfaceDelegate>("vkCreateWin32SurfaceKHR", "instance");
            vkGetPhysicalDeviceWin32PresentationSupportKHR = cache.GetCommandDelegate<VkPhysicalDeviceGetWin32PresentationSupportDelegate>("vkGetPhysicalDeviceWin32PresentationSupportKHR", "instance");
            vkCreateDebugReportCallbackEXT = cache.GetCommandDelegate<VkInstanceCreateDebugReportCallbackDelegate>("vkCreateDebugReportCallbackEXT", "instance");
            vkDestroyDebugReportCallbackEXT = cache.GetCommandDelegate<VkDebugReportCallbackEXTDestroyDelegate>("vkDestroyDebugReportCallbackEXT", "instance");
            vkDebugReportMessageEXT = cache.GetCommandDelegate<VkInstanceDebugReportMessageDelegate>("vkDebugReportMessageEXT", "instance");
            vkCmdBindTransformFeedbackBuffersEXT = cache.GetCommandDelegate<VkCommandBufferBindTransformFeedbackBuffersDelegate>("vkCmdBindTransformFeedbackBuffersEXT", "device");
            vkCmdBeginTransformFeedbackEXT = cache.GetCommandDelegate<VkCommandBufferBeginTransformFeedbackDelegate>("vkCmdBeginTransformFeedbackEXT", "device");
            vkCmdEndTransformFeedbackEXT = cache.GetCommandDelegate<VkCommandBufferEndTransformFeedbackDelegate>("vkCmdEndTransformFeedbackEXT", "device");
            vkCmdBeginQueryIndexedEXT = cache.GetCommandDelegate<VkCommandBufferBeginQueryIndexedDelegate>("vkCmdBeginQueryIndexedEXT", "device");
            vkCmdEndQueryIndexedEXT = cache.GetCommandDelegate<VkCommandBufferEndQueryIndexedDelegate>("vkCmdEndQueryIndexedEXT", "device");
            vkCmdDrawIndirectByteCountEXT = cache.GetCommandDelegate<VkCommandBufferDrawIndirectByteCountDelegate>("vkCmdDrawIndirectByteCountEXT", "device");
            vkGetImageViewHandleNVX = cache.GetCommandDelegate<VkDeviceGetImageViewHandleDelegate>("vkGetImageViewHandleNVX", "device");
            vkGetShaderInfoAMD = cache.GetCommandDelegate<VkPipelineGetShaderInfoDelegate>("vkGetShaderInfoAMD", "device");
            vkCreateStreamDescriptorSurfaceGGP = cache.GetCommandDelegate<VkInstanceCreateStreamDescriptorSurfaceDelegate>("vkCreateStreamDescriptorSurfaceGGP", "instance");
            vkGetPhysicalDeviceExternalImageFormatPropertiesNV = cache.GetCommandDelegate<VkPhysicalDeviceGetExternalImageFormatPropertiesDelegate>("vkGetPhysicalDeviceExternalImageFormatPropertiesNV", "instance");
            vkGetMemoryWin32HandleNV = cache.GetCommandDelegate<VkDeviceMemoryGetWin32HandleDelegate>("vkGetMemoryWin32HandleNV", "device");
            vkCreateViSurfaceNN = cache.GetCommandDelegate<VkInstanceCreateViSurfaceDelegate>("vkCreateViSurfaceNN", "instance");
            vkGetMemoryWin32HandleKHR = cache.GetCommandDelegate<VkDeviceGetMemoryWin32HandleDelegate>("vkGetMemoryWin32HandleKHR", "device");
            vkGetMemoryWin32HandlePropertiesKHR = cache.GetCommandDelegate<VkDeviceGetMemoryWin32HandlePropertiesDelegate>("vkGetMemoryWin32HandlePropertiesKHR", "device");
            vkGetMemoryFdKHR = cache.GetCommandDelegate<VkDeviceGetMemoryFileDescriptorDelegate>("vkGetMemoryFdKHR", "device");
            vkGetMemoryFdPropertiesKHR = cache.GetCommandDelegate<VkDeviceGetMemoryFileDescriptorPropertiesDelegate>("vkGetMemoryFdPropertiesKHR", "device");
            vkImportSemaphoreWin32HandleKHR = cache.GetCommandDelegate<VkDeviceImportSemaphoreWin32HandleDelegate>("vkImportSemaphoreWin32HandleKHR", "device");
            vkGetSemaphoreWin32HandleKHR = cache.GetCommandDelegate<VkDeviceGetSemaphoreWin32HandleDelegate>("vkGetSemaphoreWin32HandleKHR", "device");
            vkImportSemaphoreFdKHR = cache.GetCommandDelegate<VkDeviceImportSemaphoreFileDescriptorDelegate>("vkImportSemaphoreFdKHR", "device");
            vkGetSemaphoreFdKHR = cache.GetCommandDelegate<VkDeviceGetSemaphoreFileDescriptorDelegate>("vkGetSemaphoreFdKHR", "device");
            vkCmdPushDescriptorSetKHR = cache.GetCommandDelegate<VkCommandBufferPushDescriptorSetDelegate>("vkCmdPushDescriptorSetKHR", "device");
            vkCmdPushDescriptorSetWithTemplateKHR = cache.GetCommandDelegate<VkCommandBufferPushDescriptorSetWithTemplateDelegate>("vkCmdPushDescriptorSetWithTemplateKHR", "device");
            vkCmdBeginConditionalRenderingEXT = cache.GetCommandDelegate<VkCommandBufferBeginConditionalRenderingDelegate>("vkCmdBeginConditionalRenderingEXT", "device");
            vkCmdEndConditionalRenderingEXT = cache.GetCommandDelegate<VkCommandBufferEndConditionalRenderingDelegate>("vkCmdEndConditionalRenderingEXT", "device");
            vkCmdProcessCommandsNVX = cache.GetCommandDelegate<VkCommandBufferProcessCommandsDelegate>("vkCmdProcessCommandsNVX", "device");
            vkCmdReserveSpaceForCommandsNVX = cache.GetCommandDelegate<VkCommandBufferReserveSpaceForCommandsDelegate>("vkCmdReserveSpaceForCommandsNVX", "device");
            vkCreateIndirectCommandsLayoutNVX = cache.GetCommandDelegate<VkDeviceCreateIndirectCommandsLayoutDelegate>("vkCreateIndirectCommandsLayoutNVX", "device");
            vkDestroyIndirectCommandsLayoutNVX = cache.GetCommandDelegate<VkIndirectCommandsLayoutNVXDestroyDelegate>("vkDestroyIndirectCommandsLayoutNVX", "device");
            vkCreateObjectTableNVX = cache.GetCommandDelegate<VkDeviceCreateObjectTableDelegate>("vkCreateObjectTableNVX", "device");
            vkDestroyObjectTableNVX = cache.GetCommandDelegate<VkObjectTableNVXDestroyDelegate>("vkDestroyObjectTableNVX", "device");
            vkRegisterObjectsNVX = cache.GetCommandDelegate<VkObjectTableNVXRegisterObjectsDelegate>("vkRegisterObjectsNVX", "device");
            vkUnregisterObjectsNVX = cache.GetCommandDelegate<VkObjectTableNVXUnregisterObjectsDelegate>("vkUnregisterObjectsNVX", "device");
            vkGetPhysicalDeviceGeneratedCommandsPropertiesNVX = cache.GetCommandDelegate<VkPhysicalDeviceGetGeneratedCommandsPropertiesDelegate>("vkGetPhysicalDeviceGeneratedCommandsPropertiesNVX", "device");
            vkCmdSetViewportWScalingNV = cache.GetCommandDelegate<VkCommandBufferSetViewportWScalingDelegate>("vkCmdSetViewportWScalingNV", "device");
            vkReleaseDisplayEXT = cache.GetCommandDelegate<VkPhysicalDeviceReleaseDisplayDelegate>("vkReleaseDisplayEXT", "instance");
            vkAcquireXlibDisplayEXT = cache.GetCommandDelegate<VkPhysicalDeviceAcquireXlibDisplayDelegate>("vkAcquireXlibDisplayEXT", "instance");
            vkGetRandROutputDisplayEXT = cache.GetCommandDelegate<VkPhysicalDeviceGetRandROutputDisplayDelegate>("vkGetRandROutputDisplayEXT", "instance");
            vkGetPhysicalDeviceSurfaceCapabilities2EXT = cache.GetCommandDelegate<VkPhysicalDeviceGetSurfaceCapabilities2Delegate>("vkGetPhysicalDeviceSurfaceCapabilities2EXT", "instance");
            vkDisplayPowerControlEXT = cache.GetCommandDelegate<VkDeviceDisplayPowerControlDelegate>("vkDisplayPowerControlEXT", "device");
            vkRegisterDeviceEventEXT = cache.GetCommandDelegate<VkDeviceRegisterEventDelegate>("vkRegisterDeviceEventEXT", "device");
            vkRegisterDisplayEventEXT = cache.GetCommandDelegate<VkDeviceRegisterDisplayEventDelegate>("vkRegisterDisplayEventEXT", "device");
            vkGetSwapchainCounterEXT = cache.GetCommandDelegate<VkSwapchainKHRGetCounterDelegate>("vkGetSwapchainCounterEXT", "device");
            vkGetRefreshCycleDurationGOOGLE = cache.GetCommandDelegate<VkSwapchainKHRGetRefreshCycleDurationDelegate>("vkGetRefreshCycleDurationGOOGLE", "device");
            vkGetPastPresentationTimingGOOGLE = cache.GetCommandDelegate<VkSwapchainKHRGetPastPresentationTimingDelegate>("vkGetPastPresentationTimingGOOGLE", "device");
            vkCmdSetDiscardRectangleEXT = cache.GetCommandDelegate<VkCommandBufferSetDiscardRectangleDelegate>("vkCmdSetDiscardRectangleEXT", "device");
            vkSetHdrMetadataEXT = cache.GetCommandDelegate<VkDeviceSetHdrMetadataDelegate>("vkSetHdrMetadataEXT", "device");
            vkGetSwapchainStatusKHR = cache.GetCommandDelegate<VkSwapchainKHRGetStatusDelegate>("vkGetSwapchainStatusKHR", "device");
            vkImportFenceWin32HandleKHR = cache.GetCommandDelegate<VkDeviceImportFenceWin32HandleDelegate>("vkImportFenceWin32HandleKHR", "device");
            vkGetFenceWin32HandleKHR = cache.GetCommandDelegate<VkDeviceGetFenceWin32HandleDelegate>("vkGetFenceWin32HandleKHR", "device");
            vkImportFenceFdKHR = cache.GetCommandDelegate<VkDeviceImportFenceFileDescriptorDelegate>("vkImportFenceFdKHR", "device");
            vkGetFenceFdKHR = cache.GetCommandDelegate<VkDeviceGetFenceFileDescriptorDelegate>("vkGetFenceFdKHR", "device");
            vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR = cache.GetCommandDelegate<VkPhysicalDeviceEnumerateQueueFamilyPerformanceQueryCountersDelegate>("vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR", "device");
            vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR = cache.GetCommandDelegate<VkPhysicalDeviceGetQueueFamilyPerformanceQueryPassesDelegate>("vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR", "device");
            vkAcquireProfilingLockKHR = cache.GetCommandDelegate<VkDeviceAcquireProfilingLockDelegate>("vkAcquireProfilingLockKHR", "device");
            vkReleaseProfilingLockKHR = cache.GetCommandDelegate<VkDeviceReleaseProfilingLockDelegate>("vkReleaseProfilingLockKHR", "device");
            vkGetPhysicalDeviceSurfaceCapabilities2KHR = cache.GetCommandDelegate<Interop.Khronos.VkPhysicalDeviceGetSurfaceCapabilities2Delegate>("vkGetPhysicalDeviceSurfaceCapabilities2KHR", "instance");
            vkGetPhysicalDeviceSurfaceFormats2KHR = cache.GetCommandDelegate<VkPhysicalDeviceGetSurfaceFormats2Delegate>("vkGetPhysicalDeviceSurfaceFormats2KHR", "instance");
            vkGetPhysicalDeviceDisplayProperties2KHR = cache.GetCommandDelegate<VkPhysicalDeviceGetDisplayProperties2Delegate>("vkGetPhysicalDeviceDisplayProperties2KHR", "instance");
            vkGetPhysicalDeviceDisplayPlaneProperties2KHR = cache.GetCommandDelegate<VkPhysicalDeviceGetDisplayPlaneProperties2Delegate>("vkGetPhysicalDeviceDisplayPlaneProperties2KHR", "instance");
            vkGetDisplayModeProperties2KHR = cache.GetCommandDelegate<VkPhysicalDeviceGetDisplayModeProperties2Delegate>("vkGetDisplayModeProperties2KHR", "instance");
            vkGetDisplayPlaneCapabilities2KHR = cache.GetCommandDelegate<VkPhysicalDeviceGetDisplayPlaneCapabilities2Delegate>("vkGetDisplayPlaneCapabilities2KHR", "instance");
            vkCreateIOSSurfaceMVK = cache.GetCommandDelegate<VkInstanceCreateIOSSurfaceDelegate>("vkCreateIOSSurfaceMVK", "instance");
            vkCreateMacOSSurfaceMVK = cache.GetCommandDelegate<VkInstanceCreateMacOSSurfaceDelegate>("vkCreateMacOSSurfaceMVK", "instance");
            vkSetDebugUtilsObjectNameEXT = cache.GetCommandDelegate<VkDeviceSetDebugUtilsObjectNameDelegate>("vkSetDebugUtilsObjectNameEXT", "instance");
            vkSetDebugUtilsObjectTagEXT = cache.GetCommandDelegate<VkDeviceSetDebugUtilsObjectTagDelegate>("vkSetDebugUtilsObjectTagEXT", "instance");
            vkQueueBeginDebugUtilsLabelEXT = cache.GetCommandDelegate<VkQueueBeginDebugUtilsLabelDelegate>("vkQueueBeginDebugUtilsLabelEXT", "instance");
            vkQueueEndDebugUtilsLabelEXT = cache.GetCommandDelegate<VkQueueEndDebugUtilsLabelDelegate>("vkQueueEndDebugUtilsLabelEXT", "instance");
            vkQueueInsertDebugUtilsLabelEXT = cache.GetCommandDelegate<VkQueueInsertDebugUtilsLabelDelegate>("vkQueueInsertDebugUtilsLabelEXT", "instance");
            vkCmdBeginDebugUtilsLabelEXT = cache.GetCommandDelegate<VkCommandBufferBeginDebugUtilsLabelDelegate>("vkCmdBeginDebugUtilsLabelEXT", "instance");
            vkCmdEndDebugUtilsLabelEXT = cache.GetCommandDelegate<VkCommandBufferEndDebugUtilsLabelDelegate>("vkCmdEndDebugUtilsLabelEXT", "instance");
            vkCmdInsertDebugUtilsLabelEXT = cache.GetCommandDelegate<VkCommandBufferInsertDebugUtilsLabelDelegate>("vkCmdInsertDebugUtilsLabelEXT", "instance");
            vkCreateDebugUtilsMessengerEXT = cache.GetCommandDelegate<VkInstanceCreateDebugUtilsMessengerDelegate>("vkCreateDebugUtilsMessengerEXT", "instance");
            vkDestroyDebugUtilsMessengerEXT = cache.GetCommandDelegate<VkDebugUtilsMessengerEXTDestroyDelegate>("vkDestroyDebugUtilsMessengerEXT", "instance");
            vkSubmitDebugUtilsMessageEXT = cache.GetCommandDelegate<VkInstanceSubmitDebugUtilsMessageDelegate>("vkSubmitDebugUtilsMessageEXT", "instance");
            vkGetAndroidHardwareBufferPropertiesANDROID = cache.GetCommandDelegate<VkDeviceGetAndroidHardwareBufferPropertiesDelegate>("vkGetAndroidHardwareBufferPropertiesANDROID", "device");
            vkGetMemoryAndroidHardwareBufferANDROID = cache.GetCommandDelegate<VkDeviceGetMemoryAndroidHardwareBufferDelegate>("vkGetMemoryAndroidHardwareBufferANDROID", "device");
            vkCmdSetSampleLocationsEXT = cache.GetCommandDelegate<VkCommandBufferSetSampleLocationsDelegate>("vkCmdSetSampleLocationsEXT", "device");
            vkGetPhysicalDeviceMultisamplePropertiesEXT = cache.GetCommandDelegate<VkPhysicalDeviceGetMultisamplePropertiesDelegate>("vkGetPhysicalDeviceMultisamplePropertiesEXT", "device");
            vkGetImageDrmFormatModifierPropertiesEXT = cache.GetCommandDelegate<VkImageGetDrmFormatModifierPropertiesDelegate>("vkGetImageDrmFormatModifierPropertiesEXT", "device");
            vkCreateValidationCacheEXT = cache.GetCommandDelegate<VkDeviceCreateValidationCacheDelegate>("vkCreateValidationCacheEXT", "device");
            vkDestroyValidationCacheEXT = cache.GetCommandDelegate<VkValidationCacheEXTDestroyDelegate>("vkDestroyValidationCacheEXT", "device");
            vkMergeValidationCachesEXT = cache.GetCommandDelegate<VkValidationCacheEXTMergeValidationCachesDelegate>("vkMergeValidationCachesEXT", "device");
            vkGetValidationCacheDataEXT = cache.GetCommandDelegate<VkValidationCacheEXTGetDataDelegate>("vkGetValidationCacheDataEXT", "device");
            vkCmdBindShadingRateImageNV = cache.GetCommandDelegate<VkCommandBufferBindShadingRateImageDelegate>("vkCmdBindShadingRateImageNV", "device");
            vkCmdSetViewportShadingRatePaletteNV = cache.GetCommandDelegate<VkCommandBufferSetViewportShadingRatePaletteDelegate>("vkCmdSetViewportShadingRatePaletteNV", "device");
            vkCmdSetCoarseSampleOrderNV = cache.GetCommandDelegate<VkCommandBufferSetCoarseSampleOrderDelegate>("vkCmdSetCoarseSampleOrderNV", "device");
            vkCreateAccelerationStructureNV = cache.GetCommandDelegate<VkDeviceCreateAccelerationStructureDelegate>("vkCreateAccelerationStructureNV", "device");
            vkDestroyAccelerationStructureNV = cache.GetCommandDelegate<VkAccelerationStructureNVDestroyDelegate>("vkDestroyAccelerationStructureNV", "device");
            vkGetAccelerationStructureMemoryRequirementsNV = cache.GetCommandDelegate<VkDeviceGetAccelerationStructureMemoryRequirementsDelegate>("vkGetAccelerationStructureMemoryRequirementsNV", "device");
            vkBindAccelerationStructureMemoryNV = cache.GetCommandDelegate<VkDeviceBindAccelerationStructureMemoryDelegate>("vkBindAccelerationStructureMemoryNV", "device");
            vkCmdBuildAccelerationStructureNV = cache.GetCommandDelegate<VkCommandBufferBuildAccelerationStructureDelegate>("vkCmdBuildAccelerationStructureNV", "device");
            vkCmdCopyAccelerationStructureNV = cache.GetCommandDelegate<VkCommandBufferCopyAccelerationStructureDelegate>("vkCmdCopyAccelerationStructureNV", "device");
            vkCmdTraceRaysNV = cache.GetCommandDelegate<VkCommandBufferTraceRaysDelegate>("vkCmdTraceRaysNV", "device");
            vkCreateRayTracingPipelinesNV = cache.GetCommandDelegate<VkDeviceCreateRayTracingPipelinesDelegate>("vkCreateRayTracingPipelinesNV", "device");
            vkGetRayTracingShaderGroupHandlesNV = cache.GetCommandDelegate<VkPipelineGetRayTracingShaderGroupHandlesDelegate>("vkGetRayTracingShaderGroupHandlesNV", "device");
            vkGetAccelerationStructureHandleNV = cache.GetCommandDelegate<VkAccelerationStructureNVGetHandleDelegate>("vkGetAccelerationStructureHandleNV", "device");
            vkCmdWriteAccelerationStructuresPropertiesNV = cache.GetCommandDelegate<VkCommandBufferWriteAccelerationStructuresPropertiesDelegate>("vkCmdWriteAccelerationStructuresPropertiesNV", "device");
            vkCompileDeferredNV = cache.GetCommandDelegate<VkPipelineCompileDeferredDelegate>("vkCompileDeferredNV", "device");
            vkGetMemoryHostPointerPropertiesEXT = cache.GetCommandDelegate<VkDeviceGetMemoryHostPointerPropertiesDelegate>("vkGetMemoryHostPointerPropertiesEXT", "device");
            vkCmdWriteBufferMarkerAMD = cache.GetCommandDelegate<VkCommandBufferWriteBufferMarkerDelegate>("vkCmdWriteBufferMarkerAMD", "device");
            vkGetPhysicalDeviceCalibrateableTimeDomainsEXT = cache.GetCommandDelegate<VkPhysicalDeviceGetCalibrateableTimeDomainsDelegate>("vkGetPhysicalDeviceCalibrateableTimeDomainsEXT", "device");
            vkGetCalibratedTimestampsEXT = cache.GetCommandDelegate<VkDeviceGetCalibratedTimestampsDelegate>("vkGetCalibratedTimestampsEXT", "device");
            vkCmdDrawMeshTasksNV = cache.GetCommandDelegate<VkCommandBufferDrawMeshTasksDelegate>("vkCmdDrawMeshTasksNV", "device");
            vkCmdDrawMeshTasksIndirectNV = cache.GetCommandDelegate<VkCommandBufferDrawMeshTasksIndirectDelegate>("vkCmdDrawMeshTasksIndirectNV", "device");
            vkCmdDrawMeshTasksIndirectCountNV = cache.GetCommandDelegate<VkCommandBufferDrawMeshTasksIndirectCountDelegate>("vkCmdDrawMeshTasksIndirectCountNV", "device");
            vkCmdSetExclusiveScissorNV = cache.GetCommandDelegate<VkCommandBufferSetExclusiveScissorDelegate>("vkCmdSetExclusiveScissorNV", "device");
            vkCmdSetCheckpointNV = cache.GetCommandDelegate<VkCommandBufferSetCheckpointDelegate>("vkCmdSetCheckpointNV", "device");
            vkGetQueueCheckpointDataNV = cache.GetCommandDelegate<VkQueueGetCheckpointDataDelegate>("vkGetQueueCheckpointDataNV", "device");
            vkInitializePerformanceApiINTEL = cache.GetCommandDelegate<VkDeviceInitializePerformanceApiDelegate>("vkInitializePerformanceApiINTEL", "device");
            vkUninitializePerformanceApiINTEL = cache.GetCommandDelegate<VkDeviceUninitializePerformanceApiDelegate>("vkUninitializePerformanceApiINTEL", "device");
            vkCmdSetPerformanceMarkerINTEL = cache.GetCommandDelegate<VkCommandBufferSetPerformanceMarkerDelegate>("vkCmdSetPerformanceMarkerINTEL", "device");
            vkCmdSetPerformanceStreamMarkerINTEL = cache.GetCommandDelegate<VkCommandBufferSetPerformanceStreamMarkerDelegate>("vkCmdSetPerformanceStreamMarkerINTEL", "device");
            vkCmdSetPerformanceOverrideINTEL = cache.GetCommandDelegate<VkCommandBufferSetPerformanceOverrideDelegate>("vkCmdSetPerformanceOverrideINTEL", "device");
            vkAcquirePerformanceConfigurationINTEL = cache.GetCommandDelegate<VkDeviceAcquirePerformanceConfigurationDelegate>("vkAcquirePerformanceConfigurationINTEL", "device");
            vkReleasePerformanceConfigurationINTEL = cache.GetCommandDelegate<VkPerformanceConfigurationINTELReleaseDelegate>("vkReleasePerformanceConfigurationINTEL", "device");
            vkQueueSetPerformanceConfigurationINTEL = cache.GetCommandDelegate<VkQueueSetPerformanceConfigurationDelegate>("vkQueueSetPerformanceConfigurationINTEL", "device");
            vkGetPerformanceParameterINTEL = cache.GetCommandDelegate<VkDeviceGetPerformanceParameterDelegate>("vkGetPerformanceParameterINTEL", "device");
            vkSetLocalDimmingAMD = cache.GetCommandDelegate<VkSwapchainKHRSetLocalDimmingDelegate>("vkSetLocalDimmingAMD", "device");
            vkCreateImagePipeSurfaceFUCHSIA = cache.GetCommandDelegate<VkInstanceCreateImagePipeSurfaceDelegate>("vkCreateImagePipeSurfaceFUCHSIA", "instance");
            vkCreateMetalSurfaceEXT = cache.GetCommandDelegate<VkInstanceCreateMetalSurfaceDelegate>("vkCreateMetalSurfaceEXT", "instance");
            vkGetPhysicalDeviceToolPropertiesEXT = cache.GetCommandDelegate<VkPhysicalDeviceGetToolPropertiesDelegate>("vkGetPhysicalDeviceToolPropertiesEXT", "device");
            vkGetPhysicalDeviceCooperativeMatrixPropertiesNV = cache.GetCommandDelegate<VkPhysicalDeviceGetCooperativeMatrixPropertiesDelegate>("vkGetPhysicalDeviceCooperativeMatrixPropertiesNV", "device");
            vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV = cache.GetCommandDelegate<VkPhysicalDeviceGetSupportedFramebufferMixedSamplesCombinationsDelegate>("vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV", "device");
            vkGetPhysicalDeviceSurfacePresentModes2EXT = cache.GetCommandDelegate<VkPhysicalDeviceGetSurfacePresentModes2Delegate>("vkGetPhysicalDeviceSurfacePresentModes2EXT", "device");
            vkAcquireFullScreenExclusiveModeEXT = cache.GetCommandDelegate<VkSwapchainKHRAcquireFullScreenExclusiveModeDelegate>("vkAcquireFullScreenExclusiveModeEXT", "device");
            vkReleaseFullScreenExclusiveModeEXT = cache.GetCommandDelegate<VkSwapchainKHRReleaseFullScreenExclusiveModeDelegate>("vkReleaseFullScreenExclusiveModeEXT", "device");
            vkGetDeviceGroupSurfacePresentModes2EXT = cache.GetCommandDelegate<VkDeviceGetGroupSurfacePresentModes2Delegate>("vkGetDeviceGroupSurfacePresentModes2EXT", "device");
            vkCreateHeadlessSurfaceEXT = cache.GetCommandDelegate<VkInstanceCreateHeadlessSurfaceDelegate>("vkCreateHeadlessSurfaceEXT", "instance");
            vkCmdSetLineStippleEXT = cache.GetCommandDelegate<VkCommandBufferSetLineStippleDelegate>("vkCmdSetLineStippleEXT", "device");
            vkGetPipelineExecutablePropertiesKHR = cache.GetCommandDelegate<VkDeviceGetPipelineExecutablePropertiesDelegate>("vkGetPipelineExecutablePropertiesKHR", "device");
            vkGetPipelineExecutableStatisticsKHR = cache.GetCommandDelegate<VkDeviceGetPipelineExecutableStatisticsDelegate>("vkGetPipelineExecutableStatisticsKHR", "device");
            vkGetPipelineExecutableInternalRepresentationsKHR = cache.GetCommandDelegate<VkDeviceGetPipelineExecutableInternalRepresentationsDelegate>("vkGetPipelineExecutableInternalRepresentationsKHR", "device");
        }
    }
}