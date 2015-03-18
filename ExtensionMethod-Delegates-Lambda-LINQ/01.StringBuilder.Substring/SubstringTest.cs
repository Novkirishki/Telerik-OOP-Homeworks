//Problem 1. StringBuilder.Substring
//Implement an extension method Substring(int index, int length) for the class StringBuilder 
//that returns new StringBuilder and has the same functionality as Substring in the class String.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._02.Extensions
{
    class ExtensionsTest
    {
        static void Main(string[] args)
        {
            StringBuilder text = new StringBuilder("I love baking soda!!!");
            Console.WriteLine(text.Substring(7, 6));
        }
    }
}
