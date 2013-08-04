//Write a method that reverses the digits of given decimal number. Example: 256  652

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.ReverseDigitsOfDecimal
{
    class Reverse
    {
        static double ReverseDigits(double inputNumber)
        {
            string inputStr = inputNumber.ToString();
            char[] outputStr=new char[inputStr.Length];
            for (int num = inputStr.Length - 1; num >= 0; num--)
            {
                outputStr[inputStr.Length - 1 - num] = inputStr[num];
            }
            string ret = new string(outputStr);
            return double.Parse(ret);
        }

        static string ReverseNumber(double number)
        {
            string numStr = number.ToString();
            char[] numCharArr = numStr.ToCharArray();
            Array.Reverse(numCharArr);
            string reversedNum = new string(numCharArr);
            return reversedNum;
        }


        static void Main(string[] args)
        {
            double number = 16.52;
            Console.WriteLine(ReverseDigits(number));
            Console.WriteLine(ReverseNumber(number));
        }
    }
}
