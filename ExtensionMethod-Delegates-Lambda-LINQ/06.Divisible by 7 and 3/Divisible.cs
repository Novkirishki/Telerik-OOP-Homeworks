//Problem 6. Divisible by 7 and 3

//Write a program that prints from given array of integers all numbers that
//are divisible by 7 and 3. Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Divisible_by_7_and_3
{
    class Divisible
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 42, 432, 2, 3, 100, 21, 49, 18, 105 };
            //with lambda
            Console.WriteLine("Lambda:");
            var divisible = array.Where(n => ((n % 3 == 0) && (n % 7 == 0)));
            foreach (var number in divisible)
            {
                Console.WriteLine(number);
            }
            
            //with LINQ
            Console.WriteLine("LINQ:");
            var divisible2 = from n in array
                             where (n % 3 == 0 && n % 7 == 0)
                             select n;
            foreach (var number in divisible2)
            {
                Console.WriteLine(number);
            }
        }
    }
}
