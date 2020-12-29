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

namespace SharpVk.Khronos
{
    /// <summary>
    ///     Supported color space of the presentation engine.
    /// </summary>
    public enum ColorSpace
    {
        /// <summary>
        ///     Supports the sRGB color space.
        /// </summary>
        SrgbNonlinear = 0,

        /// <summary>
        ///     Specifies support for the Display-P3 color space to be displayed
        ///     using an sRGB-like EOTF.
        /// </summary>
        DisplayP3Nonlinear = 1000104001,

        /// <summary>
        ///     Specifies support for the extended sRGB color space to be displayed
        ///     using a linear EOTF.
        /// </summary>
        ExtendedSrgbLinear = 1000104002,

        /// <summary>
        ///     Specifies support for the Display-P3 color space to be displayed
        ///     using a linear EOTF
        /// </summary>
        DisplayP3Linear = 1000104003,

        /// <summary>
        ///     Supports the DCI-P3 color space and applies the Gamma 2.6 OETF.
        /// </summary>
        DciP3Nonlinear = 1000104004,

        /// <summary>
        ///     Supports the BT709 color space and applies a linear OETF.
        /// </summary>
        Bt709Linear = 1000104005,

        /// <summary>
        ///     Supports the BT709 color space and applies the SMPTE 170M OETF.
        /// </summary>
        Bt709Nonlinear = 1000104006,

        /// <summary>
        ///     Supports the BT2020 color space and applies a linear OETF.
        /// </summary>
        Bt2020Linear = 1000104007,

        /// <summary>
        ///     Specifies support for the HDR10 (BT2020 color) space to be
        ///     displayed using the SMPTE ST2084 Perceptual Quantizer (PQ) EOTF.
        /// </summary>
        Hdr10St2084 = 1000104008,

        /// <summary>
        ///     Specifies support for the Dolby Vision (BT2020 color space),
        ///     proprietary encoding, to be displayed using the SMPTE ST2084 EOTF.
        /// </summary>
        Dolbyvision = 1000104009,

        /// <summary>
        ///     Specifies support for the HDR10 (BT2020 color space) to be
        ///     displayed using the Hybrid Log Gamma (HLG) EOTF.
        /// </summary>
        Hdr10Hlg = 1000104010,

        /// <summary>
        ///     Supports the AdobeRGB color space and applies a linear OETF.
        /// </summary>
        AdobergbLinear = 1000104011,

        /// <summary>
        ///     Supports the AdobeRGB color space and applies the Gamma 2.2 OETF.
        /// </summary>
        AdobergbNonlinear = 1000104012,

        /// <summary>
        ///     Specifies that color components are used “as is”. This is intended
        ///     to allow applications to supply data for color spaces not described
        ///     here.
        /// </summary>
        PassThrough = 1000104013,

        /// <summary>
        ///     Specifies support for the extended sRGB color space to be displayed
        ///     using an sRGB EOTF.
        /// </summary>
        ExtendedSrgbNonlinear = 1000104014,

        /// <summary>
        ///     Support for the Display-P3 color space to be displayed using a
        ///     linear EOTF
        /// </summary>
        DisplayNative = 1000213000
    }
}