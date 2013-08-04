//Write a program that prints an isosceles triangle of 
//9 copyright symbols ©. Use Windows Character 
//Map to find the Unicode code of the © symbol. 
//Note: the © symbol may be displayed incorrectly.

using System;

class CopyrightTriangle
{
    static void Main()
    {
        char c = '\u00A9';         
        Console.WriteLine("   "+c);
        Console.WriteLine("  "+c+" "+c);
        Console.WriteLine(" "+c+"   "+c);
        Console.WriteLine(c+" "+c+" "+c+" "+c);
    }
}

