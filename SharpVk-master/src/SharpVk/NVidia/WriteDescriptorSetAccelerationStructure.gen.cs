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

namespace SharpVk.NVidia
{
    /// <summary>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct WriteDescriptorSetAccelerationStructure
    {
        /// <summary>
        /// </summary>
        public AccelerationStructure[] AccelerationStructures
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(Interop.NVidia.WriteDescriptorSetAccelerationStructure* pointer)
        {
            pointer->SType = StructureType.WriteDescriptorSetAccelerationStructure;
            pointer->Next = null;
            pointer->AccelerationStructureCount = HeapUtil.GetLength(AccelerationStructures);
            if (AccelerationStructures != null)
            {
                var fieldPointer = (Interop.NVidia.AccelerationStructure*)HeapUtil.AllocateAndClear<Interop.NVidia.AccelerationStructure>(AccelerationStructures.Length).ToPointer();
                for (var index = 0; index < (uint)AccelerationStructures.Length; index++) fieldPointer[index] = AccelerationStructures[index]?.handle ?? default(Interop.NVidia.AccelerationStructure);
                pointer->AccelerationStructures = fieldPointer;
            }
            else
            {
                pointer->AccelerationStructures = null;
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe WriteDescriptorSetAccelerationStructure MarshalFrom(Interop.NVidia.WriteDescriptorSetAccelerationStructure* pointer)
        {
            var result = default(WriteDescriptorSetAccelerationStructure);
            if (pointer->AccelerationStructures != null)
            {
                var fieldPointer = new AccelerationStructure[pointer->AccelerationStructureCount];
                for (var index = 0; index < pointer->AccelerationStructureCount; index++) fieldPointer[index] = new(default, pointer->AccelerationStructures[index]);
                result.AccelerationStructures = fieldPointer;
            }
            else
            {
                result.AccelerationStructures = null;
            }
            return result;
        }
    }
}