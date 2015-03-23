using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.Students_and_workers
{
    public class Student : Human
    {
        private double grade;

        public Student(string firstName, string lastName, double grade) : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public double Grade
        {
            get { return grade; }
            set 
            {
                if (value < 2 || value > 6)
                {
                    throw new ArgumentOutOfRangeException("Grade is not between 2 and 6");
                }
                grade = value; 
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(this.FirstName);
            builder.Append(" ");
            builder.Append(this.LastName);
            builder.Append(" ");
            builder.Append(this.Grade);
            return builder.ToString();
        }
    }
}
