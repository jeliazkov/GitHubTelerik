//Write a program that finds the maximal sequence of equal elements in an array.
//		Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.

using System;

class FindMaxSequenceOfEqualElems
{
    static void Main()
    {
        //use this code to ender array manualy
        //Console.WriteLine("Enter lenght of the array:");
        //int N = int.Parse(Console.ReadLine());
        //int[] array = new int[N];

        ////filling the arrays
        //for (int i = 0; i < N; i++)
        //{
        //    Console.WriteLine("Enter value for {0} element or the array", i);
        //    array[i] = int.Parse(Console.ReadLine());
        //}


        int[] array = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };

        int sequenceLength = 1;
        int repeatedElement = 0;

        //searching for the first repeated element
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i]==array[i-1])
            {
                int currentSequenceLenght = 1;
                int currentRepeateedElement = array[i-1];
                int j = i;
                //searching for the end of sequence
                while (j<array.Length && array[j]==currentRepeateedElement)
                {
                    currentSequenceLenght++;
                    j++;
                }
                //checking if the current sequence is longer than the max sequence
                if (currentSequenceLenght>sequenceLength)
                {
                    sequenceLength = currentSequenceLenght;
                    repeatedElement = currentRepeateedElement;
                }
                //moving at the end of the sequence
                i = j;
            }
        }

        //printing repeated element
        if (sequenceLength>1)
        {
            Console.Write("The repeated elements are : {");
            for (int i = 0; i < sequenceLength-1; i++)
            {
                Console.Write(repeatedElement+", ");
            }
            Console.Write(repeatedElement);
            Console.WriteLine("}");
        }
        else
        {
            Console.WriteLine("There is no sequence of equal elements");
        }
        
    }
}