using System;
using System.Collections.Generic;
using System.Text;

namespace SharpVk.Generator
{
    public static class StringExtensions
    {
        public static string FirstToUpper(this string value)
        {
            var charArray = value.ToCharArray();

            charArray[0] = char.ToUpper(charArray[0]);

            return new string(charArray);
        }

        public static string FirstToLower(this string value)
        {
            var charArray = value.ToCharArray();

            charArray[0] = char.ToLower(charArray[0]);

            return new string(charArray);
        }
    }
}
