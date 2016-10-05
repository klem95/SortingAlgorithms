using System;

namespace SortingAlgorithms
{
	class MainClass
	{
		static int inpuValue;
		static SortingStiles choseSortingType = new SortingStiles ();
		static int [] test = {24,2,14,212,424,1,3,4,12,54,66,82,};
		static SortingManager test1 = new SortingManager ();

		public static void Main (string[] args)
		{
			
			choseSortingType.bubbleSorting ();
			//choseSortingType.insertionSorting ();

			Console.WriteLine ("Quick sorting has started ");
			choseSortingType.QuickSorting (test,0,test.Length-1);
			test1.printArra (test);
			test1.printExecutionCounter ();

			//With a fixed set of numbers (seen above), i can be seen that the quick sorte needed 33 times to execute the action, while the bubble sort toke 25 times.
			// 

		}
	}
}
