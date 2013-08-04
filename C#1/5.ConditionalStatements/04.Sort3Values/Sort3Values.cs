//Sort 3 real values in descending order using nested if statements.

using System;

namespace _04.Sort3Values
{
    class Sort3Values
    {
        static void Main()
        {
            Console.WriteLine("Write 3 numbers");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            if (a > b)
            {
                if (b > c)
                {
                    Console.WriteLine("{0}>{1}>{2}", a, b, c);
                }
                else //c>b
                {
                    if (c > a)
                    {
                        Console.WriteLine("{0}>{1}>{2}", c, a, b);
                    }
                    else //a>c
                    {
                        Console.WriteLine("{0}>{1}>{2}", a, c, b);
                    }
                }
            }
            else // b > a
            {
                if (a > c)
                {
                    Console.WriteLine("{0}>{1}>{2}", b, a, c);
                }
                else // c>a
                {
                    if (c > b)
                    {
                        Console.WriteLine("{0}>{1}>{2}", c, b, a);
                    }
                    else //b>c
                    {
                        Console.WriteLine("{0}>{1}>{2}", b, c, a);
                    }
                }
            }
        }
    }
}
