//Create a program that assigns null values to an integer and 
//to double variables. Try to print them on the console, 
//try to add some values or the null literal to them and see the result.

using System;

class PrintNull
{
    static void Main()
    {
        int? a = null;
        double? b = null;
        Console.WriteLine("Null values a = {0} and b = {1}",a,b);
        a = a + 1;
        b = b + 2;
        Console.WriteLine("Added to null values a = {0} and b = {1}", a, b);
    }
}