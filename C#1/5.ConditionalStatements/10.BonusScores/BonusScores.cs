//Write a program that applies bonus scores to given scores in the range [1..9]. 
//The program reads a digit as an input. If the digit is between 1 and 3, 
//the program multiplies it by 10; if it is between 4 and 6, multiplies it by 100; 
//if it is between 7 and 9, multiplies it by 1000. If it is zero 
//or if the value is not a digit, the program must report an error.
//		Use a switch statement and at the end print the calculated new value in the console.

using System;

namespace _10.BonusScores
{
    class BonusScores
    {
        static void Main()
        {
            Console.WriteLine("Enter a digit");
            string input = Console.ReadLine();
            int convertedInput;
            if (int.TryParse(input, out convertedInput))
            {
                switch (convertedInput)
                {
                    case 1:
                    case 2:
                    case 3:
                        Console.WriteLine("The bonus is {0}", convertedInput * 10);
                        break;
                    case 4:
                    case 5:
                    case 6:
                        Console.WriteLine("The bonus is {0}", convertedInput * 100);
                        break;
                    case 8:
                    case 9:
                    case 10:
                        Console.WriteLine("The bonus is {0}", convertedInput * 1000);
                        break;
                    case 0:
                        Console.WriteLine("Error: You have entered zero number");
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("Not a number");
            }
        }
    }
}
