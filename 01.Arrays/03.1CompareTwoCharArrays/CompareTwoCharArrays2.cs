//Write a program that compares two char arrays lexicographically (letter by letter).

using System;

class CompareTwoCharArrays2
{
    static void Main()
    {
        string string1;
        string string2;

        Console.WriteLine("Enter first array of chars");
        string1 = Console.ReadLine();
        Console.WriteLine("Enter second array of chars");
        string2 = Console.ReadLine();

        //comparing the arrays
        bool equal = true;
        //comparing length
        if (string1.Length==string2.Length)
        {
            //comparing by elements
            for (int i = 0; i < string1.Length; i++)
            {
                if (string1[i] != string2[i])
                {
                    equal = false;
                    break;
                }
            }
        }
        else
        {
            equal = false;
        }
        
        if (equal)
        {
            Console.WriteLine("The arrays are equal");
        }
        else
        {
            Console.WriteLine("The arrays are different");
        }
    }
}