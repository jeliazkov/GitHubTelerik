//Find online more information about ASCII (American Standard Code 
//for Information Interchange) and write a program that prints the 
//entire ASCII table of characters on the console.

using System;

class PrintASCII
{
    static void Main()
    {
        char character = '\u0000';
        string hexValue;
        int decValue;
        Console.WriteLine("ASCII table");
        Console.WriteLine("DEC HEX SYMBOL");
        for (int i = 0; i < 128; i++)
        {
            decValue = (int)character;
            Console.Write(decValue+"    ");
            hexValue = decValue.ToString("X");           
            Console.Write(hexValue+"    ");
            Console.WriteLine(character);
            character++;
        }
    }
}
