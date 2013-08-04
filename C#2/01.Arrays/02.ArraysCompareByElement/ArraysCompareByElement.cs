//Write a program that reads two arrays from the console and compares them element by element

using System;

class ArraysCompareByElement
{
    static void Main()
    {
        Console.WriteLine("Enter lenght of the arrays:");
        int N = int.Parse(Console.ReadLine());
        int[] array1 = new int[N];
        int[] array2 = new int[N];

        //filling the arrays
        for (int i = 0; i < N; i++)
        {
            Console.WriteLine("Enter value for {0} element or the first array",i);
            array1[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < N; i++)
        {
            Console.WriteLine("Enter value for {0} element or the second array", i);
            array2[i] = int.Parse(Console.ReadLine());
        }

        //comparing the arrays
        bool equal = true;
        for (int i = 0; i < N; i++)
        {
            if (array1[i] != array2[i])
            {
                equal = false;
                break;
            }
        }

        //print result
        if (equal==true)
        {
             Console.WriteLine("The arrays are equal");
        }
        else
        {
            Console.WriteLine("The arrays are different");
        }
    }
}
