//Write a method that return the maximal element in a portion
//of array of integers starting at given index. 
//Using it write another method that sorts an array in ascending / descending order.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.ReturnMaxElemInSubArray
{
    class MaxElemInSubArray
    {
        static int IndexOfMaxElemInSubArray(int[] Array, int startIndex, int endIndex)
        {
            int tempMax = Array[startIndex];
            int tempIndex = startIndex;
            for (int index = startIndex+1; index <= endIndex; index++)
            {
                if (Array[index]>tempMax)
                {
                    tempMax = Array[index];
                    tempIndex = index;
                }
            }
            return tempIndex;
        }

        static void SwitchElem(int[] Array, int elem1, int elem2)
        {
            int temp = Array[elem1];
            Array[elem1] = Array[elem2];
            Array[elem2] = temp;
        }

        static void SortDescendingArray(int[] inputArray)
        {
            for (int index = 0; index < inputArray.Length; index++)
            {
                int max = IndexOfMaxElemInSubArray(inputArray, index, inputArray.Length - 1);
                SwitchElem(inputArray, max, index);
            }
        }

        static void SortAscendingArray(int[] inputArray)
        {
            for (int index = inputArray.Length-1; index >= 0; index--)
            {
                int max = IndexOfMaxElemInSubArray(inputArray, 0, index);
                SwitchElem(inputArray, max, index);
            }
        }

        static void PrintArray(int[] inputArray)
        {
            foreach (var num in inputArray)
            {
                Console.Write(num+" ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[] myArray = { 6, 3, 3, 7, 3, 1, 4, 8, 0, 4, 1, 123, 4564, 9, 123, 35, 45, 2, 32 };
            SortDescendingArray(myArray);
            PrintArray(myArray);
            SortAscendingArray(myArray);
            PrintArray(myArray);
        }
    }
}
