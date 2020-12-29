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
    public struct ImageDrmFormatModifierExplicitCreateInfo
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
        public SubresourceLayout[] PlaneLayouts
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(Interop.Multivendor.ImageDrmFormatModifierExplicitCreateInfo* pointer)
        {
            pointer->SType = StructureType.ImageDrmFormatModifierExplicitCreateInfo;
            pointer->Next = null;
            pointer->DrmFormatModifier = DrmFormatModifier;
            pointer->DrmFormatModifierPlaneCount = HeapUtil.GetLength(PlaneLayouts);
            if (PlaneLayouts != null)
            {
                var fieldPointer = (SubresourceLayout*)HeapUtil.AllocateAndClear<SubresourceLayout>(PlaneLayouts.Length).ToPointer();
                for (var index = 0; index < (uint)PlaneLayouts.Length; index++) fieldPointer[index] = PlaneLayouts[index];
                pointer->PlaneLayouts = fieldPointer;
            }
            else
            {
                pointer->PlaneLayouts = null;
            }
        }
    }
}