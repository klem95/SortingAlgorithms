using System;

namespace SortingAlgorithms
{
	public class SortingManager
	{
		static int countedValue = 0;
		public int quickSortPivoit = 0;
		public int saveInputArrSize;
		 


		public SortingManager ()
		{
			
		}
	
		public int [] FillWithrandomNum (int[] Inputarray)
		{
			Random rndValues = new Random ();
			int values;

			for (int i = 0; i < Inputarray.Length; i++) {
				values = rndValues.Next(0,424);
				Inputarray [i] = values;
			}
			Console.WriteLine ("The array is filled with the following random numbers");
			printArra (Inputarray);
			return Inputarray;
		}

		public void printArra (int[] inputArr)
		{
			for (int i = 0; i < inputArr.Length; i++) {
				Console.WriteLine (inputArr[i]);
			}
		}

		public void executionCounter () 
		{
			countedValue++; 
		}

		public void printExecutionCounter ()
		{
			Console.WriteLine ("I had to sort: " + countedValue + " times");
		}

		public void takeArraySize ()
		{
			saveInputArrSize = Convert.ToInt32(Console.ReadLine());;
			Console.Clear ();

		}

		public int giveArraySize () 
		{
			return saveInputArrSize;
		}





			







	}
}

