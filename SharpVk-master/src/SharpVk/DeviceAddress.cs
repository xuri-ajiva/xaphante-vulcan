namespace SharpVk
{
    /// <summary>
    ///     Represents the address in device memory.
    /// </summary>
    public struct DeviceAddress
    {
        private ulong value;

        /// <summary>
        ///     -
        /// </summary>
        public static implicit operator DeviceAddress(int value)
        {
            return new()
            {
                value = (ulong)value
            };
        }

        /// <summary>
        ///     -
        /// </summary>
        public static implicit operator DeviceAddress(ulong value)
        {
            return new()
            {
                value = value
            };
        }

        /// <summary>
        ///     -
        /// </summary>
        public static implicit operator ulong(DeviceAddress size)
        {
            return size.value;
        }

        /// <summary>
        ///     -
        /// </summary>
        public static explicit operator uint(DeviceAddress size)
        {
            return (uint)size.value;
        }

        /// <summary>
        ///     -
        /// </summary>
        public static explicit operator int(DeviceAddress size)
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