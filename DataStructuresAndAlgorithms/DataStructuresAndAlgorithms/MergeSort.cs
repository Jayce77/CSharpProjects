using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms
{
    class MergeSort
    {
        /// <summary>
        /// Main function that sorts arr[left ... right] using Merge()
        /// </summary>
        /// <param name="arr">The array that you are sorting</param>
        /// <param name="leftPoint">The index of the array to be used as the left pointer (usually 0)</param>
        /// <param name="rightPoint">The index of the array to be used as the left pointer (usually Length - 1)</param>
        public void Sort(int[] arr, int leftPoint, int rightPoint)
        {
            Console.WriteLine($"splitting l r: {leftPoint} {rightPoint}");
            if (leftPoint < rightPoint)
            {
                //Find the middle point
                int middlePoint = (leftPoint + rightPoint) / 2;

                //Sort the first and second halves
                Sort(arr, leftPoint, middlePoint);
                Sort(arr, middlePoint + 1, rightPoint);

                //Merge the sorted halves
                Merge(arr, leftPoint, middlePoint, rightPoint);
            }
        }

        //Merges two subarrays of arr[]
        //First subarray is arr[leftPont ... middlePoint]
        //Second subarray is arr[middlePont + 1 ... rightPoint]
        private void Merge(int[] arr, int leftPoint, int middlePoint, int rightPoint)
        {
            Console.WriteLine($"merge l m r: {leftPoint} {middlePoint} {rightPoint}");

            //Find sizes of two subarrays to be merged
            int leftSize = middlePoint - leftPoint + 1;
            int rightSize = rightPoint - middlePoint;

            //Create temp arrays
            int[] leftTemp = new int[leftSize];
            int[] rightTemp = new int[rightSize];

            //Copy data to temp arrays
            for (int g = 0; g < leftSize; g++)
            {
                leftTemp[g] = arr[leftPoint + g];
            }
            for (int h = 0; h < rightSize; h++)
            {
                rightTemp[h] = arr[middlePoint + 1 + h];
            }

            //Merge two arrays temp arrays

            //Initial indexes for two arrays
            int i = 0;
            int j = 0;

            //Initial index of merged sub array
            int k = leftPoint;
            while (i < leftSize && j < rightSize)
            {
                if (leftTemp[i] <= rightTemp[j])
                {
                    arr[k] = leftTemp[i];
                    i++;
                }
                else
                {
                    arr[k] = rightTemp[j];
                    j++;
                }
                k++;
            }

            //Copy remaining elements of leftTemp if any
            while (i < leftSize)
            {
                arr[k] = leftTemp[i];
                i++;
                k++;
            }
            //Copy remaining elements of rightTemp if any
            while (j < rightSize)
            {
                arr[k] = rightTemp[j];
                j++;
                k++;
            }

            Console.WriteLine("After merge");
            PrintArray(arr);
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
