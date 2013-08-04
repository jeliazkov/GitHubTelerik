//Write a method GetMax() with two parameters that returns the bigger of two integers. 
//Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.GetMax
{
    class GetMaxOf3
    {
        static float GetMax (float number1, float number2)
        {
            float max = number1;
            if (number2>number1)
            {
                max = number2;
            }
            return max;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter 3 numbers: ");
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());

            float max = GetMax(GetMax(a, b), c);
            Console.WriteLine("The max number is: {0}",max);
        }
    }
}
