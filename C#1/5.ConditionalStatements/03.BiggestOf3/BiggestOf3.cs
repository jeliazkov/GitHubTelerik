//Write a program that finds the biggest of three integers using nested if statements.

using System;

namespace _03.BiggestOf3
{
    class BiggestOf3
    {
        static void Main()
        {
            Console.WriteLine("Write 3 numbers");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int max;
            if (a > b)
            {
                max = a;
            }
            else
            {
                max = b;
            }
            if (c > max)
            {
                max = c;
            }
            Console.WriteLine("Max number is {0}",max);
        }
    }
}
