using System;
using Xunit;
using BankAccountApp;

namespace BankAccountTests
{
    public class UnitTest1
    {
        [Fact]
        public void Add_ValidAmount_UpdatesBalance()
        {
            // Arrange
            var account = new BankAccount(1000);

            // Act
            account.Add(100);

            // Assert
            Assert.Equal(1100, account.Balance);
        }

        [Fact]
        public void Withdraw_ValidAmount_UpdatesBalance()
        {
            var account = new BankAccount(1000);
            account.Withdraw(100);
            Assert.Equal(900, account.Balance);
        }

        [Fact]
        public void TransferFundsTo_ValidAmount_RemovesFunds()
        {
            var account_one = new BankAccount(1000);
            var account_two = new BankAccount(100);

            account_one.TransferFundsTo(account_two, 500);
            Assert.Equal(500, account_one.Balance);
        }

        [Fact]
        public void TransferFundsTo_ValidAmount_TransfersFunds()
        {
            var account_one = new BankAccount(1000);
            var account_two = new BankAccount(100);

            account_one.TransferFundsTo(account_two, 500);
            Assert.Equal(600, account_two.Balance);
        }


    }
}
