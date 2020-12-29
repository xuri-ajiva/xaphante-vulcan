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
using System.Runtime.InteropServices;
using SharpVk.Interop;
using SharpVk.Khronos;

namespace SharpVk.Multivendor
{
    /// <summary>
    /// </summary>
    public static class InstanceExtensions
    {
        /// <summary>
        ///     Create a debug report callback object.
        /// </summary>
        /// <param name="extendedHandle">
        ///     The Instance handle to extend.
        /// </param>
        /// <param name="flags">
        ///     flags indicate which event(s) will cause this callback to be
        ///     called. Flags are interpreted as bitmasks and multiple may be set.
        ///     Bits which can be set include: + --
        /// </param>
        /// <param name="callback">
        /// </param>
        /// <param name="userData">
        /// </param>
        /// <param name="allocator">
        ///     An optional AllocationCallbacks instance that controls host memory
        ///     allocation.
        /// </param>
        public static unsafe DebugReportCallback CreateDebugReportCallback(this Instance extendedHandle, DebugReportCallbackDelegate callback, DebugReportFlags? flags = default, IntPtr? userData = default, AllocationCallbacks? allocator = default)
        {
            try
            {
                var result = default(DebugReportCallback);
                var commandCache = default(CommandCache);
                var marshalledCreateInfo = default(Interop.Multivendor.DebugReportCallbackCreateInfo*);
                var vkDebugReportCallbackCreateInfoEXTNextPointer = default(void*);
                var marshalledAllocator = default(Interop.AllocationCallbacks*);
                var marshalledCallback = default(Interop.Multivendor.DebugReportCallback);
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfo = (Interop.Multivendor.DebugReportCallbackCreateInfo*)HeapUtil.Allocate<Interop.Multivendor.DebugReportCallbackCreateInfo>();
                marshalledCreateInfo->SType = StructureType.DebugReportCallbackCreateInfo;
                marshalledCreateInfo->Next = vkDebugReportCallbackCreateInfoEXTNextPointer;
                if (flags != null)
                    marshalledCreateInfo->Flags = flags.Value;
                else
                    marshalledCreateInfo->Flags = default;
                marshalledCreateInfo->Callback = Marshal.GetFunctionPointerForDelegate(callback);
                if (userData != null)
                    marshalledCreateInfo->UserData = userData.Value.ToPointer();
                else
                    marshalledCreateInfo->UserData = default;
                if (allocator != null)
                {
                    marshalledAllocator = (Interop.AllocationCallbacks*)HeapUtil.Allocate<Interop.AllocationCallbacks>();
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default;
                }
                var commandDelegate = commandCache.Cache.vkCreateDebugReportCallbackEXT;
                var methodResult = commandDelegate(extendedHandle.handle, marshalledCreateInfo, marshalledAllocator, &marshalledCallback);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                result = new(extendedHandle, marshalledCallback);
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
        ///     The Instance handle to extend.
        /// </param>
        /// <param name="flags">
        /// </param>
        /// <param name="objectType">
        /// </param>
        /// <param name="object">
        /// </param>
        /// <param name="location">
        /// </param>
        /// <param name="messageCode">
        /// </param>
        /// <param name="layerPrefix">
        /// </param>
        /// <param name="message">
        /// </param>
        public static unsafe void DebugReportMessage(this Instance extendedHandle, DebugReportFlags flags, DebugReportObjectType objectType, ulong @object, HostSize location, int messageCode, string layerPrefix, string message)
        {
            try
            {
                var commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                var commandDelegate = commandCache.Cache.vkDebugReportMessageEXT;
                commandDelegate(extendedHandle.handle, flags, objectType, @object, location, messageCode, HeapUtil.MarshalTo(layerPrefix), HeapUtil.MarshalTo(message));
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="extendedHandle">
        ///     The Instance handle to extend.
        /// </param>
        /// <param name="flags">
        /// </param>
        /// <param name="messageSeverity">
        /// </param>
        /// <param name="messageType">
        /// </param>
        /// <param name="userCallback">
        /// </param>
        /// <param name="userData">
        /// </param>
        /// <param name="allocator">
        /// </param>
        public static unsafe DebugUtilsMessenger CreateDebugUtilsMessenger(this Instance extendedHandle, DebugUtilsMessageSeverityFlags messageSeverity, DebugUtilsMessageTypeFlags messageType, DebugUtilsMessengerCallbackDelegate userCallback, DebugUtilsMessengerCreateFlags? flags = default, IntPtr? userData = default, AllocationCallbacks? allocator = default)
        {
            try
            {
                var result = default(DebugUtilsMessenger);
                var commandCache = default(CommandCache);
                var marshalledCreateInfo = default(Interop.Multivendor.DebugUtilsMessengerCreateInfo*);
                var vkDebugUtilsMessengerCreateInfoEXTNextPointer = default(void*);
                var marshalledAllocator = default(Interop.AllocationCallbacks*);
                var marshalledMessenger = default(Interop.Multivendor.DebugUtilsMessenger);
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfo = (Interop.Multivendor.DebugUtilsMessengerCreateInfo*)HeapUtil.Allocate<Interop.Multivendor.DebugUtilsMessengerCreateInfo>();
                marshalledCreateInfo->SType = StructureType.DebugUtilsMessengerCreateInfo;
                marshalledCreateInfo->Next = vkDebugUtilsMessengerCreateInfoEXTNextPointer;
                if (flags != null)
                    marshalledCreateInfo->Flags = flags.Value;
                else
                    marshalledCreateInfo->Flags = default;
                marshalledCreateInfo->MessageSeverity = messageSeverity;
                marshalledCreateInfo->MessageType = messageType;
                marshalledCreateInfo->UserCallback = Marshal.GetFunctionPointerForDelegate(userCallback);
                if (userData != null)
                    marshalledCreateInfo->UserData = userData.Value.ToPointer();
                else
                    marshalledCreateInfo->UserData = default;
                if (allocator != null)
                {
                    marshalledAllocator = (Interop.AllocationCallbacks*)HeapUtil.Allocate<Interop.AllocationCallbacks>();
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default;
                }
                var commandDelegate = commandCache.Cache.vkCreateDebugUtilsMessengerEXT;
                var methodResult = commandDelegate(extendedHandle.handle, marshalledCreateInfo, marshalledAllocator, &marshalledMessenger);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                result = new(extendedHandle, marshalledMessenger);
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
        ///     The Instance handle to extend.
        /// </param>
        /// <param name="messageSeverity">
        /// </param>
        /// <param name="messageTypes">
        /// </param>
        /// <param name="callbackData">
        /// </param>
        public static unsafe void SubmitDebugUtilsMessage(this Instance extendedHandle, DebugUtilsMessageSeverityFlags messageSeverity, DebugUtilsMessageTypeFlags messageTypes, DebugUtilsMessengerCallbackData callbackData)
        {
            try
            {
                var commandCache = default(CommandCache);
                var marshalledCallbackData = default(Interop.Multivendor.DebugUtilsMessengerCallbackData*);
                commandCache = extendedHandle.commandCache;
                marshalledCallbackData = (Interop.Multivendor.DebugUtilsMessengerCallbackData*)HeapUtil.Allocate<Interop.Multivendor.DebugUtilsMessengerCallbackData>();
                callbackData.MarshalTo(marshalledCallbackData);
                var commandDelegate = commandCache.Cache.vkSubmitDebugUtilsMessageEXT;
                commandDelegate(extendedHandle.handle, messageSeverity, messageTypes, marshalledCallbackData);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Create a VkSurfaceKHR object for CAMetalLayer.
        /// </summary>
        /// <param name="extendedHandle">
        ///     The Instance handle to extend.
        /// </param>
        /// <param name="flags">
        ///     Reserved for future use.
        /// </param>
        /// <param name="layer">
        ///     A CAMetalLayer object that represents a renderable surface.
        /// </param>
        /// <param name="allocator">
        ///     The allocator used for host memory allocated for the surface object
        ///     when there is no more specific allocator available.
        /// </param>
        public static unsafe Surface CreateMetalSurface(this Instance extendedHandle, IntPtr layer, MetalSurfaceCreateFlags? flags = default, AllocationCallbacks? allocator = default)
        {
            try
            {
                var result = default(Surface);
                var commandCache = default(CommandCache);
                var marshalledCreateInfo = default(Interop.Multivendor.MetalSurfaceCreateInfo*);
                var vkMetalSurfaceCreateInfoEXTNextPointer = default(void*);
                var marshalledAllocator = default(Interop.AllocationCallbacks*);
                var marshalledSurface = default(Interop.Khronos.Surface);
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfo = (Interop.Multivendor.MetalSurfaceCreateInfo*)HeapUtil.Allocate<Interop.Multivendor.MetalSurfaceCreateInfo>();
                marshalledCreateInfo->SType = StructureType.MetalSurfaceCreateInfo;
                marshalledCreateInfo->Next = vkMetalSurfaceCreateInfoEXTNextPointer;
                if (flags != null)
                    marshalledCreateInfo->Flags = flags.Value;
                else
                    marshalledCreateInfo->Flags = default;
                marshalledCreateInfo->Layer = (IntPtr*)HeapUtil.Allocate<IntPtr>();
                *marshalledCreateInfo->Layer = layer;
                if (allocator != null)
                {
                    marshalledAllocator = (Interop.AllocationCallbacks*)HeapUtil.Allocate<Interop.AllocationCallbacks>();
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default;
                }
                var commandDelegate = commandCache.Cache.vkCreateMetalSurfaceEXT;
                var methodResult = commandDelegate(extendedHandle.handle, marshalledCreateInfo, marshalledAllocator, &marshalledSurface);
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
        ///     Create a headless Surface object
        /// </summary>
        /// <param name="extendedHandle">
        ///     The Instance handle to extend.
        /// </param>
        /// <param name="flags">
        ///     Reserved for future use
        /// </param>
        /// <param name="allocator">
        ///     The allocator used for host memory allocated for the surface object
        ///     when there is no more specific allocator available.
        /// </param>
        public static unsafe Surface CreateHeadlessSurface(this Instance extendedHandle, HeadlessSurfaceCreateFlags? flags = default, AllocationCallbacks? allocator = default)
        {
            try
            {
                var result = default(Surface);
                var commandCache = default(CommandCache);
                var marshalledCreateInfo = default(Interop.Multivendor.HeadlessSurfaceCreateInfo*);
                var vkHeadlessSurfaceCreateInfoEXTNextPointer = default(void*);
                var marshalledAllocator = default(Interop.AllocationCallbacks*);
                var marshalledSurface = default(Interop.Khronos.Surface);
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfo = (Interop.Multivendor.HeadlessSurfaceCreateInfo*)HeapUtil.Allocate<Interop.Multivendor.HeadlessSurfaceCreateInfo>();
                marshalledCreateInfo->SType = StructureType.HeadlessSurfaceCreateInfo;
                marshalledCreateInfo->Next = vkHeadlessSurfaceCreateInfoEXTNextPointer;
                if (flags != null)
                    marshalledCreateInfo->Flags = flags.Value;
                else
                    marshalledCreateInfo->Flags = default;
                if (allocator != null)
                {
                    marshalledAllocator = (Interop.AllocationCallbacks*)HeapUtil.Allocate<Interop.AllocationCallbacks>();
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default;
                }
                var commandDelegate = commandCache.Cache.vkCreateHeadlessSurfaceEXT;
                var methodResult = commandDelegate(extendedHandle.handle, marshalledCreateInfo, marshalledAllocator, &marshalledSurface);
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