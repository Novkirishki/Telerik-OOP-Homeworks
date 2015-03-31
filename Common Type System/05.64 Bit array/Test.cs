//Problem 5. 64 Bit array
//Define a class BitArray64 to hold 64 bit values inside an ulong value.
//Implement IEnumerable<int> and Equals(…), GetHashCode(), [], == and !=.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._64_Bit_array
{
    class Test
    {
        static void Main(string[] args)
        {
            BitArray64 array = new BitArray64(31); //0..011111
            for (int i = 63; i >= 0; i--)
            {
                Console.Write(array[i]);
            }
            Console.WriteLine();

            array[4] = 0; // 0..001111 = 15
            Console.WriteLine(array.Value);
        }
    }
}
