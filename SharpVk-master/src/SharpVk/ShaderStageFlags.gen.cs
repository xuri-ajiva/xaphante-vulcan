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
    ///     Bitmask specifying a pipeline stage.
    /// </summary>
    [Flags]
    public enum ShaderStageFlags
    {
        /// <summary>
        /// </summary>
        None = 0,

        /// <summary>
        /// </summary>
        Vertex = 1 << 0,

        /// <summary>
        /// </summary>
        TessellationControl = 1 << 1,

        /// <summary>
        /// </summary>
        TessellationEvaluation = 1 << 2,

        /// <summary>
        /// </summary>
        Geometry = 1 << 3,

        /// <summary>
        /// </summary>
        Fragment = 1 << 4,

        /// <summary>
        /// </summary>
        Compute = 1 << 5,

        /// <summary>
        /// </summary>
        AllGraphics = 0x0000001F,

        /// <summary>
        /// </summary>
        All = 0x7FFFFFFF,

        /// <summary>
        /// </summary>
        Raygen = 1 << 8,

        /// <summary>
        /// </summary>
        AnyHit = 1 << 9,

        /// <summary>
        /// </summary>
        ClosestHit = 1 << 10,

        /// <summary>
        /// </summary>
        Miss = 1 << 11,

        /// <summary>
        /// </summary>
        Intersection = 1 << 12,

        /// <summary>
        /// </summary>
        Callable = 1 << 13,

        /// <summary>
        /// </summary>
        Task = 1 << 6,

        /// <summary>
        /// </summary>
        Mesh = 1 << 7
    }
}