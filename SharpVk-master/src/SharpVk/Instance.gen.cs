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
using SharpVk.Multivendor;

namespace SharpVk
{
    /// <summary>
    ///     Opaque handle to a instance object.
    /// </summary>
    public partial class Instance
        : IProcLookup, IDisposable
    {
        internal readonly CommandCache CommandCache;
        internal readonly Interop.Instance Handle;

        internal Instance(CommandCache commandCache, Interop.Instance handle)
        {
            this.Handle = handle;
            this.CommandCache = new(this, "instance", commandCache);
            this.CommandCache.Initialise();
        }

        /// <summary>
        ///     The raw handle for this instance.
        /// </summary>
        public Interop.Instance RawHandle => Handle;

        /// <summary>
        ///     Destroys the handles and releases any unmanaged resources
        ///     associated with it.
        /// </summary>
        public void Dispose()
        {
            Destroy();
        }

        /// <summary>
        ///     Return a function pointer for a command.
        /// </summary>
        /// <param name="name">
        /// </param>
        public unsafe IntPtr GetProcedureAddress(string name)
        {
            try
            {
                var result = default(IntPtr);
                var commandDelegate = CommandCache.Cache.VkGetInstanceProcAddr;
                result = commandDelegate(Handle, HeapUtil.MarshalTo(name));
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Create a new Vulkan instance.
        /// </summary>
        /// <param name="commandCache">
        /// </param>
        /// <param name="flags">
        ///     Reserved for future use.
        /// </param>
        /// <param name="applicationInfo">
        ///     Null or an instance of ApplicationInfo. If not Null, this
        ///     information helps implementations recognize behavior inherent to
        ///     classes of applications. ApplicationInfo is defined in detail
        ///     below.
        /// </param>
        /// <param name="enabledLayerNames">
        ///     An array of enabledLayerCount strings containing the names of
        ///     layers to enable for the created instance. See the Layers section
        ///     for further details.
        /// </param>
        /// <param name="enabledExtensionNames">
        ///     An array of enabledExtensionCount strings containing the names of
        ///     extensions to enable.
        /// </param>
        /// <param name="debugReportCallbackCreateInfoExt">
        ///     Extension struct
        /// </param>
        /// <param name="validationFlagsExt">
        ///     Extension struct
        /// </param>
        /// <param name="validationFeaturesExt">
        ///     Extension struct
        /// </param>
        /// <param name="debugUtilsMessengerCreateInfoExt">
        ///     Extension struct
        /// </param>
        /// <param name="allocator">
        ///     An optional AllocationCallbacks instance that controls host memory
        ///     allocation.
        /// </param>
        public static unsafe Instance Create(CommandCache commandCache, ArrayProxy<string>? enabledLayerNames, ArrayProxy<string>? enabledExtensionNames, InstanceCreateFlags? flags = default, ApplicationInfo? applicationInfo = default, DebugReportCallbackCreateInfo? debugReportCallbackCreateInfoExt = null, ValidationFlags? validationFlagsExt = null, ValidationFeatures? validationFeaturesExt = null, DebugUtilsMessengerCreateInfo? debugUtilsMessengerCreateInfoExt = null, AllocationCallbacks? allocator = default)
        {
            try
            {
                var result = default(Instance);
                var marshalledCreateInfo = default(Interop.InstanceCreateInfo*);
                var vkInstanceCreateInfoNextPointer = default(void*);
                var marshalledAllocator = default(Interop.AllocationCallbacks*);
                var marshalledInstance = default(Interop.Instance);
                if (debugReportCallbackCreateInfoExt != null)
                {
                    var extensionPointer = default(Interop.Multivendor.DebugReportCallbackCreateInfo*);
                    extensionPointer = (Interop.Multivendor.DebugReportCallbackCreateInfo*)HeapUtil.Allocate<Interop.Multivendor.DebugReportCallbackCreateInfo>();
                    debugReportCallbackCreateInfoExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkInstanceCreateInfoNextPointer;
                    vkInstanceCreateInfoNextPointer = extensionPointer;
                }
                if (validationFlagsExt != null)
                {
                    var extensionPointer = default(Interop.Multivendor.ValidationFlags*);
                    extensionPointer = (Interop.Multivendor.ValidationFlags*)HeapUtil.Allocate<Interop.Multivendor.ValidationFlags>();
                    validationFlagsExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkInstanceCreateInfoNextPointer;
                    vkInstanceCreateInfoNextPointer = extensionPointer;
                }
                if (validationFeaturesExt != null)
                {
                    var extensionPointer = default(Interop.Multivendor.ValidationFeatures*);
                    extensionPointer = (Interop.Multivendor.ValidationFeatures*)HeapUtil.Allocate<Interop.Multivendor.ValidationFeatures>();
                    validationFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkInstanceCreateInfoNextPointer;
                    vkInstanceCreateInfoNextPointer = extensionPointer;
                }
                if (debugUtilsMessengerCreateInfoExt != null)
                {
                    var extensionPointer = default(Interop.Multivendor.DebugUtilsMessengerCreateInfo*);
                    extensionPointer = (Interop.Multivendor.DebugUtilsMessengerCreateInfo*)HeapUtil.Allocate<Interop.Multivendor.DebugUtilsMessengerCreateInfo>();
                    debugUtilsMessengerCreateInfoExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkInstanceCreateInfoNextPointer;
                    vkInstanceCreateInfoNextPointer = extensionPointer;
                }
                marshalledCreateInfo = (Interop.InstanceCreateInfo*)HeapUtil.Allocate<Interop.InstanceCreateInfo>();
                marshalledCreateInfo->SType = StructureType.InstanceCreateInfo;
                marshalledCreateInfo->Next = vkInstanceCreateInfoNextPointer;
                if (flags != null)
                    marshalledCreateInfo->Flags = flags.Value;
                else
                    marshalledCreateInfo->Flags = default;
                if (applicationInfo != null)
                {
                    marshalledCreateInfo->ApplicationInfo = (Interop.ApplicationInfo*)HeapUtil.Allocate<Interop.ApplicationInfo>();
                    applicationInfo.Value.MarshalTo(marshalledCreateInfo->ApplicationInfo);
                }
                else
                {
                    marshalledCreateInfo->ApplicationInfo = default;
                }
                marshalledCreateInfo->EnabledLayerCount = HeapUtil.GetLength(enabledLayerNames);
                marshalledCreateInfo->EnabledLayerNames = HeapUtil.MarshalTo(enabledLayerNames);
                marshalledCreateInfo->EnabledExtensionCount = HeapUtil.GetLength(enabledExtensionNames);
                marshalledCreateInfo->EnabledExtensionNames = HeapUtil.MarshalTo(enabledExtensionNames);
                if (allocator != null)
                {
                    marshalledAllocator = (Interop.AllocationCallbacks*)HeapUtil.Allocate<Interop.AllocationCallbacks>();
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default;
                }
                var commandDelegate = commandCache.Cache.VkCreateInstance;
                var methodResult = commandDelegate(marshalledCreateInfo, marshalledAllocator, &marshalledInstance);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                result = new(commandCache, marshalledInstance);
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Destroy an instance of Vulkan.
        /// </summary>
        /// <param name="allocator">
        ///     An optional AllocationCallbacks instance that controls host memory
        ///     allocation.
        /// </param>
        public unsafe void Destroy(AllocationCallbacks? allocator = default)
        {
            try
            {
                var marshalledAllocator = default(Interop.AllocationCallbacks*);
                if (allocator != null)
                {
                    marshalledAllocator = (Interop.AllocationCallbacks*)HeapUtil.Allocate<Interop.AllocationCallbacks>();
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default;
                }
                var commandDelegate = CommandCache.Cache.VkDestroyInstance;
                commandDelegate(Handle, marshalledAllocator);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Enumerates the physical devices accessible to a Vulkan instance.
        /// </summary>
        public unsafe PhysicalDevice[] EnumeratePhysicalDevices()
        {
            try
            {
                var result = default(PhysicalDevice[]);
                var marshalledPhysicalDeviceCount = default(uint);
                var marshalledPhysicalDevices = default(Interop.PhysicalDevice*);
                var commandDelegate = CommandCache.Cache.VkEnumeratePhysicalDevices;
                var methodResult = commandDelegate(Handle, &marshalledPhysicalDeviceCount, marshalledPhysicalDevices);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                marshalledPhysicalDevices = (Interop.PhysicalDevice*)HeapUtil.Allocate<Interop.PhysicalDevice>(marshalledPhysicalDeviceCount);
                commandDelegate(Handle, &marshalledPhysicalDeviceCount, marshalledPhysicalDevices);
                if (marshalledPhysicalDevices != null)
                {
                    var fieldPointer = new PhysicalDevice[marshalledPhysicalDeviceCount];
                    for (var index = 0; index < marshalledPhysicalDeviceCount; index++) fieldPointer[index] = new(this, marshalledPhysicalDevices[index]);
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
        ///     Returns up to requested number of global extension properties.
        /// </summary>
        /// <param name="commandCache">
        /// </param>
        /// <param name="layerName">
        /// </param>
        public static unsafe ExtensionProperties[] EnumerateExtensionProperties(CommandCache commandCache, string layerName)
        {
            try
            {
                var result = default(ExtensionProperties[]);
                var marshalledPropertyCount = default(uint);
                var marshalledProperties = default(Interop.ExtensionProperties*);
                var commandDelegate = commandCache.Cache.VkEnumerateInstanceExtensionProperties;
                var methodResult = commandDelegate(HeapUtil.MarshalTo(layerName), &marshalledPropertyCount, marshalledProperties);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                marshalledProperties = (Interop.ExtensionProperties*)HeapUtil.Allocate<Interop.ExtensionProperties>(marshalledPropertyCount);
                commandDelegate(HeapUtil.MarshalTo(layerName), &marshalledPropertyCount, marshalledProperties);
                if (marshalledProperties != null)
                {
                    var fieldPointer = new ExtensionProperties[marshalledPropertyCount];
                    for (var index = 0; index < marshalledPropertyCount; index++) fieldPointer[index] = ExtensionProperties.MarshalFrom(&marshalledProperties[index]);
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
        ///     Returns up to requested number of global layer properties.
        /// </summary>
        /// <param name="commandCache">
        /// </param>
        public static unsafe LayerProperties[] EnumerateLayerProperties(CommandCache commandCache)
        {
            try
            {
                var result = default(LayerProperties[]);
                var marshalledPropertyCount = default(uint);
                var marshalledProperties = default(Interop.LayerProperties*);
                var commandDelegate = commandCache.Cache.VkEnumerateInstanceLayerProperties;
                var methodResult = commandDelegate(&marshalledPropertyCount, marshalledProperties);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                marshalledProperties = (Interop.LayerProperties*)HeapUtil.Allocate<Interop.LayerProperties>(marshalledPropertyCount);
                commandDelegate(&marshalledPropertyCount, marshalledProperties);
                if (marshalledProperties != null)
                {
                    var fieldPointer = new LayerProperties[marshalledPropertyCount];
                    for (var index = 0; index < marshalledPropertyCount; index++) fieldPointer[index] = LayerProperties.MarshalFrom(&marshalledProperties[index]);
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
        /// <param name="commandCache">
        /// </param>
        public static unsafe Version EnumerateVersion(CommandCache commandCache)
        {
            try
            {
                var result = default(Version);
                var marshalledApiVersion = default(uint);
                var commandDelegate = commandCache.Cache.VkEnumerateInstanceVersion;
                var methodResult = commandDelegate(&marshalledApiVersion);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                result = marshalledApiVersion;
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        /// </summary>
        public unsafe PhysicalDeviceGroupProperties[] EnumeratePhysicalDeviceGroups()
        {
            try
            {
                var result = default(PhysicalDeviceGroupProperties[]);
                var marshalledPhysicalDeviceGroupCount = default(uint);
                var marshalledPhysicalDeviceGroupProperties = default(Interop.PhysicalDeviceGroupProperties*);
                var commandDelegate = CommandCache.Cache.VkEnumeratePhysicalDeviceGroups;
                var methodResult = commandDelegate(Handle, &marshalledPhysicalDeviceGroupCount, marshalledPhysicalDeviceGroupProperties);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                marshalledPhysicalDeviceGroupProperties = (Interop.PhysicalDeviceGroupProperties*)HeapUtil.Allocate<Interop.PhysicalDeviceGroupProperties>(marshalledPhysicalDeviceGroupCount);
                commandDelegate(Handle, &marshalledPhysicalDeviceGroupCount, marshalledPhysicalDeviceGroupProperties);
                if (marshalledPhysicalDeviceGroupProperties != null)
                {
                    var fieldPointer = new PhysicalDeviceGroupProperties[marshalledPhysicalDeviceGroupCount];
                    for (var index = 0; index < marshalledPhysicalDeviceGroupCount; index++) fieldPointer[index] = PhysicalDeviceGroupProperties.MarshalFrom(&marshalledPhysicalDeviceGroupProperties[index]);
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
