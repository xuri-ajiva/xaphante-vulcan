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

namespace SharpVk.Interop
{
    /// <summary>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct PhysicalDeviceFloatControlsProperties
    {
        /// <summary>
        ///     The type of this structure.
        /// </summary>
        public StructureType SType;

        /// <summary>
        ///     Null or a pointer to an extension-specific structure.
        /// </summary>
        public void* Next;

        /// <summary>
        /// </summary>
        public ShaderFloatControlsIndependence DenormBehaviorIndependence;

        /// <summary>
        /// </summary>
        public ShaderFloatControlsIndependence RoundingModeIndependence;

        /// <summary>
        ///     A boolean value indicating whether an implementation supports the
        ///     round-towards-zero rounding mode for 16-bit floating-point
        ///     arithmetic and conversion instructions. It also indicates whether
        ///     the RoundingModeRTZ execution mode can be used for 16-bit
        ///     floating-point types.
        /// </summary>
        public Bool32 ShaderSignedZeroInfNanPreserveFloat16;

        /// <summary>
        ///     A boolean value indicating whether an implementation supports the
        ///     round-towards-zero rounding mode for 32-bit floating-point
        ///     arithmetic and conversion instructions. It also indicates whether
        ///     the RoundingModeRTZ execution mode can be used for 32-bit
        ///     floating-point types.
        /// </summary>
        public Bool32 ShaderSignedZeroInfNanPreserveFloat32;

        /// <summary>
        ///     A boolean value indicating whether an implementation supports the
        ///     round-towards-zero rounding mode for 64-bit floating-point
        ///     arithmetic and conversion instructions. It also indicates whether
        ///     the RoundingModeRTZ execution mode can be used for 64-bit
        ///     floating-point types.
        /// </summary>
        public Bool32 ShaderSignedZeroInfNanPreserveFloat64;

        /// <summary>
        ///     A boolean value indicating whether denormals can be preserved in
        ///     16-bit floating-point computations. It also indicates whether the
        ///     DenormPreserve execution mode can be used for 16-bit floating-point
        ///     types.
        /// </summary>
        public Bool32 ShaderDenormPreserveFloat16;

        /// <summary>
        ///     A boolean value indicating whether denormals can be preserved in
        ///     32-bit floating-point computations. It also indicates whether the
        ///     DenormPreserve execution mode can be used for 32-bit floating-point
        ///     types.
        /// </summary>
        public Bool32 ShaderDenormPreserveFloat32;

        /// <summary>
        ///     A boolean value indicating whether denormals can be preserved in
        ///     64-bit floating-point computations. It also indicates whether the
        ///     DenormPreserve execution mode can be used for 64-bit floating-point
        ///     types.
        /// </summary>
        public Bool32 ShaderDenormPreserveFloat64;

        /// <summary>
        ///     A boolean value indicating whether sign of a zero, Nans and ±∞ can
        ///     be preserved in 16-bit floating-point computations. It also
        ///     indicates whether the SignedZeroInfNanPreserve execution mode can
        ///     be used for 16-bit floating-point types.
        /// </summary>
        public Bool32 ShaderDenormFlushToZeroFloat16;

        /// <summary>
        ///     A boolean value indicating whether sign of a zero, Nans and ±∞ can
        ///     be preserved in 32-bit floating-point computations. It also
        ///     indicates whether the SignedZeroInfNanPreserve execution mode can
        ///     be used for 32-bit floating-point types.
        /// </summary>
        public Bool32 ShaderDenormFlushToZeroFloat32;

        /// <summary>
        ///     A boolean value indicating whether sign of a zero, Nans and ±∞ can
        ///     be preserved in 64-bit floating-point computations. It also
        ///     indicates whether the SignedZeroInfNanPreserve execution mode can
        ///     be used for 64-bit floating-point types.
        /// </summary>
        public Bool32 ShaderDenormFlushToZeroFloat64;

        /// <summary>
        ///     A boolean value indicating whether denormals can be flushed to zero
        ///     in 16-bit floating-point computations. It also indicates whether
        ///     the DenormFlushToZero execution mode can be used for 16-bit
        ///     floating-point types.
        /// </summary>
        public Bool32 ShaderRoundingModeRTEFloat16;

        /// <summary>
        ///     A boolean value indicating whether denormals can be flushed to zero
        ///     in 32-bit floating-point computations. It also indicates whether
        ///     the DenormFlushToZero execution mode can be used for 32-bit
        ///     floating-point types.
        /// </summary>
        public Bool32 ShaderRoundingModeRTEFloat32;

        /// <summary>
        ///     A boolean value indicating whether denormals can be flushed to zero
        ///     in 64-bit floating-point computations. It also indicates whether
        ///     the DenormFlushToZero execution mode can be used for 164-bit
        ///     floating-point types.
        /// </summary>
        public Bool32 ShaderRoundingModeRTEFloat64;

        /// <summary>
        ///     A boolean value indicating whether an implementation supports the
        ///     round-to-nearest-even rounding mode for 16-bit floating-point
        ///     arithmetic and conversion instructions. It also indicates whether
        ///     the RoundingModeRTE execution mode can be used for 16-bit
        ///     floating-point types.
        /// </summary>
        public Bool32 ShaderRoundingModeRTZFloat16;

        /// <summary>
        ///     A boolean value indicating whether an implementation supports the
        ///     round-to-nearest-even rounding mode for 32-bit floating-point
        ///     arithmetic and conversion instructions. It also indicates whether
        ///     the RoundingModeRTE execution mode can be used for 32-bit
        ///     floating-point types.
        /// </summary>
        public Bool32 ShaderRoundingModeRTZFloat32;

        /// <summary>
        ///     A boolean value indicating whether an implementation supports the
        ///     round-to-nearest-even rounding mode for 64-bit floating-point
        ///     arithmetic and conversion instructions. It also indicates whether
        ///     the RoundingModeRTE execution mode can be used for 64-bit
        ///     floating-point types.
        /// </summary>
        public Bool32 ShaderRoundingModeRTZFloat64;
    }
}