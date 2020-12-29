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
    ///     Structure specifying parameters of a newly created device queue.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct DeviceQueueCreateInfo
    {
        /// <summary>
        ///     Reserved for future use.
        /// </summary>
        public DeviceQueueCreateFlags? Flags
        {
            get;
            set;
        }

        /// <summary>
        ///     An unsigned integer indicating the index of the queue family to
        ///     create on this device. This index corresponds to the index of an
        ///     element of the pQueueFamilyProperties array that was returned by
        ///     fname:vkGetPhysicalDeviceQueueFamilyProperties.
        /// </summary>
        public uint QueueFamilyIndex
        {
            get;
            set;
        }

        /// <summary>
        ///     An array of queueCount normalized floating point values, specifying
        ///     priorities of work that will be submitted to each created queue.
        ///     See Queue Priority for more information.
        /// </summary>
        public float[] QueuePriorities
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(Interop.DeviceQueueCreateInfo* pointer)
        {
            pointer->SType = StructureType.DeviceQueueCreateInfo;
            pointer->Next = null;
            if (Flags != null)
                pointer->Flags = Flags.Value;
            else
                pointer->Flags = default;
            pointer->QueueFamilyIndex = QueueFamilyIndex;
            pointer->QueueCount = HeapUtil.GetLength(QueuePriorities);
            if (QueuePriorities != null)
            {
                var fieldPointer = (float*)HeapUtil.AllocateAndClear<float>(QueuePriorities.Length).ToPointer();
                for (var index = 0; index < (uint)QueuePriorities.Length; index++) fieldPointer[index] = QueuePriorities[index];
                pointer->QueuePriorities = fieldPointer;
            }
            else
            {
                pointer->QueuePriorities = null;
            }
        }
    }
}