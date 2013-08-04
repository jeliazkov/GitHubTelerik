//Write a method that adds two positive integer numbers represented 
//as arrays of digits (each array element arr[i] contains a digit; 
//the last digit is kept in arr[0]). Each of the numbers 
//that will be added could have up to 10 000 digits

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.AddTwoIntInArr
{
    class AddIntInArray
    {
        static int[] SumTwoIntegers(int[] number1, int[] number2)
        {
            int length = number1.Length;
            if (number2.Length > number1.Length)
            {
                length = number2.Length;
            }
            int[] tempN1 = new int[length];
            for (int pos = 0; pos < number1.Length; pos++)
            {
                tempN1[pos] = number1[pos];
            }
            int[] tempN2 = new int[length];
            for (int pos = 0; pos < number2.Length; pos++)
            {
                tempN2[pos] = number2[pos];
            }
            int[] tempCarryOne = new int[length+1];
            int[] result = new int[length+1];

            for (int pos = 0; pos < length; pos++)
            {
                int tempSum = tempN1[pos] + tempN2[pos] + tempCarryOne[pos];
                if (tempSum<10)
                {
                    result[pos] = tempSum;
                }
                else
                {
                    result[pos] = tempSum - 10;
                    tempCarryOne[pos + 1] = 1;
                }
            }
            result[length] = tempCarryOne[length];  //this is to sum the cell after the last number (for the carry one)
            return result;
        }

        static void Main(string[] args)
        {
            int[] num1 = { 8, 5, 4, 9 };                    //    9458
            int[] num2 = { 6, 1, 7, 2, 9 };                 //  +92716
            int[] ret = SumTwoIntegers(num1, num2);         // =102174
            StringBuilder sb = new StringBuilder();
            for (int pos =ret.Length-1; pos >= 0; pos--)
            {
                sb.Append(ret[pos]);
            }
            Console.WriteLine(sb);
        }
    }
}
