using System;
using System.Dynamic;
using System.Runtime.Remoting.Messaging;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace Question4
{
	public class Rational
	{
		private int numerator;
		private int denominator;


		public Rational ()
		{

			int numerator = 0;
			int denominator = 0;


		}

		public Rational (int numerator, int denominator)
		{
			this.numerator = numerator;
			this.denominator = denominator;
		}





		public int Numerator {
			get { return  this.numerator; }
			set { this.numerator = Value; }
		}

		public int Denominator {
			get { return  this.denominator; }
			set { this.denominator = Value; }
		}


		// To be completeed soon
	}
}

