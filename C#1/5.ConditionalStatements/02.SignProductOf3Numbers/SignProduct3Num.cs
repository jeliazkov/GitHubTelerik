//Write a program that shows the sign (+ or -) of the product of three real numbers without calculating it. 
//Use a sequence of if statements.

using System;

namespace _02.SignProductOf3Numbers
{
    class SignProduct3Num
    {
        static void Main()
        {
            Console.WriteLine("Write 3 numbers");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (a > 0 && b > 0 && c > 0)
            {
                Console.WriteLine("+");
            }
            else if (a > 0 && b > 0 && c < 0)
            {
                Console.WriteLine("-");
            }
            else if (a > 0 && b < 0 && c > 0)
            {
                Console.WriteLine("-");
            }
            else if (a < 0 && b > 0 && c > 0)
            {
                Console.WriteLine("-");
            }
            else if (a < 0 && b < 0 && c > 0)
            {
                Console.WriteLine("+");
            }
            else if (a > 0 && b > 0 && c < 0)
            {
                Console.WriteLine("+");
            }
            else if (a > 0 && b < 0 && c < 0)
            {
                Console.WriteLine("+");
            }
            else if (a < 0 && b < 0 && c < 0)
            {
                Console.WriteLine("-");
            }
            else if (a == 0 || b == 0 || c == 0)
            {
                Console.WriteLine("0");
            }
            int sign = Math.Sign(a * b * c);
            Console.WriteLine("Check with multiplication: {0}",sign);
        }
    }
}
