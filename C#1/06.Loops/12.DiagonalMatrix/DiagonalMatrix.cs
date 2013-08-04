//Write a program that reads from the console a positive integer number N (N < 20) and outputs a matrix like the following:
//	N = 3			N = 4

using System;

class DiagonalMatrix
{
    static void Main()
    {
        Console.WriteLine("Enter size of the matrix:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Here is the matrix: \n");
        for (int row = 1; row <= n; row++)
        {
            int number = row;
            for (int pos = 0; pos < n; pos++)
            {
                if (number > 9)
                {
                    Console.Write(number + " ");
                }
                else
                {
                    Console.Write(number + "  ");
                }
                number++;
            }
            Console.WriteLine("\n");
        }
    }
}

