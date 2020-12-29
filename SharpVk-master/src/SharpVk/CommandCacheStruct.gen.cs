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
        public readonly VkInstanceCreateDelegate VkCreateInstance;

        /// <summary>
        /// </summary>
        public readonly VkInstanceDestroyDelegate VkDestroyInstance;

        /// <summary>
        /// </summary>
        public readonly VkInstanceEnumeratePhysicalDevicesDelegate VkEnumeratePhysicalDevices;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetFeaturesDelegate VkGetPhysicalDeviceFeatures;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetFormatPropertiesDelegate VkGetPhysicalDeviceFormatProperties;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetImageFormatPropertiesDelegate VkGetPhysicalDeviceImageFormatProperties;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetPropertiesDelegate VkGetPhysicalDeviceProperties;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetQueueFamilyPropertiesDelegate VkGetPhysicalDeviceQueueFamilyProperties;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetMemoryPropertiesDelegate VkGetPhysicalDeviceMemoryProperties;

        /// <summary>
        /// </summary>
        public readonly VkInstanceGetProcedureAddressDelegate VkGetInstanceProcAddr;

        /// <summary>
        /// </summary>
        public readonly VkDeviceGetProcedureAddressDelegate VkGetDeviceProcAddr;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceCreateDeviceDelegate VkCreateDevice;

        /// <summary>
        /// </summary>
        public readonly VkDeviceDestroyDelegate VkDestroyDevice;

        /// <summary>
        /// </summary>
        public readonly VkInstanceEnumerateExtensionPropertiesDelegate VkEnumerateInstanceExtensionProperties;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceEnumerateDeviceExtensionPropertiesDelegate VkEnumerateDeviceExtensionProperties;

        /// <summary>
        /// </summary>
        public readonly VkInstanceEnumerateLayerPropertiesDelegate VkEnumerateInstanceLayerProperties;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceEnumerateDeviceLayerPropertiesDelegate VkEnumerateDeviceLayerProperties;

        /// <summary>
        /// </summary>
        public readonly VkDeviceGetQueueDelegate VkGetDeviceQueue;

        /// <summary>
        /// </summary>
        public readonly VkQueueSubmitDelegate VkQueueSubmit;

        /// <summary>
        /// </summary>
        public readonly VkQueueWaitIdleDelegate VkQueueWaitIdle;

        /// <summary>
        /// </summary>
        public readonly VkDeviceWaitIdleDelegate VkDeviceWaitIdle;

        /// <summary>
        /// </summary>
        public readonly VkDeviceAllocateMemoryDelegate VkAllocateMemory;

        /// <summary>
        /// </summary>
        public readonly VkDeviceMemoryFreeDelegate VkFreeMemory;

        /// <summary>
        /// </summary>
        public readonly VkDeviceMemoryMapDelegate VkMapMemory;

        /// <summary>
        /// </summary>
        public readonly VkDeviceMemoryUnmapDelegate VkUnmapMemory;

        /// <summary>
        /// </summary>
        public readonly VkDeviceFlushMappedMemoryRangesDelegate VkFlushMappedMemoryRanges;

        /// <summary>
        /// </summary>
        public readonly VkDeviceInvalidateMappedMemoryRangesDelegate VkInvalidateMappedMemoryRanges;

        /// <summary>
        /// </summary>
        public readonly VkDeviceMemoryGetCommitmentDelegate VkGetDeviceMemoryCommitment;

        /// <summary>
        /// </summary>
        public readonly VkBufferBindMemoryDelegate VkBindBufferMemory;

        /// <summary>
        /// </summary>
        public readonly VkImageBindMemoryDelegate VkBindImageMemory;

        /// <summary>
        /// </summary>
        public readonly VkBufferGetMemoryRequirementsDelegate VkGetBufferMemoryRequirements;

        /// <summary>
        /// </summary>
        public readonly VkImageGetMemoryRequirementsDelegate VkGetImageMemoryRequirements;

        /// <summary>
        /// </summary>
        public readonly VkImageGetSparseMemoryRequirementsDelegate VkGetImageSparseMemoryRequirements;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetSparseImageFormatPropertiesDelegate VkGetPhysicalDeviceSparseImageFormatProperties;

        /// <summary>
        /// </summary>
        public readonly VkQueueBindSparseDelegate VkQueueBindSparse;

        /// <summary>
        /// </summary>
        public readonly VkDeviceCreateFenceDelegate VkCreateFence;

        /// <summary>
        /// </summary>
        public readonly VkFenceDestroyDelegate VkDestroyFence;

        /// <summary>
        /// </summary>
        public readonly VkDeviceResetFencesDelegate VkResetFences;

        /// <summary>
        /// </summary>
        public readonly VkFenceGetStatusDelegate VkGetFenceStatus;

        /// <summary>
        /// </summary>
        public readonly VkDeviceWaitForFencesDelegate VkWaitForFences;

        /// <summary>
        /// </summary>
        public readonly VkDeviceCreateSemaphoreDelegate VkCreateSemaphore;

        /// <summary>
        /// </summary>
        public readonly VkSemaphoreDestroyDelegate VkDestroySemaphore;

        /// <summary>
        /// </summary>
        public readonly VkDeviceCreateEventDelegate VkCreateEvent;

        /// <summary>
        /// </summary>
        public readonly VkEventDestroyDelegate VkDestroyEvent;

        /// <summary>
        /// </summary>
        public readonly VkEventGetStatusDelegate VkGetEventStatus;

        /// <summary>
        /// </summary>
        public readonly VkEventSetDelegate VkSetEvent;

        /// <summary>
        /// </summary>
        public readonly VkEventResetDelegate VkResetEvent;

        /// <summary>
        /// </summary>
        public readonly VkDeviceCreateQueryPoolDelegate VkCreateQueryPool;

        /// <summary>
        /// </summary>
        public readonly VkQueryPoolDestroyDelegate VkDestroyQueryPool;

        /// <summary>
        /// </summary>
        public readonly VkQueryPoolGetResultsDelegate VkGetQueryPoolResults;

        /// <summary>
        /// </summary>
        public readonly VkDeviceCreateBufferDelegate VkCreateBuffer;

        /// <summary>
        /// </summary>
        public readonly VkBufferDestroyDelegate VkDestroyBuffer;

        /// <summary>
        /// </summary>
        public readonly VkDeviceCreateBufferViewDelegate VkCreateBufferView;

        /// <summary>
        /// </summary>
        public readonly VkBufferViewDestroyDelegate VkDestroyBufferView;

        /// <summary>
        /// </summary>
        public readonly VkDeviceCreateImageDelegate VkCreateImage;

        /// <summary>
        /// </summary>
        public readonly VkImageDestroyDelegate VkDestroyImage;

        /// <summary>
        /// </summary>
        public readonly VkImageGetSubresourceLayoutDelegate VkGetImageSubresourceLayout;

        /// <summary>
        /// </summary>
        public readonly VkDeviceCreateImageViewDelegate VkCreateImageView;

        /// <summary>
        /// </summary>
        public readonly VkImageViewDestroyDelegate VkDestroyImageView;

        /// <summary>
        /// </summary>
        public readonly VkDeviceCreateShaderModuleDelegate VkCreateShaderModule;

        /// <summary>
        /// </summary>
        public readonly VkShaderModuleDestroyDelegate VkDestroyShaderModule;

        /// <summary>
        /// </summary>
        public readonly VkDeviceCreatePipelineCacheDelegate VkCreatePipelineCache;

        /// <summary>
        /// </summary>
        public readonly VkPipelineCacheDestroyDelegate VkDestroyPipelineCache;

        /// <summary>
        /// </summary>
        public readonly VkPipelineCacheGetDataDelegate VkGetPipelineCacheData;

        /// <summary>
        /// </summary>
        public readonly VkPipelineCacheMergePipelineCachesDelegate VkMergePipelineCaches;

        /// <summary>
        /// </summary>
        public readonly VkDeviceCreateGraphicsPipelinesDelegate VkCreateGraphicsPipelines;

        /// <summary>
        /// </summary>
        public readonly VkDeviceCreateComputePipelinesDelegate VkCreateComputePipelines;

        /// <summary>
        /// </summary>
        public readonly VkPipelineDestroyDelegate VkDestroyPipeline;

        /// <summary>
        /// </summary>
        public readonly VkDeviceCreatePipelineLayoutDelegate VkCreatePipelineLayout;

        /// <summary>
        /// </summary>
        public readonly VkPipelineLayoutDestroyDelegate VkDestroyPipelineLayout;

        /// <summary>
        /// </summary>
        public readonly VkDeviceCreateSamplerDelegate VkCreateSampler;

        /// <summary>
        /// </summary>
        public readonly VkSamplerDestroyDelegate VkDestroySampler;

        /// <summary>
        /// </summary>
        public readonly VkDeviceCreateDescriptorSetLayoutDelegate VkCreateDescriptorSetLayout;

        /// <summary>
        /// </summary>
        public readonly VkDescriptorSetLayoutDestroyDelegate VkDestroyDescriptorSetLayout;

        /// <summary>
        /// </summary>
        public readonly VkDeviceCreateDescriptorPoolDelegate VkCreateDescriptorPool;

        /// <summary>
        /// </summary>
        public readonly VkDescriptorPoolDestroyDelegate VkDestroyDescriptorPool;

        /// <summary>
        /// </summary>
        public readonly VkDescriptorPoolResetDelegate VkResetDescriptorPool;

        /// <summary>
        /// </summary>
        public readonly VkDeviceAllocateDescriptorSetsDelegate VkAllocateDescriptorSets;

        /// <summary>
        /// </summary>
        public readonly VkDescriptorPoolFreeDescriptorSetsDelegate VkFreeDescriptorSets;

        /// <summary>
        /// </summary>
        public readonly VkDeviceUpdateDescriptorSetsDelegate VkUpdateDescriptorSets;

        /// <summary>
        /// </summary>
        public readonly VkDeviceCreateFramebufferDelegate VkCreateFramebuffer;

        /// <summary>
        /// </summary>
        public readonly VkFramebufferDestroyDelegate VkDestroyFramebuffer;

        /// <summary>
        /// </summary>
        public readonly VkDeviceCreateRenderPassDelegate VkCreateRenderPass;

        /// <summary>
        /// </summary>
        public readonly VkRenderPassDestroyDelegate VkDestroyRenderPass;

        /// <summary>
        /// </summary>
        public readonly VkRenderPassGetRenderAreaGranularityDelegate VkGetRenderAreaGranularity;

        /// <summary>
        /// </summary>
        public readonly VkDeviceCreateCommandPoolDelegate VkCreateCommandPool;

        /// <summary>
        /// </summary>
        public readonly VkCommandPoolDestroyDelegate VkDestroyCommandPool;

        /// <summary>
        /// </summary>
        public readonly VkCommandPoolResetDelegate VkResetCommandPool;

        /// <summary>
        /// </summary>
        public readonly VkDeviceAllocateCommandBuffersDelegate VkAllocateCommandBuffers;

        /// <summary>
        /// </summary>
        public readonly VkCommandPoolFreeCommandBuffersDelegate VkFreeCommandBuffers;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferBeginDelegate VkBeginCommandBuffer;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferEndDelegate VkEndCommandBuffer;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferResetDelegate VkResetCommandBuffer;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferBindPipelineDelegate VkCmdBindPipeline;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferSetViewportDelegate VkCmdSetViewport;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferSetScissorDelegate VkCmdSetScissor;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferSetLineWidthDelegate VkCmdSetLineWidth;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferSetDepthBiasDelegate VkCmdSetDepthBias;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferSetBlendConstantsDelegate VkCmdSetBlendConstants;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferSetDepthBoundsDelegate VkCmdSetDepthBounds;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferSetStencilCompareMaskDelegate VkCmdSetStencilCompareMask;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferSetStencilWriteMaskDelegate VkCmdSetStencilWriteMask;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferSetStencilReferenceDelegate VkCmdSetStencilReference;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferBindDescriptorSetsDelegate VkCmdBindDescriptorSets;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferBindIndexBufferDelegate VkCmdBindIndexBuffer;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferBindVertexBuffersDelegate VkCmdBindVertexBuffers;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferDrawDelegate VkCmdDraw;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferDrawIndexedDelegate VkCmdDrawIndexed;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferDrawIndirectDelegate VkCmdDrawIndirect;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferDrawIndexedIndirectDelegate VkCmdDrawIndexedIndirect;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferDispatchDelegate VkCmdDispatch;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferDispatchIndirectDelegate VkCmdDispatchIndirect;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferCopyBufferDelegate VkCmdCopyBuffer;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferCopyImageDelegate VkCmdCopyImage;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferBlitImageDelegate VkCmdBlitImage;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferCopyBufferToImageDelegate VkCmdCopyBufferToImage;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferCopyImageToBufferDelegate VkCmdCopyImageToBuffer;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferUpdateBufferDelegate VkCmdUpdateBuffer;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferFillBufferDelegate VkCmdFillBuffer;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferClearColorImageDelegate VkCmdClearColorImage;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferClearDepthStencilImageDelegate VkCmdClearDepthStencilImage;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferClearAttachmentsDelegate VkCmdClearAttachments;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferResolveImageDelegate VkCmdResolveImage;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferSetEventDelegate VkCmdSetEvent;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferResetEventDelegate VkCmdResetEvent;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferWaitEventsDelegate VkCmdWaitEvents;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferPipelineBarrierDelegate VkCmdPipelineBarrier;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferBeginQueryDelegate VkCmdBeginQuery;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferEndQueryDelegate VkCmdEndQuery;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferResetQueryPoolDelegate VkCmdResetQueryPool;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferWriteTimestampDelegate VkCmdWriteTimestamp;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferCopyQueryPoolResultsDelegate VkCmdCopyQueryPoolResults;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferPushConstantsDelegate VkCmdPushConstants;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferBeginRenderPassDelegate VkCmdBeginRenderPass;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferNextSubpassDelegate VkCmdNextSubpass;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferEndRenderPassDelegate VkCmdEndRenderPass;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferExecuteCommandsDelegate VkCmdExecuteCommands;

        /// <summary>
        /// </summary>
        public readonly VkInstanceEnumerateVersionDelegate VkEnumerateInstanceVersion;

        /// <summary>
        /// </summary>
        public readonly VkDeviceBindBufferMemory2Delegate VkBindBufferMemory2;

        /// <summary>
        /// </summary>
        public readonly VkDeviceBindImageMemory2Delegate VkBindImageMemory2;

        /// <summary>
        /// </summary>
        public readonly VkDeviceGetGroupPeerMemoryFeaturesDelegate VkGetDeviceGroupPeerMemoryFeatures;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferSetDeviceMaskDelegate VkCmdSetDeviceMask;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferDispatchBaseDelegate VkCmdDispatchBase;

        /// <summary>
        /// </summary>
        public readonly VkInstanceEnumeratePhysicalDeviceGroupsDelegate VkEnumeratePhysicalDeviceGroups;

        /// <summary>
        /// </summary>
        public readonly VkDeviceGetImageMemoryRequirements2Delegate VkGetImageMemoryRequirements2;

        /// <summary>
        /// </summary>
        public readonly VkDeviceGetBufferMemoryRequirements2Delegate VkGetBufferMemoryRequirements2;

        /// <summary>
        /// </summary>
        public readonly VkDeviceGetImageSparseMemoryRequirements2Delegate VkGetImageSparseMemoryRequirements2;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetFeatures2Delegate VkGetPhysicalDeviceFeatures2;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetProperties2Delegate VkGetPhysicalDeviceProperties2;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetFormatProperties2Delegate VkGetPhysicalDeviceFormatProperties2;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetImageFormatProperties2Delegate VkGetPhysicalDeviceImageFormatProperties2;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetQueueFamilyProperties2Delegate VkGetPhysicalDeviceQueueFamilyProperties2;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetMemoryProperties2Delegate VkGetPhysicalDeviceMemoryProperties2;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetSparseImageFormatProperties2Delegate VkGetPhysicalDeviceSparseImageFormatProperties2;

        /// <summary>
        /// </summary>
        public readonly VkCommandPoolTrimDelegate VkTrimCommandPool;

        /// <summary>
        /// </summary>
        public readonly VkDeviceGetQueue2Delegate VkGetDeviceQueue2;

        /// <summary>
        /// </summary>
        public readonly VkDeviceCreateSamplerYcbcrConversionDelegate VkCreateSamplerYcbcrConversion;

        /// <summary>
        /// </summary>
        public readonly VkSamplerYcbcrConversionDestroyDelegate VkDestroySamplerYcbcrConversion;

        /// <summary>
        /// </summary>
        public readonly VkDeviceCreateDescriptorUpdateTemplateDelegate VkCreateDescriptorUpdateTemplate;

        /// <summary>
        /// </summary>
        public readonly VkDescriptorUpdateTemplateDestroyDelegate VkDestroyDescriptorUpdateTemplate;

        /// <summary>
        /// </summary>
        public readonly VkDeviceUpdateDescriptorSetWithTemplateDelegate VkUpdateDescriptorSetWithTemplate;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetExternalBufferPropertiesDelegate VkGetPhysicalDeviceExternalBufferProperties;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetExternalFencePropertiesDelegate VkGetPhysicalDeviceExternalFenceProperties;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetExternalSemaphorePropertiesDelegate VkGetPhysicalDeviceExternalSemaphoreProperties;

        /// <summary>
        /// </summary>
        public readonly VkDeviceGetDescriptorSetLayoutSupportDelegate VkGetDescriptorSetLayoutSupport;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferDrawIndirectCountDelegate VkCmdDrawIndirectCount;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferDrawIndexedIndirectCountDelegate VkCmdDrawIndexedIndirectCount;

        /// <summary>
        /// </summary>
        public readonly VkDeviceCreateRenderPass2Delegate VkCreateRenderPass2;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferBeginRenderPass2Delegate VkCmdBeginRenderPass2;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferNextSubpass2Delegate VkCmdNextSubpass2;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferEndRenderPass2Delegate VkCmdEndRenderPass2;

        /// <summary>
        /// </summary>
        public readonly VkQueryPoolResetDelegate VkResetQueryPool;

        /// <summary>
        /// </summary>
        public readonly VkSemaphoreGetCounterValueDelegate VkGetSemaphoreCounterValue;

        /// <summary>
        /// </summary>
        public readonly VkDeviceWaitSemaphoresDelegate VkWaitSemaphores;

        /// <summary>
        /// </summary>
        public readonly VkDeviceSignalSemaphoreDelegate VkSignalSemaphore;

        /// <summary>
        /// </summary>
        public readonly VkDeviceGetBufferDeviceAddressDelegate VkGetBufferDeviceAddress;

        /// <summary>
        /// </summary>
        public readonly VkDeviceGetBufferOpaqueCaptureAddressDelegate VkGetBufferOpaqueCaptureAddress;

        /// <summary>
        /// </summary>
        public readonly VkDeviceGetMemoryOpaqueCaptureAddressDelegate VkGetDeviceMemoryOpaqueCaptureAddress;

        /// <summary>
        /// </summary>
        public readonly VkSurfaceKhrDestroyDelegate VkDestroySurfaceKhr;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetSurfaceSupportDelegate VkGetPhysicalDeviceSurfaceSupportKhr;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetSurfaceCapabilitiesDelegate VkGetPhysicalDeviceSurfaceCapabilitiesKhr;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetSurfaceFormatsDelegate VkGetPhysicalDeviceSurfaceFormatsKhr;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetSurfacePresentModesDelegate VkGetPhysicalDeviceSurfacePresentModesKhr;

        /// <summary>
        /// </summary>
        public readonly VkDeviceCreateSwapchainDelegate VkCreateSwapchainKhr;

        /// <summary>
        /// </summary>
        public readonly VkSwapchainKhrDestroyDelegate VkDestroySwapchainKhr;

        /// <summary>
        /// </summary>
        public readonly VkSwapchainKhrGetImagesDelegate VkGetSwapchainImagesKhr;

        /// <summary>
        /// </summary>
        public readonly VkSwapchainKhrAcquireNextImageDelegate VkAcquireNextImageKhr;

        /// <summary>
        /// </summary>
        public readonly VkQueuePresentDelegate VkQueuePresentKhr;

        /// <summary>
        /// </summary>
        public readonly VkDeviceGetGroupPresentCapabilitiesDelegate VkGetDeviceGroupPresentCapabilitiesKhr;

        /// <summary>
        /// </summary>
        public readonly VkDeviceGetGroupSurfacePresentModesDelegate VkGetDeviceGroupSurfacePresentModesKhr;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetPresentRectanglesDelegate VkGetPhysicalDevicePresentRectanglesKhr;

        /// <summary>
        /// </summary>
        public readonly VkDeviceAcquireNextImage2Delegate VkAcquireNextImage2Khr;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetDisplayPropertiesDelegate VkGetPhysicalDeviceDisplayPropertiesKhr;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetDisplayPlanePropertiesDelegate VkGetPhysicalDeviceDisplayPlanePropertiesKhr;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetDisplayPlaneSupportedDisplaysDelegate VkGetDisplayPlaneSupportedDisplaysKhr;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetDisplayModePropertiesDelegate VkGetDisplayModePropertiesKhr;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceCreateDisplayModeDelegate VkCreateDisplayModeKhr;

        /// <summary>
        /// </summary>
        public readonly VkDisplayModeKhrGetDisplayPlaneCapabilitiesDelegate VkGetDisplayPlaneCapabilitiesKhr;

        /// <summary>
        /// </summary>
        public readonly VkInstanceCreateDisplayPlaneSurfaceDelegate VkCreateDisplayPlaneSurfaceKhr;

        /// <summary>
        /// </summary>
        public readonly VkDeviceCreateSharedSwapchainsDelegate VkCreateSharedSwapchainsKhr;

        /// <summary>
        /// </summary>
        public readonly VkInstanceCreateXlibSurfaceDelegate VkCreateXlibSurfaceKhr;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetXlibPresentationSupportDelegate VkGetPhysicalDeviceXlibPresentationSupportKhr;

        /// <summary>
        /// </summary>
        public readonly VkInstanceCreateXcbSurfaceDelegate VkCreateXcbSurfaceKhr;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetXcbPresentationSupportDelegate VkGetPhysicalDeviceXcbPresentationSupportKhr;

        /// <summary>
        /// </summary>
        public readonly VkInstanceCreateWaylandSurfaceDelegate VkCreateWaylandSurfaceKhr;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetWaylandPresentationSupportDelegate VkGetPhysicalDeviceWaylandPresentationSupportKhr;

        /// <summary>
        /// </summary>
        public readonly VkInstanceCreateAndroidSurfaceDelegate VkCreateAndroidSurfaceKhr;

        /// <summary>
        /// </summary>
        public readonly VkInstanceCreateWin32SurfaceDelegate VkCreateWin32SurfaceKhr;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetWin32PresentationSupportDelegate VkGetPhysicalDeviceWin32PresentationSupportKhr;

        /// <summary>
        /// </summary>
        public readonly VkInstanceCreateDebugReportCallbackDelegate VkCreateDebugReportCallbackExt;

        /// <summary>
        /// </summary>
        public readonly VkDebugReportCallbackExtDestroyDelegate VkDestroyDebugReportCallbackExt;

        /// <summary>
        /// </summary>
        public readonly VkInstanceDebugReportMessageDelegate VkDebugReportMessageExt;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferBindTransformFeedbackBuffersDelegate VkCmdBindTransformFeedbackBuffersExt;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferBeginTransformFeedbackDelegate VkCmdBeginTransformFeedbackExt;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferEndTransformFeedbackDelegate VkCmdEndTransformFeedbackExt;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferBeginQueryIndexedDelegate VkCmdBeginQueryIndexedExt;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferEndQueryIndexedDelegate VkCmdEndQueryIndexedExt;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferDrawIndirectByteCountDelegate VkCmdDrawIndirectByteCountExt;

        /// <summary>
        /// </summary>
        public readonly VkDeviceGetImageViewHandleDelegate VkGetImageViewHandleNvx;

        /// <summary>
        /// </summary>
        public readonly VkPipelineGetShaderInfoDelegate VkGetShaderInfoAmd;

        /// <summary>
        /// </summary>
        public readonly VkInstanceCreateStreamDescriptorSurfaceDelegate VkCreateStreamDescriptorSurfaceGgp;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetExternalImageFormatPropertiesDelegate VkGetPhysicalDeviceExternalImageFormatPropertiesNv;

        /// <summary>
        /// </summary>
        public readonly VkDeviceMemoryGetWin32HandleDelegate VkGetMemoryWin32HandleNv;

        /// <summary>
        /// </summary>
        public readonly VkInstanceCreateViSurfaceDelegate VkCreateViSurfaceNn;

        /// <summary>
        /// </summary>
        public readonly VkDeviceGetMemoryWin32HandleDelegate VkGetMemoryWin32HandleKhr;

        /// <summary>
        /// </summary>
        public readonly VkDeviceGetMemoryWin32HandlePropertiesDelegate VkGetMemoryWin32HandlePropertiesKhr;

        /// <summary>
        /// </summary>
        public readonly VkDeviceGetMemoryFileDescriptorDelegate VkGetMemoryFdKhr;

        /// <summary>
        /// </summary>
        public readonly VkDeviceGetMemoryFileDescriptorPropertiesDelegate VkGetMemoryFdPropertiesKhr;

        /// <summary>
        /// </summary>
        public readonly VkDeviceImportSemaphoreWin32HandleDelegate VkImportSemaphoreWin32HandleKhr;

        /// <summary>
        /// </summary>
        public readonly VkDeviceGetSemaphoreWin32HandleDelegate VkGetSemaphoreWin32HandleKhr;

        /// <summary>
        /// </summary>
        public readonly VkDeviceImportSemaphoreFileDescriptorDelegate VkImportSemaphoreFdKhr;

        /// <summary>
        /// </summary>
        public readonly VkDeviceGetSemaphoreFileDescriptorDelegate VkGetSemaphoreFdKhr;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferPushDescriptorSetDelegate VkCmdPushDescriptorSetKhr;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferPushDescriptorSetWithTemplateDelegate VkCmdPushDescriptorSetWithTemplateKhr;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferBeginConditionalRenderingDelegate VkCmdBeginConditionalRenderingExt;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferEndConditionalRenderingDelegate VkCmdEndConditionalRenderingExt;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferProcessCommandsDelegate VkCmdProcessCommandsNvx;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferReserveSpaceForCommandsDelegate VkCmdReserveSpaceForCommandsNvx;

        /// <summary>
        /// </summary>
        public readonly VkDeviceCreateIndirectCommandsLayoutDelegate VkCreateIndirectCommandsLayoutNvx;

        /// <summary>
        /// </summary>
        public readonly VkIndirectCommandsLayoutNvxDestroyDelegate VkDestroyIndirectCommandsLayoutNvx;

        /// <summary>
        /// </summary>
        public readonly VkDeviceCreateObjectTableDelegate VkCreateObjectTableNvx;

        /// <summary>
        /// </summary>
        public readonly VkObjectTableNvxDestroyDelegate VkDestroyObjectTableNvx;

        /// <summary>
        /// </summary>
        public readonly VkObjectTableNvxRegisterObjectsDelegate VkRegisterObjectsNvx;

        /// <summary>
        /// </summary>
        public readonly VkObjectTableNvxUnregisterObjectsDelegate VkUnregisterObjectsNvx;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetGeneratedCommandsPropertiesDelegate VkGetPhysicalDeviceGeneratedCommandsPropertiesNvx;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferSetViewportWScalingDelegate VkCmdSetViewportWScalingNv;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceReleaseDisplayDelegate VkReleaseDisplayExt;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceAcquireXlibDisplayDelegate VkAcquireXlibDisplayExt;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetRandROutputDisplayDelegate VkGetRandROutputDisplayExt;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetSurfaceCapabilities2Delegate VkGetPhysicalDeviceSurfaceCapabilities2Ext;

        /// <summary>
        /// </summary>
        public readonly VkDeviceDisplayPowerControlDelegate VkDisplayPowerControlExt;

        /// <summary>
        /// </summary>
        public readonly VkDeviceRegisterEventDelegate VkRegisterDeviceEventExt;

        /// <summary>
        /// </summary>
        public readonly VkDeviceRegisterDisplayEventDelegate VkRegisterDisplayEventExt;

        /// <summary>
        /// </summary>
        public readonly VkSwapchainKhrGetCounterDelegate VkGetSwapchainCounterExt;

        /// <summary>
        /// </summary>
        public readonly VkSwapchainKhrGetRefreshCycleDurationDelegate VkGetRefreshCycleDurationGoogle;

        /// <summary>
        /// </summary>
        public readonly VkSwapchainKhrGetPastPresentationTimingDelegate VkGetPastPresentationTimingGoogle;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferSetDiscardRectangleDelegate VkCmdSetDiscardRectangleExt;

        /// <summary>
        /// </summary>
        public readonly VkDeviceSetHdrMetadataDelegate VkSetHdrMetadataExt;

        /// <summary>
        /// </summary>
        public readonly VkSwapchainKhrGetStatusDelegate VkGetSwapchainStatusKhr;

        /// <summary>
        /// </summary>
        public readonly VkDeviceImportFenceWin32HandleDelegate VkImportFenceWin32HandleKhr;

        /// <summary>
        /// </summary>
        public readonly VkDeviceGetFenceWin32HandleDelegate VkGetFenceWin32HandleKhr;

        /// <summary>
        /// </summary>
        public readonly VkDeviceImportFenceFileDescriptorDelegate VkImportFenceFdKhr;

        /// <summary>
        /// </summary>
        public readonly VkDeviceGetFenceFileDescriptorDelegate VkGetFenceFdKhr;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceEnumerateQueueFamilyPerformanceQueryCountersDelegate VkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKhr;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetQueueFamilyPerformanceQueryPassesDelegate VkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKhr;

        /// <summary>
        /// </summary>
        public readonly VkDeviceAcquireProfilingLockDelegate VkAcquireProfilingLockKhr;

        /// <summary>
        /// </summary>
        public readonly VkDeviceReleaseProfilingLockDelegate VkReleaseProfilingLockKhr;

        /// <summary>
        /// </summary>
        public readonly Interop.Khronos.VkPhysicalDeviceGetSurfaceCapabilities2Delegate VkGetPhysicalDeviceSurfaceCapabilities2Khr;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetSurfaceFormats2Delegate VkGetPhysicalDeviceSurfaceFormats2Khr;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetDisplayProperties2Delegate VkGetPhysicalDeviceDisplayProperties2Khr;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetDisplayPlaneProperties2Delegate VkGetPhysicalDeviceDisplayPlaneProperties2Khr;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetDisplayModeProperties2Delegate VkGetDisplayModeProperties2Khr;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetDisplayPlaneCapabilities2Delegate VkGetDisplayPlaneCapabilities2Khr;

        /// <summary>
        /// </summary>
        public readonly VkInstanceCreateIosSurfaceDelegate VkCreateIosSurfaceMvk;

        /// <summary>
        /// </summary>
        public readonly VkInstanceCreateMacOsSurfaceDelegate VkCreateMacOsSurfaceMvk;

        /// <summary>
        /// </summary>
        public readonly VkDeviceSetDebugUtilsObjectNameDelegate VkSetDebugUtilsObjectNameExt;

        /// <summary>
        /// </summary>
        public readonly VkDeviceSetDebugUtilsObjectTagDelegate VkSetDebugUtilsObjectTagExt;

        /// <summary>
        /// </summary>
        public readonly VkQueueBeginDebugUtilsLabelDelegate VkQueueBeginDebugUtilsLabelExt;

        /// <summary>
        /// </summary>
        public readonly VkQueueEndDebugUtilsLabelDelegate VkQueueEndDebugUtilsLabelExt;

        /// <summary>
        /// </summary>
        public readonly VkQueueInsertDebugUtilsLabelDelegate VkQueueInsertDebugUtilsLabelExt;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferBeginDebugUtilsLabelDelegate VkCmdBeginDebugUtilsLabelExt;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferEndDebugUtilsLabelDelegate VkCmdEndDebugUtilsLabelExt;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferInsertDebugUtilsLabelDelegate VkCmdInsertDebugUtilsLabelExt;

        /// <summary>
        /// </summary>
        public readonly VkInstanceCreateDebugUtilsMessengerDelegate VkCreateDebugUtilsMessengerExt;

        /// <summary>
        /// </summary>
        public readonly VkDebugUtilsMessengerExtDestroyDelegate VkDestroyDebugUtilsMessengerExt;

        /// <summary>
        /// </summary>
        public readonly VkInstanceSubmitDebugUtilsMessageDelegate VkSubmitDebugUtilsMessageExt;

        /// <summary>
        /// </summary>
        public readonly VkDeviceGetAndroidHardwareBufferPropertiesDelegate VkGetAndroidHardwareBufferPropertiesAndroid;

        /// <summary>
        /// </summary>
        public readonly VkDeviceGetMemoryAndroidHardwareBufferDelegate VkGetMemoryAndroidHardwareBufferAndroid;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferSetSampleLocationsDelegate VkCmdSetSampleLocationsExt;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetMultisamplePropertiesDelegate VkGetPhysicalDeviceMultisamplePropertiesExt;

        /// <summary>
        /// </summary>
        public readonly VkImageGetDrmFormatModifierPropertiesDelegate VkGetImageDrmFormatModifierPropertiesExt;

        /// <summary>
        /// </summary>
        public readonly VkDeviceCreateValidationCacheDelegate VkCreateValidationCacheExt;

        /// <summary>
        /// </summary>
        public readonly VkValidationCacheExtDestroyDelegate VkDestroyValidationCacheExt;

        /// <summary>
        /// </summary>
        public readonly VkValidationCacheExtMergeValidationCachesDelegate VkMergeValidationCachesExt;

        /// <summary>
        /// </summary>
        public readonly VkValidationCacheExtGetDataDelegate VkGetValidationCacheDataExt;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferBindShadingRateImageDelegate VkCmdBindShadingRateImageNv;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferSetViewportShadingRatePaletteDelegate VkCmdSetViewportShadingRatePaletteNv;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferSetCoarseSampleOrderDelegate VkCmdSetCoarseSampleOrderNv;

        /// <summary>
        /// </summary>
        public readonly VkDeviceCreateAccelerationStructureDelegate VkCreateAccelerationStructureNv;

        /// <summary>
        /// </summary>
        public readonly VkAccelerationStructureNvDestroyDelegate VkDestroyAccelerationStructureNv;

        /// <summary>
        /// </summary>
        public readonly VkDeviceGetAccelerationStructureMemoryRequirementsDelegate VkGetAccelerationStructureMemoryRequirementsNv;

        /// <summary>
        /// </summary>
        public readonly VkDeviceBindAccelerationStructureMemoryDelegate VkBindAccelerationStructureMemoryNv;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferBuildAccelerationStructureDelegate VkCmdBuildAccelerationStructureNv;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferCopyAccelerationStructureDelegate VkCmdCopyAccelerationStructureNv;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferTraceRaysDelegate VkCmdTraceRaysNv;

        /// <summary>
        /// </summary>
        public readonly VkDeviceCreateRayTracingPipelinesDelegate VkCreateRayTracingPipelinesNv;

        /// <summary>
        /// </summary>
        public readonly VkPipelineGetRayTracingShaderGroupHandlesDelegate VkGetRayTracingShaderGroupHandlesNv;

        /// <summary>
        /// </summary>
        public readonly VkAccelerationStructureNvGetHandleDelegate VkGetAccelerationStructureHandleNv;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferWriteAccelerationStructuresPropertiesDelegate VkCmdWriteAccelerationStructuresPropertiesNv;

        /// <summary>
        /// </summary>
        public readonly VkPipelineCompileDeferredDelegate VkCompileDeferredNv;

        /// <summary>
        /// </summary>
        public readonly VkDeviceGetMemoryHostPointerPropertiesDelegate VkGetMemoryHostPointerPropertiesExt;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferWriteBufferMarkerDelegate VkCmdWriteBufferMarkerAmd;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetCalibrateableTimeDomainsDelegate VkGetPhysicalDeviceCalibrateableTimeDomainsExt;

        /// <summary>
        /// </summary>
        public readonly VkDeviceGetCalibratedTimestampsDelegate VkGetCalibratedTimestampsExt;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferDrawMeshTasksDelegate VkCmdDrawMeshTasksNv;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferDrawMeshTasksIndirectDelegate VkCmdDrawMeshTasksIndirectNv;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferDrawMeshTasksIndirectCountDelegate VkCmdDrawMeshTasksIndirectCountNv;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferSetExclusiveScissorDelegate VkCmdSetExclusiveScissorNv;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferSetCheckpointDelegate VkCmdSetCheckpointNv;

        /// <summary>
        /// </summary>
        public readonly VkQueueGetCheckpointDataDelegate VkGetQueueCheckpointDataNv;

        /// <summary>
        /// </summary>
        public readonly VkDeviceInitializePerformanceApiDelegate VkInitializePerformanceApiIntel;

        /// <summary>
        /// </summary>
        public readonly VkDeviceUninitializePerformanceApiDelegate VkUninitializePerformanceApiIntel;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferSetPerformanceMarkerDelegate VkCmdSetPerformanceMarkerIntel;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferSetPerformanceStreamMarkerDelegate VkCmdSetPerformanceStreamMarkerIntel;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferSetPerformanceOverrideDelegate VkCmdSetPerformanceOverrideIntel;

        /// <summary>
        /// </summary>
        public readonly VkDeviceAcquirePerformanceConfigurationDelegate VkAcquirePerformanceConfigurationIntel;

        /// <summary>
        /// </summary>
        public readonly VkPerformanceConfigurationIntelReleaseDelegate VkReleasePerformanceConfigurationIntel;

        /// <summary>
        /// </summary>
        public readonly VkQueueSetPerformanceConfigurationDelegate VkQueueSetPerformanceConfigurationIntel;

        /// <summary>
        /// </summary>
        public readonly VkDeviceGetPerformanceParameterDelegate VkGetPerformanceParameterIntel;

        /// <summary>
        /// </summary>
        public readonly VkSwapchainKhrSetLocalDimmingDelegate VkSetLocalDimmingAmd;

        /// <summary>
        /// </summary>
        public readonly VkInstanceCreateImagePipeSurfaceDelegate VkCreateImagePipeSurfaceFuchsia;

        /// <summary>
        /// </summary>
        public readonly VkInstanceCreateMetalSurfaceDelegate VkCreateMetalSurfaceExt;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetToolPropertiesDelegate VkGetPhysicalDeviceToolPropertiesExt;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetCooperativeMatrixPropertiesDelegate VkGetPhysicalDeviceCooperativeMatrixPropertiesNv;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetSupportedFramebufferMixedSamplesCombinationsDelegate VkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNv;

        /// <summary>
        /// </summary>
        public readonly VkPhysicalDeviceGetSurfacePresentModes2Delegate VkGetPhysicalDeviceSurfacePresentModes2Ext;

        /// <summary>
        /// </summary>
        public readonly VkSwapchainKhrAcquireFullScreenExclusiveModeDelegate VkAcquireFullScreenExclusiveModeExt;

        /// <summary>
        /// </summary>
        public readonly VkSwapchainKhrReleaseFullScreenExclusiveModeDelegate VkReleaseFullScreenExclusiveModeExt;

        /// <summary>
        /// </summary>
        public readonly VkDeviceGetGroupSurfacePresentModes2Delegate VkGetDeviceGroupSurfacePresentModes2Ext;

        /// <summary>
        /// </summary>
        public readonly VkInstanceCreateHeadlessSurfaceDelegate VkCreateHeadlessSurfaceExt;

        /// <summary>
        /// </summary>
        public readonly VkCommandBufferSetLineStippleDelegate VkCmdSetLineStippleExt;

        /// <summary>
        /// </summary>
        public readonly VkDeviceGetPipelineExecutablePropertiesDelegate VkGetPipelineExecutablePropertiesKhr;

        /// <summary>
        /// </summary>
        public readonly VkDeviceGetPipelineExecutableStatisticsDelegate VkGetPipelineExecutableStatisticsKhr;

        /// <summary>
        /// </summary>
        public readonly VkDeviceGetPipelineExecutableInternalRepresentationsDelegate VkGetPipelineExecutableInternalRepresentationsKhr;

        /// <summary>
        /// </summary>
        public CommandCacheStruct(CommandCache cache)
        {
            VkCreateInstance = cache.GetCommandDelegate<VkInstanceCreateDelegate>("vkCreateInstance", "");
            VkDestroyInstance = cache.GetCommandDelegate<VkInstanceDestroyDelegate>("vkDestroyInstance", "");
            VkEnumeratePhysicalDevices = cache.GetCommandDelegate<VkInstanceEnumeratePhysicalDevicesDelegate>("vkEnumeratePhysicalDevices", "");
            VkGetPhysicalDeviceFeatures = cache.GetCommandDelegate<VkPhysicalDeviceGetFeaturesDelegate>("vkGetPhysicalDeviceFeatures", "");
            VkGetPhysicalDeviceFormatProperties = cache.GetCommandDelegate<VkPhysicalDeviceGetFormatPropertiesDelegate>("vkGetPhysicalDeviceFormatProperties", "");
            VkGetPhysicalDeviceImageFormatProperties = cache.GetCommandDelegate<VkPhysicalDeviceGetImageFormatPropertiesDelegate>("vkGetPhysicalDeviceImageFormatProperties", "");
            VkGetPhysicalDeviceProperties = cache.GetCommandDelegate<VkPhysicalDeviceGetPropertiesDelegate>("vkGetPhysicalDeviceProperties", "");
            VkGetPhysicalDeviceQueueFamilyProperties = cache.GetCommandDelegate<VkPhysicalDeviceGetQueueFamilyPropertiesDelegate>("vkGetPhysicalDeviceQueueFamilyProperties", "");
            VkGetPhysicalDeviceMemoryProperties = cache.GetCommandDelegate<VkPhysicalDeviceGetMemoryPropertiesDelegate>("vkGetPhysicalDeviceMemoryProperties", "");
            VkGetInstanceProcAddr = cache.GetCommandDelegate<VkInstanceGetProcedureAddressDelegate>("vkGetInstanceProcAddr", "");
            VkGetDeviceProcAddr = cache.GetCommandDelegate<VkDeviceGetProcedureAddressDelegate>("vkGetDeviceProcAddr", "");
            VkCreateDevice = cache.GetCommandDelegate<VkPhysicalDeviceCreateDeviceDelegate>("vkCreateDevice", "");
            VkDestroyDevice = cache.GetCommandDelegate<VkDeviceDestroyDelegate>("vkDestroyDevice", "");
            VkEnumerateInstanceExtensionProperties = cache.GetCommandDelegate<VkInstanceEnumerateExtensionPropertiesDelegate>("vkEnumerateInstanceExtensionProperties", "");
            VkEnumerateDeviceExtensionProperties = cache.GetCommandDelegate<VkPhysicalDeviceEnumerateDeviceExtensionPropertiesDelegate>("vkEnumerateDeviceExtensionProperties", "");
            VkEnumerateInstanceLayerProperties = cache.GetCommandDelegate<VkInstanceEnumerateLayerPropertiesDelegate>("vkEnumerateInstanceLayerProperties", "");
            VkEnumerateDeviceLayerProperties = cache.GetCommandDelegate<VkPhysicalDeviceEnumerateDeviceLayerPropertiesDelegate>("vkEnumerateDeviceLayerProperties", "");
            VkGetDeviceQueue = cache.GetCommandDelegate<VkDeviceGetQueueDelegate>("vkGetDeviceQueue", "");
            VkQueueSubmit = cache.GetCommandDelegate<VkQueueSubmitDelegate>("vkQueueSubmit", "");
            VkQueueWaitIdle = cache.GetCommandDelegate<VkQueueWaitIdleDelegate>("vkQueueWaitIdle", "");
            VkDeviceWaitIdle = cache.GetCommandDelegate<VkDeviceWaitIdleDelegate>("vkDeviceWaitIdle", "");
            VkAllocateMemory = cache.GetCommandDelegate<VkDeviceAllocateMemoryDelegate>("vkAllocateMemory", "");
            VkFreeMemory = cache.GetCommandDelegate<VkDeviceMemoryFreeDelegate>("vkFreeMemory", "");
            VkMapMemory = cache.GetCommandDelegate<VkDeviceMemoryMapDelegate>("vkMapMemory", "");
            VkUnmapMemory = cache.GetCommandDelegate<VkDeviceMemoryUnmapDelegate>("vkUnmapMemory", "");
            VkFlushMappedMemoryRanges = cache.GetCommandDelegate<VkDeviceFlushMappedMemoryRangesDelegate>("vkFlushMappedMemoryRanges", "");
            VkInvalidateMappedMemoryRanges = cache.GetCommandDelegate<VkDeviceInvalidateMappedMemoryRangesDelegate>("vkInvalidateMappedMemoryRanges", "");
            VkGetDeviceMemoryCommitment = cache.GetCommandDelegate<VkDeviceMemoryGetCommitmentDelegate>("vkGetDeviceMemoryCommitment", "");
            VkBindBufferMemory = cache.GetCommandDelegate<VkBufferBindMemoryDelegate>("vkBindBufferMemory", "");
            VkBindImageMemory = cache.GetCommandDelegate<VkImageBindMemoryDelegate>("vkBindImageMemory", "");
            VkGetBufferMemoryRequirements = cache.GetCommandDelegate<VkBufferGetMemoryRequirementsDelegate>("vkGetBufferMemoryRequirements", "");
            VkGetImageMemoryRequirements = cache.GetCommandDelegate<VkImageGetMemoryRequirementsDelegate>("vkGetImageMemoryRequirements", "");
            VkGetImageSparseMemoryRequirements = cache.GetCommandDelegate<VkImageGetSparseMemoryRequirementsDelegate>("vkGetImageSparseMemoryRequirements", "");
            VkGetPhysicalDeviceSparseImageFormatProperties = cache.GetCommandDelegate<VkPhysicalDeviceGetSparseImageFormatPropertiesDelegate>("vkGetPhysicalDeviceSparseImageFormatProperties", "");
            VkQueueBindSparse = cache.GetCommandDelegate<VkQueueBindSparseDelegate>("vkQueueBindSparse", "");
            VkCreateFence = cache.GetCommandDelegate<VkDeviceCreateFenceDelegate>("vkCreateFence", "");
            VkDestroyFence = cache.GetCommandDelegate<VkFenceDestroyDelegate>("vkDestroyFence", "");
            VkResetFences = cache.GetCommandDelegate<VkDeviceResetFencesDelegate>("vkResetFences", "");
            VkGetFenceStatus = cache.GetCommandDelegate<VkFenceGetStatusDelegate>("vkGetFenceStatus", "");
            VkWaitForFences = cache.GetCommandDelegate<VkDeviceWaitForFencesDelegate>("vkWaitForFences", "");
            VkCreateSemaphore = cache.GetCommandDelegate<VkDeviceCreateSemaphoreDelegate>("vkCreateSemaphore", "");
            VkDestroySemaphore = cache.GetCommandDelegate<VkSemaphoreDestroyDelegate>("vkDestroySemaphore", "");
            VkCreateEvent = cache.GetCommandDelegate<VkDeviceCreateEventDelegate>("vkCreateEvent", "");
            VkDestroyEvent = cache.GetCommandDelegate<VkEventDestroyDelegate>("vkDestroyEvent", "");
            VkGetEventStatus = cache.GetCommandDelegate<VkEventGetStatusDelegate>("vkGetEventStatus", "");
            VkSetEvent = cache.GetCommandDelegate<VkEventSetDelegate>("vkSetEvent", "");
            VkResetEvent = cache.GetCommandDelegate<VkEventResetDelegate>("vkResetEvent", "");
            VkCreateQueryPool = cache.GetCommandDelegate<VkDeviceCreateQueryPoolDelegate>("vkCreateQueryPool", "");
            VkDestroyQueryPool = cache.GetCommandDelegate<VkQueryPoolDestroyDelegate>("vkDestroyQueryPool", "");
            VkGetQueryPoolResults = cache.GetCommandDelegate<VkQueryPoolGetResultsDelegate>("vkGetQueryPoolResults", "");
            VkCreateBuffer = cache.GetCommandDelegate<VkDeviceCreateBufferDelegate>("vkCreateBuffer", "");
            VkDestroyBuffer = cache.GetCommandDelegate<VkBufferDestroyDelegate>("vkDestroyBuffer", "");
            VkCreateBufferView = cache.GetCommandDelegate<VkDeviceCreateBufferViewDelegate>("vkCreateBufferView", "");
            VkDestroyBufferView = cache.GetCommandDelegate<VkBufferViewDestroyDelegate>("vkDestroyBufferView", "");
            VkCreateImage = cache.GetCommandDelegate<VkDeviceCreateImageDelegate>("vkCreateImage", "");
            VkDestroyImage = cache.GetCommandDelegate<VkImageDestroyDelegate>("vkDestroyImage", "");
            VkGetImageSubresourceLayout = cache.GetCommandDelegate<VkImageGetSubresourceLayoutDelegate>("vkGetImageSubresourceLayout", "");
            VkCreateImageView = cache.GetCommandDelegate<VkDeviceCreateImageViewDelegate>("vkCreateImageView", "");
            VkDestroyImageView = cache.GetCommandDelegate<VkImageViewDestroyDelegate>("vkDestroyImageView", "");
            VkCreateShaderModule = cache.GetCommandDelegate<VkDeviceCreateShaderModuleDelegate>("vkCreateShaderModule", "");
            VkDestroyShaderModule = cache.GetCommandDelegate<VkShaderModuleDestroyDelegate>("vkDestroyShaderModule", "");
            VkCreatePipelineCache = cache.GetCommandDelegate<VkDeviceCreatePipelineCacheDelegate>("vkCreatePipelineCache", "");
            VkDestroyPipelineCache = cache.GetCommandDelegate<VkPipelineCacheDestroyDelegate>("vkDestroyPipelineCache", "");
            VkGetPipelineCacheData = cache.GetCommandDelegate<VkPipelineCacheGetDataDelegate>("vkGetPipelineCacheData", "");
            VkMergePipelineCaches = cache.GetCommandDelegate<VkPipelineCacheMergePipelineCachesDelegate>("vkMergePipelineCaches", "");
            VkCreateGraphicsPipelines = cache.GetCommandDelegate<VkDeviceCreateGraphicsPipelinesDelegate>("vkCreateGraphicsPipelines", "");
            VkCreateComputePipelines = cache.GetCommandDelegate<VkDeviceCreateComputePipelinesDelegate>("vkCreateComputePipelines", "");
            VkDestroyPipeline = cache.GetCommandDelegate<VkPipelineDestroyDelegate>("vkDestroyPipeline", "");
            VkCreatePipelineLayout = cache.GetCommandDelegate<VkDeviceCreatePipelineLayoutDelegate>("vkCreatePipelineLayout", "");
            VkDestroyPipelineLayout = cache.GetCommandDelegate<VkPipelineLayoutDestroyDelegate>("vkDestroyPipelineLayout", "");
            VkCreateSampler = cache.GetCommandDelegate<VkDeviceCreateSamplerDelegate>("vkCreateSampler", "");
            VkDestroySampler = cache.GetCommandDelegate<VkSamplerDestroyDelegate>("vkDestroySampler", "");
            VkCreateDescriptorSetLayout = cache.GetCommandDelegate<VkDeviceCreateDescriptorSetLayoutDelegate>("vkCreateDescriptorSetLayout", "");
            VkDestroyDescriptorSetLayout = cache.GetCommandDelegate<VkDescriptorSetLayoutDestroyDelegate>("vkDestroyDescriptorSetLayout", "");
            VkCreateDescriptorPool = cache.GetCommandDelegate<VkDeviceCreateDescriptorPoolDelegate>("vkCreateDescriptorPool", "");
            VkDestroyDescriptorPool = cache.GetCommandDelegate<VkDescriptorPoolDestroyDelegate>("vkDestroyDescriptorPool", "");
            VkResetDescriptorPool = cache.GetCommandDelegate<VkDescriptorPoolResetDelegate>("vkResetDescriptorPool", "");
            VkAllocateDescriptorSets = cache.GetCommandDelegate<VkDeviceAllocateDescriptorSetsDelegate>("vkAllocateDescriptorSets", "");
            VkFreeDescriptorSets = cache.GetCommandDelegate<VkDescriptorPoolFreeDescriptorSetsDelegate>("vkFreeDescriptorSets", "");
            VkUpdateDescriptorSets = cache.GetCommandDelegate<VkDeviceUpdateDescriptorSetsDelegate>("vkUpdateDescriptorSets", "");
            VkCreateFramebuffer = cache.GetCommandDelegate<VkDeviceCreateFramebufferDelegate>("vkCreateFramebuffer", "");
            VkDestroyFramebuffer = cache.GetCommandDelegate<VkFramebufferDestroyDelegate>("vkDestroyFramebuffer", "");
            VkCreateRenderPass = cache.GetCommandDelegate<VkDeviceCreateRenderPassDelegate>("vkCreateRenderPass", "");
            VkDestroyRenderPass = cache.GetCommandDelegate<VkRenderPassDestroyDelegate>("vkDestroyRenderPass", "");
            VkGetRenderAreaGranularity = cache.GetCommandDelegate<VkRenderPassGetRenderAreaGranularityDelegate>("vkGetRenderAreaGranularity", "");
            VkCreateCommandPool = cache.GetCommandDelegate<VkDeviceCreateCommandPoolDelegate>("vkCreateCommandPool", "");
            VkDestroyCommandPool = cache.GetCommandDelegate<VkCommandPoolDestroyDelegate>("vkDestroyCommandPool", "");
            VkResetCommandPool = cache.GetCommandDelegate<VkCommandPoolResetDelegate>("vkResetCommandPool", "");
            VkAllocateCommandBuffers = cache.GetCommandDelegate<VkDeviceAllocateCommandBuffersDelegate>("vkAllocateCommandBuffers", "");
            VkFreeCommandBuffers = cache.GetCommandDelegate<VkCommandPoolFreeCommandBuffersDelegate>("vkFreeCommandBuffers", "");
            VkBeginCommandBuffer = cache.GetCommandDelegate<VkCommandBufferBeginDelegate>("vkBeginCommandBuffer", "");
            VkEndCommandBuffer = cache.GetCommandDelegate<VkCommandBufferEndDelegate>("vkEndCommandBuffer", "");
            VkResetCommandBuffer = cache.GetCommandDelegate<VkCommandBufferResetDelegate>("vkResetCommandBuffer", "");
            VkCmdBindPipeline = cache.GetCommandDelegate<VkCommandBufferBindPipelineDelegate>("vkCmdBindPipeline", "");
            VkCmdSetViewport = cache.GetCommandDelegate<VkCommandBufferSetViewportDelegate>("vkCmdSetViewport", "");
            VkCmdSetScissor = cache.GetCommandDelegate<VkCommandBufferSetScissorDelegate>("vkCmdSetScissor", "");
            VkCmdSetLineWidth = cache.GetCommandDelegate<VkCommandBufferSetLineWidthDelegate>("vkCmdSetLineWidth", "");
            VkCmdSetDepthBias = cache.GetCommandDelegate<VkCommandBufferSetDepthBiasDelegate>("vkCmdSetDepthBias", "");
            VkCmdSetBlendConstants = cache.GetCommandDelegate<VkCommandBufferSetBlendConstantsDelegate>("vkCmdSetBlendConstants", "");
            VkCmdSetDepthBounds = cache.GetCommandDelegate<VkCommandBufferSetDepthBoundsDelegate>("vkCmdSetDepthBounds", "");
            VkCmdSetStencilCompareMask = cache.GetCommandDelegate<VkCommandBufferSetStencilCompareMaskDelegate>("vkCmdSetStencilCompareMask", "");
            VkCmdSetStencilWriteMask = cache.GetCommandDelegate<VkCommandBufferSetStencilWriteMaskDelegate>("vkCmdSetStencilWriteMask", "");
            VkCmdSetStencilReference = cache.GetCommandDelegate<VkCommandBufferSetStencilReferenceDelegate>("vkCmdSetStencilReference", "");
            VkCmdBindDescriptorSets = cache.GetCommandDelegate<VkCommandBufferBindDescriptorSetsDelegate>("vkCmdBindDescriptorSets", "");
            VkCmdBindIndexBuffer = cache.GetCommandDelegate<VkCommandBufferBindIndexBufferDelegate>("vkCmdBindIndexBuffer", "");
            VkCmdBindVertexBuffers = cache.GetCommandDelegate<VkCommandBufferBindVertexBuffersDelegate>("vkCmdBindVertexBuffers", "");
            VkCmdDraw = cache.GetCommandDelegate<VkCommandBufferDrawDelegate>("vkCmdDraw", "");
            VkCmdDrawIndexed = cache.GetCommandDelegate<VkCommandBufferDrawIndexedDelegate>("vkCmdDrawIndexed", "");
            VkCmdDrawIndirect = cache.GetCommandDelegate<VkCommandBufferDrawIndirectDelegate>("vkCmdDrawIndirect", "");
            VkCmdDrawIndexedIndirect = cache.GetCommandDelegate<VkCommandBufferDrawIndexedIndirectDelegate>("vkCmdDrawIndexedIndirect", "");
            VkCmdDispatch = cache.GetCommandDelegate<VkCommandBufferDispatchDelegate>("vkCmdDispatch", "");
            VkCmdDispatchIndirect = cache.GetCommandDelegate<VkCommandBufferDispatchIndirectDelegate>("vkCmdDispatchIndirect", "");
            VkCmdCopyBuffer = cache.GetCommandDelegate<VkCommandBufferCopyBufferDelegate>("vkCmdCopyBuffer", "");
            VkCmdCopyImage = cache.GetCommandDelegate<VkCommandBufferCopyImageDelegate>("vkCmdCopyImage", "");
            VkCmdBlitImage = cache.GetCommandDelegate<VkCommandBufferBlitImageDelegate>("vkCmdBlitImage", "");
            VkCmdCopyBufferToImage = cache.GetCommandDelegate<VkCommandBufferCopyBufferToImageDelegate>("vkCmdCopyBufferToImage", "");
            VkCmdCopyImageToBuffer = cache.GetCommandDelegate<VkCommandBufferCopyImageToBufferDelegate>("vkCmdCopyImageToBuffer", "");
            VkCmdUpdateBuffer = cache.GetCommandDelegate<VkCommandBufferUpdateBufferDelegate>("vkCmdUpdateBuffer", "");
            VkCmdFillBuffer = cache.GetCommandDelegate<VkCommandBufferFillBufferDelegate>("vkCmdFillBuffer", "");
            VkCmdClearColorImage = cache.GetCommandDelegate<VkCommandBufferClearColorImageDelegate>("vkCmdClearColorImage", "");
            VkCmdClearDepthStencilImage = cache.GetCommandDelegate<VkCommandBufferClearDepthStencilImageDelegate>("vkCmdClearDepthStencilImage", "");
            VkCmdClearAttachments = cache.GetCommandDelegate<VkCommandBufferClearAttachmentsDelegate>("vkCmdClearAttachments", "");
            VkCmdResolveImage = cache.GetCommandDelegate<VkCommandBufferResolveImageDelegate>("vkCmdResolveImage", "");
            VkCmdSetEvent = cache.GetCommandDelegate<VkCommandBufferSetEventDelegate>("vkCmdSetEvent", "");
            VkCmdResetEvent = cache.GetCommandDelegate<VkCommandBufferResetEventDelegate>("vkCmdResetEvent", "");
            VkCmdWaitEvents = cache.GetCommandDelegate<VkCommandBufferWaitEventsDelegate>("vkCmdWaitEvents", "");
            VkCmdPipelineBarrier = cache.GetCommandDelegate<VkCommandBufferPipelineBarrierDelegate>("vkCmdPipelineBarrier", "");
            VkCmdBeginQuery = cache.GetCommandDelegate<VkCommandBufferBeginQueryDelegate>("vkCmdBeginQuery", "");
            VkCmdEndQuery = cache.GetCommandDelegate<VkCommandBufferEndQueryDelegate>("vkCmdEndQuery", "");
            VkCmdResetQueryPool = cache.GetCommandDelegate<VkCommandBufferResetQueryPoolDelegate>("vkCmdResetQueryPool", "");
            VkCmdWriteTimestamp = cache.GetCommandDelegate<VkCommandBufferWriteTimestampDelegate>("vkCmdWriteTimestamp", "");
            VkCmdCopyQueryPoolResults = cache.GetCommandDelegate<VkCommandBufferCopyQueryPoolResultsDelegate>("vkCmdCopyQueryPoolResults", "");
            VkCmdPushConstants = cache.GetCommandDelegate<VkCommandBufferPushConstantsDelegate>("vkCmdPushConstants", "");
            VkCmdBeginRenderPass = cache.GetCommandDelegate<VkCommandBufferBeginRenderPassDelegate>("vkCmdBeginRenderPass", "");
            VkCmdNextSubpass = cache.GetCommandDelegate<VkCommandBufferNextSubpassDelegate>("vkCmdNextSubpass", "");
            VkCmdEndRenderPass = cache.GetCommandDelegate<VkCommandBufferEndRenderPassDelegate>("vkCmdEndRenderPass", "");
            VkCmdExecuteCommands = cache.GetCommandDelegate<VkCommandBufferExecuteCommandsDelegate>("vkCmdExecuteCommands", "");
            VkEnumerateInstanceVersion = cache.GetCommandDelegate<VkInstanceEnumerateVersionDelegate>("vkEnumerateInstanceVersion", "");
            VkBindBufferMemory2 = cache.GetCommandDelegate<VkDeviceBindBufferMemory2Delegate>("vkBindBufferMemory2", "");
            VkBindImageMemory2 = cache.GetCommandDelegate<VkDeviceBindImageMemory2Delegate>("vkBindImageMemory2", "");
            VkGetDeviceGroupPeerMemoryFeatures = cache.GetCommandDelegate<VkDeviceGetGroupPeerMemoryFeaturesDelegate>("vkGetDeviceGroupPeerMemoryFeatures", "");
            VkCmdSetDeviceMask = cache.GetCommandDelegate<VkCommandBufferSetDeviceMaskDelegate>("vkCmdSetDeviceMask", "");
            VkCmdDispatchBase = cache.GetCommandDelegate<VkCommandBufferDispatchBaseDelegate>("vkCmdDispatchBase", "");
            VkEnumeratePhysicalDeviceGroups = cache.GetCommandDelegate<VkInstanceEnumeratePhysicalDeviceGroupsDelegate>("vkEnumeratePhysicalDeviceGroups", "");
            VkGetImageMemoryRequirements2 = cache.GetCommandDelegate<VkDeviceGetImageMemoryRequirements2Delegate>("vkGetImageMemoryRequirements2", "");
            VkGetBufferMemoryRequirements2 = cache.GetCommandDelegate<VkDeviceGetBufferMemoryRequirements2Delegate>("vkGetBufferMemoryRequirements2", "");
            VkGetImageSparseMemoryRequirements2 = cache.GetCommandDelegate<VkDeviceGetImageSparseMemoryRequirements2Delegate>("vkGetImageSparseMemoryRequirements2", "");
            VkGetPhysicalDeviceFeatures2 = cache.GetCommandDelegate<VkPhysicalDeviceGetFeatures2Delegate>("vkGetPhysicalDeviceFeatures2", "");
            VkGetPhysicalDeviceProperties2 = cache.GetCommandDelegate<VkPhysicalDeviceGetProperties2Delegate>("vkGetPhysicalDeviceProperties2", "");
            VkGetPhysicalDeviceFormatProperties2 = cache.GetCommandDelegate<VkPhysicalDeviceGetFormatProperties2Delegate>("vkGetPhysicalDeviceFormatProperties2", "");
            VkGetPhysicalDeviceImageFormatProperties2 = cache.GetCommandDelegate<VkPhysicalDeviceGetImageFormatProperties2Delegate>("vkGetPhysicalDeviceImageFormatProperties2", "");
            VkGetPhysicalDeviceQueueFamilyProperties2 = cache.GetCommandDelegate<VkPhysicalDeviceGetQueueFamilyProperties2Delegate>("vkGetPhysicalDeviceQueueFamilyProperties2", "");
            VkGetPhysicalDeviceMemoryProperties2 = cache.GetCommandDelegate<VkPhysicalDeviceGetMemoryProperties2Delegate>("vkGetPhysicalDeviceMemoryProperties2", "");
            VkGetPhysicalDeviceSparseImageFormatProperties2 = cache.GetCommandDelegate<VkPhysicalDeviceGetSparseImageFormatProperties2Delegate>("vkGetPhysicalDeviceSparseImageFormatProperties2", "");
            VkTrimCommandPool = cache.GetCommandDelegate<VkCommandPoolTrimDelegate>("vkTrimCommandPool", "");
            VkGetDeviceQueue2 = cache.GetCommandDelegate<VkDeviceGetQueue2Delegate>("vkGetDeviceQueue2", "");
            VkCreateSamplerYcbcrConversion = cache.GetCommandDelegate<VkDeviceCreateSamplerYcbcrConversionDelegate>("vkCreateSamplerYcbcrConversion", "");
            VkDestroySamplerYcbcrConversion = cache.GetCommandDelegate<VkSamplerYcbcrConversionDestroyDelegate>("vkDestroySamplerYcbcrConversion", "");
            VkCreateDescriptorUpdateTemplate = cache.GetCommandDelegate<VkDeviceCreateDescriptorUpdateTemplateDelegate>("vkCreateDescriptorUpdateTemplate", "");
            VkDestroyDescriptorUpdateTemplate = cache.GetCommandDelegate<VkDescriptorUpdateTemplateDestroyDelegate>("vkDestroyDescriptorUpdateTemplate", "");
            VkUpdateDescriptorSetWithTemplate = cache.GetCommandDelegate<VkDeviceUpdateDescriptorSetWithTemplateDelegate>("vkUpdateDescriptorSetWithTemplate", "");
            VkGetPhysicalDeviceExternalBufferProperties = cache.GetCommandDelegate<VkPhysicalDeviceGetExternalBufferPropertiesDelegate>("vkGetPhysicalDeviceExternalBufferProperties", "");
            VkGetPhysicalDeviceExternalFenceProperties = cache.GetCommandDelegate<VkPhysicalDeviceGetExternalFencePropertiesDelegate>("vkGetPhysicalDeviceExternalFenceProperties", "");
            VkGetPhysicalDeviceExternalSemaphoreProperties = cache.GetCommandDelegate<VkPhysicalDeviceGetExternalSemaphorePropertiesDelegate>("vkGetPhysicalDeviceExternalSemaphoreProperties", "");
            VkGetDescriptorSetLayoutSupport = cache.GetCommandDelegate<VkDeviceGetDescriptorSetLayoutSupportDelegate>("vkGetDescriptorSetLayoutSupport", "");
            VkCmdDrawIndirectCount = cache.GetCommandDelegate<VkCommandBufferDrawIndirectCountDelegate>("vkCmdDrawIndirectCount", "");
            VkCmdDrawIndexedIndirectCount = cache.GetCommandDelegate<VkCommandBufferDrawIndexedIndirectCountDelegate>("vkCmdDrawIndexedIndirectCount", "");
            VkCreateRenderPass2 = cache.GetCommandDelegate<VkDeviceCreateRenderPass2Delegate>("vkCreateRenderPass2", "");
            VkCmdBeginRenderPass2 = cache.GetCommandDelegate<VkCommandBufferBeginRenderPass2Delegate>("vkCmdBeginRenderPass2", "");
            VkCmdNextSubpass2 = cache.GetCommandDelegate<VkCommandBufferNextSubpass2Delegate>("vkCmdNextSubpass2", "");
            VkCmdEndRenderPass2 = cache.GetCommandDelegate<VkCommandBufferEndRenderPass2Delegate>("vkCmdEndRenderPass2", "");
            VkResetQueryPool = cache.GetCommandDelegate<VkQueryPoolResetDelegate>("vkResetQueryPool", "");
            VkGetSemaphoreCounterValue = cache.GetCommandDelegate<VkSemaphoreGetCounterValueDelegate>("vkGetSemaphoreCounterValue", "");
            VkWaitSemaphores = cache.GetCommandDelegate<VkDeviceWaitSemaphoresDelegate>("vkWaitSemaphores", "");
            VkSignalSemaphore = cache.GetCommandDelegate<VkDeviceSignalSemaphoreDelegate>("vkSignalSemaphore", "");
            VkGetBufferDeviceAddress = cache.GetCommandDelegate<VkDeviceGetBufferDeviceAddressDelegate>("vkGetBufferDeviceAddress", "");
            VkGetBufferOpaqueCaptureAddress = cache.GetCommandDelegate<VkDeviceGetBufferOpaqueCaptureAddressDelegate>("vkGetBufferOpaqueCaptureAddress", "");
            VkGetDeviceMemoryOpaqueCaptureAddress = cache.GetCommandDelegate<VkDeviceGetMemoryOpaqueCaptureAddressDelegate>("vkGetDeviceMemoryOpaqueCaptureAddress", "");
            VkDestroySurfaceKhr = cache.GetCommandDelegate<VkSurfaceKhrDestroyDelegate>("vkDestroySurfaceKHR", "instance");
            VkGetPhysicalDeviceSurfaceSupportKhr = cache.GetCommandDelegate<VkPhysicalDeviceGetSurfaceSupportDelegate>("vkGetPhysicalDeviceSurfaceSupportKHR", "instance");
            VkGetPhysicalDeviceSurfaceCapabilitiesKhr = cache.GetCommandDelegate<VkPhysicalDeviceGetSurfaceCapabilitiesDelegate>("vkGetPhysicalDeviceSurfaceCapabilitiesKHR", "instance");
            VkGetPhysicalDeviceSurfaceFormatsKhr = cache.GetCommandDelegate<VkPhysicalDeviceGetSurfaceFormatsDelegate>("vkGetPhysicalDeviceSurfaceFormatsKHR", "instance");
            VkGetPhysicalDeviceSurfacePresentModesKhr = cache.GetCommandDelegate<VkPhysicalDeviceGetSurfacePresentModesDelegate>("vkGetPhysicalDeviceSurfacePresentModesKHR", "instance");
            VkCreateSwapchainKhr = cache.GetCommandDelegate<VkDeviceCreateSwapchainDelegate>("vkCreateSwapchainKHR", "device");
            VkDestroySwapchainKhr = cache.GetCommandDelegate<VkSwapchainKhrDestroyDelegate>("vkDestroySwapchainKHR", "device");
            VkGetSwapchainImagesKhr = cache.GetCommandDelegate<VkSwapchainKhrGetImagesDelegate>("vkGetSwapchainImagesKHR", "device");
            VkAcquireNextImageKhr = cache.GetCommandDelegate<VkSwapchainKhrAcquireNextImageDelegate>("vkAcquireNextImageKHR", "device");
            VkQueuePresentKhr = cache.GetCommandDelegate<VkQueuePresentDelegate>("vkQueuePresentKHR", "device");
            VkGetDeviceGroupPresentCapabilitiesKhr = cache.GetCommandDelegate<VkDeviceGetGroupPresentCapabilitiesDelegate>("vkGetDeviceGroupPresentCapabilitiesKHR", "device");
            VkGetDeviceGroupSurfacePresentModesKhr = cache.GetCommandDelegate<VkDeviceGetGroupSurfacePresentModesDelegate>("vkGetDeviceGroupSurfacePresentModesKHR", "device");
            VkGetPhysicalDevicePresentRectanglesKhr = cache.GetCommandDelegate<VkPhysicalDeviceGetPresentRectanglesDelegate>("vkGetPhysicalDevicePresentRectanglesKHR", "device");
            VkAcquireNextImage2Khr = cache.GetCommandDelegate<VkDeviceAcquireNextImage2Delegate>("vkAcquireNextImage2KHR", "device");
            VkGetPhysicalDeviceDisplayPropertiesKhr = cache.GetCommandDelegate<VkPhysicalDeviceGetDisplayPropertiesDelegate>("vkGetPhysicalDeviceDisplayPropertiesKHR", "instance");
            VkGetPhysicalDeviceDisplayPlanePropertiesKhr = cache.GetCommandDelegate<VkPhysicalDeviceGetDisplayPlanePropertiesDelegate>("vkGetPhysicalDeviceDisplayPlanePropertiesKHR", "instance");
            VkGetDisplayPlaneSupportedDisplaysKhr = cache.GetCommandDelegate<VkPhysicalDeviceGetDisplayPlaneSupportedDisplaysDelegate>("vkGetDisplayPlaneSupportedDisplaysKHR", "instance");
            VkGetDisplayModePropertiesKhr = cache.GetCommandDelegate<VkPhysicalDeviceGetDisplayModePropertiesDelegate>("vkGetDisplayModePropertiesKHR", "instance");
            VkCreateDisplayModeKhr = cache.GetCommandDelegate<VkPhysicalDeviceCreateDisplayModeDelegate>("vkCreateDisplayModeKHR", "instance");
            VkGetDisplayPlaneCapabilitiesKhr = cache.GetCommandDelegate<VkDisplayModeKhrGetDisplayPlaneCapabilitiesDelegate>("vkGetDisplayPlaneCapabilitiesKHR", "instance");
            VkCreateDisplayPlaneSurfaceKhr = cache.GetCommandDelegate<VkInstanceCreateDisplayPlaneSurfaceDelegate>("vkCreateDisplayPlaneSurfaceKHR", "instance");
            VkCreateSharedSwapchainsKhr = cache.GetCommandDelegate<VkDeviceCreateSharedSwapchainsDelegate>("vkCreateSharedSwapchainsKHR", "device");
            VkCreateXlibSurfaceKhr = cache.GetCommandDelegate<VkInstanceCreateXlibSurfaceDelegate>("vkCreateXlibSurfaceKHR", "instance");
            VkGetPhysicalDeviceXlibPresentationSupportKhr = cache.GetCommandDelegate<VkPhysicalDeviceGetXlibPresentationSupportDelegate>("vkGetPhysicalDeviceXlibPresentationSupportKHR", "instance");
            VkCreateXcbSurfaceKhr = cache.GetCommandDelegate<VkInstanceCreateXcbSurfaceDelegate>("vkCreateXcbSurfaceKHR", "instance");
            VkGetPhysicalDeviceXcbPresentationSupportKhr = cache.GetCommandDelegate<VkPhysicalDeviceGetXcbPresentationSupportDelegate>("vkGetPhysicalDeviceXcbPresentationSupportKHR", "instance");
            VkCreateWaylandSurfaceKhr = cache.GetCommandDelegate<VkInstanceCreateWaylandSurfaceDelegate>("vkCreateWaylandSurfaceKHR", "instance");
            VkGetPhysicalDeviceWaylandPresentationSupportKhr = cache.GetCommandDelegate<VkPhysicalDeviceGetWaylandPresentationSupportDelegate>("vkGetPhysicalDeviceWaylandPresentationSupportKHR", "instance");
            VkCreateAndroidSurfaceKhr = cache.GetCommandDelegate<VkInstanceCreateAndroidSurfaceDelegate>("vkCreateAndroidSurfaceKHR", "instance");
            VkCreateWin32SurfaceKhr = cache.GetCommandDelegate<VkInstanceCreateWin32SurfaceDelegate>("vkCreateWin32SurfaceKHR", "instance");
            VkGetPhysicalDeviceWin32PresentationSupportKhr = cache.GetCommandDelegate<VkPhysicalDeviceGetWin32PresentationSupportDelegate>("vkGetPhysicalDeviceWin32PresentationSupportKHR", "instance");
            VkCreateDebugReportCallbackExt = cache.GetCommandDelegate<VkInstanceCreateDebugReportCallbackDelegate>("vkCreateDebugReportCallbackEXT", "instance");
            VkDestroyDebugReportCallbackExt = cache.GetCommandDelegate<VkDebugReportCallbackExtDestroyDelegate>("vkDestroyDebugReportCallbackEXT", "instance");
            VkDebugReportMessageExt = cache.GetCommandDelegate<VkInstanceDebugReportMessageDelegate>("vkDebugReportMessageEXT", "instance");
            VkCmdBindTransformFeedbackBuffersExt = cache.GetCommandDelegate<VkCommandBufferBindTransformFeedbackBuffersDelegate>("vkCmdBindTransformFeedbackBuffersEXT", "device");
            VkCmdBeginTransformFeedbackExt = cache.GetCommandDelegate<VkCommandBufferBeginTransformFeedbackDelegate>("vkCmdBeginTransformFeedbackEXT", "device");
            VkCmdEndTransformFeedbackExt = cache.GetCommandDelegate<VkCommandBufferEndTransformFeedbackDelegate>("vkCmdEndTransformFeedbackEXT", "device");
            VkCmdBeginQueryIndexedExt = cache.GetCommandDelegate<VkCommandBufferBeginQueryIndexedDelegate>("vkCmdBeginQueryIndexedEXT", "device");
            VkCmdEndQueryIndexedExt = cache.GetCommandDelegate<VkCommandBufferEndQueryIndexedDelegate>("vkCmdEndQueryIndexedEXT", "device");
            VkCmdDrawIndirectByteCountExt = cache.GetCommandDelegate<VkCommandBufferDrawIndirectByteCountDelegate>("vkCmdDrawIndirectByteCountEXT", "device");
            VkGetImageViewHandleNvx = cache.GetCommandDelegate<VkDeviceGetImageViewHandleDelegate>("vkGetImageViewHandleNVX", "device");
            VkGetShaderInfoAmd = cache.GetCommandDelegate<VkPipelineGetShaderInfoDelegate>("vkGetShaderInfoAMD", "device");
            VkCreateStreamDescriptorSurfaceGgp = cache.GetCommandDelegate<VkInstanceCreateStreamDescriptorSurfaceDelegate>("vkCreateStreamDescriptorSurfaceGGP", "instance");
            VkGetPhysicalDeviceExternalImageFormatPropertiesNv = cache.GetCommandDelegate<VkPhysicalDeviceGetExternalImageFormatPropertiesDelegate>("vkGetPhysicalDeviceExternalImageFormatPropertiesNV", "instance");
            VkGetMemoryWin32HandleNv = cache.GetCommandDelegate<VkDeviceMemoryGetWin32HandleDelegate>("vkGetMemoryWin32HandleNV", "device");
            VkCreateViSurfaceNn = cache.GetCommandDelegate<VkInstanceCreateViSurfaceDelegate>("vkCreateViSurfaceNN", "instance");
            VkGetMemoryWin32HandleKhr = cache.GetCommandDelegate<VkDeviceGetMemoryWin32HandleDelegate>("vkGetMemoryWin32HandleKHR", "device");
            VkGetMemoryWin32HandlePropertiesKhr = cache.GetCommandDelegate<VkDeviceGetMemoryWin32HandlePropertiesDelegate>("vkGetMemoryWin32HandlePropertiesKHR", "device");
            VkGetMemoryFdKhr = cache.GetCommandDelegate<VkDeviceGetMemoryFileDescriptorDelegate>("vkGetMemoryFdKHR", "device");
            VkGetMemoryFdPropertiesKhr = cache.GetCommandDelegate<VkDeviceGetMemoryFileDescriptorPropertiesDelegate>("vkGetMemoryFdPropertiesKHR", "device");
            VkImportSemaphoreWin32HandleKhr = cache.GetCommandDelegate<VkDeviceImportSemaphoreWin32HandleDelegate>("vkImportSemaphoreWin32HandleKHR", "device");
            VkGetSemaphoreWin32HandleKhr = cache.GetCommandDelegate<VkDeviceGetSemaphoreWin32HandleDelegate>("vkGetSemaphoreWin32HandleKHR", "device");
            VkImportSemaphoreFdKhr = cache.GetCommandDelegate<VkDeviceImportSemaphoreFileDescriptorDelegate>("vkImportSemaphoreFdKHR", "device");
            VkGetSemaphoreFdKhr = cache.GetCommandDelegate<VkDeviceGetSemaphoreFileDescriptorDelegate>("vkGetSemaphoreFdKHR", "device");
            VkCmdPushDescriptorSetKhr = cache.GetCommandDelegate<VkCommandBufferPushDescriptorSetDelegate>("vkCmdPushDescriptorSetKHR", "device");
            VkCmdPushDescriptorSetWithTemplateKhr = cache.GetCommandDelegate<VkCommandBufferPushDescriptorSetWithTemplateDelegate>("vkCmdPushDescriptorSetWithTemplateKHR", "device");
            VkCmdBeginConditionalRenderingExt = cache.GetCommandDelegate<VkCommandBufferBeginConditionalRenderingDelegate>("vkCmdBeginConditionalRenderingEXT", "device");
            VkCmdEndConditionalRenderingExt = cache.GetCommandDelegate<VkCommandBufferEndConditionalRenderingDelegate>("vkCmdEndConditionalRenderingEXT", "device");
            VkCmdProcessCommandsNvx = cache.GetCommandDelegate<VkCommandBufferProcessCommandsDelegate>("vkCmdProcessCommandsNVX", "device");
            VkCmdReserveSpaceForCommandsNvx = cache.GetCommandDelegate<VkCommandBufferReserveSpaceForCommandsDelegate>("vkCmdReserveSpaceForCommandsNVX", "device");
            VkCreateIndirectCommandsLayoutNvx = cache.GetCommandDelegate<VkDeviceCreateIndirectCommandsLayoutDelegate>("vkCreateIndirectCommandsLayoutNVX", "device");
            VkDestroyIndirectCommandsLayoutNvx = cache.GetCommandDelegate<VkIndirectCommandsLayoutNvxDestroyDelegate>("vkDestroyIndirectCommandsLayoutNVX", "device");
            VkCreateObjectTableNvx = cache.GetCommandDelegate<VkDeviceCreateObjectTableDelegate>("vkCreateObjectTableNVX", "device");
            VkDestroyObjectTableNvx = cache.GetCommandDelegate<VkObjectTableNvxDestroyDelegate>("vkDestroyObjectTableNVX", "device");
            VkRegisterObjectsNvx = cache.GetCommandDelegate<VkObjectTableNvxRegisterObjectsDelegate>("vkRegisterObjectsNVX", "device");
            VkUnregisterObjectsNvx = cache.GetCommandDelegate<VkObjectTableNvxUnregisterObjectsDelegate>("vkUnregisterObjectsNVX", "device");
            VkGetPhysicalDeviceGeneratedCommandsPropertiesNvx = cache.GetCommandDelegate<VkPhysicalDeviceGetGeneratedCommandsPropertiesDelegate>("vkGetPhysicalDeviceGeneratedCommandsPropertiesNVX", "device");
            VkCmdSetViewportWScalingNv = cache.GetCommandDelegate<VkCommandBufferSetViewportWScalingDelegate>("vkCmdSetViewportWScalingNV", "device");
            VkReleaseDisplayExt = cache.GetCommandDelegate<VkPhysicalDeviceReleaseDisplayDelegate>("vkReleaseDisplayEXT", "instance");
            VkAcquireXlibDisplayExt = cache.GetCommandDelegate<VkPhysicalDeviceAcquireXlibDisplayDelegate>("vkAcquireXlibDisplayEXT", "instance");
            VkGetRandROutputDisplayExt = cache.GetCommandDelegate<VkPhysicalDeviceGetRandROutputDisplayDelegate>("vkGetRandROutputDisplayEXT", "instance");
            VkGetPhysicalDeviceSurfaceCapabilities2Ext = cache.GetCommandDelegate<VkPhysicalDeviceGetSurfaceCapabilities2Delegate>("vkGetPhysicalDeviceSurfaceCapabilities2EXT", "instance");
            VkDisplayPowerControlExt = cache.GetCommandDelegate<VkDeviceDisplayPowerControlDelegate>("vkDisplayPowerControlEXT", "device");
            VkRegisterDeviceEventExt = cache.GetCommandDelegate<VkDeviceRegisterEventDelegate>("vkRegisterDeviceEventEXT", "device");
            VkRegisterDisplayEventExt = cache.GetCommandDelegate<VkDeviceRegisterDisplayEventDelegate>("vkRegisterDisplayEventEXT", "device");
            VkGetSwapchainCounterExt = cache.GetCommandDelegate<VkSwapchainKhrGetCounterDelegate>("vkGetSwapchainCounterEXT", "device");
            VkGetRefreshCycleDurationGoogle = cache.GetCommandDelegate<VkSwapchainKhrGetRefreshCycleDurationDelegate>("vkGetRefreshCycleDurationGOOGLE", "device");
            VkGetPastPresentationTimingGoogle = cache.GetCommandDelegate<VkSwapchainKhrGetPastPresentationTimingDelegate>("vkGetPastPresentationTimingGOOGLE", "device");
            VkCmdSetDiscardRectangleExt = cache.GetCommandDelegate<VkCommandBufferSetDiscardRectangleDelegate>("vkCmdSetDiscardRectangleEXT", "device");
            VkSetHdrMetadataExt = cache.GetCommandDelegate<VkDeviceSetHdrMetadataDelegate>("vkSetHdrMetadataEXT", "device");
            VkGetSwapchainStatusKhr = cache.GetCommandDelegate<VkSwapchainKhrGetStatusDelegate>("vkGetSwapchainStatusKHR", "device");
            VkImportFenceWin32HandleKhr = cache.GetCommandDelegate<VkDeviceImportFenceWin32HandleDelegate>("vkImportFenceWin32HandleKHR", "device");
            VkGetFenceWin32HandleKhr = cache.GetCommandDelegate<VkDeviceGetFenceWin32HandleDelegate>("vkGetFenceWin32HandleKHR", "device");
            VkImportFenceFdKhr = cache.GetCommandDelegate<VkDeviceImportFenceFileDescriptorDelegate>("vkImportFenceFdKHR", "device");
            VkGetFenceFdKhr = cache.GetCommandDelegate<VkDeviceGetFenceFileDescriptorDelegate>("vkGetFenceFdKHR", "device");
            VkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKhr = cache.GetCommandDelegate<VkPhysicalDeviceEnumerateQueueFamilyPerformanceQueryCountersDelegate>("vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR", "device");
            VkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKhr = cache.GetCommandDelegate<VkPhysicalDeviceGetQueueFamilyPerformanceQueryPassesDelegate>("vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR", "device");
            VkAcquireProfilingLockKhr = cache.GetCommandDelegate<VkDeviceAcquireProfilingLockDelegate>("vkAcquireProfilingLockKHR", "device");
            VkReleaseProfilingLockKhr = cache.GetCommandDelegate<VkDeviceReleaseProfilingLockDelegate>("vkReleaseProfilingLockKHR", "device");
            VkGetPhysicalDeviceSurfaceCapabilities2Khr = cache.GetCommandDelegate<Interop.Khronos.VkPhysicalDeviceGetSurfaceCapabilities2Delegate>("vkGetPhysicalDeviceSurfaceCapabilities2KHR", "instance");
            VkGetPhysicalDeviceSurfaceFormats2Khr = cache.GetCommandDelegate<VkPhysicalDeviceGetSurfaceFormats2Delegate>("vkGetPhysicalDeviceSurfaceFormats2KHR", "instance");
            VkGetPhysicalDeviceDisplayProperties2Khr = cache.GetCommandDelegate<VkPhysicalDeviceGetDisplayProperties2Delegate>("vkGetPhysicalDeviceDisplayProperties2KHR", "instance");
            VkGetPhysicalDeviceDisplayPlaneProperties2Khr = cache.GetCommandDelegate<VkPhysicalDeviceGetDisplayPlaneProperties2Delegate>("vkGetPhysicalDeviceDisplayPlaneProperties2KHR", "instance");
            VkGetDisplayModeProperties2Khr = cache.GetCommandDelegate<VkPhysicalDeviceGetDisplayModeProperties2Delegate>("vkGetDisplayModeProperties2KHR", "instance");
            VkGetDisplayPlaneCapabilities2Khr = cache.GetCommandDelegate<VkPhysicalDeviceGetDisplayPlaneCapabilities2Delegate>("vkGetDisplayPlaneCapabilities2KHR", "instance");
            VkCreateIosSurfaceMvk = cache.GetCommandDelegate<VkInstanceCreateIosSurfaceDelegate>("vkCreateIOSSurfaceMVK", "instance");
            VkCreateMacOsSurfaceMvk = cache.GetCommandDelegate<VkInstanceCreateMacOsSurfaceDelegate>("vkCreateMacOSSurfaceMVK", "instance");
            VkSetDebugUtilsObjectNameExt = cache.GetCommandDelegate<VkDeviceSetDebugUtilsObjectNameDelegate>("vkSetDebugUtilsObjectNameEXT", "instance");
            VkSetDebugUtilsObjectTagExt = cache.GetCommandDelegate<VkDeviceSetDebugUtilsObjectTagDelegate>("vkSetDebugUtilsObjectTagEXT", "instance");
            VkQueueBeginDebugUtilsLabelExt = cache.GetCommandDelegate<VkQueueBeginDebugUtilsLabelDelegate>("vkQueueBeginDebugUtilsLabelEXT", "instance");
            VkQueueEndDebugUtilsLabelExt = cache.GetCommandDelegate<VkQueueEndDebugUtilsLabelDelegate>("vkQueueEndDebugUtilsLabelEXT", "instance");
            VkQueueInsertDebugUtilsLabelExt = cache.GetCommandDelegate<VkQueueInsertDebugUtilsLabelDelegate>("vkQueueInsertDebugUtilsLabelEXT", "instance");
            VkCmdBeginDebugUtilsLabelExt = cache.GetCommandDelegate<VkCommandBufferBeginDebugUtilsLabelDelegate>("vkCmdBeginDebugUtilsLabelEXT", "instance");
            VkCmdEndDebugUtilsLabelExt = cache.GetCommandDelegate<VkCommandBufferEndDebugUtilsLabelDelegate>("vkCmdEndDebugUtilsLabelEXT", "instance");
            VkCmdInsertDebugUtilsLabelExt = cache.GetCommandDelegate<VkCommandBufferInsertDebugUtilsLabelDelegate>("vkCmdInsertDebugUtilsLabelEXT", "instance");
            VkCreateDebugUtilsMessengerExt = cache.GetCommandDelegate<VkInstanceCreateDebugUtilsMessengerDelegate>("vkCreateDebugUtilsMessengerEXT", "instance");
            VkDestroyDebugUtilsMessengerExt = cache.GetCommandDelegate<VkDebugUtilsMessengerExtDestroyDelegate>("vkDestroyDebugUtilsMessengerEXT", "instance");
            VkSubmitDebugUtilsMessageExt = cache.GetCommandDelegate<VkInstanceSubmitDebugUtilsMessageDelegate>("vkSubmitDebugUtilsMessageEXT", "instance");
            VkGetAndroidHardwareBufferPropertiesAndroid = cache.GetCommandDelegate<VkDeviceGetAndroidHardwareBufferPropertiesDelegate>("vkGetAndroidHardwareBufferPropertiesANDROID", "device");
            VkGetMemoryAndroidHardwareBufferAndroid = cache.GetCommandDelegate<VkDeviceGetMemoryAndroidHardwareBufferDelegate>("vkGetMemoryAndroidHardwareBufferANDROID", "device");
            VkCmdSetSampleLocationsExt = cache.GetCommandDelegate<VkCommandBufferSetSampleLocationsDelegate>("vkCmdSetSampleLocationsEXT", "device");
            VkGetPhysicalDeviceMultisamplePropertiesExt = cache.GetCommandDelegate<VkPhysicalDeviceGetMultisamplePropertiesDelegate>("vkGetPhysicalDeviceMultisamplePropertiesEXT", "device");
            VkGetImageDrmFormatModifierPropertiesExt = cache.GetCommandDelegate<VkImageGetDrmFormatModifierPropertiesDelegate>("vkGetImageDrmFormatModifierPropertiesEXT", "device");
            VkCreateValidationCacheExt = cache.GetCommandDelegate<VkDeviceCreateValidationCacheDelegate>("vkCreateValidationCacheEXT", "device");
            VkDestroyValidationCacheExt = cache.GetCommandDelegate<VkValidationCacheExtDestroyDelegate>("vkDestroyValidationCacheEXT", "device");
            VkMergeValidationCachesExt = cache.GetCommandDelegate<VkValidationCacheExtMergeValidationCachesDelegate>("vkMergeValidationCachesEXT", "device");
            VkGetValidationCacheDataExt = cache.GetCommandDelegate<VkValidationCacheExtGetDataDelegate>("vkGetValidationCacheDataEXT", "device");
            VkCmdBindShadingRateImageNv = cache.GetCommandDelegate<VkCommandBufferBindShadingRateImageDelegate>("vkCmdBindShadingRateImageNV", "device");
            VkCmdSetViewportShadingRatePaletteNv = cache.GetCommandDelegate<VkCommandBufferSetViewportShadingRatePaletteDelegate>("vkCmdSetViewportShadingRatePaletteNV", "device");
            VkCmdSetCoarseSampleOrderNv = cache.GetCommandDelegate<VkCommandBufferSetCoarseSampleOrderDelegate>("vkCmdSetCoarseSampleOrderNV", "device");
            VkCreateAccelerationStructureNv = cache.GetCommandDelegate<VkDeviceCreateAccelerationStructureDelegate>("vkCreateAccelerationStructureNV", "device");
            VkDestroyAccelerationStructureNv = cache.GetCommandDelegate<VkAccelerationStructureNvDestroyDelegate>("vkDestroyAccelerationStructureNV", "device");
            VkGetAccelerationStructureMemoryRequirementsNv = cache.GetCommandDelegate<VkDeviceGetAccelerationStructureMemoryRequirementsDelegate>("vkGetAccelerationStructureMemoryRequirementsNV", "device");
            VkBindAccelerationStructureMemoryNv = cache.GetCommandDelegate<VkDeviceBindAccelerationStructureMemoryDelegate>("vkBindAccelerationStructureMemoryNV", "device");
            VkCmdBuildAccelerationStructureNv = cache.GetCommandDelegate<VkCommandBufferBuildAccelerationStructureDelegate>("vkCmdBuildAccelerationStructureNV", "device");
            VkCmdCopyAccelerationStructureNv = cache.GetCommandDelegate<VkCommandBufferCopyAccelerationStructureDelegate>("vkCmdCopyAccelerationStructureNV", "device");
            VkCmdTraceRaysNv = cache.GetCommandDelegate<VkCommandBufferTraceRaysDelegate>("vkCmdTraceRaysNV", "device");
            VkCreateRayTracingPipelinesNv = cache.GetCommandDelegate<VkDeviceCreateRayTracingPipelinesDelegate>("vkCreateRayTracingPipelinesNV", "device");
            VkGetRayTracingShaderGroupHandlesNv = cache.GetCommandDelegate<VkPipelineGetRayTracingShaderGroupHandlesDelegate>("vkGetRayTracingShaderGroupHandlesNV", "device");
            VkGetAccelerationStructureHandleNv = cache.GetCommandDelegate<VkAccelerationStructureNvGetHandleDelegate>("vkGetAccelerationStructureHandleNV", "device");
            VkCmdWriteAccelerationStructuresPropertiesNv = cache.GetCommandDelegate<VkCommandBufferWriteAccelerationStructuresPropertiesDelegate>("vkCmdWriteAccelerationStructuresPropertiesNV", "device");
            VkCompileDeferredNv = cache.GetCommandDelegate<VkPipelineCompileDeferredDelegate>("vkCompileDeferredNV", "device");
            VkGetMemoryHostPointerPropertiesExt = cache.GetCommandDelegate<VkDeviceGetMemoryHostPointerPropertiesDelegate>("vkGetMemoryHostPointerPropertiesEXT", "device");
            VkCmdWriteBufferMarkerAmd = cache.GetCommandDelegate<VkCommandBufferWriteBufferMarkerDelegate>("vkCmdWriteBufferMarkerAMD", "device");
            VkGetPhysicalDeviceCalibrateableTimeDomainsExt = cache.GetCommandDelegate<VkPhysicalDeviceGetCalibrateableTimeDomainsDelegate>("vkGetPhysicalDeviceCalibrateableTimeDomainsEXT", "device");
            VkGetCalibratedTimestampsExt = cache.GetCommandDelegate<VkDeviceGetCalibratedTimestampsDelegate>("vkGetCalibratedTimestampsEXT", "device");
            VkCmdDrawMeshTasksNv = cache.GetCommandDelegate<VkCommandBufferDrawMeshTasksDelegate>("vkCmdDrawMeshTasksNV", "device");
            VkCmdDrawMeshTasksIndirectNv = cache.GetCommandDelegate<VkCommandBufferDrawMeshTasksIndirectDelegate>("vkCmdDrawMeshTasksIndirectNV", "device");
            VkCmdDrawMeshTasksIndirectCountNv = cache.GetCommandDelegate<VkCommandBufferDrawMeshTasksIndirectCountDelegate>("vkCmdDrawMeshTasksIndirectCountNV", "device");
            VkCmdSetExclusiveScissorNv = cache.GetCommandDelegate<VkCommandBufferSetExclusiveScissorDelegate>("vkCmdSetExclusiveScissorNV", "device");
            VkCmdSetCheckpointNv = cache.GetCommandDelegate<VkCommandBufferSetCheckpointDelegate>("vkCmdSetCheckpointNV", "device");
            VkGetQueueCheckpointDataNv = cache.GetCommandDelegate<VkQueueGetCheckpointDataDelegate>("vkGetQueueCheckpointDataNV", "device");
            VkInitializePerformanceApiIntel = cache.GetCommandDelegate<VkDeviceInitializePerformanceApiDelegate>("vkInitializePerformanceApiINTEL", "device");
            VkUninitializePerformanceApiIntel = cache.GetCommandDelegate<VkDeviceUninitializePerformanceApiDelegate>("vkUninitializePerformanceApiINTEL", "device");
            VkCmdSetPerformanceMarkerIntel = cache.GetCommandDelegate<VkCommandBufferSetPerformanceMarkerDelegate>("vkCmdSetPerformanceMarkerINTEL", "device");
            VkCmdSetPerformanceStreamMarkerIntel = cache.GetCommandDelegate<VkCommandBufferSetPerformanceStreamMarkerDelegate>("vkCmdSetPerformanceStreamMarkerINTEL", "device");
            VkCmdSetPerformanceOverrideIntel = cache.GetCommandDelegate<VkCommandBufferSetPerformanceOverrideDelegate>("vkCmdSetPerformanceOverrideINTEL", "device");
            VkAcquirePerformanceConfigurationIntel = cache.GetCommandDelegate<VkDeviceAcquirePerformanceConfigurationDelegate>("vkAcquirePerformanceConfigurationINTEL", "device");
            VkReleasePerformanceConfigurationIntel = cache.GetCommandDelegate<VkPerformanceConfigurationIntelReleaseDelegate>("vkReleasePerformanceConfigurationINTEL", "device");
            VkQueueSetPerformanceConfigurationIntel = cache.GetCommandDelegate<VkQueueSetPerformanceConfigurationDelegate>("vkQueueSetPerformanceConfigurationINTEL", "device");
            VkGetPerformanceParameterIntel = cache.GetCommandDelegate<VkDeviceGetPerformanceParameterDelegate>("vkGetPerformanceParameterINTEL", "device");
            VkSetLocalDimmingAmd = cache.GetCommandDelegate<VkSwapchainKhrSetLocalDimmingDelegate>("vkSetLocalDimmingAMD", "device");
            VkCreateImagePipeSurfaceFuchsia = cache.GetCommandDelegate<VkInstanceCreateImagePipeSurfaceDelegate>("vkCreateImagePipeSurfaceFUCHSIA", "instance");
            VkCreateMetalSurfaceExt = cache.GetCommandDelegate<VkInstanceCreateMetalSurfaceDelegate>("vkCreateMetalSurfaceEXT", "instance");
            VkGetPhysicalDeviceToolPropertiesExt = cache.GetCommandDelegate<VkPhysicalDeviceGetToolPropertiesDelegate>("vkGetPhysicalDeviceToolPropertiesEXT", "device");
            VkGetPhysicalDeviceCooperativeMatrixPropertiesNv = cache.GetCommandDelegate<VkPhysicalDeviceGetCooperativeMatrixPropertiesDelegate>("vkGetPhysicalDeviceCooperativeMatrixPropertiesNV", "device");
            VkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNv = cache.GetCommandDelegate<VkPhysicalDeviceGetSupportedFramebufferMixedSamplesCombinationsDelegate>("vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV", "device");
            VkGetPhysicalDeviceSurfacePresentModes2Ext = cache.GetCommandDelegate<VkPhysicalDeviceGetSurfacePresentModes2Delegate>("vkGetPhysicalDeviceSurfacePresentModes2EXT", "device");
            VkAcquireFullScreenExclusiveModeExt = cache.GetCommandDelegate<VkSwapchainKhrAcquireFullScreenExclusiveModeDelegate>("vkAcquireFullScreenExclusiveModeEXT", "device");
            VkReleaseFullScreenExclusiveModeExt = cache.GetCommandDelegate<VkSwapchainKhrReleaseFullScreenExclusiveModeDelegate>("vkReleaseFullScreenExclusiveModeEXT", "device");
            VkGetDeviceGroupSurfacePresentModes2Ext = cache.GetCommandDelegate<VkDeviceGetGroupSurfacePresentModes2Delegate>("vkGetDeviceGroupSurfacePresentModes2EXT", "device");
            VkCreateHeadlessSurfaceExt = cache.GetCommandDelegate<VkInstanceCreateHeadlessSurfaceDelegate>("vkCreateHeadlessSurfaceEXT", "instance");
            VkCmdSetLineStippleExt = cache.GetCommandDelegate<VkCommandBufferSetLineStippleDelegate>("vkCmdSetLineStippleEXT", "device");
            VkGetPipelineExecutablePropertiesKhr = cache.GetCommandDelegate<VkDeviceGetPipelineExecutablePropertiesDelegate>("vkGetPipelineExecutablePropertiesKHR", "device");
            VkGetPipelineExecutableStatisticsKhr = cache.GetCommandDelegate<VkDeviceGetPipelineExecutableStatisticsDelegate>("vkGetPipelineExecutableStatisticsKHR", "device");
            VkGetPipelineExecutableInternalRepresentationsKhr = cache.GetCommandDelegate<VkDeviceGetPipelineExecutableInternalRepresentationsDelegate>("vkGetPipelineExecutableInternalRepresentationsKHR", "device");
        }
    }
}
