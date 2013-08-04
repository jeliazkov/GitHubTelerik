//Write a program that finds all prime numbers in the range [1...10 000 000]. 
//Use the sieve of Eratosthenes algorithm (find it in Wikipedia).

using System;
using System.Collections.Generic;

class FindPrimeNumbers
{
    static void Main()
    {
        int range = 10000000;
        int[] myArray = new int[range];
        //inicialise array of all numbers to 10 000 000
        for (int i = 0; i < range; i++)
        {
            myArray[i] = i;
        }
        List<int> primeList = new List<int>();

        //making the non prime numbers =0
        for (int divisor = 2; divisor < range; divisor++)
        {
            if (myArray[divisor]!=0)
            {
                for (int number = 2 * divisor; number < range; number += divisor)
                {
                    myArray[number] = 0;
                }
            }
            
        }

        //print non prime numbers
        foreach (var number in myArray)
        {
            if (number!=0)
            {
                //Console.Write(myArray[number]+" ");
                primeList.Add(myArray[number]);
            }
        }
        Console.WriteLine("From 0 to {0} exist {1} prime numbers stored in a list",range,primeList.Count);
    }
}