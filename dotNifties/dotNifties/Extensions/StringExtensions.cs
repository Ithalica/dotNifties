using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNifties.Extensions
{
    public static class StringExtensions
    {
        /// <summary>
        /// Check for equality on two strings, without regard for leading or trailing whitespaces or case.
        /// </summary>
        /// <param name="source">String to test</param>
        /// <param name="target">String to test against</param>
        /// <returns>true if the value parameter is equal to the target, ignoring leading and trailing whitespaces and case</returns>
        public static bool EqualsTrimmedInvariant(this string source, string target)
        {
            //If either of the strings are NULL, we need to make a check to see if both are null. 
            //If we don't, we will end up with getting true on nulls compared to whitespaces.
            if (source == null || target == null)
            {
                return source == null && target == null;
            }

            string str1 = (source ?? "").ToLowerInvariant().Trim();
            string str2 = (target ?? "").ToLowerInvariant().Trim();

            return str1.Equals(str2);
        }

        /// <summary>
        /// Indicates whether a specified string is null, empty, or consists only of white-space characters.
        /// Wrapper of string.IsNullOrWhiteSpoace(string)
        /// </summary>
        /// <param name="source">The string to test</param>
        /// <returns>true if the value parameter is null or System.String.Empty, or if value consists exclusively of white-space characters</returns>
        public static bool IsNullOrWhiteSpace(this string source)
        {
            return string.IsNullOrWhiteSpace(source);
        }

        /// <summary>
        /// Converts the string segment within the range provided to its upper case equivalent using the casing rules of the invariant culture.
        /// </summary>
        /// <param name="source">The string to convert</param>
        /// <param name="startIndex">The zero-based starting character position of a substring in this instance</param>
        /// <param name="length">The length of characters in the substring to convert to upper case</param>
        /// <returns></returns>
        public static string ToUpper(this string source, int startIndex, int length)
        {
            char[] stringAsChars = source.ToCharArray();

            for (int i = startIndex; i < startIndex + length; i++)
            {
                stringAsChars[i] = char.ToUpperInvariant(stringAsChars[i]);
            }

            return new string(stringAsChars);
        }

        /// <summary>
        /// Converts the string segment within the range provided to its lower case equivalent using the casing rules of the invariant culture.
        /// </summary>
        /// <param name="source">The string to convert</param>
        /// <param name="startIndex">The zero-based starting character position of a substring in this instance</param>
        /// <param name="length">The length of characters in the substring to convert to lower case</param>
        /// <returns></returns>
        public static string ToLower(this string source, int startIndex, int length)
        {
            char[] stringAsChars = source.ToCharArray();

            for (int i = startIndex; i < startIndex + length; i++)
            {
                stringAsChars[i] = char.ToLowerInvariant(stringAsChars[i]);
            }

            return new string(stringAsChars);
        }
    }
}
