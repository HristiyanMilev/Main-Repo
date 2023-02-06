using System;

namespace _7._Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long[][] pascalTriangle = new long[n][];
            pascalTriangle[0] = new long[1] {1};
            for (int row = 1; row < n; row++)
            {
                pascalTriangle[row] = new long[row + 1];

                for (int col = 0; col < pascalTriangle[row].Length; col++)
                {
                    if (pascalTriangle[row - 1].Length > col)
                    {
                        pascalTriangle[row][col] += pascalTriangle[row - 1][col];

                    }
                    if (col > 0)
                    {
                        pascalTriangle[row][col] += pascalTriangle[row - 1][col - 1];
                    }
                }
                
            }


            for (int i = 0; i < pascalTriangle.Length; i++)
            {
                for (int j = 0; j < pascalTriangle[i].Length; j++)
                {
                    Console.Write($"{pascalTriangle[i][j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
