//Write a program to read your age from the console and print how old you will be after 10 years.

using System;
    class AgeAfter10Years
    {
        static void Main()
        {
            Console.WriteLine("What is your age?");
            int age = int.Parse (Console.ReadLine());
            Console.WriteLine("After 10 years you will be "+(age+10)+" years old");
        }
    }

