using System;
using System.Linq;

namespace _04.Person_class
{
    class Test
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Stoyan", 32);
            Person person2 = new Person("Ivan");

            Console.WriteLine(person1.ToString());
            Console.WriteLine(person2.ToString());
        }
    }
}
