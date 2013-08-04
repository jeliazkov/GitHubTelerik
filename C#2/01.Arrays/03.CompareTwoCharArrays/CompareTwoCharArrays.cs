//Write a program that compares two char arrays lexicographically (letter by letter).

using System;

class CompareTwoCharArrays
{
    static void Main()
    {
        Console.WriteLine("Enter lenght of the arrays:");
        int N = int.Parse(Console.ReadLine());
        char[] charArr1 = new char[N];
        char[] charArr2 = new char[N];

        //filling the arrays
        for (int i = 0; i < N; i++)
        {
            Console.WriteLine("Enter value for {0} element or the first array", i);
            charArr1[i] =char.Parse(Console.ReadLine());
        }
        for (int i = 0; i < N; i++)
        {
            Console.WriteLine("Enter value for {0} element or the second array", i);
            charArr2[i] = char.Parse(Console.ReadLine());
        }

        //comparing the arrays
        bool equal = true;
        for (int i = 0; i < N; i++)
        {
            if (charArr1[i] != charArr2[i])
            {
                Console.WriteLine("The arrays are different");
                equal = false;
                break;
            }
        }
        if (equal)
        {
            Console.WriteLine("The arrays are equal");
        }
    }
}
