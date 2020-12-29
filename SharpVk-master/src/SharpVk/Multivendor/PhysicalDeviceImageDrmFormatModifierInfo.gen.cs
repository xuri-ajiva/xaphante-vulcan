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

namespace SharpVk.Multivendor
{
    /// <summary>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct PhysicalDeviceImageDrmFormatModifierInfo
    {
        /// <summary>
        /// </summary>
        public ulong DrmFormatModifier
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public SharingMode SharingMode
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public uint[] QueueFamilyIndices
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(Interop.Multivendor.PhysicalDeviceImageDrmFormatModifierInfo* pointer)
        {
            pointer->SType = StructureType.PhysicalDeviceImageDrmFormatModifierInfo;
            pointer->Next = null;
            pointer->DrmFormatModifier = DrmFormatModifier;
            pointer->SharingMode = SharingMode;
            pointer->QueueFamilyIndexCount = HeapUtil.GetLength(QueueFamilyIndices);
            if (QueueFamilyIndices != null)
            {
                var fieldPointer = (uint*)HeapUtil.AllocateAndClear<uint>(QueueFamilyIndices.Length).ToPointer();
                for (var index = 0; index < (uint)QueueFamilyIndices.Length; index++) fieldPointer[index] = QueueFamilyIndices[index];
                pointer->QueueFamilyIndices = fieldPointer;
            }
            else
            {
                pointer->QueueFamilyIndices = null;
            }
        }
    }
}