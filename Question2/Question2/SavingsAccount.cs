using System;
using System.Dynamic;

namespace Question2
{
	public class SavingsAccount
	{
		private double savingsBalance { get; set; }

		public  double annualInterestRate { get; set; }



		public SavingsAccount (double savingsBalance, double annualInterestRate)
		{

			this.savingsBalance = savingsBalance;
			this.annualInterestRate = annualInterestRate;
		}

		public double SavingsBalance {
			get { return this.savingsBalance; }

			set { this.savingsBalance = value; } 
		}



		public double AnnualInterestRate {
			get { return this.annualInterestRate; }

			set 
			{ this.annualInterestRate = value; } 
			

		}


		public double CalculateMonthlyInterest ()
		{

			double monthlyInterest = (SavingsBalance * AnnualInterestRate) / 12;

			return monthlyInterest;


		}



	}
}

