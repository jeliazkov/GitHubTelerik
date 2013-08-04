//Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01d.FillMatrixByPattern
{
    class FillMatrixByPatternD
    {
        static void Main()
        {
            Console.WriteLine("Enter size of the matrix");
            int n = int.Parse(Console.ReadLine());
            int number = 1;
            int lenght = n - 1;
            int delta = 1;
            int[,] matrix = new int[n, n];

            //fill 1st row
            for (int i = 0; i < n; i++)
            {
                matrix[0, i] = number;
                number++;
            }

            //repetitive filling the rest of the rows
            for (int j = 0; j < n / 2; j++)
            {

                for (int i = 0; i <= lenght - delta; i++)
                {
                    matrix[i + j + 1, n - j - 1] = number;
                    number++;
                }
                for (int i = 0; i <= lenght - delta; i++)
                {
                    matrix[n - 1 - j, n - 2 - j - i] = number;
                    number++;
                }
                for (int i = 0; i <= lenght - delta - 1; i++)
                {
                    matrix[n - 2 - i - j, j] = number;
                    number++;
                }
                for (int i = 0; i <= lenght - delta - 1; i++)
                {
                    matrix[1 + j, i + 1 + j] = number;
                    number++;
                }
                delta += 2;
            }

            //printing
            for (int col = 0; col < n; col++)
            {
                for (int row = 0; row < n; row++)
                {
                   
                        Console.Write("{0,4}",matrix[row, col]);

                }
                Console.WriteLine();
            }
        }
    }
}
