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

using SharpVk.Ggp;
using SharpVk.Google;
using SharpVk.Interop;

namespace SharpVk.Khronos
{
    /// <summary>
    /// </summary>
    public static class QueueExtensions
    {
        /// <summary>
        ///     Queue an image for presentation.
        /// </summary>
        /// <param name="extendedHandle">
        ///     The Queue handle to extend.
        /// </param>
        /// <param name="waitSemaphores">
        /// </param>
        /// <param name="swapchains">
        /// </param>
        /// <param name="imageIndices">
        /// </param>
        /// <param name="results">
        /// </param>
        /// <param name="displayPresentInfoKhr">
        ///     Extension struct
        /// </param>
        /// <param name="presentRegionsKhr">
        ///     Extension struct
        /// </param>
        /// <param name="deviceGroupPresentInfoKhr">
        ///     Extension struct
        /// </param>
        /// <param name="presentTimesInfoGoogle">
        ///     Extension struct
        /// </param>
        /// <param name="presentFrameTokenGgp">
        ///     Extension struct
        /// </param>
        public static unsafe Result Present(this Queue extendedHandle, ArrayProxy<Semaphore>? waitSemaphores, ArrayProxy<Swapchain>? swapchains, ArrayProxy<uint>? imageIndices, ArrayProxy<Result>? results = null, DisplayPresentInfo? displayPresentInfoKhr = null, PresentRegions? presentRegionsKhr = null, DeviceGroupPresentInfo? deviceGroupPresentInfoKhr = null, PresentTimesInfo? presentTimesInfoGoogle = null, PresentFrameToken? presentFrameTokenGgp = null)
        {
            try
            {
                var result = default(Result);
                var commandCache = default(CommandCache);
                var marshalledPresentInfo = default(Interop.Khronos.PresentInfo*);
                var vkPresentInfoKHRNextPointer = default(void*);
                if (displayPresentInfoKhr != null)
                {
                    var extensionPointer = default(Interop.Khronos.DisplayPresentInfo*);
                    extensionPointer = (Interop.Khronos.DisplayPresentInfo*)HeapUtil.Allocate<Interop.Khronos.DisplayPresentInfo>();
                    displayPresentInfoKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkPresentInfoKHRNextPointer;
                    vkPresentInfoKHRNextPointer = extensionPointer;
                }
                if (presentRegionsKhr != null)
                {
                    var extensionPointer = default(Interop.Khronos.PresentRegions*);
                    extensionPointer = (Interop.Khronos.PresentRegions*)HeapUtil.Allocate<Interop.Khronos.PresentRegions>();
                    presentRegionsKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkPresentInfoKHRNextPointer;
                    vkPresentInfoKHRNextPointer = extensionPointer;
                }
                if (deviceGroupPresentInfoKhr != null)
                {
                    var extensionPointer = default(Interop.Khronos.DeviceGroupPresentInfo*);
                    extensionPointer = (Interop.Khronos.DeviceGroupPresentInfo*)HeapUtil.Allocate<Interop.Khronos.DeviceGroupPresentInfo>();
                    deviceGroupPresentInfoKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkPresentInfoKHRNextPointer;
                    vkPresentInfoKHRNextPointer = extensionPointer;
                }
                if (presentTimesInfoGoogle != null)
                {
                    var extensionPointer = default(Interop.Google.PresentTimesInfo*);
                    extensionPointer = (Interop.Google.PresentTimesInfo*)HeapUtil.Allocate<Interop.Google.PresentTimesInfo>();
                    presentTimesInfoGoogle.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkPresentInfoKHRNextPointer;
                    vkPresentInfoKHRNextPointer = extensionPointer;
                }
                if (presentFrameTokenGgp != null)
                {
                    var extensionPointer = default(Interop.Ggp.PresentFrameToken*);
                    extensionPointer = (Interop.Ggp.PresentFrameToken*)HeapUtil.Allocate<Interop.Ggp.PresentFrameToken>();
                    presentFrameTokenGgp.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkPresentInfoKHRNextPointer;
                    vkPresentInfoKHRNextPointer = extensionPointer;
                }
                commandCache = extendedHandle.commandCache;
                marshalledPresentInfo = (Interop.Khronos.PresentInfo*)HeapUtil.Allocate<Interop.Khronos.PresentInfo>();
                marshalledPresentInfo->SType = StructureType.PresentInfo;
                marshalledPresentInfo->Next = vkPresentInfoKHRNextPointer;
                marshalledPresentInfo->WaitSemaphoreCount = HeapUtil.GetLength(waitSemaphores);
                if (waitSemaphores.IsNull())
                {
                    marshalledPresentInfo->WaitSemaphores = null;
                }
                else
                {
                    if (waitSemaphores.Value.Contents == ProxyContents.Single)
                    {
                        marshalledPresentInfo->WaitSemaphores = (Interop.Semaphore*)HeapUtil.Allocate<Interop.Semaphore>();
                        *marshalledPresentInfo->WaitSemaphores = waitSemaphores.Value.GetSingleValue()?.handle ?? default(Interop.Semaphore);
                    }
                    else
                    {
                        var fieldPointer = (Interop.Semaphore*)HeapUtil.AllocateAndClear<Interop.Semaphore>(HeapUtil.GetLength(waitSemaphores.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(waitSemaphores.Value); index++) fieldPointer[index] = waitSemaphores.Value[index]?.handle ?? default(Interop.Semaphore);
                        marshalledPresentInfo->WaitSemaphores = fieldPointer;
                    }
                }
                marshalledPresentInfo->SwapchainCount = HeapUtil.GetLength(swapchains);
                if (swapchains.IsNull())
                {
                    marshalledPresentInfo->Swapchains = null;
                }
                else
                {
                    if (swapchains.Value.Contents == ProxyContents.Single)
                    {
                        marshalledPresentInfo->Swapchains = (Interop.Khronos.Swapchain*)HeapUtil.Allocate<Interop.Khronos.Swapchain>();
                        *marshalledPresentInfo->Swapchains = swapchains.Value.GetSingleValue()?.handle ?? default(Interop.Khronos.Swapchain);
                    }
                    else
                    {
                        var fieldPointer = (Interop.Khronos.Swapchain*)HeapUtil.AllocateAndClear<Interop.Khronos.Swapchain>(HeapUtil.GetLength(swapchains.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(swapchains.Value); index++) fieldPointer[index] = swapchains.Value[index]?.handle ?? default(Interop.Khronos.Swapchain);
                        marshalledPresentInfo->Swapchains = fieldPointer;
                    }
                }
                if (imageIndices.IsNull())
                {
                    marshalledPresentInfo->ImageIndices = null;
                }
                else
                {
                    if (imageIndices.Value.Contents == ProxyContents.Single)
                    {
                        marshalledPresentInfo->ImageIndices = (uint*)HeapUtil.Allocate<uint>();
                        *marshalledPresentInfo->ImageIndices = imageIndices.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (uint*)HeapUtil.AllocateAndClear<uint>(HeapUtil.GetLength(imageIndices.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(imageIndices.Value); index++) fieldPointer[index] = imageIndices.Value[index];
                        marshalledPresentInfo->ImageIndices = fieldPointer;
                    }
                }
                if (results.IsNull())
                {
                    marshalledPresentInfo->Results = null;
                }
                else
                {
                    if (results.Value.Contents == ProxyContents.Single)
                    {
                        marshalledPresentInfo->Results = (Result*)HeapUtil.Allocate<Result>();
                        *marshalledPresentInfo->Results = results.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (Result*)HeapUtil.AllocateAndClear<Result>(HeapUtil.GetLength(results.Value)).ToPointer();
                        for (var index = 0; index < HeapUtil.GetLength(results.Value); index++) fieldPointer[index] = results.Value[index];
                        marshalledPresentInfo->Results = fieldPointer;
                    }
                }
                var commandDelegate = commandCache.Cache.vkQueuePresentKHR;
                result = commandDelegate(extendedHandle.handle, marshalledPresentInfo);
                if (SharpVkException.IsError(result)) throw SharpVkException.Create(result);
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }
    }
}