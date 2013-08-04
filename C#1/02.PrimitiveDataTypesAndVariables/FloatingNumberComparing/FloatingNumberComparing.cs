//Write a program that safely compares floating-point 
//numbers with precision of 0.000001. Examples:
//(5.3 ; 6.01)  false;  (5.00000001 ; 5.00000003)  true


using System;

class FloatingNumberComparing
{
    static void Main()
    {
        Console.WriteLine("Enter number A");
        string inputA = Console.ReadLine();
        float numberA = float.Parse(inputA);
        Console.WriteLine("Enter number B");
        string inputB = Console.ReadLine();
        float numberB = float.Parse(inputB);
        float delta = numberA - numberB;
        if (Math.Abs(delta)<0.000001)
        {
            Console.WriteLine("The numbers are equal with 0.000001 precision.");
        }
        else
        {
            Console.WriteLine("The numbers are NOT equal with 0.000001 precision.");
        }
    }
}

