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
    public static class PipelineExtensions
    {
        /// <summary>
        /// </summary>
        /// <param name="extendedHandle">
        ///     The Pipeline handle to extend.
        /// </param>
        /// <param name="firstGroup">
        /// </param>
        /// <param name="groupCount">
        /// </param>
        /// <param name="dataSize">
        /// </param>
        public static unsafe byte[] GetRayTracingShaderGroupHandles(this Pipeline extendedHandle, uint firstGroup, uint groupCount, HostSize dataSize)
        {
            try
            {
                var result = default(byte[]);
                var commandCache = default(CommandCache);
                var marshalledDataSize = default(HostSize);
                var marshalledData = default(byte*);
                commandCache = extendedHandle.commandCache;
                marshalledDataSize = dataSize;
                marshalledData = (byte*)HeapUtil.Allocate<byte>(marshalledDataSize);
                var commandDelegate = commandCache.Cache.vkGetRayTracingShaderGroupHandlesNV;
                var methodResult = commandDelegate(extendedHandle.parent.handle, extendedHandle.handle, firstGroup, groupCount, marshalledDataSize, marshalledData);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                if (marshalledData != null)
                {
                    var fieldPointer = new byte[(uint)marshalledDataSize];
                    for (var index = 0; index < (uint)marshalledDataSize; index++) fieldPointer[index] = marshalledData[index];
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
        ///     The Pipeline handle to extend.
        /// </param>
        /// <param name="shader">
        /// </param>
        public static void CompileDeferred(this Pipeline extendedHandle, uint shader)
        {
            try
            {
                var commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                var commandDelegate = commandCache.Cache.vkCompileDeferredNV;
                var methodResult = commandDelegate(extendedHandle.parent.handle, extendedHandle.handle, shader);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }
    }
}