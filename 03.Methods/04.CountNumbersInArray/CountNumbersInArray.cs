//Write a method that counts how many times given number appears in given array. 
//Write a test program to check if the method is working correctly.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CountNumbersInArray
{
    class CountNumbersInArray
    {
        static float[] EnterArray()
        {
            Console.WriteLine("Enter length of the array");
            int numbersCount = int.Parse(Console.ReadLine());
            float[] Array = new float[numbersCount];
            Console.WriteLine("Enter some numbers");
            for (int i = 0; i < numbersCount; i++)
            {
                string input = Console.ReadLine();
                Array[i] = float.Parse(input);
            }
            return    Array;
        }

        static int CountRepeatetNumber(float[] arr1, float repeatedNumber)
        {
            int count = 0;
            foreach (float number in arr1)
            {
                if (number==repeatedNumber)
                {
                    count++;
                }
            }
            return count;
        }


        static void Main(string[] args)
        {
            float[] arr1 = EnterArray();
            Console.WriteLine("Enter the number to look for: ");
            float number = float.Parse(Console.ReadLine());
            int count = CountRepeatetNumber(arr1, number);
            Console.WriteLine("The number {0} is found {1} times in the array",number,count);
        }
    }
}
