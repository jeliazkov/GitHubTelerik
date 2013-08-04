//Write an if statement that examines two integer variables and exchanges 
//their values if the first one is greater than the second one.

using System;

namespace _01.Exchange2Int
{
    class Exchange2Int
    {
        static void Main()
        {
            Console.WriteLine("Write 2 numbers");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (a>b)
            {
                int c = a;
                a = b;
                b = c;
            }
            Console.WriteLine("The arranged numbers are {0} and {1}",a,b);
        }
    }
}
