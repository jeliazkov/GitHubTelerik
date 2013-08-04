//Write a program that reads from the console a sequence of N integer numbers and returns the minimal and maximal of them.

using System;

class MinAndMax
{
    static void Main()
    {
        Console.WriteLine("How many integer numbers you want to compare");
        int n = int.Parse(Console.ReadLine());
        int[] nums = new int[n];
        Console.WriteLine("Enter number 1");
        nums[0] = int.Parse(Console.ReadLine());
        int max = nums[0];
        int min = nums[0];
        for (int i = 1; i < n; i++)
        {
            Console.WriteLine("Enter number "+(i+1));
            nums[i] = int.Parse(Console.ReadLine());
            if (nums[i]>max)
            {
                max = nums[i];
            }
            if (nums[i]<min)
            {
                min = nums[i];
            }
        }
        Console.WriteLine("The max number is: {0} \nThe min number is {1}",max,min);
    }
}

