using System;

namespace SortingAlgorithms
{
	class MainClass
	{
		//static int inpuValue;
		static SortingStiles choseSortingType = new SortingStiles ();
		static int [] test = {24,2,14,212,424,1,3,4,12,54,66};
		static SortingManager test1 = new SortingManager ();

		public static void Main (string[] args)
		{
//			var watch1 = System.Diagnostics.Stopwatch.StartNew();
//			choseSortingType.bubbleSorting ();
//			watch1.Stop();
//			var elapsedMs1 = watch1.ElapsedMilliseconds;
//			Console.WriteLine ("It toke:");
//			Console.WriteLine (elapsedMs1);
//
			//choseSortingType.insertionSorting ();

			//Console.WriteLine ("Quick sorting has started ");

			var watch = System.Diagnostics.Stopwatch.StartNew();
			choseSortingType.QuickSorting (test,0,test.Length-1);
			test1.printArra (test);
			watch.Stop();
			var elapsedMs = watch.ElapsedMilliseconds;
			Console.WriteLine ("Iafasfasf:");

			Console.WriteLine ("It toke:");
			Console.WriteLine (elapsedMs);

			//test1.printArra (test);
			//test1.printExecutionCounter ();

			//With a fixed set of numbers (seen above), i can be seen that the quick sorte needed 33 times to execute the action, while the bubble sort toke 25 times.
			// 

		}
	}
}
