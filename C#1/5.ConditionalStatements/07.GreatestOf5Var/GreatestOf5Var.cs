//Write a program that finds the greatest of given 5 variables.

using System;

namespace _07.GreatestOf5Var
{
    class GreatestOf5Var
    {
        static void Main()
        {
            Console.WriteLine("Write 5 numbers");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double e = double.Parse(Console.ReadLine());
            double max;

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
            if (d > max)
            {
                max = d;
            }
            if (e > max)
            {
                max = e;
            }
            Console.WriteLine("The greatest number is: {0}",max);
        }
    }
}
