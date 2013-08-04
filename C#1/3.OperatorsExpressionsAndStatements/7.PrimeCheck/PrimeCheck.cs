//Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.

using System;

namespace _7.PrimeCheck
{
    class PrimeCheck
    {
        static void Main()
        {
            int number;
            int check=0;
            Console.WriteLine("Write number");
            number = int.Parse(Console.ReadLine());
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    check++;
                }
            }
            if (check == 0)
            {
                Console.WriteLine("The number is prime");
            }
            else
            {
                Console.WriteLine("The number is not prime");
            }
        }
    }
}
