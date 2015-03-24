using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.Bank_accounts
{
    public class Loan : Account
    {
        public Loan(Customer customer, double balance, double interestRate)
            : base(customer, balance, interestRate)
        {

        }

        public override double CalculateInterestRateForPeriod(int months)
        {
            int freeMonths = 0;
            switch (this.Customer.GetType().Name)
            {
                case "Individual":
                    {
                        freeMonths = 3;
                        break;
                    }
                case "Company":
                    {
                        freeMonths = 2;
                        break;
                    }                   
                default:
                    break;
            }

            if (months - freeMonths <= 0)
            {
                return 0;
            }
            else
            {
                return base.CalculateInterestRateForPeriod(months - freeMonths);
            }            
        }
    }
}
