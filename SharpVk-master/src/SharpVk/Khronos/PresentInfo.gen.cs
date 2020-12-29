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

namespace SharpVk.Khronos
{
    /// <summary>
    ///     Structure describing parameters of a queue presentation.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct PresentInfo
    {
        /// <summary>
        ///     If not Null, is an array of Semaphore objects with
        ///     waitSemaphoreCount entries, and specifies the semaphores to wait
        ///     for before issuing the present request.
        /// </summary>
        public Semaphore[] WaitSemaphores
        {
            get;
            set;
        }

        /// <summary>
        ///     An array of SwapchainKHR objects with swapchainCount entries. A
        ///     given swapchain must not appear in this list more than once.
        /// </summary>
        public Swapchain[] Swapchains
        {
            get;
            set;
        }

        /// <summary>
        ///     An array of indices into the array of each swapchain's presentable
        ///     images, with swapchainCount entries. Each entry in this array
        ///     identifies the image to present on the corresponding entry in the
        ///     pSwapchains array.
        /// </summary>
        public uint[] ImageIndices
        {
            get;
            set;
        }

        /// <summary>
        ///     An array of Result typed elements with swapchainCount entries.
        ///     Applications that do not need per-swapchain results can use Null
        ///     for pResults. If non-Null, each entry in pResults will be set to
        ///     the Result for presenting the swapchain corresponding to the same
        ///     index in pSwapchains.
        /// </summary>
        public Result[] Results
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(Interop.Khronos.PresentInfo* pointer)
        {
            pointer->SType = StructureType.PresentInfo;
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
            pointer->SwapchainCount = HeapUtil.GetLength(Swapchains);
            if (Swapchains != null)
            {
                var fieldPointer = (Interop.Khronos.Swapchain*)HeapUtil.AllocateAndClear<Interop.Khronos.Swapchain>(Swapchains.Length).ToPointer();
                for (var index = 0; index < (uint)Swapchains.Length; index++) fieldPointer[index] = Swapchains[index]?.Handle ?? default(Interop.Khronos.Swapchain);
                pointer->Swapchains = fieldPointer;
            }
            else
            {
                pointer->Swapchains = null;
            }
            if (ImageIndices != null)
            {
                var fieldPointer = (uint*)HeapUtil.AllocateAndClear<uint>(ImageIndices.Length).ToPointer();
                for (var index = 0; index < (uint)ImageIndices.Length; index++) fieldPointer[index] = ImageIndices[index];
                pointer->ImageIndices = fieldPointer;
            }
            else
            {
                pointer->ImageIndices = null;
            }
            if (Results != null)
            {
                var fieldPointer = (Result*)HeapUtil.AllocateAndClear<Result>(Results.Length).ToPointer();
                for (var index = 0; index < (uint)Results.Length; index++) fieldPointer[index] = Results[index];
                pointer->Results = fieldPointer;
            }
            else
            {
                pointer->Results = null;
            }
        }
    }
}
