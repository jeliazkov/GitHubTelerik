//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

using System;

namespace _13.BitExchange
{
    class BitExchange
    {
        static void Main()
        {
            Console.WriteLine("Write number");
            uint number; 
            number = uint.Parse(Console.ReadLine());
            uint maskFirst = 56u;
            uint maskLast = 117440512u;
            Console.WriteLine("The binary represantation of the number is: \n" + Convert.ToString(number, 2).PadLeft(32, '0'));
            uint first3Bits = number & maskFirst;
            uint last3Bits = number & maskLast;

            first3Bits = first3Bits << 21;
            last3Bits = last3Bits >> 21;

            number = number & (~maskFirst);
            number = number & (~maskLast);

            number = number | first3Bits;
            number = number | last3Bits;
            Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
        }
    }
}
