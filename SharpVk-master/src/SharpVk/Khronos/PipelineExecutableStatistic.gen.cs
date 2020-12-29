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
using SharpVk.Interop;

namespace SharpVk.Khronos
{
    /// <summary>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct PipelineExecutableStatistic
    {
        /// <summary>
        /// </summary>
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public string Description
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public PipelineExecutableStatisticFormat Format
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public PipelineExecutableStatisticValue Value
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe PipelineExecutableStatistic MarshalFrom(Interop.Khronos.PipelineExecutableStatistic* pointer)
        {
            var result = default(PipelineExecutableStatistic);
            result.Name = HeapUtil.MarshalStringFrom(pointer->Name, Constants.MaxDescriptionSize, true);
            result.Description = HeapUtil.MarshalStringFrom(pointer->Description, Constants.MaxDescriptionSize, true);
            result.Format = pointer->Format;
            result.Value = pointer->Value;
            return result;
        }
    }
}