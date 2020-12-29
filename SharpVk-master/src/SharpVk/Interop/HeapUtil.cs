﻿using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpVk.Interop
{
    internal static unsafe class HeapUtil
    {
        private const int PerThreadSpace = 1 << 20;

        [ThreadStatic] private static IntPtr allocateSpace;

        [ThreadStatic] private static uint allocatedCount;

        private static IntPtr AllocateSpace
        {
            get
            {
                if (allocateSpace == IntPtr.Zero)
                {
                    allocateSpace = Marshal.AllocHGlobal(PerThreadSpace);

                    allocatedCount = 0;
                }

                return allocateSpace;
            }
        }

        internal static IntPtr Allocate<T>(HostSize count)
        {
            return Allocate<T>((uint)count);
        }

        internal static IntPtr Allocate<T>(int count)
        {
            return Allocate<T>((uint)count);
        }

        internal static IntPtr Allocate<T>(uint count = 1)
        {
            if (count == 0) return IntPtr.Zero;

            var requiredSize = SizeOfCache<T>.Value * count;

            var tailBytes = requiredSize % (uint)IntPtr.Size;

            if (tailBytes > 0) requiredSize += (uint)IntPtr.Size - tailBytes;

            if (allocatedCount + requiredSize > PerThreadSpace) throw new("Out of interop heap memory");

            var pointer = AllocateSpace + (int)allocatedCount;

            allocatedCount += requiredSize;

            return pointer;
        }

        internal static IntPtr AllocateAndClear<T>(uint count)
        {
            return AllocateAndClear<T>((int)count);
        }

        internal static IntPtr AllocateAndClear<T>(int count = 1)
        {
            var size = SizeOfCache<T>.Value;

            var pointer = Allocate<T>(count);

            var bytePointer = (byte*)pointer.ToPointer();

            for (var offset = 0; offset < count; offset++) bytePointer[offset] = 0;

            return pointer;
        }

        internal static void FreeAll()
        {
            allocatedCount = 0;
        }

        internal static byte* MarshalTo(string value)
        {
            if (value != null)
            {
                var size = Encoding.UTF8.GetByteCount(value) + 1;

                var pointer = AllocateAndClear<byte>(size);

                var chars = stackalloc char[value.Length];

                Marshal.Copy(value.ToCharArray(), 0, new(chars), value.Length);

                Encoding.UTF8.GetBytes(chars, value.Length, (byte*)pointer.ToPointer(), size);

                return (byte*)pointer.ToPointer();
            }
            return null;
        }

        internal static byte** MarshalTo(ArrayProxy<string>? proxy)
        {
            if (!proxy.HasValue || proxy.Value.Contents == ProxyContents.Null) return null;
            var proxyValue = proxy.Value;

            var pointer = Allocate<IntPtr>(proxyValue.Length);

            var typedPointer = (byte**)pointer.ToPointer();

            if (proxyValue.Contents == ProxyContents.Single)
                *typedPointer = MarshalTo(proxyValue.GetSingleValue());
            else
                for (var index = 0; index < proxyValue.Length; index++)
                    typedPointer[index] = MarshalTo(proxyValue[index]);

            return typedPointer;
        }

        internal static string MarshalStringFrom(byte* pointer)
        {
            return Marshal.PtrToStringAnsi(new(pointer));
        }

        internal static string MarshalStringFrom(byte* pointer, int length, bool isNullTerminated = false)
        {
            int actualLength;

            if (isNullTerminated)
            {
                actualLength = 0;

                while (actualLength < length && pointer[actualLength] != 0) actualLength++;

                length = actualLength;
            }
            else
            {
                actualLength = length;
            }

            return Marshal.PtrToStringAnsi(new(pointer), actualLength);
        }

        internal static byte[] MarshalFrom(byte* pointer, int length)
        {
            return MarshalFrom(pointer, length, out var actualLength);
        }

        internal static byte[] MarshalFrom(byte* pointer, int length, out int actualLength, bool isNullTerminated = false)
        {
            if (isNullTerminated)
            {
                actualLength = 0;

                while (actualLength < length && pointer[actualLength] != 0) actualLength++;

                length = actualLength;
            }
            else
            {
                actualLength = length;
            }

            var newArray = new byte[length];

            Marshal.Copy(new(pointer), newArray, 0, length);

            return newArray;
        }

        internal static uint GetLength<T>(T[] value)
        {
            return (uint)(value?.Length ?? 0);
        }

        internal static uint GetLength<T>(ArrayProxy<T> value)
        {
            return (uint)value.Length;
        }

        internal static uint GetLength<T>(ArrayProxy<T>? value)
        {
            return (uint)(value?.Length ?? 0);
        }

        internal static float[] MarshalFrom(float* pointer, int length)
        {
            var newArray = new float[length];

            Marshal.Copy(new(pointer), newArray, 0, length);

            return newArray;
        }

        internal static uint[] MarshalFrom(uint* pointer, int length)
        {
            var newArray = new uint[length];

            // Marshal.Copy doesn't support uints for some reason...
            for (var index = 0; index < length; index++) newArray[index] = *(pointer + length);

            return newArray;
        }

        internal static ulong[] MarshalFrom(ulong* pointer, int length)
        {
            var newArray = new ulong[length];

            // Marshal.Copy doesn't support uints for some reason...
            for (var index = 0; index < length; index++) newArray[index] = *(pointer + length);

            return newArray;
        }

        internal static byte* MarshalTo(byte[] value)
        {
            var pointer = (byte*)Allocate<byte>(value.Length).ToPointer();

            MarshalTo(value, value.Length, pointer);

            return pointer;
        }

        internal static float* MarshalTo(float[] value)
        {
            var pointer = (float*)Allocate<float>(value.Length).ToPointer();

            MarshalTo(value, value.Length, pointer);

            return pointer;
        }

        internal static int* MarshalTo(int[] value)
        {
            var pointer = (int*)Allocate<int>(value.Length).ToPointer();

            MarshalTo(value, value.Length, pointer);

            return pointer;
        }

        internal static uint* MarshalTo(uint[] value)
        {
            var pointer = (uint*)Allocate<uint>(value.Length).ToPointer();

            MarshalTo(value, value.Length, pointer);

            return pointer;
        }

        internal static ulong* MarshalTo(ulong[] value)
        {
            var pointer = (ulong*)Allocate<ulong>(value.Length).ToPointer();

            MarshalTo(value, value.Length, pointer);

            return pointer;
        }

        internal static void MarshalTo(Guid value, int length, byte* pointer)
        {
            value.TryWriteBytes(new(pointer, length));
        }

        internal static void MarshalTo(byte[] value, int length, byte* pointer)
        {
            Marshal.Copy(value, 0, new(pointer), length);
        }

        internal static void MarshalTo(float[] value, int length, float* pointer)
        {
            Marshal.Copy(value, 0, new(pointer), length);
        }

        internal static void MarshalTo(int[] value, int length, int* pointer)
        {
            Marshal.Copy(value, 0, new(pointer), length);
        }

        internal static void MarshalTo(uint[] value, int length, uint* pointer)
        {
            //Marshal.Copy doesn't support uints for some reason...
            for (var index = 0; index < length; index++) pointer[index] = value[index];
        }

        internal static void MarshalTo(ulong[] value, int length, ulong* pointer)
        {
            //Marshal.Copy doesn't support ulongs for some reason...
            for (var index = 0; index < length; index++) pointer[index] = value[index];
        }

        internal static void MarshalTo(string[] value, int length, byte** pointer)
        {
            for (var index = 0; index < length; index++) pointer[index] = MarshalTo(value[index]);
        }

        private static class SizeOfCache<T>
        {
            public static readonly uint Value;

            static SizeOfCache()
            {
                Value = (uint)Unsafe.SizeOf<T>();
            }
        }
    }
}
