//Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732  true.

using System;

namespace _4.ThirdDigitIs7
{
    class ThirdDigidIs7
    {
        static void Main()
        {
            int number;
            Console.WriteLine("Write number");
            number = int.Parse(Console.ReadLine());
            int numDiv = number / 100;
            int check = numDiv % 10;
            if (check == 7 || check == -7)
            {
                Console.WriteLine("The third digit is 7");
            }
            else
            {
                Console.WriteLine("The third digit is {0}", check);
            }

        }
    }
}
