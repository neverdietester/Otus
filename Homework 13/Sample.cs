using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_13
{
    public static class Sample
    {
        public static IEnumerable<T> Top<T>(this IEnumerable<T> collection, int percent)
        {
            if (percent > 100 || percent < 1)
                throw new ArgumentException("Процентное значение должно быть от 1 до 100");
            var amount = (collection.Count() * percent / 100) + 1;
            return collection.OrderByDescending(x=>x).ToList().Take(amount);
        }

        public static IEnumerable<T> Top<T>(this IEnumerable<T> collection, int percent, Func<T, int> predicat)
        {
            if (percent > 100 || percent < 1)
                throw new ArgumentException("Процентное значение должно быть от 1 до 100");
          
            var amount = (collection.Count() * percent / 100) + 1;
            return collection.OrderByDescending(predicat).ToList().Take(amount);
        }
    }
}
