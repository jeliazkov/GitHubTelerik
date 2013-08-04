//We are given a matrix of strings of size N x M. 
//Sequences in the matrix we define as sets of several 
//neighbor elements located on the same line, column or diagonal. 
//Write a program that finds the longest sequence of equal strings in the matrix. Example:


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.FindLongestSequence
{
    class FindLongestSequence
    {
        static void Main()
        {

            string[,] matrix = {
                                   {"ha","fifi","ho","xx"},
                                   {"fo","ha","ha","xx"},
                                   {"xxx","xxx","xxx","xx"},
                                   {"fo","ho","ha","xx"},
                                   {"fo","ho","ha","xx"},
                               };
            int nRows = matrix.GetLength(0);
            int nCols = matrix.GetLength(1);
            int maxCount = 1;
            string maxElement="None";
            string maxDirection="None";

            for (int row = 0; row < nRows; row++)
            {
                for (int col = 0; col < nCols; col++)
                {
                    //horisontal check
                    int currentCol = col;
                    int currentRow = row;
                    int currentCount = 1;
                    while (currentCol<nCols-1 && matrix[currentRow,currentCol]==matrix[currentRow,currentCol+1])
                    {                     
                        currentCount++;
                        currentCol++;
                    }
                    if (currentCount>maxCount)
                    {
                        maxCount = currentCount;
                        maxElement = matrix[row, col];
                        maxDirection = "Right";
                    }
                    //vertical check
                    currentCol = col;
                    currentRow = row;
                    currentCount = 1;
                    while (currentRow<nRows-1 && matrix[currentRow,currentCol]==matrix[currentRow+1,currentCol])
                    {
                        currentCount++;
                        currentRow++;
                    }
                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                        maxElement = matrix[row, col];
                        maxDirection = "Down";
                    }
                    //Diagonal Down Right
                    currentCol = col;
                    currentRow = row;
                    currentCount = 1;
                    while (currentRow<nRows-1 && currentCol<nCols-1 && matrix[currentRow,currentCol]==matrix[currentRow+1,currentCol+1])
                    {
                        currentCount++;
                        currentRow++;
                        currentCol++;
                    }
                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                        maxElement = matrix[row, col];
                        maxDirection = "Down Right";
                    }
                    //Diagonal Down Left
                    currentCol = col;
                    currentRow = row;
                    currentCount = 1;
                    while (currentRow<nRows-1 && currentCol>0 && matrix[currentRow,currentCol]==matrix[currentRow+1,currentCol-1])
                    {
                        currentCount++;
                        currentRow++;
                        currentCol--;
                    }
                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                        maxElement = matrix[row, col];
                        maxDirection = "Down Left";
                    }
                }
            }

            Console.WriteLine("The element \"{0}\" is repeated {1} times in {2} direction",maxElement,maxCount,maxDirection);
        }
    }
}
