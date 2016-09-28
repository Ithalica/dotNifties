using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNifties.Extensions
{
    public static class IEnumerableExtensions
    {

        public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> source)
        {
            Random rand = new Random();
            return source.OrderBy(_ => rand.Next());
        }
        
        public static IEnumerable<T> Swap<T>(this IEnumerable<T> source, int firstIndex, int secondIndex)
        {
            var arr = source.ToArray();
            T tempItem = arr[firstIndex];
            arr[firstIndex] = arr[secondIndex];
            arr[secondIndex] = tempItem;
            return source;
        }
    }
}
