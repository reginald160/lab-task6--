using System;
using System.Configuration;

namespace Question3
{
	public class Complex
	{

		private float realPart { get; set; }

		private float imaginary{ get; set; }






		public Complex ()
		{
			this.realPart = realPart;
			this.imaginary = imaginary;

		}

	

		public double add (double Num1, double Num2)
		{
			double addition = (realPart + Num1 * realPart) + (imaginary + Num2 * imaginary);

			return addition;
		}

		public float subtract (float num1, float num2)
		{
			float subtraction =	(realPart + num1 * realPart) + (imaginary + num2 * imaginary);

			return subtraction;
		}

		public String toString ()
		{
			return String.Format ("({0}, {1})", realPart, imaginary);
		}
	}



}

