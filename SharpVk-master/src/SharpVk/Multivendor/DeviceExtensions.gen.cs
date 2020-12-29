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

using System;
using SharpVk.Interop;
using SharpVk.Khronos;

namespace SharpVk.Multivendor
{
    /// <summary>
    /// </summary>
    public static class DeviceExtensions
    {
        /// <summary>
        ///     Set the power state of a display.
        /// </summary>
        /// <param name="extendedHandle">
        ///     The Device handle to extend.
        /// </param>
        /// <param name="display">
        /// </param>
        /// <param name="displayPowerInfo">
        /// </param>
        public static unsafe void DisplayPowerControl(this Device extendedHandle, Display display, DisplayPowerInfo displayPowerInfo)
        {
            try
            {
                var commandCache = default(CommandCache);
                var marshalledDisplayPowerInfo = default(Interop.Multivendor.DisplayPowerInfo*);
                commandCache = extendedHandle.CommandCache;
                marshalledDisplayPowerInfo = (Interop.Multivendor.DisplayPowerInfo*)HeapUtil.Allocate<Interop.Multivendor.DisplayPowerInfo>();
                displayPowerInfo.MarshalTo(marshalledDisplayPowerInfo);
                var commandDelegate = commandCache.Cache.VkDisplayPowerControlExt;
                var methodResult = commandDelegate(extendedHandle.Handle, display?.Handle ?? default(Interop.Khronos.Display), marshalledDisplayPowerInfo);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Signal a fence when a device event occurs.
        /// </summary>
        /// <param name="extendedHandle">
        ///     The Device handle to extend.
        /// </param>
        /// <param name="deviceEventInfo">
        /// </param>
        /// <param name="allocator">
        ///     An optional AllocationCallbacks instance that controls host memory
        ///     allocation.
        /// </param>
        public static unsafe Fence RegisterEvent(this Device extendedHandle, DeviceEventInfo deviceEventInfo, AllocationCallbacks? allocator = default)
        {
            try
            {
                var result = default(Fence);
                var commandCache = default(CommandCache);
                var marshalledDeviceEventInfo = default(Interop.Multivendor.DeviceEventInfo*);
                var marshalledAllocator = default(Interop.AllocationCallbacks*);
                var marshalledFence = default(Interop.Fence);
                commandCache = extendedHandle.CommandCache;
                marshalledDeviceEventInfo = (Interop.Multivendor.DeviceEventInfo*)HeapUtil.Allocate<Interop.Multivendor.DeviceEventInfo>();
                deviceEventInfo.MarshalTo(marshalledDeviceEventInfo);
                if (allocator != null)
                {
                    marshalledAllocator = (Interop.AllocationCallbacks*)HeapUtil.Allocate<Interop.AllocationCallbacks>();
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default;
                }
                var commandDelegate = commandCache.Cache.VkRegisterDeviceEventExt;
                var methodResult = commandDelegate(extendedHandle.Handle, marshalledDeviceEventInfo, marshalledAllocator, &marshalledFence);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                result = new(extendedHandle, marshalledFence);
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Signal a fence when a display event occurs.
        /// </summary>
        /// <param name="extendedHandle">
        ///     The Device handle to extend.
        /// </param>
        /// <param name="display">
        /// </param>
        /// <param name="displayEventInfo">
        /// </param>
        /// <param name="allocator">
        ///     An optional AllocationCallbacks instance that controls host memory
        ///     allocation.
        /// </param>
        public static unsafe Fence RegisterDisplayEvent(this Device extendedHandle, Display display, DisplayEventInfo displayEventInfo, AllocationCallbacks? allocator = default)
        {
            try
            {
                var result = default(Fence);
                var commandCache = default(CommandCache);
                var marshalledDisplayEventInfo = default(Interop.Multivendor.DisplayEventInfo*);
                var marshalledAllocator = default(Interop.AllocationCallbacks*);
                var marshalledFence = default(Interop.Fence);
                commandCache = extendedHandle.CommandCache;
                marshalledDisplayEventInfo = (Interop.Multivendor.DisplayEventInfo*)HeapUtil.Allocate<Interop.Multivendor.DisplayEventInfo>();
                displayEventInfo.MarshalTo(marshalledDisplayEventInfo);
                if (allocator != null)
                {
                    marshalledAllocator = (Interop.AllocationCallbacks*)HeapUtil.Allocate<Interop.AllocationCallbacks>();
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default;
                }
                var commandDelegate = commandCache.Cache.VkRegisterDisplayEventExt;
                var methodResult = commandDelegate(extendedHandle.Handle, display?.Handle ?? default(Interop.Khronos.Display), marshalledDisplayEventInfo, marshalledAllocator, &marshalledFence);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                result = new(extendedHandle, marshalledFence);
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
        /// <param name="swapchains">
        /// </param>
        /// <param name="metadata">
        /// </param>
        public static unsafe void SetHdrMetadata(this Device extendedHandle, ArrayProxy<Swapchain>? swapchains, ArrayProxy<HdrMetadata>? metadata)
        {
            try
            {
                var commandCache = default(CommandCache);
                var marshalledSwapchains = default(Interop.Khronos.Swapchain*);
                var marshalledMetadata = default(Interop.Multivendor.HdrMetadata*);
                commandCache = extendedHandle.CommandCache;
                if (swapchains.IsNull())
                {
                    marshalledSwapchains = null;
                }
                else
                {
                    if (swapchains.Value.Contents == ProxyContents.Single)
                    {
                        marshalledSwapchains = (Interop.Khronos.Swapchain*)HeapUtil.Allocate<Interop.Khronos.Swapchain>();
                        *marshalledSwapchains = swapchains.Value.GetSingleValue()?.Handle ?? default(Interop.Khronos.Swapchain);
                    }
                    else
                    {
                        var fieldPointer = (Interop.Khronos.Swapchain*)HeapUtil.AllocateAndClear<Interop.Khronos.Swapchain>(HeapUtil.GetLength(swapchains.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(swapchains.Value); index++) fieldPointer[index] = swapchains.Value[index]?.Handle ?? default(Interop.Khronos.Swapchain);
                        marshalledSwapchains = fieldPointer;
                    }
                }
                if (metadata.IsNull())
                {
                    marshalledMetadata = null;
                }
                else
                {
                    if (metadata.Value.Contents == ProxyContents.Single)
                    {
                        marshalledMetadata = (Interop.Multivendor.HdrMetadata*)HeapUtil.Allocate<Interop.Multivendor.HdrMetadata>();
                        metadata.Value.GetSingleValue().MarshalTo(&*marshalledMetadata);
                    }
                    else
                    {
                        var fieldPointer = (Interop.Multivendor.HdrMetadata*)HeapUtil.AllocateAndClear<Interop.Multivendor.HdrMetadata>(HeapUtil.GetLength(metadata.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(metadata.Value); index++) metadata.Value[index].MarshalTo(&fieldPointer[index]);
                        marshalledMetadata = fieldPointer;
                    }
                }
                var commandDelegate = commandCache.Cache.VkSetHdrMetadataExt;
                commandDelegate(extendedHandle.Handle, HeapUtil.GetLength(swapchains), marshalledSwapchains, marshalledMetadata);
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
        /// <param name="nameInfo">
        /// </param>
        public static unsafe void SetDebugUtilsObjectName(this Device extendedHandle, DebugUtilsObjectNameInfo nameInfo)
        {
            try
            {
                var commandCache = default(CommandCache);
                var marshalledNameInfo = default(Interop.Multivendor.DebugUtilsObjectNameInfo*);
                commandCache = extendedHandle.CommandCache;
                marshalledNameInfo = (Interop.Multivendor.DebugUtilsObjectNameInfo*)HeapUtil.Allocate<Interop.Multivendor.DebugUtilsObjectNameInfo>();
                nameInfo.MarshalTo(marshalledNameInfo);
                var commandDelegate = commandCache.Cache.VkSetDebugUtilsObjectNameExt;
                var methodResult = commandDelegate(extendedHandle.Handle, marshalledNameInfo);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
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
        /// <param name="tagInfo">
        /// </param>
        public static unsafe void SetDebugUtilsObjectTag(this Device extendedHandle, DebugUtilsObjectTagInfo tagInfo)
        {
            try
            {
                var commandCache = default(CommandCache);
                var marshalledTagInfo = default(Interop.Multivendor.DebugUtilsObjectTagInfo*);
                commandCache = extendedHandle.CommandCache;
                marshalledTagInfo = (Interop.Multivendor.DebugUtilsObjectTagInfo*)HeapUtil.Allocate<Interop.Multivendor.DebugUtilsObjectTagInfo>();
                tagInfo.MarshalTo(marshalledTagInfo);
                var commandDelegate = commandCache.Cache.VkSetDebugUtilsObjectTagExt;
                var methodResult = commandDelegate(extendedHandle.Handle, marshalledTagInfo);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
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
        /// <param name="flags">
        /// </param>
        /// <param name="initialData">
        /// </param>
        /// <param name="allocator">
        /// </param>
        public static unsafe ValidationCache CreateValidationCache(this Device extendedHandle, ArrayProxy<byte>? initialData, ValidationCacheCreateFlags? flags = default, AllocationCallbacks? allocator = default)
        {
            try
            {
                var result = default(ValidationCache);
                var commandCache = default(CommandCache);
                var marshalledCreateInfo = default(Interop.Multivendor.ValidationCacheCreateInfo*);
                var vkValidationCacheCreateInfoExtNextPointer = default(void*);
                var marshalledAllocator = default(Interop.AllocationCallbacks*);
                var marshalledValidationCache = default(Interop.Multivendor.ValidationCache);
                commandCache = extendedHandle.CommandCache;
                marshalledCreateInfo = (Interop.Multivendor.ValidationCacheCreateInfo*)HeapUtil.Allocate<Interop.Multivendor.ValidationCacheCreateInfo>();
                marshalledCreateInfo->SType = StructureType.ValidationCacheCreateInfo;
                marshalledCreateInfo->Next = vkValidationCacheCreateInfoExtNextPointer;
                if (flags != null)
                    marshalledCreateInfo->Flags = flags.Value;
                else
                    marshalledCreateInfo->Flags = default;
                marshalledCreateInfo->InitialDataSize = HeapUtil.GetLength(initialData);
                if (initialData.IsNull())
                {
                    marshalledCreateInfo->InitialData = null;
                }
                else
                {
                    if (initialData.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfo->InitialData = (byte*)HeapUtil.Allocate<byte>();
                        *marshalledCreateInfo->InitialData = initialData.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (byte*)HeapUtil.AllocateAndClear<byte>(HeapUtil.GetLength(initialData.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(initialData.Value); index++) fieldPointer[index] = initialData.Value[index];
                        marshalledCreateInfo->InitialData = fieldPointer;
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
                var commandDelegate = commandCache.Cache.VkCreateValidationCacheExt;
                var methodResult = commandDelegate(extendedHandle.Handle, marshalledCreateInfo, marshalledAllocator, &marshalledValidationCache);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                result = new(extendedHandle, marshalledValidationCache);
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
        /// <param name="handleType">
        /// </param>
        /// <param name="hostPointer">
        /// </param>
        public static unsafe MemoryHostPointerProperties GetMemoryHostPointerProperties(this Device extendedHandle, ExternalMemoryHandleTypeFlags handleType, IntPtr hostPointer)
        {
            try
            {
                var result = default(MemoryHostPointerProperties);
                var commandCache = default(CommandCache);
                var marshalledMemoryHostPointerProperties = default(Interop.Multivendor.MemoryHostPointerProperties);
                commandCache = extendedHandle.CommandCache;
                var commandDelegate = commandCache.Cache.VkGetMemoryHostPointerPropertiesExt;
                var methodResult = commandDelegate(extendedHandle.Handle, handleType, hostPointer.ToPointer(), &marshalledMemoryHostPointerProperties);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                result = MemoryHostPointerProperties.MarshalFrom(&marshalledMemoryHostPointerProperties);
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
        /// <param name="timestampInfos">
        /// </param>
        /// <param name="timestamps">
        /// </param>
        public static unsafe ulong GetCalibratedTimestamps(this Device extendedHandle, ArrayProxy<CalibratedTimestampInfo>? timestampInfos, ArrayProxy<ulong>? timestamps)
        {
            try
            {
                var result = default(ulong);
                var commandCache = default(CommandCache);
                var marshalledTimestampInfos = default(Interop.Multivendor.CalibratedTimestampInfo*);
                var marshalledTimestamps = default(ulong*);
                var marshalledMaxDeviation = default(ulong);
                commandCache = extendedHandle.CommandCache;
                if (timestampInfos.IsNull())
                {
                    marshalledTimestampInfos = null;
                }
                else
                {
                    if (timestampInfos.Value.Contents == ProxyContents.Single)
                    {
                        marshalledTimestampInfos = (Interop.Multivendor.CalibratedTimestampInfo*)HeapUtil.Allocate<Interop.Multivendor.CalibratedTimestampInfo>();
                        timestampInfos.Value.GetSingleValue().MarshalTo(&*marshalledTimestampInfos);
                    }
                    else
                    {
                        var fieldPointer = (Interop.Multivendor.CalibratedTimestampInfo*)HeapUtil.AllocateAndClear<Interop.Multivendor.CalibratedTimestampInfo>(HeapUtil.GetLength(timestampInfos.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(timestampInfos.Value); index++) timestampInfos.Value[index].MarshalTo(&fieldPointer[index]);
                        marshalledTimestampInfos = fieldPointer;
                    }
                }
                if (timestamps.IsNull())
                {
                    marshalledTimestamps = null;
                }
                else
                {
                    if (timestamps.Value.Contents == ProxyContents.Single)
                    {
                        marshalledTimestamps = (ulong*)HeapUtil.Allocate<ulong>();
                        *marshalledTimestamps = timestamps.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (ulong*)HeapUtil.AllocateAndClear<ulong>(HeapUtil.GetLength(timestamps.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(timestamps.Value); index++) fieldPointer[index] = timestamps.Value[index];
                        marshalledTimestamps = fieldPointer;
                    }
                }
                var commandDelegate = commandCache.Cache.VkGetCalibratedTimestampsExt;
                var methodResult = commandDelegate(extendedHandle.Handle, HeapUtil.GetLength(timestampInfos), marshalledTimestampInfos, marshalledTimestamps, &marshalledMaxDeviation);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                result = marshalledMaxDeviation;
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Query device group present capabilities for a surface
        /// </summary>
        /// <param name="extendedHandle">
        ///     The Device handle to extend.
        /// </param>
        /// <param name="surfaceInfo">
        ///     An instance of the VkPhysicalDeviceSurfaceInfo2KHR structure,
        ///     describing the surface and other fixed parameters that would be
        ///     consumed by vkCreateSwapchainKHR.
        /// </param>
        public static unsafe DeviceGroupPresentModeFlags GetGroupSurfacePresentModes2(this Device extendedHandle, PhysicalDeviceSurfaceInfo2 surfaceInfo)
        {
            try
            {
                var result = default(DeviceGroupPresentModeFlags);
                var commandCache = default(CommandCache);
                var marshalledSurfaceInfo = default(Interop.Khronos.PhysicalDeviceSurfaceInfo2*);
                var marshalledModes = default(DeviceGroupPresentModeFlags);
                commandCache = extendedHandle.CommandCache;
                marshalledSurfaceInfo = (Interop.Khronos.PhysicalDeviceSurfaceInfo2*)HeapUtil.Allocate<Interop.Khronos.PhysicalDeviceSurfaceInfo2>();
                surfaceInfo.MarshalTo(marshalledSurfaceInfo);
                var commandDelegate = commandCache.Cache.VkGetDeviceGroupSurfacePresentModes2Ext;
                var methodResult = commandDelegate(extendedHandle.Handle, marshalledSurfaceInfo, &marshalledModes);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                result = marshalledModes;
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }
    }
}
