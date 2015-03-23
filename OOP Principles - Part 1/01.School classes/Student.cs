using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.School_classes
{
    class Student : Person
    {
        private char classID;
        public Student(string name, char classID)
            : base(name)
        {
            this.ClassID = classID;
        }

        public char ClassID
        {
            get
            {
                return this.classID;
            }
            set
            {
                if (value > 0)
                {
                    this.classID = value;
                }
            }
        }
    }
}
