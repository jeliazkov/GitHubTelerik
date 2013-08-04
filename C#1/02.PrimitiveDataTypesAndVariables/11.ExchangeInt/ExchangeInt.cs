//Declare  two integer variables and assign them with 5 and 10 
//and after that exchange their values.

using System;

class ExchangeInt
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        int c;
        Console.WriteLine(a+" "+b);
        c = a;
        a = b;
        b = c;
        Console.WriteLine(a+" "+b);
    }
}