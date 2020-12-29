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

namespace SharpVk
{
    /// <summary>
    ///     Structure specifying parameters of a newly created instance.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct InstanceCreateInfo
    {
        /// <summary>
        ///     Reserved for future use.
        /// </summary>
        public InstanceCreateFlags? Flags
        {
            get;
            set;
        }

        /// <summary>
        ///     Null or an instance of ApplicationInfo. If not Null, this
        ///     information helps implementations recognize behavior inherent to
        ///     classes of applications. ApplicationInfo is defined in detail
        ///     below.
        /// </summary>
        public ApplicationInfo? ApplicationInfo
        {
            get;
            set;
        }

        /// <summary>
        ///     An array of enabledLayerCount strings containing the names of
        ///     layers to enable for the created instance. See the Layers section
        ///     for further details.
        /// </summary>
        public ArrayProxy<string> EnabledLayerNames
        {
            get;
            set;
        }

        /// <summary>
        ///     An array of enabledExtensionCount strings containing the names of
        ///     extensions to enable.
        /// </summary>
        public ArrayProxy<string> EnabledExtensionNames
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(Interop.InstanceCreateInfo* pointer)
        {
            pointer->SType = StructureType.InstanceCreateInfo;
            pointer->Next = null;
            if (Flags != null)
                pointer->Flags = Flags.Value;
            else
                pointer->Flags = default;
            if (ApplicationInfo != null)
            {
                pointer->ApplicationInfo = (Interop.ApplicationInfo*)HeapUtil.Allocate<Interop.ApplicationInfo>();
                ApplicationInfo.Value.MarshalTo(pointer->ApplicationInfo);
            }
            else
            {
                pointer->ApplicationInfo = default;
            }
            pointer->EnabledLayerCount = HeapUtil.GetLength(EnabledLayerNames);
            pointer->EnabledLayerNames = HeapUtil.MarshalTo(EnabledLayerNames);
            pointer->EnabledExtensionCount = HeapUtil.GetLength(EnabledExtensionNames);
            pointer->EnabledExtensionNames = HeapUtil.MarshalTo(EnabledExtensionNames);
        }
    }
}