//Problem 2. IEnumerable extensions

//Implement a set of extension methods for IEnumerable<T> that implement the following 
//group functions: sum, product, min, max, average.

namespace _02.IEnumerable_extensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class IEnumerableExtensions
    {
        static void Main(string[] args)
        {
            int[] array = new int[6] { 1, 2, 3, 4, 5, 6 };
            List<float> list = new List<float>();
            list.Add(1.2f);
            list.Add(3.5f);
            list.Add(4.54f);

            Console.WriteLine("Sum");
            Console.WriteLine(array.Sum<int>());
            Console.WriteLine(list.Sum<float>());

            Console.WriteLine("Product");
            Console.WriteLine(array.Product<int>());
            Console.WriteLine(list.Product<float>());

            Console.WriteLine("Average");
            Console.WriteLine(array.Average<int>());
            Console.WriteLine(list.Average<float>());

            Console.WriteLine("Min");
            Console.WriteLine(array.Min<int>());
            Console.WriteLine(list.Min<float>());

            Console.WriteLine("Max");
            Console.WriteLine(array.Max<int>());
            Console.WriteLine(list.Max<float>());
        }
    }
}
