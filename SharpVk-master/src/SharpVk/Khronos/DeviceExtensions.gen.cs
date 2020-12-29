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
using SharpVk.Amd;
using SharpVk.Interop;
using SharpVk.Multivendor;

namespace SharpVk.Khronos
{
    /// <summary>
    /// </summary>
    public static class DeviceExtensions
    {
        /// <summary>
        ///     Create a swapchain.
        /// </summary>
        /// <param name="extendedHandle">
        ///     The Device handle to extend.
        /// </param>
        /// <param name="flags">
        ///     A bitmask indicating parameters of swapchain creation. Bits which
        ///     can be set include: + --
        /// </param>
        /// <param name="surface">
        /// </param>
        /// <param name="minImageCount">
        /// </param>
        /// <param name="imageFormat">
        /// </param>
        /// <param name="imageColorSpace">
        /// </param>
        /// <param name="imageExtent">
        /// </param>
        /// <param name="imageArrayLayers">
        /// </param>
        /// <param name="imageUsage">
        /// </param>
        /// <param name="imageSharingMode">
        /// </param>
        /// <param name="queueFamilyIndices">
        /// </param>
        /// <param name="preTransform">
        /// </param>
        /// <param name="compositeAlpha">
        /// </param>
        /// <param name="presentMode">
        /// </param>
        /// <param name="clipped">
        /// </param>
        /// <param name="oldSwapchain">
        /// </param>
        /// <param name="swapchainCounterCreateInfoExt">
        ///     Extension struct
        /// </param>
        /// <param name="deviceGroupSwapchainCreateInfoKhr">
        ///     Extension struct
        /// </param>
        /// <param name="swapchainDisplayNativeHdrCreateInfoAmd">
        ///     Extension struct
        /// </param>
        /// <param name="imageFormatListCreateInfo">
        ///     Extension struct
        /// </param>
        /// <param name="surfaceFullScreenExclusiveInfoExt">
        ///     Extension struct
        /// </param>
        /// <param name="surfaceFullScreenExclusiveWin32InfoExt">
        ///     Extension struct
        /// </param>
        /// <param name="allocator">
        ///     An optional AllocationCallbacks instance that controls host memory
        ///     allocation.
        /// </param>
        public static unsafe Swapchain CreateSwapchain(this Device extendedHandle, Surface surface, uint minImageCount, Format imageFormat, ColorSpace imageColorSpace, Extent2D imageExtent, uint imageArrayLayers, ImageUsageFlags imageUsage, SharingMode imageSharingMode, ArrayProxy<uint>? queueFamilyIndices, SurfaceTransformFlags preTransform, CompositeAlphaFlags compositeAlpha, PresentMode presentMode, bool clipped, Swapchain oldSwapchain, SwapchainCreateFlags? flags = default, SwapchainCounterCreateInfo? swapchainCounterCreateInfoExt = null, DeviceGroupSwapchainCreateInfo? deviceGroupSwapchainCreateInfoKhr = null,
            SwapchainDisplayNativeHdrCreateInfo? swapchainDisplayNativeHdrCreateInfoAmd = null, ImageFormatListCreateInfo? imageFormatListCreateInfo = null, SurfaceFullScreenExclusiveInfo? surfaceFullScreenExclusiveInfoExt = null, SurfaceFullScreenExclusiveWin32Info? surfaceFullScreenExclusiveWin32InfoExt = null, AllocationCallbacks? allocator = default)
        {
            try
            {
                var result = default(Swapchain);
                var commandCache = default(CommandCache);
                var marshalledCreateInfo = default(Interop.Khronos.SwapchainCreateInfo*);
                var vkSwapchainCreateInfoKhrNextPointer = default(void*);
                var marshalledAllocator = default(Interop.AllocationCallbacks*);
                var marshalledSwapchain = default(Interop.Khronos.Swapchain);
                if (swapchainCounterCreateInfoExt != null)
                {
                    var extensionPointer = default(Interop.Multivendor.SwapchainCounterCreateInfo*);
                    extensionPointer = (Interop.Multivendor.SwapchainCounterCreateInfo*)HeapUtil.Allocate<Interop.Multivendor.SwapchainCounterCreateInfo>();
                    swapchainCounterCreateInfoExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkSwapchainCreateInfoKhrNextPointer;
                    vkSwapchainCreateInfoKhrNextPointer = extensionPointer;
                }
                if (deviceGroupSwapchainCreateInfoKhr != null)
                {
                    var extensionPointer = default(Interop.Khronos.DeviceGroupSwapchainCreateInfo*);
                    extensionPointer = (Interop.Khronos.DeviceGroupSwapchainCreateInfo*)HeapUtil.Allocate<Interop.Khronos.DeviceGroupSwapchainCreateInfo>();
                    deviceGroupSwapchainCreateInfoKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkSwapchainCreateInfoKhrNextPointer;
                    vkSwapchainCreateInfoKhrNextPointer = extensionPointer;
                }
                if (swapchainDisplayNativeHdrCreateInfoAmd != null)
                {
                    var extensionPointer = default(Interop.Amd.SwapchainDisplayNativeHdrCreateInfo*);
                    extensionPointer = (Interop.Amd.SwapchainDisplayNativeHdrCreateInfo*)HeapUtil.Allocate<Interop.Amd.SwapchainDisplayNativeHdrCreateInfo>();
                    swapchainDisplayNativeHdrCreateInfoAmd.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkSwapchainCreateInfoKhrNextPointer;
                    vkSwapchainCreateInfoKhrNextPointer = extensionPointer;
                }
                if (imageFormatListCreateInfo != null)
                {
                    var extensionPointer = default(Interop.ImageFormatListCreateInfo*);
                    extensionPointer = (Interop.ImageFormatListCreateInfo*)HeapUtil.Allocate<Interop.ImageFormatListCreateInfo>();
                    imageFormatListCreateInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkSwapchainCreateInfoKhrNextPointer;
                    vkSwapchainCreateInfoKhrNextPointer = extensionPointer;
                }
                if (surfaceFullScreenExclusiveInfoExt != null)
                {
                    var extensionPointer = default(Interop.Multivendor.SurfaceFullScreenExclusiveInfo*);
                    extensionPointer = (Interop.Multivendor.SurfaceFullScreenExclusiveInfo*)HeapUtil.Allocate<Interop.Multivendor.SurfaceFullScreenExclusiveInfo>();
                    surfaceFullScreenExclusiveInfoExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkSwapchainCreateInfoKhrNextPointer;
                    vkSwapchainCreateInfoKhrNextPointer = extensionPointer;
                }
                if (surfaceFullScreenExclusiveWin32InfoExt != null)
                {
                    var extensionPointer = default(Interop.Multivendor.SurfaceFullScreenExclusiveWin32Info*);
                    extensionPointer = (Interop.Multivendor.SurfaceFullScreenExclusiveWin32Info*)HeapUtil.Allocate<Interop.Multivendor.SurfaceFullScreenExclusiveWin32Info>();
                    surfaceFullScreenExclusiveWin32InfoExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkSwapchainCreateInfoKhrNextPointer;
                    vkSwapchainCreateInfoKhrNextPointer = extensionPointer;
                }
                commandCache = extendedHandle.CommandCache;
                marshalledCreateInfo = (Interop.Khronos.SwapchainCreateInfo*)HeapUtil.Allocate<Interop.Khronos.SwapchainCreateInfo>();
                marshalledCreateInfo->SType = StructureType.SwapchainCreateInfo;
                marshalledCreateInfo->Next = vkSwapchainCreateInfoKhrNextPointer;
                if (flags != null)
                    marshalledCreateInfo->Flags = flags.Value;
                else
                    marshalledCreateInfo->Flags = default;
                marshalledCreateInfo->Surface = surface?.Handle ?? default(Interop.Khronos.Surface);
                marshalledCreateInfo->MinImageCount = minImageCount;
                marshalledCreateInfo->ImageFormat = imageFormat;
                marshalledCreateInfo->ImageColorSpace = imageColorSpace;
                marshalledCreateInfo->ImageExtent = imageExtent;
                marshalledCreateInfo->ImageArrayLayers = imageArrayLayers;
                marshalledCreateInfo->ImageUsage = imageUsage;
                marshalledCreateInfo->ImageSharingMode = imageSharingMode;
                marshalledCreateInfo->QueueFamilyIndexCount = HeapUtil.GetLength(queueFamilyIndices);
                if (queueFamilyIndices.IsNull())
                {
                    marshalledCreateInfo->QueueFamilyIndices = null;
                }
                else
                {
                    if (queueFamilyIndices.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfo->QueueFamilyIndices = (uint*)HeapUtil.Allocate<uint>();
                        *marshalledCreateInfo->QueueFamilyIndices = queueFamilyIndices.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (uint*)HeapUtil.AllocateAndClear<uint>(HeapUtil.GetLength(queueFamilyIndices.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(queueFamilyIndices.Value); index++) fieldPointer[index] = queueFamilyIndices.Value[index];
                        marshalledCreateInfo->QueueFamilyIndices = fieldPointer;
                    }
                }
                marshalledCreateInfo->PreTransform = preTransform;
                marshalledCreateInfo->CompositeAlpha = compositeAlpha;
                marshalledCreateInfo->PresentMode = presentMode;
                marshalledCreateInfo->Clipped = clipped;
                marshalledCreateInfo->OldSwapchain = oldSwapchain?.Handle ?? default(Interop.Khronos.Swapchain);
                if (allocator != null)
                {
                    marshalledAllocator = (Interop.AllocationCallbacks*)HeapUtil.Allocate<Interop.AllocationCallbacks>();
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default;
                }
                var commandDelegate = commandCache.Cache.VkCreateSwapchainKhr;
                var methodResult = commandDelegate(extendedHandle.Handle, marshalledCreateInfo, marshalledAllocator, &marshalledSwapchain);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                result = new(extendedHandle, marshalledSwapchain);
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
        public static unsafe DeviceGroupPresentCapabilities GetGroupPresentCapabilities(this Device extendedHandle)
        {
            try
            {
                var result = default(DeviceGroupPresentCapabilities);
                var commandCache = default(CommandCache);
                var marshalledDeviceGroupPresentCapabilities = default(Interop.Khronos.DeviceGroupPresentCapabilities);
                commandCache = extendedHandle.CommandCache;
                var commandDelegate = commandCache.Cache.VkGetDeviceGroupPresentCapabilitiesKhr;
                var methodResult = commandDelegate(extendedHandle.Handle, &marshalledDeviceGroupPresentCapabilities);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                result = DeviceGroupPresentCapabilities.MarshalFrom(&marshalledDeviceGroupPresentCapabilities);
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
        /// <param name="surface">
        /// </param>
        public static unsafe DeviceGroupPresentModeFlags GetGroupSurfacePresentModes(this Device extendedHandle, Surface surface)
        {
            try
            {
                var result = default(DeviceGroupPresentModeFlags);
                var commandCache = default(CommandCache);
                var marshalledModes = default(DeviceGroupPresentModeFlags);
                commandCache = extendedHandle.CommandCache;
                var commandDelegate = commandCache.Cache.VkGetDeviceGroupSurfacePresentModesKhr;
                var methodResult = commandDelegate(extendedHandle.Handle, surface?.Handle ?? default(Interop.Khronos.Surface), &marshalledModes);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                result = marshalledModes;
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Retrieve the index of the next available presentable image.
        /// </summary>
        /// <param name="extendedHandle">
        ///     The Device handle to extend.
        /// </param>
        /// <param name="acquireInfo">
        /// </param>
        public static unsafe uint AcquireNextImage2(this Device extendedHandle, AcquireNextImageInfo acquireInfo)
        {
            try
            {
                var result = default(uint);
                var commandCache = default(CommandCache);
                var marshalledAcquireInfo = default(Interop.Khronos.AcquireNextImageInfo*);
                var marshalledImageIndex = default(uint);
                commandCache = extendedHandle.CommandCache;
                marshalledAcquireInfo = (Interop.Khronos.AcquireNextImageInfo*)HeapUtil.Allocate<Interop.Khronos.AcquireNextImageInfo>();
                acquireInfo.MarshalTo(marshalledAcquireInfo);
                var commandDelegate = commandCache.Cache.VkAcquireNextImage2Khr;
                var methodResult = commandDelegate(extendedHandle.Handle, marshalledAcquireInfo, &marshalledImageIndex);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                result = marshalledImageIndex;
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Create multiple swapchains that share presentable images.
        /// </summary>
        /// <param name="extendedHandle">
        ///     The Device handle to extend.
        /// </param>
        /// <param name="createInfos">
        /// </param>
        /// <param name="allocator">
        ///     An optional AllocationCallbacks instance that controls host memory
        ///     allocation.
        /// </param>
        public static unsafe Swapchain[] CreateSharedSwapchains(this Device extendedHandle, ArrayProxy<SwapchainCreateInfo>? createInfos, AllocationCallbacks? allocator = default)
        {
            try
            {
                var result = default(Swapchain[]);
                var commandCache = default(CommandCache);
                var marshalledSwapchainCount = default(uint);
                var marshalledCreateInfos = default(Interop.Khronos.SwapchainCreateInfo*);
                var marshalledAllocator = default(Interop.AllocationCallbacks*);
                var marshalledSwapchains = default(Interop.Khronos.Swapchain*);
                commandCache = extendedHandle.CommandCache;
                marshalledSwapchainCount = HeapUtil.GetLength(createInfos);
                if (createInfos.IsNull())
                {
                    marshalledCreateInfos = null;
                }
                else
                {
                    if (createInfos.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfos = (Interop.Khronos.SwapchainCreateInfo*)HeapUtil.Allocate<Interop.Khronos.SwapchainCreateInfo>();
                        createInfos.Value.GetSingleValue().MarshalTo(&*marshalledCreateInfos);
                    }
                    else
                    {
                        var fieldPointer = (Interop.Khronos.SwapchainCreateInfo*)HeapUtil.AllocateAndClear<Interop.Khronos.SwapchainCreateInfo>(HeapUtil.GetLength(createInfos.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(createInfos.Value); index++) createInfos.Value[index].MarshalTo(&fieldPointer[index]);
                        marshalledCreateInfos = fieldPointer;
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
                marshalledSwapchains = (Interop.Khronos.Swapchain*)HeapUtil.Allocate<Interop.Khronos.Swapchain>(marshalledSwapchainCount);
                var commandDelegate = commandCache.Cache.VkCreateSharedSwapchainsKhr;
                var methodResult = commandDelegate(extendedHandle.Handle, marshalledSwapchainCount, marshalledCreateInfos, marshalledAllocator, marshalledSwapchains);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                if (marshalledSwapchains != null)
                {
                    var fieldPointer = new Swapchain[marshalledSwapchainCount];
                    for (var index = 0; index < marshalledSwapchainCount; index++) fieldPointer[index] = new(extendedHandle, marshalledSwapchains[index]);
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
        ///     Create multiple swapchains that share presentable images.
        /// </summary>
        /// <param name="extendedHandle">
        ///     The Device handle to extend.
        /// </param>
        /// <param name="flags">
        ///     A bitmask indicating parameters of swapchain creation. Bits which
        ///     can be set include: + --
        /// </param>
        /// <param name="surface">
        /// </param>
        /// <param name="minImageCount">
        /// </param>
        /// <param name="imageFormat">
        /// </param>
        /// <param name="imageColorSpace">
        /// </param>
        /// <param name="imageExtent">
        /// </param>
        /// <param name="imageArrayLayers">
        /// </param>
        /// <param name="imageUsage">
        /// </param>
        /// <param name="imageSharingMode">
        /// </param>
        /// <param name="queueFamilyIndices">
        /// </param>
        /// <param name="preTransform">
        /// </param>
        /// <param name="compositeAlpha">
        /// </param>
        /// <param name="presentMode">
        /// </param>
        /// <param name="clipped">
        /// </param>
        /// <param name="oldSwapchain">
        /// </param>
        /// <param name="swapchainCounterCreateInfoExt">
        ///     Extension struct
        /// </param>
        /// <param name="deviceGroupSwapchainCreateInfoKhr">
        ///     Extension struct
        /// </param>
        /// <param name="swapchainDisplayNativeHdrCreateInfoAmd">
        ///     Extension struct
        /// </param>
        /// <param name="imageFormatListCreateInfo">
        ///     Extension struct
        /// </param>
        /// <param name="surfaceFullScreenExclusiveInfoExt">
        ///     Extension struct
        /// </param>
        /// <param name="surfaceFullScreenExclusiveWin32InfoExt">
        ///     Extension struct
        /// </param>
        /// <param name="allocator">
        ///     An optional AllocationCallbacks instance that controls host memory
        ///     allocation.
        /// </param>
        public static unsafe Swapchain CreateSharedSwapchain(this Device extendedHandle, Surface surface, uint minImageCount, Format imageFormat, ColorSpace imageColorSpace, Extent2D imageExtent, uint imageArrayLayers, ImageUsageFlags imageUsage, SharingMode imageSharingMode, ArrayProxy<uint>? queueFamilyIndices, SurfaceTransformFlags preTransform, CompositeAlphaFlags compositeAlpha, PresentMode presentMode, bool clipped, Swapchain oldSwapchain, SwapchainCreateFlags? flags = default, SwapchainCounterCreateInfo? swapchainCounterCreateInfoExt = null, DeviceGroupSwapchainCreateInfo? deviceGroupSwapchainCreateInfoKhr = null,
            SwapchainDisplayNativeHdrCreateInfo? swapchainDisplayNativeHdrCreateInfoAmd = null, ImageFormatListCreateInfo? imageFormatListCreateInfo = null, SurfaceFullScreenExclusiveInfo? surfaceFullScreenExclusiveInfoExt = null, SurfaceFullScreenExclusiveWin32Info? surfaceFullScreenExclusiveWin32InfoExt = null, AllocationCallbacks? allocator = default)
        {
            try
            {
                var result = default(Swapchain);
                var commandCache = default(CommandCache);
                var marshalledSwapchainCount = default(uint);
                var marshalledCreateInfos = default(Interop.Khronos.SwapchainCreateInfo*);
                var vkSwapchainCreateInfoKhrNextPointer = default(void*);
                var marshalledAllocator = default(Interop.AllocationCallbacks*);
                var marshalledSwapchains = default(Interop.Khronos.Swapchain*);
                if (swapchainCounterCreateInfoExt != null)
                {
                    var extensionPointer = default(Interop.Multivendor.SwapchainCounterCreateInfo*);
                    extensionPointer = (Interop.Multivendor.SwapchainCounterCreateInfo*)HeapUtil.Allocate<Interop.Multivendor.SwapchainCounterCreateInfo>();
                    swapchainCounterCreateInfoExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkSwapchainCreateInfoKhrNextPointer;
                    vkSwapchainCreateInfoKhrNextPointer = extensionPointer;
                }
                if (deviceGroupSwapchainCreateInfoKhr != null)
                {
                    var extensionPointer = default(Interop.Khronos.DeviceGroupSwapchainCreateInfo*);
                    extensionPointer = (Interop.Khronos.DeviceGroupSwapchainCreateInfo*)HeapUtil.Allocate<Interop.Khronos.DeviceGroupSwapchainCreateInfo>();
                    deviceGroupSwapchainCreateInfoKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkSwapchainCreateInfoKhrNextPointer;
                    vkSwapchainCreateInfoKhrNextPointer = extensionPointer;
                }
                if (swapchainDisplayNativeHdrCreateInfoAmd != null)
                {
                    var extensionPointer = default(Interop.Amd.SwapchainDisplayNativeHdrCreateInfo*);
                    extensionPointer = (Interop.Amd.SwapchainDisplayNativeHdrCreateInfo*)HeapUtil.Allocate<Interop.Amd.SwapchainDisplayNativeHdrCreateInfo>();
                    swapchainDisplayNativeHdrCreateInfoAmd.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkSwapchainCreateInfoKhrNextPointer;
                    vkSwapchainCreateInfoKhrNextPointer = extensionPointer;
                }
                if (imageFormatListCreateInfo != null)
                {
                    var extensionPointer = default(Interop.ImageFormatListCreateInfo*);
                    extensionPointer = (Interop.ImageFormatListCreateInfo*)HeapUtil.Allocate<Interop.ImageFormatListCreateInfo>();
                    imageFormatListCreateInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkSwapchainCreateInfoKhrNextPointer;
                    vkSwapchainCreateInfoKhrNextPointer = extensionPointer;
                }
                if (surfaceFullScreenExclusiveInfoExt != null)
                {
                    var extensionPointer = default(Interop.Multivendor.SurfaceFullScreenExclusiveInfo*);
                    extensionPointer = (Interop.Multivendor.SurfaceFullScreenExclusiveInfo*)HeapUtil.Allocate<Interop.Multivendor.SurfaceFullScreenExclusiveInfo>();
                    surfaceFullScreenExclusiveInfoExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkSwapchainCreateInfoKhrNextPointer;
                    vkSwapchainCreateInfoKhrNextPointer = extensionPointer;
                }
                if (surfaceFullScreenExclusiveWin32InfoExt != null)
                {
                    var extensionPointer = default(Interop.Multivendor.SurfaceFullScreenExclusiveWin32Info*);
                    extensionPointer = (Interop.Multivendor.SurfaceFullScreenExclusiveWin32Info*)HeapUtil.Allocate<Interop.Multivendor.SurfaceFullScreenExclusiveWin32Info>();
                    surfaceFullScreenExclusiveWin32InfoExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkSwapchainCreateInfoKhrNextPointer;
                    vkSwapchainCreateInfoKhrNextPointer = extensionPointer;
                }
                commandCache = extendedHandle.CommandCache;
                marshalledSwapchainCount = 1;
                marshalledCreateInfos = (Interop.Khronos.SwapchainCreateInfo*)HeapUtil.Allocate<Interop.Khronos.SwapchainCreateInfo>();
                marshalledCreateInfos->SType = StructureType.SwapchainCreateInfo;
                marshalledCreateInfos->Next = vkSwapchainCreateInfoKhrNextPointer;
                if (flags != null)
                    marshalledCreateInfos->Flags = flags.Value;
                else
                    marshalledCreateInfos->Flags = default;
                marshalledCreateInfos->Surface = surface?.Handle ?? default(Interop.Khronos.Surface);
                marshalledCreateInfos->MinImageCount = minImageCount;
                marshalledCreateInfos->ImageFormat = imageFormat;
                marshalledCreateInfos->ImageColorSpace = imageColorSpace;
                marshalledCreateInfos->ImageExtent = imageExtent;
                marshalledCreateInfos->ImageArrayLayers = imageArrayLayers;
                marshalledCreateInfos->ImageUsage = imageUsage;
                marshalledCreateInfos->ImageSharingMode = imageSharingMode;
                marshalledCreateInfos->QueueFamilyIndexCount = HeapUtil.GetLength(queueFamilyIndices);
                if (queueFamilyIndices.IsNull())
                {
                    marshalledCreateInfos->QueueFamilyIndices = null;
                }
                else
                {
                    if (queueFamilyIndices.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfos->QueueFamilyIndices = (uint*)HeapUtil.Allocate<uint>();
                        *marshalledCreateInfos->QueueFamilyIndices = queueFamilyIndices.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (uint*)HeapUtil.AllocateAndClear<uint>(HeapUtil.GetLength(queueFamilyIndices.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(queueFamilyIndices.Value); index++) fieldPointer[index] = queueFamilyIndices.Value[index];
                        marshalledCreateInfos->QueueFamilyIndices = fieldPointer;
                    }
                }
                marshalledCreateInfos->PreTransform = preTransform;
                marshalledCreateInfos->CompositeAlpha = compositeAlpha;
                marshalledCreateInfos->PresentMode = presentMode;
                marshalledCreateInfos->Clipped = clipped;
                marshalledCreateInfos->OldSwapchain = oldSwapchain?.Handle ?? default(Interop.Khronos.Swapchain);
                if (allocator != null)
                {
                    marshalledAllocator = (Interop.AllocationCallbacks*)HeapUtil.Allocate<Interop.AllocationCallbacks>();
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default;
                }
                marshalledSwapchains = (Interop.Khronos.Swapchain*)HeapUtil.Allocate<Interop.Khronos.Swapchain>(1);
                var commandDelegate = commandCache.Cache.VkCreateSharedSwapchainsKhr;
                var methodResult = commandDelegate(extendedHandle.Handle, marshalledSwapchainCount, marshalledCreateInfos, marshalledAllocator, marshalledSwapchains);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                result = new(extendedHandle, *marshalledSwapchains);
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
        /// <param name="getWin32HandleInfo">
        /// </param>
        public static unsafe IntPtr GetMemoryWin32Handle(this Device extendedHandle, MemoryGetWin32HandleInfo getWin32HandleInfo)
        {
            try
            {
                var result = default(IntPtr);
                var commandCache = default(CommandCache);
                var marshalledGetWin32HandleInfo = default(Interop.Khronos.MemoryGetWin32HandleInfo*);
                var marshalledHandle = default(IntPtr);
                commandCache = extendedHandle.CommandCache;
                marshalledGetWin32HandleInfo = (Interop.Khronos.MemoryGetWin32HandleInfo*)HeapUtil.Allocate<Interop.Khronos.MemoryGetWin32HandleInfo>();
                getWin32HandleInfo.MarshalTo(marshalledGetWin32HandleInfo);
                var commandDelegate = commandCache.Cache.VkGetMemoryWin32HandleKhr;
                var methodResult = commandDelegate(extendedHandle.Handle, marshalledGetWin32HandleInfo, &marshalledHandle);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                result = marshalledHandle;
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
        /// <param name="handle">
        /// </param>
        public static unsafe MemoryWin32HandleProperties GetMemoryWin32HandleProperties(this Device extendedHandle, SharpVk.ExternalMemoryHandleTypeFlags handleType, IntPtr handle)
        {
            try
            {
                var result = default(MemoryWin32HandleProperties);
                var commandCache = default(CommandCache);
                var marshalledMemoryWin32HandleProperties = default(Interop.Khronos.MemoryWin32HandleProperties);
                commandCache = extendedHandle.CommandCache;
                var commandDelegate = commandCache.Cache.VkGetMemoryWin32HandlePropertiesKhr;
                var methodResult = commandDelegate(extendedHandle.Handle, handleType, handle, &marshalledMemoryWin32HandleProperties);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                result = MemoryWin32HandleProperties.MarshalFrom(&marshalledMemoryWin32HandleProperties);
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
        /// <param name="getFileDescriptorInfo">
        /// </param>
        public static unsafe int GetMemoryFileDescriptor(this Device extendedHandle, MemoryGetFileDescriptorInfo getFileDescriptorInfo)
        {
            try
            {
                var result = default(int);
                var commandCache = default(CommandCache);
                var marshalledGetFileDescriptorInfo = default(Interop.Khronos.MemoryGetFileDescriptorInfo*);
                var marshalledFileDescriptor = default(int);
                commandCache = extendedHandle.CommandCache;
                marshalledGetFileDescriptorInfo = (Interop.Khronos.MemoryGetFileDescriptorInfo*)HeapUtil.Allocate<Interop.Khronos.MemoryGetFileDescriptorInfo>();
                getFileDescriptorInfo.MarshalTo(marshalledGetFileDescriptorInfo);
                var commandDelegate = commandCache.Cache.VkGetMemoryFdKhr;
                var methodResult = commandDelegate(extendedHandle.Handle, marshalledGetFileDescriptorInfo, &marshalledFileDescriptor);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                result = marshalledFileDescriptor;
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
        /// <param name="fileDescriptor">
        /// </param>
        public static unsafe MemoryFileDescriptorProperties GetMemoryFileDescriptorProperties(this Device extendedHandle, SharpVk.ExternalMemoryHandleTypeFlags handleType, int fileDescriptor)
        {
            try
            {
                var result = default(MemoryFileDescriptorProperties);
                var commandCache = default(CommandCache);
                var marshalledMemoryFileDescriptorProperties = default(Interop.Khronos.MemoryFileDescriptorProperties);
                commandCache = extendedHandle.CommandCache;
                var commandDelegate = commandCache.Cache.VkGetMemoryFdPropertiesKhr;
                var methodResult = commandDelegate(extendedHandle.Handle, handleType, fileDescriptor, &marshalledMemoryFileDescriptorProperties);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                result = MemoryFileDescriptorProperties.MarshalFrom(&marshalledMemoryFileDescriptorProperties);
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
        /// <param name="importSemaphoreWin32HandleInfo">
        /// </param>
        public static unsafe void ImportSemaphoreWin32Handle(this Device extendedHandle, ImportSemaphoreWin32HandleInfo importSemaphoreWin32HandleInfo)
        {
            try
            {
                var commandCache = default(CommandCache);
                var marshalledImportSemaphoreWin32HandleInfo = default(Interop.Khronos.ImportSemaphoreWin32HandleInfo*);
                commandCache = extendedHandle.CommandCache;
                marshalledImportSemaphoreWin32HandleInfo = (Interop.Khronos.ImportSemaphoreWin32HandleInfo*)HeapUtil.Allocate<Interop.Khronos.ImportSemaphoreWin32HandleInfo>();
                importSemaphoreWin32HandleInfo.MarshalTo(marshalledImportSemaphoreWin32HandleInfo);
                var commandDelegate = commandCache.Cache.VkImportSemaphoreWin32HandleKhr;
                var methodResult = commandDelegate(extendedHandle.Handle, marshalledImportSemaphoreWin32HandleInfo);
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
        /// <param name="getWin32HandleInfo">
        /// </param>
        public static unsafe IntPtr GetSemaphoreWin32Handle(this Device extendedHandle, SemaphoreGetWin32HandleInfo getWin32HandleInfo)
        {
            try
            {
                var result = default(IntPtr);
                var commandCache = default(CommandCache);
                var marshalledGetWin32HandleInfo = default(Interop.Khronos.SemaphoreGetWin32HandleInfo*);
                var marshalledHandle = default(IntPtr);
                commandCache = extendedHandle.CommandCache;
                marshalledGetWin32HandleInfo = (Interop.Khronos.SemaphoreGetWin32HandleInfo*)HeapUtil.Allocate<Interop.Khronos.SemaphoreGetWin32HandleInfo>();
                getWin32HandleInfo.MarshalTo(marshalledGetWin32HandleInfo);
                var commandDelegate = commandCache.Cache.VkGetSemaphoreWin32HandleKhr;
                var methodResult = commandDelegate(extendedHandle.Handle, marshalledGetWin32HandleInfo, &marshalledHandle);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                result = marshalledHandle;
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
        /// <param name="importSemaphoreFileDescriptorInfo">
        /// </param>
        public static unsafe void ImportSemaphoreFileDescriptor(this Device extendedHandle, ImportSemaphoreFileDescriptorInfo importSemaphoreFileDescriptorInfo)
        {
            try
            {
                var commandCache = default(CommandCache);
                var marshalledImportSemaphoreFileDescriptorInfo = default(Interop.Khronos.ImportSemaphoreFileDescriptorInfo*);
                commandCache = extendedHandle.CommandCache;
                marshalledImportSemaphoreFileDescriptorInfo = (Interop.Khronos.ImportSemaphoreFileDescriptorInfo*)HeapUtil.Allocate<Interop.Khronos.ImportSemaphoreFileDescriptorInfo>();
                importSemaphoreFileDescriptorInfo.MarshalTo(marshalledImportSemaphoreFileDescriptorInfo);
                var commandDelegate = commandCache.Cache.VkImportSemaphoreFdKhr;
                var methodResult = commandDelegate(extendedHandle.Handle, marshalledImportSemaphoreFileDescriptorInfo);
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
        /// <param name="getFileDescriptorInfo">
        /// </param>
        public static unsafe int GetSemaphoreFileDescriptor(this Device extendedHandle, SemaphoreGetFileDescriptorInfo getFileDescriptorInfo)
        {
            try
            {
                var result = default(int);
                var commandCache = default(CommandCache);
                var marshalledGetFileDescriptorInfo = default(Interop.Khronos.SemaphoreGetFileDescriptorInfo*);
                var marshalledFileDescriptor = default(int);
                commandCache = extendedHandle.CommandCache;
                marshalledGetFileDescriptorInfo = (Interop.Khronos.SemaphoreGetFileDescriptorInfo*)HeapUtil.Allocate<Interop.Khronos.SemaphoreGetFileDescriptorInfo>();
                getFileDescriptorInfo.MarshalTo(marshalledGetFileDescriptorInfo);
                var commandDelegate = commandCache.Cache.VkGetSemaphoreFdKhr;
                var methodResult = commandDelegate(extendedHandle.Handle, marshalledGetFileDescriptorInfo, &marshalledFileDescriptor);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                result = marshalledFileDescriptor;
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
        /// <param name="importFenceWin32HandleInfo">
        /// </param>
        public static unsafe void ImportFenceWin32Handle(this Device extendedHandle, ImportFenceWin32HandleInfo importFenceWin32HandleInfo)
        {
            try
            {
                var commandCache = default(CommandCache);
                var marshalledImportFenceWin32HandleInfo = default(Interop.Khronos.ImportFenceWin32HandleInfo*);
                commandCache = extendedHandle.CommandCache;
                marshalledImportFenceWin32HandleInfo = (Interop.Khronos.ImportFenceWin32HandleInfo*)HeapUtil.Allocate<Interop.Khronos.ImportFenceWin32HandleInfo>();
                importFenceWin32HandleInfo.MarshalTo(marshalledImportFenceWin32HandleInfo);
                var commandDelegate = commandCache.Cache.VkImportFenceWin32HandleKhr;
                var methodResult = commandDelegate(extendedHandle.Handle, marshalledImportFenceWin32HandleInfo);
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
        /// <param name="getWin32HandleInfo">
        /// </param>
        public static unsafe IntPtr GetFenceWin32Handle(this Device extendedHandle, FenceGetWin32HandleInfo getWin32HandleInfo)
        {
            try
            {
                var result = default(IntPtr);
                var commandCache = default(CommandCache);
                var marshalledGetWin32HandleInfo = default(Interop.Khronos.FenceGetWin32HandleInfo*);
                var marshalledHandle = default(IntPtr);
                commandCache = extendedHandle.CommandCache;
                marshalledGetWin32HandleInfo = (Interop.Khronos.FenceGetWin32HandleInfo*)HeapUtil.Allocate<Interop.Khronos.FenceGetWin32HandleInfo>();
                getWin32HandleInfo.MarshalTo(marshalledGetWin32HandleInfo);
                var commandDelegate = commandCache.Cache.VkGetFenceWin32HandleKhr;
                var methodResult = commandDelegate(extendedHandle.Handle, marshalledGetWin32HandleInfo, &marshalledHandle);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                result = marshalledHandle;
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
        /// <param name="importFenceFileDescriptorInfo">
        /// </param>
        public static unsafe void ImportFenceFileDescriptor(this Device extendedHandle, ImportFenceFileDescriptorInfo importFenceFileDescriptorInfo)
        {
            try
            {
                var commandCache = default(CommandCache);
                var marshalledImportFenceFileDescriptorInfo = default(Interop.Khronos.ImportFenceFileDescriptorInfo*);
                commandCache = extendedHandle.CommandCache;
                marshalledImportFenceFileDescriptorInfo = (Interop.Khronos.ImportFenceFileDescriptorInfo*)HeapUtil.Allocate<Interop.Khronos.ImportFenceFileDescriptorInfo>();
                importFenceFileDescriptorInfo.MarshalTo(marshalledImportFenceFileDescriptorInfo);
                var commandDelegate = commandCache.Cache.VkImportFenceFdKhr;
                var methodResult = commandDelegate(extendedHandle.Handle, marshalledImportFenceFileDescriptorInfo);
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
        /// <param name="getFileDescriptorInfo">
        /// </param>
        public static unsafe int GetFenceFileDescriptor(this Device extendedHandle, FenceGetFileDescriptorInfo getFileDescriptorInfo)
        {
            try
            {
                var result = default(int);
                var commandCache = default(CommandCache);
                var marshalledGetFileDescriptorInfo = default(Interop.Khronos.FenceGetFileDescriptorInfo*);
                var marshalledFileDescriptor = default(int);
                commandCache = extendedHandle.CommandCache;
                marshalledGetFileDescriptorInfo = (Interop.Khronos.FenceGetFileDescriptorInfo*)HeapUtil.Allocate<Interop.Khronos.FenceGetFileDescriptorInfo>();
                getFileDescriptorInfo.MarshalTo(marshalledGetFileDescriptorInfo);
                var commandDelegate = commandCache.Cache.VkGetFenceFdKhr;
                var methodResult = commandDelegate(extendedHandle.Handle, marshalledGetFileDescriptorInfo, &marshalledFileDescriptor);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                result = marshalledFileDescriptor;
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
        /// <param name="info">
        /// </param>
        public static unsafe void AcquireProfilingLock(this Device extendedHandle, AcquireProfilingLockInfo info)
        {
            try
            {
                var commandCache = default(CommandCache);
                var marshalledInfo = default(Interop.Khronos.AcquireProfilingLockInfo*);
                commandCache = extendedHandle.CommandCache;
                marshalledInfo = (Interop.Khronos.AcquireProfilingLockInfo*)HeapUtil.Allocate<Interop.Khronos.AcquireProfilingLockInfo>();
                info.MarshalTo(marshalledInfo);
                var commandDelegate = commandCache.Cache.VkAcquireProfilingLockKhr;
                var methodResult = commandDelegate(extendedHandle.Handle, marshalledInfo);
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
        public static void ReleaseProfilingLock(this Device extendedHandle)
        {
            try
            {
                var commandCache = default(CommandCache);
                commandCache = extendedHandle.CommandCache;
                var commandDelegate = commandCache.Cache.VkReleaseProfilingLockKhr;
                commandDelegate(extendedHandle.Handle);
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
        /// <param name="pipelineInfo">
        /// </param>
        public static unsafe PipelineExecutableProperties[] GetPipelineExecutableProperties(this Device extendedHandle, PipelineInfo pipelineInfo)
        {
            try
            {
                var result = default(PipelineExecutableProperties[]);
                var marshalledExecutableCount = default(uint);
                var commandCache = default(CommandCache);
                var marshalledPipelineInfo = default(Interop.Khronos.PipelineInfo*);
                var marshalledProperties = default(Interop.Khronos.PipelineExecutableProperties*);
                commandCache = extendedHandle.CommandCache;
                marshalledPipelineInfo = (Interop.Khronos.PipelineInfo*)HeapUtil.Allocate<Interop.Khronos.PipelineInfo>();
                pipelineInfo.MarshalTo(marshalledPipelineInfo);
                var commandDelegate = commandCache.Cache.VkGetPipelineExecutablePropertiesKhr;
                var methodResult = commandDelegate(extendedHandle.Handle, marshalledPipelineInfo, &marshalledExecutableCount, marshalledProperties);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                marshalledProperties = (Interop.Khronos.PipelineExecutableProperties*)HeapUtil.Allocate<Interop.Khronos.PipelineExecutableProperties>(marshalledExecutableCount);
                commandDelegate(extendedHandle.Handle, marshalledPipelineInfo, &marshalledExecutableCount, marshalledProperties);
                if (marshalledProperties != null)
                {
                    var fieldPointer = new PipelineExecutableProperties[marshalledExecutableCount];
                    for (var index = 0; index < marshalledExecutableCount; index++) fieldPointer[index] = PipelineExecutableProperties.MarshalFrom(&marshalledProperties[index]);
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
        /// <param name="extendedHandle">
        ///     The Device handle to extend.
        /// </param>
        /// <param name="executableInfo">
        /// </param>
        public static unsafe PipelineExecutableStatistic[] GetPipelineExecutableStatistics(this Device extendedHandle, PipelineExecutableInfo executableInfo)
        {
            try
            {
                var result = default(PipelineExecutableStatistic[]);
                var marshalledStatisticCount = default(uint);
                var commandCache = default(CommandCache);
                var marshalledExecutableInfo = default(Interop.Khronos.PipelineExecutableInfo*);
                var marshalledStatistics = default(Interop.Khronos.PipelineExecutableStatistic*);
                commandCache = extendedHandle.CommandCache;
                marshalledExecutableInfo = (Interop.Khronos.PipelineExecutableInfo*)HeapUtil.Allocate<Interop.Khronos.PipelineExecutableInfo>();
                executableInfo.MarshalTo(marshalledExecutableInfo);
                var commandDelegate = commandCache.Cache.VkGetPipelineExecutableStatisticsKhr;
                var methodResult = commandDelegate(extendedHandle.Handle, marshalledExecutableInfo, &marshalledStatisticCount, marshalledStatistics);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                marshalledStatistics = (Interop.Khronos.PipelineExecutableStatistic*)HeapUtil.Allocate<Interop.Khronos.PipelineExecutableStatistic>(marshalledStatisticCount);
                commandDelegate(extendedHandle.Handle, marshalledExecutableInfo, &marshalledStatisticCount, marshalledStatistics);
                if (marshalledStatistics != null)
                {
                    var fieldPointer = new PipelineExecutableStatistic[marshalledStatisticCount];
                    for (var index = 0; index < marshalledStatisticCount; index++) fieldPointer[index] = PipelineExecutableStatistic.MarshalFrom(&marshalledStatistics[index]);
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
        /// <param name="extendedHandle">
        ///     The Device handle to extend.
        /// </param>
        /// <param name="executableInfo">
        /// </param>
        public static unsafe PipelineExecutableInternalRepresentation[] GetPipelineExecutableInternalRepresentations(this Device extendedHandle, PipelineExecutableInfo executableInfo)
        {
            try
            {
                var result = default(PipelineExecutableInternalRepresentation[]);
                var marshalledInternalRepresentationCount = default(uint);
                var commandCache = default(CommandCache);
                var marshalledExecutableInfo = default(Interop.Khronos.PipelineExecutableInfo*);
                var marshalledInternalRepresentations = default(Interop.Khronos.PipelineExecutableInternalRepresentation*);
                commandCache = extendedHandle.CommandCache;
                marshalledExecutableInfo = (Interop.Khronos.PipelineExecutableInfo*)HeapUtil.Allocate<Interop.Khronos.PipelineExecutableInfo>();
                executableInfo.MarshalTo(marshalledExecutableInfo);
                var commandDelegate = commandCache.Cache.VkGetPipelineExecutableInternalRepresentationsKhr;
                var methodResult = commandDelegate(extendedHandle.Handle, marshalledExecutableInfo, &marshalledInternalRepresentationCount, marshalledInternalRepresentations);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                marshalledInternalRepresentations = (Interop.Khronos.PipelineExecutableInternalRepresentation*)HeapUtil.Allocate<Interop.Khronos.PipelineExecutableInternalRepresentation>(marshalledInternalRepresentationCount);
                commandDelegate(extendedHandle.Handle, marshalledExecutableInfo, &marshalledInternalRepresentationCount, marshalledInternalRepresentations);
                if (marshalledInternalRepresentations != null)
                {
                    var fieldPointer = new PipelineExecutableInternalRepresentation[marshalledInternalRepresentationCount];
                    for (var index = 0; index < marshalledInternalRepresentationCount; index++) fieldPointer[index] = PipelineExecutableInternalRepresentation.MarshalFrom(&marshalledInternalRepresentations[index]);
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
    }
}
