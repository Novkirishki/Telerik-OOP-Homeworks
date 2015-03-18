using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.IEnumerable_extensions
{
    public static class Extensions
    {
        public static T Sum<T>(this IEnumerable<T> enumeration) where T : struct
        {
            T sum = default(T);
            foreach (T item in enumeration)
            {
                sum += (dynamic)item;
            }
            return sum;
        }

        public static T Product<T>(this IEnumerable<T> enumeration) where T : struct
        {
            T sum = (dynamic)1;
            foreach (T item in enumeration)
            {
                sum *= (dynamic)item;
            }
            return sum;
        }

        public static T Average<T>(this IEnumerable<T> enumeration) where T : struct
        {
            dynamic sum = default(T);
            int counter = 0;
            foreach (T item in enumeration)
            {
                sum += (dynamic)item;
                counter++;
            }
            return (sum/counter);
        }

        public static T Min<T>(this IEnumerable<T> enumeration) where T : IComparable
        {
            T min = enumeration.ElementAt(0);
            foreach (T item in enumeration)
            {
                if (min.CompareTo(item) > 0)
                {
                    min = item;
                }
            }
            return min;
        }

        public static T Max<T>(this IEnumerable<T> enumeration) where T : IComparable
        {
            T max = enumeration.ElementAt(0);
            foreach (T item in enumeration)
            {
                if (max.CompareTo(item) < 0)
                {
                    max = item;
                }
            }
            return max;
        }
    }
}
