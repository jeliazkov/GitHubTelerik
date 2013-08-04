using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.MaxMinSumOfAnyType
{
    class MinMaxGeneric
    {

        static T MinOfArray<T>(params T[] array) where T : IComparable<T>
        {
            T min = array[0];
            for (int index = 1; index < array.Length; index++)
            {
                if (array[index].CompareTo(min) < 0)                   //array[index] < min  
                {                           //Comparer<T>.Default.Compare(array[index],min)<0
                    min = array[index];
                }
            }
            return min;
        }

        static T MaxOfArray<T>(params T[] array) where T : IComparable<T>
        {
            T max = array[0];
            for (int index = 1; index < array.Length; index++)
            {
                if (array[index].CompareTo(max) > 0)
                {
                    max = array[index];
                }
            }
            return max;
        }

        //static T AverageOfArray<T>(params T[] array)
        //{
        //    T sum = default(T);   //=0
        //    for (int pos = 0; pos < array.Length; pos++)
        //    {
        //        sum = Add(sum, array[pos]);
        //    }
        //    double lenght = array.Length;
        //    T average = Divide((double)sum, lenght);  //(double)sum / (double)array.Length;
        //    return average;
        //}

        static T Add<T>(T x, T y)
        {
            dynamic dx = x, dy = y;
            return dx + dy;
        }

        static T Multiply<T>(T x, T y)
        {
            dynamic dx = x, dy = y;
            return dx * dy;
        }

        //static T Divide<T>(T x, T y)
        //{
        //    dynamic dx = x, dy = y;
        //    return dx / dy;
        //}

        static T SumOfArray<T>(params T[] array)
        {
            T sum = default(T);
            for (int index = 0; index < array.Length; index++)
            {
                sum = Add(sum, array[index]);
            }
            return sum;
        }

        static T ProductOfArray<T>(params T[] array)
        {
            T product = array[0];
            for (int index = 1; index < array.Length; index++)
            {
                product = Multiply(product, array[index]);
            }
            return product;
        }


        static void Main()
        {
            double[] inputArray = { 2.6, 3, 4, 6.3, 11, 23, 2, -44 };

            Console.WriteLine("The array will be 2,3,4,6,10,23,2,-44 And its entered like params \n");

            Console.WriteLine("Min " + MinOfArray(inputArray));
            Console.WriteLine("Max " + MaxOfArray(inputArray));
            //Console.WriteLine("Average " + AverageOfArray(2, 3, 4, 6, 10, 23, 2, -44));
            Console.WriteLine("Sum " + SumOfArray(inputArray));
            Console.WriteLine("Product " + ProductOfArray(inputArray));
        }

    }
}
