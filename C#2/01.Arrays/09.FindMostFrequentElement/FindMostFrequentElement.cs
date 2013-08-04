//Write a program that finds the most frequent number in an array. Example:
//    {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)

using System;

    class FindMostFrequentElement
    {
        static void Main()
        {
            int[] myArray = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };

            int mostFrequentElement=myArray[0];
            int maxElementCount=1;
            //taking one element and counting how many times its in the array
            for (int elemCheck = 0; elemCheck < myArray.Length; elemCheck++)
            {
                int tempCount=1;
                int tempElem=0;
                //counting the repetions
                for (int currentElem = elemCheck+1; currentElem < myArray.Length; currentElem++)
                {
                    if (myArray[currentElem]==myArray[elemCheck])
                    {
                        tempCount++;
                        tempElem=myArray[elemCheck];
                    }
                }
                //comparing with the current most frequent element
                if (tempCount>maxElementCount)
                {
                    maxElementCount = tempCount;
                    mostFrequentElement = tempElem;
                }
            }

            //print
            if (mostFrequentElement==myArray[0] && maxElementCount==1)
            {
                Console.WriteLine("All the elements are different");
            }
            else
            {
                Console.WriteLine("Most frequent element is {0} - ({1} times)",mostFrequentElement,maxElementCount);
            }
        }
    }