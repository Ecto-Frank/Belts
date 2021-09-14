using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Qualnet.Web
{
    public static class IEnumerableExtensions
    {
        public static int? SumOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, int> selector, int? nullValue = null)
        {
            if (source?.Any() == true)
            {
                return source.Sum(selector);
            }
            else
            {
                return nullValue;
            }
        }

        public static double? SumOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, double> selector, double? nullValue = null)
        {
            if (source?.Any() == true)
            {
                return source.Sum(selector);
            }
            else
            {
                return nullValue;
            }
        }
    }
}
