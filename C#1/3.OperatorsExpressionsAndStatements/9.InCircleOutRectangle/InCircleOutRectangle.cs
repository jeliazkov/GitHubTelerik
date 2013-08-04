//Write an expression that checks for given point (x, y) if it is 
//within the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).

using System;

namespace _9.InCircleOutRectangle
{
    class InCircleOutRectangle
    {
        static void Main()
        {
            double x;
            double y;
            bool withinCircle;
            bool withinRectangle;
            Console.WriteLine("Coordinate X of the point");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Coordinate Y of the point");
            y = double.Parse(Console.ReadLine());
            withinCircle = ((x - 1) * (x - 1) + (y - 1) * (y - 1)) <= 9;
             //(x-center_x)^2 + (y - center_y)^2 < radius^2
            withinRectangle = (x >= -1 && x <= 5 && y >= -1 && y <= 1);
            if ((withinCircle && withinRectangle) == true)
            {
                Console.WriteLine("The point is within both figures");
            }
            else
            {
                Console.WriteLine("The point is not within both figures");
            }
        }
    }
}
