//Write a program that reads the radius r of a circle and prints its perimeter and area.

using System;

namespace _02.ReadRadiusCircle
{
    class ReadRadiusCircle
    {
        static void Main()
        {
            Console.WriteLine("Input radius of circle");
            double radius = double.Parse(Console.ReadLine());
            double perimeter = 2*Math.PI*radius;
            double area = Math.PI*radius*radius;
            Console.WriteLine("Circle with radius {0} has perimeter {1} and area {2}",radius,perimeter,area);
        }
    }
}
