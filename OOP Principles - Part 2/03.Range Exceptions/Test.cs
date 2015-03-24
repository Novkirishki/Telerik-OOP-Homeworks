using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Range_Exceptions
{
    class Test
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number in range [1, 100]");
            try
            {
                int n = int.Parse(Console.ReadLine());
                if (n < 1 || n > 100)
	            {
		             throw new InvalidRangeException<int>(1, 100);
            	}                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Enter a DateTime in range [1.1.1980, 31.12.2013].");
            try
            {
                DateTime date = DateTime.Parse(Console.ReadLine());
                if (date < new DateTime(1980,1,1) || date > new DateTime(2013, 12, 31))
                {
                    throw new InvalidRangeException<DateTime>(new DateTime(1980, 1, 1), new DateTime(2013, 12, 31));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
