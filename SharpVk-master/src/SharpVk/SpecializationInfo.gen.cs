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
    ///     Structure specifying specialization info.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct SpecializationInfo
    {
        /// <summary>
        ///     An array of SpecializationMapEntry which maps constant IDs to
        ///     offsets in pData.
        /// </summary>
        public SpecializationMapEntry[] MapEntries
        {
            get;
            set;
        }

        /// <summary>
        ///     pData contains the actual constant values to specialize with.
        /// </summary>
        public byte[] Data
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(Interop.SpecializationInfo* pointer)
        {
            pointer->MapEntryCount = HeapUtil.GetLength(MapEntries);
            if (MapEntries != null)
            {
                var fieldPointer = (SpecializationMapEntry*)HeapUtil.AllocateAndClear<SpecializationMapEntry>(MapEntries.Length).ToPointer();
                for (var index = 0; index < (uint)MapEntries.Length; index++) fieldPointer[index] = MapEntries[index];
                pointer->MapEntries = fieldPointer;
            }
            else
            {
                pointer->MapEntries = null;
            }
            pointer->DataSize = HeapUtil.GetLength(Data);
            if (Data != null)
            {
                var fieldPointer = (byte*)HeapUtil.AllocateAndClear<byte>(Data.Length).ToPointer();
                for (var index = 0; index < (uint)Data.Length; index++) fieldPointer[index] = Data[index];
                pointer->Data = fieldPointer;
            }
            else
            {
                pointer->Data = null;
            }
        }
    }
}