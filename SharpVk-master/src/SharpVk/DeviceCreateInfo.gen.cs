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
    ///     Structure specifying parameters of a newly created device.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct DeviceCreateInfo
    {
        /// <summary>
        ///     Reserved for future use.
        /// </summary>
        public DeviceCreateFlags? Flags
        {
            get;
            set;
        }

        /// <summary>
        ///     An array of DeviceQueueCreateInfo structures describing the queues
        ///     that are requested to be created along with the logical device.
        /// </summary>
        public DeviceQueueCreateInfo[] QueueCreateInfos
        {
            get;
            set;
        }

        /// <summary>
        ///     ppEnabledLayerNames is deprecated and ignored.
        /// </summary>
        public ArrayProxy<string> EnabledLayerNames
        {
            get;
            set;
        }

        /// <summary>
        ///     An array of enabledExtensionCount strings containing the names of
        ///     extensions to enable for the created device.
        /// </summary>
        public ArrayProxy<string> EnabledExtensionNames
        {
            get;
            set;
        }

        /// <summary>
        ///     Null or a PhysicalDeviceFeatures structure that contains boolean
        ///     indicators of all the features to be enabled.
        /// </summary>
        public PhysicalDeviceFeatures? EnabledFeatures
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(Interop.DeviceCreateInfo* pointer)
        {
            pointer->SType = StructureType.DeviceCreateInfo;
            pointer->Next = null;
            if (Flags != null)
                pointer->Flags = Flags.Value;
            else
                pointer->Flags = default;
            pointer->QueueCreateInfoCount = HeapUtil.GetLength(QueueCreateInfos);
            if (QueueCreateInfos != null)
            {
                var fieldPointer = (Interop.DeviceQueueCreateInfo*)HeapUtil.AllocateAndClear<Interop.DeviceQueueCreateInfo>(QueueCreateInfos.Length).ToPointer();
                for (var index = 0; index < (uint)QueueCreateInfos.Length; index++) QueueCreateInfos[index].MarshalTo(&fieldPointer[index]);
                pointer->QueueCreateInfos = fieldPointer;
            }
            else
            {
                pointer->QueueCreateInfos = null;
            }
            pointer->EnabledLayerCount = HeapUtil.GetLength(EnabledLayerNames);
            pointer->EnabledLayerNames = HeapUtil.MarshalTo(EnabledLayerNames);
            pointer->EnabledExtensionCount = HeapUtil.GetLength(EnabledExtensionNames);
            pointer->EnabledExtensionNames = HeapUtil.MarshalTo(EnabledExtensionNames);
            if (EnabledFeatures != null)
            {
                pointer->EnabledFeatures = (Interop.PhysicalDeviceFeatures*)HeapUtil.Allocate<Interop.PhysicalDeviceFeatures>();
                EnabledFeatures.Value.MarshalTo(pointer->EnabledFeatures);
            }
            else
            {
                pointer->EnabledFeatures = default;
            }
        }
    }
}