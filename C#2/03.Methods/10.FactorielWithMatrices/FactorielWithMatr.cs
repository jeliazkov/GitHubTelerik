//Write a program to calculate n! for each n in the range [1..100]. 
//Hint: Implement first a method that multiplies a number 
//represented as array of digits by given integer number. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.FactorielWithMatrices
{
    class FactorielWithMatr
    {
        /// <summary>
        /// The method multiplies two numbers  entered as strings, and returns the result as string
        /// </summary>
        /// <param name="number1">The first number to be multiplied(as string)</param>
        /// <param name="number2">The second number to be multiplied(as string)</param>
        /// <returns>The result of the multiplication(as string)</returns>
        static string MultiplyStringInIntArr(string number1, string number2)
        {
            int[] num1 = StringNumToArray(number1);
            int[] num2 = StringNumToArray(number2);
            int height = num1.Length;
            int width = num2.Length;
            int[,] matrix = new int[height, width+1];
            int[] answer = new int[height + width];

            //fill matrix for adding
            for (int row = 0; row < height; row++)
            {
                for (int col = width; col > 0; col--)
                {
                    matrix[row, col] = num1[height - 1 - row] * num2[col-1];
                }
            }

            //take care for the >10
            ReduceFieldsOver10(matrix);
                
            //summing  with offset = diagonal summing
            
            for (int startRow = matrix.GetLength(0)-1; startRow >= 0; startRow--)
            {
                int col = 0;
                int row = startRow;
                int tempSum = 0;
                while (row < matrix.GetLength(0) && col < matrix.GetLength(1)) //diagonal summing
                {
                    tempSum += matrix[row, col];
                    col++;
                    row++;
                }
                answer[matrix.GetLength(0)-1-startRow] = tempSum;
            }
            if (matrix.GetLength(1)>1)
            {
                for (int startCol = 1; startCol < matrix.GetLength(1); startCol++)
                {
                    int row = 0;
                    int col = startCol;
                    int tempSum = 0;
                    while (row < matrix.GetLength(0) && col < matrix.GetLength(1)) //diagonal summing
                    {
                        tempSum += matrix[row, col];
                        col++;
                        row++;
                    }
                    answer[matrix.GetLength(0) + startCol-1] = tempSum;
                }
            }
           

            //print
            //PrintMatrix(matrix);
            //PrintArray(answer);
            ReduceArrayOver10(answer);
            //PrintArray(answer);
            string answerStr = AttayToStringNum(answer);
            string reducedAnswer = answerStr.TrimStart('0'); //Trims the leading zeros
            return reducedAnswer;
        }


        /// <summary>
        /// Check all the positions of the array , startng at the last one, if there is a number >9
        ///if its finds such number, it leaves in the position only the ones (%10)
        ///and it carries and adds the number of the tenths(/10) to the next one (the one on the left).
        ///This method modifies the string itself.
        /// </summary>
        /// <param name="Array">The string to be modified</param>
        private static void ReduceArrayOver10(int[] Array)
        {
            for (int index = Array.Length-1; index >= 0; index--)
            {
                if (Array[index]>9)
                {
                    int decs = Array[index] / 10;
                    int ones = Array[index] % 10;
                    Array[index] = ones;
                    Array[index - 1] += decs;
                }
            }
        }

        /// <summary>
        /// Check all the positions of the matrix , startng at the last one, first row ,if there is a number >9.
        ///If its finds such number, it leaves in the position only the ones (%10)
        ///and it carries and adds the number of the tenths(/10) to the next one (the one on the left).
        ///This method modifies the array itself.
        /// </summary>
        /// <param name="matrix">The matrix to be modified</param>
        private static void ReduceFieldsOver10(int[,] matrix)
        {
            //int height = matrix.GetLength(0);
            //int width = matrix.GetLength(1)-1;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = matrix.GetLength(1)-1; col > 0; col--)
                {
                    if (matrix[row, col] > 9)
                    {
                        int decs = matrix[row, col] / 10;
                        int ones = matrix[row, col] % 10;
                        matrix[row, col] = ones;
                        matrix[row, col - 1] += decs;
                    }
                }
            }
        }
        //help method
        private static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + "  ");
                }
                Console.WriteLine();
            }
        }
        //help method
        private static void PrintArray(int[] answer)
        {
            foreach (var num in answer)
            {
                Console.Write(num + "  ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Converts number from string to int[], every position is single digit
        /// </summary>
        /// <param name="numStr">the number to be converted</param>
        /// <returns>the array of digits</returns>
        private static int[] StringNumToArray(string numStr)
        {
            int[] intArr = new int[numStr.Length];
            for (int index = 0; index < numStr.Length; index++)
            {
                intArr[index] = int.Parse(numStr[index].ToString());
            }
            return intArr;
        }

        /// <summary>
        /// Converts array of integer digits to a number as string
        /// </summary>
        /// <param name="intArray">the array of ingeger digits</param>
        /// <returns>the number as string</returns>
        private static string AttayToStringNum(int[] intArray)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var num in intArray)
            {
                sb.Append(num);
            }
            string answer = sb.ToString();
            return answer;
        }

        /// <summary>
        /// Calculates factorial of some number
        /// </summary>
        /// <param name="N">the number to calculate factorial</param>
        /// <returns>the factorial of the number</returns>
        static string Factoriel(int N)
        {
            string answer = "1";
            for (int i = 2; i <= N; i++)
            {
                string iStr = i.ToString();
                answer = MultiplyStringInIntArr(answer, iStr);
            }
            return answer;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Factorials of the number 1 to 100 with custom made multiplication");
            for (int num = 1; num <= 100; num++)
            {
                Console.Write("{0}! = ",num);
                Console.WriteLine(Factoriel(num));
            }
        }
    }
}
