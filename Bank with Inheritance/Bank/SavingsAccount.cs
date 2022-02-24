using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public class SavingsAccount : BankAccount
    {
        private double interest;

        public SavingsAccount(string holder, int number, double balance, double interest) : base(holder, number, balance)
        {
            Console.WriteLine("Savings Account Created");
            this.interest = interest;
        }

        public override void Withdraw(double amount)
        {
            if (amount > currentBalance)
            {
                Console.WriteLine("Widthdraw not allowed");
            }
            else
            {
                currentBalance -= amount;
            }
        }

        public void ApplyInterest()
        {
            Console.WriteLine($"Applied interest of {interest*100}%");
            currentBalance = currentBalance + (interest * currentBalance);
        }
        public void ApplyInterest(int years)
        {
            Console.WriteLine($"Applied compound interest of {interest * 100}% over {years} years");
            currentBalance = currentBalance * Math.Pow((1 + interest), years);
        }
    }

}
