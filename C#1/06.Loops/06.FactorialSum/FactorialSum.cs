//Write a program that, for a given two integer numbers N and X, calculates the sumS = 1 + 1!/X + 2!/X2 + … + N!/XN

using System;

class FactorialSum
{
    static void Main()
    {
        Console.WriteLine("Enter N");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter X");
        int x = int.Parse(Console.ReadLine());
        double sum = 1;
        for (int i = 1; i <= n; i++)
        {
            double factorial=1;
            for (int j = 1; j <= i; j++)
			{
			 factorial *= j;
			}
            double deg= x;
            for (int j = 1; j < i; j++)
			{
			 deg *= x;
			}
            Console.WriteLine("{0}/{1}",factorial,deg);
            sum += (factorial / deg);
        }
        Console.WriteLine("The sum is: {0}", sum);
    }
}

