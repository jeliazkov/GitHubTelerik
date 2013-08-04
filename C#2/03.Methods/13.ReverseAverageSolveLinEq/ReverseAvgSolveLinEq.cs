//Write a program that can solve these tasks:
//Reverses the digits of a number
//Calculates the average of a sequence of integers
//Solves a linear equation a * x + b = 0
//        Create appropriate methods.
//        Provide a simple text-based menu for the user to choose which task to solve.
//        Validate the input data:
//The decimal number should be non-negative
//The sequence should not be empty
//a should not be equal to 0

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.ReverseAverageSolveLinEq
{
    class ReverseAvgSolveLinEq
    {
        static double ReverseDigits(double inputNumber)
        {
            string inputStr = inputNumber.ToString();
            char[] outputStr = new char[inputStr.Length];
            for (int num = inputStr.Length - 1; num >= 0; num--)
            {
                outputStr[inputStr.Length - 1 - num] = inputStr[num];
            }
            string ret = new string(outputStr);
            return double.Parse(ret);
        }

        static double AverageOfArray(List<int> array)
        {
            int sum = 0;
            for (int pos = 0; pos < array.Count; pos++)
            {
                sum += array[pos];
            }
            double average = (double)sum / (double)array.Count;
            return average;
        }

        static double SolveLinearEq(double a, double b)  //a * x + b = 0
        {
            double answer = -b / a;
            return answer;
        }


        static void Main(string[] args)
        {
            Console.WriteLine(
        @"What task to solve:
        1.Reverses the digits of a number
        2.Calculate the average of a sequence of integers
        3.Solves a linear equation a * x + b = 0");
            Console.Write("Answer: ");
            string inputStr = Console.ReadLine();
            int answer = 0;
            while (int.TryParse(inputStr, out answer)==false || answer>3 || answer<0)
            {
                Console.WriteLine("Enter the number of your choice: (1-3)");
                inputStr = Console.ReadLine();
            }

            switch (answer)
            {
                case 1:
                    {
                        Console.Write("Enter the number to be reversed: ");
                        string inStr = Console.ReadLine();
                        int ans = 0;
                        while (int.TryParse(inStr, out ans) == false || ans<0)
                        {
                            Console.WriteLine("Enter positive number:");
                            inStr = Console.ReadLine();
                        }
                        Console.Write("The reversed digid is: ");
                        Console.WriteLine(ReverseDigits(ans));
                        break;
                    }
                case 2:
                    {
                        Console.Write("Enter some number: ");
                        string instr = Console.ReadLine();
                        int number = 0;
                        List<int> arr=new List<int>();
                        while (int.TryParse(instr, out number))
                        {
                            arr.Add(number);
                            Console.Write("Enter other number or letter for end ");
                            instr = Console.ReadLine();
                        }
                        Console.Write("The average of the array is: ");
                        Console.WriteLine(AverageOfArray(arr));
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Enter coefficient \"a\" of the equation  a * x + b = 0");
                        string inStr = Console.ReadLine();
                        int coefA = 0;
                        while (int.TryParse(inStr,out coefA)==false || coefA==0)
                        {
                            Console.Write("Enter non zero coefficient ");
                            inStr = Console.ReadLine();
                        }
                        Console.WriteLine("Enter coefficient \"b\" of the equation  a * x + b = 0");
                        inStr = Console.ReadLine();
                        int coefB = 0;
                        while (int.TryParse(inStr,out coefB)==false)
                        {
                            Console.Write("Enter non zero coefficient ");
                            inStr = Console.ReadLine();
                        }
                        double answ = SolveLinearEq(coefA, coefB);
                        Console.WriteLine("The answer of the equasion  {0} * x + {1} = 0 is : x={2}",coefA,coefB,answ);
                        break;
                    }
                default:
                    break;
            }
        }
    }
}
