//*Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N]. Example:
//	N = 3, K = 2  {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}

using System;

class PrintAllVariationsOfKElementsOfNNumbers
{
    static void Main()
    {
        Console.WriteLine("N=?");
        int N = int.Parse(Console.ReadLine());
        Console.WriteLine("K=?");
        int K = int.Parse(Console.ReadLine());

        int height = (int) Math.Pow(N, K);
        int[,] myArray = new int[height, K];

        //make variations
        for (int col = 0; col < K; col++)
        {
            int row = 0;
            for (int repearGroup = 0; repearGroup < (int)Math.Pow(N, col); repearGroup++)
            {
                for (int value = 1; value <= N; value++)
                {
                    for (int timesSameDigit = 0; timesSameDigit < (int)Math.Pow(N,K-col-1); timesSameDigit++)  //N*N=N^(K-1)
                    {
                        myArray[row, col] = value;
                        row++;
                    }
                }
            }
        }

        //print combination matrix
        for (int row = 0; row < height; row++)
        {
            Console.Write("{");
            for (int col = 0; col < K; col++)
            {
                if (col<K-1)
                {
                    Console.Write(myArray[row,col]+", ");
                }
                else
                {
                    Console.Write(myArray[row, col]);
                }
                
            }
            Console.Write("}");
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}