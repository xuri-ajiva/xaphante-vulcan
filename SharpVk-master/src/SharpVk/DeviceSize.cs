namespace SharpVk
{
    /// <summary>
    ///     Represents the size of a block in device memory.
    /// </summary>
    public struct DeviceSize
    {
        private ulong value;

        /// <summary>
        ///     -
        /// </summary>
        public static implicit operator DeviceSize(int value)
        {
            return new()
            {
                value = (ulong)value
            };
        }

        /// <summary>
        ///     -
        /// </summary>
        public static implicit operator DeviceSize(ulong value)
        {
            return new()
            {
                value = value
            };
        }

        /// <summary>
        ///     -
        /// </summary>
        public static implicit operator ulong(DeviceSize size)
        {
            return size.value;
        }

        /// <summary>
        ///     -
        /// </summary>
        public static explicit operator uint(DeviceSize size)
        {
            return (uint)size.value;
        }

        /// <summary>
        ///     -
        /// </summary>
        public static explicit operator int(DeviceSize size)
        {
            return (int)size.value;
        }

        /// <summary>
        ///     -
        /// </summary>
        public override string ToString()
        {
            return value.ToString();
        }
    }
}