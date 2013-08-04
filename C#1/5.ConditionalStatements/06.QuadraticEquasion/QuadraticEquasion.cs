//Write a program that enters the coefficients a, b and c of a quadratic equation
//		a*x2 + b*x + c = 0
//		and calculates and prints its real roots. Note that quadratic equations may have 0, 1 or 2 real roots.

using System;

namespace _06.QuadraticEquasion
{
    class QuadraticEquasion
    {
        static void Main()
        {
            Console.WriteLine("Enter the coefficients a, b and c of a quadratic equation ax2+bx+c=0");
            Console.WriteLine("a=?");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("b=?");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("c=?");
            double c = double.Parse(Console.ReadLine());

            double d = Math.Sqrt(b * b - 4 * a * c);
            if (double.IsNaN(d))
            {
                Console.WriteLine("There are no real roots");
            }
            else if (d==0)
            {
                Console.WriteLine("The only root is {0}", (-b) / (2 * a));
            }
            else 
            {
                Console.WriteLine("The first root is {0}", (-b - d) / (2 * a));
                Console.WriteLine("The second root is {0}", (-b + d) / (2 * a));
            }
        }
    }
}
