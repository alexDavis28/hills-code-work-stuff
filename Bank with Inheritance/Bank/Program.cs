using System;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account1 = new BankAccount("SAM", 1, 5.50);
            Console.WriteLine(account1.ToString());
            account1.Deposit(100);
            Console.WriteLine(account1.ToString());
            account1.Withdraw(600);
            Console.WriteLine(account1.ToString());
            SavingsAccount account2 = new SavingsAccount("JOE", 2, 1000, 0.05);
            Console.WriteLine(account2.ToString());
            account2.Deposit(100);
            Console.WriteLine(account2.ToString());
            account2.Withdraw(1200);
            Console.WriteLine(account2.ToString());
            account2.ApplyInterest();
            Console.WriteLine(account2.ToString());
            account2.ApplyInterest(2);
            Console.WriteLine(account2.ToString());
        }

    }
}
