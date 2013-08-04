//Write a program that finds the maximal increasing sequence in an array. 
//Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.

using System;
using System.Collections.Generic;

class FindMaxIncreasingSequence
{   
    static void Main()
    {
        int[] myArray = { 3, 2, 3, 4, 9, 3, 4,5,6 };
        List<int> myList = new List<int>();
        int sequenceLength = 1;


        //searching for the first element element
        for (int i = 1; i < myArray.Length; i++)
        {
            if (myArray[i] > myArray[i - 1])
            {
                int currentSequenceLenght = 1;
                List<int> currentSequence = new List<int>();
                int j = i;
                currentSequence.Add(myArray[i - 1]);
                //searching for the end of sequence
                while (j < myArray.Length && myArray[j] > myArray[j-1])
                {
                    currentSequence.Add(myArray[j]);
                    currentSequenceLenght++;
                    j++;
                }
                //checking if the current sequence is longer than the max sequence
                if (currentSequenceLenght >= sequenceLength)  //if it is ">=" it is the last sequence  if it is ">" it is the first sequence
                {
                    sequenceLength = currentSequenceLenght;
                    myList.Clear();
                    for (int k = 0; k < currentSequence.Count; k++)
                    {
                        myList.Add(currentSequence[k]);
                    }
                }
                //moving at the end of the sequence
                i = j;
            }
        }

        //printing
        foreach (var element in myList)
	        {
		         Console.WriteLine(element+" ");
	        }
            
    }
}