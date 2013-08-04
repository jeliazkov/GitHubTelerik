//You are given an array of strings. 
//Write a method that sorts the array by the length of its elements 
//(the number of characters composing them).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SortStringsByLength
{
    class SortStringsByLength
    {
        public static void SwitchPos(string[] arrStr, int[] arrLght, int oldPos, int newPos)
        {
            string tempStr;
            int tempLenght;

            tempStr = arrStr[oldPos];
            tempLenght = arrLght[oldPos];
            arrStr[oldPos] = arrStr[newPos];
            arrLght[oldPos] = arrLght[newPos];
            arrStr[newPos] = tempStr;
            arrLght[newPos] = tempLenght;
        }

        public static void PrintArray(Array arr)
        {
            foreach (var item in arr)
            {
                Console.Write("{0,2}  ",item);
            }
            Console.WriteLine();
        }

         private static void SortStringArr(string[] arrStr, int[] strLength)
        {
            for (int startPos = 0; startPos < arrStr.Length - 1; startPos++)
            {
                int minLength = strLength[startPos];
                int minPos = startPos;
                for (int check = startPos + 1; check < arrStr.Length; check++)
                {
                    if (strLength[check] < minLength)
                    {
                        minLength = strLength[check];
                        minPos = check;
                    }
                }
                if (minPos != startPos)
                {
                    SwitchPos(arrStr, strLength, startPos, minPos);
                }
            }
         }

        static void Main()
        {
            string[] arrStr = {"asdf", "ews", "zv","s", "hr", "errdgrs", "aerh", "ewr","wadaw",""};
            int[] strLength = new int[arrStr.Length];
            for (int position = 0; position < arrStr.Length; position++)
            {
                strLength[position] = arrStr[position].Length;
            }
            Console.WriteLine("The input array and the length of its members");
            PrintArray(arrStr);
            PrintArray(strLength);
            SortStringArr(arrStr, strLength);
            Console.WriteLine("The sorted array and the length of its members");
            PrintArray(arrStr);
            PrintArray(strLength);
        }
    }
}
