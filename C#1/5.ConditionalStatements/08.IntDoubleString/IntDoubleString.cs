//Write a program that, depending on the user's choice inputs int, double or string variable.
//If the variable is integer or double, increases it with 1. If the variable is string, 
//appends "*" at its end. The program must show the value of that variable as a console output. 
//Use switch statement.

using System;

namespace _08.IntDoubleString
{
    class IntDoubleString
    {
        static void Main()
        {
            Console.WriteLine("What do you want to write \n1.Integer \n2.Double \n3.String \nWrite the number 1, 2 or 3.");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("You have chosen integer. Write one integer.");
                    int integer = int.Parse(Console.ReadLine());
                    Console.WriteLine("You have entered {0}, and the result is {1}",integer,integer+1);
                    break;
                case 2:
                    Console.WriteLine("You have chosen double. Write one double number");
                    double dbl = double.Parse(Console.ReadLine());
                    Console.WriteLine("You have entered {0}, and the result is {1}",dbl,dbl+1);
                    break;
                case 3:
                    Console.WriteLine("You have chosen string. Write one string");
                    string str = Console.ReadLine();
                    Console.WriteLine("You have entered {0}, and the result is {1}",str,str+"*");
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }
    }
}
