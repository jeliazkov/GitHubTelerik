//Write a program that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time.

using System;

class PrintNotDiv3And7
{
    static void Main()
    {
        Console.WriteLine("Enter number to print not divisible numbers by 3 and 7 at the same time:");
        string input = Console.ReadLine();
        int n;
        if (int.TryParse(input, out n))
        {
            Console.WriteLine("The numbers from 1 to {0}, not divisible by 3 and 7 at the same time are:", n);
            for (int i = 1; i <= n; i++)
            {
                if (i % 7 != 0 || i % 3 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }
}
