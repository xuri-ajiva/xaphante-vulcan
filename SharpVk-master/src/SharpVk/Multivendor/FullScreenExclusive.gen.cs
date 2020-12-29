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

namespace SharpVk.Multivendor
{
    /// <summary>
    ///     Hint values an application can specify affecting full-screen transition
    ///     behavior
    /// </summary>
    public enum FullScreenExclusive
    {
        /// <summary>
        ///     Indicates the implementation should determine the appropriate
        ///     full-screen method by whatever means it deems appropriate.
        /// </summary>
        Default = 0,

        /// <summary>
        ///     Indicates the implementation may use full-screen exclusive
        ///     mechanisms when available. Such mechanisms may result in better
        ///     performance and/or the availability of different presentation
        ///     capabilities, but may require a more disruptive transition during
        ///     swapchain initialization, first presentation and/or destruction.
        /// </summary>
        Allowed = 1,

        /// <summary>
        ///     Indicates the implementation should avoid using full-screen
        ///     mechanisms which rely on disruptive transitions.
        /// </summary>
        Disallowed = 2,

        /// <summary>
        ///     Indicates the application will manage full-screen exclusive mode by
        ///     using the vkAcquireFullScreenExclusiveModeEXT and
        ///     vkReleaseFullScreenExclusiveModeEXT commands.
        /// </summary>
        ApplicationControlled = 3
    }
}