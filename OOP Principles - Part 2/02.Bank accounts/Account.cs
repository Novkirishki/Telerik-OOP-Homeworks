using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.Bank_accounts
{
    public abstract class Account
    {
        private double balance;
        private double interestRate;
        private Customer customer;

        public Account(Customer customer, double balance, double interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public double Balance
        {
            get { return balance; }
            protected set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Initial balance cannot be negative");
                }
                balance = value; 
            }
        }

        public double InterestRate
        {
            get { return interestRate; }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Interest Rate cannot be negative");
                }
                interestRate = value;
            }
        }

        public Customer Customer
        {
            get { return customer; }
            protected set { customer = value; }
        }

        public virtual double CalculateInterestRateForPeriod(int months)
        {
            return this.InterestRate * months;
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Amount must be greater than 0");
            }
            this.Balance += amount;
        }
    }
}
