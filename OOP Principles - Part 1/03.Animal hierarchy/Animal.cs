using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Animal_hierarchy
{
    public abstract class Animal : ISound
    {
        private int age;
        private string name;
        private Sex sex;

        protected Animal(string name, int age, Sex sex)
        {
            this.Age = age;
            this.Name = name;
            this.Sex = sex;
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("Age must be greater than 0");
                }
                this.age = value;
            }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Sex Sex
        {
            get { return sex; }
            set { sex = value; }
        }

        public abstract void produceSound();
    }
}
