﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.School_classes
{
    public class Person
    {
        private string name;
        public Person(string name)
        {
            this.Name = name;
        }
    
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }
}
