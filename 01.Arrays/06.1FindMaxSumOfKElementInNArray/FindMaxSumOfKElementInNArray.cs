//Write a program that reads two integer numbers N and K 
//and an array of N elements from the console. 
//Find in the array those K elements that have maximal sum.

//Max of all elements

using System;

    class FindMaxSumOfKElementInNArray
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
                Console.WriteLine("Enter number {0}", i + 1);
                array[i] = int.Parse(Console.ReadLine());
            }
            bool[] used = new bool[N];  //array to store if the position is already used in the sum
            int maxSum = 0;

            //going trough the array K times to find the next maximal element
            for (int times = 0; times < K; times++)
            {
                int tempMax = Int32.MinValue;   //the minimal integer - in order to accept negative members
                int tempPosition = 0;
                for (int i = 0; i < N; i++)
                {
                    if (array[i] > tempMax && used[i]==false)
                    {
                        tempMax = array[i];
                        tempPosition = i;
                    }
                }
                used[tempPosition] = true;
                maxSum += tempMax;
            }

            //print
            Console.WriteLine("The max sum is = {0}",maxSum);
        }
    }