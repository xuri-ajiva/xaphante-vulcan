using System.Text;

namespace SharpVk.Glfw
{
    /// <summary>
    ///     Represents a native UTF32 codepoint.
    /// </summary>
    public struct CodePoint
    {
        /// <summary>
        ///     The numeric value of the codepoint.
        /// </summary>
        public readonly uint Value;

        /// <summary>
        ///     Casts the codepoint to System.Char.
        /// </summary>
        /// <returns>
        ///     The character representation of the codepoint.
        /// </returns>
        public unsafe char ToChar()
        {
            var value = Value;

            char result;

            Encoding.UTF32.GetChars((byte*)&value, 4, &result, 1);

            return result;
        }

        /// <summary>
        ///     Converts the value of this instance to its equivalent string representation.
        /// </summary>
        /// <returns>
        ///     A string containing the character representation of the codepoint.
        /// </returns>
        public override string ToString()
        {
            return ToChar().ToString();
        }
    }
}