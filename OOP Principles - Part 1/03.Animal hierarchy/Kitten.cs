using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Animal_hierarchy
{
    public class Kitten : Cat
    {        
        public Kitten(string name, int age) 
            : base(name,age,Sex.female)
        {

        }

        public override void produceSound()
        {
            Console.WriteLine("Murrr");
        }
    }
}
