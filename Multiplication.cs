using System;

namespace Multiplication
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Enter a number to be multiplied!");
			int number = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine ("Table of "+number);
			Console.WriteLine ();
			multiplication (number);
		}
		public static void multiplication(int number)
		{
			int counter = number;
			number = number * number;

			for (int i = 1; i <= counter; i++) {

				for (int j = 1; j <= counter; j++) {

					Console.Write(j*i + " ");
				}

				Console.WriteLine( );
			}
	}
}
}