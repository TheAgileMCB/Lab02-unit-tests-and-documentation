using System;

namespace Lab02UnitTests
{
	public class Program
	{
		public static void Main(string[] args)
		{
			double balance = 20000.00;
			Console.WriteLine("Hello!");
			Console.Write(" Welcome, User! \n What would you like to do? \n Please type it now, \n\n Check Balance \n Withdraw \n Deposit \n Exit \n\n");

			string userResponse = Console.ReadLine();
			switch (userResponse.ToLower())
			{
				case "check balance":
	
				viewBalance(balance);
					break;

				case "withdraw":
			
				withdrawFunds(balance);
					break;

				case "deposit":

				depositFunds(balance);
					break;

				default:
				Console.WriteLine("Thank you and goodbye!");
					break;
			}

		}

		public static void viewBalance(double balance)
		{
			Console.WriteLine($"Your balance is {balance:C}");

		}

		public static double withdrawFunds(double balance)
		{
			Console.WriteLine("How much would you like to withdraw?");
			double withdrawl = double.Parse(Console.ReadLine());
			double newBalance = balance - withdrawl;
			Console.WriteLine($"You are withdrawing {withdrawl:C}");
			return newBalance;
		}

		public static double depositFunds(double balance)
		{
			return 00.00;
		}
	}
}
