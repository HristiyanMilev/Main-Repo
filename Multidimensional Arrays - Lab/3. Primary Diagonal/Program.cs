using System;
using System.Linq;

namespace _3._Primary_Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] sqMatrix = new int[n, n];

            for (int i = 0; i < sqMatrix.GetLength(0); i++)
            {
                int[] data = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int j = 0; j < sqMatrix.GetLength(1); j++)
                {
                    sqMatrix[i, j] = data[j]; // sus data ot j vzimame svsyaka stoinost ot masiva data chrez inkrementaciyata na j
                }
            }

            int sum = 0;
             
            for (int i = 0; i < n; i++)
            {
                sum += sqMatrix[i, i];
            }
            Console.WriteLine(sum);
        }
    }
}
