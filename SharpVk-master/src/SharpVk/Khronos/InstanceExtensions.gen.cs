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
    public static class InstanceExtensions
    {
        /// <summary>
        ///     Create a SurfaceKHR structure representing a display plane and
        ///     mode.
        /// </summary>
        /// <param name="extendedHandle">
        ///     The Instance handle to extend.
        /// </param>
        /// <param name="flags">
        ///     Reserved for future use, and must be zero.
        /// </param>
        /// <param name="displayMode">
        ///     The mode to use when displaying this surface.
        /// </param>
        /// <param name="planeIndex">
        ///     The plane on which this surface appears.
        /// </param>
        /// <param name="planeStackIndex">
        ///     The z-order of the plane.
        /// </param>
        /// <param name="transform">
        ///     The transform to apply to the images as part of the scanout
        ///     operation.
        /// </param>
        /// <param name="globalAlpha">
        ///     The global alpha value. This value is ignored if alphaMode is not
        ///     VK_DISPLAY_PLANE_ALPHA_GLOBAL_BIT_KHR.
        /// </param>
        /// <param name="alphaMode">
        ///     The type of alpha blending to use.
        /// </param>
        /// <param name="imageExtent">
        /// </param>
        /// <param name="allocator">
        ///     An optional AllocationCallbacks instance that controls host memory
        ///     allocation.
        /// </param>
        public static unsafe Surface CreateDisplayPlaneSurface(this Instance extendedHandle, DisplayMode displayMode, uint planeIndex, uint planeStackIndex, SurfaceTransformFlags transform, float globalAlpha, DisplayPlaneAlphaFlags alphaMode, Extent2D imageExtent, DisplaySurfaceCreateFlags? flags = default, AllocationCallbacks? allocator = default)
        {
            try
            {
                var result = default(Surface);
                var commandCache = default(CommandCache);
                var marshalledCreateInfo = default(Interop.Khronos.DisplaySurfaceCreateInfo*);
                var vkDisplaySurfaceCreateInfoKhrNextPointer = default(void*);
                var marshalledAllocator = default(Interop.AllocationCallbacks*);
                var marshalledSurface = default(Interop.Khronos.Surface);
                commandCache = extendedHandle.CommandCache;
                marshalledCreateInfo = (Interop.Khronos.DisplaySurfaceCreateInfo*)HeapUtil.Allocate<Interop.Khronos.DisplaySurfaceCreateInfo>();
                marshalledCreateInfo->SType = StructureType.DisplaySurfaceCreateInfo;
                marshalledCreateInfo->Next = vkDisplaySurfaceCreateInfoKhrNextPointer;
                if (flags != null)
                    marshalledCreateInfo->Flags = flags.Value;
                else
                    marshalledCreateInfo->Flags = default;
                marshalledCreateInfo->DisplayMode = displayMode?.Handle ?? default(Interop.Khronos.DisplayMode);
                marshalledCreateInfo->PlaneIndex = planeIndex;
                marshalledCreateInfo->PlaneStackIndex = planeStackIndex;
                marshalledCreateInfo->Transform = transform;
                marshalledCreateInfo->GlobalAlpha = globalAlpha;
                marshalledCreateInfo->AlphaMode = alphaMode;
                marshalledCreateInfo->ImageExtent = imageExtent;
                if (allocator != null)
                {
                    marshalledAllocator = (Interop.AllocationCallbacks*)HeapUtil.Allocate<Interop.AllocationCallbacks>();
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default;
                }
                var commandDelegate = commandCache.Cache.VkCreateDisplayPlaneSurfaceKhr;
                var methodResult = commandDelegate(extendedHandle.Handle, marshalledCreateInfo, marshalledAllocator, &marshalledSurface);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                result = new(extendedHandle, marshalledSurface);
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Create a SurfaceKHR object for an X11 window, using the Xlib
        ///     client-side library.
        /// </summary>
        /// <param name="extendedHandle">
        ///     The Instance handle to extend.
        /// </param>
        /// <param name="flags">
        ///     Reserved for future use.
        /// </param>
        /// <param name="dpy">
        ///     An Xlib Display connection to the X server.
        /// </param>
        /// <param name="window">
        ///     An Xlib Window to associate the surface with.
        /// </param>
        /// <param name="allocator">
        ///     An optional AllocationCallbacks instance that controls host memory
        ///     allocation.
        /// </param>
        public static unsafe Surface CreateXlibSurface(this Instance extendedHandle, IntPtr dpy, IntPtr window, XlibSurfaceCreateFlags? flags = default, AllocationCallbacks? allocator = default)
        {
            try
            {
                var result = default(Surface);
                var commandCache = default(CommandCache);
                var marshalledCreateInfo = default(Interop.Khronos.XlibSurfaceCreateInfo*);
                var vkXlibSurfaceCreateInfoKhrNextPointer = default(void*);
                var marshalledAllocator = default(Interop.AllocationCallbacks*);
                var marshalledSurface = default(Interop.Khronos.Surface);
                commandCache = extendedHandle.CommandCache;
                marshalledCreateInfo = (Interop.Khronos.XlibSurfaceCreateInfo*)HeapUtil.Allocate<Interop.Khronos.XlibSurfaceCreateInfo>();
                marshalledCreateInfo->SType = StructureType.XlibSurfaceCreateInfo;
                marshalledCreateInfo->Next = vkXlibSurfaceCreateInfoKhrNextPointer;
                if (flags != null)
                    marshalledCreateInfo->Flags = flags.Value;
                else
                    marshalledCreateInfo->Flags = default;
                marshalledCreateInfo->Dpy = (IntPtr*)HeapUtil.Allocate<IntPtr>();
                *marshalledCreateInfo->Dpy = dpy;
                marshalledCreateInfo->Window = window;
                if (allocator != null)
                {
                    marshalledAllocator = (Interop.AllocationCallbacks*)HeapUtil.Allocate<Interop.AllocationCallbacks>();
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default;
                }
                var commandDelegate = commandCache.Cache.VkCreateXlibSurfaceKhr;
                var methodResult = commandDelegate(extendedHandle.Handle, marshalledCreateInfo, marshalledAllocator, &marshalledSurface);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                result = new(extendedHandle, marshalledSurface);
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Create a SurfaceKHR object for a X11 window, using the XCB
        ///     client-side library.
        /// </summary>
        /// <param name="extendedHandle">
        ///     The Instance handle to extend.
        /// </param>
        /// <param name="flags">
        ///     Reserved for future use.
        /// </param>
        /// <param name="connection">
        ///     An xcb_connection_t to the X server.
        /// </param>
        /// <param name="window">
        ///     The xcb_window_t for the X11 window to associate the surface with.
        /// </param>
        /// <param name="allocator">
        ///     An optional AllocationCallbacks instance that controls host memory
        ///     allocation.
        /// </param>
        public static unsafe Surface CreateXcbSurface(this Instance extendedHandle, IntPtr connection, IntPtr window, XcbSurfaceCreateFlags? flags = default, AllocationCallbacks? allocator = default)
        {
            try
            {
                var result = default(Surface);
                var commandCache = default(CommandCache);
                var marshalledCreateInfo = default(Interop.Khronos.XcbSurfaceCreateInfo*);
                var vkXcbSurfaceCreateInfoKhrNextPointer = default(void*);
                var marshalledAllocator = default(Interop.AllocationCallbacks*);
                var marshalledSurface = default(Interop.Khronos.Surface);
                commandCache = extendedHandle.CommandCache;
                marshalledCreateInfo = (Interop.Khronos.XcbSurfaceCreateInfo*)HeapUtil.Allocate<Interop.Khronos.XcbSurfaceCreateInfo>();
                marshalledCreateInfo->SType = StructureType.XcbSurfaceCreateInfo;
                marshalledCreateInfo->Next = vkXcbSurfaceCreateInfoKhrNextPointer;
                if (flags != null)
                    marshalledCreateInfo->Flags = flags.Value;
                else
                    marshalledCreateInfo->Flags = default;
                marshalledCreateInfo->Connection = (IntPtr*)HeapUtil.Allocate<IntPtr>();
                *marshalledCreateInfo->Connection = connection;
                marshalledCreateInfo->Window = window;
                if (allocator != null)
                {
                    marshalledAllocator = (Interop.AllocationCallbacks*)HeapUtil.Allocate<Interop.AllocationCallbacks>();
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default;
                }
                var commandDelegate = commandCache.Cache.VkCreateXcbSurfaceKhr;
                var methodResult = commandDelegate(extendedHandle.Handle, marshalledCreateInfo, marshalledAllocator, &marshalledSurface);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                result = new(extendedHandle, marshalledSurface);
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Create a SurfaceKHR object for a Wayland window.
        /// </summary>
        /// <param name="extendedHandle">
        ///     The Instance handle to extend.
        /// </param>
        /// <param name="flags">
        ///     Reserved for future use.
        /// </param>
        /// <param name="display">
        ///     display and surface are pointers to the Wayland wl_display and
        ///     wl_surface to associate the surface with.
        /// </param>
        /// <param name="surface">
        /// </param>
        /// <param name="allocator">
        ///     An optional AllocationCallbacks instance that controls host memory
        ///     allocation.
        /// </param>
        public static unsafe Surface CreateWaylandSurface(this Instance extendedHandle, IntPtr display, IntPtr surface, WaylandSurfaceCreateFlags? flags = default, AllocationCallbacks? allocator = default)
        {
            try
            {
                var result = default(Surface);
                var commandCache = default(CommandCache);
                var marshalledCreateInfo = default(Interop.Khronos.WaylandSurfaceCreateInfo*);
                var vkWaylandSurfaceCreateInfoKhrNextPointer = default(void*);
                var marshalledAllocator = default(Interop.AllocationCallbacks*);
                var marshalledSurface = default(Interop.Khronos.Surface);
                commandCache = extendedHandle.CommandCache;
                marshalledCreateInfo = (Interop.Khronos.WaylandSurfaceCreateInfo*)HeapUtil.Allocate<Interop.Khronos.WaylandSurfaceCreateInfo>();
                marshalledCreateInfo->SType = StructureType.WaylandSurfaceCreateInfo;
                marshalledCreateInfo->Next = vkWaylandSurfaceCreateInfoKhrNextPointer;
                if (flags != null)
                    marshalledCreateInfo->Flags = flags.Value;
                else
                    marshalledCreateInfo->Flags = default;
                marshalledCreateInfo->Display = (IntPtr*)HeapUtil.Allocate<IntPtr>();
                *marshalledCreateInfo->Display = display;
                marshalledCreateInfo->Surface = (IntPtr*)HeapUtil.Allocate<IntPtr>();
                *marshalledCreateInfo->Surface = surface;
                if (allocator != null)
                {
                    marshalledAllocator = (Interop.AllocationCallbacks*)HeapUtil.Allocate<Interop.AllocationCallbacks>();
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default;
                }
                var commandDelegate = commandCache.Cache.VkCreateWaylandSurfaceKhr;
                var methodResult = commandDelegate(extendedHandle.Handle, marshalledCreateInfo, marshalledAllocator, &marshalledSurface);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                result = new(extendedHandle, marshalledSurface);
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Create a SurfaceKHR object for an Android native window.
        /// </summary>
        /// <param name="extendedHandle">
        ///     The Instance handle to extend.
        /// </param>
        /// <param name="flags">
        ///     Reserved for future use.
        /// </param>
        /// <param name="window">
        ///     A pointer to the ANativeWindow to associate the surface with.
        /// </param>
        /// <param name="allocator">
        ///     An optional AllocationCallbacks instance that controls host memory
        ///     allocation.
        /// </param>
        public static unsafe Surface CreateAndroidSurface(this Instance extendedHandle, IntPtr window, AndroidSurfaceCreateFlags? flags = default, AllocationCallbacks? allocator = default)
        {
            try
            {
                var result = default(Surface);
                var commandCache = default(CommandCache);
                var marshalledCreateInfo = default(Interop.Khronos.AndroidSurfaceCreateInfo*);
                var vkAndroidSurfaceCreateInfoKhrNextPointer = default(void*);
                var marshalledAllocator = default(Interop.AllocationCallbacks*);
                var marshalledSurface = default(Interop.Khronos.Surface);
                commandCache = extendedHandle.CommandCache;
                marshalledCreateInfo = (Interop.Khronos.AndroidSurfaceCreateInfo*)HeapUtil.Allocate<Interop.Khronos.AndroidSurfaceCreateInfo>();
                marshalledCreateInfo->SType = StructureType.AndroidSurfaceCreateInfo;
                marshalledCreateInfo->Next = vkAndroidSurfaceCreateInfoKhrNextPointer;
                if (flags != null)
                    marshalledCreateInfo->Flags = flags.Value;
                else
                    marshalledCreateInfo->Flags = default;
                marshalledCreateInfo->Window = (IntPtr*)HeapUtil.Allocate<IntPtr>();
                *marshalledCreateInfo->Window = window;
                if (allocator != null)
                {
                    marshalledAllocator = (Interop.AllocationCallbacks*)HeapUtil.Allocate<Interop.AllocationCallbacks>();
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default;
                }
                var commandDelegate = commandCache.Cache.VkCreateAndroidSurfaceKhr;
                var methodResult = commandDelegate(extendedHandle.Handle, marshalledCreateInfo, marshalledAllocator, &marshalledSurface);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                result = new(extendedHandle, marshalledSurface);
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Create a SurfaceKHR object for an Win32 native window.
        /// </summary>
        /// <param name="extendedHandle">
        ///     The Instance handle to extend.
        /// </param>
        /// <param name="flags">
        ///     Reserved for future use.
        /// </param>
        /// <param name="hinstance">
        ///     Win32 HINSTANCE for the window to associate the surface with.
        /// </param>
        /// <param name="hwnd">
        ///     Win32 HWND for the window to associate the surface with.
        /// </param>
        /// <param name="allocator">
        ///     An optional AllocationCallbacks instance that controls host memory
        ///     allocation.
        /// </param>
        public static unsafe Surface CreateWin32Surface(this Instance extendedHandle, IntPtr hinstance, IntPtr hwnd, Win32SurfaceCreateFlags? flags = default, AllocationCallbacks? allocator = default)
        {
            try
            {
                var result = default(Surface);
                var commandCache = default(CommandCache);
                var marshalledCreateInfo = default(Interop.Khronos.Win32SurfaceCreateInfo*);
                var vkWin32SurfaceCreateInfoKhrNextPointer = default(void*);
                var marshalledAllocator = default(Interop.AllocationCallbacks*);
                var marshalledSurface = default(Interop.Khronos.Surface);
                commandCache = extendedHandle.CommandCache;
                marshalledCreateInfo = (Interop.Khronos.Win32SurfaceCreateInfo*)HeapUtil.Allocate<Interop.Khronos.Win32SurfaceCreateInfo>();
                marshalledCreateInfo->SType = StructureType.Win32SurfaceCreateInfo;
                marshalledCreateInfo->Next = vkWin32SurfaceCreateInfoKhrNextPointer;
                if (flags != null)
                    marshalledCreateInfo->Flags = flags.Value;
                else
                    marshalledCreateInfo->Flags = default;
                marshalledCreateInfo->Hinstance = hinstance;
                marshalledCreateInfo->Hwnd = hwnd;
                if (allocator != null)
                {
                    marshalledAllocator = (Interop.AllocationCallbacks*)HeapUtil.Allocate<Interop.AllocationCallbacks>();
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default;
                }
                var commandDelegate = commandCache.Cache.VkCreateWin32SurfaceKhr;
                var methodResult = commandDelegate(extendedHandle.Handle, marshalledCreateInfo, marshalledAllocator, &marshalledSurface);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                result = new(extendedHandle, marshalledSurface);
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }
    }
}
