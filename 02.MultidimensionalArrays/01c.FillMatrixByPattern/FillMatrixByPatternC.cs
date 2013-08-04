//Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01c.FillMatrixByPattern
{
    class FillMatrixByPatternC
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());

            int counter = 1;
            int[,] arr = new int[N, N];

            for (int row = N-1; row >= 0; row--)
            {
                int col = 0;
                int curRow = row;
                for (int repeat = 0; repeat < N-row; repeat++)
                {
                    arr[curRow, col] = counter;
                    counter++;
                    col++;
                    curRow++;
                }
            }

            for (int col = 1; col < N; col++)
            {
                int row = 0;
                int curCol = col;
                for (int repeat = N-col; repeat > 0; repeat--)
                {
                    arr[row,curCol]=counter;
                    counter++;
                    row++;
                    curCol++;
                }
            }

            //print matrix
            for (int row = 0; row < N; row++)
            {
                for (int col = 0; col < N; col++)
                {
                    Console.Write("{0,4}", arr[row, col]);
                }
                Console.WriteLine();
            }
           
        }
    }
}
