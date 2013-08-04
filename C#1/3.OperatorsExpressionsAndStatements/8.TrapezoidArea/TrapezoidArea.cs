//Write an expression that calculates trapezoid's area by given sides a and b and height h.

using System;

namespace _8.TrapezoidArea
{
    class TrapezoidArea
    {
        static void Main()
        {
            double a;
            double b;
            double h;
            double area;
            Console.WriteLine("Side A of the trapeziod");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Side B of the trapeziod");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Height of the trapeziod");
            h = double.Parse(Console.ReadLine());
            area = (a + b) * h / 2;
            Console.WriteLine("The area of the trapezoid is {0}",area);
        }
    }
}
