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
    ///     Structure specifying parameters of a newly created sampler.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct SamplerCreateInfo
    {
        /// <summary>
        ///     Reserved for future use.
        /// </summary>
        public SamplerCreateFlags? Flags
        {
            get;
            set;
        }

        /// <summary>
        ///     The magnification filter to apply to lookups.
        /// </summary>
        public Filter MagFilter
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public Filter MinFilter
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public SamplerMipmapMode MipmapMode
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public SamplerAddressMode AddressModeU
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public SamplerAddressMode AddressModeV
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public SamplerAddressMode AddressModeW
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public float MipLodBias
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool AnisotropyEnable
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public float MaxAnisotropy
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool CompareEnable
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public CompareOp CompareOp
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public float MinLod
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public float MaxLod
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public BorderColor BorderColor
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public bool UnnormalizedCoordinates
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(Interop.SamplerCreateInfo* pointer)
        {
            pointer->SType = StructureType.SamplerCreateInfo;
            pointer->Next = null;
            if (Flags != null)
                pointer->Flags = Flags.Value;
            else
                pointer->Flags = default;
            pointer->MagFilter = MagFilter;
            pointer->MinFilter = MinFilter;
            pointer->MipmapMode = MipmapMode;
            pointer->AddressModeU = AddressModeU;
            pointer->AddressModeV = AddressModeV;
            pointer->AddressModeW = AddressModeW;
            pointer->MipLodBias = MipLodBias;
            pointer->AnisotropyEnable = AnisotropyEnable;
            pointer->MaxAnisotropy = MaxAnisotropy;
            pointer->CompareEnable = CompareEnable;
            pointer->CompareOp = CompareOp;
            pointer->MinLod = MinLod;
            pointer->MaxLod = MaxLod;
            pointer->BorderColor = BorderColor;
            pointer->UnnormalizedCoordinates = UnnormalizedCoordinates;
        }
    }
}