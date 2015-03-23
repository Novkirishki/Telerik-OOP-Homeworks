using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.Students_and_workers
{
    public class Worker : Human
    {
        private double weekSalary;
        private int workHoursPerDay;

        public Worker(string firstName, string lastName, double weekSalary, int workHoursPerDay) 
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public Worker(string firstName, string lastName) : this(firstName, lastName, 0, 0)
        {

        }


        public double WeekSalary
        {
            get { return weekSalary; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Salary must be nonnegative");
                }
                weekSalary = value; 
            }
        }

        public int WorkHoursPerDay
        {
            get { return workHoursPerDay; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Work hours must be nonnegative");
                }
                workHoursPerDay = value; 
            }
        }

        public double MoneyPerHour()
        {
            return (double)this.WeekSalary / (this.WorkHoursPerDay * 5);
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(this.FirstName);
            builder.Append(" ");
            builder.Append(this.LastName);
            builder.Append(" ");
            builder.Append(this.MoneyPerHour());
            return builder.ToString();
        }
    }
}
