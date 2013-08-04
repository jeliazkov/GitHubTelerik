//Write a program that prints all the numbers from 1 to N.

using System;

class PrintNums1ToN
{
    static void Main()
    {
        Console.WriteLine("Enter number to sum to:");
        string input = Console.ReadLine();
        int n;
        if (int.TryParse(input, out n))
        {
            Console.WriteLine("The numbers from 1 to {0} are:",n);
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }
}

