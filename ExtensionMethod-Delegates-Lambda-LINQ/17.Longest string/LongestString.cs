//Problem 17. Longest string
//Write a program to return the string with maximum length from an array of strings.
//Use LINQ.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Longest_string
{
    class LongestString
    {
        static void Main(string[] args)
        {
            string[] array = new string[] { "abba", "dsadsadas", "asddsa", "das", "dsaaaasadasfasf" };
            string longest = array.OrderByDescending(s => s.Length).First();
            Console.WriteLine("The longest string is: {0}", longest);
        }
    }
}
