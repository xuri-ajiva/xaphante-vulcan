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

namespace SharpVk
{
    /// <summary>
    ///     Structure specifying a queue submit operation.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct SubmitInfo
    {
        /// <summary>
        ///     An array of semaphores upon which to wait before the command
        ///     buffers for this batch begin execution. If semaphores to wait on
        ///     are provided, they define a semaphore wait operation.
        /// </summary>
        public Semaphore[] WaitSemaphores
        {
            get;
            set;
        }

        /// <summary>
        ///     An array of pipeline stages at which each corresponding semaphore
        ///     wait will occur.
        /// </summary>
        public PipelineStageFlags[] WaitDestinationStageMask
        {
            get;
            set;
        }

        /// <summary>
        ///     An array of command buffers to execute in the batch.
        /// </summary>
        public CommandBuffer[] CommandBuffers
        {
            get;
            set;
        }

        /// <summary>
        ///     An array of semaphores which will be signaled when the command
        ///     buffers for this batch have completed execution. If semaphores to
        ///     be signaled are provided, they define a semaphore signal operation.
        /// </summary>
        public Semaphore[] SignalSemaphores
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(Interop.SubmitInfo* pointer)
        {
            pointer->SType = StructureType.SubmitInfo;
            pointer->Next = null;
            pointer->WaitSemaphoreCount = HeapUtil.GetLength(WaitSemaphores);
            if (WaitSemaphores != null)
            {
                var fieldPointer = (Interop.Semaphore*)HeapUtil.AllocateAndClear<Interop.Semaphore>(WaitSemaphores.Length).ToPointer();
                for (var index = 0; index < (uint)WaitSemaphores.Length; index++) fieldPointer[index] = WaitSemaphores[index]?.Handle ?? default(Interop.Semaphore);
                pointer->WaitSemaphores = fieldPointer;
            }
            else
            {
                pointer->WaitSemaphores = null;
            }
            if (WaitDestinationStageMask != null)
            {
                var fieldPointer = (PipelineStageFlags*)HeapUtil.AllocateAndClear<PipelineStageFlags>(WaitDestinationStageMask.Length).ToPointer();
                for (var index = 0; index < (uint)WaitDestinationStageMask.Length; index++) fieldPointer[index] = WaitDestinationStageMask[index];
                pointer->WaitDestinationStageMask = fieldPointer;
            }
            else
            {
                pointer->WaitDestinationStageMask = null;
            }
            pointer->CommandBufferCount = HeapUtil.GetLength(CommandBuffers);
            if (CommandBuffers != null)
            {
                var fieldPointer = (Interop.CommandBuffer*)HeapUtil.AllocateAndClear<Interop.CommandBuffer>(CommandBuffers.Length).ToPointer();
                for (var index = 0; index < (uint)CommandBuffers.Length; index++) fieldPointer[index] = CommandBuffers[index]?.Handle ?? default(Interop.CommandBuffer);
                pointer->CommandBuffers = fieldPointer;
            }
            else
            {
                pointer->CommandBuffers = null;
            }
            pointer->SignalSemaphoreCount = HeapUtil.GetLength(SignalSemaphores);
            if (SignalSemaphores != null)
            {
                var fieldPointer = (Interop.Semaphore*)HeapUtil.AllocateAndClear<Interop.Semaphore>(SignalSemaphores.Length).ToPointer();
                for (var index = 0; index < (uint)SignalSemaphores.Length; index++) fieldPointer[index] = SignalSemaphores[index]?.Handle ?? default(Interop.Semaphore);
                pointer->SignalSemaphores = fieldPointer;
            }
            else
            {
                pointer->SignalSemaphores = null;
            }
        }
    }
}
