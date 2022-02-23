using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public class BankAccount
    {
        private string accountHolder;
        private int accountNumber;
        protected double currentBalance;

        public BankAccount(string holder, int number, double balance)
        {
            accountHolder = holder;
            accountNumber = number;
            currentBalance = balance;
            Console.WriteLine("Bank Account Created");
        }

        public void Deposit(double amount)
        {
            currentBalance += amount;
        }

        public virtual void Withdraw(double amount)
        {
            currentBalance -= amount;
        }

        public double GetBalance()
        {
            return currentBalance;
        }

        public int GetAccountNumber()
        {
            return accountNumber;
        }

        public string GetAccountHolder()
        {
            return accountHolder;
        }

        public override string ToString()
        {
            return $"Account Number: {accountNumber} \tAccount Holder: {accountHolder} \tBalance: {currentBalance}";
        }

    }
}
