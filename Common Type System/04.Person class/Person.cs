using System;
using System.Linq;

namespace _04.Person_class
{
    public class Person
    {
        private readonly string name;
        private readonly int? age;

        public Person(string name)
        {
            this.name = name;
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public override string ToString()
        {
            if (age == null)
            {
                return string.Format("name: {0}, age is not specified", name);
            }
            else
            {
                return string.Format("name: {0}, age: {1}", name, age);
            }
        }
    }
}
