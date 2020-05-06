using System;

namespace Lab02UnitTests
{
	public class ATM
	{
		public static void Main()
		{
			try
			{
				Console.WriteLine("Hello!");
				Console.Write(" Welcome, User! \n What would you like to do? \n Please type it now, \n\n Check Balance \n Withdraw \n Deposit \n Exit \n\n");

				string userResponse = Console.ReadLine();
				switch (userResponse.ToLower())
				{
					case "check balance":

						ViewBalance();
						break;

					case "withdraw":

						Console.WriteLine("How much would you like to withdraw?");
						double withdrawal = Math.Abs(double.Parse(Console.ReadLine()));

						WithdrawFunds(withdrawal);
						break;

					case "deposit":

						Console.WriteLine("How much would you like to deposit?");
						double deposit = Math.Abs(double.Parse(Console.ReadLine()));

						DepositFunds(deposit);
						break;

					default:
						Console.WriteLine("Thank you and goodbye!");
						break;
				}
			}
			catch (Exception)
			{

				throw;
			}
		}

		public static void ViewBalance()
		{
			Console.WriteLine($"Your balance is {balance:C}");

		}
		private static double balance = 20000;

		public static double GetBalance()
		{
			return balance;
		}

		public static double WithdrawFunds(double withdrawal)
		{
			try
			{
				double newBalance = balance - withdrawal;
				if(newBalance < 0)
				{
					Console.WriteLine("Your account must remain positive");
					return balance;
				}
				Console.WriteLine($"You are withdrawing {withdrawal:C}");
				return newBalance;
			}
			catch (ArgumentOutOfRangeException)
			{

				throw;
			}
		}

		public static double DepositFunds(double deposit)
		{
			try
			{
				double newBalance = balance + deposit;
				Console.WriteLine($"You are depositing {deposit:C}");
				return newBalance;
			}
			catch (ArgumentOutOfRangeException)
			{

				throw;
			}
		}
	}
}
