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
using System.Runtime.InteropServices;
using SharpVk.Interop;

namespace SharpVk
{
    /// <summary>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct PhysicalDeviceIdProperties
    {
        /// <summary>
        /// </summary>
        public Guid DeviceUuid
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public Guid DriverUuid
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public Guid DeviceLuid
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public uint DeviceNodeMask
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool DeviceLuidValid
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe PhysicalDeviceIdProperties MarshalFrom(Interop.PhysicalDeviceIdProperties* pointer)
        {
            var result = default(PhysicalDeviceIdProperties);
            result.DeviceUuid = new(HeapUtil.MarshalFrom(pointer->DeviceUUID, Constants.UuidSize));
            result.DriverUuid = new(HeapUtil.MarshalFrom(pointer->DriverUUID, Constants.UuidSize));
            result.DeviceLuid = new(HeapUtil.MarshalFrom(pointer->DeviceLUID, Constants.LuidSize));
            result.DeviceNodeMask = pointer->DeviceNodeMask;
            result.DeviceLuidValid = pointer->DeviceLUIDValid;
            return result;
        }
    }
}
