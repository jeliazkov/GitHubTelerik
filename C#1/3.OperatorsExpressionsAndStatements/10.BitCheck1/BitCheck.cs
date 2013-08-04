//Write a boolean expression that returns if the bit at position p (counting from 0)
//in a given integer number v has value of 1. Example: v=5; p=1  false.

using System;

namespace _10.BitCheck1
{
    class BitCheck
    {
        static void Main()
        {
            int number;
            Console.WriteLine("Write number");
            number = int.Parse(Console.ReadLine());
            int p;
            Console.WriteLine("Position to be checked");
            p = int.Parse(Console.ReadLine());
            int mask = 1;
            int result;
            mask = mask << p;
            result = (mask | number);
            bool check;
            check = number == result;
            if (check)
            {
                Console.WriteLine("Bit at position {0} is 1 - true", p);
            }
            else
            {
                Console.WriteLine("Bit at position {0} is 1 - false", p);
            }
        }
    }
}
