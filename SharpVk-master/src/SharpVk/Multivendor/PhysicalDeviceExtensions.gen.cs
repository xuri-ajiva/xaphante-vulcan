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
    public static class PhysicalDeviceExtensions
    {
        /// <summary>
        ///     Release access to an acquired Display.
        /// </summary>
        /// <param name="extendedHandle">
        ///     The PhysicalDevice handle to extend.
        /// </param>
        /// <param name="display">
        /// </param>
        public static void ReleaseDisplay(this PhysicalDevice extendedHandle, Display display)
        {
            try
            {
                var commandCache = default(CommandCache);
                commandCache = extendedHandle.CommandCache;
                var commandDelegate = commandCache.Cache.VkReleaseDisplayExt;
                var methodResult = commandDelegate(extendedHandle.Handle, display?.Handle ?? default(Interop.Khronos.Display));
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Acquire access to a Display using Xlib.
        /// </summary>
        /// <param name="extendedHandle">
        ///     The PhysicalDevice handle to extend.
        /// </param>
        /// <param name="dpy">
        ///     A connection to the X11 server that currently owns the display.
        /// </param>
        /// <param name="display">
        ///     The display the caller wishes to control in Vulkan.
        /// </param>
        public static unsafe void AcquireXlibDisplay(this PhysicalDevice extendedHandle, IntPtr dpy, Display display)
        {
            try
            {
                var commandCache = default(CommandCache);
                var marshalledDpy = default(IntPtr*);
                commandCache = extendedHandle.CommandCache;
                marshalledDpy = (IntPtr*)HeapUtil.Allocate<IntPtr>();
                *marshalledDpy = dpy;
                var commandDelegate = commandCache.Cache.VkAcquireXlibDisplayExt;
                var methodResult = commandDelegate(extendedHandle.Handle, marshalledDpy, display?.Handle ?? default(Interop.Khronos.Display));
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Query the DisplayKHR corresponding to an X11 RandR Output.
        /// </summary>
        /// <param name="extendedHandle">
        ///     The PhysicalDevice handle to extend.
        /// </param>
        /// <param name="dpy">
        /// </param>
        /// <param name="rrOutput">
        /// </param>
        public static unsafe Display GetRandROutputDisplay(this PhysicalDevice extendedHandle, IntPtr dpy, IntPtr rrOutput)
        {
            try
            {
                var result = default(Display);
                var commandCache = default(CommandCache);
                var marshalledDpy = default(IntPtr*);
                var marshalledDisplay = default(Interop.Khronos.Display);
                commandCache = extendedHandle.CommandCache;
                marshalledDpy = (IntPtr*)HeapUtil.Allocate<IntPtr>();
                *marshalledDpy = dpy;
                var commandDelegate = commandCache.Cache.VkGetRandROutputDisplayExt;
                var methodResult = commandDelegate(extendedHandle.Handle, marshalledDpy, rrOutput, &marshalledDisplay);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                result = new(marshalledDisplay);
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
        public static unsafe SurfaceCapabilities2 GetSurfaceCapabilities2(this PhysicalDevice extendedHandle, Surface surface)
        {
            try
            {
                var result = default(SurfaceCapabilities2);
                var commandCache = default(CommandCache);
                var marshalledSurfaceCapabilities = default(Interop.Multivendor.SurfaceCapabilities2);
                commandCache = extendedHandle.CommandCache;
                var commandDelegate = commandCache.Cache.VkGetPhysicalDeviceSurfaceCapabilities2Ext;
                var methodResult = commandDelegate(extendedHandle.Handle, surface?.Handle ?? default(Interop.Khronos.Surface), &marshalledSurfaceCapabilities);
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
        /// <param name="samples">
        /// </param>
        public static unsafe MultisampleProperties GetMultisampleProperties(this PhysicalDevice extendedHandle, SampleCountFlags samples)
        {
            try
            {
                var result = default(MultisampleProperties);
                var commandCache = default(CommandCache);
                var marshalledMultisampleProperties = default(Interop.Multivendor.MultisampleProperties);
                commandCache = extendedHandle.CommandCache;
                var commandDelegate = commandCache.Cache.VkGetPhysicalDeviceMultisamplePropertiesExt;
                commandDelegate(extendedHandle.Handle, samples, &marshalledMultisampleProperties);
                result = MultisampleProperties.MarshalFrom(&marshalledMultisampleProperties);
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
        public static unsafe TimeDomain[] GetCalibrateableTimeDomains(this PhysicalDevice extendedHandle)
        {
            try
            {
                var result = default(TimeDomain[]);
                var marshalledTimeDomainCount = default(uint);
                var commandCache = default(CommandCache);
                var marshalledTimeDomains = default(TimeDomain*);
                commandCache = extendedHandle.CommandCache;
                var commandDelegate = commandCache.Cache.VkGetPhysicalDeviceCalibrateableTimeDomainsExt;
                var methodResult = commandDelegate(extendedHandle.Handle, &marshalledTimeDomainCount, marshalledTimeDomains);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                marshalledTimeDomains = (TimeDomain*)HeapUtil.Allocate<TimeDomain>(marshalledTimeDomainCount);
                commandDelegate(extendedHandle.Handle, &marshalledTimeDomainCount, marshalledTimeDomains);
                if (marshalledTimeDomains != null)
                {
                    var fieldPointer = new TimeDomain[marshalledTimeDomainCount];
                    for (var index = 0; index < marshalledTimeDomainCount; index++) fieldPointer[index] = marshalledTimeDomains[index];
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
        public static unsafe PhysicalDeviceToolProperties[] GetToolProperties(this PhysicalDevice extendedHandle)
        {
            try
            {
                var result = default(PhysicalDeviceToolProperties[]);
                var marshalledToolCount = default(uint);
                var commandCache = default(CommandCache);
                var marshalledToolProperties = default(Interop.Multivendor.PhysicalDeviceToolProperties*);
                commandCache = extendedHandle.CommandCache;
                var commandDelegate = commandCache.Cache.VkGetPhysicalDeviceToolPropertiesExt;
                var methodResult = commandDelegate(extendedHandle.Handle, &marshalledToolCount, marshalledToolProperties);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                marshalledToolProperties = (Interop.Multivendor.PhysicalDeviceToolProperties*)HeapUtil.Allocate<Interop.Multivendor.PhysicalDeviceToolProperties>(marshalledToolCount);
                commandDelegate(extendedHandle.Handle, &marshalledToolCount, marshalledToolProperties);
                if (marshalledToolProperties != null)
                {
                    var fieldPointer = new PhysicalDeviceToolProperties[marshalledToolCount];
                    for (var index = 0; index < marshalledToolCount; index++) fieldPointer[index] = PhysicalDeviceToolProperties.MarshalFrom(&marshalledToolProperties[index]);
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
        ///     Query supported presentation modes
        /// </summary>
        /// <param name="extendedHandle">
        ///     The PhysicalDevice handle to extend.
        /// </param>
        /// <param name="surfaceInfo">
        ///     An instance of the VkPhysicalDeviceSurfaceInfo2KHR structure,
        ///     describing the surface and other fixed parameters that would be
        ///     consumed by vkCreateSwapchainKHR.
        /// </param>
        public static unsafe PresentMode[] GetSurfacePresentModes2(this PhysicalDevice extendedHandle, PhysicalDeviceSurfaceInfo2 surfaceInfo)
        {
            try
            {
                var result = default(PresentMode[]);
                var marshalledPresentModeCount = default(uint);
                var commandCache = default(CommandCache);
                var marshalledSurfaceInfo = default(Interop.Khronos.PhysicalDeviceSurfaceInfo2*);
                var marshalledPresentModes = default(PresentMode*);
                commandCache = extendedHandle.CommandCache;
                marshalledSurfaceInfo = (Interop.Khronos.PhysicalDeviceSurfaceInfo2*)HeapUtil.Allocate<Interop.Khronos.PhysicalDeviceSurfaceInfo2>();
                surfaceInfo.MarshalTo(marshalledSurfaceInfo);
                var commandDelegate = commandCache.Cache.VkGetPhysicalDeviceSurfacePresentModes2Ext;
                var methodResult = commandDelegate(extendedHandle.Handle, marshalledSurfaceInfo, &marshalledPresentModeCount, marshalledPresentModes);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                marshalledPresentModes = (PresentMode*)HeapUtil.Allocate<PresentMode>(marshalledPresentModeCount);
                commandDelegate(extendedHandle.Handle, marshalledSurfaceInfo, &marshalledPresentModeCount, marshalledPresentModes);
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
    }
}
