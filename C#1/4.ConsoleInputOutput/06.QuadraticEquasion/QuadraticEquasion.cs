//Write a program that reads the coefficients a, b and c of a 
//quadratic equation ax2+bx+c=0 and solves it (prints its real roots).

using System;

namespace _06.QuadraticEquasion
{
    class QuadraticEquasion
    {
        static void Main()
        {
            Console.WriteLine("Input the coefficients a, b and c of a quadratic equation ax2+bx+c=0");
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
            else
            {
                Console.WriteLine("The first root is {0}", (-b - d) / (2 * a));
                Console.WriteLine("The second root is {0}", (-b + d) / (2 * a));
            }
        }
    }
}
