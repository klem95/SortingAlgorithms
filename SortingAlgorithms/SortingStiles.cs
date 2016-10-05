using System;

namespace SortingAlgorithms
{
	public class SortingStiles
	{
		static SortingManager currentManager = new SortingManager ();

		//bool created = false;
		//bool filled = false; 

		public int[] array4Sorting;
		
		public SortingStiles ()
		{
		}

		public void insertionSorting ()  
		{
			if (currentManager.saveInputArrSize == 0) 
				currentManager.takeArraySize ();
			
			int[] array4Sorting = new int[currentManager.giveArraySize()]; 

			currentManager.FillWithrandomNum (array4Sorting);

			Console.WriteLine (" ");
			Console.WriteLine ("insertion sorting starts");

			for (int i = 0; i < array4Sorting.Length; i++) 
			{
				int tempInArray;

				for (int j = i + 1; j < array4Sorting.Length; j++) 
				{
					if (array4Sorting [i] > array4Sorting[j]) 
					{
						tempInArray = array4Sorting [i];
						array4Sorting [i] = array4Sorting [j];
						array4Sorting [j] = tempInArray;
						currentManager.executionCounter ();
					}
				}
			}
			currentManager.printArra (array4Sorting);
			currentManager.printExecutionCounter ();
		}


		public void bubbleSorting ()
		{

			//Turn "on" the code to get an interactive system

			//if (currentManager.saveInputArrSize == 0) 
			//currentManager.takeArraySize ();
			
			int[] array4Sorting = { 24,2,14,212,424,1,3,4,12,54,66,82,3,353,124,514,163,216,2614,161,346 };
			//int[] array4Sorting = new int[currentManager.giveArraySize()]; 
			int temp;


			//currentManager.FillWithrandomNum (array4Sorting);

			Console.WriteLine (" ");
			Console.WriteLine ("Bubble sorting starts");

			for (int i = 1; i < array4Sorting.Length; i++) 
			{		
				for (int j = 0; j < array4Sorting.Length - 1; j++) 
				{
					if (array4Sorting [j] > array4Sorting [j + 1]) {
						temp = array4Sorting [j];
						array4Sorting [j] = array4Sorting [j + 1];
						array4Sorting [j + 1] = temp;
						currentManager.executionCounter ();

					}
				}
			}
			currentManager.printArra (array4Sorting); 
			currentManager.printExecutionCounter ();

		}


		public void QuickSorting (int [] inputArry ,int leftSide, int rightSide)
		{
			// These two int are the left most number, and right must number.
			int i = leftSide;
			int j = rightSide;
			// Here it test whether the left most value is creater or equal to the right side value 
			if (leftSide >= rightSide) 
			{
				// if so, the it will return
				return;
			}

			//this holds the pivot
			int pivot = inputArry[leftSide];


			// this will run while i is smaller then j
			while (i < j) 
			{

				//here the i and j i compared again, as well as whether the value contained in inputArr at posiotion j is greater than the pivot 
				while (i < j && inputArry [j] > pivot) 
				{
					//j is decrimented
					j--;
				}
			
				//here the value of nputArry [i] is assigned inputArry at position j
				inputArry [i] = inputArry [j]; 

				//here the vaulues are ones again (expect this time it is i) to the pivot
				while (i < j && inputArry [i] < pivot) 
				{
					// i is incrimented
					i++;

				}
				currentManager.executionCounter ();


				//here the value of nputArry [j] is assigned inputArry at position i
				inputArry [j] = inputArry [i];

			}
			// the pivot is now set the at the posistion inputArry [i]
			inputArry [i] = pivot;


			//the quickSorting function is called recursively, where the left and right most vaulues are decresead and increased.
			QuickSorting (inputArry,leftSide, i - 1);
			QuickSorting (inputArry, i + 1, rightSide);



		}
	}
}

