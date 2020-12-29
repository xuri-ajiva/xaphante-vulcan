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
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DebugUtilsMessengerCallbackData
    {
        /// <summary>
        /// </summary>
        public DebugUtilsMessengerCallbackDataFlags? Flags
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public string MessageIdName
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public int? MessageIdNumber
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public string Message
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public DebugUtilsLabel[] QueueLabels
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public DebugUtilsLabel[] CommandBufLabels
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public DebugUtilsObjectNameInfo[] Objects
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(Interop.Multivendor.DebugUtilsMessengerCallbackData* pointer)
        {
            pointer->SType = StructureType.DebugUtilsMessengerCallbackData;
            pointer->Next = null;
            if (Flags != null)
                pointer->Flags = Flags.Value;
            else
                pointer->Flags = default;
            pointer->MessageIdName = HeapUtil.MarshalTo(MessageIdName);
            if (MessageIdNumber != null)
                pointer->MessageIdNumber = MessageIdNumber.Value;
            else
                pointer->MessageIdNumber = default;
            pointer->Message = HeapUtil.MarshalTo(Message);
            pointer->QueueLabelCount = HeapUtil.GetLength(QueueLabels);
            if (QueueLabels != null)
            {
                var fieldPointer = (Interop.Multivendor.DebugUtilsLabel*)HeapUtil.AllocateAndClear<Interop.Multivendor.DebugUtilsLabel>(QueueLabels.Length).ToPointer();
                for (var index = 0; index < (uint)QueueLabels.Length; index++) QueueLabels[index].MarshalTo(&fieldPointer[index]);
                pointer->QueueLabels = fieldPointer;
            }
            else
            {
                pointer->QueueLabels = null;
            }
            pointer->CommandBufLabelCount = HeapUtil.GetLength(CommandBufLabels);
            if (CommandBufLabels != null)
            {
                var fieldPointer = (Interop.Multivendor.DebugUtilsLabel*)HeapUtil.AllocateAndClear<Interop.Multivendor.DebugUtilsLabel>(CommandBufLabels.Length).ToPointer();
                for (var index = 0; index < (uint)CommandBufLabels.Length; index++) CommandBufLabels[index].MarshalTo(&fieldPointer[index]);
                pointer->CommandBufLabels = fieldPointer;
            }
            else
            {
                pointer->CommandBufLabels = null;
            }
            pointer->ObjectCount = HeapUtil.GetLength(Objects);
            if (Objects != null)
            {
                var fieldPointer = (Interop.Multivendor.DebugUtilsObjectNameInfo*)HeapUtil.AllocateAndClear<Interop.Multivendor.DebugUtilsObjectNameInfo>(Objects.Length).ToPointer();
                for (var index = 0; index < (uint)Objects.Length; index++) Objects[index].MarshalTo(&fieldPointer[index]);
                pointer->Objects = fieldPointer;
            }
            else
            {
                pointer->Objects = null;
            }
        }
    }
}