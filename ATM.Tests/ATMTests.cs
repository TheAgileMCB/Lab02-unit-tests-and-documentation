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
            //Arrange | Given
            double balance = Lab02UnitTests.ATM.GetBalance();
            double deposit = 10;

            // Act | When
            double result = Lab02UnitTests.ATM.DepositFunds(deposit);

            // Assert | Then
            double expectedBalance = balance + deposit;
            Assert.Equal(expectedBalance, result);
        }

        [Fact]
        public void Does_negative_money_go_in()
        {
            //Arrange
            double balance = Lab02UnitTests.ATM.GetBalance();
            double deposit = -10;

            // Act
            double result = Lab02UnitTests.ATM.DepositFunds(deposit);

            // Assert
            double expectedBalance = balance + deposit;
            Assert.Equal(expectedBalance, result);
        }

        [Fact]
        public void Overdraft_protection()
        {
            //Arrange
            double balance = Lab02UnitTests.ATM.GetBalance();
            double withdrawal = balance + 500;

            // Act
            double balanceAfterWithdraw = Lab02UnitTests.ATM.WithdrawFunds(withdrawal);


            // Assert
            Assert.Equal(balance, withdrawal - 500);
                }
    }
}
