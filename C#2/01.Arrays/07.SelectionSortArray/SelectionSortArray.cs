//Sorting an array means to arrange its elements in increasing order. 
//Write a program to sort an array. Use the "selection sort" algorithm: 
//Find the smallest element, move it at the first position, 
//find the smallest from the rest, move it at the second position, etc.


using System;

class SelectionSortArray
{
    static void Main()
    {
        int[] myArray = { 5,4,3,5,2,1,7,-5,2 };
        int N = myArray.Length;

        Console.WriteLine("Unsorted array:");
        foreach (var value in myArray)
        {
            Console.Write(value+" ");
        }

        //scaning trough the array and marking the border of the sorted already array. 
        for (int sortedBorder = 0; sortedBorder < N-1; sortedBorder++)
        {
        //finding the minimal element from the rest of the array to compare it with the bored element
            int tempMin = myArray[sortedBorder];
            int tempPos = sortedBorder;
            //going from the border to the end of the array to find the min element
            for (int i = sortedBorder; i < N; i++)
            {
                //storing the current min value in tempmin
                if (myArray[i] < tempMin)
                {
                    tempMin = myArray[i];
                    tempPos = i;
                }
            }
            //switching the values of the min border value and the min value of the rest of the array
            int tempValue = myArray[sortedBorder];
            myArray[sortedBorder] = myArray[tempPos];
            myArray[tempPos] = tempValue;
        }

        //print
        Console.WriteLine();
        Console.WriteLine("Sorted array:");
        foreach (var value in myArray)
        {
            Console.Write(value+" ");
        }
        Console.WriteLine();
    }
}