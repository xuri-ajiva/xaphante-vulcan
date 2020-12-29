using System;
using System.Reflection;

namespace SharpVk
{
    /// <summary>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public struct ArrayProxy<T>
    {
        private T value;

        private ArraySegment<T> arrayValue;

        /// <summary>
        /// </summary>
        public ProxyContents Contents
        {
            get;
            private set;
        }

        /// <summary>
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= Length) throw new IndexOutOfRangeException();
                if (Contents == ProxyContents.Single)
                    return value;
                return arrayValue.Array[arrayValue.Offset + index];
            }
        }

        /// <summary>
        /// </summary>
        /// <returns></returns>
        public int Length
        {
            get
            {
                // The underlying integer values for ProxyContents.Null & .Single
                // are 0 and 1 respectively and can be returned directly; otherwise
                // get the length of the array.
                var length = (int)Contents;

                if (length > 1) length = arrayValue.Count;

                return length;
            }
        }

        /// <summary>
        /// </summary>
        /// <returns></returns>
        public T GetSingleValue()
        {
            return value;
        }

        /// <summary>
        /// </summary>
        /// <returns></returns>
        public ArraySegment<T> GetArrayValue()
        {
            return arrayValue;
        }

        /// <summary>
        /// </summary>
        public static ArrayProxy<T> Null =>
            new()
            {
                Contents = ProxyContents.Null
            };

        /// <summary>
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator ArrayProxy<T>(T[] value)
        {
            if (value == null)
                return Null;
            if (value.Length == 1)
                return new()
                {
                    value = value[0],
                    Contents = ProxyContents.Single
                };
            return new()
            {
                arrayValue = new(value),
                Contents = ProxyContents.Array
            };
        }

        /// <summary>
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator ArrayProxy<T>(ArraySegment<T> value)
        {
            if (value.Count == 0)
                return Null;
            if (value.Count == 1)
                return new()
                {
                    value = value.Array[0],
                    Contents = ProxyContents.Single
                };
            return new()
            {
                arrayValue = value,
                Contents = ProxyContents.Array
            };
        }

        /// <summary>
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator ArrayProxy<T>(T value)
        {
            if (!typeof(T).GetTypeInfo().IsValueType && value.Equals(default(T)))
                return Null;
            return new()
            {
                value = value,
                Contents = ProxyContents.Single
            };
        }
    }

    /// <summary>
    /// </summary>
    public enum ProxyContents
        : uint
    {
        /// <summary>
        /// </summary>
        Null = 0,
        /// <summary>
        /// </summary>
        Single = 1,
        /// <summary>
        /// </summary>
        Array = 2
    }

    /// <summary>
    /// </summary>
    public static class ArrayProxyExtensions
    {
        /// <summary>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="proxy"></param>
        /// <returns></returns>
        public static bool IsNull<T>(this ArrayProxy<T> proxy)
        {
            return proxy.Contents == ProxyContents.Null;
        }

        /// <summary>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="proxy"></param>
        /// <returns></returns>
        public static bool IsNull<T>(this ArrayProxy<T>? proxy)
        {
            return proxy == null || proxy.Value.Contents == ProxyContents.Null;
        }
    }
}