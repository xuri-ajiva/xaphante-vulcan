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
using SharpVk.Android;
using SharpVk.Interop;
using SharpVk.Khronos;
using SharpVk.Multivendor;
using SharpVk.NVidia;
using ExportMemoryWin32HandleInfo = SharpVk.NVidia.ExportMemoryWin32HandleInfo;
using ImportMemoryWin32HandleInfo = SharpVk.NVidia.ImportMemoryWin32HandleInfo;

namespace SharpVk
{
    /// <summary>
    ///     Opaque handle to a device object.
    /// </summary>
    public partial class Device
        : IProcLookup, IDisposable
    {
        internal readonly CommandCache CommandCache;
        internal readonly Interop.Device Handle;

        internal readonly PhysicalDevice Parent;

        internal Device(PhysicalDevice parent, Interop.Device handle)
        {
            this.Handle = handle;
            this.Parent = parent;
            CommandCache = new(this, "device", parent.CommandCache);
            CommandCache.Initialise();
        }

        /// <summary>
        ///     The raw handle for this instance.
        /// </summary>
        public Interop.Device RawHandle => Handle;

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
                var commandDelegate = CommandCache.Cache.VkGetDeviceProcAddr;
                result = commandDelegate(Handle, HeapUtil.MarshalTo(name));
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Destroy a logical device.
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
                var commandDelegate = CommandCache.Cache.VkDestroyDevice;
                commandDelegate(Handle, marshalledAllocator);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Get a queue handle from a device.
        /// </summary>
        /// <param name="queueFamilyIndex">
        /// </param>
        /// <param name="queueIndex">
        /// </param>
        public unsafe Queue GetQueue(uint queueFamilyIndex, uint queueIndex)
        {
            try
            {
                var result = default(Queue);
                var marshalledQueue = default(Interop.Queue);
                var commandDelegate = CommandCache.Cache.VkGetDeviceQueue;
                commandDelegate(Handle, queueFamilyIndex, queueIndex, &marshalledQueue);
                result = new(this, marshalledQueue);
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Wait for a device to become idle.
        /// </summary>
        public void WaitIdle()
        {
            try
            {
                var commandDelegate = CommandCache.Cache.VkDeviceWaitIdle;
                var methodResult = commandDelegate(Handle);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Allocate GPU memory.
        /// </summary>
        /// <param name="allocationSize">
        ///     The size of the allocation in bytes
        /// </param>
        /// <param name="memoryTypeIndex">
        ///     The memory type index, which selects the properties of the memory
        ///     to be allocated, as well as the heap the memory will come from.
        /// </param>
        /// <param name="dedicatedAllocationMemoryAllocateInfoNv">
        ///     Extension struct
        /// </param>
        /// <param name="exportMemoryAllocateInfoNv">
        ///     Extension struct
        /// </param>
        /// <param name="importMemoryWin32HandleInfoNv">
        ///     Extension struct
        /// </param>
        /// <param name="exportMemoryWin32HandleInfoNv">
        ///     Extension struct
        /// </param>
        /// <param name="exportMemoryAllocateInfo">
        ///     Extension struct
        /// </param>
        /// <param name="importMemoryWin32HandleInfoKhr">
        ///     Extension struct
        /// </param>
        /// <param name="exportMemoryWin32HandleInfoKhr">
        ///     Extension struct
        /// </param>
        /// <param name="importMemoryFileDescriptorInfoKhr">
        ///     Extension struct
        /// </param>
        /// <param name="memoryAllocateFlagsInfo">
        ///     Extension struct
        /// </param>
        /// <param name="memoryDedicatedAllocateInfo">
        ///     Extension struct
        /// </param>
        /// <param name="importMemoryHostPointerInfoExt">
        ///     Extension struct
        /// </param>
        /// <param name="importAndroidHardwareBufferInfoAndroid">
        ///     Extension struct
        /// </param>
        /// <param name="memoryPriorityAllocateInfoExt">
        ///     Extension struct
        /// </param>
        /// <param name="memoryOpaqueCaptureAddressAllocateInfo">
        ///     Extension struct
        /// </param>
        /// <param name="allocator">
        ///     An optional AllocationCallbacks instance that controls host memory
        ///     allocation.
        /// </param>
        public unsafe DeviceMemory AllocateMemory(ulong allocationSize, uint memoryTypeIndex, DedicatedAllocationMemoryAllocateInfo? dedicatedAllocationMemoryAllocateInfoNv = null, NVidia.ExportMemoryAllocateInfo? exportMemoryAllocateInfoNv = null, ImportMemoryWin32HandleInfo? importMemoryWin32HandleInfoNv = null, ExportMemoryWin32HandleInfo? exportMemoryWin32HandleInfoNv = null, ExportMemoryAllocateInfo? exportMemoryAllocateInfo = null, Khronos.ImportMemoryWin32HandleInfo? importMemoryWin32HandleInfoKhr = null,
            Khronos.ExportMemoryWin32HandleInfo? exportMemoryWin32HandleInfoKhr = null, ImportMemoryFileDescriptorInfo? importMemoryFileDescriptorInfoKhr = null, MemoryAllocateFlagsInfo? memoryAllocateFlagsInfo = null, MemoryDedicatedAllocateInfo? memoryDedicatedAllocateInfo = null, ImportMemoryHostPointerInfo? importMemoryHostPointerInfoExt = null, ImportAndroidHardwareBufferInfo? importAndroidHardwareBufferInfoAndroid = null, MemoryPriorityAllocateInfo? memoryPriorityAllocateInfoExt = null,
            MemoryOpaqueCaptureAddressAllocateInfo? memoryOpaqueCaptureAddressAllocateInfo = null, AllocationCallbacks? allocator = default)
        {
            try
            {
                var result = default(DeviceMemory);
                var marshalledAllocateInfo = default(Interop.MemoryAllocateInfo*);
                var vkMemoryAllocateInfoNextPointer = default(void*);
                var marshalledAllocator = default(Interop.AllocationCallbacks*);
                var marshalledMemory = default(Interop.DeviceMemory);
                if (dedicatedAllocationMemoryAllocateInfoNv != null)
                {
                    var extensionPointer = default(Interop.NVidia.DedicatedAllocationMemoryAllocateInfo*);
                    extensionPointer = (Interop.NVidia.DedicatedAllocationMemoryAllocateInfo*)HeapUtil.Allocate<Interop.NVidia.DedicatedAllocationMemoryAllocateInfo>();
                    dedicatedAllocationMemoryAllocateInfoNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkMemoryAllocateInfoNextPointer;
                    vkMemoryAllocateInfoNextPointer = extensionPointer;
                }
                if (exportMemoryAllocateInfoNv != null)
                {
                    var extensionPointer = default(Interop.NVidia.ExportMemoryAllocateInfo*);
                    extensionPointer = (Interop.NVidia.ExportMemoryAllocateInfo*)HeapUtil.Allocate<Interop.NVidia.ExportMemoryAllocateInfo>();
                    exportMemoryAllocateInfoNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkMemoryAllocateInfoNextPointer;
                    vkMemoryAllocateInfoNextPointer = extensionPointer;
                }
                if (importMemoryWin32HandleInfoNv != null)
                {
                    var extensionPointer = default(Interop.NVidia.ImportMemoryWin32HandleInfo*);
                    extensionPointer = (Interop.NVidia.ImportMemoryWin32HandleInfo*)HeapUtil.Allocate<Interop.NVidia.ImportMemoryWin32HandleInfo>();
                    importMemoryWin32HandleInfoNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkMemoryAllocateInfoNextPointer;
                    vkMemoryAllocateInfoNextPointer = extensionPointer;
                }
                if (exportMemoryWin32HandleInfoNv != null)
                {
                    var extensionPointer = default(Interop.NVidia.ExportMemoryWin32HandleInfo*);
                    extensionPointer = (Interop.NVidia.ExportMemoryWin32HandleInfo*)HeapUtil.Allocate<Interop.NVidia.ExportMemoryWin32HandleInfo>();
                    exportMemoryWin32HandleInfoNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkMemoryAllocateInfoNextPointer;
                    vkMemoryAllocateInfoNextPointer = extensionPointer;
                }
                if (exportMemoryAllocateInfo != null)
                {
                    var extensionPointer = default(Interop.ExportMemoryAllocateInfo*);
                    extensionPointer = (Interop.ExportMemoryAllocateInfo*)HeapUtil.Allocate<Interop.ExportMemoryAllocateInfo>();
                    exportMemoryAllocateInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkMemoryAllocateInfoNextPointer;
                    vkMemoryAllocateInfoNextPointer = extensionPointer;
                }
                if (importMemoryWin32HandleInfoKhr != null)
                {
                    var extensionPointer = default(Interop.Khronos.ImportMemoryWin32HandleInfo*);
                    extensionPointer = (Interop.Khronos.ImportMemoryWin32HandleInfo*)HeapUtil.Allocate<Interop.Khronos.ImportMemoryWin32HandleInfo>();
                    importMemoryWin32HandleInfoKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkMemoryAllocateInfoNextPointer;
                    vkMemoryAllocateInfoNextPointer = extensionPointer;
                }
                if (exportMemoryWin32HandleInfoKhr != null)
                {
                    var extensionPointer = default(Interop.Khronos.ExportMemoryWin32HandleInfo*);
                    extensionPointer = (Interop.Khronos.ExportMemoryWin32HandleInfo*)HeapUtil.Allocate<Interop.Khronos.ExportMemoryWin32HandleInfo>();
                    exportMemoryWin32HandleInfoKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkMemoryAllocateInfoNextPointer;
                    vkMemoryAllocateInfoNextPointer = extensionPointer;
                }
                if (importMemoryFileDescriptorInfoKhr != null)
                {
                    var extensionPointer = default(Interop.Khronos.ImportMemoryFileDescriptorInfo*);
                    extensionPointer = (Interop.Khronos.ImportMemoryFileDescriptorInfo*)HeapUtil.Allocate<Interop.Khronos.ImportMemoryFileDescriptorInfo>();
                    importMemoryFileDescriptorInfoKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkMemoryAllocateInfoNextPointer;
                    vkMemoryAllocateInfoNextPointer = extensionPointer;
                }
                if (memoryAllocateFlagsInfo != null)
                {
                    var extensionPointer = default(Interop.MemoryAllocateFlagsInfo*);
                    extensionPointer = (Interop.MemoryAllocateFlagsInfo*)HeapUtil.Allocate<Interop.MemoryAllocateFlagsInfo>();
                    memoryAllocateFlagsInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkMemoryAllocateInfoNextPointer;
                    vkMemoryAllocateInfoNextPointer = extensionPointer;
                }
                if (memoryDedicatedAllocateInfo != null)
                {
                    var extensionPointer = default(Interop.MemoryDedicatedAllocateInfo*);
                    extensionPointer = (Interop.MemoryDedicatedAllocateInfo*)HeapUtil.Allocate<Interop.MemoryDedicatedAllocateInfo>();
                    memoryDedicatedAllocateInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkMemoryAllocateInfoNextPointer;
                    vkMemoryAllocateInfoNextPointer = extensionPointer;
                }
                if (importMemoryHostPointerInfoExt != null)
                {
                    var extensionPointer = default(Interop.Multivendor.ImportMemoryHostPointerInfo*);
                    extensionPointer = (Interop.Multivendor.ImportMemoryHostPointerInfo*)HeapUtil.Allocate<Interop.Multivendor.ImportMemoryHostPointerInfo>();
                    importMemoryHostPointerInfoExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkMemoryAllocateInfoNextPointer;
                    vkMemoryAllocateInfoNextPointer = extensionPointer;
                }
                if (importAndroidHardwareBufferInfoAndroid != null)
                {
                    var extensionPointer = default(Interop.Android.ImportAndroidHardwareBufferInfo*);
                    extensionPointer = (Interop.Android.ImportAndroidHardwareBufferInfo*)HeapUtil.Allocate<Interop.Android.ImportAndroidHardwareBufferInfo>();
                    importAndroidHardwareBufferInfoAndroid.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkMemoryAllocateInfoNextPointer;
                    vkMemoryAllocateInfoNextPointer = extensionPointer;
                }
                if (memoryPriorityAllocateInfoExt != null)
                {
                    var extensionPointer = default(Interop.Multivendor.MemoryPriorityAllocateInfo*);
                    extensionPointer = (Interop.Multivendor.MemoryPriorityAllocateInfo*)HeapUtil.Allocate<Interop.Multivendor.MemoryPriorityAllocateInfo>();
                    memoryPriorityAllocateInfoExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkMemoryAllocateInfoNextPointer;
                    vkMemoryAllocateInfoNextPointer = extensionPointer;
                }
                if (memoryOpaqueCaptureAddressAllocateInfo != null)
                {
                    var extensionPointer = default(Interop.MemoryOpaqueCaptureAddressAllocateInfo*);
                    extensionPointer = (Interop.MemoryOpaqueCaptureAddressAllocateInfo*)HeapUtil.Allocate<Interop.MemoryOpaqueCaptureAddressAllocateInfo>();
                    memoryOpaqueCaptureAddressAllocateInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkMemoryAllocateInfoNextPointer;
                    vkMemoryAllocateInfoNextPointer = extensionPointer;
                }
                marshalledAllocateInfo = (Interop.MemoryAllocateInfo*)HeapUtil.Allocate<Interop.MemoryAllocateInfo>();
                marshalledAllocateInfo->SType = StructureType.MemoryAllocateInfo;
                marshalledAllocateInfo->Next = vkMemoryAllocateInfoNextPointer;
                marshalledAllocateInfo->AllocationSize = allocationSize;
                marshalledAllocateInfo->MemoryTypeIndex = memoryTypeIndex;
                if (allocator != null)
                {
                    marshalledAllocator = (Interop.AllocationCallbacks*)HeapUtil.Allocate<Interop.AllocationCallbacks>();
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default;
                }
                var commandDelegate = CommandCache.Cache.VkAllocateMemory;
                var methodResult = commandDelegate(Handle, marshalledAllocateInfo, marshalledAllocator, &marshalledMemory);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                result = new(this, marshalledMemory);
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Flush mapped memory ranges.
        /// </summary>
        /// <param name="memoryRanges">
        /// </param>
        public unsafe void FlushMappedMemoryRanges(ArrayProxy<MappedMemoryRange>? memoryRanges)
        {
            try
            {
                var marshalledMemoryRanges = default(Interop.MappedMemoryRange*);
                if (memoryRanges.IsNull())
                {
                    marshalledMemoryRanges = null;
                }
                else
                {
                    if (memoryRanges.Value.Contents == ProxyContents.Single)
                    {
                        marshalledMemoryRanges = (Interop.MappedMemoryRange*)HeapUtil.Allocate<Interop.MappedMemoryRange>();
                        memoryRanges.Value.GetSingleValue().MarshalTo(&*marshalledMemoryRanges);
                    }
                    else
                    {
                        var fieldPointer = (Interop.MappedMemoryRange*)HeapUtil.AllocateAndClear<Interop.MappedMemoryRange>(HeapUtil.GetLength(memoryRanges.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(memoryRanges.Value); index++) memoryRanges.Value[index].MarshalTo(&fieldPointer[index]);
                        marshalledMemoryRanges = fieldPointer;
                    }
                }
                var commandDelegate = CommandCache.Cache.VkFlushMappedMemoryRanges;
                var methodResult = commandDelegate(Handle, HeapUtil.GetLength(memoryRanges), marshalledMemoryRanges);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Invalidate ranges of mapped memory objects.
        /// </summary>
        /// <param name="memoryRanges">
        /// </param>
        public unsafe void InvalidateMappedMemoryRanges(ArrayProxy<MappedMemoryRange>? memoryRanges)
        {
            try
            {
                var marshalledMemoryRanges = default(Interop.MappedMemoryRange*);
                if (memoryRanges.IsNull())
                {
                    marshalledMemoryRanges = null;
                }
                else
                {
                    if (memoryRanges.Value.Contents == ProxyContents.Single)
                    {
                        marshalledMemoryRanges = (Interop.MappedMemoryRange*)HeapUtil.Allocate<Interop.MappedMemoryRange>();
                        memoryRanges.Value.GetSingleValue().MarshalTo(&*marshalledMemoryRanges);
                    }
                    else
                    {
                        var fieldPointer = (Interop.MappedMemoryRange*)HeapUtil.AllocateAndClear<Interop.MappedMemoryRange>(HeapUtil.GetLength(memoryRanges.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(memoryRanges.Value); index++) memoryRanges.Value[index].MarshalTo(&fieldPointer[index]);
                        marshalledMemoryRanges = fieldPointer;
                    }
                }
                var commandDelegate = CommandCache.Cache.VkInvalidateMappedMemoryRanges;
                var methodResult = commandDelegate(Handle, HeapUtil.GetLength(memoryRanges), marshalledMemoryRanges);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Create a new fence object.
        /// </summary>
        /// <param name="flags">
        ///     flags defines the initial state and behavior of the fence. Bits
        ///     which can be set include: + --
        /// </param>
        /// <param name="exportFenceCreateInfo">
        ///     Extension struct
        /// </param>
        /// <param name="exportFenceWin32HandleInfoKhr">
        ///     Extension struct
        /// </param>
        /// <param name="allocator">
        ///     An optional AllocationCallbacks instance that controls host memory
        ///     allocation.
        /// </param>
        public unsafe Fence CreateFence(FenceCreateFlags? flags = default, ExportFenceCreateInfo? exportFenceCreateInfo = null, ExportFenceWin32HandleInfo? exportFenceWin32HandleInfoKhr = null, AllocationCallbacks? allocator = default)
        {
            try
            {
                var result = default(Fence);
                var marshalledCreateInfo = default(Interop.FenceCreateInfo*);
                var vkFenceCreateInfoNextPointer = default(void*);
                var marshalledAllocator = default(Interop.AllocationCallbacks*);
                var marshalledFence = default(Interop.Fence);
                if (exportFenceCreateInfo != null)
                {
                    var extensionPointer = default(Interop.ExportFenceCreateInfo*);
                    extensionPointer = (Interop.ExportFenceCreateInfo*)HeapUtil.Allocate<Interop.ExportFenceCreateInfo>();
                    exportFenceCreateInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkFenceCreateInfoNextPointer;
                    vkFenceCreateInfoNextPointer = extensionPointer;
                }
                if (exportFenceWin32HandleInfoKhr != null)
                {
                    var extensionPointer = default(Interop.Khronos.ExportFenceWin32HandleInfo*);
                    extensionPointer = (Interop.Khronos.ExportFenceWin32HandleInfo*)HeapUtil.Allocate<Interop.Khronos.ExportFenceWin32HandleInfo>();
                    exportFenceWin32HandleInfoKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkFenceCreateInfoNextPointer;
                    vkFenceCreateInfoNextPointer = extensionPointer;
                }
                marshalledCreateInfo = (Interop.FenceCreateInfo*)HeapUtil.Allocate<Interop.FenceCreateInfo>();
                marshalledCreateInfo->SType = StructureType.FenceCreateInfo;
                marshalledCreateInfo->Next = vkFenceCreateInfoNextPointer;
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
                var commandDelegate = CommandCache.Cache.VkCreateFence;
                var methodResult = commandDelegate(Handle, marshalledCreateInfo, marshalledAllocator, &marshalledFence);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                result = new(this, marshalledFence);
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Resets one or more fence objects.
        /// </summary>
        /// <param name="fences">
        /// </param>
        public unsafe void ResetFences(ArrayProxy<Fence>? fences)
        {
            try
            {
                var marshalledFences = default(Interop.Fence*);
                if (fences.IsNull())
                {
                    marshalledFences = null;
                }
                else
                {
                    if (fences.Value.Contents == ProxyContents.Single)
                    {
                        marshalledFences = (Interop.Fence*)HeapUtil.Allocate<Interop.Fence>();
                        *marshalledFences = fences.Value.GetSingleValue()?.Handle ?? default(Interop.Fence);
                    }
                    else
                    {
                        var fieldPointer = (Interop.Fence*)HeapUtil.AllocateAndClear<Interop.Fence>(HeapUtil.GetLength(fences.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(fences.Value); index++) fieldPointer[index] = fences.Value[index]?.Handle ?? default(Interop.Fence);
                        marshalledFences = fieldPointer;
                    }
                }
                var commandDelegate = CommandCache.Cache.VkResetFences;
                var methodResult = commandDelegate(Handle, HeapUtil.GetLength(fences), marshalledFences);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Wait for one or more fences to become signaled.
        /// </summary>
        /// <param name="fences">
        /// </param>
        /// <param name="waitAll">
        /// </param>
        /// <param name="timeout">
        /// </param>
        public unsafe Result WaitForFences(ArrayProxy<Fence>? fences, bool waitAll, ulong timeout)
        {
            try
            {
                var result = default(Result);
                var marshalledFences = default(Interop.Fence*);
                if (fences.IsNull())
                {
                    marshalledFences = null;
                }
                else
                {
                    if (fences.Value.Contents == ProxyContents.Single)
                    {
                        marshalledFences = (Interop.Fence*)HeapUtil.Allocate<Interop.Fence>();
                        *marshalledFences = fences.Value.GetSingleValue()?.Handle ?? default(Interop.Fence);
                    }
                    else
                    {
                        var fieldPointer = (Interop.Fence*)HeapUtil.AllocateAndClear<Interop.Fence>(HeapUtil.GetLength(fences.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(fences.Value); index++) fieldPointer[index] = fences.Value[index]?.Handle ?? default(Interop.Fence);
                        marshalledFences = fieldPointer;
                    }
                }
                var commandDelegate = CommandCache.Cache.VkWaitForFences;
                result = commandDelegate(Handle, HeapUtil.GetLength(fences), marshalledFences, waitAll, timeout);
                if (SharpVkException.IsError(result)) throw SharpVkException.Create(result);
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Create a new queue semaphore object.
        /// </summary>
        /// <param name="flags">
        ///     Reserved for future use.
        /// </param>
        /// <param name="exportSemaphoreCreateInfo">
        ///     Extension struct
        /// </param>
        /// <param name="exportSemaphoreWin32HandleInfoKhr">
        ///     Extension struct
        /// </param>
        /// <param name="semaphoreTypeCreateInfo">
        ///     Extension struct
        /// </param>
        /// <param name="allocator">
        ///     An optional AllocationCallbacks instance that controls host memory
        ///     allocation.
        /// </param>
        public unsafe Semaphore CreateSemaphore(SemaphoreCreateFlags? flags = default, ExportSemaphoreCreateInfo? exportSemaphoreCreateInfo = null, ExportSemaphoreWin32HandleInfo? exportSemaphoreWin32HandleInfoKhr = null, SemaphoreTypeCreateInfo? semaphoreTypeCreateInfo = null, AllocationCallbacks? allocator = default)
        {
            try
            {
                var result = default(Semaphore);
                var marshalledCreateInfo = default(Interop.SemaphoreCreateInfo*);
                var vkSemaphoreCreateInfoNextPointer = default(void*);
                var marshalledAllocator = default(Interop.AllocationCallbacks*);
                var marshalledSemaphore = default(Interop.Semaphore);
                if (exportSemaphoreCreateInfo != null)
                {
                    var extensionPointer = default(Interop.ExportSemaphoreCreateInfo*);
                    extensionPointer = (Interop.ExportSemaphoreCreateInfo*)HeapUtil.Allocate<Interop.ExportSemaphoreCreateInfo>();
                    exportSemaphoreCreateInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkSemaphoreCreateInfoNextPointer;
                    vkSemaphoreCreateInfoNextPointer = extensionPointer;
                }
                if (exportSemaphoreWin32HandleInfoKhr != null)
                {
                    var extensionPointer = default(Interop.Khronos.ExportSemaphoreWin32HandleInfo*);
                    extensionPointer = (Interop.Khronos.ExportSemaphoreWin32HandleInfo*)HeapUtil.Allocate<Interop.Khronos.ExportSemaphoreWin32HandleInfo>();
                    exportSemaphoreWin32HandleInfoKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkSemaphoreCreateInfoNextPointer;
                    vkSemaphoreCreateInfoNextPointer = extensionPointer;
                }
                if (semaphoreTypeCreateInfo != null)
                {
                    var extensionPointer = default(Interop.SemaphoreTypeCreateInfo*);
                    extensionPointer = (Interop.SemaphoreTypeCreateInfo*)HeapUtil.Allocate<Interop.SemaphoreTypeCreateInfo>();
                    semaphoreTypeCreateInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkSemaphoreCreateInfoNextPointer;
                    vkSemaphoreCreateInfoNextPointer = extensionPointer;
                }
                marshalledCreateInfo = (Interop.SemaphoreCreateInfo*)HeapUtil.Allocate<Interop.SemaphoreCreateInfo>();
                marshalledCreateInfo->SType = StructureType.SemaphoreCreateInfo;
                marshalledCreateInfo->Next = vkSemaphoreCreateInfoNextPointer;
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
                var commandDelegate = CommandCache.Cache.VkCreateSemaphore;
                var methodResult = commandDelegate(Handle, marshalledCreateInfo, marshalledAllocator, &marshalledSemaphore);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                result = new(this, marshalledSemaphore);
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Create a new event object.
        /// </summary>
        /// <param name="flags">
        ///     Reserved for future use.
        /// </param>
        /// <param name="allocator">
        ///     An optional AllocationCallbacks instance that controls host memory
        ///     allocation.
        /// </param>
        public unsafe Event CreateEvent(EventCreateFlags? flags = default, AllocationCallbacks? allocator = default)
        {
            try
            {
                var result = default(Event);
                var marshalledCreateInfo = default(Interop.EventCreateInfo*);
                var vkEventCreateInfoNextPointer = default(void*);
                var marshalledAllocator = default(Interop.AllocationCallbacks*);
                var marshalledEvent = default(Interop.Event);
                marshalledCreateInfo = (Interop.EventCreateInfo*)HeapUtil.Allocate<Interop.EventCreateInfo>();
                marshalledCreateInfo->SType = StructureType.EventCreateInfo;
                marshalledCreateInfo->Next = vkEventCreateInfoNextPointer;
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
                var commandDelegate = CommandCache.Cache.VkCreateEvent;
                var methodResult = commandDelegate(Handle, marshalledCreateInfo, marshalledAllocator, &marshalledEvent);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                result = new(this, marshalledEvent);
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Create a new query pool object.
        /// </summary>
        /// <param name="flags">
        ///     Reserved for future use.
        /// </param>
        /// <param name="queryType">
        ///     The type of queries managed by the pool.
        /// </param>
        /// <param name="queryCount">
        /// </param>
        /// <param name="pipelineStatistics">
        /// </param>
        /// <param name="queryPoolPerformanceCreateInfoKhr">
        ///     Extension struct
        /// </param>
        /// <param name="allocator">
        ///     An optional AllocationCallbacks instance that controls host memory
        ///     allocation.
        /// </param>
        public unsafe QueryPool CreateQueryPool(QueryType queryType, uint queryCount, QueryPoolCreateFlags? flags = default, QueryPipelineStatisticFlags? pipelineStatistics = default, QueryPoolPerformanceCreateInfo? queryPoolPerformanceCreateInfoKhr = null, AllocationCallbacks? allocator = default)
        {
            try
            {
                var result = default(QueryPool);
                var marshalledCreateInfo = default(Interop.QueryPoolCreateInfo*);
                var vkQueryPoolCreateInfoNextPointer = default(void*);
                var marshalledAllocator = default(Interop.AllocationCallbacks*);
                var marshalledQueryPool = default(Interop.QueryPool);
                if (queryPoolPerformanceCreateInfoKhr != null)
                {
                    var extensionPointer = default(Interop.Khronos.QueryPoolPerformanceCreateInfo*);
                    extensionPointer = (Interop.Khronos.QueryPoolPerformanceCreateInfo*)HeapUtil.Allocate<Interop.Khronos.QueryPoolPerformanceCreateInfo>();
                    queryPoolPerformanceCreateInfoKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkQueryPoolCreateInfoNextPointer;
                    vkQueryPoolCreateInfoNextPointer = extensionPointer;
                }
                marshalledCreateInfo = (Interop.QueryPoolCreateInfo*)HeapUtil.Allocate<Interop.QueryPoolCreateInfo>();
                marshalledCreateInfo->SType = StructureType.QueryPoolCreateInfo;
                marshalledCreateInfo->Next = vkQueryPoolCreateInfoNextPointer;
                if (flags != null)
                    marshalledCreateInfo->Flags = flags.Value;
                else
                    marshalledCreateInfo->Flags = default;
                marshalledCreateInfo->QueryType = queryType;
                marshalledCreateInfo->QueryCount = queryCount;
                if (pipelineStatistics != null)
                    marshalledCreateInfo->PipelineStatistics = pipelineStatistics.Value;
                else
                    marshalledCreateInfo->PipelineStatistics = default;
                if (allocator != null)
                {
                    marshalledAllocator = (Interop.AllocationCallbacks*)HeapUtil.Allocate<Interop.AllocationCallbacks>();
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default;
                }
                var commandDelegate = CommandCache.Cache.VkCreateQueryPool;
                var methodResult = commandDelegate(Handle, marshalledCreateInfo, marshalledAllocator, &marshalledQueryPool);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                result = new(this, marshalledQueryPool);
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Create a new buffer object.
        /// </summary>
        /// <param name="flags">
        ///     A bitmask describing additional parameters of the buffer.
        /// </param>
        /// <param name="size">
        ///     The size in bytes of the buffer to be created.
        /// </param>
        /// <param name="usage">
        ///     A bitmask describing the allowed usages of the buffer.
        /// </param>
        /// <param name="sharingMode">
        ///     The sharing mode of the buffer when it will be accessed by multiple
        ///     queue families.
        /// </param>
        /// <param name="queueFamilyIndices">
        /// </param>
        /// <param name="dedicatedAllocationBufferCreateInfoNv">
        ///     Extension struct
        /// </param>
        /// <param name="externalMemoryBufferCreateInfo">
        ///     Extension struct
        /// </param>
        /// <param name="bufferOpaqueCaptureAddressCreateInfo">
        ///     Extension struct
        /// </param>
        /// <param name="bufferDeviceAddressCreateInfoExt">
        ///     Extension struct
        /// </param>
        /// <param name="allocator">
        ///     An optional AllocationCallbacks instance that controls host memory
        ///     allocation.
        /// </param>
        public unsafe Buffer CreateBuffer(ulong size, BufferUsageFlags usage, SharingMode sharingMode, ArrayProxy<uint>? queueFamilyIndices, BufferCreateFlags? flags = default, DedicatedAllocationBufferCreateInfo? dedicatedAllocationBufferCreateInfoNv = null, ExternalMemoryBufferCreateInfo? externalMemoryBufferCreateInfo = null, BufferOpaqueCaptureAddressCreateInfo? bufferOpaqueCaptureAddressCreateInfo = null, BufferDeviceAddressCreateInfo? bufferDeviceAddressCreateInfoExt = null,
            AllocationCallbacks? allocator = default)
        {
            try
            {
                var result = default(Buffer);
                var marshalledCreateInfo = default(Interop.BufferCreateInfo*);
                var vkBufferCreateInfoNextPointer = default(void*);
                var marshalledAllocator = default(Interop.AllocationCallbacks*);
                var marshalledBuffer = default(Interop.Buffer);
                if (dedicatedAllocationBufferCreateInfoNv != null)
                {
                    var extensionPointer = default(Interop.NVidia.DedicatedAllocationBufferCreateInfo*);
                    extensionPointer = (Interop.NVidia.DedicatedAllocationBufferCreateInfo*)HeapUtil.Allocate<Interop.NVidia.DedicatedAllocationBufferCreateInfo>();
                    dedicatedAllocationBufferCreateInfoNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkBufferCreateInfoNextPointer;
                    vkBufferCreateInfoNextPointer = extensionPointer;
                }
                if (externalMemoryBufferCreateInfo != null)
                {
                    var extensionPointer = default(Interop.ExternalMemoryBufferCreateInfo*);
                    extensionPointer = (Interop.ExternalMemoryBufferCreateInfo*)HeapUtil.Allocate<Interop.ExternalMemoryBufferCreateInfo>();
                    externalMemoryBufferCreateInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkBufferCreateInfoNextPointer;
                    vkBufferCreateInfoNextPointer = extensionPointer;
                }
                if (bufferOpaqueCaptureAddressCreateInfo != null)
                {
                    var extensionPointer = default(Interop.BufferOpaqueCaptureAddressCreateInfo*);
                    extensionPointer = (Interop.BufferOpaqueCaptureAddressCreateInfo*)HeapUtil.Allocate<Interop.BufferOpaqueCaptureAddressCreateInfo>();
                    bufferOpaqueCaptureAddressCreateInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkBufferCreateInfoNextPointer;
                    vkBufferCreateInfoNextPointer = extensionPointer;
                }
                if (bufferDeviceAddressCreateInfoExt != null)
                {
                    var extensionPointer = default(Interop.Multivendor.BufferDeviceAddressCreateInfo*);
                    extensionPointer = (Interop.Multivendor.BufferDeviceAddressCreateInfo*)HeapUtil.Allocate<Interop.Multivendor.BufferDeviceAddressCreateInfo>();
                    bufferDeviceAddressCreateInfoExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkBufferCreateInfoNextPointer;
                    vkBufferCreateInfoNextPointer = extensionPointer;
                }
                marshalledCreateInfo = (Interop.BufferCreateInfo*)HeapUtil.Allocate<Interop.BufferCreateInfo>();
                marshalledCreateInfo->SType = StructureType.BufferCreateInfo;
                marshalledCreateInfo->Next = vkBufferCreateInfoNextPointer;
                if (flags != null)
                    marshalledCreateInfo->Flags = flags.Value;
                else
                    marshalledCreateInfo->Flags = default;
                marshalledCreateInfo->Size = size;
                marshalledCreateInfo->Usage = usage;
                marshalledCreateInfo->SharingMode = sharingMode;
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
                if (allocator != null)
                {
                    marshalledAllocator = (Interop.AllocationCallbacks*)HeapUtil.Allocate<Interop.AllocationCallbacks>();
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default;
                }
                var commandDelegate = CommandCache.Cache.VkCreateBuffer;
                var methodResult = commandDelegate(Handle, marshalledCreateInfo, marshalledAllocator, &marshalledBuffer);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                result = new(this, marshalledBuffer);
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Create a new buffer view object.
        /// </summary>
        /// <param name="flags">
        ///     Reserved for future use.
        /// </param>
        /// <param name="buffer">
        ///     A Buffer on which the view will be created.
        /// </param>
        /// <param name="format">
        ///     A Format describing the format of the data elements in the buffer.
        /// </param>
        /// <param name="offset">
        ///     An offset in bytes from the base address of the buffer. Accesses to
        ///     the buffer view from shaders use addressing that is relative to
        ///     this starting offset.
        /// </param>
        /// <param name="range">
        ///     A size in bytes of the buffer view. If range is equal to
        ///     Constants.WholeSize, the range from offset to the end of the buffer
        ///     is used. If Constants.WholeSize is used and the remaining size of
        ///     the buffer is not a multiple of the element size of format, then
        ///     the nearest smaller multiple is used.
        /// </param>
        /// <param name="allocator">
        ///     An optional AllocationCallbacks instance that controls host memory
        ///     allocation.
        /// </param>
        public unsafe BufferView CreateBufferView(Buffer buffer, Format format, ulong offset, ulong range, BufferViewCreateFlags? flags = default, AllocationCallbacks? allocator = default)
        {
            try
            {
                var result = default(BufferView);
                var marshalledCreateInfo = default(Interop.BufferViewCreateInfo*);
                var vkBufferViewCreateInfoNextPointer = default(void*);
                var marshalledAllocator = default(Interop.AllocationCallbacks*);
                var marshalledView = default(Interop.BufferView);
                marshalledCreateInfo = (Interop.BufferViewCreateInfo*)HeapUtil.Allocate<Interop.BufferViewCreateInfo>();
                marshalledCreateInfo->SType = StructureType.BufferViewCreateInfo;
                marshalledCreateInfo->Next = vkBufferViewCreateInfoNextPointer;
                if (flags != null)
                    marshalledCreateInfo->Flags = flags.Value;
                else
                    marshalledCreateInfo->Flags = default;
                marshalledCreateInfo->Buffer = buffer?.Handle ?? default(Interop.Buffer);
                marshalledCreateInfo->Format = format;
                marshalledCreateInfo->Offset = offset;
                marshalledCreateInfo->Range = range;
                if (allocator != null)
                {
                    marshalledAllocator = (Interop.AllocationCallbacks*)HeapUtil.Allocate<Interop.AllocationCallbacks>();
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default;
                }
                var commandDelegate = CommandCache.Cache.VkCreateBufferView;
                var methodResult = commandDelegate(Handle, marshalledCreateInfo, marshalledAllocator, &marshalledView);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                result = new(this, marshalledView);
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Create a new image object.
        /// </summary>
        /// <param name="flags">
        ///     A bitmask describing additional parameters of the image. See
        ///     ImageCreateFlagBits below for a description of the supported bits.
        /// </param>
        /// <param name="imageType">
        ///     An ImageType specifying the basic dimensionality of the image, as
        ///     described below. Layers in array textures do not count as a
        ///     dimension for the purposes of the image type.
        /// </param>
        /// <param name="format">
        ///     A Format describing the format and type of the data elements that
        ///     will be contained in the image.
        /// </param>
        /// <param name="extent">
        ///     A Extent3D describing the number of data elements in each dimension
        ///     of the base level.
        /// </param>
        /// <param name="mipLevels">
        ///     mipLevels describes the number of levels of detail available for
        ///     minified sampling of the image.
        /// </param>
        /// <param name="arrayLayers">
        ///     The number of layers in the image.
        /// </param>
        /// <param name="samples">
        ///     The number of sub-data element samples in the image as defined in
        ///     SampleCountFlagBits. See Multisampling.
        /// </param>
        /// <param name="tiling">
        ///     An ImageTiling specifying the tiling arrangement of the data
        ///     elements in memory, as described below.
        /// </param>
        /// <param name="usage">
        ///     A bitmask describing the intended usage of the image. See
        ///     ImageUsageFlagBits below for a description of the supported bits.
        /// </param>
        /// <param name="sharingMode">
        ///     The sharing mode of the image when it will be accessed by multiple
        ///     queue families, and must be one of the values described for
        ///     SharingMode in the Resource Sharing section below.
        /// </param>
        /// <param name="queueFamilyIndices">
        /// </param>
        /// <param name="initialLayout">
        ///     initialLayout selects the initial ImageLayout state of all image
        ///     subresources of the image. See Image Layouts. initialLayout must be
        ///     VK_IMAGE_LAYOUT_UNDEFINED or VK_IMAGE_LAYOUT_PREINITIALIZED.
        /// </param>
        /// <param name="dedicatedAllocationImageCreateInfoNv">
        ///     Extension struct
        /// </param>
        /// <param name="externalMemoryImageCreateInfoNv">
        ///     Extension struct
        /// </param>
        /// <param name="externalMemoryImageCreateInfo">
        ///     Extension struct
        /// </param>
        /// <param name="imageSwapchainCreateInfoKhr">
        ///     Extension struct
        /// </param>
        /// <param name="imageFormatListCreateInfo">
        ///     Extension struct
        /// </param>
        /// <param name="externalFormatAndroid">
        ///     Extension struct
        /// </param>
        /// <param name="imageDrmFormatModifierListCreateInfoExt">
        ///     Extension struct
        /// </param>
        /// <param name="imageDrmFormatModifierExplicitCreateInfoExt">
        ///     Extension struct
        /// </param>
        /// <param name="imageStencilUsageCreateInfo">
        ///     Extension struct
        /// </param>
        /// <param name="allocator">
        ///     An optional AllocationCallbacks instance that controls host memory
        ///     allocation.
        /// </param>
        public unsafe Image CreateImage(ImageType imageType, Format format, Extent3D extent, uint mipLevels, uint arrayLayers, SampleCountFlags samples, ImageTiling tiling, ImageUsageFlags usage, SharingMode sharingMode, ArrayProxy<uint>? queueFamilyIndices, ImageLayout initialLayout, ImageCreateFlags? flags = default, DedicatedAllocationImageCreateInfo? dedicatedAllocationImageCreateInfoNv = null, NVidia.ExternalMemoryImageCreateInfo? externalMemoryImageCreateInfoNv = null,
            ExternalMemoryImageCreateInfo? externalMemoryImageCreateInfo = null, ImageSwapchainCreateInfo? imageSwapchainCreateInfoKhr = null, ImageFormatListCreateInfo? imageFormatListCreateInfo = null, ExternalFormat? externalFormatAndroid = null, ImageDrmFormatModifierListCreateInfo? imageDrmFormatModifierListCreateInfoExt = null, ImageDrmFormatModifierExplicitCreateInfo? imageDrmFormatModifierExplicitCreateInfoExt = null, ImageStencilUsageCreateInfo? imageStencilUsageCreateInfo = null,
            AllocationCallbacks? allocator = default)
        {
            try
            {
                var result = default(Image);
                var marshalledCreateInfo = default(Interop.ImageCreateInfo*);
                var vkImageCreateInfoNextPointer = default(void*);
                var marshalledAllocator = default(Interop.AllocationCallbacks*);
                var marshalledImage = default(Interop.Image);
                if (dedicatedAllocationImageCreateInfoNv != null)
                {
                    var extensionPointer = default(Interop.NVidia.DedicatedAllocationImageCreateInfo*);
                    extensionPointer = (Interop.NVidia.DedicatedAllocationImageCreateInfo*)HeapUtil.Allocate<Interop.NVidia.DedicatedAllocationImageCreateInfo>();
                    dedicatedAllocationImageCreateInfoNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkImageCreateInfoNextPointer;
                    vkImageCreateInfoNextPointer = extensionPointer;
                }
                if (externalMemoryImageCreateInfoNv != null)
                {
                    var extensionPointer = default(Interop.NVidia.ExternalMemoryImageCreateInfo*);
                    extensionPointer = (Interop.NVidia.ExternalMemoryImageCreateInfo*)HeapUtil.Allocate<Interop.NVidia.ExternalMemoryImageCreateInfo>();
                    externalMemoryImageCreateInfoNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkImageCreateInfoNextPointer;
                    vkImageCreateInfoNextPointer = extensionPointer;
                }
                if (externalMemoryImageCreateInfo != null)
                {
                    var extensionPointer = default(Interop.ExternalMemoryImageCreateInfo*);
                    extensionPointer = (Interop.ExternalMemoryImageCreateInfo*)HeapUtil.Allocate<Interop.ExternalMemoryImageCreateInfo>();
                    externalMemoryImageCreateInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkImageCreateInfoNextPointer;
                    vkImageCreateInfoNextPointer = extensionPointer;
                }
                if (imageSwapchainCreateInfoKhr != null)
                {
                    var extensionPointer = default(Interop.Khronos.ImageSwapchainCreateInfo*);
                    extensionPointer = (Interop.Khronos.ImageSwapchainCreateInfo*)HeapUtil.Allocate<Interop.Khronos.ImageSwapchainCreateInfo>();
                    imageSwapchainCreateInfoKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkImageCreateInfoNextPointer;
                    vkImageCreateInfoNextPointer = extensionPointer;
                }
                if (imageFormatListCreateInfo != null)
                {
                    var extensionPointer = default(Interop.ImageFormatListCreateInfo*);
                    extensionPointer = (Interop.ImageFormatListCreateInfo*)HeapUtil.Allocate<Interop.ImageFormatListCreateInfo>();
                    imageFormatListCreateInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkImageCreateInfoNextPointer;
                    vkImageCreateInfoNextPointer = extensionPointer;
                }
                if (externalFormatAndroid != null)
                {
                    var extensionPointer = default(Interop.Android.ExternalFormat*);
                    extensionPointer = (Interop.Android.ExternalFormat*)HeapUtil.Allocate<Interop.Android.ExternalFormat>();
                    externalFormatAndroid.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkImageCreateInfoNextPointer;
                    vkImageCreateInfoNextPointer = extensionPointer;
                }
                if (imageDrmFormatModifierListCreateInfoExt != null)
                {
                    var extensionPointer = default(Interop.Multivendor.ImageDrmFormatModifierListCreateInfo*);
                    extensionPointer = (Interop.Multivendor.ImageDrmFormatModifierListCreateInfo*)HeapUtil.Allocate<Interop.Multivendor.ImageDrmFormatModifierListCreateInfo>();
                    imageDrmFormatModifierListCreateInfoExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkImageCreateInfoNextPointer;
                    vkImageCreateInfoNextPointer = extensionPointer;
                }
                if (imageDrmFormatModifierExplicitCreateInfoExt != null)
                {
                    var extensionPointer = default(Interop.Multivendor.ImageDrmFormatModifierExplicitCreateInfo*);
                    extensionPointer = (Interop.Multivendor.ImageDrmFormatModifierExplicitCreateInfo*)HeapUtil.Allocate<Interop.Multivendor.ImageDrmFormatModifierExplicitCreateInfo>();
                    imageDrmFormatModifierExplicitCreateInfoExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkImageCreateInfoNextPointer;
                    vkImageCreateInfoNextPointer = extensionPointer;
                }
                if (imageStencilUsageCreateInfo != null)
                {
                    var extensionPointer = default(Interop.ImageStencilUsageCreateInfo*);
                    extensionPointer = (Interop.ImageStencilUsageCreateInfo*)HeapUtil.Allocate<Interop.ImageStencilUsageCreateInfo>();
                    imageStencilUsageCreateInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkImageCreateInfoNextPointer;
                    vkImageCreateInfoNextPointer = extensionPointer;
                }
                marshalledCreateInfo = (Interop.ImageCreateInfo*)HeapUtil.Allocate<Interop.ImageCreateInfo>();
                marshalledCreateInfo->SType = StructureType.ImageCreateInfo;
                marshalledCreateInfo->Next = vkImageCreateInfoNextPointer;
                if (flags != null)
                    marshalledCreateInfo->Flags = flags.Value;
                else
                    marshalledCreateInfo->Flags = default;
                marshalledCreateInfo->ImageType = imageType;
                marshalledCreateInfo->Format = format;
                marshalledCreateInfo->Extent = extent;
                marshalledCreateInfo->MipLevels = mipLevels;
                marshalledCreateInfo->ArrayLayers = arrayLayers;
                marshalledCreateInfo->Samples = samples;
                marshalledCreateInfo->Tiling = tiling;
                marshalledCreateInfo->Usage = usage;
                marshalledCreateInfo->SharingMode = sharingMode;
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
                marshalledCreateInfo->InitialLayout = initialLayout;
                if (allocator != null)
                {
                    marshalledAllocator = (Interop.AllocationCallbacks*)HeapUtil.Allocate<Interop.AllocationCallbacks>();
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default;
                }
                var commandDelegate = CommandCache.Cache.VkCreateImage;
                var methodResult = commandDelegate(Handle, marshalledCreateInfo, marshalledAllocator, &marshalledImage);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                result = new(this, marshalledImage);
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Create an image view from an existing image.
        /// </summary>
        /// <param name="flags">
        ///     Reserved for future use.
        /// </param>
        /// <param name="image">
        ///     An Image on which the view will be created.
        /// </param>
        /// <param name="viewType">
        ///     The type of the image view.
        /// </param>
        /// <param name="format">
        ///     A Format describing the format and type used to interpret data
        ///     elements in the image.
        /// </param>
        /// <param name="components">
        ///     Specifies a remapping of color components (or of depth or stencil
        ///     components after they have been converted into color components).
        /// </param>
        /// <param name="subresourceRange">
        ///     An ImageSubresourceRange selecting the set of mipmap levels and
        ///     array layers to be accessible to the view.
        /// </param>
        /// <param name="imageViewUsageCreateInfo">
        ///     Extension struct
        /// </param>
        /// <param name="samplerYcbcrConversionInfo">
        ///     Extension struct
        /// </param>
        /// <param name="imageViewAstcDecodeModeExt">
        ///     Extension struct
        /// </param>
        /// <param name="allocator">
        ///     An optional AllocationCallbacks instance that controls host memory
        ///     allocation.
        /// </param>
        public unsafe ImageView CreateImageView(Image image, ImageViewType viewType, Format format, ComponentMapping components, ImageSubresourceRange subresourceRange, ImageViewCreateFlags? flags = default, ImageViewUsageCreateInfo? imageViewUsageCreateInfo = null, SamplerYcbcrConversionInfo? samplerYcbcrConversionInfo = null, ImageViewAstcDecodeMode? imageViewAstcDecodeModeExt = null, AllocationCallbacks? allocator = default)
        {
            try
            {
                var result = default(ImageView);
                var marshalledCreateInfo = default(Interop.ImageViewCreateInfo*);
                var vkImageViewCreateInfoNextPointer = default(void*);
                var marshalledAllocator = default(Interop.AllocationCallbacks*);
                var marshalledView = default(Interop.ImageView);
                if (imageViewUsageCreateInfo != null)
                {
                    var extensionPointer = default(Interop.ImageViewUsageCreateInfo*);
                    extensionPointer = (Interop.ImageViewUsageCreateInfo*)HeapUtil.Allocate<Interop.ImageViewUsageCreateInfo>();
                    imageViewUsageCreateInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkImageViewCreateInfoNextPointer;
                    vkImageViewCreateInfoNextPointer = extensionPointer;
                }
                if (samplerYcbcrConversionInfo != null)
                {
                    var extensionPointer = default(Interop.SamplerYcbcrConversionInfo*);
                    extensionPointer = (Interop.SamplerYcbcrConversionInfo*)HeapUtil.Allocate<Interop.SamplerYcbcrConversionInfo>();
                    samplerYcbcrConversionInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkImageViewCreateInfoNextPointer;
                    vkImageViewCreateInfoNextPointer = extensionPointer;
                }
                if (imageViewAstcDecodeModeExt != null)
                {
                    var extensionPointer = default(Interop.Multivendor.ImageViewAstcDecodeMode*);
                    extensionPointer = (Interop.Multivendor.ImageViewAstcDecodeMode*)HeapUtil.Allocate<Interop.Multivendor.ImageViewAstcDecodeMode>();
                    imageViewAstcDecodeModeExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkImageViewCreateInfoNextPointer;
                    vkImageViewCreateInfoNextPointer = extensionPointer;
                }
                marshalledCreateInfo = (Interop.ImageViewCreateInfo*)HeapUtil.Allocate<Interop.ImageViewCreateInfo>();
                marshalledCreateInfo->SType = StructureType.ImageViewCreateInfo;
                marshalledCreateInfo->Next = vkImageViewCreateInfoNextPointer;
                if (flags != null)
                    marshalledCreateInfo->Flags = flags.Value;
                else
                    marshalledCreateInfo->Flags = default;
                marshalledCreateInfo->Image = image?.Handle ?? default(Interop.Image);
                marshalledCreateInfo->ViewType = viewType;
                marshalledCreateInfo->Format = format;
                marshalledCreateInfo->Components = components;
                marshalledCreateInfo->SubresourceRange = subresourceRange;
                if (allocator != null)
                {
                    marshalledAllocator = (Interop.AllocationCallbacks*)HeapUtil.Allocate<Interop.AllocationCallbacks>();
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default;
                }
                var commandDelegate = CommandCache.Cache.VkCreateImageView;
                var methodResult = commandDelegate(Handle, marshalledCreateInfo, marshalledAllocator, &marshalledView);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                result = new(this, marshalledView);
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Creates a new shader module object.
        /// </summary>
        /// <param name="flags">
        ///     Reserved for future use.
        /// </param>
        /// <param name="codeSize">
        ///     The size, in bytes, of the code.
        /// </param>
        /// <param name="code">
        /// </param>
        /// <param name="shaderModuleValidationCacheCreateInfoExt">
        ///     Extension struct
        /// </param>
        /// <param name="allocator">
        ///     An optional AllocationCallbacks instance that controls host memory
        ///     allocation.
        /// </param>
        public unsafe ShaderModule CreateShaderModule(HostSize codeSize, ArrayProxy<uint>? code, ShaderModuleCreateFlags? flags = default, ShaderModuleValidationCacheCreateInfo? shaderModuleValidationCacheCreateInfoExt = null, AllocationCallbacks? allocator = default)
        {
            try
            {
                var result = default(ShaderModule);
                var marshalledCreateInfo = default(Interop.ShaderModuleCreateInfo*);
                var vkShaderModuleCreateInfoNextPointer = default(void*);
                var marshalledAllocator = default(Interop.AllocationCallbacks*);
                var marshalledShaderModule = default(Interop.ShaderModule);
                if (shaderModuleValidationCacheCreateInfoExt != null)
                {
                    var extensionPointer = default(Interop.Multivendor.ShaderModuleValidationCacheCreateInfo*);
                    extensionPointer = (Interop.Multivendor.ShaderModuleValidationCacheCreateInfo*)HeapUtil.Allocate<Interop.Multivendor.ShaderModuleValidationCacheCreateInfo>();
                    shaderModuleValidationCacheCreateInfoExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkShaderModuleCreateInfoNextPointer;
                    vkShaderModuleCreateInfoNextPointer = extensionPointer;
                }
                marshalledCreateInfo = (Interop.ShaderModuleCreateInfo*)HeapUtil.Allocate<Interop.ShaderModuleCreateInfo>();
                marshalledCreateInfo->SType = StructureType.ShaderModuleCreateInfo;
                marshalledCreateInfo->Next = vkShaderModuleCreateInfoNextPointer;
                if (flags != null)
                    marshalledCreateInfo->Flags = flags.Value;
                else
                    marshalledCreateInfo->Flags = default;
                marshalledCreateInfo->CodeSize = codeSize;
                if (code.IsNull())
                {
                    marshalledCreateInfo->Code = null;
                }
                else
                {
                    if (code.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfo->Code = (uint*)HeapUtil.Allocate<uint>();
                        *marshalledCreateInfo->Code = code.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (uint*)HeapUtil.AllocateAndClear<uint>(HeapUtil.GetLength(code.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(code.Value); index++) fieldPointer[index] = code.Value[index];
                        marshalledCreateInfo->Code = fieldPointer;
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
                var commandDelegate = CommandCache.Cache.VkCreateShaderModule;
                var methodResult = commandDelegate(Handle, marshalledCreateInfo, marshalledAllocator, &marshalledShaderModule);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                result = new(this, marshalledShaderModule);
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Creates a new pipeline cache.
        /// </summary>
        /// <param name="flags">
        ///     Reserved for future use.
        /// </param>
        /// <param name="initialData">
        /// </param>
        /// <param name="allocator">
        ///     An optional AllocationCallbacks instance that controls host memory
        ///     allocation.
        /// </param>
        public unsafe PipelineCache CreatePipelineCache(ArrayProxy<byte>? initialData, PipelineCacheCreateFlags? flags = default, AllocationCallbacks? allocator = default)
        {
            try
            {
                var result = default(PipelineCache);
                var marshalledCreateInfo = default(Interop.PipelineCacheCreateInfo*);
                var vkPipelineCacheCreateInfoNextPointer = default(void*);
                var marshalledAllocator = default(Interop.AllocationCallbacks*);
                var marshalledPipelineCache = default(Interop.PipelineCache);
                marshalledCreateInfo = (Interop.PipelineCacheCreateInfo*)HeapUtil.Allocate<Interop.PipelineCacheCreateInfo>();
                marshalledCreateInfo->SType = StructureType.PipelineCacheCreateInfo;
                marshalledCreateInfo->Next = vkPipelineCacheCreateInfoNextPointer;
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
                var commandDelegate = CommandCache.Cache.VkCreatePipelineCache;
                var methodResult = commandDelegate(Handle, marshalledCreateInfo, marshalledAllocator, &marshalledPipelineCache);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                result = new(this, marshalledPipelineCache);
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Create graphics pipelines.
        /// </summary>
        /// <param name="pipelineCache">
        /// </param>
        /// <param name="createInfos">
        /// </param>
        /// <param name="allocator">
        ///     An optional AllocationCallbacks instance that controls host memory
        ///     allocation.
        /// </param>
        public unsafe Pipeline[] CreateGraphicsPipelines(PipelineCache pipelineCache, ArrayProxy<GraphicsPipelineCreateInfo>? createInfos, AllocationCallbacks? allocator = default)
        {
            try
            {
                var result = default(Pipeline[]);
                var marshalledCreateInfoCount = default(uint);
                var marshalledCreateInfos = default(Interop.GraphicsPipelineCreateInfo*);
                var marshalledAllocator = default(Interop.AllocationCallbacks*);
                var marshalledPipelines = default(Interop.Pipeline*);
                marshalledCreateInfoCount = HeapUtil.GetLength(createInfos);
                if (createInfos.IsNull())
                {
                    marshalledCreateInfos = null;
                }
                else
                {
                    if (createInfos.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfos = (Interop.GraphicsPipelineCreateInfo*)HeapUtil.Allocate<Interop.GraphicsPipelineCreateInfo>();
                        createInfos.Value.GetSingleValue().MarshalTo(&*marshalledCreateInfos);
                    }
                    else
                    {
                        var fieldPointer = (Interop.GraphicsPipelineCreateInfo*)HeapUtil.AllocateAndClear<Interop.GraphicsPipelineCreateInfo>(HeapUtil.GetLength(createInfos.Value)).ToPointer();
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
                marshalledPipelines = (Interop.Pipeline*)HeapUtil.Allocate<Interop.Pipeline>(marshalledCreateInfoCount);
                var commandDelegate = CommandCache.Cache.VkCreateGraphicsPipelines;
                var methodResult = commandDelegate(Handle, pipelineCache?.Handle ?? default(Interop.PipelineCache), marshalledCreateInfoCount, marshalledCreateInfos, marshalledAllocator, marshalledPipelines);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                if (marshalledPipelines != null)
                {
                    var fieldPointer = new Pipeline[marshalledCreateInfoCount];
                    for (var index = 0; index < marshalledCreateInfoCount; index++) fieldPointer[index] = new(this, marshalledPipelines[index]);
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
        ///     Create graphics pipelines.
        /// </summary>
        /// <param name="pipelineCache">
        /// </param>
        /// <param name="flags">
        ///     A bitmask of PipelineCreateFlagBits controlling how the pipeline
        ///     will be generated, as described below.
        /// </param>
        /// <param name="stages">
        /// </param>
        /// <param name="vertexInputState">
        ///     An instance of the PipelineVertexInputStateCreateInfo structure.
        /// </param>
        /// <param name="inputAssemblyState">
        ///     An instance of the PipelineInputAssemblyStateCreateInfo structure
        ///     which determines input assembly behavior.
        /// </param>
        /// <param name="tessellationState">
        ///     An instance of the PipelineTessellationStateCreateInfo structure,
        ///     or Null if the pipeline does not include a tessellation control
        ///     shader stage and tessellation evaluation shader stage.
        /// </param>
        /// <param name="viewportState">
        ///     An instance of the PipelineViewportStateCreateInfo structure, or
        ///     Null if the pipeline has rasterization disabled.
        /// </param>
        /// <param name="rasterizationState">
        ///     An instance of the PipelineRasterizationStateCreateInfo structure.
        /// </param>
        /// <param name="multisampleState">
        ///     An instance of the PipelineMultisampleStateCreateInfo, or Null if
        ///     the pipeline has rasterization disabled.
        /// </param>
        /// <param name="depthStencilState">
        ///     An instance of the PipelineDepthStencilStateCreateInfo structure,
        ///     or Null if the pipeline has rasterization disabled or if the
        ///     subpass of the render pass the pipeline is created against does not
        ///     use a depth/stencil attachment.
        /// </param>
        /// <param name="colorBlendState">
        ///     An instance of the PipelineColorBlendStateCreateInfo structure, or
        ///     Null if the pipeline has rasterization disabled or if the subpass
        ///     of the render pass the pipeline is created against does not use any
        ///     color attachments.
        /// </param>
        /// <param name="dynamicState">
        ///     A pointer to PipelineDynamicStateCreateInfo and is used to indicate
        ///     which properties of the pipeline state object are dynamic and can
        ///     be changed independently of the pipeline state. This can be Null,
        ///     which means no state in the pipeline is considered dynamic.
        /// </param>
        /// <param name="layout">
        ///     The description of binding locations used by both the pipeline and
        ///     descriptor sets used with the pipeline.
        /// </param>
        /// <param name="renderPass">
        ///     A handle to a render pass object describing the environment in
        ///     which the pipeline will be used; the pipeline must only be used
        ///     with an instance of any render pass compatible with the one
        ///     provided.
        /// </param>
        /// <param name="subpass">
        ///     The index of the subpass in the render pass where this pipeline
        ///     will be used.
        /// </param>
        /// <param name="basePipelineHandle">
        ///     A pipeline to derive from.
        /// </param>
        /// <param name="basePipelineIndex">
        ///     An index into the pCreateInfos parameter to use as a pipeline to
        ///     derive from.
        /// </param>
        /// <param name="pipelineDiscardRectangleStateCreateInfoExt">
        ///     Extension struct
        /// </param>
        /// <param name="pipelineRepresentativeFragmentTestStateCreateInfoNv">
        ///     Extension struct
        /// </param>
        /// <param name="pipelineCreationFeedbackCreateInfoExt">
        ///     Extension struct
        /// </param>
        /// <param name="pipelineCompilerControlCreateInfoAmd">
        ///     Extension struct
        /// </param>
        /// <param name="allocator">
        ///     An optional AllocationCallbacks instance that controls host memory
        ///     allocation.
        /// </param>
        public unsafe Pipeline CreateGraphicsPipeline(PipelineCache pipelineCache, ArrayProxy<PipelineShaderStageCreateInfo>? stages, PipelineRasterizationStateCreateInfo rasterizationState, PipelineLayout layout, RenderPass renderPass, uint subpass, Pipeline basePipelineHandle, int basePipelineIndex, PipelineCreateFlags? flags = default, PipelineVertexInputStateCreateInfo? vertexInputState = default,
            PipelineInputAssemblyStateCreateInfo? inputAssemblyState = default, PipelineTessellationStateCreateInfo? tessellationState = default, PipelineViewportStateCreateInfo? viewportState = default, PipelineMultisampleStateCreateInfo? multisampleState = default, PipelineDepthStencilStateCreateInfo? depthStencilState = default,
            PipelineColorBlendStateCreateInfo? colorBlendState = default, PipelineDynamicStateCreateInfo? dynamicState = default, PipelineDiscardRectangleStateCreateInfo? pipelineDiscardRectangleStateCreateInfoExt = null, PipelineRepresentativeFragmentTestStateCreateInfo? pipelineRepresentativeFragmentTestStateCreateInfoNv = null, PipelineCreationFeedbackCreateInfo? pipelineCreationFeedbackCreateInfoExt = null,
            PipelineCompilerControlCreateInfo? pipelineCompilerControlCreateInfoAmd = null, AllocationCallbacks? allocator = default)
        {
            try
            {
                var result = default(Pipeline);
                var marshalledCreateInfoCount = default(uint);
                var marshalledCreateInfos = default(Interop.GraphicsPipelineCreateInfo*);
                var vkGraphicsPipelineCreateInfoNextPointer = default(void*);
                var marshalledAllocator = default(Interop.AllocationCallbacks*);
                var marshalledPipelines = default(Interop.Pipeline*);
                if (pipelineDiscardRectangleStateCreateInfoExt != null)
                {
                    var extensionPointer = default(Interop.Multivendor.PipelineDiscardRectangleStateCreateInfo*);
                    extensionPointer = (Interop.Multivendor.PipelineDiscardRectangleStateCreateInfo*)HeapUtil.Allocate<Interop.Multivendor.PipelineDiscardRectangleStateCreateInfo>();
                    pipelineDiscardRectangleStateCreateInfoExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkGraphicsPipelineCreateInfoNextPointer;
                    vkGraphicsPipelineCreateInfoNextPointer = extensionPointer;
                }
                if (pipelineRepresentativeFragmentTestStateCreateInfoNv != null)
                {
                    var extensionPointer = default(Interop.NVidia.PipelineRepresentativeFragmentTestStateCreateInfo*);
                    extensionPointer = (Interop.NVidia.PipelineRepresentativeFragmentTestStateCreateInfo*)HeapUtil.Allocate<Interop.NVidia.PipelineRepresentativeFragmentTestStateCreateInfo>();
                    pipelineRepresentativeFragmentTestStateCreateInfoNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkGraphicsPipelineCreateInfoNextPointer;
                    vkGraphicsPipelineCreateInfoNextPointer = extensionPointer;
                }
                if (pipelineCreationFeedbackCreateInfoExt != null)
                {
                    var extensionPointer = default(Interop.Multivendor.PipelineCreationFeedbackCreateInfo*);
                    extensionPointer = (Interop.Multivendor.PipelineCreationFeedbackCreateInfo*)HeapUtil.Allocate<Interop.Multivendor.PipelineCreationFeedbackCreateInfo>();
                    pipelineCreationFeedbackCreateInfoExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkGraphicsPipelineCreateInfoNextPointer;
                    vkGraphicsPipelineCreateInfoNextPointer = extensionPointer;
                }
                if (pipelineCompilerControlCreateInfoAmd != null)
                {
                    var extensionPointer = default(Interop.Amd.PipelineCompilerControlCreateInfo*);
                    extensionPointer = (Interop.Amd.PipelineCompilerControlCreateInfo*)HeapUtil.Allocate<Interop.Amd.PipelineCompilerControlCreateInfo>();
                    pipelineCompilerControlCreateInfoAmd.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkGraphicsPipelineCreateInfoNextPointer;
                    vkGraphicsPipelineCreateInfoNextPointer = extensionPointer;
                }
                marshalledCreateInfoCount = 1;
                marshalledCreateInfos = (Interop.GraphicsPipelineCreateInfo*)HeapUtil.Allocate<Interop.GraphicsPipelineCreateInfo>();
                marshalledCreateInfos->SType = StructureType.GraphicsPipelineCreateInfo;
                marshalledCreateInfos->Next = vkGraphicsPipelineCreateInfoNextPointer;
                if (flags != null)
                    marshalledCreateInfos->Flags = flags.Value;
                else
                    marshalledCreateInfos->Flags = default;
                marshalledCreateInfos->StageCount = HeapUtil.GetLength(stages);
                if (stages.IsNull())
                {
                    marshalledCreateInfos->Stages = null;
                }
                else
                {
                    if (stages.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfos->Stages = (Interop.PipelineShaderStageCreateInfo*)HeapUtil.Allocate<Interop.PipelineShaderStageCreateInfo>();
                        stages.Value.GetSingleValue().MarshalTo(&*marshalledCreateInfos->Stages);
                    }
                    else
                    {
                        var fieldPointer = (Interop.PipelineShaderStageCreateInfo*)HeapUtil.AllocateAndClear<Interop.PipelineShaderStageCreateInfo>(HeapUtil.GetLength(stages.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(stages.Value); index++) stages.Value[index].MarshalTo(&fieldPointer[index]);
                        marshalledCreateInfos->Stages = fieldPointer;
                    }
                }
                if (vertexInputState != null)
                {
                    marshalledCreateInfos->VertexInputState = (Interop.PipelineVertexInputStateCreateInfo*)HeapUtil.Allocate<Interop.PipelineVertexInputStateCreateInfo>();
                    vertexInputState.Value.MarshalTo(marshalledCreateInfos->VertexInputState);
                }
                else
                {
                    marshalledCreateInfos->VertexInputState = default;
                }
                if (inputAssemblyState != null)
                {
                    marshalledCreateInfos->InputAssemblyState = (Interop.PipelineInputAssemblyStateCreateInfo*)HeapUtil.Allocate<Interop.PipelineInputAssemblyStateCreateInfo>();
                    inputAssemblyState.Value.MarshalTo(marshalledCreateInfos->InputAssemblyState);
                }
                else
                {
                    marshalledCreateInfos->InputAssemblyState = default;
                }
                if (tessellationState != null)
                {
                    marshalledCreateInfos->TessellationState = (Interop.PipelineTessellationStateCreateInfo*)HeapUtil.Allocate<Interop.PipelineTessellationStateCreateInfo>();
                    tessellationState.Value.MarshalTo(marshalledCreateInfos->TessellationState);
                }
                else
                {
                    marshalledCreateInfos->TessellationState = default;
                }
                if (viewportState != null)
                {
                    marshalledCreateInfos->ViewportState = (Interop.PipelineViewportStateCreateInfo*)HeapUtil.Allocate<Interop.PipelineViewportStateCreateInfo>();
                    viewportState.Value.MarshalTo(marshalledCreateInfos->ViewportState);
                }
                else
                {
                    marshalledCreateInfos->ViewportState = default;
                }
                marshalledCreateInfos->RasterizationState = (Interop.PipelineRasterizationStateCreateInfo*)HeapUtil.Allocate<Interop.PipelineRasterizationStateCreateInfo>();
                rasterizationState.MarshalTo(marshalledCreateInfos->RasterizationState);
                if (multisampleState != null)
                {
                    marshalledCreateInfos->MultisampleState = (Interop.PipelineMultisampleStateCreateInfo*)HeapUtil.Allocate<Interop.PipelineMultisampleStateCreateInfo>();
                    multisampleState.Value.MarshalTo(marshalledCreateInfos->MultisampleState);
                }
                else
                {
                    marshalledCreateInfos->MultisampleState = default;
                }
                if (depthStencilState != null)
                {
                    marshalledCreateInfos->DepthStencilState = (Interop.PipelineDepthStencilStateCreateInfo*)HeapUtil.Allocate<Interop.PipelineDepthStencilStateCreateInfo>();
                    depthStencilState.Value.MarshalTo(marshalledCreateInfos->DepthStencilState);
                }
                else
                {
                    marshalledCreateInfos->DepthStencilState = default;
                }
                if (colorBlendState != null)
                {
                    marshalledCreateInfos->ColorBlendState = (Interop.PipelineColorBlendStateCreateInfo*)HeapUtil.Allocate<Interop.PipelineColorBlendStateCreateInfo>();
                    colorBlendState.Value.MarshalTo(marshalledCreateInfos->ColorBlendState);
                }
                else
                {
                    marshalledCreateInfos->ColorBlendState = default;
                }
                if (dynamicState != null)
                {
                    marshalledCreateInfos->DynamicState = (Interop.PipelineDynamicStateCreateInfo*)HeapUtil.Allocate<Interop.PipelineDynamicStateCreateInfo>();
                    dynamicState.Value.MarshalTo(marshalledCreateInfos->DynamicState);
                }
                else
                {
                    marshalledCreateInfos->DynamicState = default;
                }
                marshalledCreateInfos->Layout = layout?.Handle ?? default(Interop.PipelineLayout);
                marshalledCreateInfos->RenderPass = renderPass?.Handle ?? default(Interop.RenderPass);
                marshalledCreateInfos->Subpass = subpass;
                marshalledCreateInfos->BasePipelineHandle = basePipelineHandle?.Handle ?? default(Interop.Pipeline);
                marshalledCreateInfos->BasePipelineIndex = basePipelineIndex;
                if (allocator != null)
                {
                    marshalledAllocator = (Interop.AllocationCallbacks*)HeapUtil.Allocate<Interop.AllocationCallbacks>();
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default;
                }
                marshalledPipelines = (Interop.Pipeline*)HeapUtil.Allocate<Interop.Pipeline>(1);
                var commandDelegate = CommandCache.Cache.VkCreateGraphicsPipelines;
                var methodResult = commandDelegate(Handle, pipelineCache?.Handle ?? default(Interop.PipelineCache), marshalledCreateInfoCount, marshalledCreateInfos, marshalledAllocator, marshalledPipelines);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                result = new(this, *marshalledPipelines);
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Creates a new compute pipeline object.
        /// </summary>
        /// <param name="pipelineCache">
        /// </param>
        /// <param name="createInfos">
        /// </param>
        /// <param name="allocator">
        ///     An optional AllocationCallbacks instance that controls host memory
        ///     allocation.
        /// </param>
        public unsafe Pipeline[] CreateComputePipelines(PipelineCache pipelineCache, ArrayProxy<ComputePipelineCreateInfo>? createInfos, AllocationCallbacks? allocator = default)
        {
            try
            {
                var result = default(Pipeline[]);
                var marshalledCreateInfoCount = default(uint);
                var marshalledCreateInfos = default(Interop.ComputePipelineCreateInfo*);
                var marshalledAllocator = default(Interop.AllocationCallbacks*);
                var marshalledPipelines = default(Interop.Pipeline*);
                marshalledCreateInfoCount = HeapUtil.GetLength(createInfos);
                if (createInfos.IsNull())
                {
                    marshalledCreateInfos = null;
                }
                else
                {
                    if (createInfos.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfos = (Interop.ComputePipelineCreateInfo*)HeapUtil.Allocate<Interop.ComputePipelineCreateInfo>();
                        createInfos.Value.GetSingleValue().MarshalTo(&*marshalledCreateInfos);
                    }
                    else
                    {
                        var fieldPointer = (Interop.ComputePipelineCreateInfo*)HeapUtil.AllocateAndClear<Interop.ComputePipelineCreateInfo>(HeapUtil.GetLength(createInfos.Value)).ToPointer();
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
                marshalledPipelines = (Interop.Pipeline*)HeapUtil.Allocate<Interop.Pipeline>(marshalledCreateInfoCount);
                var commandDelegate = CommandCache.Cache.VkCreateComputePipelines;
                var methodResult = commandDelegate(Handle, pipelineCache?.Handle ?? default(Interop.PipelineCache), marshalledCreateInfoCount, marshalledCreateInfos, marshalledAllocator, marshalledPipelines);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                if (marshalledPipelines != null)
                {
                    var fieldPointer = new Pipeline[marshalledCreateInfoCount];
                    for (var index = 0; index < marshalledCreateInfoCount; index++) fieldPointer[index] = new(this, marshalledPipelines[index]);
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
        ///     Creates a new compute pipeline object.
        /// </summary>
        /// <param name="pipelineCache">
        /// </param>
        /// <param name="flags">
        ///     flags provides options for pipeline creation, and is of type
        ///     PipelineCreateFlagBits.
        /// </param>
        /// <param name="stage">
        ///     A PipelineShaderStageCreateInfo describing the compute shader.
        /// </param>
        /// <param name="layout">
        ///     The description of binding locations used by both the pipeline and
        ///     descriptor sets used with the pipeline.
        /// </param>
        /// <param name="basePipelineHandle">
        ///     A pipeline to derive from
        /// </param>
        /// <param name="basePipelineIndex">
        ///     An index into the pCreateInfos parameter to use as a pipeline to
        ///     derive from
        /// </param>
        /// <param name="pipelineCreationFeedbackCreateInfoExt">
        ///     Extension struct
        /// </param>
        /// <param name="pipelineCompilerControlCreateInfoAmd">
        ///     Extension struct
        /// </param>
        /// <param name="allocator">
        ///     An optional AllocationCallbacks instance that controls host memory
        ///     allocation.
        /// </param>
        public unsafe Pipeline CreateComputePipeline(PipelineCache pipelineCache, PipelineShaderStageCreateInfo stage, PipelineLayout layout, Pipeline basePipelineHandle, int basePipelineIndex, PipelineCreateFlags? flags = default, PipelineCreationFeedbackCreateInfo? pipelineCreationFeedbackCreateInfoExt = null, PipelineCompilerControlCreateInfo? pipelineCompilerControlCreateInfoAmd = null, AllocationCallbacks? allocator = default)
        {
            try
            {
                var result = default(Pipeline);
                var marshalledCreateInfoCount = default(uint);
                var marshalledCreateInfos = default(Interop.ComputePipelineCreateInfo*);
                var vkComputePipelineCreateInfoNextPointer = default(void*);
                var marshalledAllocator = default(Interop.AllocationCallbacks*);
                var marshalledPipelines = default(Interop.Pipeline*);
                if (pipelineCreationFeedbackCreateInfoExt != null)
                {
                    var extensionPointer = default(Interop.Multivendor.PipelineCreationFeedbackCreateInfo*);
                    extensionPointer = (Interop.Multivendor.PipelineCreationFeedbackCreateInfo*)HeapUtil.Allocate<Interop.Multivendor.PipelineCreationFeedbackCreateInfo>();
                    pipelineCreationFeedbackCreateInfoExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkComputePipelineCreateInfoNextPointer;
                    vkComputePipelineCreateInfoNextPointer = extensionPointer;
                }
                if (pipelineCompilerControlCreateInfoAmd != null)
                {
                    var extensionPointer = default(Interop.Amd.PipelineCompilerControlCreateInfo*);
                    extensionPointer = (Interop.Amd.PipelineCompilerControlCreateInfo*)HeapUtil.Allocate<Interop.Amd.PipelineCompilerControlCreateInfo>();
                    pipelineCompilerControlCreateInfoAmd.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkComputePipelineCreateInfoNextPointer;
                    vkComputePipelineCreateInfoNextPointer = extensionPointer;
                }
                marshalledCreateInfoCount = 1;
                marshalledCreateInfos = (Interop.ComputePipelineCreateInfo*)HeapUtil.Allocate<Interop.ComputePipelineCreateInfo>();
                marshalledCreateInfos->SType = StructureType.ComputePipelineCreateInfo;
                marshalledCreateInfos->Next = vkComputePipelineCreateInfoNextPointer;
                if (flags != null)
                    marshalledCreateInfos->Flags = flags.Value;
                else
                    marshalledCreateInfos->Flags = default;
                stage.MarshalTo(&marshalledCreateInfos->Stage);
                marshalledCreateInfos->Layout = layout?.Handle ?? default(Interop.PipelineLayout);
                marshalledCreateInfos->BasePipelineHandle = basePipelineHandle?.Handle ?? default(Interop.Pipeline);
                marshalledCreateInfos->BasePipelineIndex = basePipelineIndex;
                if (allocator != null)
                {
                    marshalledAllocator = (Interop.AllocationCallbacks*)HeapUtil.Allocate<Interop.AllocationCallbacks>();
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default;
                }
                marshalledPipelines = (Interop.Pipeline*)HeapUtil.Allocate<Interop.Pipeline>(1);
                var commandDelegate = CommandCache.Cache.VkCreateComputePipelines;
                var methodResult = commandDelegate(Handle, pipelineCache?.Handle ?? default(Interop.PipelineCache), marshalledCreateInfoCount, marshalledCreateInfos, marshalledAllocator, marshalledPipelines);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                result = new(this, *marshalledPipelines);
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Creates a new pipeline layout object.
        /// </summary>
        /// <param name="flags">
        ///     Reserved for future use.
        /// </param>
        /// <param name="setLayouts">
        /// </param>
        /// <param name="pushConstantRanges">
        /// </param>
        /// <param name="allocator">
        ///     An optional AllocationCallbacks instance that controls host memory
        ///     allocation.
        /// </param>
        public unsafe PipelineLayout CreatePipelineLayout(ArrayProxy<DescriptorSetLayout>? setLayouts, ArrayProxy<PushConstantRange>? pushConstantRanges, PipelineLayoutCreateFlags? flags = default, AllocationCallbacks? allocator = default)
        {
            try
            {
                var result = default(PipelineLayout);
                var marshalledCreateInfo = default(Interop.PipelineLayoutCreateInfo*);
                var vkPipelineLayoutCreateInfoNextPointer = default(void*);
                var marshalledAllocator = default(Interop.AllocationCallbacks*);
                var marshalledPipelineLayout = default(Interop.PipelineLayout);
                marshalledCreateInfo = (Interop.PipelineLayoutCreateInfo*)HeapUtil.Allocate<Interop.PipelineLayoutCreateInfo>();
                marshalledCreateInfo->SType = StructureType.PipelineLayoutCreateInfo;
                marshalledCreateInfo->Next = vkPipelineLayoutCreateInfoNextPointer;
                if (flags != null)
                    marshalledCreateInfo->Flags = flags.Value;
                else
                    marshalledCreateInfo->Flags = default;
                marshalledCreateInfo->SetLayoutCount = HeapUtil.GetLength(setLayouts);
                if (setLayouts.IsNull())
                {
                    marshalledCreateInfo->SetLayouts = null;
                }
                else
                {
                    if (setLayouts.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfo->SetLayouts = (Interop.DescriptorSetLayout*)HeapUtil.Allocate<Interop.DescriptorSetLayout>();
                        *marshalledCreateInfo->SetLayouts = setLayouts.Value.GetSingleValue()?.Handle ?? default(Interop.DescriptorSetLayout);
                    }
                    else
                    {
                        var fieldPointer = (Interop.DescriptorSetLayout*)HeapUtil.AllocateAndClear<Interop.DescriptorSetLayout>(HeapUtil.GetLength(setLayouts.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(setLayouts.Value); index++) fieldPointer[index] = setLayouts.Value[index]?.Handle ?? default(Interop.DescriptorSetLayout);
                        marshalledCreateInfo->SetLayouts = fieldPointer;
                    }
                }
                marshalledCreateInfo->PushConstantRangeCount = HeapUtil.GetLength(pushConstantRanges);
                if (pushConstantRanges.IsNull())
                {
                    marshalledCreateInfo->PushConstantRanges = null;
                }
                else
                {
                    if (pushConstantRanges.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfo->PushConstantRanges = (PushConstantRange*)HeapUtil.Allocate<PushConstantRange>();
                        *marshalledCreateInfo->PushConstantRanges = pushConstantRanges.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (PushConstantRange*)HeapUtil.AllocateAndClear<PushConstantRange>(HeapUtil.GetLength(pushConstantRanges.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(pushConstantRanges.Value); index++) fieldPointer[index] = pushConstantRanges.Value[index];
                        marshalledCreateInfo->PushConstantRanges = fieldPointer;
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
                var commandDelegate = CommandCache.Cache.VkCreatePipelineLayout;
                var methodResult = commandDelegate(Handle, marshalledCreateInfo, marshalledAllocator, &marshalledPipelineLayout);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                result = new(this, marshalledPipelineLayout);
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Create a new sampler object.
        /// </summary>
        /// <param name="flags">
        ///     Reserved for future use.
        /// </param>
        /// <param name="magFilter">
        ///     The magnification filter to apply to lookups.
        /// </param>
        /// <param name="minFilter">
        /// </param>
        /// <param name="mipmapMode">
        /// </param>
        /// <param name="addressModeU">
        /// </param>
        /// <param name="addressModeV">
        /// </param>
        /// <param name="addressModeW">
        /// </param>
        /// <param name="mipLodBias">
        /// </param>
        /// <param name="anisotropyEnable">
        /// </param>
        /// <param name="maxAnisotropy">
        /// </param>
        /// <param name="compareEnable">
        /// </param>
        /// <param name="compareOp">
        /// </param>
        /// <param name="minLod">
        /// </param>
        /// <param name="maxLod">
        /// </param>
        /// <param name="borderColor">
        /// </param>
        /// <param name="unnormalizedCoordinates">
        /// </param>
        /// <param name="samplerYcbcrConversionInfo">
        ///     Extension struct
        /// </param>
        /// <param name="samplerReductionModeCreateInfo">
        ///     Extension struct
        /// </param>
        /// <param name="allocator">
        ///     An optional AllocationCallbacks instance that controls host memory
        ///     allocation.
        /// </param>
        public unsafe Sampler CreateSampler(Filter magFilter, Filter minFilter, SamplerMipmapMode mipmapMode, SamplerAddressMode addressModeU, SamplerAddressMode addressModeV, SamplerAddressMode addressModeW, float mipLodBias, bool anisotropyEnable, float maxAnisotropy, bool compareEnable, CompareOp compareOp, float minLod, float maxLod, BorderColor borderColor, bool unnormalizedCoordinates, SamplerCreateFlags? flags = default, SamplerYcbcrConversionInfo? samplerYcbcrConversionInfo = null,
            SamplerReductionModeCreateInfo? samplerReductionModeCreateInfo = null, AllocationCallbacks? allocator = default)
        {
            try
            {
                var result = default(Sampler);
                var marshalledCreateInfo = default(Interop.SamplerCreateInfo*);
                var vkSamplerCreateInfoNextPointer = default(void*);
                var marshalledAllocator = default(Interop.AllocationCallbacks*);
                var marshalledSampler = default(Interop.Sampler);
                if (samplerYcbcrConversionInfo != null)
                {
                    var extensionPointer = default(Interop.SamplerYcbcrConversionInfo*);
                    extensionPointer = (Interop.SamplerYcbcrConversionInfo*)HeapUtil.Allocate<Interop.SamplerYcbcrConversionInfo>();
                    samplerYcbcrConversionInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkSamplerCreateInfoNextPointer;
                    vkSamplerCreateInfoNextPointer = extensionPointer;
                }
                if (samplerReductionModeCreateInfo != null)
                {
                    var extensionPointer = default(Interop.SamplerReductionModeCreateInfo*);
                    extensionPointer = (Interop.SamplerReductionModeCreateInfo*)HeapUtil.Allocate<Interop.SamplerReductionModeCreateInfo>();
                    samplerReductionModeCreateInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkSamplerCreateInfoNextPointer;
                    vkSamplerCreateInfoNextPointer = extensionPointer;
                }
                marshalledCreateInfo = (Interop.SamplerCreateInfo*)HeapUtil.Allocate<Interop.SamplerCreateInfo>();
                marshalledCreateInfo->SType = StructureType.SamplerCreateInfo;
                marshalledCreateInfo->Next = vkSamplerCreateInfoNextPointer;
                if (flags != null)
                    marshalledCreateInfo->Flags = flags.Value;
                else
                    marshalledCreateInfo->Flags = default;
                marshalledCreateInfo->MagFilter = magFilter;
                marshalledCreateInfo->MinFilter = minFilter;
                marshalledCreateInfo->MipmapMode = mipmapMode;
                marshalledCreateInfo->AddressModeU = addressModeU;
                marshalledCreateInfo->AddressModeV = addressModeV;
                marshalledCreateInfo->AddressModeW = addressModeW;
                marshalledCreateInfo->MipLodBias = mipLodBias;
                marshalledCreateInfo->AnisotropyEnable = anisotropyEnable;
                marshalledCreateInfo->MaxAnisotropy = maxAnisotropy;
                marshalledCreateInfo->CompareEnable = compareEnable;
                marshalledCreateInfo->CompareOp = compareOp;
                marshalledCreateInfo->MinLod = minLod;
                marshalledCreateInfo->MaxLod = maxLod;
                marshalledCreateInfo->BorderColor = borderColor;
                marshalledCreateInfo->UnnormalizedCoordinates = unnormalizedCoordinates;
                if (allocator != null)
                {
                    marshalledAllocator = (Interop.AllocationCallbacks*)HeapUtil.Allocate<Interop.AllocationCallbacks>();
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default;
                }
                var commandDelegate = CommandCache.Cache.VkCreateSampler;
                var methodResult = commandDelegate(Handle, marshalledCreateInfo, marshalledAllocator, &marshalledSampler);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                result = new(this, marshalledSampler);
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Create a new descriptor set layout.
        /// </summary>
        /// <param name="flags">
        ///     flags provides options for descriptor set layout creation, and is
        ///     of type DescriptorSetLayoutCreateFlags. Bits which can be set
        ///     include: + --
        /// </param>
        /// <param name="bindings">
        /// </param>
        /// <param name="descriptorSetLayoutBindingFlagsCreateInfo">
        ///     Extension struct
        /// </param>
        /// <param name="allocator">
        ///     An optional AllocationCallbacks instance that controls host memory
        ///     allocation.
        /// </param>
        public unsafe DescriptorSetLayout CreateDescriptorSetLayout(ArrayProxy<DescriptorSetLayoutBinding>? bindings, DescriptorSetLayoutCreateFlags? flags = default, DescriptorSetLayoutBindingFlagsCreateInfo? descriptorSetLayoutBindingFlagsCreateInfo = null, AllocationCallbacks? allocator = default)
        {
            try
            {
                var result = default(DescriptorSetLayout);
                var marshalledCreateInfo = default(Interop.DescriptorSetLayoutCreateInfo*);
                var vkDescriptorSetLayoutCreateInfoNextPointer = default(void*);
                var marshalledAllocator = default(Interop.AllocationCallbacks*);
                var marshalledSetLayout = default(Interop.DescriptorSetLayout);
                if (descriptorSetLayoutBindingFlagsCreateInfo != null)
                {
                    var extensionPointer = default(Interop.DescriptorSetLayoutBindingFlagsCreateInfo*);
                    extensionPointer = (Interop.DescriptorSetLayoutBindingFlagsCreateInfo*)HeapUtil.Allocate<Interop.DescriptorSetLayoutBindingFlagsCreateInfo>();
                    descriptorSetLayoutBindingFlagsCreateInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDescriptorSetLayoutCreateInfoNextPointer;
                    vkDescriptorSetLayoutCreateInfoNextPointer = extensionPointer;
                }
                marshalledCreateInfo = (Interop.DescriptorSetLayoutCreateInfo*)HeapUtil.Allocate<Interop.DescriptorSetLayoutCreateInfo>();
                marshalledCreateInfo->SType = StructureType.DescriptorSetLayoutCreateInfo;
                marshalledCreateInfo->Next = vkDescriptorSetLayoutCreateInfoNextPointer;
                if (flags != null)
                    marshalledCreateInfo->Flags = flags.Value;
                else
                    marshalledCreateInfo->Flags = default;
                marshalledCreateInfo->BindingCount = HeapUtil.GetLength(bindings);
                if (bindings.IsNull())
                {
                    marshalledCreateInfo->Bindings = null;
                }
                else
                {
                    if (bindings.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfo->Bindings = (Interop.DescriptorSetLayoutBinding*)HeapUtil.Allocate<Interop.DescriptorSetLayoutBinding>();
                        bindings.Value.GetSingleValue().MarshalTo(&*marshalledCreateInfo->Bindings);
                    }
                    else
                    {
                        var fieldPointer = (Interop.DescriptorSetLayoutBinding*)HeapUtil.AllocateAndClear<Interop.DescriptorSetLayoutBinding>(HeapUtil.GetLength(bindings.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(bindings.Value); index++) bindings.Value[index].MarshalTo(&fieldPointer[index]);
                        marshalledCreateInfo->Bindings = fieldPointer;
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
                var commandDelegate = CommandCache.Cache.VkCreateDescriptorSetLayout;
                var methodResult = commandDelegate(Handle, marshalledCreateInfo, marshalledAllocator, &marshalledSetLayout);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                result = new(this, marshalledSetLayout);
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Creates a descriptor pool object.
        /// </summary>
        /// <param name="flags">
        ///     Specifies certain supported operations on the pool. Bits which can
        ///     be set include: + --
        /// </param>
        /// <param name="maxSets">
        /// </param>
        /// <param name="poolSizes">
        /// </param>
        /// <param name="descriptorPoolInlineUniformBlockCreateInfoExt">
        ///     Extension struct
        /// </param>
        /// <param name="allocator">
        ///     An optional AllocationCallbacks instance that controls host memory
        ///     allocation.
        /// </param>
        public unsafe DescriptorPool CreateDescriptorPool(uint maxSets, ArrayProxy<DescriptorPoolSize>? poolSizes, DescriptorPoolCreateFlags? flags = default, DescriptorPoolInlineUniformBlockCreateInfo? descriptorPoolInlineUniformBlockCreateInfoExt = null, AllocationCallbacks? allocator = default)
        {
            try
            {
                var result = default(DescriptorPool);
                var marshalledCreateInfo = default(Interop.DescriptorPoolCreateInfo*);
                var vkDescriptorPoolCreateInfoNextPointer = default(void*);
                var marshalledAllocator = default(Interop.AllocationCallbacks*);
                var marshalledDescriptorPool = default(Interop.DescriptorPool);
                if (descriptorPoolInlineUniformBlockCreateInfoExt != null)
                {
                    var extensionPointer = default(Interop.Multivendor.DescriptorPoolInlineUniformBlockCreateInfo*);
                    extensionPointer = (Interop.Multivendor.DescriptorPoolInlineUniformBlockCreateInfo*)HeapUtil.Allocate<Interop.Multivendor.DescriptorPoolInlineUniformBlockCreateInfo>();
                    descriptorPoolInlineUniformBlockCreateInfoExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDescriptorPoolCreateInfoNextPointer;
                    vkDescriptorPoolCreateInfoNextPointer = extensionPointer;
                }
                marshalledCreateInfo = (Interop.DescriptorPoolCreateInfo*)HeapUtil.Allocate<Interop.DescriptorPoolCreateInfo>();
                marshalledCreateInfo->SType = StructureType.DescriptorPoolCreateInfo;
                marshalledCreateInfo->Next = vkDescriptorPoolCreateInfoNextPointer;
                if (flags != null)
                    marshalledCreateInfo->Flags = flags.Value;
                else
                    marshalledCreateInfo->Flags = default;
                marshalledCreateInfo->MaxSets = maxSets;
                marshalledCreateInfo->PoolSizeCount = HeapUtil.GetLength(poolSizes);
                if (poolSizes.IsNull())
                {
                    marshalledCreateInfo->PoolSizes = null;
                }
                else
                {
                    if (poolSizes.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfo->PoolSizes = (DescriptorPoolSize*)HeapUtil.Allocate<DescriptorPoolSize>();
                        *marshalledCreateInfo->PoolSizes = poolSizes.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (DescriptorPoolSize*)HeapUtil.AllocateAndClear<DescriptorPoolSize>(HeapUtil.GetLength(poolSizes.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(poolSizes.Value); index++) fieldPointer[index] = poolSizes.Value[index];
                        marshalledCreateInfo->PoolSizes = fieldPointer;
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
                var commandDelegate = CommandCache.Cache.VkCreateDescriptorPool;
                var methodResult = commandDelegate(Handle, marshalledCreateInfo, marshalledAllocator, &marshalledDescriptorPool);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                result = new(this, marshalledDescriptorPool);
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Allocate one or more descriptor sets.
        /// </summary>
        /// <param name="descriptorPool">
        ///     The pool which the sets will be allocated from.
        /// </param>
        /// <param name="setLayouts">
        /// </param>
        /// <param name="descriptorSetVariableDescriptorCountAllocateInfo">
        ///     Extension struct
        /// </param>
        public unsafe DescriptorSet[] AllocateDescriptorSets(DescriptorPool descriptorPool, ArrayProxy<DescriptorSetLayout>? setLayouts, DescriptorSetVariableDescriptorCountAllocateInfo? descriptorSetVariableDescriptorCountAllocateInfo = null)
        {
            try
            {
                var result = default(DescriptorSet[]);
                var marshalledAllocateInfo = default(Interop.DescriptorSetAllocateInfo*);
                var vkDescriptorSetAllocateInfoNextPointer = default(void*);
                var marshalledDescriptorSets = default(Interop.DescriptorSet*);
                if (descriptorSetVariableDescriptorCountAllocateInfo != null)
                {
                    var extensionPointer = default(Interop.DescriptorSetVariableDescriptorCountAllocateInfo*);
                    extensionPointer = (Interop.DescriptorSetVariableDescriptorCountAllocateInfo*)HeapUtil.Allocate<Interop.DescriptorSetVariableDescriptorCountAllocateInfo>();
                    descriptorSetVariableDescriptorCountAllocateInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDescriptorSetAllocateInfoNextPointer;
                    vkDescriptorSetAllocateInfoNextPointer = extensionPointer;
                }
                marshalledAllocateInfo = (Interop.DescriptorSetAllocateInfo*)HeapUtil.Allocate<Interop.DescriptorSetAllocateInfo>();
                marshalledAllocateInfo->SType = StructureType.DescriptorSetAllocateInfo;
                marshalledAllocateInfo->Next = vkDescriptorSetAllocateInfoNextPointer;
                marshalledAllocateInfo->DescriptorPool = descriptorPool?.Handle ?? default(Interop.DescriptorPool);
                marshalledAllocateInfo->DescriptorSetCount = HeapUtil.GetLength(setLayouts);
                if (setLayouts.IsNull())
                {
                    marshalledAllocateInfo->SetLayouts = null;
                }
                else
                {
                    if (setLayouts.Value.Contents == ProxyContents.Single)
                    {
                        marshalledAllocateInfo->SetLayouts = (Interop.DescriptorSetLayout*)HeapUtil.Allocate<Interop.DescriptorSetLayout>();
                        *marshalledAllocateInfo->SetLayouts = setLayouts.Value.GetSingleValue()?.Handle ?? default(Interop.DescriptorSetLayout);
                    }
                    else
                    {
                        var fieldPointer = (Interop.DescriptorSetLayout*)HeapUtil.AllocateAndClear<Interop.DescriptorSetLayout>(HeapUtil.GetLength(setLayouts.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(setLayouts.Value); index++) fieldPointer[index] = setLayouts.Value[index]?.Handle ?? default(Interop.DescriptorSetLayout);
                        marshalledAllocateInfo->SetLayouts = fieldPointer;
                    }
                }
                marshalledDescriptorSets = (Interop.DescriptorSet*)HeapUtil.Allocate<Interop.DescriptorSet>(HeapUtil.GetLength(setLayouts));
                var commandDelegate = CommandCache.Cache.VkAllocateDescriptorSets;
                var methodResult = commandDelegate(Handle, marshalledAllocateInfo, marshalledDescriptorSets);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                if (marshalledDescriptorSets != null)
                {
                    var fieldPointer = new DescriptorSet[HeapUtil.GetLength(setLayouts)];
                    for (var index = 0; index < HeapUtil.GetLength(setLayouts); index++) fieldPointer[index] = new(descriptorPool, marshalledDescriptorSets[index]);
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
        ///     Allocate one or more descriptor sets.
        /// </summary>
        /// <param name="descriptorPool">
        ///     The pool which the sets will be allocated from.
        /// </param>
        /// <param name="setLayouts">
        ///     An array of descriptor set layouts, with each member specifying how
        ///     the corresponding descriptor set is allocated.
        /// </param>
        /// <param name="descriptorSetVariableDescriptorCountAllocateInfo">
        ///     Extension struct
        /// </param>
        public unsafe DescriptorSet AllocateDescriptorSet(DescriptorPool descriptorPool, DescriptorSetLayout setLayouts, DescriptorSetVariableDescriptorCountAllocateInfo? descriptorSetVariableDescriptorCountAllocateInfo = null)
        {
            try
            {
                var result = default(DescriptorSet);
                var marshalledAllocateInfo = default(Interop.DescriptorSetAllocateInfo*);
                var vkDescriptorSetAllocateInfoNextPointer = default(void*);
                var marshalledDescriptorSets = default(Interop.DescriptorSet*);
                if (descriptorSetVariableDescriptorCountAllocateInfo != null)
                {
                    var extensionPointer = default(Interop.DescriptorSetVariableDescriptorCountAllocateInfo*);
                    extensionPointer = (Interop.DescriptorSetVariableDescriptorCountAllocateInfo*)HeapUtil.Allocate<Interop.DescriptorSetVariableDescriptorCountAllocateInfo>();
                    descriptorSetVariableDescriptorCountAllocateInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDescriptorSetAllocateInfoNextPointer;
                    vkDescriptorSetAllocateInfoNextPointer = extensionPointer;
                }
                marshalledAllocateInfo = (Interop.DescriptorSetAllocateInfo*)HeapUtil.Allocate<Interop.DescriptorSetAllocateInfo>();
                marshalledAllocateInfo->SType = StructureType.DescriptorSetAllocateInfo;
                marshalledAllocateInfo->Next = vkDescriptorSetAllocateInfoNextPointer;
                marshalledAllocateInfo->DescriptorPool = descriptorPool?.Handle ?? default(Interop.DescriptorPool);
                marshalledAllocateInfo->DescriptorSetCount = 1;
                marshalledAllocateInfo->SetLayouts = (Interop.DescriptorSetLayout*)HeapUtil.Allocate<Interop.DescriptorSetLayout>();
                *marshalledAllocateInfo->SetLayouts = setLayouts.Handle;
                marshalledDescriptorSets = (Interop.DescriptorSet*)HeapUtil.Allocate<Interop.DescriptorSet>(1);
                var commandDelegate = CommandCache.Cache.VkAllocateDescriptorSets;
                var methodResult = commandDelegate(Handle, marshalledAllocateInfo, marshalledDescriptorSets);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                result = new(descriptorPool, *marshalledDescriptorSets);
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Update the contents of a descriptor set object.
        /// </summary>
        /// <param name="descriptorWrites">
        /// </param>
        /// <param name="descriptorCopies">
        /// </param>
        public unsafe void UpdateDescriptorSets(ArrayProxy<WriteDescriptorSet>? descriptorWrites, ArrayProxy<CopyDescriptorSet>? descriptorCopies)
        {
            try
            {
                var marshalledDescriptorWrites = default(Interop.WriteDescriptorSet*);
                var marshalledDescriptorCopies = default(Interop.CopyDescriptorSet*);
                if (descriptorWrites.IsNull())
                {
                    marshalledDescriptorWrites = null;
                }
                else
                {
                    if (descriptorWrites.Value.Contents == ProxyContents.Single)
                    {
                        marshalledDescriptorWrites = (Interop.WriteDescriptorSet*)HeapUtil.Allocate<Interop.WriteDescriptorSet>();
                        descriptorWrites.Value.GetSingleValue().MarshalTo(&*marshalledDescriptorWrites);
                    }
                    else
                    {
                        var fieldPointer = (Interop.WriteDescriptorSet*)HeapUtil.AllocateAndClear<Interop.WriteDescriptorSet>(HeapUtil.GetLength(descriptorWrites.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(descriptorWrites.Value); index++) descriptorWrites.Value[index].MarshalTo(&fieldPointer[index]);
                        marshalledDescriptorWrites = fieldPointer;
                    }
                }
                if (descriptorCopies.IsNull())
                {
                    marshalledDescriptorCopies = null;
                }
                else
                {
                    if (descriptorCopies.Value.Contents == ProxyContents.Single)
                    {
                        marshalledDescriptorCopies = (Interop.CopyDescriptorSet*)HeapUtil.Allocate<Interop.CopyDescriptorSet>();
                        descriptorCopies.Value.GetSingleValue().MarshalTo(&*marshalledDescriptorCopies);
                    }
                    else
                    {
                        var fieldPointer = (Interop.CopyDescriptorSet*)HeapUtil.AllocateAndClear<Interop.CopyDescriptorSet>(HeapUtil.GetLength(descriptorCopies.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(descriptorCopies.Value); index++) descriptorCopies.Value[index].MarshalTo(&fieldPointer[index]);
                        marshalledDescriptorCopies = fieldPointer;
                    }
                }
                var commandDelegate = CommandCache.Cache.VkUpdateDescriptorSets;
                commandDelegate(Handle, HeapUtil.GetLength(descriptorWrites), marshalledDescriptorWrites, HeapUtil.GetLength(descriptorCopies), marshalledDescriptorCopies);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Create a new framebuffer object.
        /// </summary>
        /// <param name="flags">
        ///     Reserved for future use.
        /// </param>
        /// <param name="renderPass">
        ///     A render pass that defines what render passes the framebuffer will
        ///     be compatible with.
        /// </param>
        /// <param name="attachments">
        /// </param>
        /// <param name="width">
        ///     width, height and layers define the dimensions of the framebuffer.
        ///     If the render pass uses multiview, then layers must be one and each
        ///     attachment requires a number of layers that is greater than the
        ///     maximum bit index set in the view mask in the subpasses in which it
        ///     is used.
        /// </param>
        /// <param name="height">
        /// </param>
        /// <param name="layers">
        /// </param>
        /// <param name="framebufferAttachmentsCreateInfo">
        ///     Extension struct
        /// </param>
        /// <param name="allocator">
        ///     An optional AllocationCallbacks instance that controls host memory
        ///     allocation.
        /// </param>
        public unsafe Framebuffer CreateFramebuffer(RenderPass renderPass, ArrayProxy<ImageView>? attachments, uint width, uint height, uint layers, FramebufferCreateFlags? flags = default, FramebufferAttachmentsCreateInfo? framebufferAttachmentsCreateInfo = null, AllocationCallbacks? allocator = default)
        {
            try
            {
                var result = default(Framebuffer);
                var marshalledCreateInfo = default(Interop.FramebufferCreateInfo*);
                var vkFramebufferCreateInfoNextPointer = default(void*);
                var marshalledAllocator = default(Interop.AllocationCallbacks*);
                var marshalledFramebuffer = default(Interop.Framebuffer);
                if (framebufferAttachmentsCreateInfo != null)
                {
                    var extensionPointer = default(Interop.FramebufferAttachmentsCreateInfo*);
                    extensionPointer = (Interop.FramebufferAttachmentsCreateInfo*)HeapUtil.Allocate<Interop.FramebufferAttachmentsCreateInfo>();
                    framebufferAttachmentsCreateInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkFramebufferCreateInfoNextPointer;
                    vkFramebufferCreateInfoNextPointer = extensionPointer;
                }
                marshalledCreateInfo = (Interop.FramebufferCreateInfo*)HeapUtil.Allocate<Interop.FramebufferCreateInfo>();
                marshalledCreateInfo->SType = StructureType.FramebufferCreateInfo;
                marshalledCreateInfo->Next = vkFramebufferCreateInfoNextPointer;
                if (flags != null)
                    marshalledCreateInfo->Flags = flags.Value;
                else
                    marshalledCreateInfo->Flags = default;
                marshalledCreateInfo->RenderPass = renderPass?.Handle ?? default(Interop.RenderPass);
                marshalledCreateInfo->AttachmentCount = HeapUtil.GetLength(attachments);
                if (attachments.IsNull())
                {
                    marshalledCreateInfo->Attachments = null;
                }
                else
                {
                    if (attachments.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfo->Attachments = (Interop.ImageView*)HeapUtil.Allocate<Interop.ImageView>();
                        *marshalledCreateInfo->Attachments = attachments.Value.GetSingleValue()?.Handle ?? default(Interop.ImageView);
                    }
                    else
                    {
                        var fieldPointer = (Interop.ImageView*)HeapUtil.AllocateAndClear<Interop.ImageView>(HeapUtil.GetLength(attachments.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(attachments.Value); index++) fieldPointer[index] = attachments.Value[index]?.Handle ?? default(Interop.ImageView);
                        marshalledCreateInfo->Attachments = fieldPointer;
                    }
                }
                marshalledCreateInfo->Width = width;
                marshalledCreateInfo->Height = height;
                marshalledCreateInfo->Layers = layers;
                if (allocator != null)
                {
                    marshalledAllocator = (Interop.AllocationCallbacks*)HeapUtil.Allocate<Interop.AllocationCallbacks>();
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default;
                }
                var commandDelegate = CommandCache.Cache.VkCreateFramebuffer;
                var methodResult = commandDelegate(Handle, marshalledCreateInfo, marshalledAllocator, &marshalledFramebuffer);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                result = new(this, marshalledFramebuffer);
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Create a new render pass object.
        /// </summary>
        /// <param name="flags">
        ///     Reserved for future use.
        /// </param>
        /// <param name="attachments">
        /// </param>
        /// <param name="subpasses">
        /// </param>
        /// <param name="dependencies">
        /// </param>
        /// <param name="renderPassMultiviewCreateInfo">
        ///     Extension struct
        /// </param>
        /// <param name="renderPassInputAttachmentAspectCreateInfo">
        ///     Extension struct
        /// </param>
        /// <param name="renderPassFragmentDensityMapCreateInfoExt">
        ///     Extension struct
        /// </param>
        /// <param name="allocator">
        ///     An optional AllocationCallbacks instance that controls host memory
        ///     allocation.
        /// </param>
        public unsafe RenderPass CreateRenderPass(ArrayProxy<AttachmentDescription>? attachments, ArrayProxy<SubpassDescription>? subpasses, ArrayProxy<SubpassDependency>? dependencies, RenderPassCreateFlags? flags = default, RenderPassMultiviewCreateInfo? renderPassMultiviewCreateInfo = null, RenderPassInputAttachmentAspectCreateInfo? renderPassInputAttachmentAspectCreateInfo = null, RenderPassFragmentDensityMapCreateInfo? renderPassFragmentDensityMapCreateInfoExt = null,
            AllocationCallbacks? allocator = default)
        {
            try
            {
                var result = default(RenderPass);
                var marshalledCreateInfo = default(Interop.RenderPassCreateInfo*);
                var vkRenderPassCreateInfoNextPointer = default(void*);
                var marshalledAllocator = default(Interop.AllocationCallbacks*);
                var marshalledRenderPass = default(Interop.RenderPass);
                if (renderPassMultiviewCreateInfo != null)
                {
                    var extensionPointer = default(Interop.RenderPassMultiviewCreateInfo*);
                    extensionPointer = (Interop.RenderPassMultiviewCreateInfo*)HeapUtil.Allocate<Interop.RenderPassMultiviewCreateInfo>();
                    renderPassMultiviewCreateInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkRenderPassCreateInfoNextPointer;
                    vkRenderPassCreateInfoNextPointer = extensionPointer;
                }
                if (renderPassInputAttachmentAspectCreateInfo != null)
                {
                    var extensionPointer = default(Interop.RenderPassInputAttachmentAspectCreateInfo*);
                    extensionPointer = (Interop.RenderPassInputAttachmentAspectCreateInfo*)HeapUtil.Allocate<Interop.RenderPassInputAttachmentAspectCreateInfo>();
                    renderPassInputAttachmentAspectCreateInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkRenderPassCreateInfoNextPointer;
                    vkRenderPassCreateInfoNextPointer = extensionPointer;
                }
                if (renderPassFragmentDensityMapCreateInfoExt != null)
                {
                    var extensionPointer = default(Interop.Multivendor.RenderPassFragmentDensityMapCreateInfo*);
                    extensionPointer = (Interop.Multivendor.RenderPassFragmentDensityMapCreateInfo*)HeapUtil.Allocate<Interop.Multivendor.RenderPassFragmentDensityMapCreateInfo>();
                    renderPassFragmentDensityMapCreateInfoExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkRenderPassCreateInfoNextPointer;
                    vkRenderPassCreateInfoNextPointer = extensionPointer;
                }
                marshalledCreateInfo = (Interop.RenderPassCreateInfo*)HeapUtil.Allocate<Interop.RenderPassCreateInfo>();
                marshalledCreateInfo->SType = StructureType.RenderPassCreateInfo;
                marshalledCreateInfo->Next = vkRenderPassCreateInfoNextPointer;
                if (flags != null)
                    marshalledCreateInfo->Flags = flags.Value;
                else
                    marshalledCreateInfo->Flags = default;
                marshalledCreateInfo->AttachmentCount = HeapUtil.GetLength(attachments);
                if (attachments.IsNull())
                {
                    marshalledCreateInfo->Attachments = null;
                }
                else
                {
                    if (attachments.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfo->Attachments = (AttachmentDescription*)HeapUtil.Allocate<AttachmentDescription>();
                        *marshalledCreateInfo->Attachments = attachments.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (AttachmentDescription*)HeapUtil.AllocateAndClear<AttachmentDescription>(HeapUtil.GetLength(attachments.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(attachments.Value); index++) fieldPointer[index] = attachments.Value[index];
                        marshalledCreateInfo->Attachments = fieldPointer;
                    }
                }
                marshalledCreateInfo->SubpassCount = HeapUtil.GetLength(subpasses);
                if (subpasses.IsNull())
                {
                    marshalledCreateInfo->Subpasses = null;
                }
                else
                {
                    if (subpasses.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfo->Subpasses = (Interop.SubpassDescription*)HeapUtil.Allocate<Interop.SubpassDescription>();
                        subpasses.Value.GetSingleValue().MarshalTo(&*marshalledCreateInfo->Subpasses);
                    }
                    else
                    {
                        var fieldPointer = (Interop.SubpassDescription*)HeapUtil.AllocateAndClear<Interop.SubpassDescription>(HeapUtil.GetLength(subpasses.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(subpasses.Value); index++) subpasses.Value[index].MarshalTo(&fieldPointer[index]);
                        marshalledCreateInfo->Subpasses = fieldPointer;
                    }
                }
                marshalledCreateInfo->DependencyCount = HeapUtil.GetLength(dependencies);
                if (dependencies.IsNull())
                {
                    marshalledCreateInfo->Dependencies = null;
                }
                else
                {
                    if (dependencies.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfo->Dependencies = (SubpassDependency*)HeapUtil.Allocate<SubpassDependency>();
                        *marshalledCreateInfo->Dependencies = dependencies.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (SubpassDependency*)HeapUtil.AllocateAndClear<SubpassDependency>(HeapUtil.GetLength(dependencies.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(dependencies.Value); index++) fieldPointer[index] = dependencies.Value[index];
                        marshalledCreateInfo->Dependencies = fieldPointer;
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
                var commandDelegate = CommandCache.Cache.VkCreateRenderPass;
                var methodResult = commandDelegate(Handle, marshalledCreateInfo, marshalledAllocator, &marshalledRenderPass);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                result = new(this, marshalledRenderPass);
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Create a new command pool object.
        /// </summary>
        /// <param name="flags">
        ///     A bitmask indicating usage behavior for the pool and command
        ///     buffers allocated from it. Bits which can be set include: + --
        /// </param>
        /// <param name="queueFamilyIndex">
        /// </param>
        /// <param name="allocator">
        ///     An optional AllocationCallbacks instance that controls host memory
        ///     allocation.
        /// </param>
        public unsafe CommandPool CreateCommandPool(uint queueFamilyIndex, CommandPoolCreateFlags? flags = default, AllocationCallbacks? allocator = default)
        {
            try
            {
                var result = default(CommandPool);
                var marshalledCreateInfo = default(Interop.CommandPoolCreateInfo*);
                var vkCommandPoolCreateInfoNextPointer = default(void*);
                var marshalledAllocator = default(Interop.AllocationCallbacks*);
                var marshalledCommandPool = default(Interop.CommandPool);
                marshalledCreateInfo = (Interop.CommandPoolCreateInfo*)HeapUtil.Allocate<Interop.CommandPoolCreateInfo>();
                marshalledCreateInfo->SType = StructureType.CommandPoolCreateInfo;
                marshalledCreateInfo->Next = vkCommandPoolCreateInfoNextPointer;
                if (flags != null)
                    marshalledCreateInfo->Flags = flags.Value;
                else
                    marshalledCreateInfo->Flags = default;
                marshalledCreateInfo->QueueFamilyIndex = queueFamilyIndex;
                if (allocator != null)
                {
                    marshalledAllocator = (Interop.AllocationCallbacks*)HeapUtil.Allocate<Interop.AllocationCallbacks>();
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default;
                }
                var commandDelegate = CommandCache.Cache.VkCreateCommandPool;
                var methodResult = commandDelegate(Handle, marshalledCreateInfo, marshalledAllocator, &marshalledCommandPool);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                result = new(this, marshalledCommandPool);
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Allocate command buffers from an existing command pool.
        /// </summary>
        /// <param name="commandPool">
        ///     The command pool from which the command buffers are allocated.
        /// </param>
        /// <param name="level">
        ///     level determines whether the command buffers are primary or
        ///     secondary command buffers. Possible values include: + --
        /// </param>
        /// <param name="commandBufferCount">
        /// </param>
        public unsafe CommandBuffer[] AllocateCommandBuffers(CommandPool commandPool, CommandBufferLevel level, uint commandBufferCount)
        {
            try
            {
                var result = default(CommandBuffer[]);
                var marshalledAllocateInfo = default(Interop.CommandBufferAllocateInfo*);
                var vkCommandBufferAllocateInfoNextPointer = default(void*);
                var marshalledCommandBuffers = default(Interop.CommandBuffer*);
                marshalledAllocateInfo = (Interop.CommandBufferAllocateInfo*)HeapUtil.Allocate<Interop.CommandBufferAllocateInfo>();
                marshalledAllocateInfo->SType = StructureType.CommandBufferAllocateInfo;
                marshalledAllocateInfo->Next = vkCommandBufferAllocateInfoNextPointer;
                marshalledAllocateInfo->CommandPool = commandPool?.Handle ?? default(Interop.CommandPool);
                marshalledAllocateInfo->Level = level;
                marshalledAllocateInfo->CommandBufferCount = commandBufferCount;
                marshalledCommandBuffers = (Interop.CommandBuffer*)HeapUtil.Allocate<Interop.CommandBuffer>(commandBufferCount);
                var commandDelegate = CommandCache.Cache.VkAllocateCommandBuffers;
                var methodResult = commandDelegate(Handle, marshalledAllocateInfo, marshalledCommandBuffers);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                if (marshalledCommandBuffers != null)
                {
                    var fieldPointer = new CommandBuffer[commandBufferCount];
                    for (var index = 0; index < commandBufferCount; index++) fieldPointer[index] = new(commandPool, marshalledCommandBuffers[index]);
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
        ///     Allocate command buffers from an existing command pool.
        /// </summary>
        /// <param name="commandPool">
        ///     The command pool from which the command buffers are allocated.
        /// </param>
        /// <param name="level">
        ///     level determines whether the command buffers are primary or
        ///     secondary command buffers. Possible values include: + --
        /// </param>
        public unsafe CommandBuffer AllocateCommandBuffer(CommandPool commandPool, CommandBufferLevel level)
        {
            try
            {
                var result = default(CommandBuffer);
                var marshalledAllocateInfo = default(Interop.CommandBufferAllocateInfo*);
                var vkCommandBufferAllocateInfoNextPointer = default(void*);
                var marshalledCommandBuffers = default(Interop.CommandBuffer*);
                marshalledAllocateInfo = (Interop.CommandBufferAllocateInfo*)HeapUtil.Allocate<Interop.CommandBufferAllocateInfo>();
                marshalledAllocateInfo->SType = StructureType.CommandBufferAllocateInfo;
                marshalledAllocateInfo->Next = vkCommandBufferAllocateInfoNextPointer;
                marshalledAllocateInfo->CommandPool = commandPool?.Handle ?? default(Interop.CommandPool);
                marshalledAllocateInfo->Level = level;
                marshalledAllocateInfo->CommandBufferCount = 1;
                marshalledCommandBuffers = (Interop.CommandBuffer*)HeapUtil.Allocate<Interop.CommandBuffer>(1);
                var commandDelegate = CommandCache.Cache.VkAllocateCommandBuffers;
                var methodResult = commandDelegate(Handle, marshalledAllocateInfo, marshalledCommandBuffers);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                result = new(commandPool, *marshalledCommandBuffers);
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="bindInfos">
        /// </param>
        public unsafe void BindBufferMemory2(ArrayProxy<BindBufferMemoryInfo>? bindInfos)
        {
            try
            {
                var marshalledBindInfos = default(Interop.BindBufferMemoryInfo*);
                if (bindInfos.IsNull())
                {
                    marshalledBindInfos = null;
                }
                else
                {
                    if (bindInfos.Value.Contents == ProxyContents.Single)
                    {
                        marshalledBindInfos = (Interop.BindBufferMemoryInfo*)HeapUtil.Allocate<Interop.BindBufferMemoryInfo>();
                        bindInfos.Value.GetSingleValue().MarshalTo(&*marshalledBindInfos);
                    }
                    else
                    {
                        var fieldPointer = (Interop.BindBufferMemoryInfo*)HeapUtil.AllocateAndClear<Interop.BindBufferMemoryInfo>(HeapUtil.GetLength(bindInfos.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(bindInfos.Value); index++) bindInfos.Value[index].MarshalTo(&fieldPointer[index]);
                        marshalledBindInfos = fieldPointer;
                    }
                }
                var commandDelegate = CommandCache.Cache.VkBindBufferMemory2;
                var methodResult = commandDelegate(Handle, HeapUtil.GetLength(bindInfos), marshalledBindInfos);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="bindInfos">
        /// </param>
        public unsafe void BindImageMemory2(ArrayProxy<BindImageMemoryInfo>? bindInfos)
        {
            try
            {
                var marshalledBindInfos = default(Interop.BindImageMemoryInfo*);
                if (bindInfos.IsNull())
                {
                    marshalledBindInfos = null;
                }
                else
                {
                    if (bindInfos.Value.Contents == ProxyContents.Single)
                    {
                        marshalledBindInfos = (Interop.BindImageMemoryInfo*)HeapUtil.Allocate<Interop.BindImageMemoryInfo>();
                        bindInfos.Value.GetSingleValue().MarshalTo(&*marshalledBindInfos);
                    }
                    else
                    {
                        var fieldPointer = (Interop.BindImageMemoryInfo*)HeapUtil.AllocateAndClear<Interop.BindImageMemoryInfo>(HeapUtil.GetLength(bindInfos.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(bindInfos.Value); index++) bindInfos.Value[index].MarshalTo(&fieldPointer[index]);
                        marshalledBindInfos = fieldPointer;
                    }
                }
                var commandDelegate = CommandCache.Cache.VkBindImageMemory2;
                var methodResult = commandDelegate(Handle, HeapUtil.GetLength(bindInfos), marshalledBindInfos);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="heapIndex">
        /// </param>
        /// <param name="localDeviceIndex">
        /// </param>
        /// <param name="remoteDeviceIndex">
        /// </param>
        public unsafe PeerMemoryFeatureFlags GetGroupPeerMemoryFeatures(uint heapIndex, uint localDeviceIndex, uint remoteDeviceIndex)
        {
            try
            {
                var result = default(PeerMemoryFeatureFlags);
                var marshalledPeerMemoryFeatures = default(PeerMemoryFeatureFlags);
                var commandDelegate = CommandCache.Cache.VkGetDeviceGroupPeerMemoryFeatures;
                commandDelegate(Handle, heapIndex, localDeviceIndex, remoteDeviceIndex, &marshalledPeerMemoryFeatures);
                result = marshalledPeerMemoryFeatures;
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="info">
        /// </param>
        public unsafe MemoryRequirements2 GetImageMemoryRequirements2(ImageMemoryRequirementsInfo2 info)
        {
            try
            {
                var result = default(MemoryRequirements2);
                var marshalledInfo = default(Interop.ImageMemoryRequirementsInfo2*);
                var marshalledMemoryRequirements = default(Interop.MemoryRequirements2);
                marshalledInfo = (Interop.ImageMemoryRequirementsInfo2*)HeapUtil.Allocate<Interop.ImageMemoryRequirementsInfo2>();
                info.MarshalTo(marshalledInfo);
                var commandDelegate = CommandCache.Cache.VkGetImageMemoryRequirements2;
                commandDelegate(Handle, marshalledInfo, &marshalledMemoryRequirements);
                result = MemoryRequirements2.MarshalFrom(&marshalledMemoryRequirements);
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="info">
        /// </param>
        public unsafe MemoryRequirements2 GetBufferMemoryRequirements2(BufferMemoryRequirementsInfo2 info)
        {
            try
            {
                var result = default(MemoryRequirements2);
                var marshalledInfo = default(Interop.BufferMemoryRequirementsInfo2*);
                var marshalledMemoryRequirements = default(Interop.MemoryRequirements2);
                marshalledInfo = (Interop.BufferMemoryRequirementsInfo2*)HeapUtil.Allocate<Interop.BufferMemoryRequirementsInfo2>();
                info.MarshalTo(marshalledInfo);
                var commandDelegate = CommandCache.Cache.VkGetBufferMemoryRequirements2;
                commandDelegate(Handle, marshalledInfo, &marshalledMemoryRequirements);
                result = MemoryRequirements2.MarshalFrom(&marshalledMemoryRequirements);
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="info">
        /// </param>
        public unsafe SparseImageMemoryRequirements2[] GetImageSparseMemoryRequirements2(ImageSparseMemoryRequirementsInfo2 info)
        {
            try
            {
                var result = default(SparseImageMemoryRequirements2[]);
                var marshalledSparseMemoryRequirementCount = default(uint);
                var marshalledInfo = default(Interop.ImageSparseMemoryRequirementsInfo2*);
                var marshalledSparseMemoryRequirements = default(Interop.SparseImageMemoryRequirements2*);
                marshalledInfo = (Interop.ImageSparseMemoryRequirementsInfo2*)HeapUtil.Allocate<Interop.ImageSparseMemoryRequirementsInfo2>();
                info.MarshalTo(marshalledInfo);
                var commandDelegate = CommandCache.Cache.VkGetImageSparseMemoryRequirements2;
                commandDelegate(Handle, marshalledInfo, &marshalledSparseMemoryRequirementCount, marshalledSparseMemoryRequirements);
                marshalledSparseMemoryRequirements = (Interop.SparseImageMemoryRequirements2*)HeapUtil.Allocate<Interop.SparseImageMemoryRequirements2>(marshalledSparseMemoryRequirementCount);
                commandDelegate(Handle, marshalledInfo, &marshalledSparseMemoryRequirementCount, marshalledSparseMemoryRequirements);
                if (marshalledSparseMemoryRequirements != null)
                {
                    var fieldPointer = new SparseImageMemoryRequirements2[marshalledSparseMemoryRequirementCount];
                    for (var index = 0; index < marshalledSparseMemoryRequirementCount; index++) fieldPointer[index] = SparseImageMemoryRequirements2.MarshalFrom(&marshalledSparseMemoryRequirements[index]);
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
        /// <param name="queueInfo">
        /// </param>
        public unsafe Queue GetQueue2(DeviceQueueInfo2 queueInfo)
        {
            try
            {
                var result = default(Queue);
                var marshalledQueueInfo = default(Interop.DeviceQueueInfo2*);
                var marshalledQueue = default(Interop.Queue);
                marshalledQueueInfo = (Interop.DeviceQueueInfo2*)HeapUtil.Allocate<Interop.DeviceQueueInfo2>();
                queueInfo.MarshalTo(marshalledQueueInfo);
                var commandDelegate = CommandCache.Cache.VkGetDeviceQueue2;
                commandDelegate(Handle, marshalledQueueInfo, &marshalledQueue);
                result = new(this, marshalledQueue);
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="format">
        /// </param>
        /// <param name="ycbcrModel">
        /// </param>
        /// <param name="ycbcrRange">
        /// </param>
        /// <param name="components">
        /// </param>
        /// <param name="xChromaOffset">
        /// </param>
        /// <param name="yChromaOffset">
        /// </param>
        /// <param name="chromaFilter">
        /// </param>
        /// <param name="forceExplicitReconstruction">
        /// </param>
        /// <param name="externalFormatAndroid">
        ///     Extension struct
        /// </param>
        /// <param name="allocator">
        /// </param>
        public unsafe SamplerYcbcrConversion CreateSamplerYcbcrConversion(Format format, SamplerYcbcrModelConversion ycbcrModel, SamplerYcbcrRange ycbcrRange, ComponentMapping components, ChromaLocation xChromaOffset, ChromaLocation yChromaOffset, Filter chromaFilter, bool forceExplicitReconstruction, ExternalFormat? externalFormatAndroid = null, AllocationCallbacks? allocator = default)
        {
            try
            {
                var result = default(SamplerYcbcrConversion);
                var marshalledCreateInfo = default(Interop.SamplerYcbcrConversionCreateInfo*);
                var vkSamplerYcbcrConversionCreateInfoNextPointer = default(void*);
                var marshalledAllocator = default(Interop.AllocationCallbacks*);
                var marshalledYcbcrConversion = default(Interop.SamplerYcbcrConversion);
                if (externalFormatAndroid != null)
                {
                    var extensionPointer = default(Interop.Android.ExternalFormat*);
                    extensionPointer = (Interop.Android.ExternalFormat*)HeapUtil.Allocate<Interop.Android.ExternalFormat>();
                    externalFormatAndroid.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkSamplerYcbcrConversionCreateInfoNextPointer;
                    vkSamplerYcbcrConversionCreateInfoNextPointer = extensionPointer;
                }
                marshalledCreateInfo = (Interop.SamplerYcbcrConversionCreateInfo*)HeapUtil.Allocate<Interop.SamplerYcbcrConversionCreateInfo>();
                marshalledCreateInfo->SType = StructureType.SamplerYcbcrConversionCreateInfoVersion;
                marshalledCreateInfo->Next = vkSamplerYcbcrConversionCreateInfoNextPointer;
                marshalledCreateInfo->Format = format;
                marshalledCreateInfo->YcbcrModel = ycbcrModel;
                marshalledCreateInfo->YcbcrRange = ycbcrRange;
                marshalledCreateInfo->Components = components;
                marshalledCreateInfo->XChromaOffset = xChromaOffset;
                marshalledCreateInfo->YChromaOffset = yChromaOffset;
                marshalledCreateInfo->ChromaFilter = chromaFilter;
                marshalledCreateInfo->ForceExplicitReconstruction = forceExplicitReconstruction;
                if (allocator != null)
                {
                    marshalledAllocator = (Interop.AllocationCallbacks*)HeapUtil.Allocate<Interop.AllocationCallbacks>();
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default;
                }
                var commandDelegate = CommandCache.Cache.VkCreateSamplerYcbcrConversion;
                var methodResult = commandDelegate(Handle, marshalledCreateInfo, marshalledAllocator, &marshalledYcbcrConversion);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                result = new(this, marshalledYcbcrConversion);
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="flags">
        /// </param>
        /// <param name="descriptorUpdateEntries">
        /// </param>
        /// <param name="templateType">
        /// </param>
        /// <param name="descriptorSetLayout">
        /// </param>
        /// <param name="pipelineBindPoint">
        /// </param>
        /// <param name="pipelineLayout">
        /// </param>
        /// <param name="set">
        /// </param>
        /// <param name="allocator">
        /// </param>
        public unsafe DescriptorUpdateTemplate CreateDescriptorUpdateTemplate(ArrayProxy<DescriptorUpdateTemplateEntry>? descriptorUpdateEntries, DescriptorUpdateTemplateType templateType, DescriptorSetLayout descriptorSetLayout, PipelineBindPoint pipelineBindPoint, PipelineLayout pipelineLayout, uint set, DescriptorUpdateTemplateCreateFlags? flags = default, AllocationCallbacks? allocator = default)
        {
            try
            {
                var result = default(DescriptorUpdateTemplate);
                var marshalledCreateInfo = default(Interop.DescriptorUpdateTemplateCreateInfo*);
                var vkDescriptorUpdateTemplateCreateInfoNextPointer = default(void*);
                var marshalledAllocator = default(Interop.AllocationCallbacks*);
                var marshalledDescriptorUpdateTemplate = default(Interop.DescriptorUpdateTemplate);
                marshalledCreateInfo = (Interop.DescriptorUpdateTemplateCreateInfo*)HeapUtil.Allocate<Interop.DescriptorUpdateTemplateCreateInfo>();
                marshalledCreateInfo->SType = StructureType.DescriptorUpdateTemplateCreateInfoVersion;
                marshalledCreateInfo->Next = vkDescriptorUpdateTemplateCreateInfoNextPointer;
                if (flags != null)
                    marshalledCreateInfo->Flags = flags.Value;
                else
                    marshalledCreateInfo->Flags = default;
                marshalledCreateInfo->DescriptorUpdateEntryCount = HeapUtil.GetLength(descriptorUpdateEntries);
                if (descriptorUpdateEntries.IsNull())
                {
                    marshalledCreateInfo->DescriptorUpdateEntries = null;
                }
                else
                {
                    if (descriptorUpdateEntries.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfo->DescriptorUpdateEntries = (DescriptorUpdateTemplateEntry*)HeapUtil.Allocate<DescriptorUpdateTemplateEntry>();
                        *marshalledCreateInfo->DescriptorUpdateEntries = descriptorUpdateEntries.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (DescriptorUpdateTemplateEntry*)HeapUtil.AllocateAndClear<DescriptorUpdateTemplateEntry>(HeapUtil.GetLength(descriptorUpdateEntries.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(descriptorUpdateEntries.Value); index++) fieldPointer[index] = descriptorUpdateEntries.Value[index];
                        marshalledCreateInfo->DescriptorUpdateEntries = fieldPointer;
                    }
                }
                marshalledCreateInfo->TemplateType = templateType;
                marshalledCreateInfo->DescriptorSetLayout = descriptorSetLayout?.Handle ?? default(Interop.DescriptorSetLayout);
                marshalledCreateInfo->PipelineBindPoint = pipelineBindPoint;
                marshalledCreateInfo->PipelineLayout = pipelineLayout?.Handle ?? default(Interop.PipelineLayout);
                marshalledCreateInfo->Set = set;
                if (allocator != null)
                {
                    marshalledAllocator = (Interop.AllocationCallbacks*)HeapUtil.Allocate<Interop.AllocationCallbacks>();
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default;
                }
                var commandDelegate = CommandCache.Cache.VkCreateDescriptorUpdateTemplate;
                var methodResult = commandDelegate(Handle, marshalledCreateInfo, marshalledAllocator, &marshalledDescriptorUpdateTemplate);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                result = new(this, marshalledDescriptorUpdateTemplate);
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="descriptorSet">
        /// </param>
        /// <param name="descriptorUpdateTemplate">
        /// </param>
        /// <param name="data">
        /// </param>
        public unsafe void UpdateDescriptorSetWithTemplate(DescriptorSet descriptorSet, DescriptorUpdateTemplate descriptorUpdateTemplate, IntPtr data)
        {
            try
            {
                var commandDelegate = CommandCache.Cache.VkUpdateDescriptorSetWithTemplate;
                commandDelegate(Handle, descriptorSet?.Handle ?? default(Interop.DescriptorSet), descriptorUpdateTemplate?.Handle ?? default(Interop.DescriptorUpdateTemplate), data.ToPointer());
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="createInfo">
        /// </param>
        public unsafe DescriptorSetLayoutSupport GetDescriptorSetLayoutSupport(DescriptorSetLayoutCreateInfo createInfo)
        {
            try
            {
                var result = default(DescriptorSetLayoutSupport);
                var marshalledCreateInfo = default(Interop.DescriptorSetLayoutCreateInfo*);
                var marshalledSupport = default(Interop.DescriptorSetLayoutSupport);
                marshalledCreateInfo = (Interop.DescriptorSetLayoutCreateInfo*)HeapUtil.Allocate<Interop.DescriptorSetLayoutCreateInfo>();
                createInfo.MarshalTo(marshalledCreateInfo);
                var commandDelegate = CommandCache.Cache.VkGetDescriptorSetLayoutSupport;
                commandDelegate(Handle, marshalledCreateInfo, &marshalledSupport);
                result = DescriptorSetLayoutSupport.MarshalFrom(&marshalledSupport);
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="createInfo">
        /// </param>
        /// <param name="allocator">
        /// </param>
        public unsafe RenderPass CreateRenderPass2(RenderPassCreateInfo2 createInfo, AllocationCallbacks? allocator = default)
        {
            try
            {
                var result = default(RenderPass);
                var marshalledCreateInfo = default(Interop.RenderPassCreateInfo2*);
                var marshalledAllocator = default(Interop.AllocationCallbacks*);
                var marshalledRenderPass = default(Interop.RenderPass);
                marshalledCreateInfo = (Interop.RenderPassCreateInfo2*)HeapUtil.Allocate<Interop.RenderPassCreateInfo2>();
                createInfo.MarshalTo(marshalledCreateInfo);
                if (allocator != null)
                {
                    marshalledAllocator = (Interop.AllocationCallbacks*)HeapUtil.Allocate<Interop.AllocationCallbacks>();
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default;
                }
                var commandDelegate = CommandCache.Cache.VkCreateRenderPass2;
                var methodResult = commandDelegate(Handle, marshalledCreateInfo, marshalledAllocator, &marshalledRenderPass);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                result = new(this, marshalledRenderPass);
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="flags">
        /// </param>
        /// <param name="semaphores">
        /// </param>
        /// <param name="values">
        /// </param>
        /// <param name="timeout">
        /// </param>
        public unsafe Result WaitSemaphores(ArrayProxy<Semaphore>? semaphores, ArrayProxy<ulong>? values, ulong timeout, SemaphoreWaitFlags? flags = default)
        {
            try
            {
                var result = default(Result);
                var marshalledWaitInfo = default(Interop.SemaphoreWaitInfo*);
                var vkSemaphoreWaitInfoNextPointer = default(void*);
                marshalledWaitInfo = (Interop.SemaphoreWaitInfo*)HeapUtil.Allocate<Interop.SemaphoreWaitInfo>();
                marshalledWaitInfo->SType = StructureType.SemaphoreWaitInfoVersion;
                marshalledWaitInfo->Next = vkSemaphoreWaitInfoNextPointer;
                if (flags != null)
                    marshalledWaitInfo->Flags = flags.Value;
                else
                    marshalledWaitInfo->Flags = default;
                marshalledWaitInfo->SemaphoreCount = HeapUtil.GetLength(semaphores);
                if (semaphores.IsNull())
                {
                    marshalledWaitInfo->Semaphores = null;
                }
                else
                {
                    if (semaphores.Value.Contents == ProxyContents.Single)
                    {
                        marshalledWaitInfo->Semaphores = (Interop.Semaphore*)HeapUtil.Allocate<Interop.Semaphore>();
                        *marshalledWaitInfo->Semaphores = semaphores.Value.GetSingleValue()?.Handle ?? default(Interop.Semaphore);
                    }
                    else
                    {
                        var fieldPointer = (Interop.Semaphore*)HeapUtil.AllocateAndClear<Interop.Semaphore>(HeapUtil.GetLength(semaphores.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(semaphores.Value); index++) fieldPointer[index] = semaphores.Value[index]?.Handle ?? default(Interop.Semaphore);
                        marshalledWaitInfo->Semaphores = fieldPointer;
                    }
                }
                if (values.IsNull())
                {
                    marshalledWaitInfo->Values = null;
                }
                else
                {
                    if (values.Value.Contents == ProxyContents.Single)
                    {
                        marshalledWaitInfo->Values = (ulong*)HeapUtil.Allocate<ulong>();
                        *marshalledWaitInfo->Values = values.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (ulong*)HeapUtil.AllocateAndClear<ulong>(HeapUtil.GetLength(values.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(values.Value); index++) fieldPointer[index] = values.Value[index];
                        marshalledWaitInfo->Values = fieldPointer;
                    }
                }
                var commandDelegate = CommandCache.Cache.VkWaitSemaphores;
                result = commandDelegate(Handle, marshalledWaitInfo, timeout);
                if (SharpVkException.IsError(result)) throw SharpVkException.Create(result);
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="semaphore">
        /// </param>
        /// <param name="value">
        /// </param>
        public unsafe void SignalSemaphore(Semaphore semaphore, ulong value)
        {
            try
            {
                var marshalledSignalInfo = default(Interop.SemaphoreSignalInfo*);
                var vkSemaphoreSignalInfoNextPointer = default(void*);
                marshalledSignalInfo = (Interop.SemaphoreSignalInfo*)HeapUtil.Allocate<Interop.SemaphoreSignalInfo>();
                marshalledSignalInfo->SType = StructureType.SemaphoreSignalInfoVersion;
                marshalledSignalInfo->Next = vkSemaphoreSignalInfoNextPointer;
                marshalledSignalInfo->Semaphore = semaphore?.Handle ?? default(Interop.Semaphore);
                marshalledSignalInfo->Value = value;
                var commandDelegate = CommandCache.Cache.VkSignalSemaphore;
                var methodResult = commandDelegate(Handle, marshalledSignalInfo);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="info">
        /// </param>
        public unsafe void GetBufferDeviceAddress(BufferDeviceAddressInfo info)
        {
            try
            {
                var marshalledInfo = default(Interop.BufferDeviceAddressInfo*);
                marshalledInfo = (Interop.BufferDeviceAddressInfo*)HeapUtil.Allocate<Interop.BufferDeviceAddressInfo>();
                info.MarshalTo(marshalledInfo);
                var commandDelegate = CommandCache.Cache.VkGetBufferDeviceAddress;
                commandDelegate(Handle, marshalledInfo);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="info">
        /// </param>
        public unsafe void GetBufferOpaqueCaptureAddress(BufferDeviceAddressInfo info)
        {
            try
            {
                var marshalledInfo = default(Interop.BufferDeviceAddressInfo*);
                marshalledInfo = (Interop.BufferDeviceAddressInfo*)HeapUtil.Allocate<Interop.BufferDeviceAddressInfo>();
                info.MarshalTo(marshalledInfo);
                var commandDelegate = CommandCache.Cache.VkGetBufferOpaqueCaptureAddress;
                commandDelegate(Handle, marshalledInfo);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="info">
        /// </param>
        public unsafe void GetMemoryOpaqueCaptureAddress(DeviceMemoryOpaqueCaptureAddressInfo info)
        {
            try
            {
                var marshalledInfo = default(Interop.DeviceMemoryOpaqueCaptureAddressInfo*);
                marshalledInfo = (Interop.DeviceMemoryOpaqueCaptureAddressInfo*)HeapUtil.Allocate<Interop.DeviceMemoryOpaqueCaptureAddressInfo>();
                info.MarshalTo(marshalledInfo);
                var commandDelegate = CommandCache.Cache.VkGetDeviceMemoryOpaqueCaptureAddress;
                commandDelegate(Handle, marshalledInfo);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }
    }
}
