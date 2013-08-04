//* Write a program that calculates for given N how many trailing zeros present at the end of the number N!. Examples:
//N = 10  N! = 3628800  2
//N = 20  N! = 2432902008176640000  4
//Does your program work for N = 50 000?
//Hint: The trailing zeros in N! are equal to the number of its prime divisors of value 5. Think why!

using System;

class TrailingZerosOfFactorial
{
    static void Main()
    {
        Console.WriteLine("Enter number");
        int number = int.Parse(Console.ReadLine());
        int counter = 0;
        for (int i = 1; i <= number; i++)
        {
            if (i % 5 == 0)
            {
                int res1 = 0;
                int num1 = i;
                while (res1 % 5 == 0)
                {
                    res1 = num1 / 5;
                    num1 = res1;
                    counter++;
                }
            }
        }
        Console.WriteLine("The number of trailing zeros counter present at the end of the number {0}!\nis {1}",number,counter);
    }
}

