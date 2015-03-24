//Problem 2. Bank accounts

//A bank holds different types of accounts for its customers: deposit accounts, 
//loan accounts and mortgage accounts. Customers could be individuals or companies.
//All accounts have customer, balance and interest rate (monthly based).
//Deposit accounts are allowed to deposit and with draw money.
//Loan and mortgage accounts can only deposit money.
//All accounts can calculate their interest amount for a given period (in months). 
//In the common case its is calculated as follows: number_of_months * interest_rate.
//Loan accounts have no interest for the first 3 months if are held by individuals and 
//for the first 2 months if are held by a company.
//Deposit accounts have no interest if their balance is positive and less than 1000.
//Mortgage accounts have ½ interest for the first 12 months for companies and no interest 
//for the first 6 months for individuals.
//Your task is to write a program to model the bank system by classes and interfaces.
//You should identify the classes, interfaces, base classes and abstract actions and implement
//the calculation of the interest functionality through overridden methods.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Bank_accounts
{
    class Test
    {
        static void Main(string[] args)
        {
            //examples and tests
            Deposit deposit1 = new Deposit(new Company(), 500, 100);
            Console.WriteLine("Interest for 2 months {0} {1} with {2} interest rate: {3}",
                deposit1.Customer.GetType().Name,
                deposit1.GetType().Name,
                deposit1.InterestRate,
                deposit1.CalculateInterestRateForPeriod(2));

            Deposit deposit2 = new Deposit(new Individual(), 500, 100);
            Console.WriteLine("Interest for 4 months {0} {1} with {2} interest rate: {3}",
                deposit2.Customer.GetType().Name,
                deposit2.GetType().Name,
                deposit2.InterestRate,
                deposit2.CalculateInterestRateForPeriod(4));

            Loan loan1 = new Loan(new Individual(), 500, 100);
            Console.WriteLine("Interest for 7 months {0} {1} with {2} interest rate: {3}",
                loan1.Customer.GetType().Name,
                loan1.GetType().Name,
                loan1.InterestRate,
                loan1.CalculateInterestRateForPeriod(7));

            Loan loan2 = new Loan(new Company(), 500, 100);
            Console.WriteLine("Interest for 7 months {0} {1} with {2} interest rate: {3}",
                loan2.Customer.GetType().Name,
                loan2.GetType().Name,
                loan2.InterestRate,
                loan2.CalculateInterestRateForPeriod(7));

            Mortgage mortgage1 = new Mortgage(new Company(), 500, 100);
            Console.WriteLine("Interest for 7 months {0} {1} with {2} interest rate: {3}",
                mortgage1.Customer.GetType().Name,
                mortgage1.GetType().Name,
                mortgage1.InterestRate,
                mortgage1.CalculateInterestRateForPeriod(7));

            Mortgage mortgage2 = new Mortgage(new Company(), 500, 100);
            Console.WriteLine("Interest for 13 months {0} {1} with {2} interest rate: {3}",
                mortgage2.Customer.GetType().Name,
                mortgage2.GetType().Name,
                mortgage2.InterestRate,
                mortgage2.CalculateInterestRateForPeriod(13));

            Mortgage mortgage3 = new Mortgage(new Individual(), 500, 100);
            Console.WriteLine("Interest for 5 months {0} {1} with {2} interest rate: {3}",
                mortgage3.Customer.GetType().Name,
                mortgage3.GetType().Name,
                mortgage3.InterestRate,
                mortgage3.CalculateInterestRateForPeriod(5));

            Mortgage mortgage4 = new Mortgage(new Individual(), 500, 100);
            Console.WriteLine("Interest for 5 months {0} {1} with {2} interest rate: {3}",
                mortgage4.Customer.GetType().Name,
                mortgage4.GetType().Name,
                mortgage4.InterestRate,
                mortgage4.CalculateInterestRateForPeriod(7));
        }
    }
}
