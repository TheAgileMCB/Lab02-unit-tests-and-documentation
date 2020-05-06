using System;

namespace Lab02UnitTests
{
	public class Program
	{
		public static void Main(string[] args)
		{
			double balance = 20000.00;
			Console.WriteLine("Hello!");
			if ( ToLowerCase(Console.ReadLine()) == "check balance")
            {
				viewBalance(balance);
            }


		}

		public static string viewBalance(double balance)
        {
			Console.WriteLine($"Your balance is {balance:C}");

        }

		public static double withdrawFunds()
        {

        }

		public static double depositFunds()
        {

        }
	}
}
