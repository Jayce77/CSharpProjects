using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms
{
    class QuickSort
    {
        public int[] Sort(int[] arr)
        {
            //Pick a pivot element randomly

            //Walk through the array makingsure that all elements
            //are smaller before the pivot and that elements after are bigger
            //and we do this in place! That's the killer feature.
            //No extra array required
            //We repeat the process to the left and right portionsover and over again
            //Eventually the array will be sorted

            QuickSortMain(arr, 0, arr.Length - 1);
            PrintArray(arr);

            return arr;
        }

        private void QuickSortMain(int[] arr, int leftPoint, int rightPoint)
        {
            if (leftPoint >= rightPoint)
            {
                return;
            }

            //Step 1: Pick a pivot element - We will chose the center
            //Better would be to choose left + (right -left)/2 (as this would avoid overflow errors in large arrays i.e. 2GB
            int pivot = arr[(leftPoint + rightPoint) / 2];

            //Step 2: Partition the array around this pivot - return the index of the partition
            int index = Partition(arr, leftPoint, rightPoint, pivot);

            //Step 3: Sort on the left and the right side
            QuickSortMain(arr, leftPoint, index - 1);
            QuickSortMain(arr, index, rightPoint);

        }

        private int Partition(int[] arr, int leftPoint, int rightPoint, int pivot)
        {
            //Move the left and right pointers towards each other
            while (leftPoint <= rightPoint)
            {
                //Move the leftPoint until you find an element bigger than the pivot
                while (arr[leftPoint] < pivot)
                {
                    leftPoint++;
                }
                //Move the rightPoint until you find an element smaller than the pivot
                while (arr[rightPoint] > pivot)
                {
                    rightPoint--;
                }

                if (leftPoint <= rightPoint)
                {
                    Swap(arr, leftPoint, rightPoint);
                    leftPoint++;
                    rightPoint--;
                }
            }
            //When we get here, everything in this partition will be in the right order
            //Now we need to return to the next partition point - which for us will be on the left
            return leftPoint;
        }

        private void Swap(int[] arr, int leftPoint, int rightPoint)
        {
            int temp = arr[leftPoint];
            arr[leftPoint] = arr[rightPoint];
            arr[rightPoint] = temp;
        }

        private void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

        }
    }
}
