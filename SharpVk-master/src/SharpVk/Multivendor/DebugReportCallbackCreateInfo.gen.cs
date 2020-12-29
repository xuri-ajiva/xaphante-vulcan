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
using System.Runtime.InteropServices;

namespace SharpVk.Multivendor
{
    /// <summary>
    ///     Structure specifying parameters of a newly created debug report
    ///     callback.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct DebugReportCallbackCreateInfo
    {
        /// <summary>
        ///     flags indicate which event(s) will cause this callback to be
        ///     called. Flags are interpreted as bitmasks and multiple may be set.
        ///     Bits which can be set include: + --
        /// </summary>
        public DebugReportFlags? Flags
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public DebugReportCallbackDelegate Callback
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public IntPtr? UserData
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(Interop.Multivendor.DebugReportCallbackCreateInfo* pointer)
        {
            pointer->SType = StructureType.DebugReportCallbackCreateInfo;
            pointer->Next = null;
            if (Flags != null)
                pointer->Flags = Flags.Value;
            else
                pointer->Flags = default;
            pointer->Callback = Marshal.GetFunctionPointerForDelegate(Callback);
            if (UserData != null)
                pointer->UserData = UserData.Value.ToPointer();
            else
                pointer->UserData = default;
        }
    }
}