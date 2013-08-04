//Write a program that prints all possible cards from a standard deck of 52 cards (without jokers). 
//The cards should be printed with their English names. Use nested for loops and switch-case.

using System;

class PrintAllCardsOfDeck
{
    static void Main()
    {
        string[] cards = new string[] {"2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace"};
        //string[] colour = new string[] { "diamond", "heart", "club", "spade" };
        Console.WriteLine("Press enter to print all possible cards");
        Console.ReadLine();
        for (int i = 0; i < 13; i++)
        {
            for (int j = 0; j <= 3; j++)
            {
                switch (j)
                {
                    case 0:
                        Console.WriteLine("{0} of diamonds", cards[i]);
                        break;
                    case 1:
                        Console.WriteLine("{0} of hearts", cards[i]);
                        break;
                    case 2: 
                        Console.WriteLine("{0} of clubs", cards[i]);
                        break;
                    case 3: 
                        Console.WriteLine("{0} of spades", cards[i]);
                        break;
                    default:
                        break;
                }
                //Console.WriteLine("{0} {1}",cards[i], colour[j]);
            }
            
        }
    }
}

