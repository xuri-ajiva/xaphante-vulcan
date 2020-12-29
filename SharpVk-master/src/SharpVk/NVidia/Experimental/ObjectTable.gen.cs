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

namespace SharpVk.NVidia.Experimental
{
    /// <summary>
    ///     Opaque handle to an object table.
    /// </summary>
    public class ObjectTable
        : IDisposable
    {
        internal readonly CommandCache commandCache;
        internal readonly Interop.NVidia.Experimental.ObjectTable handle;

        internal readonly Device parent;

        internal ObjectTable(Device parent, Interop.NVidia.Experimental.ObjectTable handle)
        {
            this.handle = handle;
            this.parent = parent;
            commandCache = parent.commandCache;
        }

        /// <summary>
        ///     The raw handle for this instance.
        /// </summary>
        public Interop.NVidia.Experimental.ObjectTable RawHandle => handle;

        /// <summary>
        ///     Destroys the handles and releases any unmanaged resources
        ///     associated with it.
        /// </summary>
        public void Dispose()
        {
            Destroy();
        }

        /// <summary>
        ///     Destroy a object table.
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
                var commandDelegate = commandCache.Cache.vkDestroyObjectTableNVX;
                commandDelegate(parent.handle, handle, marshalledAllocator);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="objectTableEntries">
        /// </param>
        /// <param name="objectIndices">
        /// </param>
        public unsafe void RegisterObjects(ArrayProxy<ObjectTableEntry>? objectTableEntries, ArrayProxy<uint>? objectIndices)
        {
            try
            {
                var marshalledObjectTableEntries = default(ObjectTableEntry**);
                var semiMarshalledObjectTableEntries = default(ObjectTableEntry*);
                var marshalledObjectIndices = default(uint*);
                if (objectTableEntries.IsNull())
                {
                    marshalledObjectTableEntries = null;
                }
                else
                {
                    if (objectTableEntries.Value.Contents == ProxyContents.Single)
                    {
                        semiMarshalledObjectTableEntries = (ObjectTableEntry*)HeapUtil.Allocate<ObjectTableEntry>();
                        *semiMarshalledObjectTableEntries = objectTableEntries.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (ObjectTableEntry*)HeapUtil.AllocateAndClear<ObjectTableEntry>(HeapUtil.GetLength(objectTableEntries.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(objectTableEntries.Value); index++) fieldPointer[index] = objectTableEntries.Value[index];
                        semiMarshalledObjectTableEntries = fieldPointer;
                        var marshalledFieldPointer = (ObjectTableEntry**)HeapUtil.AllocateAndClear<IntPtr>(HeapUtil.GetLength(objectTableEntries.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(objectTableEntries.Value); index++) marshalledFieldPointer[index] = &semiMarshalledObjectTableEntries[index];
                        marshalledObjectTableEntries = marshalledFieldPointer;
                    }
                }
                if (objectIndices.IsNull())
                {
                    marshalledObjectIndices = null;
                }
                else
                {
                    if (objectIndices.Value.Contents == ProxyContents.Single)
                    {
                        marshalledObjectIndices = (uint*)HeapUtil.Allocate<uint>();
                        *marshalledObjectIndices = objectIndices.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (uint*)HeapUtil.AllocateAndClear<uint>(HeapUtil.GetLength(objectIndices.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(objectIndices.Value); index++) fieldPointer[index] = objectIndices.Value[index];
                        marshalledObjectIndices = fieldPointer;
                    }
                }
                var commandDelegate = commandCache.Cache.vkRegisterObjectsNVX;
                var methodResult = commandDelegate(parent.handle, handle, HeapUtil.GetLength(objectTableEntries), marshalledObjectTableEntries, marshalledObjectIndices);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="objectEntryTypes">
        /// </param>
        /// <param name="objectIndices">
        /// </param>
        public unsafe void UnregisterObjects(ArrayProxy<ObjectEntryType>? objectEntryTypes, ArrayProxy<uint>? objectIndices)
        {
            try
            {
                var marshalledObjectEntryTypes = default(ObjectEntryType*);
                var marshalledObjectIndices = default(uint*);
                if (objectEntryTypes.IsNull())
                {
                    marshalledObjectEntryTypes = null;
                }
                else
                {
                    if (objectEntryTypes.Value.Contents == ProxyContents.Single)
                    {
                        marshalledObjectEntryTypes = (ObjectEntryType*)HeapUtil.Allocate<ObjectEntryType>();
                        *marshalledObjectEntryTypes = objectEntryTypes.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (ObjectEntryType*)HeapUtil.AllocateAndClear<ObjectEntryType>(HeapUtil.GetLength(objectEntryTypes.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(objectEntryTypes.Value); index++) fieldPointer[index] = objectEntryTypes.Value[index];
                        marshalledObjectEntryTypes = fieldPointer;
                    }
                }
                if (objectIndices.IsNull())
                {
                    marshalledObjectIndices = null;
                }
                else
                {
                    if (objectIndices.Value.Contents == ProxyContents.Single)
                    {
                        marshalledObjectIndices = (uint*)HeapUtil.Allocate<uint>();
                        *marshalledObjectIndices = objectIndices.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (uint*)HeapUtil.AllocateAndClear<uint>(HeapUtil.GetLength(objectIndices.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(objectIndices.Value); index++) fieldPointer[index] = objectIndices.Value[index];
                        marshalledObjectIndices = fieldPointer;
                    }
                }
                var commandDelegate = commandCache.Cache.vkUnregisterObjectsNVX;
                var methodResult = commandDelegate(parent.handle, handle, HeapUtil.GetLength(objectEntryTypes), marshalledObjectEntryTypes, marshalledObjectIndices);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }
    }
}