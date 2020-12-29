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

namespace SharpVk.Android
{
    /// <summary>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct AndroidHardwareBufferFormatProperties
    {
        /// <summary>
        /// </summary>
        public Format Format
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public ulong ExternalFormat
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public FormatFeatureFlags FormatFeatures
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public ComponentMapping SamplerYcbcrConversionComponents
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public SamplerYcbcrModelConversion SuggestedYcbcrModel
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public SamplerYcbcrRange SuggestedYcbcrRange
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public ChromaLocation SuggestedXChromaOffset
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public ChromaLocation SuggestedYChromaOffset
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe AndroidHardwareBufferFormatProperties MarshalFrom(Interop.Android.AndroidHardwareBufferFormatProperties* pointer)
        {
            var result = default(AndroidHardwareBufferFormatProperties);
            result.Format = pointer->Format;
            result.ExternalFormat = pointer->ExternalFormat;
            result.FormatFeatures = pointer->FormatFeatures;
            result.SamplerYcbcrConversionComponents = pointer->SamplerYcbcrConversionComponents;
            result.SuggestedYcbcrModel = pointer->SuggestedYcbcrModel;
            result.SuggestedYcbcrRange = pointer->SuggestedYcbcrRange;
            result.SuggestedXChromaOffset = pointer->SuggestedXChromaOffset;
            result.SuggestedYChromaOffset = pointer->SuggestedYChromaOffset;
            return result;
        }
    }
}