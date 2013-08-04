//Write an expression that calculates rectangle’s area by given width and height.

using System;

namespace _3.RectangleArea
{
    class RectangleArea
    {
        static void Main()
        {
            float width;
            float height;
            float area;
            Console.WriteLine("Width of rectangle");
            width = float.Parse(Console.ReadLine());
            Console.WriteLine("Height or rectangle");
            height = float.Parse(Console.ReadLine());
            area = width * height;
            Console.WriteLine("The area or the given rectagnle is {0}",area);
        }
    }
}
