//Write a program that reads from the console a sequence of N integer numbers and returns the minimal and maximal of them.

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter first number to start comparing, \nenter not a number for summary and exit");
        string input = Console.ReadLine();
        int inputToNum = int.Parse(input);
        int max = inputToNum;
        int min = inputToNum;       
        bool exit = false;
        while (exit == false)
        {
            Console.Write("Enter one number: ");
            input = Console.ReadLine();
            if (int.TryParse(input, out inputToNum))
            {
                if (inputToNum > max)
                {
                    max = inputToNum;
                }
                if (inputToNum < min)
                {
                    min = inputToNum;
                }
                Console.WriteLine("Max = {0} \nMin = {1}", max, min);
            }
            else
            {
                exit = true;
            }
        }
        Console.WriteLine("TOTAL max is: {0} \nTOTAL min is {1}", max, min);
    }
}