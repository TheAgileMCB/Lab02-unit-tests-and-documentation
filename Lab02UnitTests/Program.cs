using System;

namespace Lab02UnitTests
{
	public class Program
	{
		public static void Main(string[] args)
		{
			double balance = 20000.00;
			Console.WriteLine("Hello!");
			Console.Write(" Welcome, User! \n What would you like to do? \n Please type it now, \n\n Check Balance \n Withdraw \n Deposit \n Exit");
			if (Console.ReadLine().ToLower() == "check balance")
			{
				viewBalance(balance);
			}


		}

		public static void viewBalance(double balance)
		{
			Console.WriteLine($"Your balance is {balance:C}");

		}

		public static double withdrawFunds()
		{
			return ;
		}

		public static double depositFunds()
		{
			return 00.00;
		}
	}
}
