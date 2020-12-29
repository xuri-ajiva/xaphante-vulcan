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

namespace SharpVk.NVidia.Experimental
{
    /// <summary>
    /// </summary>
    public static class DeviceExtensions
    {
        /// <summary>
        ///     Get the handle for an image view for a specific descriptor type
        /// </summary>
        /// <param name="extendedHandle">
        ///     The Device handle to extend.
        /// </param>
        /// <param name="info">
        ///     Describes the image view to query and type of handle.
        /// </param>
        public static unsafe void GetImageViewHandle(this Device extendedHandle, ImageViewHandleInfo info)
        {
            try
            {
                var commandCache = default(CommandCache);
                var marshalledInfo = default(Interop.NVidia.Experimental.ImageViewHandleInfo*);
                commandCache = extendedHandle.CommandCache;
                marshalledInfo = (Interop.NVidia.Experimental.ImageViewHandleInfo*)HeapUtil.Allocate<Interop.NVidia.Experimental.ImageViewHandleInfo>();
                info.MarshalTo(marshalledInfo);
                var commandDelegate = commandCache.Cache.VkGetImageViewHandleNvx;
                commandDelegate(extendedHandle.Handle, marshalledInfo);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="extendedHandle">
        ///     The Device handle to extend.
        /// </param>
        /// <param name="pipelineBindPoint">
        ///     The PipelineBindPoint that this layout targets.
        /// </param>
        /// <param name="flags">
        ///     A bitmask providing usage hints of this layout. See
        ///     IndirectCommandsLayoutUsageFlagBitsNVX below for a description of
        ///     the supported bits.
        /// </param>
        /// <param name="tokens">
        /// </param>
        /// <param name="allocator">
        ///     An optional AllocationCallbacks instance that controls host memory
        ///     allocation.
        /// </param>
        public static unsafe IndirectCommandsLayout CreateIndirectCommandsLayout(this Device extendedHandle, PipelineBindPoint pipelineBindPoint, IndirectCommandsLayoutUsageFlags flags, ArrayProxy<IndirectCommandsLayoutToken>? tokens, AllocationCallbacks? allocator = default)
        {
            try
            {
                var result = default(IndirectCommandsLayout);
                var commandCache = default(CommandCache);
                var marshalledCreateInfo = default(Interop.NVidia.Experimental.IndirectCommandsLayoutCreateInfo*);
                var vkIndirectCommandsLayoutCreateInfoNvxNextPointer = default(void*);
                var marshalledAllocator = default(Interop.AllocationCallbacks*);
                var marshalledIndirectCommandsLayout = default(Interop.NVidia.Experimental.IndirectCommandsLayout);
                commandCache = extendedHandle.CommandCache;
                marshalledCreateInfo = (Interop.NVidia.Experimental.IndirectCommandsLayoutCreateInfo*)HeapUtil.Allocate<Interop.NVidia.Experimental.IndirectCommandsLayoutCreateInfo>();
                marshalledCreateInfo->SType = StructureType.IndirectCommandsLayoutCreateInfo;
                marshalledCreateInfo->Next = vkIndirectCommandsLayoutCreateInfoNvxNextPointer;
                marshalledCreateInfo->PipelineBindPoint = pipelineBindPoint;
                marshalledCreateInfo->Flags = flags;
                marshalledCreateInfo->TokenCount = HeapUtil.GetLength(tokens);
                if (tokens.IsNull())
                {
                    marshalledCreateInfo->Tokens = null;
                }
                else
                {
                    if (tokens.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfo->Tokens = (IndirectCommandsLayoutToken*)HeapUtil.Allocate<IndirectCommandsLayoutToken>();
                        *marshalledCreateInfo->Tokens = tokens.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (IndirectCommandsLayoutToken*)HeapUtil.AllocateAndClear<IndirectCommandsLayoutToken>(HeapUtil.GetLength(tokens.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(tokens.Value); index++) fieldPointer[index] = tokens.Value[index];
                        marshalledCreateInfo->Tokens = fieldPointer;
                    }
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
                var commandDelegate = commandCache.Cache.VkCreateIndirectCommandsLayoutNvx;
                var methodResult = commandDelegate(extendedHandle.Handle, marshalledCreateInfo, marshalledAllocator, &marshalledIndirectCommandsLayout);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                result = new(extendedHandle, marshalledIndirectCommandsLayout);
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="extendedHandle">
        ///     The Device handle to extend.
        /// </param>
        /// <param name="objectEntryTypes">
        /// </param>
        /// <param name="objectEntryCounts">
        /// </param>
        /// <param name="objectEntryUsageFlags">
        /// </param>
        /// <param name="maxUniformBuffersPerDescriptor">
        ///     The maximum number of DescriptorType.UniformBuffer or
        ///     DescriptorType.UniformBufferDynamic used by any single registered
        ///     DescriptorSet in this table.
        /// </param>
        /// <param name="maxStorageBuffersPerDescriptor">
        ///     The maximum number of DescriptorType.StorageBuffer or
        ///     DescriptorType.StorageBufferDynamic used by any single registered
        ///     DescriptorSet in this table.
        /// </param>
        /// <param name="maxStorageImagesPerDescriptor">
        ///     The maximum number of DescriptorType.StorageImage or
        ///     DescriptorType.StorageTexelBuffer used by any single registered
        ///     DescriptorSet in this table.
        /// </param>
        /// <param name="maxSampledImagesPerDescriptor">
        ///     The maximum number of DescriptorType.Sampler,
        ///     DescriptorType.CombinedImageSampler, DescriptorType.UniformTexelBuffer
        ///     or DescriptorType.InputAttachment used by any single registered
        ///     DescriptorSet in this table.
        /// </param>
        /// <param name="maxPipelineLayouts">
        ///     The maximum number of unique PipelineLayout used by any registered
        ///     DescriptorSet or Pipeline in this table.
        /// </param>
        /// <param name="allocator">
        ///     An optional AllocationCallbacks instance that controls host memory
        ///     allocation.
        /// </param>
        public static unsafe ObjectTable CreateObjectTable(this Device extendedHandle, ArrayProxy<ObjectEntryType>? objectEntryTypes, ArrayProxy<uint>? objectEntryCounts, ArrayProxy<ObjectEntryUsageFlags>? objectEntryUsageFlags, uint maxUniformBuffersPerDescriptor, uint maxStorageBuffersPerDescriptor, uint maxStorageImagesPerDescriptor, uint maxSampledImagesPerDescriptor, uint maxPipelineLayouts, AllocationCallbacks? allocator = default)
        {
            try
            {
                var result = default(ObjectTable);
                var commandCache = default(CommandCache);
                var marshalledCreateInfo = default(Interop.NVidia.Experimental.ObjectTableCreateInfo*);
                var vkObjectTableCreateInfoNvxNextPointer = default(void*);
                var marshalledAllocator = default(Interop.AllocationCallbacks*);
                var marshalledObjectTable = default(Interop.NVidia.Experimental.ObjectTable);
                commandCache = extendedHandle.CommandCache;
                marshalledCreateInfo = (Interop.NVidia.Experimental.ObjectTableCreateInfo*)HeapUtil.Allocate<Interop.NVidia.Experimental.ObjectTableCreateInfo>();
                marshalledCreateInfo->SType = StructureType.ObjectTableCreateInfo;
                marshalledCreateInfo->Next = vkObjectTableCreateInfoNvxNextPointer;
                marshalledCreateInfo->ObjectCount = HeapUtil.GetLength(objectEntryTypes);
                if (objectEntryTypes.IsNull())
                {
                    marshalledCreateInfo->ObjectEntryTypes = null;
                }
                else
                {
                    if (objectEntryTypes.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfo->ObjectEntryTypes = (ObjectEntryType*)HeapUtil.Allocate<ObjectEntryType>();
                        *marshalledCreateInfo->ObjectEntryTypes = objectEntryTypes.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (ObjectEntryType*)HeapUtil.AllocateAndClear<ObjectEntryType>(HeapUtil.GetLength(objectEntryTypes.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(objectEntryTypes.Value); index++) fieldPointer[index] = objectEntryTypes.Value[index];
                        marshalledCreateInfo->ObjectEntryTypes = fieldPointer;
                    }
                }
                if (objectEntryCounts.IsNull())
                {
                    marshalledCreateInfo->ObjectEntryCounts = null;
                }
                else
                {
                    if (objectEntryCounts.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfo->ObjectEntryCounts = (uint*)HeapUtil.Allocate<uint>();
                        *marshalledCreateInfo->ObjectEntryCounts = objectEntryCounts.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (uint*)HeapUtil.AllocateAndClear<uint>(HeapUtil.GetLength(objectEntryCounts.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(objectEntryCounts.Value); index++) fieldPointer[index] = objectEntryCounts.Value[index];
                        marshalledCreateInfo->ObjectEntryCounts = fieldPointer;
                    }
                }
                if (objectEntryUsageFlags.IsNull())
                {
                    marshalledCreateInfo->ObjectEntryUsageFlags = null;
                }
                else
                {
                    if (objectEntryUsageFlags.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfo->ObjectEntryUsageFlags = (ObjectEntryUsageFlags*)HeapUtil.Allocate<ObjectEntryUsageFlags>();
                        *marshalledCreateInfo->ObjectEntryUsageFlags = objectEntryUsageFlags.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (ObjectEntryUsageFlags*)HeapUtil.AllocateAndClear<ObjectEntryUsageFlags>(HeapUtil.GetLength(objectEntryUsageFlags.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(objectEntryUsageFlags.Value); index++) fieldPointer[index] = objectEntryUsageFlags.Value[index];
                        marshalledCreateInfo->ObjectEntryUsageFlags = fieldPointer;
                    }
                }
                marshalledCreateInfo->MaxUniformBuffersPerDescriptor = maxUniformBuffersPerDescriptor;
                marshalledCreateInfo->MaxStorageBuffersPerDescriptor = maxStorageBuffersPerDescriptor;
                marshalledCreateInfo->MaxStorageImagesPerDescriptor = maxStorageImagesPerDescriptor;
                marshalledCreateInfo->MaxSampledImagesPerDescriptor = maxSampledImagesPerDescriptor;
                marshalledCreateInfo->MaxPipelineLayouts = maxPipelineLayouts;
                if (allocator != null)
                {
                    marshalledAllocator = (Interop.AllocationCallbacks*)HeapUtil.Allocate<Interop.AllocationCallbacks>();
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default;
                }
                var commandDelegate = commandCache.Cache.VkCreateObjectTableNvx;
                var methodResult = commandDelegate(extendedHandle.Handle, marshalledCreateInfo, marshalledAllocator, &marshalledObjectTable);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                result = new(extendedHandle, marshalledObjectTable);
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }
    }
}
