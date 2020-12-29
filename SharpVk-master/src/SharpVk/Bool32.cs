namespace SharpVk
{
    /// <summary>
    ///     -
    /// </summary>
    public struct Bool32
    {
        private readonly uint value;

        /// <summary>
        ///     -
        /// </summary>
        public Bool32(bool value)
        {
            this.value = value
                ? Constants.True
                : Constants.False;
        }

        /// <summary>
        ///     -
        /// </summary>
        public static implicit operator Bool32(bool value)
        {
            return new(value);
        }

        /// <summary>
        ///     -
        /// </summary>
        public static implicit operator bool(Bool32 value)
        {
            return value.value != Constants.False;
        }

        /// <summary>
        ///     -
        /// </summary>
        public override string ToString()
        {
            return ((bool)this).ToString();
        }
    }
}