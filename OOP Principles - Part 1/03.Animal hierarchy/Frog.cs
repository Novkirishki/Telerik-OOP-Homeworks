﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Animal_hierarchy
{
    public class Frog : Animal
    {        
        public Frog(string name, int age, Sex sex) 
            : base(name,age,sex)
        {

        }

        public override void produceSound()
        {
            Console.WriteLine("Quack");
        }
    }
}
