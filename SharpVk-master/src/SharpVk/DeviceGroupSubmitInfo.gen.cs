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
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct DeviceGroupSubmitInfo
    {
        /// <summary>
        /// </summary>
        public uint[] WaitSemaphoreDeviceIndices
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public uint[] CommandBufferDeviceMasks
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public uint[] SignalSemaphoreDeviceIndices
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(Interop.DeviceGroupSubmitInfo* pointer)
        {
            pointer->SType = StructureType.DeviceGroupSubmitInfoVersion;
            pointer->Next = null;
            pointer->WaitSemaphoreCount = HeapUtil.GetLength(WaitSemaphoreDeviceIndices);
            if (WaitSemaphoreDeviceIndices != null)
            {
                var fieldPointer = (uint*)HeapUtil.AllocateAndClear<uint>(WaitSemaphoreDeviceIndices.Length).ToPointer();
                for (var index = 0; index < (uint)WaitSemaphoreDeviceIndices.Length; index++) fieldPointer[index] = WaitSemaphoreDeviceIndices[index];
                pointer->WaitSemaphoreDeviceIndices = fieldPointer;
            }
            else
            {
                pointer->WaitSemaphoreDeviceIndices = null;
            }
            pointer->CommandBufferCount = HeapUtil.GetLength(CommandBufferDeviceMasks);
            if (CommandBufferDeviceMasks != null)
            {
                var fieldPointer = (uint*)HeapUtil.AllocateAndClear<uint>(CommandBufferDeviceMasks.Length).ToPointer();
                for (var index = 0; index < (uint)CommandBufferDeviceMasks.Length; index++) fieldPointer[index] = CommandBufferDeviceMasks[index];
                pointer->CommandBufferDeviceMasks = fieldPointer;
            }
            else
            {
                pointer->CommandBufferDeviceMasks = null;
            }
            pointer->SignalSemaphoreCount = HeapUtil.GetLength(SignalSemaphoreDeviceIndices);
            if (SignalSemaphoreDeviceIndices != null)
            {
                var fieldPointer = (uint*)HeapUtil.AllocateAndClear<uint>(SignalSemaphoreDeviceIndices.Length).ToPointer();
                for (var index = 0; index < (uint)SignalSemaphoreDeviceIndices.Length; index++) fieldPointer[index] = SignalSemaphoreDeviceIndices[index];
                pointer->SignalSemaphoreDeviceIndices = fieldPointer;
            }
            else
            {
                pointer->SignalSemaphoreDeviceIndices = null;
            }
        }
    }
}