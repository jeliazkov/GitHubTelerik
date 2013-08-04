//Declare a boolean variable called isFemale 
//and assign an appropriate value 
//corresponding to your gender.

using System;

class BooleanIsFemale
{
    static void Main()
    {
        Boolean isFemale=false;
        Console.WriteLine("What is your gender: M or F?");
        string gender = Console.ReadLine();
        while (gender != "M" && gender != "F")
        {
            Console.WriteLine("Gender must be \"M\" or \"F\"");
            gender = Console.ReadLine();
        }
            if (gender == "M")
            {
                isFemale = false;
            }
            if (gender == "F")
            {
                isFemale = true;
                
            }
            Console.WriteLine("It is {0} that you are female",isFemale);
    }
}