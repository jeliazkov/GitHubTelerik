//Write a program that reads a rectangular matrix of size N x M and 
//finds in it the square 3 x 3 that has maximal sum of its elements.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MaxSumInSquare
{
    class MaxSumInSquare
    {
        static void Main()
        {
            //Console.WriteLine("Enter number of rows");
            //int rows = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter nubmer of cols");
            //int cols = int.Parse(Console.ReadLine());
            //double[,] matrix = new double[rows,cols];
            ////enter matrix manual
            //for (int row = 0; row < rows; row++)
            //{
            //    for (int col = 0; col < cols; col++)
            //    {
            //        Console.Write("Enter member {0},{1}  ",row+1,col+1);
            //        matrix[row, col] = double.Parse(Console.ReadLine());
            //    }
            //}

            
            double[,] matrix = {
            {1,2,3,4,5},
            {1,2,3,4,5},
            {2,3,4,5,6},
            {1,4,5,6,7},
            };
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            double maxSum = double.MinValue;
            int bestRow = 0;
            int bestCol = 0;
            for (int currentRow = 0; currentRow < rows-2; currentRow++)
            {
                for (int currentCol = 0; currentCol < cols-2; currentCol++)
                {
                    double tempSum = double.MinValue;
                    tempSum = matrix[currentRow, currentCol] + matrix[currentRow, currentCol + 1] + matrix[currentRow, currentCol + 2] +
                        matrix[currentRow + 1, currentCol] + matrix[currentRow + 1, currentCol + 1] + matrix[currentRow + 1, currentCol + 2] +
                        matrix[currentRow + 2, currentCol] + matrix[currentRow + 2, currentCol + 1] + matrix[currentRow + 2, currentCol + 2];
                    if (tempSum>maxSum)
                    {
                        maxSum = tempSum;
                        bestRow = currentRow;
                        bestCol = currentCol;
                    }
                }
            }

            Console.WriteLine("The best sum is {0} from the members:",maxSum);

            for (int row = bestRow; row < bestRow+3; row++)
            {
                for (int col = bestCol; col < bestCol+3; col++)
                {
                    Console.Write("{0,5}",matrix[row,col]);
                }
                Console.WriteLine();
            }
        }
    }
}
