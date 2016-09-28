using System;
using System.Collections.Generic;
using System.Linq;

namespace dotNifties.Extensions
{
    public static class IEnumerableExtensions
    {
        /// <summary>
        /// Shuffles the elements of a sequence
        /// </summary>
        /// <typeparam name="T">The type of the elements of source.</typeparam>
        /// <param name="source">An System.Collections.Generic.IEnumerable`1 to shuffle</param>
        /// <returns>An System.Collections.Generic.IEnumerable`1 that contains the reshuffled elements of source</returns>
        public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> source)
        {
            Random rand = new Random();
            return source.OrderBy(_ => rand.Next());
        }

        /// <summary>
        /// Swaps places of two elements in a sequence
        /// </summary>
        /// <typeparam name="T">The type of the elements of source.</typeparam>
        /// <param name="source">An System.Collections.Generic.IEnumerable`1 to perform the swap on</param>
        /// <param name="firstIndex">The first index to be swapped with the second</param>
        /// <param name="secondIndex">The second index to be swapped with the first</param>
        /// <returns>An System.Collections.Generic.IEnumerable`1 where firstIndex and secondIndex have been swapped</returns>
        public static IEnumerable<T> Swap<T>(this IEnumerable<T> source, int firstIndex, int secondIndex)
        {
            var arr = source.ToArray();
            T tempItem = arr[firstIndex];
            arr[firstIndex] = arr[secondIndex];
            arr[secondIndex] = tempItem;
            return source;
        }

        /// <summary>
        /// A semantically better way to remove null-values from a sequence
        /// </summary>
        /// <typeparam name="T">The type of the elements of source.</typeparam>
        /// <param name="source">An System.Collections.Generic.IEnumerable`1 to remove NULL-value elements on</param>
        /// <returns>An System.Collections.Generic.IEnumerable`1 where elements with the value of NULL have been filtered out</returns>
        public static IEnumerable<T> WhereNotNull<T> (this IEnumerable<T> source)
        {
            return source.Where(x => x != null);
        }
    }
}
