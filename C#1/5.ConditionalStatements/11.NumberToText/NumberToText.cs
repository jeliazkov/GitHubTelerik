//* Write a program that converts a number in the range [0...999] 
//to a text corresponding to its English pronunciation. Examples:
//	0  "Zero"
//	273  "Two hundred seventy three"
//	400  "Four hundred"
//	501  "Five hundred and one"
//	711  "Seven hundred and eleven"

using System;

namespace _11.NumberToText
{
    class NumberToText
    {
        static void Main()
        {
            Console.WriteLine("Enter a number between 0 and 999");
            int input = int.Parse(Console.ReadLine());
            switch (input / 100)  //Hundreds
            {
                case 1:
                    Console.Write("One hundred");
                    break;
                case 2:
                    Console.Write("Two hundred");
                    break;
                case 3:
                    Console.Write("Three hundred");
                    break;
                case 4:
                    Console.Write("Four hundred");
                    break;
                case 5:
                    Console.Write("Five hundred");
                    break;
                case 6:
                    Console.Write("Six hundred");
                    break;
                case 7:
                    Console.Write("Seven hundred");
                    break;
                case 8:
                    Console.Write("Eight hundred");
                    break;
                case 9:
                    Console.Write("Nine hundred");
                    break;
                default:
                    break;
            }
            switch ((input % 100) / 10)  //Tenths
            {
                case 1:
                    if (input / 100 != 0)
                    {
                        Console.Write(" and ");
                    }
                    switch (input % 100)
                    {
                        case 10:
                            Console.Write("ten");
                            break;
                        case 11:
                            Console.Write("eleven");
                            break;
                        case 12:
                            Console.Write("twelve");
                            break;
                        case 13:
                            Console.Write("thirteen");
                            break;
                        case 14:
                            Console.Write("fourteen");
                            break;
                        case 15:
                            Console.Write("fifteen");
                            break;
                        case 16:
                            Console.Write("sixteen");
                            break;
                        case 17:
                            Console.Write("seventeen");
                            break;
                        case 18:
                            Console.Write("eighteen");
                            break;
                        case 19:
                            Console.Write("nineteen");
                            break;

                        default:
                            break;
                    }
                    break;
                case 2:
                    if (input / 100 != 0)
                    {
                        Console.Write(" and ");
                    }
                    Console.Write("twenty");
                    if (input % 10 != 0)
                    {
                        Console.Write("-");
                    }
                    break;
                case 3:
                    if (input / 100 != 0)
                    {
                        Console.Write(" and ");
                    }
                    Console.Write("thirty");
                    if (input % 10 != 0)
                    {
                        Console.Write("-");
                    }
                    break;
                case 4:
                    if (input / 100 != 0)
                    {
                        Console.Write(" and ");
                    }
                    Console.Write("forty");
                    if (input % 10 != 0)
                    {
                        Console.Write("-");
                    }
                    break;
                case 5:
                    if (input / 100 != 0)
                    {
                        Console.Write(" and ");
                    }
                    Console.Write("fifty");
                    if (input % 10 != 0)
                    {
                        Console.Write("-");
                    }
                    break;
                case 6:
                    if (input / 100 != 0)
                    {
                        Console.Write(" and ");
                    }
                    Console.Write("sixty");
                    if (input % 10 != 0)
                    {
                        Console.Write("-");
                    }
                    break;
                case 7:
                    if (input / 100 != 0)
                    {
                        Console.Write(" and ");
                    }
                    Console.Write("seventy");
                    if (input % 10 != 0)
                    {
                        Console.Write("-");
                    }
                    break;
                case 8:
                    if (input / 100 != 0)
                    {
                        Console.Write(" and ");
                    }
                    Console.Write("eighthty");
                    if (input % 10 != 0)
                    {
                        Console.Write("-");
                    }
                    break;
                case 9:
                    if (input / 100 != 0)
                    {
                        Console.Write(" and ");
                    }
                    Console.Write("ninety");
                    if (input % 10 != 0)
                    {
                        Console.Write("-");
                    }
                    break;
                case 0:
                    if ((input / 100 != 0) && (input % 10 != 0))
                    {
                        Console.Write(" and ");
                    }
                    break;
                default:
                    break;
            }

            switch (input % 10)  //Last digit
            {
                case 1:
                    if (((input % 100) / 10) != 1)
                    {
                        Console.Write("one");
                    }
                    break;
                case 2:
                    if (((input % 100) / 10) != 1)
                    {
                        Console.Write("two");
                    }
                    break;
                case 3:
                    if (((input % 100) / 10) != 1)
                    {
                        Console.Write("three");
                    }
                    break;
                case 4:
                    if (((input % 100) / 10) != 1)
                    {
                        Console.Write("four");
                    }
                    break;
                case 5:
                    if (((input % 100) / 10) != 1)
                    {
                        Console.Write("five");
                    }
                    break;
                case 6:
                    if (((input % 100) / 10) != 1)
                    {
                        Console.Write("six");
                    }
                    break;
                case 7:
                    if (((input % 100) / 10) != 1)
                    {
                        Console.Write("seven");
                    }
                    break;
                case 8:
                    if (((input % 100) / 10) != 1)
                    {
                        Console.Write("eight");
                    }
                    break;
                case 9:
                    if (((input % 100) / 10) != 1)
                    {
                        Console.Write("nine");
                    }
                    break;
                case 0:
                    if ((input / 100 == 0) && (input / 10 == 0))
                    {
                        Console.Write("Zero");
                    }
                    break;
                default:
                    break;
            }
            Console.WriteLine(".\n");
            Console.ReadLine();
        }
    }
}
