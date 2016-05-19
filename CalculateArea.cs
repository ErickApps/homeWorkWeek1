using System;

namespace CalculateArea
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int length;
			int width; 


			Console.WriteLine("Enter length: ");
			length = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine( "Enter the width: ");

			width = Convert.ToInt32(Console.ReadLine());

			int area = CalcArea(length, width);
			Console.WriteLine("The area is: "+area);


			Console.ReadLine();
		}
		public static int CalcArea(int length, int width)
		{
			return length * width;
		}


	}
}