//We are given 5 integer numbers. Write a program that checks 
//if the sum of some subset of them is 0. Example: 3, -2, 1, 1, 8  1+1-2=0.

using System;

namespace _09.ZeroSumSubset
{
    class ZerSumSubset
    {
        static void Main()
        {
            Console.WriteLine("Enter 5 numbers");
            int[] numbers = new int[5];
            for (int i = 0; i < 5; i++)
			{
			    numbers[i]=int.Parse(Console.ReadLine());
			}
            int count=0;
            for (int combinations = 1; combinations < 31; combinations++)
            {
                int currentSum=0;
                for (int currentBit = 0;currentBit < 5; currentBit++)
                {

                    int mask = 1 << currentBit;
                    int nAndMask = combinations & mask;
                    if (nAndMask == mask)
                    {
                        currentSum += numbers[currentBit];
                    }
                }
                if (currentSum==0)
                {
                    count++;
                }
            }
            Console.WriteLine("Combinations: {0}",count);
        }
    }
}
