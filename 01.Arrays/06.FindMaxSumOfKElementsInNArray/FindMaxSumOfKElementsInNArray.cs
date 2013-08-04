//Write a program that reads two integer numbers N and K 
//and an array of N elements from the console. 
//Find in the array those K elements that have maximal sum.

//Array of sequential elemnts

using System;

class FindMaxSumOfKElementsInNArray
{
    static void Main()
    {
        Console.WriteLine("Enter N");
        int N = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter K<N");
        int K = int.Parse(Console.ReadLine());
        int[] array = new int[N];
        for (int i = 0; i < N; i++)
        {
            Console.WriteLine("Enter number {0}",i+1);
            array[i]=int.Parse(Console.ReadLine());
        }

        int maxSum = 0;
        int startOfSum = 0;

        //scaning in the array to find the beginning of the array with max sum
        for (int i = 0; i <= N-K; i++)
        {
            //calculating the sum of the current sequence
            int tempSum = 0;
            for (int j = 0; j < K; j++)
            {
                tempSum += array[i + j];
            }
            //comparing the current sequence sum with the max sequence sum
            if (tempSum>maxSum)
            {
                maxSum = tempSum;
                startOfSum = i;
            }
        }


        //printing

        for (int i = startOfSum; i < startOfSum+K; i++)
        {
            Console.Write(array[i]+"+");
        }
        Console.WriteLine("=" + maxSum);
    }
}