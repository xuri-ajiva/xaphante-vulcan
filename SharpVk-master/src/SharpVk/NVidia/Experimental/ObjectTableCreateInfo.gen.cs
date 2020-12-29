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

using System.Runtime.InteropServices;
using SharpVk.Interop;

namespace SharpVk.NVidia.Experimental
{
    /// <summary>
    ///     Structure specifying the parameters of a newly created object table.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct ObjectTableCreateInfo
    {
        /// <summary>
        ///     An array of ObjectEntryTypeNVX providing the entry type of a given
        ///     configuration.
        /// </summary>
        public ObjectEntryType[] ObjectEntryTypes
        {
            get;
            set;
        }

        /// <summary>
        ///     An array of counts how many objects can be registered in the table.
        /// </summary>
        public uint[] ObjectEntryCounts
        {
            get;
            set;
        }

        /// <summary>
        ///     An array of bitmasks describing the binding usage of the entry. See
        ///     ObjectEntryUsageFlagBitsNVX below for a description of the
        ///     supported bits.
        /// </summary>
        public ObjectEntryUsageFlags[] ObjectEntryUsageFlags
        {
            get;
            set;
        }

        /// <summary>
        ///     The maximum number of DescriptorType.UniformBuffer or
        ///     DescriptorType.UniformBufferDynamic used by any single registered
        ///     DescriptorSet in this table.
        /// </summary>
        public uint MaxUniformBuffersPerDescriptor
        {
            get;
            set;
        }

        /// <summary>
        ///     The maximum number of DescriptorType.StorageBuffer or
        ///     DescriptorType.StorageBufferDynamic used by any single registered
        ///     DescriptorSet in this table.
        /// </summary>
        public uint MaxStorageBuffersPerDescriptor
        {
            get;
            set;
        }

        /// <summary>
        ///     The maximum number of DescriptorType.StorageImage or
        ///     DescriptorType.StorageTexelBuffer used by any single registered
        ///     DescriptorSet in this table.
        /// </summary>
        public uint MaxStorageImagesPerDescriptor
        {
            get;
            set;
        }

        /// <summary>
        ///     The maximum number of DescriptorType.Sampler,
        ///     DescriptorType.CombinedImageSampler, DescriptorType.UniformTexelBuffer
        ///     or DescriptorType.InputAttachment used by any single registered
        ///     DescriptorSet in this table.
        /// </summary>
        public uint MaxSampledImagesPerDescriptor
        {
            get;
            set;
        }

        /// <summary>
        ///     The maximum number of unique PipelineLayout used by any registered
        ///     DescriptorSet or Pipeline in this table.
        /// </summary>
        public uint MaxPipelineLayouts
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(Interop.NVidia.Experimental.ObjectTableCreateInfo* pointer)
        {
            pointer->SType = StructureType.ObjectTableCreateInfo;
            pointer->Next = null;
            pointer->ObjectCount = HeapUtil.GetLength(ObjectEntryTypes);
            if (ObjectEntryTypes != null)
            {
                var fieldPointer = (ObjectEntryType*)HeapUtil.AllocateAndClear<ObjectEntryType>(ObjectEntryTypes.Length).ToPointer();
                for (var index = 0; index < (uint)ObjectEntryTypes.Length; index++) fieldPointer[index] = ObjectEntryTypes[index];
                pointer->ObjectEntryTypes = fieldPointer;
            }
            else
            {
                pointer->ObjectEntryTypes = null;
            }
            if (ObjectEntryCounts != null)
            {
                var fieldPointer = (uint*)HeapUtil.AllocateAndClear<uint>(ObjectEntryCounts.Length).ToPointer();
                for (var index = 0; index < (uint)ObjectEntryCounts.Length; index++) fieldPointer[index] = ObjectEntryCounts[index];
                pointer->ObjectEntryCounts = fieldPointer;
            }
            else
            {
                pointer->ObjectEntryCounts = null;
            }
            if (ObjectEntryUsageFlags != null)
            {
                var fieldPointer = (ObjectEntryUsageFlags*)HeapUtil.AllocateAndClear<ObjectEntryUsageFlags>(ObjectEntryUsageFlags.Length).ToPointer();
                for (var index = 0; index < (uint)ObjectEntryUsageFlags.Length; index++) fieldPointer[index] = ObjectEntryUsageFlags[index];
                pointer->ObjectEntryUsageFlags = fieldPointer;
            }
            else
            {
                pointer->ObjectEntryUsageFlags = null;
            }
            pointer->MaxUniformBuffersPerDescriptor = MaxUniformBuffersPerDescriptor;
            pointer->MaxStorageBuffersPerDescriptor = MaxStorageBuffersPerDescriptor;
            pointer->MaxStorageImagesPerDescriptor = MaxStorageImagesPerDescriptor;
            pointer->MaxSampledImagesPerDescriptor = MaxSampledImagesPerDescriptor;
            pointer->MaxPipelineLayouts = MaxPipelineLayouts;
        }
    }
}