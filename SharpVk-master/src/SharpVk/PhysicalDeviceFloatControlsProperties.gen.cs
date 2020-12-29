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
    ///     Describes properties supported by VK_KHR_shader_float_controls
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct PhysicalDeviceFloatControlsProperties
    {
        /// <summary>
        /// </summary>
        public ShaderFloatControlsIndependence DenormBehaviorIndependence
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public ShaderFloatControlsIndependence RoundingModeIndependence
        {
            get;
            set;
        }

        /// <summary>
        ///     A boolean value indicating whether an implementation supports the
        ///     round-towards-zero rounding mode for 16-bit floating-point
        ///     arithmetic and conversion instructions. It also indicates whether
        ///     the RoundingModeRTZ execution mode can be used for 16-bit
        ///     floating-point types.
        /// </summary>
        public bool ShaderSignedZeroInfNanPreserveFloat16
        {
            get;
            set;
        }

        /// <summary>
        ///     A boolean value indicating whether an implementation supports the
        ///     round-towards-zero rounding mode for 32-bit floating-point
        ///     arithmetic and conversion instructions. It also indicates whether
        ///     the RoundingModeRTZ execution mode can be used for 32-bit
        ///     floating-point types.
        /// </summary>
        public bool ShaderSignedZeroInfNanPreserveFloat32
        {
            get;
            set;
        }

        /// <summary>
        ///     A boolean value indicating whether an implementation supports the
        ///     round-towards-zero rounding mode for 64-bit floating-point
        ///     arithmetic and conversion instructions. It also indicates whether
        ///     the RoundingModeRTZ execution mode can be used for 64-bit
        ///     floating-point types.
        /// </summary>
        public bool ShaderSignedZeroInfNanPreserveFloat64
        {
            get;
            set;
        }

        /// <summary>
        ///     A boolean value indicating whether denormals can be preserved in
        ///     16-bit floating-point computations. It also indicates whether the
        ///     DenormPreserve execution mode can be used for 16-bit floating-point
        ///     types.
        /// </summary>
        public bool ShaderDenormPreserveFloat16
        {
            get;
            set;
        }

        /// <summary>
        ///     A boolean value indicating whether denormals can be preserved in
        ///     32-bit floating-point computations. It also indicates whether the
        ///     DenormPreserve execution mode can be used for 32-bit floating-point
        ///     types.
        /// </summary>
        public bool ShaderDenormPreserveFloat32
        {
            get;
            set;
        }

        /// <summary>
        ///     A boolean value indicating whether denormals can be preserved in
        ///     64-bit floating-point computations. It also indicates whether the
        ///     DenormPreserve execution mode can be used for 64-bit floating-point
        ///     types.
        /// </summary>
        public bool ShaderDenormPreserveFloat64
        {
            get;
            set;
        }

        /// <summary>
        ///     A boolean value indicating whether sign of a zero, Nans and ±∞ can
        ///     be preserved in 16-bit floating-point computations. It also
        ///     indicates whether the SignedZeroInfNanPreserve execution mode can
        ///     be used for 16-bit floating-point types.
        /// </summary>
        public bool ShaderDenormFlushToZeroFloat16
        {
            get;
            set;
        }

        /// <summary>
        ///     A boolean value indicating whether sign of a zero, Nans and ±∞ can
        ///     be preserved in 32-bit floating-point computations. It also
        ///     indicates whether the SignedZeroInfNanPreserve execution mode can
        ///     be used for 32-bit floating-point types.
        /// </summary>
        public bool ShaderDenormFlushToZeroFloat32
        {
            get;
            set;
        }

        /// <summary>
        ///     A boolean value indicating whether sign of a zero, Nans and ±∞ can
        ///     be preserved in 64-bit floating-point computations. It also
        ///     indicates whether the SignedZeroInfNanPreserve execution mode can
        ///     be used for 64-bit floating-point types.
        /// </summary>
        public bool ShaderDenormFlushToZeroFloat64
        {
            get;
            set;
        }

        /// <summary>
        ///     A boolean value indicating whether denormals can be flushed to zero
        ///     in 16-bit floating-point computations. It also indicates whether
        ///     the DenormFlushToZero execution mode can be used for 16-bit
        ///     floating-point types.
        /// </summary>
        public bool ShaderRoundingModeRTEFloat16
        {
            get;
            set;
        }

        /// <summary>
        ///     A boolean value indicating whether denormals can be flushed to zero
        ///     in 32-bit floating-point computations. It also indicates whether
        ///     the DenormFlushToZero execution mode can be used for 32-bit
        ///     floating-point types.
        /// </summary>
        public bool ShaderRoundingModeRTEFloat32
        {
            get;
            set;
        }

        /// <summary>
        ///     A boolean value indicating whether denormals can be flushed to zero
        ///     in 64-bit floating-point computations. It also indicates whether
        ///     the DenormFlushToZero execution mode can be used for 164-bit
        ///     floating-point types.
        /// </summary>
        public bool ShaderRoundingModeRTEFloat64
        {
            get;
            set;
        }

        /// <summary>
        ///     A boolean value indicating whether an implementation supports the
        ///     round-to-nearest-even rounding mode for 16-bit floating-point
        ///     arithmetic and conversion instructions. It also indicates whether
        ///     the RoundingModeRTE execution mode can be used for 16-bit
        ///     floating-point types.
        /// </summary>
        public bool ShaderRoundingModeRTZFloat16
        {
            get;
            set;
        }

        /// <summary>
        ///     A boolean value indicating whether an implementation supports the
        ///     round-to-nearest-even rounding mode for 32-bit floating-point
        ///     arithmetic and conversion instructions. It also indicates whether
        ///     the RoundingModeRTE execution mode can be used for 32-bit
        ///     floating-point types.
        /// </summary>
        public bool ShaderRoundingModeRTZFloat32
        {
            get;
            set;
        }

        /// <summary>
        ///     A boolean value indicating whether an implementation supports the
        ///     round-to-nearest-even rounding mode for 64-bit floating-point
        ///     arithmetic and conversion instructions. It also indicates whether
        ///     the RoundingModeRTE execution mode can be used for 64-bit
        ///     floating-point types.
        /// </summary>
        public bool ShaderRoundingModeRTZFloat64
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe PhysicalDeviceFloatControlsProperties MarshalFrom(Interop.PhysicalDeviceFloatControlsProperties* pointer)
        {
            var result = default(PhysicalDeviceFloatControlsProperties);
            result.DenormBehaviorIndependence = pointer->DenormBehaviorIndependence;
            result.RoundingModeIndependence = pointer->RoundingModeIndependence;
            result.ShaderSignedZeroInfNanPreserveFloat16 = pointer->ShaderSignedZeroInfNanPreserveFloat16;
            result.ShaderSignedZeroInfNanPreserveFloat32 = pointer->ShaderSignedZeroInfNanPreserveFloat32;
            result.ShaderSignedZeroInfNanPreserveFloat64 = pointer->ShaderSignedZeroInfNanPreserveFloat64;
            result.ShaderDenormPreserveFloat16 = pointer->ShaderDenormPreserveFloat16;
            result.ShaderDenormPreserveFloat32 = pointer->ShaderDenormPreserveFloat32;
            result.ShaderDenormPreserveFloat64 = pointer->ShaderDenormPreserveFloat64;
            result.ShaderDenormFlushToZeroFloat16 = pointer->ShaderDenormFlushToZeroFloat16;
            result.ShaderDenormFlushToZeroFloat32 = pointer->ShaderDenormFlushToZeroFloat32;
            result.ShaderDenormFlushToZeroFloat64 = pointer->ShaderDenormFlushToZeroFloat64;
            result.ShaderRoundingModeRTEFloat16 = pointer->ShaderRoundingModeRTEFloat16;
            result.ShaderRoundingModeRTEFloat32 = pointer->ShaderRoundingModeRTEFloat32;
            result.ShaderRoundingModeRTEFloat64 = pointer->ShaderRoundingModeRTEFloat64;
            result.ShaderRoundingModeRTZFloat16 = pointer->ShaderRoundingModeRTZFloat16;
            result.ShaderRoundingModeRTZFloat32 = pointer->ShaderRoundingModeRTZFloat32;
            result.ShaderRoundingModeRTZFloat64 = pointer->ShaderRoundingModeRTZFloat64;
            return result;
        }
    }
}