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
using SharpVk.Multivendor;

namespace SharpVk.NVidia
{
    /// <summary>
    /// </summary>
    public static class DeviceExtensions
    {
        /// <summary>
        /// </summary>
        /// <param name="extendedHandle">
        ///     The Device handle to extend.
        /// </param>
        /// <param name="compactedSize">
        /// </param>
        /// <param name="info">
        /// </param>
        /// <param name="allocator">
        /// </param>
        public static unsafe AccelerationStructure CreateAccelerationStructure(this Device extendedHandle, ulong compactedSize, AccelerationStructureInfo info, AllocationCallbacks? allocator = default)
        {
            try
            {
                var result = default(AccelerationStructure);
                var commandCache = default(CommandCache);
                var marshalledCreateInfo = default(Interop.NVidia.AccelerationStructureCreateInfo*);
                var vkAccelerationStructureCreateInfoNVNextPointer = default(void*);
                var marshalledAllocator = default(Interop.AllocationCallbacks*);
                var marshalledAccelerationStructure = default(Interop.NVidia.AccelerationStructure);
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfo = (Interop.NVidia.AccelerationStructureCreateInfo*)HeapUtil.Allocate<Interop.NVidia.AccelerationStructureCreateInfo>();
                marshalledCreateInfo->SType = StructureType.AccelerationStructureCreateInfo;
                marshalledCreateInfo->Next = vkAccelerationStructureCreateInfoNVNextPointer;
                marshalledCreateInfo->CompactedSize = compactedSize;
                info.MarshalTo(&marshalledCreateInfo->Info);
                if (allocator != null)
                {
                    marshalledAllocator = (Interop.AllocationCallbacks*)HeapUtil.Allocate<Interop.AllocationCallbacks>();
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default;
                }
                var commandDelegate = commandCache.Cache.vkCreateAccelerationStructureNV;
                var methodResult = commandDelegate(extendedHandle.handle, marshalledCreateInfo, marshalledAllocator, &marshalledAccelerationStructure);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                result = new(extendedHandle, marshalledAccelerationStructure);
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
        public static unsafe MemoryRequirements2 GetAccelerationStructureMemoryRequirements(this Device extendedHandle, AccelerationStructureMemoryRequirementsInfo info)
        {
            try
            {
                var result = default(MemoryRequirements2);
                var commandCache = default(CommandCache);
                var marshalledInfo = default(Interop.NVidia.AccelerationStructureMemoryRequirementsInfo*);
                var marshalledMemoryRequirements = default(Interop.MemoryRequirements2);
                commandCache = extendedHandle.commandCache;
                marshalledInfo = (Interop.NVidia.AccelerationStructureMemoryRequirementsInfo*)HeapUtil.Allocate<Interop.NVidia.AccelerationStructureMemoryRequirementsInfo>();
                info.MarshalTo(marshalledInfo);
                var commandDelegate = commandCache.Cache.vkGetAccelerationStructureMemoryRequirementsNV;
                commandDelegate(extendedHandle.handle, marshalledInfo, &marshalledMemoryRequirements);
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
        /// <param name="extendedHandle">
        ///     The Device handle to extend.
        /// </param>
        /// <param name="bindInfos">
        /// </param>
        public static unsafe void BindAccelerationStructureMemory(this Device extendedHandle, ArrayProxy<BindAccelerationStructureMemoryInfo>? bindInfos)
        {
            try
            {
                var commandCache = default(CommandCache);
                var marshalledBindInfos = default(Interop.NVidia.BindAccelerationStructureMemoryInfo*);
                commandCache = extendedHandle.commandCache;
                if (bindInfos.IsNull())
                {
                    marshalledBindInfos = null;
                }
                else
                {
                    if (bindInfos.Value.Contents == ProxyContents.Single)
                    {
                        marshalledBindInfos = (Interop.NVidia.BindAccelerationStructureMemoryInfo*)HeapUtil.Allocate<Interop.NVidia.BindAccelerationStructureMemoryInfo>();
                        bindInfos.Value.GetSingleValue().MarshalTo(&*marshalledBindInfos);
                    }
                    else
                    {
                        var fieldPointer = (Interop.NVidia.BindAccelerationStructureMemoryInfo*)HeapUtil.AllocateAndClear<Interop.NVidia.BindAccelerationStructureMemoryInfo>(HeapUtil.GetLength(bindInfos.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(bindInfos.Value); index++) bindInfos.Value[index].MarshalTo(&fieldPointer[index]);
                        marshalledBindInfos = fieldPointer;
                    }
                }
                var commandDelegate = commandCache.Cache.vkBindAccelerationStructureMemoryNV;
                var methodResult = commandDelegate(extendedHandle.handle, HeapUtil.GetLength(bindInfos), marshalledBindInfos);
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
        /// <param name="pipelineCache">
        /// </param>
        /// <param name="createInfos">
        /// </param>
        /// <param name="allocator">
        /// </param>
        public static unsafe Pipeline[] CreateRayTracingPipelines(this Device extendedHandle, PipelineCache pipelineCache, ArrayProxy<RayTracingPipelineCreateInfo>? createInfos, AllocationCallbacks? allocator = default)
        {
            try
            {
                var result = default(Pipeline[]);
                var commandCache = default(CommandCache);
                var marshalledCreateInfoCount = default(uint);
                var marshalledCreateInfos = default(Interop.NVidia.RayTracingPipelineCreateInfo*);
                var marshalledAllocator = default(Interop.AllocationCallbacks*);
                var marshalledPipelines = default(Interop.Pipeline*);
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfoCount = HeapUtil.GetLength(createInfos);
                if (createInfos.IsNull())
                {
                    marshalledCreateInfos = null;
                }
                else
                {
                    if (createInfos.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfos = (Interop.NVidia.RayTracingPipelineCreateInfo*)HeapUtil.Allocate<Interop.NVidia.RayTracingPipelineCreateInfo>();
                        createInfos.Value.GetSingleValue().MarshalTo(&*marshalledCreateInfos);
                    }
                    else
                    {
                        var fieldPointer = (Interop.NVidia.RayTracingPipelineCreateInfo*)HeapUtil.AllocateAndClear<Interop.NVidia.RayTracingPipelineCreateInfo>(HeapUtil.GetLength(createInfos.Value)).ToPointer();
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
                var commandDelegate = commandCache.Cache.vkCreateRayTracingPipelinesNV;
                var methodResult = commandDelegate(extendedHandle.handle, pipelineCache?.handle ?? default(Interop.PipelineCache), marshalledCreateInfoCount, marshalledCreateInfos, marshalledAllocator, marshalledPipelines);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                if (marshalledPipelines != null)
                {
                    var fieldPointer = new Pipeline[marshalledCreateInfoCount];
                    for (var index = 0; index < marshalledCreateInfoCount; index++) fieldPointer[index] = new(extendedHandle, marshalledPipelines[index]);
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
        /// <param name="pipelineCache">
        /// </param>
        /// <param name="flags">
        /// </param>
        /// <param name="stages">
        /// </param>
        /// <param name="groups">
        /// </param>
        /// <param name="maxRecursionDepth">
        /// </param>
        /// <param name="layout">
        /// </param>
        /// <param name="basePipelineHandle">
        /// </param>
        /// <param name="basePipelineIndex">
        /// </param>
        /// <param name="pipelineCreationFeedbackCreateInfoExt">
        ///     Extension struct
        /// </param>
        /// <param name="allocator">
        /// </param>
        public static unsafe Pipeline CreateRayTracingPipeline(this Device extendedHandle, PipelineCache pipelineCache, ArrayProxy<PipelineShaderStageCreateInfo>? stages, ArrayProxy<RayTracingShaderGroupCreateInfo>? groups, uint maxRecursionDepth, PipelineLayout layout, Pipeline basePipelineHandle, int basePipelineIndex, PipelineCreateFlags? flags = default, PipelineCreationFeedbackCreateInfo? pipelineCreationFeedbackCreateInfoExt = null, AllocationCallbacks? allocator = default)
        {
            try
            {
                var result = default(Pipeline);
                var commandCache = default(CommandCache);
                var marshalledCreateInfoCount = default(uint);
                var marshalledCreateInfos = default(Interop.NVidia.RayTracingPipelineCreateInfo*);
                var vkRayTracingPipelineCreateInfoNVNextPointer = default(void*);
                var marshalledAllocator = default(Interop.AllocationCallbacks*);
                var marshalledPipelines = default(Interop.Pipeline*);
                if (pipelineCreationFeedbackCreateInfoExt != null)
                {
                    var extensionPointer = default(Interop.Multivendor.PipelineCreationFeedbackCreateInfo*);
                    extensionPointer = (Interop.Multivendor.PipelineCreationFeedbackCreateInfo*)HeapUtil.Allocate<Interop.Multivendor.PipelineCreationFeedbackCreateInfo>();
                    pipelineCreationFeedbackCreateInfoExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkRayTracingPipelineCreateInfoNVNextPointer;
                    vkRayTracingPipelineCreateInfoNVNextPointer = extensionPointer;
                }
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfoCount = 1;
                marshalledCreateInfos = (Interop.NVidia.RayTracingPipelineCreateInfo*)HeapUtil.Allocate<Interop.NVidia.RayTracingPipelineCreateInfo>();
                marshalledCreateInfos->SType = StructureType.RayTracingPipelineCreateInfo;
                marshalledCreateInfos->Next = vkRayTracingPipelineCreateInfoNVNextPointer;
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
                marshalledCreateInfos->GroupCount = HeapUtil.GetLength(groups);
                if (groups.IsNull())
                {
                    marshalledCreateInfos->Groups = null;
                }
                else
                {
                    if (groups.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfos->Groups = (Interop.NVidia.RayTracingShaderGroupCreateInfo*)HeapUtil.Allocate<Interop.NVidia.RayTracingShaderGroupCreateInfo>();
                        groups.Value.GetSingleValue().MarshalTo(&*marshalledCreateInfos->Groups);
                    }
                    else
                    {
                        var fieldPointer = (Interop.NVidia.RayTracingShaderGroupCreateInfo*)HeapUtil.AllocateAndClear<Interop.NVidia.RayTracingShaderGroupCreateInfo>(HeapUtil.GetLength(groups.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(groups.Value); index++) groups.Value[index].MarshalTo(&fieldPointer[index]);
                        marshalledCreateInfos->Groups = fieldPointer;
                    }
                }
                marshalledCreateInfos->MaxRecursionDepth = maxRecursionDepth;
                marshalledCreateInfos->Layout = layout?.handle ?? default(Interop.PipelineLayout);
                marshalledCreateInfos->BasePipelineHandle = basePipelineHandle?.handle ?? default(Interop.Pipeline);
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
                var commandDelegate = commandCache.Cache.vkCreateRayTracingPipelinesNV;
                var methodResult = commandDelegate(extendedHandle.handle, pipelineCache?.handle ?? default(Interop.PipelineCache), marshalledCreateInfoCount, marshalledCreateInfos, marshalledAllocator, marshalledPipelines);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                result = new(extendedHandle, *marshalledPipelines);
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }
    }
}