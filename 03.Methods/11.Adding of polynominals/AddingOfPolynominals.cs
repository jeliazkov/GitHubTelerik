//Write a method that adds two polynomials. 
//Represent them as arrays of their coefficients as in the example below:

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Adding_of_polynominals
{
    class AddingOfPolynominals
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
                tempN1[pos+(length-number1.Length)] = number1[pos];
            }
            int[] tempN2 = new int[length];       //Array with the longest length
            for (int pos = 0; pos < number2.Length; pos++)  //filling the array with the second number
            {
                tempN2[pos+(length-number2.Length)] = number2[pos];
            }
            int[] result = new int[length + 1];

            for (int pos = 0; pos < length; pos++)
            {
                result[pos + 1] = tempN1[pos] + tempN2[pos];
            }
            //PrintArray(result);
            return result;
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
            for (int index = Array.Length - 1; index >= 0; index--)
            {
                if (Array[index] > 9)
                {
                    int decs = Array[index] / 10;
                    int ones = Array[index] % 10;
                    Array[index] = ones;
                    Array[index - 1] += decs;
                }
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

        static void Main(string[] args)
        {

            int[] num1 = { 9,2,3 };
            int[] num2 = { 4, 3,2, 9,0,0 };

            int[] res = SumTwoPolynominals(num1, num2);

            if (res[0]==0)
            {
                for (int pos = 1; pos < res.Length; pos++)
                {
                    Console.Write("{0}X^{1}  +  ",res[pos],pos-1);
                }
            }
            else
            {
                for (int pos = 0; pos < res.Length; pos++)
                {
                    Console.Write("{0}X^{1}  +  ",res[pos],pos);
                }
            }
            
        }
    }
}
