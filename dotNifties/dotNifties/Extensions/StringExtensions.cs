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
    }
}
