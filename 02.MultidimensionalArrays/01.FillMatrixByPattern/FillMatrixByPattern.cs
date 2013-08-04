//Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.FillMatrixByPattern
{
    class FillMatrixByPattern
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());

            int counter = 1;
            int[,] arr = new int[N, N];
            for (int col = 0; col < N; col++)
            {
                for (int row = 0; row < N; row++)
                {
                    arr[row,col]=counter;
                    counter++;
                }
            }

            //print matrix
            for (int row = 0; row < N; row++)
            {
                for (int col = 0; col < N; col++)
                {
                    Console.Write("{0,4}",arr[row,col]);
                }
                Console.WriteLine();
            }
        }
    }
}
