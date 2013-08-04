//Write an expression that checks if given point (x,  y) is within a circle K(O, 5).

using System;

namespace _6.PoinInCircle
{
    class PointInCircle
    {
        static void Main()
        {
            float x;
            float y;
            float r;
            Console.WriteLine("Input x:");
            x = float.Parse(Console.ReadLine());
            Console.WriteLine("Input y:");
            y = float.Parse(Console.ReadLine());
            r = (float) Math.Sqrt(x * x + y * y);
            
            if (r < 5)
            {
                Console.WriteLine("The point is within the circle");
            }
            else if (r==5)
            {
                Console.WriteLine("The point is on the circumference");
            }
            else
            {
                Console.WriteLine("The point is out of the circle");
            }
        }
    }
}
