using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotterCartTest
{
    public static class EnumerableExtender
    {
        public static IEnumerable<TSource> Distinct<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> selector)
        {
            HashSet<TKey> hashKey = new HashSet<TKey>();
            foreach (TSource element in source)
            {
                var value = selector(element);
                if (hashKey.Add(value))
                {
                    yield return element;
                }
            }
        }
    }
}
