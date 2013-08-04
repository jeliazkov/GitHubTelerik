//Write methods to calculate minimum, maximum, average, sum 
//and product of given set of integer numbers. Use variable number of arguments.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.MinMaxAvgSumProductOfSetOfInt
{
    class MinMaxAvgOfArr
    {
        static int MinOfArray(params int[] array)
        {
            int min = array[0];
            for (int index = 1; index < array.Length; index++)
            {
                if (array[index]<min)
                {
                    min = array[index];
                }
            }
            return min;
        }

        static int MaxOfArray(params int[] array)
        {
            int max = array[0];
            for (int index = 1; index < array.Length; index++)
            {
                if (array[index]>max)
                {
                    max = array[index];
                }
            }
            return max;
        }

        static double AverageOfArray(params int[] array)
        {
            int sum = 0;
            for (int pos = 0; pos < array.Length; pos++)
            {
                sum += array[pos];
            }
            double average = (double)sum / (double)array.Length;
            return average;
        }

        static int SumOfArray(params int[] array)
        {
            int sum = 0;
            for (int index = 0; index < array.Length; index++)
            {
                sum += array[index];
            }
            return sum;
        }

        static int ProductOfArray(params int[] array)
        {
            int product = 1;
            for (int index = 0; index < array.Length; index++)
            {
                product *= array.Length;
            }
            return product;
        }

        static void Main(string[] args)
        {
            int[] inputArray = { 323, 4, 6, -124, 0, 34, 634, 2, -23 ,666 };

            Console.WriteLine("The array will be 2,3,4,6,0,23,4,-44 And its entered like params \n");

            Console.WriteLine("Min "+MinOfArray(2, 3, 4, 6, 0, 23, 4, -44));
            Console.WriteLine("Max " + MaxOfArray(2, 3, 4, 6, 0, 23, 4, -44));
            Console.WriteLine("Average " + AverageOfArray(2, 3, 4, 6, 0, 23, 4, -44));
            Console.WriteLine("Sum " + SumOfArray(2, 3, 4, 6, 0, 23, 4, -44));
            Console.WriteLine("Product " + ProductOfArray(2, 3, 4, 6, 0, 23, 4, -44));
        }
    }
}
