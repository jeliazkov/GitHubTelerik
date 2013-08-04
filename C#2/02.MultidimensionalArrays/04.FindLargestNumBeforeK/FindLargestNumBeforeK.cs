//Write a program, that reads from the console an array 
//of N integers and an integer K, sorts the array 
//and using the method Array.BinSearch() finds the largest number in the array which is ≤ K

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.FindLargestNumBeforeK
{
    class FindLargestNumBeforeK
    {
        static void Main()
        {
            Console.WriteLine("Integers count?");
            int N = int.Parse(Console.ReadLine());
            List<int> myList = new List<int>();
            Console.WriteLine("Enter {0} integers",N);
            for (int i = 0; i < N; i++)
            {
                myList.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("Enter integers K to search for");
            int K = int.Parse(Console.ReadLine());
            myList.Sort();

            int position = myList.BinarySearch(K);

            if (position>=0)
            {
                Console.WriteLine("The element {0} exists in the array at position {1}, and first smaller is {2} at position {3}:", K, position, myList[position - 1],position-1);
                Console.WriteLine();
            }
            else if (position<-1) //the number doesnt exist in the list and exists smaller number
            {
                int newPos = ~position;
                Console.WriteLine("The element {0} would be at position {1} first smaller is: {2} at position {3}",K,newPos,myList[newPos-1],newPos-1);
            }
            else if (position==-1) //the number is not in the list and all the numbers are bigger
            {
                int newPos = ~position;
                Console.WriteLine("All the elements are bigger than {0}", K);
            }
            Console.WriteLine();
            Console.WriteLine("The sorted array is");
            foreach (var number in myList)
            {
                Console.Write(number+ " ");
            }
        }
    }
}
