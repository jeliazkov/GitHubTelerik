//Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).

using System;
using System.Numerics;

class NKFactorial2
{
    static BigInteger Factorial(int numTo)
    {
        BigInteger factorialRes = 1;
        for (int i = 1; i <= numTo; i++)
        {
            factorialRes *= i;
        }
        return factorialRes;
    }
    static void Main()
    {
        Console.WriteLine("To calculate  N!*K! / (K-N)! for given N and K (1<N<K).\nEnter N>1");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter K");
        int k = int.Parse(Console.ReadLine());
        if (k < n)
        {
            int temp = k;
            k = n;
            n = temp;
        }
        BigInteger result = Factorial(n) * Factorial(k) / Factorial(k - n);
        Console.WriteLine("N!*K! / (K-N)!= " + result);
    }
}

