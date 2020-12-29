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
    ///     Bitmask controlling how a pipeline is generated.
    /// </summary>
    [Flags]
    public enum PipelineCreateFlags
    {
        /// <summary>
        /// </summary>
        None = 0,

        /// <summary>
        ///     Specifies that the created pipeline will not be optimized. Using
        ///     this flag may reduce the time taken to create the pipeline.
        /// </summary>
        DisableOptimization = 1 << 0,

        /// <summary>
        ///     Specifies that the pipeline to be created is allowed to be the
        ///     parent of a pipeline that will be created in a subsequent call to
        ///     flink:vkCreateGraphicsPipelines.
        /// </summary>
        AllowDerivatives = 1 << 1,

        /// <summary>
        ///     Specifies that the pipeline to be created will be a child of a
        ///     previously created parent pipeline.
        /// </summary>
        Derivative = 1 << 2,

        /// <summary>
        /// </summary>
        ViewIndexFromDeviceIndex = 1 << 3,

        /// <summary>
        /// </summary>
        DispatchBaseVersion = 1 << 4,

        /// <summary>
        /// </summary>
        Extension151Bit0 = 1 << 11,

        /// <summary>
        /// </summary>
        Extension151Bit1 = 1 << 14,

        /// <summary>
        /// </summary>
        Extension151Bit2 = 1 << 15,

        /// <summary>
        /// </summary>
        Extension151Bit3 = 1 << 16,

        /// <summary>
        /// </summary>
        Extension151Bit4 = 1 << 17,

        /// <summary>
        /// </summary>
        DeferCompile = 1 << 5,

        /// <summary>
        /// </summary>
        CaptureStatistics = 1 << 6,

        /// <summary>
        /// </summary>
        CaptureInternalRepresentations = 1 << 7,

        /// <summary>
        /// </summary>
        Extension291Bit0 = 1 << 12,

        /// <summary>
        /// </summary>
        Extension291Bit1 = 1 << 13,

        /// <summary>
        /// </summary>
        Reserved8 = 1 << 8,

        /// <summary>
        /// </summary>
        Reserved9 = 1 << 9,

        /// <summary>
        /// </summary>
        Reserved10 = 1 << 10
    }
}