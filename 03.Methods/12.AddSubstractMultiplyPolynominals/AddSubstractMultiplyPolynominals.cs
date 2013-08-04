//Write a method that adds two polynomials. 
//Represent them as arrays of their coefficients as in the example below:
//Extend the program to support also subtraction and multiplication of polynomials.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.AddSubstractMultiplyPolynominals
{
    class AddSubstractMultiplyPolynominals
    {
        static int[] SumTwoPolynominals(int[] number1, int[] number2)
        {
            int length = number1.Length;
            if (number2.Length > number1.Length)  //finding the longer number
            {
                length = number2.Length;
            }
            int[] tempN1 = new int[length];       //Array with the longest length
            for (int pos = 0; pos < number1.Length; pos++)  //filling the array with the first number
            {
                tempN1[pos + (length - number1.Length)] = number1[pos];
            }
            int[] tempN2 = new int[length];       //Array with the longest length
            for (int pos = 0; pos < number2.Length; pos++)  //filling the array with the second number
            {
                tempN2[pos + (length - number2.Length)] = number2[pos];
            }

            int[] result = new int[length + 1];

            for (int pos = 0; pos < length; pos++)
            {
                result[pos] = tempN1[pos] + tempN2[pos];
            }
            return result;
        }

        static int[] SubstractTwoPolynominals(int[] number1, int[] number2)
        {
            int length = number1.Length;
            if (number2.Length > number1.Length)  //finding the longer number
            {
                length = number2.Length;
            }
            int[] tempN1 = new int[length];       //Array with the longest length
            for (int pos = 0; pos < number1.Length; pos++)  //filling the array with the first number
            {
                tempN1[pos + (length - number1.Length)] = number1[pos];
            }
            int[] tempN2 = new int[length];       //Array with the longest length
            for (int pos = 0; pos < number2.Length; pos++)  //filling the array with the second number
            {
                tempN2[pos + (length - number2.Length)] = number2[pos];
            }
            int[] result = new int[length];
            for (int pos = 0; pos < length; pos++)
            {
                result[pos] = tempN1[pos] - tempN2[pos];
            }
            return result;
        }

        static int[] MultiplyTwoPolynominals(int[] number1, int[] number2)
        {
            int[] result = new int[number1.Length + number2.Length - 1];
            for (int startNum = 0; startNum < number1.Length; startNum++)
            {
                int[] tempMultiplied = new int[number2.Length];
                for (int pos2 = 0; pos2 < number2.Length; pos2++)
                {
                    tempMultiplied[pos2] = number1[startNum] * number2[pos2];

                }
                tempMultiplied = IncreasePower(tempMultiplied, startNum);  //multiplying the whole brackets with X^startnum
                //add the temp number to the answer
                for (int i = 0; i < tempMultiplied.Length; i++)
                {
                    result[i] += tempMultiplied[i];
                }
            }
            return result;
        }

        static int[] IncreasePower(int[] array, int power)
        {
            int[] newArray = new int[array.Length + power];
            for (int pos = 0; pos < array.Length; pos++)
            {
                newArray[pos + power] = array[pos];
            }
            return newArray;
        }


        static void Main(string[] args)
        {
            int[] num1 = { 1, 2, 3, 4 };
            int[] num2 = { 3, 4, 5 };

            int[] sum = SumTwoPolynominals(num1,num2);
            int[] substract = SubstractTwoPolynominals(num1, num2);
            int[] multiply = MultiplyTwoPolynominals(num1, num2);
            PrintPolynominal(sum);
            PrintPolynominal(substract);
            PrintPolynominal(multiply);

        }

        private static void PrintPolynominal(int[] res)
        {
            Console.Write("{0} ", res[0]);
            if (1 < res.Length - 1 && res[1] > 0)
            {
                Console.Write("+ ");
            }
            for (int pos = 1; pos < res.Length; pos++)
            {
                if (res[pos] != 0)
                {
                    Console.Write("{0}X^{1}", res[pos], pos);
                }
                if (pos < res.Length - 1 && res[pos]>0)
                {
                    Console.Write(" + ");
                }
                else if (pos<res.Length-1 && res[pos]<0)
                {
                    Console.Write("   ");
                }
            }
            Console.WriteLine();
        }
    }
}
