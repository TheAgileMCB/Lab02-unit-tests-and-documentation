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
        //    double balance = 20;

        //    // Act
        //    double result = Lab02UnitTests.ATM.ViewBalance(balance);

        //    // Assert
        //    Assert.StrictEqual(balance, result);

        //}

        [Fact]
        public void  Does_money_come_out()
        {
            //Arrange
            double balance = Lab02UnitTests.ATM.GetBalance();
            double withdrawal = 10;
            double testBalance = balance - withdrawal;

            // Act
            double result = Lab02UnitTests.ATM.WithdrawFunds(withdrawal);

            // Assert
            Assert.Equal(testBalance, result);
        }

        [Fact]
        public void Does_negative_money_come_out()
        {
            //Arrange
            double balance = Lab02UnitTests.ATM.GetBalance();
            double withdrawal = -10;
            double testBalance = balance - withdrawal;

            // Act
            double result = Lab02UnitTests.ATM.WithdrawFunds(withdrawal);

            // Assert
            Assert.Equal(testBalance, result);
        }

        [Fact]
        public void Does_money_go_in()
        {
            //Arrange
            double balance = Lab02UnitTests.ATM.GetBalance();
            double deposit = 10;
            double testBalance = balance + deposit;

            // Act
            double result = Lab02UnitTests.ATM.DepositFunds(deposit);

            // Assert
            Assert.Equal(testBalance, result);
        }

        [Fact]
        public void Does_negative_money_go_in()
        {
            //Arrange
            double balance = Lab02UnitTests.ATM.GetBalance();
            double deposit = -10;
            double testBalance = balance + deposit;

            // Act
            double result = Lab02UnitTests.ATM.DepositFunds(deposit);

            // Assert
            Assert.Equal(testBalance, result);
        }







        //[Fact]
        //public void overdraftProtection()

        //    //Arrange
        //decimal originalBalance = Lab02UnitTests.ATM.GetBalance();
        //decimal amountToWithdraw = originalBalance + 500;

        //// Act
        //decimal balanceAfterWithdraw = Program.withdrawFunds(amountToWithdraw);


        //// Assert
        //Assert.Equal(orignalBalance, balanceToWithdraw)
    }
}
