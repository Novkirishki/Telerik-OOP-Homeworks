using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.Bank_accounts
{
    public class Mortgage : Account
    {
        public Mortgage(Customer customer, double balance, double interestRate)
            : base(customer, balance, interestRate)
        {

        }

        public override double CalculateInterestRateForPeriod(int months)
        {
            switch (this.Customer.GetType().Name)
            {
                case "Individual":
                    {
                        if (months - 6 <= 0)
                        {
                            return 0;
                        }
                        else
                        {
                            return base.CalculateInterestRateForPeriod(months - 6);
                        }
                    }
                case "Company":
                    {
                        if (months - 12 <= 0)
                        {
                            return (base.CalculateInterestRateForPeriod(months) / 2);
                        }
                        else
                        {
                            return (base.CalculateInterestRateForPeriod(12) / 2
                                + base.CalculateInterestRateForPeriod(months - 12));
                        }
                        break;
                    }
                default:
                    return 0;
                    break;
            }          
        }
    }
}
