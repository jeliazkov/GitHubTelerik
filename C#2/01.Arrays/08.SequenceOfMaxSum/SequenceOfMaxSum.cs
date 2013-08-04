//Write a program that finds the sequence of maximal sum in given array. Example:
//    {2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}
//    Can you do it with only one loop (with single scan through the elements of the array)?

using System;

class SequenceOfMaxSum
{
    static void Main()
    {
        int[] myArray = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
        int N = myArray.Length;

        int maxSum = 0;
        int maxStart = 0;
        int maxCount = 0;
        int tempSum = 0;

        //scan trough the array for beginning of possible array
        for (int start = 0; start < N; start++)
        {
            //scanning for the end of this possible array
            for (int elementsCount = 1; elementsCount <= N-start; elementsCount++)
            {
                //calculating the sum of the possible array
                tempSum = 0;
                for (int currentElement = start; currentElement < start+elementsCount; currentElement++)
                {
                    tempSum += myArray[currentElement];
                }
                //comparing with the max found sum
                if (tempSum>maxSum)
                {
                    maxSum = tempSum;
                    maxStart = start;
                    maxCount = elementsCount;
                }
            }
        }

        //print
        Console.WriteLine("The sequence of maximal sum in the given array is:");
        for (int i = maxStart; i < maxStart+maxCount; i++)
        {
            Console.Write(myArray[i]+" ");
        }
        Console.WriteLine();
    }
}