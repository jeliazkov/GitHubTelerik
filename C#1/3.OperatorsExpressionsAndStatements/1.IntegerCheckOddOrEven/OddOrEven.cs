//Write an expression that checks if given integer is odd or even.

using System;

namespace _1.IntegerCheckOddOrEven
{
    class OddOrEven
    {
        static void Main()
        {
            int number;
            Console.WriteLine("Writhe number");
            number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }
    }
}
