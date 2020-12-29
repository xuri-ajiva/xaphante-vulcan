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

namespace SharpVk.NVidia.Experimental
{
    /// <summary>
    ///     Structure specifying the image view for handle queries
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct ImageViewHandleInfo
    {
        /// <summary>
        ///     The image view to query.
        /// </summary>
        public ImageView ImageView
        {
            get;
            set;
        }

        /// <summary>
        ///     The type of descriptor for which to query a handle.
        /// </summary>
        public DescriptorType DescriptorType
        {
            get;
            set;
        }

        /// <summary>
        ///     The sampler to combine with the image view when generating the
        ///     handle.
        /// </summary>
        public Sampler Sampler
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(Interop.NVidia.Experimental.ImageViewHandleInfo* pointer)
        {
            pointer->SType = StructureType.ImageViewHandleInfo;
            pointer->Next = null;
            pointer->ImageView = ImageView?.handle ?? default(Interop.ImageView);
            pointer->DescriptorType = DescriptorType;
            pointer->Sampler = Sampler?.handle ?? default(Interop.Sampler);
        }
    }
}