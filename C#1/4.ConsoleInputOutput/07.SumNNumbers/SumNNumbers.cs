//Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum. 

using System;

class SumNNumbers
{
    static void Main()
    {
        double sum=0;
        Console.WriteLine("How many numbers you want to sum?");
        int count = int.Parse(Console.ReadLine());
        
        for (int i = 1; i <= count; i++)
        {
            Console.WriteLine("Write number to sum");
            double number = double.Parse(Console.ReadLine());
            sum =sum + number;
        }
        Console.WriteLine("The sum of the {0} numbers is {1}",count,sum);
    }
}
