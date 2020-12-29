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

namespace SharpVk.Multivendor
{
    /// <summary>
    ///     Specify parameters of a name to give to an object.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct DebugMarkerObjectNameInfo
    {
        /// <summary>
        ///     A DebugReportObjectTypeEXT specifying the type of the object to be
        ///     named.
        /// </summary>
        public DebugReportObjectType ObjectType
        {
            get;
            set;
        }

        /// <summary>
        ///     The object to be named.
        /// </summary>
        public ulong Object
        {
            get;
            set;
        }

        /// <summary>
        ///     A string specifying the name to apply to object.
        /// </summary>
        public string ObjectName
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(Interop.Multivendor.DebugMarkerObjectNameInfo* pointer)
        {
            pointer->SType = StructureType.DebugMarkerObjectNameInfo;
            pointer->Next = null;
            pointer->ObjectType = ObjectType;
            pointer->Object = Object;
            pointer->ObjectName = HeapUtil.MarshalTo(ObjectName);
        }
    }
}