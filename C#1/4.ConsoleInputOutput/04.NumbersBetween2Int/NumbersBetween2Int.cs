//Write a program that reads two positive integer numbers and prints 
//how many numbers p exist between them such that the reminder 
//of the division by 5 is 0 (inclusive). Example: p(17,25) = 2.

using System;

namespace _04.NumbersBetween2Int
{
    class NumbersBetween2Int
    {
        static void Main()
        {
            int min;
            int max;
            int count=0;
            Console.WriteLine("Input number 1");
            int input1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input number 2");
            int input2 = int.Parse(Console.ReadLine());
            if (input1 < input2)
            {
                min = input1;
                max = input2;
            }
            else
            {
                min = input2;
                max = input1;
            }
            
            for (int i = min; i <= max; i++)
            {
                if (i%5==0)
                {
                    count++;
                }
            }
            Console.WriteLine("Between {0} and {1} exist {2} numbers such that the reminder of the division by 5 is 0",min,max,count);
        }
    }
}
