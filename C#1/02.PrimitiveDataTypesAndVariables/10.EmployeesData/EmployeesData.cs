//A marketing firm wants to keep record of its employees. 
//Each record would have the following characteristics – 
//first name, family name, age, gender (m or f), ID number, 
//unique employee number (27560000 to 27569999). 
//Declare the variables needed to keep the information for a 
//single employee using appropriate data types and descriptive names.

using System;

class EmployeesData
{
    static void Main()
    {
        string firstName;
        string familyName;
        byte age;
        char gender;
        int iDNumber;

        firstName="Ivan";
        familyName="Ivanov";
        age=25;
        gender='m';
        iDNumber=27560001;
        
        Console.WriteLine("{0} {1} is {2} years old, gender - {3}, ID - {4}", firstName, familyName, age, gender, iDNumber);
    }
}
