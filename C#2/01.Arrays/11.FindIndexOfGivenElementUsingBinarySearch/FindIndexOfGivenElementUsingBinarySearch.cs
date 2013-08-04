//Write a program that finds the index of given element in a 
//sorted array of integers by using the binary search algorithm (find it in Wikipedia).

using System;
using System.Collections.Generic;

class FindIndexOfGivenElementUsingBinarySearch
{
    static void Main()
    {
        //inicialising the array
        List<int> myArray = new List<int>();
        Console.WriteLine("Enter length of the array");
        int N = int.Parse(Console.ReadLine());
        for (int i = 0; i < N; i++)
        {
            Console.Write("Enter {0} member of the array:  ",i+1);
            myArray.Add(int.Parse(Console.ReadLine()));
        }
        myArray.Sort(); //sorting the array

        //print sorted array
        Console.WriteLine("The sorted array is:");
        foreach (var number in myArray)
        {
            Console.Write(number+" ");
        }
        Console.WriteLine();

        //Entering the number to look for
        Console.WriteLine("What number are you looking for:");
        int key = int.Parse(Console.ReadLine());
        
        //searching for the number
        int lowIndex=0;
        int highIndex=myArray.Count-1;
        int midIndex=(highIndex-lowIndex)/2+lowIndex;

        while (true)
        {
            if (key<myArray[midIndex])
            {
                highIndex = midIndex-1;
            }
            else if (key>myArray[midIndex])
            {
                lowIndex = midIndex+1;
            }
            else if (key==myArray[midIndex])
            {
                Console.WriteLine("The numner {0} is found in the array with index {1}",key,midIndex);
                break;                
            }
            if (lowIndex>highIndex)
            {
                Console.WriteLine("The numner {0} is NOT found in the array", key);
                break;
            }
            midIndex = (highIndex - lowIndex) / 2 + lowIndex;
        }

    }
}