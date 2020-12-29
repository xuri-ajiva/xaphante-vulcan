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
    public static class CommandBufferExtensions
    {
        /// <summary>
        ///     Pushes descriptor updates into a command buffer.
        /// </summary>
        /// <param name="extendedHandle">
        ///     The CommandBuffer handle to extend.
        /// </param>
        /// <param name="pipelineBindPoint">
        /// </param>
        /// <param name="layout">
        /// </param>
        /// <param name="set">
        /// </param>
        /// <param name="descriptorWrites">
        /// </param>
        public static unsafe void PushDescriptorSet(this CommandBuffer extendedHandle, PipelineBindPoint pipelineBindPoint, PipelineLayout layout, uint set, ArrayProxy<WriteDescriptorSet>? descriptorWrites)
        {
            try
            {
                var commandCache = default(CommandCache);
                var marshalledDescriptorWrites = default(Interop.WriteDescriptorSet*);
                commandCache = extendedHandle.CommandCache;
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
                var commandDelegate = commandCache.Cache.VkCmdPushDescriptorSetKhr;
                commandDelegate(extendedHandle.Handle, pipelineBindPoint, layout?.Handle ?? default(Interop.PipelineLayout), set, HeapUtil.GetLength(descriptorWrites), marshalledDescriptorWrites);
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }

        /// <summary>
        ///     Pushes descriptor updates into a command buffer using a descriptor
        ///     update template.
        /// </summary>
        /// <param name="extendedHandle">
        ///     The CommandBuffer handle to extend.
        /// </param>
        /// <param name="descriptorUpdateTemplate">
        /// </param>
        /// <param name="layout">
        /// </param>
        /// <param name="set">
        /// </param>
        /// <param name="data">
        /// </param>
        public static unsafe void PushDescriptorSetWithTemplate(this CommandBuffer extendedHandle, DescriptorUpdateTemplate descriptorUpdateTemplate, PipelineLayout layout, uint set, IntPtr data)
        {
            try
            {
                var commandCache = default(CommandCache);
                commandCache = extendedHandle.CommandCache;
                var commandDelegate = commandCache.Cache.VkCmdPushDescriptorSetWithTemplateKhr;
                commandDelegate(extendedHandle.Handle, descriptorUpdateTemplate?.Handle ?? default(Interop.DescriptorUpdateTemplate), layout?.Handle ?? default(Interop.PipelineLayout), set, data.ToPointer());
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }
    }
}
