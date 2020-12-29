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

namespace SharpVk
{
    /// <summary>
    ///     Available image formats.
    /// </summary>
    public enum Format
    {
        /// <summary>
        ///     The format is not specified.
        /// </summary>
        Undefined = 0,

        /// <summary>
        ///     A two-component, 8-bit packed unsigned normalized format that has a
        ///     4-bit R component in bits 4..7, and a 4-bit G component in bits
        ///     0..3.
        /// </summary>
        R4G4UNormPack8 = 1,

        /// <summary>
        ///     A four-component, 16-bit packed unsigned normalized format that has
        ///     a 4-bit R component in bits 12..15, a 4-bit G component in bits
        ///     8..11, a 4-bit B component in bits 4..7, and a 4-bit A component in
        ///     bits 0..3.
        /// </summary>
        R4G4B4A4UNormPack16 = 2,

        /// <summary>
        ///     A four-component, 16-bit packed unsigned normalized format that has
        ///     a 4-bit B component in bits 12..15, a 4-bit G component in bits
        ///     8..11, a 4-bit R component in bits 4..7, and a 4-bit A component in
        ///     bits 0..3.
        /// </summary>
        B4G4R4A4UNormPack16 = 3,

        /// <summary>
        ///     A three-component, 16-bit packed unsigned normalized format that
        ///     has a 5-bit R component in bits 11..15, a 6-bit G component in bits
        ///     5..10, and a 5-bit B component in bits 0..4.
        /// </summary>
        R5G6B5UNormPack16 = 4,

        /// <summary>
        ///     A three-component, 16-bit packed unsigned normalized format that
        ///     has a 5-bit B component in bits 11..15, a 6-bit G component in bits
        ///     5..10, and a 5-bit R component in bits 0..4.
        /// </summary>
        B5G6R5UNormPack16 = 5,

        /// <summary>
        ///     A four-component, 16-bit packed unsigned normalized format that has
        ///     a 5-bit R component in bits 11..15, a 5-bit G component in bits
        ///     6..10, a 5-bit B component in bits 1..5, and a 1-bit A component in
        ///     bit 0.
        /// </summary>
        R5G5B5A1UNormPack16 = 6,

        /// <summary>
        ///     A four-component, 16-bit packed unsigned normalized format that has
        ///     a 5-bit B component in bits 11..15, a 5-bit G component in bits
        ///     6..10, a 5-bit R component in bits 1..5, and a 1-bit A component in
        ///     bit 0.
        /// </summary>
        B5G5R5A1UNormPack16 = 7,

        /// <summary>
        ///     A four-component, 16-bit packed unsigned normalized format that has
        ///     a 1-bit A component in bit 15, a 5-bit R component in bits 10..14,
        ///     a 5-bit G component in bits 5..9, and a 5-bit B component in bits
        ///     0..4.
        /// </summary>
        A1R5G5B5UNormPack16 = 8,

        /// <summary>
        ///     A one-component, 8-bit unsigned normalized format that has a single
        ///     8-bit R component.
        /// </summary>
        R8UNorm = 9,

        /// <summary>
        ///     A one-component, 8-bit signed normalized format that has a single
        ///     8-bit R component.
        /// </summary>
        R8SNorm = 10,

        /// <summary>
        ///     A one-component, 8-bit unsigned scaled integer format that has a
        ///     single 8-bit R component.
        /// </summary>
        R8UScaled = 11,

        /// <summary>
        ///     A one-component, 8-bit signed scaled integer format that has a
        ///     single 8-bit R component.
        /// </summary>
        R8SScaled = 12,

        /// <summary>
        ///     A one-component, 8-bit unsigned integer format that has a single
        ///     8-bit R component.
        /// </summary>
        R8UInt = 13,

        /// <summary>
        ///     A one-component, 8-bit signed integer format that has a single
        ///     8-bit R component.
        /// </summary>
        R8SInt = 14,

        /// <summary>
        ///     A one-component, 8-bit unsigned normalized format that has a single
        ///     8-bit R component stored with sRGB nonlinear encoding.
        /// </summary>
        R8Srgb = 15,

        /// <summary>
        ///     A two-component, 16-bit unsigned normalized format that has an
        ///     8-bit R component in byte 0, and an 8-bit G component in byte 1.
        /// </summary>
        R8G8UNorm = 16,

        /// <summary>
        ///     A two-component, 16-bit signed normalized format that has an 8-bit
        ///     R component in byte 0, and an 8-bit G component in byte 1.
        /// </summary>
        R8G8SNorm = 17,

        /// <summary>
        ///     A two-component, 16-bit unsigned scaled integer format that has an
        ///     8-bit R component in byte 0, and an 8-bit G component in byte 1.
        /// </summary>
        R8G8UScaled = 18,

        /// <summary>
        ///     A two-component, 16-bit signed scaled integer format that has an
        ///     8-bit R component in byte 0, and an 8-bit G component in byte 1.
        /// </summary>
        R8G8SScaled = 19,

        /// <summary>
        ///     A two-component, 16-bit unsigned integer format that has an 8-bit R
        ///     component in byte 0, and an 8-bit G component in byte 1.
        /// </summary>
        R8G8UInt = 20,

        /// <summary>
        ///     A two-component, 16-bit signed integer format that has an 8-bit R
        ///     component in byte 0, and an 8-bit G component in byte 1.
        /// </summary>
        R8G8SInt = 21,

        /// <summary>
        ///     A two-component, 16-bit unsigned normalized format that has an
        ///     8-bit R component stored with sRGB nonlinear encoding in byte 0,
        ///     and an 8-bit G component stored with sRGB nonlinear encoding in
        ///     byte 1.
        /// </summary>
        R8G8Srgb = 22,

        /// <summary>
        ///     A three-component, 24-bit unsigned normalized format that has an
        ///     8-bit R component in byte 0, an 8-bit G component in byte 1, and an
        ///     8-bit B component in byte 2.
        /// </summary>
        R8G8B8UNorm = 23,

        /// <summary>
        ///     A three-component, 24-bit signed normalized format that has an
        ///     8-bit R component in byte 0, an 8-bit G component in byte 1, and an
        ///     8-bit B component in byte 2.
        /// </summary>
        R8G8B8SNorm = 24,

        /// <summary>
        ///     A three-component, 24-bit unsigned scaled format that has an 8-bit
        ///     R component in byte 0, an 8-bit G component in byte 1, and an 8-bit
        ///     B component in byte 2.
        /// </summary>
        R8G8B8UScaled = 25,

        /// <summary>
        ///     A three-component, 24-bit signed scaled format that has an 8-bit R
        ///     component in byte 0, an 8-bit G component in byte 1, and an 8-bit B
        ///     component in byte 2.
        /// </summary>
        R8G8B8SScaled = 26,

        /// <summary>
        ///     A three-component, 24-bit unsigned integer format that has an 8-bit
        ///     R component in byte 0, an 8-bit G component in byte 1, and an 8-bit
        ///     B component in byte 2.
        /// </summary>
        R8G8B8UInt = 27,

        /// <summary>
        ///     A three-component, 24-bit signed integer format that has an 8-bit R
        ///     component in byte 0, an 8-bit G component in byte 1, and an 8-bit B
        ///     component in byte 2.
        /// </summary>
        R8G8B8SInt = 28,

        /// <summary>
        ///     A three-component, 24-bit unsigned normalized format that has an
        ///     8-bit R component stored with sRGB nonlinear encoding in byte 0, an
        ///     8-bit G component stored with sRGB nonlinear encoding in byte 1,
        ///     and an 8-bit B component stored with sRGB nonlinear encoding in
        ///     byte 2.
        /// </summary>
        R8G8B8Srgb = 29,

        /// <summary>
        ///     A three-component, 24-bit unsigned normalized format that has an
        ///     8-bit B component in byte 0, an 8-bit G component in byte 1, and an
        ///     8-bit R component in byte 2.
        /// </summary>
        B8G8R8UNorm = 30,

        /// <summary>
        ///     A three-component, 24-bit signed normalized format that has an
        ///     8-bit B component in byte 0, an 8-bit G component in byte 1, and an
        ///     8-bit R component in byte 2.
        /// </summary>
        B8G8R8SNorm = 31,

        /// <summary>
        ///     A three-component, 24-bit unsigned scaled format that has an 8-bit
        ///     B component in byte 0, an 8-bit G component in byte 1, and an 8-bit
        ///     R component in byte 2.
        /// </summary>
        B8G8R8UScaled = 32,

        /// <summary>
        ///     A three-component, 24-bit signed scaled format that has an 8-bit B
        ///     component in byte 0, an 8-bit G component in byte 1, and an 8-bit R
        ///     component in byte 2.
        /// </summary>
        B8G8R8SScaled = 33,

        /// <summary>
        ///     A three-component, 24-bit unsigned integer format that has an 8-bit
        ///     B component in byte 0, an 8-bit G component in byte 1, and an 8-bit
        ///     R component in byte 2.
        /// </summary>
        B8G8R8UInt = 34,

        /// <summary>
        ///     A three-component, 24-bit signed integer format that has an 8-bit B
        ///     component in byte 0, an 8-bit G component in byte 1, and an 8-bit R
        ///     component in byte 2.
        /// </summary>
        B8G8R8SInt = 35,

        /// <summary>
        ///     A three-component, 24-bit unsigned normalized format that has an
        ///     8-bit B component stored with sRGB nonlinear encoding in byte 0, an
        ///     8-bit G component stored with sRGB nonlinear encoding in byte 1,
        ///     and an 8-bit R component stored with sRGB nonlinear encoding in
        ///     byte 2.
        /// </summary>
        B8G8R8Srgb = 36,

        /// <summary>
        ///     A four-component, 32-bit unsigned normalized format that has an
        ///     8-bit R component in byte 0, an 8-bit G component in byte 1, an
        ///     8-bit B component in byte 2, and an 8-bit A component in byte 3.
        /// </summary>
        R8G8B8A8UNorm = 37,

        /// <summary>
        ///     A four-component, 32-bit signed normalized format that has an 8-bit
        ///     R component in byte 0, an 8-bit G component in byte 1, an 8-bit B
        ///     component in byte 2, and an 8-bit A component in byte 3.
        /// </summary>
        R8G8B8A8SNorm = 38,

        /// <summary>
        ///     A four-component, 32-bit unsigned scaled format that has an 8-bit R
        ///     component in byte 0, an 8-bit G component in byte 1, an 8-bit B
        ///     component in byte 2, and an 8-bit A component in byte 3.
        /// </summary>
        R8G8B8A8UScaled = 39,

        /// <summary>
        ///     A four-component, 32-bit signed scaled format that has an 8-bit R
        ///     component in byte 0, an 8-bit G component in byte 1, an 8-bit B
        ///     component in byte 2, and an 8-bit A component in byte 3.
        /// </summary>
        R8G8B8A8SScaled = 40,

        /// <summary>
        ///     A four-component, 32-bit unsigned integer format that has an 8-bit
        ///     R component in byte 0, an 8-bit G component in byte 1, an 8-bit B
        ///     component in byte 2, and an 8-bit A component in byte 3.
        /// </summary>
        R8G8B8A8UInt = 41,

        /// <summary>
        ///     A four-component, 32-bit signed integer format that has an 8-bit R
        ///     component in byte 0, an 8-bit G component in byte 1, an 8-bit B
        ///     component in byte 2, and an 8-bit A component in byte 3.
        /// </summary>
        R8G8B8A8SInt = 42,

        /// <summary>
        ///     A four-component, 32-bit unsigned normalized format that has an
        ///     8-bit R component stored with sRGB nonlinear encoding in byte 0, an
        ///     8-bit G component stored with sRGB nonlinear encoding in byte 1, an
        ///     8-bit B component stored with sRGB nonlinear encoding in byte 2,
        ///     and an 8-bit A component in byte 3.
        /// </summary>
        R8G8B8A8Srgb = 43,

        /// <summary>
        ///     A four-component, 32-bit unsigned normalized format that has an
        ///     8-bit B component in byte 0, an 8-bit G component in byte 1, an
        ///     8-bit R component in byte 2, and an 8-bit A component in byte 3.
        /// </summary>
        B8G8R8A8UNorm = 44,

        /// <summary>
        ///     A four-component, 32-bit signed normalized format that has an 8-bit
        ///     B component in byte 0, an 8-bit G component in byte 1, an 8-bit R
        ///     component in byte 2, and an 8-bit A component in byte 3.
        /// </summary>
        B8G8R8A8SNorm = 45,

        /// <summary>
        ///     A four-component, 32-bit unsigned scaled format that has an 8-bit B
        ///     component in byte 0, an 8-bit G component in byte 1, an 8-bit R
        ///     component in byte 2, and an 8-bit A component in byte 3.
        /// </summary>
        B8G8R8A8UScaled = 46,

        /// <summary>
        ///     A four-component, 32-bit signed scaled format that has an 8-bit B
        ///     component in byte 0, an 8-bit G component in byte 1, an 8-bit R
        ///     component in byte 2, and an 8-bit A component in byte 3.
        /// </summary>
        B8G8R8A8SScaled = 47,

        /// <summary>
        ///     A four-component, 32-bit unsigned integer format that has an 8-bit
        ///     B component in byte 0, an 8-bit G component in byte 1, an 8-bit R
        ///     component in byte 2, and an 8-bit A component in byte 3.
        /// </summary>
        B8G8R8A8UInt = 48,

        /// <summary>
        ///     A four-component, 32-bit signed integer format that has an 8-bit B
        ///     component in byte 0, an 8-bit G component in byte 1, an 8-bit R
        ///     component in byte 2, and an 8-bit A component in byte 3.
        /// </summary>
        B8G8R8A8SInt = 49,

        /// <summary>
        ///     A four-component, 32-bit unsigned normalized format that has an
        ///     8-bit B component stored with sRGB nonlinear encoding in byte 0, an
        ///     8-bit G component stored with sRGB nonlinear encoding in byte 1, an
        ///     8-bit R component stored with sRGB nonlinear encoding in byte 2,
        ///     and an 8-bit A component in byte 3.
        /// </summary>
        B8G8R8A8Srgb = 50,

        /// <summary>
        ///     A four-component, 32-bit packed unsigned normalized format that has
        ///     an 8-bit A component in bits 24..31, an 8-bit B component in bits
        ///     16..23, an 8-bit G component in bits 8..15, and an 8-bit R
        ///     component in bits 0..7.
        /// </summary>
        A8B8G8R8UNormPack32 = 51,

        /// <summary>
        ///     A four-component, 32-bit packed signed normalized format that has
        ///     an 8-bit A component in bits 24..31, an 8-bit B component in bits
        ///     16..23, an 8-bit G component in bits 8..15, and an 8-bit R
        ///     component in bits 0..7.
        /// </summary>
        A8B8G8R8SNormPack32 = 52,

        /// <summary>
        ///     A four-component, 32-bit packed unsigned scaled integer format that
        ///     has an 8-bit A component in bits 24..31, an 8-bit B component in
        ///     bits 16..23, an 8-bit G component in bits 8..15, and an 8-bit R
        ///     component in bits 0..7.
        /// </summary>
        A8B8G8R8UScaledPack32 = 53,

        /// <summary>
        ///     A four-component, 32-bit packed signed scaled integer format that
        ///     has an 8-bit A component in bits 24..31, an 8-bit B component in
        ///     bits 16..23, an 8-bit G component in bits 8..15, and an 8-bit R
        ///     component in bits 0..7.
        /// </summary>
        A8B8G8R8SScaledPack32 = 54,

        /// <summary>
        ///     A four-component, 32-bit packed unsigned integer format that has an
        ///     8-bit A component in bits 24..31, an 8-bit B component in bits
        ///     16..23, an 8-bit G component in bits 8..15, and an 8-bit R
        ///     component in bits 0..7.
        /// </summary>
        A8B8G8R8UIntPack32 = 55,

        /// <summary>
        ///     A four-component, 32-bit packed signed integer format that has an
        ///     8-bit A component in bits 24..31, an 8-bit B component in bits
        ///     16..23, an 8-bit G component in bits 8..15, and an 8-bit R
        ///     component in bits 0..7.
        /// </summary>
        A8B8G8R8SIntPack32 = 56,

        /// <summary>
        ///     A four-component, 32-bit packed unsigned normalized format that has
        ///     an 8-bit A component in bits 24..31, an 8-bit B component stored
        ///     with sRGB nonlinear encoding in bits 16..23, an 8-bit G component
        ///     stored with sRGB nonlinear encoding in bits 8..15, and an 8-bit R
        ///     component stored with sRGB nonlinear encoding in bits 0..7.
        /// </summary>
        A8B8G8R8SrgbPack32 = 57,

        /// <summary>
        ///     A four-component, 32-bit packed unsigned normalized format that has
        ///     a 2-bit A component in bits 30..31, a 10-bit R component in bits
        ///     20..29, a 10-bit G component in bits 10..19, and a 10-bit B
        ///     component in bits 0..9.
        /// </summary>
        A2R10G10B10UNormPack32 = 58,

        /// <summary>
        ///     A four-component, 32-bit packed signed normalized format that has a
        ///     2-bit A component in bits 30..31, a 10-bit R component in bits
        ///     20..29, a 10-bit G component in bits 10..19, and a 10-bit B
        ///     component in bits 0..9.
        /// </summary>
        A2R10G10B10SNormPack32 = 59,

        /// <summary>
        ///     A four-component, 32-bit packed unsigned scaled integer format that
        ///     has a 2-bit A component in bits 30..31, a 10-bit R component in
        ///     bits 20..29, a 10-bit G component in bits 10..19, and a 10-bit B
        ///     component in bits 0..9.
        /// </summary>
        A2R10G10B10UScaledPack32 = 60,

        /// <summary>
        ///     A four-component, 32-bit packed signed scaled integer format that
        ///     has a 2-bit A component in bits 30..31, a 10-bit R component in
        ///     bits 20..29, a 10-bit G component in bits 10..19, and a 10-bit B
        ///     component in bits 0..9.
        /// </summary>
        A2R10G10B10SScaledPack32 = 61,

        /// <summary>
        ///     A four-component, 32-bit packed unsigned integer format that has a
        ///     2-bit A component in bits 30..31, a 10-bit R component in bits
        ///     20..29, a 10-bit G component in bits 10..19, and a 10-bit B
        ///     component in bits 0..9.
        /// </summary>
        A2R10G10B10UIntPack32 = 62,

        /// <summary>
        ///     A four-component, 32-bit packed signed integer format that has a
        ///     2-bit A component in bits 30..31, a 10-bit R component in bits
        ///     20..29, a 10-bit G component in bits 10..19, and a 10-bit B
        ///     component in bits 0..9.
        /// </summary>
        A2R10G10B10SIntPack32 = 63,

        /// <summary>
        ///     A four-component, 32-bit packed unsigned normalized format that has
        ///     a 2-bit A component in bits 30..31, a 10-bit B component in bits
        ///     20..29, a 10-bit G component in bits 10..19, and a 10-bit R
        ///     component in bits 0..9.
        /// </summary>
        A2B10G10R10UNormPack32 = 64,

        /// <summary>
        ///     A four-component, 32-bit packed signed normalized format that has a
        ///     2-bit A component in bits 30..31, a 10-bit B component in bits
        ///     20..29, a 10-bit G component in bits 10..19, and a 10-bit R
        ///     component in bits 0..9.
        /// </summary>
        A2B10G10R10SNormPack32 = 65,

        /// <summary>
        ///     A four-component, 32-bit packed unsigned scaled integer format that
        ///     has a 2-bit A component in bits 30..31, a 10-bit B component in
        ///     bits 20..29, a 10-bit G component in bits 10..19, and a 10-bit R
        ///     component in bits 0..9.
        /// </summary>
        A2B10G10R10UScaledPack32 = 66,

        /// <summary>
        ///     A four-component, 32-bit packed signed scaled integer format that
        ///     has a 2-bit A component in bits 30..31, a 10-bit B component in
        ///     bits 20..29, a 10-bit G component in bits 10..19, and a 10-bit R
        ///     component in bits 0..9.
        /// </summary>
        A2B10G10R10SScaledPack32 = 67,

        /// <summary>
        ///     A four-component, 32-bit packed unsigned integer format that has a
        ///     2-bit A component in bits 30..31, a 10-bit B component in bits
        ///     20..29, a 10-bit G component in bits 10..19, and a 10-bit R
        ///     component in bits 0..9.
        /// </summary>
        A2B10G10R10UIntPack32 = 68,

        /// <summary>
        ///     A four-component, 32-bit packed signed integer format that has a
        ///     2-bit A component in bits 30..31, a 10-bit B component in bits
        ///     20..29, a 10-bit G component in bits 10..19, and a 10-bit R
        ///     component in bits 0..9.
        /// </summary>
        A2B10G10R10SIntPack32 = 69,

        /// <summary>
        ///     A one-component, 16-bit unsigned normalized format that has a
        ///     single 16-bit R component.
        /// </summary>
        R16UNorm = 70,

        /// <summary>
        ///     A one-component, 16-bit signed normalized format that has a single
        ///     16-bit R component.
        /// </summary>
        R16SNorm = 71,

        /// <summary>
        ///     A one-component, 16-bit unsigned scaled integer format that has a
        ///     single 16-bit R component.
        /// </summary>
        R16UScaled = 72,

        /// <summary>
        ///     A one-component, 16-bit signed scaled integer format that has a
        ///     single 16-bit R component.
        /// </summary>
        R16SScaled = 73,

        /// <summary>
        ///     A one-component, 16-bit unsigned integer format that has a single
        ///     16-bit R component.
        /// </summary>
        R16UInt = 74,

        /// <summary>
        ///     A one-component, 16-bit signed integer format that has a single
        ///     16-bit R component.
        /// </summary>
        R16SInt = 75,

        /// <summary>
        ///     A one-component, 16-bit signed floating-point format that has a
        ///     single 16-bit R component.
        /// </summary>
        R16SFloat = 76,

        /// <summary>
        ///     A two-component, 32-bit unsigned normalized format that has a
        ///     16-bit R component in bytes 0..1, and a 16-bit G component in bytes
        ///     2..3.
        /// </summary>
        R16G16UNorm = 77,

        /// <summary>
        ///     A two-component, 32-bit signed normalized format that has a 16-bit
        ///     R component in bytes 0..1, and a 16-bit G component in bytes 2..3.
        /// </summary>
        R16G16SNorm = 78,

        /// <summary>
        ///     A two-component, 32-bit unsigned scaled integer format that has a
        ///     16-bit R component in bytes 0..1, and a 16-bit G component in bytes
        ///     2..3.
        /// </summary>
        R16G16UScaled = 79,

        /// <summary>
        ///     A two-component, 32-bit signed scaled integer format that has a
        ///     16-bit R component in bytes 0..1, and a 16-bit G component in bytes
        ///     2..3.
        /// </summary>
        R16G16SScaled = 80,

        /// <summary>
        ///     A two-component, 32-bit unsigned integer format that has a 16-bit R
        ///     component in bytes 0..1, and a 16-bit G component in bytes 2..3.
        /// </summary>
        R16G16UInt = 81,

        /// <summary>
        ///     A two-component, 32-bit signed integer format that has a 16-bit R
        ///     component in bytes 0..1, and a 16-bit G component in bytes 2..3.
        /// </summary>
        R16G16SInt = 82,

        /// <summary>
        ///     A two-component, 32-bit signed floating-point format that has a
        ///     16-bit R component in bytes 0..1, and a 16-bit G component in bytes
        ///     2..3.
        /// </summary>
        R16G16SFloat = 83,

        /// <summary>
        ///     A three-component, 48-bit unsigned normalized format that has a
        ///     16-bit R component in bytes 0..1, a 16-bit G component in bytes
        ///     2..3, and a 16-bit B component in bytes 4..5.
        /// </summary>
        R16G16B16UNorm = 84,

        /// <summary>
        ///     A three-component, 48-bit signed normalized format that has a
        ///     16-bit R component in bytes 0..1, a 16-bit G component in bytes
        ///     2..3, and a 16-bit B component in bytes 4..5.
        /// </summary>
        R16G16B16SNorm = 85,

        /// <summary>
        ///     A three-component, 48-bit unsigned scaled integer format that has a
        ///     16-bit R component in bytes 0..1, a 16-bit G component in bytes
        ///     2..3, and a 16-bit B component in bytes 4..5.
        /// </summary>
        R16G16B16UScaled = 86,

        /// <summary>
        ///     A three-component, 48-bit signed scaled integer format that has a
        ///     16-bit R component in bytes 0..1, a 16-bit G component in bytes
        ///     2..3, and a 16-bit B component in bytes 4..5.
        /// </summary>
        R16G16B16SScaled = 87,

        /// <summary>
        ///     A three-component, 48-bit unsigned integer format that has a 16-bit
        ///     R component in bytes 0..1, a 16-bit G component in bytes 2..3, and
        ///     a 16-bit B component in bytes 4..5.
        /// </summary>
        R16G16B16UInt = 88,

        /// <summary>
        ///     A three-component, 48-bit signed integer format that has a 16-bit R
        ///     component in bytes 0..1, a 16-bit G component in bytes 2..3, and a
        ///     16-bit B component in bytes 4..5.
        /// </summary>
        R16G16B16SInt = 89,

        /// <summary>
        ///     A three-component, 48-bit signed floating-point format that has a
        ///     16-bit R component in bytes 0..1, a 16-bit G component in bytes
        ///     2..3, and a 16-bit B component in bytes 4..5.
        /// </summary>
        R16G16B16SFloat = 90,

        /// <summary>
        ///     A four-component, 64-bit unsigned normalized format that has a
        ///     16-bit R component in bytes 0..1, a 16-bit G component in bytes
        ///     2..3, a 16-bit B component in bytes 4..5, and a 16-bit A component
        ///     in bytes 6..7.
        /// </summary>
        R16G16B16A16UNorm = 91,

        /// <summary>
        ///     A four-component, 64-bit signed normalized format that has a 16-bit
        ///     R component in bytes 0..1, a 16-bit G component in bytes 2..3, a
        ///     16-bit B component in bytes 4..5, and a 16-bit A component in bytes
        ///     6..7.
        /// </summary>
        R16G16B16A16SNorm = 92,

        /// <summary>
        ///     A four-component, 64-bit unsigned scaled integer format that has a
        ///     16-bit R component in bytes 0..1, a 16-bit G component in bytes
        ///     2..3, a 16-bit B component in bytes 4..5, and a 16-bit A component
        ///     in bytes 6..7.
        /// </summary>
        R16G16B16A16UScaled = 93,

        /// <summary>
        ///     A four-component, 64-bit signed scaled integer format that has a
        ///     16-bit R component in bytes 0..1, a 16-bit G component in bytes
        ///     2..3, a 16-bit B component in bytes 4..5, and a 16-bit A component
        ///     in bytes 6..7.
        /// </summary>
        R16G16B16A16SScaled = 94,

        /// <summary>
        ///     A four-component, 64-bit unsigned integer format that has a 16-bit
        ///     R component in bytes 0..1, a 16-bit G component in bytes 2..3, a
        ///     16-bit B component in bytes 4..5, and a 16-bit A component in bytes
        ///     6..7.
        /// </summary>
        R16G16B16A16UInt = 95,

        /// <summary>
        ///     A four-component, 64-bit signed integer format that has a 16-bit R
        ///     component in bytes 0..1, a 16-bit G component in bytes 2..3, a
        ///     16-bit B component in bytes 4..5, and a 16-bit A component in bytes
        ///     6..7.
        /// </summary>
        R16G16B16A16SInt = 96,

        /// <summary>
        ///     A four-component, 64-bit signed floating-point format that has a
        ///     16-bit R component in bytes 0..1, a 16-bit G component in bytes
        ///     2..3, a 16-bit B component in bytes 4..5, and a 16-bit A component
        ///     in bytes 6..7.
        /// </summary>
        R16G16B16A16SFloat = 97,

        /// <summary>
        ///     A one-component, 32-bit unsigned integer format that has a single
        ///     32-bit R component.
        /// </summary>
        R32UInt = 98,

        /// <summary>
        ///     A one-component, 32-bit signed integer format that has a single
        ///     32-bit R component.
        /// </summary>
        R32SInt = 99,

        /// <summary>
        ///     A one-component, 32-bit signed floating-point format that has a
        ///     single 32-bit R component.
        /// </summary>
        R32SFloat = 100,

        /// <summary>
        ///     A two-component, 64-bit unsigned integer format that has a 32-bit R
        ///     component in bytes 0..3, and a 32-bit G component in bytes 4..7.
        /// </summary>
        R32G32UInt = 101,

        /// <summary>
        ///     A two-component, 64-bit signed integer format that has a 32-bit R
        ///     component in bytes 0..3, and a 32-bit G component in bytes 4..7.
        /// </summary>
        R32G32SInt = 102,

        /// <summary>
        ///     A two-component, 64-bit signed floating-point format that has a
        ///     32-bit R component in bytes 0..3, and a 32-bit G component in bytes
        ///     4..7.
        /// </summary>
        R32G32SFloat = 103,

        /// <summary>
        ///     A three-component, 96-bit unsigned integer format that has a 32-bit
        ///     R component in bytes 0..3, a 32-bit G component in bytes 4..7, and
        ///     a 32-bit B component in bytes 8..11.
        /// </summary>
        R32G32B32UInt = 104,

        /// <summary>
        ///     A three-component, 96-bit signed integer format that has a 32-bit R
        ///     component in bytes 0..3, a 32-bit G component in bytes 4..7, and a
        ///     32-bit B component in bytes 8..11.
        /// </summary>
        R32G32B32SInt = 105,

        /// <summary>
        ///     A three-component, 96-bit signed floating-point format that has a
        ///     32-bit R component in bytes 0..3, a 32-bit G component in bytes
        ///     4..7, and a 32-bit B component in bytes 8..11.
        /// </summary>
        R32G32B32SFloat = 106,

        /// <summary>
        ///     A four-component, 128-bit unsigned integer format that has a 32-bit
        ///     R component in bytes 0..3, a 32-bit G component in bytes 4..7, a
        ///     32-bit B component in bytes 8..11, and a 32-bit A component in
        ///     bytes 12..15.
        /// </summary>
        R32G32B32A32UInt = 107,

        /// <summary>
        ///     A four-component, 128-bit signed integer format that has a 32-bit R
        ///     component in bytes 0..3, a 32-bit G component in bytes 4..7, a
        ///     32-bit B component in bytes 8..11, and a 32-bit A component in
        ///     bytes 12..15.
        /// </summary>
        R32G32B32A32SInt = 108,

        /// <summary>
        ///     A four-component, 128-bit signed floating-point format that has a
        ///     32-bit R component in bytes 0..3, a 32-bit G component in bytes
        ///     4..7, a 32-bit B component in bytes 8..11, and a 32-bit A component
        ///     in bytes 12..15.
        /// </summary>
        R32G32B32A32SFloat = 109,

        /// <summary>
        ///     A one-component, 64-bit unsigned integer format that has a single
        ///     64-bit R component.
        /// </summary>
        R64UInt = 110,

        /// <summary>
        ///     A one-component, 64-bit signed integer format that has a single
        ///     64-bit R component.
        /// </summary>
        R64SInt = 111,

        /// <summary>
        ///     A one-component, 64-bit signed floating-point format that has a
        ///     single 64-bit R component.
        /// </summary>
        R64SFloat = 112,

        /// <summary>
        ///     A two-component, 128-bit unsigned integer format that has a 64-bit
        ///     R component in bytes 0..7, and a 64-bit G component in bytes 8..15.
        /// </summary>
        R64G64UInt = 113,

        /// <summary>
        ///     A two-component, 128-bit signed integer format that has a 64-bit R
        ///     component in bytes 0..7, and a 64-bit G component in bytes 8..15.
        /// </summary>
        R64G64SInt = 114,

        /// <summary>
        ///     A two-component, 128-bit signed floating-point format that has a
        ///     64-bit R component in bytes 0..7, and a 64-bit G component in bytes
        ///     8..15.
        /// </summary>
        R64G64SFloat = 115,

        /// <summary>
        ///     A three-component, 192-bit unsigned integer format that has a
        ///     64-bit R component in bytes 0..7, a 64-bit G component in bytes
        ///     8..15, and a 64-bit B component in bytes 16..23.
        /// </summary>
        R64G64B64UInt = 116,

        /// <summary>
        ///     A three-component, 192-bit signed integer format that has a 64-bit
        ///     R component in bytes 0..7, a 64-bit G component in bytes 8..15, and
        ///     a 64-bit B component in bytes 16..23.
        /// </summary>
        R64G64B64SInt = 117,

        /// <summary>
        ///     A three-component, 192-bit signed floating-point format that has a
        ///     64-bit R component in bytes 0..7, a 64-bit G component in bytes
        ///     8..15, and a 64-bit B component in bytes 16..23.
        /// </summary>
        R64G64B64SFloat = 118,

        /// <summary>
        ///     A four-component, 256-bit unsigned integer format that has a 64-bit
        ///     R component in bytes 0..7, a 64-bit G component in bytes 8..15, a
        ///     64-bit B component in bytes 16..23, and a 64-bit A component in
        ///     bytes 24..31.
        /// </summary>
        R64G64B64A64UInt = 119,

        /// <summary>
        ///     A four-component, 256-bit signed integer format that has a 64-bit R
        ///     component in bytes 0..7, a 64-bit G component in bytes 8..15, a
        ///     64-bit B component in bytes 16..23, and a 64-bit A component in
        ///     bytes 24..31.
        /// </summary>
        R64G64B64A64SInt = 120,

        /// <summary>
        ///     A four-component, 256-bit signed floating-point format that has a
        ///     64-bit R component in bytes 0..7, a 64-bit G component in bytes
        ///     8..15, a 64-bit B component in bytes 16..23, and a 64-bit A
        ///     component in bytes 24..31.
        /// </summary>
        R64G64B64A64SFloat = 121,

        /// <summary>
        ///     A three-component, 32-bit packed unsigned floating-point format
        ///     that has a 10-bit B component in bits 22..31, an 11-bit G component
        ///     in bits 11..21, an 11-bit R component in bits 0..10. See
        ///     &lt;&lt;fundamentals-fp10 and &lt;&lt;fundamentals-fp11.
        /// </summary>
        B10G11R11UFloatPack32 = 122,

        /// <summary>
        ///     A three-component, 32-bit packed unsigned floating-point format
        ///     that has a 5-bit shared exponent in bits 27..31, a 9-bit B
        ///     component mantissa in bits 18..26, a 9-bit G component mantissa in
        ///     bits 9..17, and a 9-bit R component mantissa in bits 0..8.
        /// </summary>
        E5B9G9R9UFloatPack32 = 123,

        /// <summary>
        ///     A one-component, 16-bit unsigned normalized format that has a
        ///     single 16-bit depth component.
        /// </summary>
        D16UNorm = 124,

        /// <summary>
        ///     A two-component, 32-bit format that has 24 unsigned normalized bits
        ///     in the depth component and, optionally:, 8 bits that are unused.
        /// </summary>
        X8D24UNormPack32 = 125,

        /// <summary>
        ///     A one-component, 32-bit signed floating-point format that has
        ///     32-bits in the depth component.
        /// </summary>
        D32SFloat = 126,

        /// <summary>
        ///     A one-component, 8-bit unsigned integer format that has 8-bits in
        ///     the stencil component.
        /// </summary>
        S8UInt = 127,

        /// <summary>
        ///     A two-component, 24-bit format that has 16 unsigned normalized bits
        ///     in the depth component and 8 unsigned integer bits in the stencil
        ///     component.
        /// </summary>
        D16UNormS8UInt = 128,

        /// <summary>
        ///     A two-component, 32-bit packed format that has 8 unsigned integer
        ///     bits in the stencil component, and 24 unsigned normalized bits in
        ///     the depth component.
        /// </summary>
        D24UNormS8UInt = 129,

        /// <summary>
        ///     A two-component format that has 32 signed float bits in the depth
        ///     component and 8 unsigned integer bits in the stencil component.
        ///     There are optionally: 24-bits that are unused.
        /// </summary>
        D32SFloatS8UInt = 130,

        /// <summary>
        ///     A three-component, block-compressed format where each 64-bit
        ///     compressed texel block encodes a 4x4 rectangle of unsigned
        ///     normalized RGB texel data. This format has no alpha and is
        ///     considered opaque.
        /// </summary>
        Bc1RgbUNormBlock = 131,

        /// <summary>
        ///     A three-component, block-compressed format where each 64-bit
        ///     compressed texel block encodes a 4x4 rectangle of unsigned
        ///     normalized RGB texel data with sRGB nonlinear encoding. This format
        ///     has no alpha and is considered opaque.
        /// </summary>
        Bc1RgbSrgbBlock = 132,

        /// <summary>
        ///     A four-component, block-compressed format where each 64-bit
        ///     compressed texel block encodes a 4x4 rectangle of unsigned
        ///     normalized RGB texel data, and provides 1 bit of alpha.
        /// </summary>
        Bc1RgbaUNormBlock = 133,

        /// <summary>
        ///     A four-component, block-compressed format where each 64-bit
        ///     compressed texel block encodes a 4x4 rectangle of unsigned
        ///     normalized RGB texel data with sRGB nonlinear encoding, and
        ///     provides 1 bit of alpha.
        /// </summary>
        Bc1RgbaSrgbBlock = 134,

        /// <summary>
        ///     A four-component, block-compressed format where each 128-bit
        ///     compressed texel block encodes a 4x4 rectangle of unsigned
        ///     normalized RGBA texel data with the first 64 bits encoding alpha
        ///     values followed by 64 bits encoding RGB values.
        /// </summary>
        Bc2UNormBlock = 135,

        /// <summary>
        ///     A four-component, block-compressed format where each 128-bit
        ///     compressed texel block encodes a 4x4 rectangle of unsigned
        ///     normalized RGBA texel data with the first 64 bits encoding alpha
        ///     values followed by 64 bits encoding RGB values with sRGB nonlinear
        ///     encoding.
        /// </summary>
        Bc2SrgbBlock = 136,

        /// <summary>
        ///     A four-component, block-compressed format where each 128-bit
        ///     compressed texel block encodes a 4x4 rectangle of unsigned
        ///     normalized RGBA texel data with the first 64 bits encoding alpha
        ///     values followed by 64 bits encoding RGB values.
        /// </summary>
        Bc3UNormBlock = 137,

        /// <summary>
        ///     A four-component, block-compressed format where each 128-bit
        ///     compressed texel block encodes a 4x4 rectangle of unsigned
        ///     normalized RGBA texel data with the first 64 bits encoding alpha
        ///     values followed by 64 bits encoding RGB values with sRGB nonlinear
        ///     encoding.
        /// </summary>
        Bc3SrgbBlock = 138,

        /// <summary>
        ///     A one-component, block-compressed format where each 64-bit
        ///     compressed texel block encodes a 4x4 rectangle of unsigned
        ///     normalized red texel data.
        /// </summary>
        Bc4UNormBlock = 139,

        /// <summary>
        ///     A one-component, block-compressed format where each 64-bit
        ///     compressed texel block encodes a 4x4 rectangle of signed normalized
        ///     red texel data.
        /// </summary>
        Bc4SNormBlock = 140,

        /// <summary>
        ///     A two-component, block-compressed format where each 128-bit
        ///     compressed texel block encodes a 4x4 rectangle of unsigned
        ///     normalized RG texel data with the first 64 bits encoding red values
        ///     followed by 64 bits encoding green values.
        /// </summary>
        Bc5UNormBlock = 141,

        /// <summary>
        ///     A two-component, block-compressed format where each 128-bit
        ///     compressed texel block encodes a 4x4 rectangle of signed normalized
        ///     RG texel data with the first 64 bits encoding red values followed
        ///     by 64 bits encoding green values.
        /// </summary>
        Bc5SNormBlock = 142,

        /// <summary>
        ///     A three-component, block-compressed format where each 128-bit
        ///     compressed texel block encodes a 4x4 rectangle of unsigned
        ///     floating-point RGB texel data.
        /// </summary>
        Bc6HUFloatBlock = 143,

        /// <summary>
        ///     A three-component, block-compressed format where each 128-bit
        ///     compressed texel block encodes a 4x4 rectangle of signed
        ///     floating-point RGB texel data.
        /// </summary>
        Bc6HSFloatBlock = 144,

        /// <summary>
        ///     A four-component, block-compressed format where each 128-bit
        ///     compressed texel block encodes a 4x4 rectangle of unsigned
        ///     normalized RGBA texel data.
        /// </summary>
        Bc7UNormBlock = 145,

        /// <summary>
        ///     A four-component, block-compressed format where each 128-bit
        ///     compressed texel block encodes a 4x4 rectangle of unsigned
        ///     normalized RGBA texel data with sRGB nonlinear encoding applied to
        ///     the RGB components.
        /// </summary>
        Bc7SrgbBlock = 146,

        /// <summary>
        ///     A three-component, ETC2 compressed format where each 64-bit
        ///     compressed texel block encodes a 4x4 rectangle of unsigned
        ///     normalized RGB texel data. This format has no alpha and is
        ///     considered opaque.
        /// </summary>
        Etc2R8G8B8UNormBlock = 147,

        /// <summary>
        ///     A three-component, ETC2 compressed format where each 64-bit
        ///     compressed texel block encodes a 4x4 rectangle of unsigned
        ///     normalized RGB texel data with sRGB nonlinear encoding. This format
        ///     has no alpha and is considered opaque.
        /// </summary>
        Etc2R8G8B8SrgbBlock = 148,

        /// <summary>
        ///     A four-component, ETC2 compressed format where each 64-bit
        ///     compressed texel block encodes a 4x4 rectangle of unsigned
        ///     normalized RGB texel data, and provides 1 bit of alpha.
        /// </summary>
        Etc2R8G8B8A1UNormBlock = 149,

        /// <summary>
        ///     A four-component, ETC2 compressed format where each 64-bit
        ///     compressed texel block encodes a 4x4 rectangle of unsigned
        ///     normalized RGB texel data with sRGB nonlinear encoding, and
        ///     provides 1 bit of alpha.
        /// </summary>
        Etc2R8G8B8A1SrgbBlock = 150,

        /// <summary>
        ///     A four-component, ETC2 compressed format where each 128-bit
        ///     compressed texel block encodes a 4x4 rectangle of unsigned
        ///     normalized RGBA texel data with the first 64 bits encoding alpha
        ///     values followed by 64 bits encoding RGB values.
        /// </summary>
        Etc2R8G8B8A8UNormBlock = 151,

        /// <summary>
        ///     A four-component, ETC2 compressed format where each 64-bit
        ///     compressed texel block encodes a 4x4 rectangle of unsigned
        ///     normalized RGBA texel data with the first 64 bits encoding alpha
        ///     values followed by 64 bits encoding RGB values with sRGB nonlinear
        ///     encoding applied.
        /// </summary>
        Etc2R8G8B8A8SrgbBlock = 152,

        /// <summary>
        ///     A one-component, ETC2 compressed format where each 64-bit
        ///     compressed texel block encodes a 4x4 rectangle of unsigned
        ///     normalized red texel data.
        /// </summary>
        EacR11UNormBlock = 153,

        /// <summary>
        ///     A one-component, ETC2 compressed format where each 64-bit
        ///     compressed texel block encodes a 4x4 rectangle of signed normalized
        ///     red texel data.
        /// </summary>
        EacR11SNormBlock = 154,

        /// <summary>
        ///     A two-component, ETC2 compressed format where each 128-bit
        ///     compressed texel block encodes a 4x4 rectangle of unsigned
        ///     normalized RG texel data with the first 64 bits encoding red values
        ///     followed by 64 bits encoding green values.
        /// </summary>
        EacR11G11UNormBlock = 155,

        /// <summary>
        ///     A two-component, ETC2 compressed format where each 128-bit
        ///     compressed texel block encodes a 4x4 rectangle of signed normalized
        ///     RG texel data with the first 64 bits encoding red values followed
        ///     by 64 bits encoding green values.
        /// </summary>
        EacR11G11SNormBlock = 156,

        /// <summary>
        ///     A four-component, ASTC compressed format where each 128-bit
        ///     compressed texel block encodes a 4x4 rectangle of unsigned
        ///     normalized RGBA texel data.
        /// </summary>
        Astc4X4UNormBlock = 157,

        /// <summary>
        ///     A four-component, ASTC compressed format where each 128-bit
        ///     compressed texel block encodes a 4x4 rectangle of unsigned
        ///     normalized RGBA texel data with sRGB nonlinear encoding applied to
        ///     the RGB components.
        /// </summary>
        Astc4X4SrgbBlock = 158,

        /// <summary>
        ///     A four-component, ASTC compressed format where each 128-bit
        ///     compressed texel block encodes a 5x4 rectangle of unsigned
        ///     normalized RGBA texel data.
        /// </summary>
        Astc5X4UNormBlock = 159,

        /// <summary>
        ///     A four-component, ASTC compressed format where each 128-bit
        ///     compressed texel block encodes a 5x4 rectangle of unsigned
        ///     normalized RGBA texel data with sRGB nonlinear encoding applied to
        ///     the RGB components.
        /// </summary>
        Astc5X4SrgbBlock = 160,

        /// <summary>
        ///     A four-component, ASTC compressed format where each 128-bit
        ///     compressed texel block encodes a 5x5 rectangle of unsigned
        ///     normalized RGBA texel data.
        /// </summary>
        Astc5X5UNormBlock = 161,

        /// <summary>
        ///     A four-component, ASTC compressed format where each 128-bit
        ///     compressed texel block encodes a 5x5 rectangle of unsigned
        ///     normalized RGBA texel data with sRGB nonlinear encoding applied to
        ///     the RGB components.
        /// </summary>
        Astc5X5SrgbBlock = 162,

        /// <summary>
        ///     A four-component, ASTC compressed format where each 128-bit
        ///     compressed texel block encodes a 6x5 rectangle of unsigned
        ///     normalized RGBA texel data.
        /// </summary>
        Astc6X5UNormBlock = 163,

        /// <summary>
        ///     A four-component, ASTC compressed format where each 128-bit
        ///     compressed texel block encodes a 6x5 rectangle of unsigned
        ///     normalized RGBA texel data with sRGB nonlinear encoding applied to
        ///     the RGB components.
        /// </summary>
        Astc6X5SrgbBlock = 164,

        /// <summary>
        ///     A four-component, ASTC compressed format where each 128-bit
        ///     compressed texel block encodes a 6x6 rectangle of unsigned
        ///     normalized RGBA texel data.
        /// </summary>
        Astc6X6UNormBlock = 165,

        /// <summary>
        ///     A four-component, ASTC compressed format where each 128-bit
        ///     compressed texel block encodes a 6x6 rectangle of unsigned
        ///     normalized RGBA texel data with sRGB nonlinear encoding applied to
        ///     the RGB components.
        /// </summary>
        Astc6X6SrgbBlock = 166,

        /// <summary>
        ///     A four-component, ASTC compressed format where each 128-bit
        ///     compressed texel block encodes an 8x5 rectangle of unsigned
        ///     normalized RGBA texel data.
        /// </summary>
        Astc8X5UNormBlock = 167,

        /// <summary>
        ///     A four-component, ASTC compressed format where each 128-bit
        ///     compressed texel block encodes an 8x5 rectangle of unsigned
        ///     normalized RGBA texel data with sRGB nonlinear encoding applied to
        ///     the RGB components.
        /// </summary>
        Astc8X5SrgbBlock = 168,

        /// <summary>
        ///     A four-component, ASTC compressed format where each 128-bit
        ///     compressed texel block encodes an 8x6 rectangle of unsigned
        ///     normalized RGBA texel data.
        /// </summary>
        Astc8X6UNormBlock = 169,

        /// <summary>
        ///     A four-component, ASTC compressed format where each 128-bit
        ///     compressed texel block encodes an 8x6 rectangle of unsigned
        ///     normalized RGBA texel data with sRGB nonlinear encoding applied to
        ///     the RGB components.
        /// </summary>
        Astc8X6SrgbBlock = 170,

        /// <summary>
        ///     A four-component, ASTC compressed format where each 128-bit
        ///     compressed texel block encodes an 8x8 rectangle of unsigned
        ///     normalized RGBA texel data.
        /// </summary>
        Astc8X8UNormBlock = 171,

        /// <summary>
        ///     A four-component, ASTC compressed format where each 128-bit
        ///     compressed texel block encodes an 8x8 rectangle of unsigned
        ///     normalized RGBA texel data with sRGB nonlinear encoding applied to
        ///     the RGB components.
        /// </summary>
        Astc8X8SrgbBlock = 172,

        /// <summary>
        ///     A four-component, ASTC compressed format where each 128-bit
        ///     compressed texel block encodes a 10x5 rectangle of unsigned
        ///     normalized RGBA texel data.
        /// </summary>
        Astc10X5UNormBlock = 173,

        /// <summary>
        ///     A four-component, ASTC compressed format where each 128-bit
        ///     compressed texel block encodes a 10x5 rectangle of unsigned
        ///     normalized RGBA texel data with sRGB nonlinear encoding applied to
        ///     the RGB components.
        /// </summary>
        Astc10X5SrgbBlock = 174,

        /// <summary>
        ///     A four-component, ASTC compressed format where each 128-bit
        ///     compressed texel block encodes a 10x6 rectangle of unsigned
        ///     normalized RGBA texel data.
        /// </summary>
        Astc10X6UNormBlock = 175,

        /// <summary>
        ///     A four-component, ASTC compressed format where each 128-bit
        ///     compressed texel block encodes a 10x6 rectangle of unsigned
        ///     normalized RGBA texel data with sRGB nonlinear encoding applied to
        ///     the RGB components.
        /// </summary>
        Astc10X6SrgbBlock = 176,

        /// <summary>
        ///     A four-component, ASTC compressed format where each 128-bit
        ///     compressed texel block encodes a 10x8 rectangle of unsigned
        ///     normalized RGBA texel data.
        /// </summary>
        Astc10X8UNormBlock = 177,

        /// <summary>
        ///     A four-component, ASTC compressed format where each 128-bit
        ///     compressed texel block encodes a 10x8 rectangle of unsigned
        ///     normalized RGBA texel data with sRGB nonlinear encoding applied to
        ///     the RGB components.
        /// </summary>
        Astc10X8SrgbBlock = 178,

        /// <summary>
        ///     A four-component, ASTC compressed format where each 128-bit
        ///     compressed texel block encodes a 10x10 rectangle of unsigned
        ///     normalized RGBA texel data.
        /// </summary>
        Astc10X10UNormBlock = 179,

        /// <summary>
        ///     A four-component, ASTC compressed format where each 128-bit
        ///     compressed texel block encodes a 10x10 rectangle of unsigned
        ///     normalized RGBA texel data with sRGB nonlinear encoding applied to
        ///     the RGB components.
        /// </summary>
        Astc10X10SrgbBlock = 180,

        /// <summary>
        ///     A four-component, ASTC compressed format where each 128-bit
        ///     compressed texel block encodes a 12x10 rectangle of unsigned
        ///     normalized RGBA texel data.
        /// </summary>
        Astc12X10UNormBlock = 181,

        /// <summary>
        ///     A four-component, ASTC compressed format where each 128-bit
        ///     compressed texel block encodes a 12x10 rectangle of unsigned
        ///     normalized RGBA texel data with sRGB nonlinear encoding applied to
        ///     the RGB components.
        /// </summary>
        Astc12X10SrgbBlock = 182,

        /// <summary>
        ///     A four-component, ASTC compressed format where each 128-bit
        ///     compressed texel block encodes a 12x12 rectangle of unsigned
        ///     normalized RGBA texel data.
        /// </summary>
        Astc12X12UNormBlock = 183,

        /// <summary>
        ///     A four-component, ASTC compressed format where each 128-bit
        ///     compressed texel block encodes a 12x12 rectangle of unsigned
        ///     normalized RGBA texel data with sRGB nonlinear encoding applied to
        ///     the RGB components.
        /// </summary>
        Astc12X12SrgbBlock = 184,

        /// <summary>
        /// </summary>
        G8B8G8R8422UNormVersion = 1000156000,

        /// <summary>
        /// </summary>
        B8G8R8G8422UNormVersion = 1000156001,

        /// <summary>
        /// </summary>
        G8B8R83Plane420UNormVersion = 1000156002,

        /// <summary>
        /// </summary>
        G8B8R82Plane420UNormVersion = 1000156003,

        /// <summary>
        /// </summary>
        G8B8R83Plane422UNormVersion = 1000156004,

        /// <summary>
        /// </summary>
        G8B8R82Plane422UNormVersion = 1000156005,

        /// <summary>
        /// </summary>
        G8B8R83Plane444UNormVersion = 1000156006,

        /// <summary>
        /// </summary>
        R10X6UNormPack16Version = 1000156007,

        /// <summary>
        /// </summary>
        R10X6G10X6UNorm2Pack16Version = 1000156008,

        /// <summary>
        /// </summary>
        R10X6G10X6B10X6A10X6UNorm4Pack16Version = 1000156009,

        /// <summary>
        /// </summary>
        G10X6B10X6G10X6R10X6422UNorm4Pack16Version = 1000156010,

        /// <summary>
        /// </summary>
        B10X6G10X6R10X6G10X6422UNorm4Pack16Version = 1000156011,

        /// <summary>
        /// </summary>
        G10X6B10X6R10X63Plane420UNorm3Pack16Version = 1000156012,

        /// <summary>
        /// </summary>
        G10X6B10X6R10X62Plane420UNorm3Pack16Version = 1000156013,

        /// <summary>
        /// </summary>
        G10X6B10X6R10X63Plane422UNorm3Pack16Version = 1000156014,

        /// <summary>
        /// </summary>
        G10X6B10X6R10X62Plane422UNorm3Pack16Version = 1000156015,

        /// <summary>
        /// </summary>
        G10X6B10X6R10X63Plane444UNorm3Pack16Version = 1000156016,

        /// <summary>
        /// </summary>
        R12X4UNormPack16Version = 1000156017,

        /// <summary>
        /// </summary>
        R12X4G12X4UNorm2Pack16Version = 1000156018,

        /// <summary>
        /// </summary>
        R12X4G12X4B12X4A12X4UNorm4Pack16Version = 1000156019,

        /// <summary>
        /// </summary>
        G12X4B12X4G12X4R12X4422UNorm4Pack16Version = 1000156020,

        /// <summary>
        /// </summary>
        B12X4G12X4R12X4G12X4422UNorm4Pack16Version = 1000156021,

        /// <summary>
        /// </summary>
        G12X4B12X4R12X43Plane420UNorm3Pack16Version = 1000156022,

        /// <summary>
        /// </summary>
        G12X4B12X4R12X42Plane420UNorm3Pack16Version = 1000156023,

        /// <summary>
        /// </summary>
        G12X4B12X4R12X43Plane422UNorm3Pack16Version = 1000156024,

        /// <summary>
        /// </summary>
        G12X4B12X4R12X42Plane422UNorm3Pack16Version = 1000156025,

        /// <summary>
        /// </summary>
        G12X4B12X4R12X43Plane444UNorm3Pack16Version = 1000156026,

        /// <summary>
        /// </summary>
        G16B16G16R16422UNormVersion = 1000156027,

        /// <summary>
        /// </summary>
        B16G16R16G16422UNormVersion = 1000156028,

        /// <summary>
        /// </summary>
        G16B16R163Plane420UNormVersion = 1000156029,

        /// <summary>
        /// </summary>
        G16B16R162Plane420UNormVersion = 1000156030,

        /// <summary>
        /// </summary>
        G16B16R163Plane422UNormVersion = 1000156031,

        /// <summary>
        /// </summary>
        G16B16R162Plane422UNormVersion = 1000156032,

        /// <summary>
        /// </summary>
        G16B16R163Plane444UNormVersion = 1000156033,

        /// <summary>
        /// </summary>
        Pvrtc12BppUNormBlock = 1000054000,

        /// <summary>
        /// </summary>
        Pvrtc14BppUNormBlock = 1000054001,

        /// <summary>
        /// </summary>
        Pvrtc22BppUNormBlock = 1000054002,

        /// <summary>
        /// </summary>
        Pvrtc24BppUNormBlock = 1000054003,

        /// <summary>
        /// </summary>
        Pvrtc12BppSrgbBlock = 1000054004,

        /// <summary>
        /// </summary>
        Pvrtc14BppSrgbBlock = 1000054005,

        /// <summary>
        /// </summary>
        Pvrtc22BppSrgbBlock = 1000054006,

        /// <summary>
        /// </summary>
        Pvrtc24BppSrgbBlock = 1000054007,

        /// <summary>
        /// </summary>
        Astc4X4SFloatBlock = 1000066000,

        /// <summary>
        /// </summary>
        Astc5X4SFloatBlock = 1000066001,

        /// <summary>
        /// </summary>
        Astc5X5SFloatBlock = 1000066002,

        /// <summary>
        /// </summary>
        Astc6X5SFloatBlock = 1000066003,

        /// <summary>
        /// </summary>
        Astc6X6SFloatBlock = 1000066004,

        /// <summary>
        /// </summary>
        Astc8X5SFloatBlock = 1000066005,

        /// <summary>
        /// </summary>
        Astc8X6SFloatBlock = 1000066006,

        /// <summary>
        /// </summary>
        Astc8X8SFloatBlock = 1000066007,

        /// <summary>
        /// </summary>
        Astc10X5SFloatBlock = 1000066008,

        /// <summary>
        /// </summary>
        Astc10X6SFloatBlock = 1000066009,

        /// <summary>
        /// </summary>
        Astc10X8SFloatBlock = 1000066010,

        /// <summary>
        /// </summary>
        Astc10X10SFloatBlock = 1000066011,

        /// <summary>
        /// </summary>
        Astc12X10SFloatBlock = 1000066012,

        /// <summary>
        /// </summary>
        Astc12X12SFloatBlock = 1000066013
    }
}
