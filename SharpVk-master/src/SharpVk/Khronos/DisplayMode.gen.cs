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

using SharpVk.Interop;

namespace SharpVk.Khronos
{
    /// <summary>
    /// </summary>
    public class DisplayMode
    {
        internal readonly CommandCache CommandCache;
        internal readonly Interop.Khronos.DisplayMode Handle;

        internal readonly PhysicalDevice Parent;

        internal DisplayMode(PhysicalDevice parent, Interop.Khronos.DisplayMode handle)
        {
            this.Handle = handle;
            this.Parent = parent;
            CommandCache = parent.CommandCache;
        }

        /// <summary>
        ///     The raw handle for this instance.
        /// </summary>
        public Interop.Khronos.DisplayMode RawHandle => Handle;

        /// <summary>
        ///     Query capabilities of a mode and plane combination.
        /// </summary>
        /// <param name="planeIndex">
        /// </param>
        public unsafe DisplayPlaneCapabilities GetDisplayPlaneCapabilities(uint planeIndex)
        {
            try
            {
                var result = default(DisplayPlaneCapabilities);
                var marshalledCapabilities = default(DisplayPlaneCapabilities);
                var commandDelegate = CommandCache.Cache.VkGetDisplayPlaneCapabilitiesKhr;
                var methodResult = commandDelegate(Parent.Handle, Handle, planeIndex, &marshalledCapabilities);
                if (SharpVkException.IsError(methodResult)) throw SharpVkException.Create(methodResult);
                result = marshalledCapabilities;
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }
    }
}
