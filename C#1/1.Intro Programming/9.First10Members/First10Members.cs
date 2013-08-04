//Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...

using System;
class First10Members
{
    static void Main()
    {
        for (int i = 2; i <= 11; i++)
        {
            int j = i % 2;
                if (j == 1)
               {
                   Console.Write(-i+" ");
               }
                  else 
                  Console.Write(i+" ");
        }
    }
}