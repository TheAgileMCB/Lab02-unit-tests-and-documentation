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
				Console.Write(" Welcome, User! \n What would you like to do? \n Please type the corresponding number now. \n\n 1. Check Balance \n 2. Withdraw \n 3. Deposit \n 4. Exit \n\n");

				string userResponse = Console.ReadLine();
				switch (userResponse)
				{
					case "1":

						ViewBalance();
						break;

					case "2":

						Console.WriteLine("How much would you like to withdraw?");
						decimal withdrawal = Math.Abs(decimal.Parse(Console.ReadLine()));

						WithdrawFunds(withdrawal);
						break;

					case "3":

						Console.WriteLine("How much would you like to deposit?");
						decimal deposit = Math.Abs(decimal.Parse(Console.ReadLine()));

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
		private static decimal balance = 0;

		public static decimal GetBalance()
		{
			return balance;
		}

		public static decimal WithdrawFunds(decimal withdrawal)
		{
			try
			{
				//if (withdrawal < 0)
				//{
				//	Console.WriteLine("Cannot withdraw negative amount");
				//	return balance;
				//}
				balance = balance - withdrawal;
				if(balance < 0)
				{
					Console.WriteLine("Your account must remain positive");
					return balance;
				}
				Console.WriteLine($"You are withdrawing {withdrawal:C}");
				return balance;
			}
			catch (ArgumentOutOfRangeException)
			{

				throw;
			}
		}

		public static decimal DepositFunds(decimal deposit)
		{
			try
			{
				balance = balance + deposit;
				Console.WriteLine($"You are depositing {deposit:C}");
				return balance;
			}
			catch (ArgumentOutOfRangeException)
			{

				throw;
			}
		}
	}
}
