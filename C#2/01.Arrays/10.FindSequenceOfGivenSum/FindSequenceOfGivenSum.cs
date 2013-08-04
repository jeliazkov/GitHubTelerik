//Write a program that finds in given array of integers a sequence of given sum S (if present). 
//Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}	

using System;

class FindSequenceOfGivenSum
{
    static void Main()
    {
        int[] myArray = { 4, 3, 1, 4, 2, 5, 8 };
        int N = myArray.Length;
        Console.WriteLine("Enter sum S to look for:");
        int S = int.Parse(Console.ReadLine());

        int maxSum = 0;
        int maxStart = 0;
        int maxCount = 0;
        int tempSum = 0;
        bool sumFound = false;

        //finding the srat of every possible sequendce
        for (int start = 0; start < N; start++)
        {
            //finding every sequence with this start
            for (int elementsCount = 1; elementsCount <= N - start; elementsCount++)
            {
                tempSum = 0;
                //calculating the sum of the sequence with the current start and end
                for (int currentElement = start; currentElement < start + elementsCount; currentElement++)
                {
                    tempSum += myArray[currentElement];
                }
                //comparing
                if (tempSum == S)
                {
                    maxSum = tempSum;
                    maxStart = start;
                    maxCount = elementsCount;
                    sumFound = true;
                }
            }
        }

        //print
        if (sumFound)
        {
            Console.WriteLine("The sequence with sum {0} in the given array is:",S);
            for (int i = maxStart; i < maxStart + maxCount; i++)
            {
                Console.Write(myArray[i] + " ");
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("There is no sequence with sum {0} in the given array.",S);
        }
    }
}