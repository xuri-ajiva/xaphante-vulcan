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

namespace SharpVk.NVidia
{
    /// <summary>
    /// </summary>
    public static class PhysicalDeviceExtensions
    {
        /// <summary>
        ///     Determine image capabilities compatible with external memory handle
        ///     types.
        /// </summary>
        /// <param name="extendedHandle">
        ///     The PhysicalDevice handle to extend.
        /// </param>
        /// <param name="format">
        /// </param>
        /// <param name="type">
        /// </param>
        /// <param name="tiling">
        /// </param>
        /// <param name="usage">
        /// </param>
        /// <param name="flags">
        /// </param>
        /// <param name="externalHandleType">
        /// </param>
        public static unsafe ExternalImageFormatProperties GetExternalImageFormatProperties(this PhysicalDevice extendedHandle, Format format, ImageType type, ImageTiling tiling, ImageUsageFlags usage, ImageCreateFlags? flags = default, ExternalMemoryHandleTypeFlags? externalHandleType = default)
        {
            try
            {
                var result = default(ExternalImageFormatProperties);
                var commandCache = default(CommandCache);
                var marshalledFlags = default(ImageCreateFlags);
                var marshalledExternalHandleType = default(ExternalMemoryHandleTypeFlags);
                var marshalledExternalImageFormatProperties = default(ExternalImageFormatProperties);
                commandCache = extendedHandle.commandCache;
                if (flags != null)
                    marshalledFlags = flags.Value;
                else
                    marshalledFlags = default;
                if (externalHandleType != null)
                    marshalledExternalHandleType = externalHandleType.Value;
                else
                    marshalledExternalHandleType = default;
                var commandDelegate = commandCache.Cache.vkGetPhysicalDeviceExternalImageFormatPropertiesNV;
                var methodResult = commandDelegate(extendedHandle.handle, format, type, tiling, usage, marshalledFlags, marshalledExternalHandleType, &marshalledExternalImageFormatProperties);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                result = marshalledExternalImageFormatProperties;
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Returns properties describing what cooperative matrix types are
        ///     supported
        /// </summary>
        /// <param name="extendedHandle">
        ///     The PhysicalDevice handle to extend.
        /// </param>
        public static unsafe CooperativeMatrixProperties[] GetCooperativeMatrixProperties(this PhysicalDevice extendedHandle)
        {
            try
            {
                var result = default(CooperativeMatrixProperties[]);
                var marshalledPropertyCount = default(uint);
                var commandCache = default(CommandCache);
                var marshalledProperties = default(Interop.NVidia.CooperativeMatrixProperties*);
                commandCache = extendedHandle.commandCache;
                var commandDelegate = commandCache.Cache.vkGetPhysicalDeviceCooperativeMatrixPropertiesNV;
                var methodResult = commandDelegate(extendedHandle.handle, &marshalledPropertyCount, marshalledProperties);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                marshalledProperties = (Interop.NVidia.CooperativeMatrixProperties*)HeapUtil.Allocate<Interop.NVidia.CooperativeMatrixProperties>(marshalledPropertyCount);
                commandDelegate(extendedHandle.handle, &marshalledPropertyCount, marshalledProperties);
                if (marshalledProperties != null)
                {
                    var fieldPointer = new CooperativeMatrixProperties[marshalledPropertyCount];
                    for (var index = 0; index < marshalledPropertyCount; index++) fieldPointer[index] = CooperativeMatrixProperties.MarshalFrom(&marshalledProperties[index]);
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
        ///     Query supported sample count combinations
        /// </summary>
        /// <param name="extendedHandle">
        ///     The PhysicalDevice handle to extend.
        /// </param>
        public static unsafe FramebufferMixedSamplesCombination[] GetSupportedFramebufferMixedSamplesCombinations(this PhysicalDevice extendedHandle)
        {
            try
            {
                var result = default(FramebufferMixedSamplesCombination[]);
                var marshalledCombinationCount = default(uint);
                var commandCache = default(CommandCache);
                var marshalledCombinations = default(Interop.NVidia.FramebufferMixedSamplesCombination*);
                commandCache = extendedHandle.commandCache;
                var commandDelegate = commandCache.Cache.vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV;
                var methodResult = commandDelegate(extendedHandle.handle, &marshalledCombinationCount, marshalledCombinations);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                marshalledCombinations = (Interop.NVidia.FramebufferMixedSamplesCombination*)HeapUtil.Allocate<Interop.NVidia.FramebufferMixedSamplesCombination>(marshalledCombinationCount);
                commandDelegate(extendedHandle.handle, &marshalledCombinationCount, marshalledCombinations);
                if (marshalledCombinations != null)
                {
                    var fieldPointer = new FramebufferMixedSamplesCombination[marshalledCombinationCount];
                    for (var index = 0; index < marshalledCombinationCount; index++) fieldPointer[index] = FramebufferMixedSamplesCombination.MarshalFrom(&marshalledCombinations[index]);
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