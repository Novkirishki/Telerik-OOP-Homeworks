using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.Bank_accounts
{
    public class Deposit : Account
    {
        public Deposit(Customer customer, double balance, double interestRate) 
            : base(customer, balance, interestRate)
        {

        }

        public void Withdraw(double amount)
        {
            if (amount > this.Balance)
            {
                throw new InvalidOperationException("Amount is greater than balance");
            }
            this.Balance -= amount;
        }

        public override double CalculateInterestRateForPeriod(int months)
        {
            if (this.Balance > 0 && this.Balance < 1000)
            {
                return 0;
            }
            else
            {
                return base.CalculateInterestRateForPeriod(months);
            }            
        }
    }
}
