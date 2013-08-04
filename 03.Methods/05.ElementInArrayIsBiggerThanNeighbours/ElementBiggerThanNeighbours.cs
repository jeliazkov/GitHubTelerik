//Write a method that checks if the element at given position 
//in given array of integers is bigger than its two neighbors (when such exist).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ElementInArrayIsBiggerThanNeighbours
{
    class ElementBiggerThanNeighbours
    {
        static bool IsBiggerThanNeighbours(int[] array, int position)
        {
            bool biggerThanNeighbours = false;
            bool biggerThanNext = false;
            bool biggerThanPrev = false;
            if (position+1>array.Length-1 || array[position] > array[position + 1])  //if no next neighbour exist the element is still bigger than it
            {
                biggerThanNext = true;
            }
            if (position-1<0 || array[position]>array[position-1]) //if there is no previous neighbour the element is bigger than it
            {
                biggerThanPrev = true;
            }
            if (biggerThanNext&&biggerThanPrev)
            {
                biggerThanNeighbours = true;
            }
            return biggerThanNeighbours;
        }

        static void Main(string[] args)
        {
            int[] myArray ={4,3,6,5,8,9};
            bool result = IsBiggerThanNeighbours(myArray, 2);
            Console.WriteLine(result);
        }
    }
}
