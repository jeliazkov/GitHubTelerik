//In the combinatorial mathematics, the Catalan numbers are calculated by the following formula:
//Same as program N10

using System;
using System.Numerics;

class CatalanNumbers
{
    static BigInteger Factorial (int num)
    {
        BigInteger factorialRes=1;
        for (int i = 1; i <= num; i++)
        {
            factorialRes *= i;
        }
        return factorialRes;
    }
    static void Main()
    {
        Console.WriteLine("Which Catalan number:");
        int n = int.Parse(Console.ReadLine());

        BigInteger topFactorial = Factorial(2*n);
        BigInteger botFactorial = Factorial(n);
        BigInteger botFactorial2 = Factorial(n+1);
        BigInteger catalan = topFactorial / (botFactorial * botFactorial2);
        Console.WriteLine("The {0} Catalan number is {1}",n,catalan);
    }
}