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

namespace SharpVk.Khronos
{
    /// <summary>
    /// </summary>
    public static class PhysicalDeviceExtensions
    {
        /// <summary>
        ///     Query if presentation is supported.
        /// </summary>
        /// <param name="extendedHandle">
        ///     The PhysicalDevice handle to extend.
        /// </param>
        /// <param name="queueFamilyIndex">
        /// </param>
        /// <param name="surface">
        /// </param>
        public static unsafe bool GetSurfaceSupport(this PhysicalDevice extendedHandle, uint queueFamilyIndex, Surface surface)
        {
            try
            {
                var result = default(bool);
                var commandCache = default(CommandCache);
                var marshalledSupported = default(Bool32);
                commandCache = extendedHandle.commandCache;
                var commandDelegate = commandCache.Cache.vkGetPhysicalDeviceSurfaceSupportKHR;
                var methodResult = commandDelegate(extendedHandle.handle, queueFamilyIndex, surface?.handle ?? default(Interop.Khronos.Surface), &marshalledSupported);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                result = marshalledSupported;
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Query surface capabilities.
        /// </summary>
        /// <param name="extendedHandle">
        ///     The PhysicalDevice handle to extend.
        /// </param>
        /// <param name="surface">
        /// </param>
        public static unsafe SurfaceCapabilities GetSurfaceCapabilities(this PhysicalDevice extendedHandle, Surface surface)
        {
            try
            {
                var result = default(SurfaceCapabilities);
                var commandCache = default(CommandCache);
                var marshalledSurfaceCapabilities = default(SurfaceCapabilities);
                commandCache = extendedHandle.commandCache;
                var commandDelegate = commandCache.Cache.vkGetPhysicalDeviceSurfaceCapabilitiesKHR;
                var methodResult = commandDelegate(extendedHandle.handle, surface?.handle ?? default(Interop.Khronos.Surface), &marshalledSurfaceCapabilities);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                result = marshalledSurfaceCapabilities;
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Query color formats supported by surface.
        /// </summary>
        /// <param name="extendedHandle">
        ///     The PhysicalDevice handle to extend.
        /// </param>
        /// <param name="surface">
        /// </param>
        public static unsafe SurfaceFormat[] GetSurfaceFormats(this PhysicalDevice extendedHandle, Surface surface)
        {
            try
            {
                var result = default(SurfaceFormat[]);
                var marshalledSurfaceFormatCount = default(uint);
                var commandCache = default(CommandCache);
                var marshalledSurfaceFormats = default(SurfaceFormat*);
                commandCache = extendedHandle.commandCache;
                var commandDelegate = commandCache.Cache.vkGetPhysicalDeviceSurfaceFormatsKHR;
                var methodResult = commandDelegate(extendedHandle.handle, surface?.handle ?? default(Interop.Khronos.Surface), &marshalledSurfaceFormatCount, marshalledSurfaceFormats);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                marshalledSurfaceFormats = (SurfaceFormat*)HeapUtil.Allocate<SurfaceFormat>(marshalledSurfaceFormatCount);
                commandDelegate(extendedHandle.handle, surface?.handle ?? default(Interop.Khronos.Surface), &marshalledSurfaceFormatCount, marshalledSurfaceFormats);
                if (marshalledSurfaceFormats != null)
                {
                    var fieldPointer = new SurfaceFormat[marshalledSurfaceFormatCount];
                    for (var index = 0; index < marshalledSurfaceFormatCount; index++) fieldPointer[index] = marshalledSurfaceFormats[index];
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
        ///     Query supported presentation modes.
        /// </summary>
        /// <param name="extendedHandle">
        ///     The PhysicalDevice handle to extend.
        /// </param>
        /// <param name="surface">
        /// </param>
        public static unsafe PresentMode[] GetSurfacePresentModes(this PhysicalDevice extendedHandle, Surface surface)
        {
            try
            {
                var result = default(PresentMode[]);
                var marshalledPresentModeCount = default(uint);
                var commandCache = default(CommandCache);
                var marshalledPresentModes = default(PresentMode*);
                commandCache = extendedHandle.commandCache;
                var commandDelegate = commandCache.Cache.vkGetPhysicalDeviceSurfacePresentModesKHR;
                var methodResult = commandDelegate(extendedHandle.handle, surface?.handle ?? default(Interop.Khronos.Surface), &marshalledPresentModeCount, marshalledPresentModes);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                marshalledPresentModes = (PresentMode*)HeapUtil.Allocate<PresentMode>(marshalledPresentModeCount);
                commandDelegate(extendedHandle.handle, surface?.handle ?? default(Interop.Khronos.Surface), &marshalledPresentModeCount, marshalledPresentModes);
                if (marshalledPresentModes != null)
                {
                    var fieldPointer = new PresentMode[marshalledPresentModeCount];
                    for (var index = 0; index < marshalledPresentModeCount; index++) fieldPointer[index] = marshalledPresentModes[index];
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
        ///     The PhysicalDevice handle to extend.
        /// </param>
        /// <param name="surface">
        /// </param>
        public static unsafe Rect2D[] GetPresentRectangles(this PhysicalDevice extendedHandle, Surface surface)
        {
            try
            {
                var result = default(Rect2D[]);
                var marshalledRectCount = default(uint);
                var commandCache = default(CommandCache);
                var marshalledRects = default(Rect2D*);
                commandCache = extendedHandle.commandCache;
                var commandDelegate = commandCache.Cache.vkGetPhysicalDevicePresentRectanglesKHR;
                var methodResult = commandDelegate(extendedHandle.handle, surface?.handle ?? default(Interop.Khronos.Surface), &marshalledRectCount, marshalledRects);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                marshalledRects = (Rect2D*)HeapUtil.Allocate<Rect2D>(marshalledRectCount);
                commandDelegate(extendedHandle.handle, surface?.handle ?? default(Interop.Khronos.Surface), &marshalledRectCount, marshalledRects);
                if (marshalledRects != null)
                {
                    var fieldPointer = new Rect2D[marshalledRectCount];
                    for (var index = 0; index < marshalledRectCount; index++) fieldPointer[index] = marshalledRects[index];
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
        ///     Query information about the available displays.
        /// </summary>
        /// <param name="extendedHandle">
        ///     The PhysicalDevice handle to extend.
        /// </param>
        public static unsafe DisplayProperties[] GetDisplayProperties(this PhysicalDevice extendedHandle)
        {
            try
            {
                var result = default(DisplayProperties[]);
                var marshalledPropertyCount = default(uint);
                var commandCache = default(CommandCache);
                var marshalledProperties = default(Interop.Khronos.DisplayProperties*);
                commandCache = extendedHandle.commandCache;
                var commandDelegate = commandCache.Cache.vkGetPhysicalDeviceDisplayPropertiesKHR;
                var methodResult = commandDelegate(extendedHandle.handle, &marshalledPropertyCount, marshalledProperties);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                marshalledProperties = (Interop.Khronos.DisplayProperties*)HeapUtil.Allocate<Interop.Khronos.DisplayProperties>(marshalledPropertyCount);
                commandDelegate(extendedHandle.handle, &marshalledPropertyCount, marshalledProperties);
                if (marshalledProperties != null)
                {
                    var fieldPointer = new DisplayProperties[marshalledPropertyCount];
                    for (var index = 0; index < marshalledPropertyCount; index++) fieldPointer[index] = DisplayProperties.MarshalFrom(&marshalledProperties[index]);
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
        ///     Query the plane properties.
        /// </summary>
        /// <param name="extendedHandle">
        ///     The PhysicalDevice handle to extend.
        /// </param>
        public static unsafe DisplayPlaneProperties[] GetDisplayPlaneProperties(this PhysicalDevice extendedHandle)
        {
            try
            {
                var result = default(DisplayPlaneProperties[]);
                var marshalledPropertyCount = default(uint);
                var commandCache = default(CommandCache);
                var marshalledProperties = default(Interop.Khronos.DisplayPlaneProperties*);
                commandCache = extendedHandle.commandCache;
                var commandDelegate = commandCache.Cache.vkGetPhysicalDeviceDisplayPlanePropertiesKHR;
                var methodResult = commandDelegate(extendedHandle.handle, &marshalledPropertyCount, marshalledProperties);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                marshalledProperties = (Interop.Khronos.DisplayPlaneProperties*)HeapUtil.Allocate<Interop.Khronos.DisplayPlaneProperties>(marshalledPropertyCount);
                commandDelegate(extendedHandle.handle, &marshalledPropertyCount, marshalledProperties);
                if (marshalledProperties != null)
                {
                    var fieldPointer = new DisplayPlaneProperties[marshalledPropertyCount];
                    for (var index = 0; index < marshalledPropertyCount; index++) fieldPointer[index] = DisplayPlaneProperties.MarshalFrom(&marshalledProperties[index]);
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
        ///     Query the list of displays a plane supports.
        /// </summary>
        /// <param name="extendedHandle">
        ///     The PhysicalDevice handle to extend.
        /// </param>
        /// <param name="planeIndex">
        /// </param>
        public static unsafe Display[] GetDisplayPlaneSupportedDisplays(this PhysicalDevice extendedHandle, uint planeIndex)
        {
            try
            {
                var result = default(Display[]);
                var marshalledDisplayCount = default(uint);
                var commandCache = default(CommandCache);
                var marshalledDisplays = default(Interop.Khronos.Display*);
                commandCache = extendedHandle.commandCache;
                var commandDelegate = commandCache.Cache.vkGetDisplayPlaneSupportedDisplaysKHR;
                var methodResult = commandDelegate(extendedHandle.handle, planeIndex, &marshalledDisplayCount, marshalledDisplays);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                marshalledDisplays = (Interop.Khronos.Display*)HeapUtil.Allocate<Interop.Khronos.Display>(marshalledDisplayCount);
                commandDelegate(extendedHandle.handle, planeIndex, &marshalledDisplayCount, marshalledDisplays);
                if (marshalledDisplays != null)
                {
                    var fieldPointer = new Display[marshalledDisplayCount];
                    for (var index = 0; index < marshalledDisplayCount; index++) fieldPointer[index] = new(marshalledDisplays[index]);
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
        ///     Query the set of mode properties supported by the display.
        /// </summary>
        /// <param name="extendedHandle">
        ///     The PhysicalDevice handle to extend.
        /// </param>
        /// <param name="display">
        /// </param>
        public static unsafe DisplayModeProperties[] GetDisplayModeProperties(this PhysicalDevice extendedHandle, Display display)
        {
            try
            {
                var result = default(DisplayModeProperties[]);
                var marshalledPropertyCount = default(uint);
                var commandCache = default(CommandCache);
                var marshalledProperties = default(Interop.Khronos.DisplayModeProperties*);
                commandCache = extendedHandle.commandCache;
                var commandDelegate = commandCache.Cache.vkGetDisplayModePropertiesKHR;
                var methodResult = commandDelegate(extendedHandle.handle, display?.handle ?? default(Interop.Khronos.Display), &marshalledPropertyCount, marshalledProperties);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                marshalledProperties = (Interop.Khronos.DisplayModeProperties*)HeapUtil.Allocate<Interop.Khronos.DisplayModeProperties>(marshalledPropertyCount);
                commandDelegate(extendedHandle.handle, display?.handle ?? default(Interop.Khronos.Display), &marshalledPropertyCount, marshalledProperties);
                if (marshalledProperties != null)
                {
                    var fieldPointer = new DisplayModeProperties[marshalledPropertyCount];
                    for (var index = 0; index < marshalledPropertyCount; index++) fieldPointer[index] = DisplayModeProperties.MarshalFrom(&marshalledProperties[index]);
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
        ///     Create a display mode.
        /// </summary>
        /// <param name="extendedHandle">
        ///     The PhysicalDevice handle to extend.
        /// </param>
        /// <param name="display">
        /// </param>
        /// <param name="flags">
        ///     Reserved for future use, and must be zero.
        /// </param>
        /// <param name="parameters">
        ///     A DisplayModeParametersKHR structure describing the display
        ///     parameters to use in creating the new mode. If the parameters are
        ///     not compatible with the specified display, the implementation must
        ///     return Result.ErrorINITIALIZATION_FAILED.
        /// </param>
        /// <param name="allocator">
        ///     An optional AllocationCallbacks instance that controls host memory
        ///     allocation.
        /// </param>
        public static unsafe DisplayMode CreateDisplayMode(this PhysicalDevice extendedHandle, Display display, DisplayModeParameters parameters, DisplayModeCreateFlags? flags = default, AllocationCallbacks? allocator = default)
        {
            try
            {
                var result = default(DisplayMode);
                var commandCache = default(CommandCache);
                var marshalledCreateInfo = default(Interop.Khronos.DisplayModeCreateInfo*);
                var vkDisplayModeCreateInfoKHRNextPointer = default(void*);
                var marshalledAllocator = default(Interop.AllocationCallbacks*);
                var marshalledMode = default(Interop.Khronos.DisplayMode);
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfo = (Interop.Khronos.DisplayModeCreateInfo*)HeapUtil.Allocate<Interop.Khronos.DisplayModeCreateInfo>();
                marshalledCreateInfo->SType = StructureType.DisplayModeCreateInfo;
                marshalledCreateInfo->Next = vkDisplayModeCreateInfoKHRNextPointer;
                if (flags != null)
                    marshalledCreateInfo->Flags = flags.Value;
                else
                    marshalledCreateInfo->Flags = default;
                marshalledCreateInfo->Parameters = parameters;
                if (allocator != null)
                {
                    marshalledAllocator = (Interop.AllocationCallbacks*)HeapUtil.Allocate<Interop.AllocationCallbacks>();
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default;
                }
                var commandDelegate = commandCache.Cache.vkCreateDisplayModeKHR;
                var methodResult = commandDelegate(extendedHandle.handle, display?.handle ?? default(Interop.Khronos.Display), marshalledCreateInfo, marshalledAllocator, &marshalledMode);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                result = new(extendedHandle, marshalledMode);
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Query physical device for presentation to X11 server using Xlib.
        /// </summary>
        /// <param name="extendedHandle">
        ///     The PhysicalDevice handle to extend.
        /// </param>
        /// <param name="queueFamilyIndex">
        /// </param>
        /// <param name="dpy">
        /// </param>
        /// <param name="visualID">
        /// </param>
        public static unsafe void GetXlibPresentationSupport(this PhysicalDevice extendedHandle, uint queueFamilyIndex, IntPtr dpy, IntPtr visualID)
        {
            try
            {
                var commandCache = default(CommandCache);
                var marshalledDpy = default(IntPtr*);
                commandCache = extendedHandle.commandCache;
                marshalledDpy = (IntPtr*)HeapUtil.Allocate<IntPtr>();
                *marshalledDpy = dpy;
                var commandDelegate = commandCache.Cache.vkGetPhysicalDeviceXlibPresentationSupportKHR;
                commandDelegate(extendedHandle.handle, queueFamilyIndex, marshalledDpy, visualID);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Query physical device for presentation to X11 server using XCB.
        /// </summary>
        /// <param name="extendedHandle">
        ///     The PhysicalDevice handle to extend.
        /// </param>
        /// <param name="queueFamilyIndex">
        /// </param>
        /// <param name="connection">
        /// </param>
        /// <param name="visualId">
        /// </param>
        public static unsafe void GetXcbPresentationSupport(this PhysicalDevice extendedHandle, uint queueFamilyIndex, IntPtr connection, IntPtr visualId)
        {
            try
            {
                var commandCache = default(CommandCache);
                var marshalledConnection = default(IntPtr*);
                commandCache = extendedHandle.commandCache;
                marshalledConnection = (IntPtr*)HeapUtil.Allocate<IntPtr>();
                *marshalledConnection = connection;
                var commandDelegate = commandCache.Cache.vkGetPhysicalDeviceXcbPresentationSupportKHR;
                commandDelegate(extendedHandle.handle, queueFamilyIndex, marshalledConnection, visualId);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Query physical device for presentation to Wayland.
        /// </summary>
        /// <param name="extendedHandle">
        ///     The PhysicalDevice handle to extend.
        /// </param>
        /// <param name="queueFamilyIndex">
        /// </param>
        /// <param name="display">
        /// </param>
        public static unsafe void GetWaylandPresentationSupport(this PhysicalDevice extendedHandle, uint queueFamilyIndex, IntPtr display)
        {
            try
            {
                var commandCache = default(CommandCache);
                var marshalledDisplay = default(IntPtr*);
                commandCache = extendedHandle.commandCache;
                marshalledDisplay = (IntPtr*)HeapUtil.Allocate<IntPtr>();
                *marshalledDisplay = display;
                var commandDelegate = commandCache.Cache.vkGetPhysicalDeviceWaylandPresentationSupportKHR;
                commandDelegate(extendedHandle.handle, queueFamilyIndex, marshalledDisplay);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Query queue family support for presentation on a Win32 display.
        /// </summary>
        /// <param name="extendedHandle">
        ///     The PhysicalDevice handle to extend.
        /// </param>
        /// <param name="queueFamilyIndex">
        /// </param>
        public static void GetWin32PresentationSupport(this PhysicalDevice extendedHandle, uint queueFamilyIndex)
        {
            try
            {
                var commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                var commandDelegate = commandCache.Cache.vkGetPhysicalDeviceWin32PresentationSupportKHR;
                commandDelegate(extendedHandle.handle, queueFamilyIndex);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="extendedHandle">
        ///     The PhysicalDevice handle to extend.
        /// </param>
        /// <param name="queueFamilyIndex">
        /// </param>
        /// <param name="counters">
        /// </param>
        /// <param name="counterDescriptions">
        /// </param>
        public static unsafe Result EnumerateQueueFamilyPerformanceQueryCounters(this PhysicalDevice extendedHandle, uint queueFamilyIndex, out PerformanceCounter[] counters, out PerformanceCounterDescription[] counterDescriptions)
        {
            try
            {
                var result = default(Result);
                var marshalledCounterCount = default(uint);
                var commandCache = default(CommandCache);
                var marshalledCounters = default(Interop.Khronos.PerformanceCounter*);
                var marshalledCounterDescriptions = default(Interop.Khronos.PerformanceCounterDescription*);
                commandCache = extendedHandle.commandCache;
                var commandDelegate = commandCache.Cache.vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR;
                result = commandDelegate(extendedHandle.handle, queueFamilyIndex, &marshalledCounterCount, marshalledCounters, marshalledCounterDescriptions);
                if (SharpVkException.IsError(result)) throw SharpVkException.Create(result);
                marshalledCounterDescriptions = (Interop.Khronos.PerformanceCounterDescription*)HeapUtil.Allocate<Interop.Khronos.PerformanceCounterDescription>(marshalledCounterCount);
                marshalledCounters = (Interop.Khronos.PerformanceCounter*)HeapUtil.Allocate<Interop.Khronos.PerformanceCounter>(marshalledCounterCount);
                commandDelegate(extendedHandle.handle, queueFamilyIndex, &marshalledCounterCount, marshalledCounters, marshalledCounterDescriptions);
                if (marshalledCounters != null)
                {
                    var fieldPointer = new PerformanceCounter[marshalledCounterCount];
                    for (var index = 0; index < marshalledCounterCount; index++) fieldPointer[index] = PerformanceCounter.MarshalFrom(&marshalledCounters[index]);
                    counters = fieldPointer;
                }
                else
                {
                    counters = null;
                }
                if (marshalledCounterDescriptions != null)
                {
                    var fieldPointer = new PerformanceCounterDescription[marshalledCounterCount];
                    for (var index = 0; index < marshalledCounterCount; index++) fieldPointer[index] = PerformanceCounterDescription.MarshalFrom(&marshalledCounterDescriptions[index]);
                    counterDescriptions = fieldPointer;
                }
                else
                {
                    counterDescriptions = null;
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
        ///     The PhysicalDevice handle to extend.
        /// </param>
        /// <param name="performanceQueryCreateInfo">
        /// </param>
        public static unsafe uint GetQueueFamilyPerformanceQueryPasses(this PhysicalDevice extendedHandle, QueryPoolPerformanceCreateInfo performanceQueryCreateInfo)
        {
            try
            {
                var result = default(uint);
                var commandCache = default(CommandCache);
                var marshalledPerformanceQueryCreateInfo = default(Interop.Khronos.QueryPoolPerformanceCreateInfo*);
                var marshalledNumPasses = default(uint);
                commandCache = extendedHandle.commandCache;
                marshalledPerformanceQueryCreateInfo = (Interop.Khronos.QueryPoolPerformanceCreateInfo*)HeapUtil.Allocate<Interop.Khronos.QueryPoolPerformanceCreateInfo>();
                performanceQueryCreateInfo.MarshalTo(marshalledPerformanceQueryCreateInfo);
                var commandDelegate = commandCache.Cache.vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR;
                commandDelegate(extendedHandle.handle, marshalledPerformanceQueryCreateInfo, &marshalledNumPasses);
                result = marshalledNumPasses;
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
        ///     The PhysicalDevice handle to extend.
        /// </param>
        /// <param name="surfaceInfo">
        /// </param>
        public static unsafe SurfaceCapabilities2 GetSurfaceCapabilities2(this PhysicalDevice extendedHandle, PhysicalDeviceSurfaceInfo2 surfaceInfo)
        {
            try
            {
                var result = default(SurfaceCapabilities2);
                var commandCache = default(CommandCache);
                var marshalledSurfaceInfo = default(Interop.Khronos.PhysicalDeviceSurfaceInfo2*);
                var marshalledSurfaceCapabilities = default(Interop.Khronos.SurfaceCapabilities2);
                commandCache = extendedHandle.commandCache;
                marshalledSurfaceInfo = (Interop.Khronos.PhysicalDeviceSurfaceInfo2*)HeapUtil.Allocate<Interop.Khronos.PhysicalDeviceSurfaceInfo2>();
                surfaceInfo.MarshalTo(marshalledSurfaceInfo);
                var commandDelegate = commandCache.Cache.vkGetPhysicalDeviceSurfaceCapabilities2KHR;
                var methodResult = commandDelegate(extendedHandle.handle, marshalledSurfaceInfo, &marshalledSurfaceCapabilities);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                result = SurfaceCapabilities2.MarshalFrom(&marshalledSurfaceCapabilities);
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
        ///     The PhysicalDevice handle to extend.
        /// </param>
        /// <param name="surfaceInfo">
        /// </param>
        public static unsafe SurfaceFormat2[] GetSurfaceFormats2(this PhysicalDevice extendedHandle, PhysicalDeviceSurfaceInfo2 surfaceInfo)
        {
            try
            {
                var result = default(SurfaceFormat2[]);
                var marshalledSurfaceFormatCount = default(uint);
                var commandCache = default(CommandCache);
                var marshalledSurfaceInfo = default(Interop.Khronos.PhysicalDeviceSurfaceInfo2*);
                var marshalledSurfaceFormats = default(Interop.Khronos.SurfaceFormat2*);
                commandCache = extendedHandle.commandCache;
                marshalledSurfaceInfo = (Interop.Khronos.PhysicalDeviceSurfaceInfo2*)HeapUtil.Allocate<Interop.Khronos.PhysicalDeviceSurfaceInfo2>();
                surfaceInfo.MarshalTo(marshalledSurfaceInfo);
                var commandDelegate = commandCache.Cache.vkGetPhysicalDeviceSurfaceFormats2KHR;
                var methodResult = commandDelegate(extendedHandle.handle, marshalledSurfaceInfo, &marshalledSurfaceFormatCount, marshalledSurfaceFormats);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                marshalledSurfaceFormats = (Interop.Khronos.SurfaceFormat2*)HeapUtil.Allocate<Interop.Khronos.SurfaceFormat2>(marshalledSurfaceFormatCount);
                commandDelegate(extendedHandle.handle, marshalledSurfaceInfo, &marshalledSurfaceFormatCount, marshalledSurfaceFormats);
                if (marshalledSurfaceFormats != null)
                {
                    var fieldPointer = new SurfaceFormat2[marshalledSurfaceFormatCount];
                    for (var index = 0; index < marshalledSurfaceFormatCount; index++) fieldPointer[index] = SurfaceFormat2.MarshalFrom(&marshalledSurfaceFormats[index]);
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
        ///     The PhysicalDevice handle to extend.
        /// </param>
        public static unsafe DisplayProperties2[] GetDisplayProperties2(this PhysicalDevice extendedHandle)
        {
            try
            {
                var result = default(DisplayProperties2[]);
                var marshalledPropertyCount = default(uint);
                var commandCache = default(CommandCache);
                var marshalledProperties = default(Interop.Khronos.DisplayProperties2*);
                commandCache = extendedHandle.commandCache;
                var commandDelegate = commandCache.Cache.vkGetPhysicalDeviceDisplayProperties2KHR;
                var methodResult = commandDelegate(extendedHandle.handle, &marshalledPropertyCount, marshalledProperties);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                marshalledProperties = (Interop.Khronos.DisplayProperties2*)HeapUtil.Allocate<Interop.Khronos.DisplayProperties2>(marshalledPropertyCount);
                commandDelegate(extendedHandle.handle, &marshalledPropertyCount, marshalledProperties);
                if (marshalledProperties != null)
                {
                    var fieldPointer = new DisplayProperties2[marshalledPropertyCount];
                    for (var index = 0; index < marshalledPropertyCount; index++) fieldPointer[index] = DisplayProperties2.MarshalFrom(&marshalledProperties[index]);
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
        ///     The PhysicalDevice handle to extend.
        /// </param>
        public static unsafe DisplayPlaneProperties2[] GetDisplayPlaneProperties2(this PhysicalDevice extendedHandle)
        {
            try
            {
                var result = default(DisplayPlaneProperties2[]);
                var marshalledPropertyCount = default(uint);
                var commandCache = default(CommandCache);
                var marshalledProperties = default(Interop.Khronos.DisplayPlaneProperties2*);
                commandCache = extendedHandle.commandCache;
                var commandDelegate = commandCache.Cache.vkGetPhysicalDeviceDisplayPlaneProperties2KHR;
                var methodResult = commandDelegate(extendedHandle.handle, &marshalledPropertyCount, marshalledProperties);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                marshalledProperties = (Interop.Khronos.DisplayPlaneProperties2*)HeapUtil.Allocate<Interop.Khronos.DisplayPlaneProperties2>(marshalledPropertyCount);
                commandDelegate(extendedHandle.handle, &marshalledPropertyCount, marshalledProperties);
                if (marshalledProperties != null)
                {
                    var fieldPointer = new DisplayPlaneProperties2[marshalledPropertyCount];
                    for (var index = 0; index < marshalledPropertyCount; index++) fieldPointer[index] = DisplayPlaneProperties2.MarshalFrom(&marshalledProperties[index]);
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
        ///     The PhysicalDevice handle to extend.
        /// </param>
        /// <param name="display">
        /// </param>
        public static unsafe DisplayModeProperties2[] GetDisplayModeProperties2(this PhysicalDevice extendedHandle, Display display)
        {
            try
            {
                var result = default(DisplayModeProperties2[]);
                var marshalledPropertyCount = default(uint);
                var commandCache = default(CommandCache);
                var marshalledProperties = default(Interop.Khronos.DisplayModeProperties2*);
                commandCache = extendedHandle.commandCache;
                var commandDelegate = commandCache.Cache.vkGetDisplayModeProperties2KHR;
                var methodResult = commandDelegate(extendedHandle.handle, display?.handle ?? default(Interop.Khronos.Display), &marshalledPropertyCount, marshalledProperties);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                marshalledProperties = (Interop.Khronos.DisplayModeProperties2*)HeapUtil.Allocate<Interop.Khronos.DisplayModeProperties2>(marshalledPropertyCount);
                commandDelegate(extendedHandle.handle, display?.handle ?? default(Interop.Khronos.Display), &marshalledPropertyCount, marshalledProperties);
                if (marshalledProperties != null)
                {
                    var fieldPointer = new DisplayModeProperties2[marshalledPropertyCount];
                    for (var index = 0; index < marshalledPropertyCount; index++) fieldPointer[index] = DisplayModeProperties2.MarshalFrom(&marshalledProperties[index]);
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
        ///     The PhysicalDevice handle to extend.
        /// </param>
        /// <param name="displayPlaneInfo">
        /// </param>
        public static unsafe DisplayPlaneCapabilities2 GetDisplayPlaneCapabilities2(this PhysicalDevice extendedHandle, DisplayPlaneInfo2 displayPlaneInfo)
        {
            try
            {
                var result = default(DisplayPlaneCapabilities2);
                var commandCache = default(CommandCache);
                var marshalledDisplayPlaneInfo = default(Interop.Khronos.DisplayPlaneInfo2*);
                var marshalledCapabilities = default(Interop.Khronos.DisplayPlaneCapabilities2);
                commandCache = extendedHandle.commandCache;
                marshalledDisplayPlaneInfo = (Interop.Khronos.DisplayPlaneInfo2*)HeapUtil.Allocate<Interop.Khronos.DisplayPlaneInfo2>();
                displayPlaneInfo.MarshalTo(marshalledDisplayPlaneInfo);
                var commandDelegate = commandCache.Cache.vkGetDisplayPlaneCapabilities2KHR;
                var methodResult = commandDelegate(extendedHandle.handle, marshalledDisplayPlaneInfo, &marshalledCapabilities);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                result = DisplayPlaneCapabilities2.MarshalFrom(&marshalledCapabilities);
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }
    }
}