//We are given integer number n, value v (v=0 or 1) and a position p. 
//Write a sequence of operators that modifies n to hold the value v at the position p from the binary representation of n.
//	Example: n = 5 (00000101), p=3, v=1  13 (00001101)
//	n = 5 (00000101), p=2, v=0  1 (00000001)

using System;

namespace _12.BitPositionChange
{
    class BitPositionChange
    {
        static void Main()
        {
            int number;
            Console.WriteLine("Write number");
            number = int.Parse(Console.ReadLine());
            int p;
            Console.WriteLine("Bit position");
            p = int.Parse(Console.ReadLine());
            int v;
            Console.WriteLine("Value of the bit");
            v = int.Parse(Console.ReadLine());
            if (v==1)
            {
                int mask = 1;
                mask = mask << p;
                int result;
                result = number | mask;
                Console.WriteLine("The new value is {0}",result);
            }
            if (v == 0)
            {
                int mask = ~(1<<p);
                int result = number & mask;
                Console.WriteLine("The new value is {0}",result);
            }
        }
    }
}
