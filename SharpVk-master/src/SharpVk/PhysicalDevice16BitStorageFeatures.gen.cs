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

namespace SharpVk
{
    /// <summary>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct PhysicalDevice16BitStorageFeatures
    {
        /// <summary>
        /// </summary>
        public bool StorageBuffer16BitAccess
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool UniformAndStorageBuffer16BitAccess
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool StoragePushConstant16
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool StorageInputOutput16
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(Interop.PhysicalDevice16BitStorageFeatures* pointer)
        {
            pointer->SType = StructureType.PhysicalDevice16BitStorageFeaturesVersion;
            pointer->Next = null;
            pointer->StorageBuffer16BitAccess = StorageBuffer16BitAccess;
            pointer->UniformAndStorageBuffer16BitAccess = UniformAndStorageBuffer16BitAccess;
            pointer->StoragePushConstant16 = StoragePushConstant16;
            pointer->StorageInputOutput16 = StorageInputOutput16;
        }

        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe PhysicalDevice16BitStorageFeatures MarshalFrom(Interop.PhysicalDevice16BitStorageFeatures* pointer)
        {
            var result = default(PhysicalDevice16BitStorageFeatures);
            result.StorageBuffer16BitAccess = pointer->StorageBuffer16BitAccess;
            result.UniformAndStorageBuffer16BitAccess = pointer->UniformAndStorageBuffer16BitAccess;
            result.StoragePushConstant16 = pointer->StoragePushConstant16;
            result.StorageInputOutput16 = pointer->StorageInputOutput16;
            return result;
        }
    }
}
