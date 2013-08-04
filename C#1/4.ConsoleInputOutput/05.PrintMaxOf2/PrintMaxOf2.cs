//Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.

using System;

namespace _05.PrintMaxOf2
{
    class PrintMaxOf2
    {
        static void Main()
        {
            Console.WriteLine("Input number 1");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Input number 2");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Max of {0} and {1} is {2}", a, b,((a>b)?a:b));
        }
    }
}
