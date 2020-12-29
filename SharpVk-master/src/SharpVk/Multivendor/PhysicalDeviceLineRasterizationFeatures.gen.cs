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

namespace SharpVk.Multivendor
{
    /// <summary>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct PhysicalDeviceLineRasterizationFeatures
    {
        /// <summary>
        /// </summary>
        public bool RectangularLines
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool BresenhamLines
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool SmoothLines
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool StippledRectangularLines
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool StippledBresenhamLines
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool StippledSmoothLines
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(Interop.Multivendor.PhysicalDeviceLineRasterizationFeatures* pointer)
        {
            pointer->SType = StructureType.PhysicalDeviceLineRasterizationFeatures;
            pointer->Next = null;
            pointer->RectangularLines = RectangularLines;
            pointer->BresenhamLines = BresenhamLines;
            pointer->SmoothLines = SmoothLines;
            pointer->StippledRectangularLines = StippledRectangularLines;
            pointer->StippledBresenhamLines = StippledBresenhamLines;
            pointer->StippledSmoothLines = StippledSmoothLines;
        }

        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe PhysicalDeviceLineRasterizationFeatures MarshalFrom(Interop.Multivendor.PhysicalDeviceLineRasterizationFeatures* pointer)
        {
            var result = default(PhysicalDeviceLineRasterizationFeatures);
            result.RectangularLines = pointer->RectangularLines;
            result.BresenhamLines = pointer->BresenhamLines;
            result.SmoothLines = pointer->SmoothLines;
            result.StippledRectangularLines = pointer->StippledRectangularLines;
            result.StippledBresenhamLines = pointer->StippledBresenhamLines;
            result.StippledSmoothLines = pointer->StippledSmoothLines;
            return result;
        }
    }
}