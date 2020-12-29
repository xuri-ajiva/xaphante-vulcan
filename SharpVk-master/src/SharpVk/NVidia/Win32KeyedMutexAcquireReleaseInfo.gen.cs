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

namespace SharpVk.NVidia
{
    /// <summary>
    ///     Use Windows keyex mutex mechanism to synchronize work.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct Win32KeyedMutexAcquireReleaseInfo
    {
        /// <summary>
        /// </summary>
        public DeviceMemory[] AcquireSyncs
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public ulong[] AcquireKeys
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public uint[] AcquireTimeoutMilliseconds
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public DeviceMemory[] ReleaseSyncs
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public ulong[] ReleaseKeys
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(Interop.NVidia.Win32KeyedMutexAcquireReleaseInfo* pointer)
        {
            pointer->SType = StructureType.Win32KeyedMutexAcquireReleaseInfoNv;
            pointer->Next = null;
            pointer->AcquireCount = HeapUtil.GetLength(AcquireSyncs);
            if (AcquireSyncs != null)
            {
                var fieldPointer = (Interop.DeviceMemory*)HeapUtil.AllocateAndClear<Interop.DeviceMemory>(AcquireSyncs.Length).ToPointer();
                for (var index = 0; index < (uint)AcquireSyncs.Length; index++) fieldPointer[index] = AcquireSyncs[index]?.handle ?? default(Interop.DeviceMemory);
                pointer->AcquireSyncs = fieldPointer;
            }
            else
            {
                pointer->AcquireSyncs = null;
            }
            if (AcquireKeys != null)
            {
                var fieldPointer = (ulong*)HeapUtil.AllocateAndClear<ulong>(AcquireKeys.Length).ToPointer();
                for (var index = 0; index < (uint)AcquireKeys.Length; index++) fieldPointer[index] = AcquireKeys[index];
                pointer->AcquireKeys = fieldPointer;
            }
            else
            {
                pointer->AcquireKeys = null;
            }
            if (AcquireTimeoutMilliseconds != null)
            {
                var fieldPointer = (uint*)HeapUtil.AllocateAndClear<uint>(AcquireTimeoutMilliseconds.Length).ToPointer();
                for (var index = 0; index < (uint)AcquireTimeoutMilliseconds.Length; index++) fieldPointer[index] = AcquireTimeoutMilliseconds[index];
                pointer->AcquireTimeoutMilliseconds = fieldPointer;
            }
            else
            {
                pointer->AcquireTimeoutMilliseconds = null;
            }
            pointer->ReleaseCount = HeapUtil.GetLength(ReleaseSyncs);
            if (ReleaseSyncs != null)
            {
                var fieldPointer = (Interop.DeviceMemory*)HeapUtil.AllocateAndClear<Interop.DeviceMemory>(ReleaseSyncs.Length).ToPointer();
                for (var index = 0; index < (uint)ReleaseSyncs.Length; index++) fieldPointer[index] = ReleaseSyncs[index]?.handle ?? default(Interop.DeviceMemory);
                pointer->ReleaseSyncs = fieldPointer;
            }
            else
            {
                pointer->ReleaseSyncs = null;
            }
            if (ReleaseKeys != null)
            {
                var fieldPointer = (ulong*)HeapUtil.AllocateAndClear<ulong>(ReleaseKeys.Length).ToPointer();
                for (var index = 0; index < (uint)ReleaseKeys.Length; index++) fieldPointer[index] = ReleaseKeys[index];
                pointer->ReleaseKeys = fieldPointer;
            }
            else
            {
                pointer->ReleaseKeys = null;
            }
        }
    }
}