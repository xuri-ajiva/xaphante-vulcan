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

using System;

namespace SharpVk
{
    /// <summary>
    ///     Bitmask specifying properties for a memory type.
    /// </summary>
    [Flags]
    public enum MemoryPropertyFlags
    {
        /// <summary>
        /// </summary>
        None = 0,

        /// <summary>
        /// </summary>
        DeviceLocal = 1 << 0,

        /// <summary>
        /// </summary>
        HostVisible = 1 << 1,

        /// <summary>
        /// </summary>
        HostCoherent = 1 << 2,

        /// <summary>
        /// </summary>
        HostCached = 1 << 3,

        /// <summary>
        /// </summary>
        LazilyAllocated = 1 << 4,

        /// <summary>
        /// </summary>
        Protected = 1 << 5,

        /// <summary>
        /// </summary>
        DeviceCoherent = 1 << 6,

        /// <summary>
        /// </summary>
        DeviceUncached = 1 << 7
    }
}