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
    public struct HdrMetadata
    {
        /// <summary>
        /// </summary>
        public XYColor DisplayPrimaryRed
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public XYColor DisplayPrimaryGreen
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public XYColor DisplayPrimaryBlue
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public XYColor WhitePoint
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public float MaxLuminance
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public float MinLuminance
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public float MaxContentLightLevel
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public float MaxFrameAverageLightLevel
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(Interop.Multivendor.HdrMetadata* pointer)
        {
            pointer->SType = StructureType.HdrMetadata;
            pointer->Next = null;
            pointer->DisplayPrimaryRed = DisplayPrimaryRed;
            pointer->DisplayPrimaryGreen = DisplayPrimaryGreen;
            pointer->DisplayPrimaryBlue = DisplayPrimaryBlue;
            pointer->WhitePoint = WhitePoint;
            pointer->MaxLuminance = MaxLuminance;
            pointer->MinLuminance = MinLuminance;
            pointer->MaxContentLightLevel = MaxContentLightLevel;
            pointer->MaxFrameAverageLightLevel = MaxFrameAverageLightLevel;
        }

        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe HdrMetadata MarshalFrom(Interop.Multivendor.HdrMetadata* pointer)
        {
            var result = default(HdrMetadata);
            result.DisplayPrimaryRed = pointer->DisplayPrimaryRed;
            result.DisplayPrimaryGreen = pointer->DisplayPrimaryGreen;
            result.DisplayPrimaryBlue = pointer->DisplayPrimaryBlue;
            result.WhitePoint = pointer->WhitePoint;
            result.MaxLuminance = pointer->MaxLuminance;
            result.MinLuminance = pointer->MinLuminance;
            result.MaxContentLightLevel = pointer->MaxContentLightLevel;
            result.MaxFrameAverageLightLevel = pointer->MaxFrameAverageLightLevel;
            return result;
        }
    }
}