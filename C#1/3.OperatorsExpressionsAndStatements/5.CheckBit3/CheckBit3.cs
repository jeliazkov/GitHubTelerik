//Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.

using System;

namespace _5.CheckBit3
{
    class CheckBit3
    {
        static void Main()
        {
            int number;
            Console.WriteLine("Write number");
            number = int.Parse(Console.ReadLine());
            int mask = 1;
            int result;
            mask = mask << 3;
            result = (mask | number);
            bool check;
            check = number == result;
            Console.WriteLine("Bit N3 is = 1: {0}",check);
        }
    }
}
