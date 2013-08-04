//* Write a program that reads a positive integer number N (N < 20) from console 
//and outputs in the console the numbers 1 ... N numbers arranged as a spiral.

using System;

class SpiralMatrix
{
    static void Main()
    {
        Console.WriteLine("Enter size of the matrix");
        int n = int.Parse(Console.ReadLine());
        int number=1;
        int lenght=n-1;
        int delta = 1;
        int[,] matrix = new int[n, n];
        
        //fill 1st row
        for (int i = 0; i < n; i++)
        {
            matrix[0, i] = number;
            number++;
        }

        //repetitive filling the rest of the rows
        for (int j = 0; j < n/2; j++)
        {

            for (int i = 0; i <= lenght - delta; i++)
            {
                matrix[i + j+1, n - j-1] = number;
                number++;
            }
            for (int i = 0; i <= lenght - delta; i++)
            {
                matrix[n - 1-j, n -2-j - i] = number;
                number++;
            }
            for (int i = 0; i <= lenght - delta - 1; i++)
            {
                matrix[n - 2 - i-j, j] = number;
                number++;
            }
            for (int i = 0; i <= lenght - delta - 1; i++)
            {
                matrix[1+j, i + 1+j] = number;
                number++;
            }
            delta += 2;
        }

        //printing
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (matrix[i,j]>99)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                else if (matrix[i, j] > 9)
                {
                    Console.Write(matrix[i, j] + "  ");
                }
                else 
                {
                    Console.Write(matrix[i, j] + "   ");
                }
            }
            Console.WriteLine();
        }
    }
}