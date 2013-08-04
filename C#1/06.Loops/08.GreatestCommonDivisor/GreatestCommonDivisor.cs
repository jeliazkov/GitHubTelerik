//Write a program that calculates the greatest common divisor (GCD) of given two numbers. 
//Use the Euclidean algorithm (find it in Internet).

using System;

class GreatestCommonDivisor
{
    static void Main()
    {
        //input
        Console.WriteLine("Enter the two numbers for calculating the greatest common divisor:");
        int max = int.Parse(Console.ReadLine());
        int min = int.Parse(Console.ReadLine());
        //arrange
        if (min > max)
        {
            int temp = max;
            max = min;
            min = temp;
        }
        //euclidean algorithm
        while (max % min != 0)
        {
            int remainder = max % min;
            max = min;
            min = remainder;
        }
        //print
        Console.WriteLine("The GCD is : " + min);
    }
}

