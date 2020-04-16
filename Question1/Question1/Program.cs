using System;

namespace Question1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("======App to find area of a rectangle========");


			Rectangle myRectange = new Rectangle (8.0f, 6.9f);

			Console.WriteLine (myRectange.Area ());

		}
	}
}
