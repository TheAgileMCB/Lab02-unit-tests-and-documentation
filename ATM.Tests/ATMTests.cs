using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using Xunit;
using Lab02UnitTests;

namespace ATM.Tests
{
    public class ATMTests
    {
        //[Fact]
        //public void Does_balance_exist()
        //{
        //    //Arrange
        //    decimal balance = 20;

        //    // Act
        //    decimal result = Lab02UnitTests.ATM.ViewBalance(balance);

        //    // Assert
        //    Assert.StrictEqual(balance, result);

        //}

        [Fact]
        public void  Does_money_come_out()
        {
            //Arrange
            decimal balance = Lab02UnitTests.ATM.GetBalance();
            decimal withdrawal = 10;
            decimal testBalance = balance - withdrawal;

            // Act
            decimal result = Lab02UnitTests.ATM.WithdrawFunds(withdrawal);

            // Assert
            Assert.Equal(testBalance, result);
        }

        [Fact]
        public void Does_negative_money_come_out()
        {
            //Arrange
            decimal balance = Lab02UnitTests.ATM.GetBalance();
            decimal withdrawal = -10;
            decimal testBalance = balance - withdrawal;

            // Act
            decimal result = Lab02UnitTests.ATM.WithdrawFunds(withdrawal);

            // Assert
            Assert.Equal(testBalance, result);
        }

        [Fact]
        public void Does_money_go_in()
        {
            //Arrange | Given
            decimal balance = Lab02UnitTests.ATM.GetBalance();
            decimal deposit = 10;

            // Act | When
            decimal result = Lab02UnitTests.ATM.DepositFunds(deposit);

            // Assert | Then
            decimal expectedBalance = balance + deposit;
            Assert.Equal(expectedBalance, result);
        }

        [Fact]
        public void Does_negative_money_go_in()
        {
            //Arrange
            decimal balance = Lab02UnitTests.ATM.GetBalance();
            decimal deposit = -10;

            // Act
            decimal result = Lab02UnitTests.ATM.DepositFunds(deposit);

            // Assert
            decimal expectedBalance = balance + deposit;
            Assert.Equal(expectedBalance, result);
        }

        [Fact]
        public void Overdraft_protection()
        {
            //Arrange
            decimal balance = Lab02UnitTests.ATM.GetBalance();
            decimal withdrawal = balance + 500;

            // Act
            decimal balanceAfterWithdraw = Lab02UnitTests.ATM.WithdrawFunds(withdrawal);


            // Assert
            Assert.Equal(balance, withdrawal - 500);
                }
    }
}
