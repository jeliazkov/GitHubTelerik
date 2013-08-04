//Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...

using System;

namespace _10.SumOfSequence
{
    class SumOfSequence
    {
        static void Main()
        {
            decimal number = 1M;
            decimal sum = 0M;
            decimal delta;
            int i = 1;
            int count = 0;
            do
            {
                sum = sum + number;
                i++;
                if (i % 2 == 0)
                {
                    number = 1.0M / i;
                }
                else
                {
                    number = -1.0M / i;
                }
                //Console.WriteLine("number {0} sum {1}", number, sum);
                delta = Math.Abs(number);
                count++;
            } 
            while (delta >= 0.001M);
            Console.WriteLine("The sum of the sequence (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ... is: {0:0.000} .It's made of the first {1} members", sum, count);
        }
    }
}
