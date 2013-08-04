//Write a program that calculates N!/K! for given N and K (1<K<N).

using System;
using System.Numerics;

class NKFactorial
{
    static void Main()
    {
        Console.WriteLine("To calculate N!/K! \nEnter N>1");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter K<N");
        int k = int.Parse(Console.ReadLine());
        BigInteger factorial = 1;
        Console.Write("N!/K!=");
            for (int i = n; i > (k); i--)
            {
                Console.Write(i);
                if (i > k + 1)
                {
                    Console.Write("*");
                }
                    factorial *= i;
            }
        Console.WriteLine("=" + factorial);
    }
}

