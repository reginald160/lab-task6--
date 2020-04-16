using System;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Globalization;

namespace Question2
{
	class MainClass
	{
		public double annualInterestRate = 0;

		public static void Main (string[] args)
		{ 


			SavingsAccount saver1 = new SavingsAccount (200.00, 4);
			SavingsAccount saver2 = new SavingsAccount (300.00, 4);

			Console.WriteLine (" The Monthly interst of saver1 "
			+ saver1.CalculateMonthlyInterest ().ToString ("C", CultureInfo.CurrentCulture));
			Console.WriteLine (" The Monthly interst of saver1 "
			+ saver2.CalculateMonthlyInterest ().ToString ("C", CultureInfo.CurrentCulture));



		}


	}

}
