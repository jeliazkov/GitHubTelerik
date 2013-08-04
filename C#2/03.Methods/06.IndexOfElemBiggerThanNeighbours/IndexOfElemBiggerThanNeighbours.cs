//Write a method that returns the index of the first element in array 
//that is bigger than its neighbors, or -1, if there’s no such element.
//Use the method from the previous exercise.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.IndexOfElemBiggerThanNeighbours
{
    class IndexOfElemBiggerThanNeighbours
    {
        static bool IsBiggerThanNeighbours(int[] array, int position)
        {
            bool biggerThanNeighbours = false;
            bool biggerThanNext = false;
            bool biggerThanPrev = false;
            if (position + 1 > array.Length - 1 || array[position] > array[position + 1])  //if no next neighbour exist the element is still bigger than it
            {
                biggerThanNext = true;
            }
            if (position - 1 < 0 || array[position] > array[position - 1]) //if there is no previous neighbour the element is bigger than it
            {
                biggerThanPrev = true;
            }
            if (biggerThanNext && biggerThanPrev)
            {
                biggerThanNeighbours = true;
            }
            return biggerThanNeighbours;
        }

        static void Main(string[] args)
        {
            int firstBigger = -1;
            int[] myArray = { 1, 3, 6, 5, 10, 9 };

            for (int member = 0; member < myArray.Length; member++) //if you put member=1 you will exclude de first one
            {
                if (IsBiggerThanNeighbours(myArray,member))
                {
                    firstBigger = member;
                    break;
                }
            }
                        
            Console.WriteLine("The  index of the first element bigger than neighbours is: {0} with value {1}",firstBigger,myArray[firstBigger]);
        }
    }
}
