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

namespace SharpVk.Intel
{
    /// <summary>
    ///     Type of the parameters that can be queried
    /// </summary>
    public enum PerformanceValueType
    {
        /// <summary>
        ///     Specifies that unsigned 32-bit integer data is returned in
        ///     data.value32.
        /// </summary>
        Uint32 = 0,

        /// <summary>
        ///     Specifies that unsigned 64-bit integer data is returned in
        ///     data.value64.
        /// </summary>
        Uint64 = 1,

        /// <summary>
        ///     Specifies that floating-point data is returned in data.valueFloat.
        /// </summary>
        Float = 2,

        /// <summary>
        ///     Specifies that Bool32 data is returned in data.valueBool.
        /// </summary>
        Bool = 3,

        /// <summary>
        ///     Specifies that a pointer to a NULL-terminated string is returned in
        ///     data.valueString. The pointer is valid for the lifetime of the
        ///     device parameter passed to vkGetPerformanceParameterINTEL.
        /// </summary>
        String = 4
    }
}