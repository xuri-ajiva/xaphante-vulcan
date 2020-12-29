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

namespace SharpVk.Intel
{
    /// <summary>
    /// </summary>
    public static class DeviceExtensions
    {
        /// <summary>
        ///     Initialize a device for performance queries
        /// </summary>
        /// <param name="extendedHandle">
        ///     The Device handle to extend.
        /// </param>
        /// <param name="initializeInfo">
        ///     The initialization parameters.
        /// </param>
        public static unsafe void InitializePerformanceApi(this Device extendedHandle, InitializePerformanceApiInfo initializeInfo)
        {
            try
            {
                var commandCache = default(CommandCache);
                var marshalledInitializeInfo = default(Interop.Intel.InitializePerformanceApiInfo*);
                commandCache = extendedHandle.commandCache;
                marshalledInitializeInfo = (Interop.Intel.InitializePerformanceApiInfo*)HeapUtil.Allocate<Interop.Intel.InitializePerformanceApiInfo>();
                initializeInfo.MarshalTo(marshalledInitializeInfo);
                var commandDelegate = commandCache.Cache.vkInitializePerformanceApiINTEL;
                var methodResult = commandDelegate(extendedHandle.handle, marshalledInitializeInfo);
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
        public static void UninitializePerformanceApi(this Device extendedHandle)
        {
            try
            {
                var commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                var commandDelegate = commandCache.Cache.vkUninitializePerformanceApiINTEL;
                commandDelegate(extendedHandle.handle);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Acquire the performance query capability
        /// </summary>
        /// <param name="extendedHandle">
        ///     The Device handle to extend.
        /// </param>
        /// <param name="type">
        ///     One of the VkPerformanceConfigurationTypeINTEL type of performance
        ///     configuration that will be acquired.
        /// </param>
        public static unsafe PerformanceConfiguration AcquirePerformanceConfiguration(this Device extendedHandle, PerformanceConfigurationType type)
        {
            try
            {
                var result = default(PerformanceConfiguration);
                var commandCache = default(CommandCache);
                var marshalledAcquireInfo = default(Interop.Intel.PerformanceConfigurationAcquireInfo*);
                var vkPerformanceConfigurationAcquireInfoINTELNextPointer = default(void*);
                var marshalledConfiguration = default(Interop.Intel.PerformanceConfiguration);
                commandCache = extendedHandle.commandCache;
                marshalledAcquireInfo = (Interop.Intel.PerformanceConfigurationAcquireInfo*)HeapUtil.Allocate<Interop.Intel.PerformanceConfigurationAcquireInfo>();
                marshalledAcquireInfo->SType = StructureType.PerformanceConfigurationAcquireInfo;
                marshalledAcquireInfo->Next = vkPerformanceConfigurationAcquireInfoINTELNextPointer;
                marshalledAcquireInfo->Type = type;
                var commandDelegate = commandCache.Cache.vkAcquirePerformanceConfigurationINTEL;
                var methodResult = commandDelegate(extendedHandle.handle, marshalledAcquireInfo, &marshalledConfiguration);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                result = new(extendedHandle, marshalledConfiguration);
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Query performance capabilities of the device
        /// </summary>
        /// <param name="extendedHandle">
        ///     The Device handle to extend.
        /// </param>
        /// <param name="parameter">
        ///     The parameter to query.
        /// </param>
        public static unsafe PerformanceValue GetPerformanceParameter(this Device extendedHandle, PerformanceParameterType parameter)
        {
            try
            {
                var result = default(PerformanceValue);
                var commandCache = default(CommandCache);
                var marshalledValue = default(Interop.Intel.PerformanceValue);
                commandCache = extendedHandle.commandCache;
                var commandDelegate = commandCache.Cache.vkGetPerformanceParameterINTEL;
                var methodResult = commandDelegate(extendedHandle.handle, parameter, &marshalledValue);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                result = PerformanceValue.MarshalFrom(&marshalledValue);
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }
    }
}