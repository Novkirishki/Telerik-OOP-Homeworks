//Problem 20.* Infinite convergent series
//By using delegates develop an universal static method to calculate the sum
//of infinite convergent series with given precision depending on a function 
//of its term. By using proper functions for the term calculate with a 2-digit
//precision the sum of the infinite series:

//1 + 1/2 + 1/4 + 1/8 + 1/16 + …
//1 + 1/2! + 1/3! + 1/4! + 1/5! + …
//1 + 1/2 - 1/4 + 1/8 - 1/16 + …

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.InfiniteConvergenSteries
{
    class Program
    {
        static double Factorial(int x)
        {
            double factorial = 1;
            for (int i = 1; i <= x; i++)
            {
                factorial *= (ulong)i;
            }

            return factorial;
        }
        static double Series(Func<int,double> nextMemberOfSeries, int precision)
        {
            double sum = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i == 0 && nextMemberOfSeries(i) > 1)
                {
                    continue;
                }
                sum += nextMemberOfSeries(i);
            }

            return Math.Round(sum, precision, MidpointRounding.AwayFromZero);
        }
        static void Main(string[] args)
        {
            int precision = 2;
            Console.WriteLine(Series(x => 1 / Math.Pow(2, x), precision)); // 2
            Console.WriteLine(Series(x => 1 / Factorial(x), precision)); // 2.72
            Console.WriteLine(Series(x => 1 / (Math.Pow(2, x) * Math.Pow(-1, x)), precision));// 2/3
        }
    }
}
