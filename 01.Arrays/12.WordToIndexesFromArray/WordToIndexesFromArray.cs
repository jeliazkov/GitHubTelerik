//Write a program that creates an array containing all letters from the alphabet (A-Z). 
//Read a word from the console and print the index of each of its letters in the array.


using System;

    class WordToIndexesFromArray
    {
        static void Main()
        {
            char[] smallCharTable = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            Console.WriteLine("Enter one word");
            string inputWord = Console.ReadLine();
            string compareWord = inputWord.ToLower();

            //taking letter from the word
            for (int letter = 0; letter < compareWord.Length; letter++)
            {
                //comparing the letter with the character array with alphabet
                  for (int i = 0; i < smallCharTable.Length; i++)
                {
                    if (compareWord[letter]==smallCharTable[i])   //To small to escape the capital letters
                    {
                        Console.WriteLine("{0} - {1}",inputWord[letter],i+1);  //the index is i+1 in order to get the real place in the alphabet
                    }
                }   
            }
        }
    }
