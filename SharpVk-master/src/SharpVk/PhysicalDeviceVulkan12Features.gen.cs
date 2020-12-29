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
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct PhysicalDeviceVulkan12Features
    {
        /// <summary>
        /// </summary>
        public bool SamplerMirrorClampToEdge
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool DrawIndirectCount
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool StorageBuffer8BitAccess
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool UniformAndStorageBuffer8BitAccess
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool StoragePushConstant8
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool ShaderBufferInt64Atomics
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool ShaderSharedInt64Atomics
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool ShaderFloat16
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool ShaderInt8
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool DescriptorIndexing
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool ShaderInputAttachmentArrayDynamicIndexing
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool ShaderUniformTexelBufferArrayDynamicIndexing
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool ShaderStorageTexelBufferArrayDynamicIndexing
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool ShaderUniformBufferArrayNonUniformIndexing
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool ShaderSampledImageArrayNonUniformIndexing
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool ShaderStorageBufferArrayNonUniformIndexing
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool ShaderStorageImageArrayNonUniformIndexing
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool ShaderInputAttachmentArrayNonUniformIndexing
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool ShaderUniformTexelBufferArrayNonUniformIndexing
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool ShaderStorageTexelBufferArrayNonUniformIndexing
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool DescriptorBindingUniformBufferUpdateAfterBind
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool DescriptorBindingSampledImageUpdateAfterBind
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool DescriptorBindingStorageImageUpdateAfterBind
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool DescriptorBindingStorageBufferUpdateAfterBind
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool DescriptorBindingUniformTexelBufferUpdateAfterBind
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool DescriptorBindingStorageTexelBufferUpdateAfterBind
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool DescriptorBindingUpdateUnusedWhilePending
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool DescriptorBindingPartiallyBound
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool DescriptorBindingVariableDescriptorCount
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool RuntimeDescriptorArray
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool SamplerFilterMinmax
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool ScalarBlockLayout
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool ImagelessFramebuffer
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool UniformBufferStandardLayout
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool ShaderSubgroupExtendedTypes
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool SeparateDepthStencilLayouts
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool HostQueryReset
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool TimelineSemaphore
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool BufferDeviceAddress
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool BufferDeviceAddressCaptureReplay
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool BufferDeviceAddressMultiDevice
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool VulkanMemoryModel
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool VulkanMemoryModelDeviceScope
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool VulkanMemoryModelAvailabilityVisibilityChains
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool ShaderOutputViewportIndex
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool ShaderOutputLayer
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool SubgroupBroadcastDynamicId
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(Interop.PhysicalDeviceVulkan12Features* pointer)
        {
            pointer->SType = StructureType.PhysicalDeviceVulkan12Features;
            pointer->Next = null;
            pointer->SamplerMirrorClampToEdge = SamplerMirrorClampToEdge;
            pointer->DrawIndirectCount = DrawIndirectCount;
            pointer->StorageBuffer8BitAccess = StorageBuffer8BitAccess;
            pointer->UniformAndStorageBuffer8BitAccess = UniformAndStorageBuffer8BitAccess;
            pointer->StoragePushConstant8 = StoragePushConstant8;
            pointer->ShaderBufferInt64Atomics = ShaderBufferInt64Atomics;
            pointer->ShaderSharedInt64Atomics = ShaderSharedInt64Atomics;
            pointer->ShaderFloat16 = ShaderFloat16;
            pointer->ShaderInt8 = ShaderInt8;
            pointer->DescriptorIndexing = DescriptorIndexing;
            pointer->ShaderInputAttachmentArrayDynamicIndexing = ShaderInputAttachmentArrayDynamicIndexing;
            pointer->ShaderUniformTexelBufferArrayDynamicIndexing = ShaderUniformTexelBufferArrayDynamicIndexing;
            pointer->ShaderStorageTexelBufferArrayDynamicIndexing = ShaderStorageTexelBufferArrayDynamicIndexing;
            pointer->ShaderUniformBufferArrayNonUniformIndexing = ShaderUniformBufferArrayNonUniformIndexing;
            pointer->ShaderSampledImageArrayNonUniformIndexing = ShaderSampledImageArrayNonUniformIndexing;
            pointer->ShaderStorageBufferArrayNonUniformIndexing = ShaderStorageBufferArrayNonUniformIndexing;
            pointer->ShaderStorageImageArrayNonUniformIndexing = ShaderStorageImageArrayNonUniformIndexing;
            pointer->ShaderInputAttachmentArrayNonUniformIndexing = ShaderInputAttachmentArrayNonUniformIndexing;
            pointer->ShaderUniformTexelBufferArrayNonUniformIndexing = ShaderUniformTexelBufferArrayNonUniformIndexing;
            pointer->ShaderStorageTexelBufferArrayNonUniformIndexing = ShaderStorageTexelBufferArrayNonUniformIndexing;
            pointer->DescriptorBindingUniformBufferUpdateAfterBind = DescriptorBindingUniformBufferUpdateAfterBind;
            pointer->DescriptorBindingSampledImageUpdateAfterBind = DescriptorBindingSampledImageUpdateAfterBind;
            pointer->DescriptorBindingStorageImageUpdateAfterBind = DescriptorBindingStorageImageUpdateAfterBind;
            pointer->DescriptorBindingStorageBufferUpdateAfterBind = DescriptorBindingStorageBufferUpdateAfterBind;
            pointer->DescriptorBindingUniformTexelBufferUpdateAfterBind = DescriptorBindingUniformTexelBufferUpdateAfterBind;
            pointer->DescriptorBindingStorageTexelBufferUpdateAfterBind = DescriptorBindingStorageTexelBufferUpdateAfterBind;
            pointer->DescriptorBindingUpdateUnusedWhilePending = DescriptorBindingUpdateUnusedWhilePending;
            pointer->DescriptorBindingPartiallyBound = DescriptorBindingPartiallyBound;
            pointer->DescriptorBindingVariableDescriptorCount = DescriptorBindingVariableDescriptorCount;
            pointer->RuntimeDescriptorArray = RuntimeDescriptorArray;
            pointer->SamplerFilterMinmax = SamplerFilterMinmax;
            pointer->ScalarBlockLayout = ScalarBlockLayout;
            pointer->ImagelessFramebuffer = ImagelessFramebuffer;
            pointer->UniformBufferStandardLayout = UniformBufferStandardLayout;
            pointer->ShaderSubgroupExtendedTypes = ShaderSubgroupExtendedTypes;
            pointer->SeparateDepthStencilLayouts = SeparateDepthStencilLayouts;
            pointer->HostQueryReset = HostQueryReset;
            pointer->TimelineSemaphore = TimelineSemaphore;
            pointer->BufferDeviceAddress = BufferDeviceAddress;
            pointer->BufferDeviceAddressCaptureReplay = BufferDeviceAddressCaptureReplay;
            pointer->BufferDeviceAddressMultiDevice = BufferDeviceAddressMultiDevice;
            pointer->VulkanMemoryModel = VulkanMemoryModel;
            pointer->VulkanMemoryModelDeviceScope = VulkanMemoryModelDeviceScope;
            pointer->VulkanMemoryModelAvailabilityVisibilityChains = VulkanMemoryModelAvailabilityVisibilityChains;
            pointer->ShaderOutputViewportIndex = ShaderOutputViewportIndex;
            pointer->ShaderOutputLayer = ShaderOutputLayer;
            pointer->SubgroupBroadcastDynamicId = SubgroupBroadcastDynamicId;
        }

        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe PhysicalDeviceVulkan12Features MarshalFrom(Interop.PhysicalDeviceVulkan12Features* pointer)
        {
            var result = default(PhysicalDeviceVulkan12Features);
            result.SamplerMirrorClampToEdge = pointer->SamplerMirrorClampToEdge;
            result.DrawIndirectCount = pointer->DrawIndirectCount;
            result.StorageBuffer8BitAccess = pointer->StorageBuffer8BitAccess;
            result.UniformAndStorageBuffer8BitAccess = pointer->UniformAndStorageBuffer8BitAccess;
            result.StoragePushConstant8 = pointer->StoragePushConstant8;
            result.ShaderBufferInt64Atomics = pointer->ShaderBufferInt64Atomics;
            result.ShaderSharedInt64Atomics = pointer->ShaderSharedInt64Atomics;
            result.ShaderFloat16 = pointer->ShaderFloat16;
            result.ShaderInt8 = pointer->ShaderInt8;
            result.DescriptorIndexing = pointer->DescriptorIndexing;
            result.ShaderInputAttachmentArrayDynamicIndexing = pointer->ShaderInputAttachmentArrayDynamicIndexing;
            result.ShaderUniformTexelBufferArrayDynamicIndexing = pointer->ShaderUniformTexelBufferArrayDynamicIndexing;
            result.ShaderStorageTexelBufferArrayDynamicIndexing = pointer->ShaderStorageTexelBufferArrayDynamicIndexing;
            result.ShaderUniformBufferArrayNonUniformIndexing = pointer->ShaderUniformBufferArrayNonUniformIndexing;
            result.ShaderSampledImageArrayNonUniformIndexing = pointer->ShaderSampledImageArrayNonUniformIndexing;
            result.ShaderStorageBufferArrayNonUniformIndexing = pointer->ShaderStorageBufferArrayNonUniformIndexing;
            result.ShaderStorageImageArrayNonUniformIndexing = pointer->ShaderStorageImageArrayNonUniformIndexing;
            result.ShaderInputAttachmentArrayNonUniformIndexing = pointer->ShaderInputAttachmentArrayNonUniformIndexing;
            result.ShaderUniformTexelBufferArrayNonUniformIndexing = pointer->ShaderUniformTexelBufferArrayNonUniformIndexing;
            result.ShaderStorageTexelBufferArrayNonUniformIndexing = pointer->ShaderStorageTexelBufferArrayNonUniformIndexing;
            result.DescriptorBindingUniformBufferUpdateAfterBind = pointer->DescriptorBindingUniformBufferUpdateAfterBind;
            result.DescriptorBindingSampledImageUpdateAfterBind = pointer->DescriptorBindingSampledImageUpdateAfterBind;
            result.DescriptorBindingStorageImageUpdateAfterBind = pointer->DescriptorBindingStorageImageUpdateAfterBind;
            result.DescriptorBindingStorageBufferUpdateAfterBind = pointer->DescriptorBindingStorageBufferUpdateAfterBind;
            result.DescriptorBindingUniformTexelBufferUpdateAfterBind = pointer->DescriptorBindingUniformTexelBufferUpdateAfterBind;
            result.DescriptorBindingStorageTexelBufferUpdateAfterBind = pointer->DescriptorBindingStorageTexelBufferUpdateAfterBind;
            result.DescriptorBindingUpdateUnusedWhilePending = pointer->DescriptorBindingUpdateUnusedWhilePending;
            result.DescriptorBindingPartiallyBound = pointer->DescriptorBindingPartiallyBound;
            result.DescriptorBindingVariableDescriptorCount = pointer->DescriptorBindingVariableDescriptorCount;
            result.RuntimeDescriptorArray = pointer->RuntimeDescriptorArray;
            result.SamplerFilterMinmax = pointer->SamplerFilterMinmax;
            result.ScalarBlockLayout = pointer->ScalarBlockLayout;
            result.ImagelessFramebuffer = pointer->ImagelessFramebuffer;
            result.UniformBufferStandardLayout = pointer->UniformBufferStandardLayout;
            result.ShaderSubgroupExtendedTypes = pointer->ShaderSubgroupExtendedTypes;
            result.SeparateDepthStencilLayouts = pointer->SeparateDepthStencilLayouts;
            result.HostQueryReset = pointer->HostQueryReset;
            result.TimelineSemaphore = pointer->TimelineSemaphore;
            result.BufferDeviceAddress = pointer->BufferDeviceAddress;
            result.BufferDeviceAddressCaptureReplay = pointer->BufferDeviceAddressCaptureReplay;
            result.BufferDeviceAddressMultiDevice = pointer->BufferDeviceAddressMultiDevice;
            result.VulkanMemoryModel = pointer->VulkanMemoryModel;
            result.VulkanMemoryModelDeviceScope = pointer->VulkanMemoryModelDeviceScope;
            result.VulkanMemoryModelAvailabilityVisibilityChains = pointer->VulkanMemoryModelAvailabilityVisibilityChains;
            result.ShaderOutputViewportIndex = pointer->ShaderOutputViewportIndex;
            result.ShaderOutputLayer = pointer->ShaderOutputLayer;
            result.SubgroupBroadcastDynamicId = pointer->SubgroupBroadcastDynamicId;
            return result;
        }
    }
}