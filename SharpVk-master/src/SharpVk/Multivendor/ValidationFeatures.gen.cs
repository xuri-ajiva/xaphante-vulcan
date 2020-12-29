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
    public struct ValidationFeatures
    {
        /// <summary>
        /// </summary>
        public ValidationFeatureEnable[] EnabledValidationFeatures
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public ValidationFeatureDisable[] DisabledValidationFeatures
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(Interop.Multivendor.ValidationFeatures* pointer)
        {
            pointer->SType = StructureType.ValidationFeatures;
            pointer->Next = null;
            pointer->EnabledValidationFeatureCount = HeapUtil.GetLength(EnabledValidationFeatures);
            if (EnabledValidationFeatures != null)
            {
                var fieldPointer = (ValidationFeatureEnable*)HeapUtil.AllocateAndClear<ValidationFeatureEnable>(EnabledValidationFeatures.Length).ToPointer();
                for (var index = 0; index < (uint)EnabledValidationFeatures.Length; index++) fieldPointer[index] = EnabledValidationFeatures[index];
                pointer->EnabledValidationFeatures = fieldPointer;
            }
            else
            {
                pointer->EnabledValidationFeatures = null;
            }
            pointer->DisabledValidationFeatureCount = HeapUtil.GetLength(DisabledValidationFeatures);
            if (DisabledValidationFeatures != null)
            {
                var fieldPointer = (ValidationFeatureDisable*)HeapUtil.AllocateAndClear<ValidationFeatureDisable>(DisabledValidationFeatures.Length).ToPointer();
                for (var index = 0; index < (uint)DisabledValidationFeatures.Length; index++) fieldPointer[index] = DisabledValidationFeatures[index];
                pointer->DisabledValidationFeatures = fieldPointer;
            }
            else
            {
                pointer->DisabledValidationFeatures = null;
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe ValidationFeatures MarshalFrom(Interop.Multivendor.ValidationFeatures* pointer)
        {
            var result = default(ValidationFeatures);
            if (pointer->EnabledValidationFeatures != null)
            {
                var fieldPointer = new ValidationFeatureEnable[pointer->EnabledValidationFeatureCount];
                for (var index = 0; index < pointer->EnabledValidationFeatureCount; index++) fieldPointer[index] = pointer->EnabledValidationFeatures[index];
                result.EnabledValidationFeatures = fieldPointer;
            }
            else
            {
                result.EnabledValidationFeatures = null;
            }
            if (pointer->DisabledValidationFeatures != null)
            {
                var fieldPointer = new ValidationFeatureDisable[pointer->DisabledValidationFeatureCount];
                for (var index = 0; index < pointer->DisabledValidationFeatureCount; index++) fieldPointer[index] = pointer->DisabledValidationFeatures[index];
                result.DisabledValidationFeatures = fieldPointer;
            }
            else
            {
                result.DisabledValidationFeatures = null;
            }
            return result;
        }
    }
}