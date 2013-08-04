//A bank account has a holder name (first name, middle name and last name), 
//available amount of money (balance), bank name, IBAN, BIC code 
//and 3 credit card numbers associated with the account. 
//Declare the variables needed to keep the information 
//for a single bank account using the appropriate data types and descriptive names.

using System;

class BankAccVar
{
    static void Main()
    {
        string firstName;
        string middleName;
        string lastName;
        decimal balance;
        string bankName;
        string iBAN;
        string bicCode;
        long? card1=null;
        long? card2=null;
        long? card3=null;

        firstName = "Ivan";
        middleName = "Petrov";
        lastName = "Ivanov";
        balance = 20.69M;
        bankName = "DSK";
        iBAN = "GB82 WEST 1234 5698 7654 32";
        bicCode = "DEUT";
        card1 = 4485668246598973;
        card2 = 5596018078195923;
        Console.WriteLine("{0} {1} {2} has balance of {3} LV \nmember of {4}, with IBAN - {5}, BIC - {6}. \nPossessing credid cards with numbers - {7} , {8}, {9}", firstName, middleName, lastName, balance, bankName, iBAN, bicCode, card1, card2, card3);
    }
}