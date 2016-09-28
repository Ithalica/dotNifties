using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNifties.Extensions
{
   public static class StringExtensions
    {
        public static bool EqualsTrimmedInvariant(this string source, string target)
        {
            string str1 = (source ?? "").ToLowerInvariant().Trim();
            string str2 = (target ?? "").ToLowerInvariant().Trim();

            return str1.Equals(str2);
        }
    }
}
