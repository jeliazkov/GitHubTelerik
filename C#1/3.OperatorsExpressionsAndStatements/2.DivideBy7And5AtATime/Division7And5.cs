//Write a boolean expression that checks for given integer 
//if it can be divided (without remainder) by 7 and 5 in the same time.

using System;

namespace _2.DivideBy7And5AtATime
{
    class Division7And5
    {
        static void Main()
        {
            int number;
            Console.WriteLine("Write number");
            number = int.Parse(Console.ReadLine());
            bool div7 = (number % 7) == 0;
            bool div5 = (number % 5) == 0;
            if (div5 && div7 == true)
            {
                Console.WriteLine("{0} is divided by 7 and 5 at the same time", number);
            }
            else
            {
                Console.WriteLine("{0} is not divided by 7 and 5 at the same time", number);
            }
        }
    }
}
