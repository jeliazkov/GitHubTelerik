//Write a program that reads a number N and calculates the sum of the first N members of 
//the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
//Each member of the Fibonacci sequence (except the first two) is a sum of the previous two members.

using System;
using System.Numerics;

class SumFibonacciNums
{
    static void Main()
    {
        Console.WriteLine("How many members you want to sum");
        int count = int.Parse(Console.ReadLine());
        Console.WriteLine("The members first {0} members of the fibonacci sequence:", count);
        BigInteger a = 0;
        BigInteger b = 1;
        BigInteger c = 0;
        BigInteger sum = a + b;
        Console.WriteLine(a);
        Console.WriteLine(b);
        for (int i = 0; i < count - 2; i++)
        {
            c = a + b;
            sum = sum + c;
            Console.WriteLine(c);
            a = b;
            b = c;
        }
        Console.WriteLine("The sum of the first {0} members is {1}", count, sum);
    }
}

