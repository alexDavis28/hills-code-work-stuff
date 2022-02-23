using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public class SavingsAccount : BankAccount
    {
        private double interest;

        public SavingsAccount(string holder, int number, double balance) : base(holder, number, balance)
        {
            Console.WriteLine("Savings Account Created");
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
    }

}
