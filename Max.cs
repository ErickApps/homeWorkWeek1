using System;

namespace FindMax
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[] arr = { 8, 5,10,4,56,7,4 };
			Console.WriteLine ("The Max is "+Max(arr));
		}

		public static int Max(int[] arr)
		{
			int index = 0;

			for (int i = 0; i < arr.Length; i++) {

				if (i != arr.Length -1 && arr[i] > arr[i+1] ) {

					int temp = arr [i];
					arr [i] = arr [i+1];
					arr [i + 1] = temp;
				}
				index = i;
			}
			return arr[index];

		}



	}
		
}
