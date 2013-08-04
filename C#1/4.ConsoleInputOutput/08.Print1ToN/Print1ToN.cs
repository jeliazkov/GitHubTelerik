//Write a program that reads an integer number n from the console and prints all the 
//numbers in the interval [1..n], each on a single line.

using System;

namespace _08.Print1ToN
{
    class Print1ToN
    {
        static void Main()
        {
            Console.WriteLine("Input number");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("The numbers from 1 to {0} are:",n);
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
