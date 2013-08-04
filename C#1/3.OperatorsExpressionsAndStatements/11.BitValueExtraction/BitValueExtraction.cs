//Write an expression that extracts from a given integer i 
//the value of a given bit number b. Example: i=5; b=2  value=1.

using System;

namespace _11.BitValueExtraction
{
    class BitValueExtraction
    {
        static void Main()
        {
            int number;
            Console.WriteLine("Write number");
            number = int.Parse(Console.ReadLine());
            int p;
            Console.WriteLine("Bit position");
            p = int.Parse(Console.ReadLine());
            int mask = 1;
            int result;
            mask = mask << p;
            result = (mask | number);
            bool check;
            check = number == result;
            if (check)
            {
                Console.WriteLine("Bit at position {0} has value 1", p);
            }
            else
            {
                Console.WriteLine("Bit at position {0} has value 0", p);
            }
        }
    }
}
