using System;
using System.Linq;

namespace _5._Square_With_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] parameters = Console.ReadLine().Split(", ");
            int rows = int.Parse(parameters[0]);
            int cols = int.Parse(parameters[1]);

            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                int[] data = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = data[j];
                }
            }

            int sum = 0;
            int topSum = 0;
            int maxRow = 0;
            int maxCol = 0;

            for (int i = 0; i < rows; i++)
            {

                for (int j = 0; j < cols; j++)
                {
                    sum = 0;
                    if (j == cols - 1 || i == rows - 1)
                    {
                        continue;
                    }
                    sum += matrix[i, j];
                    sum += matrix[i, j+1];
                    sum += matrix[i+1, j];
                    sum += matrix[i+1, j+1];
                    
                    if (sum > topSum)
                    {
                        topSum = sum;
                        maxRow = i;
                        maxCol = j;
                    }
                }
            }

            Console.WriteLine($"{matrix[maxRow,maxCol]} {matrix[maxRow, maxCol + 1]}");
            Console.WriteLine($"{matrix[maxRow + 1,maxCol]} {matrix[maxRow + 1,  maxCol + 1]}");
            Console.WriteLine(topSum);

            //int suuum = 0;
            //for (int i = 0; i < rows; i++)
            //{

            //    for (int j = 0; j < cols; j++)
            //    {
            //        suuum = 0;
            //        if (j == cols - 1 || i == rows - 1)
            //        {
            //            continue;
            //        }
            //        suuum += matrix[i, j];
            //        suuum += matrix[i, j + 1];
            //        suuum += matrix[i + 1, j];
            //        suuum += matrix[i + 1, j + 1];

            //        if (suuum == topSum)
            //        {
            //            Console.Write(matrix[i, j] + " ");
            //            Console.Write(matrix[i, j + 1]);
            //            Console.WriteLine();
            //            Console.Write(matrix[i + 1, j] + " ");
            //            Console.Write(matrix[i + 1, j + 1]);
            //        }
            //    }
            //}


            //Console.WriteLine();
            //Console.WriteLine(topSum);
        }
    }
}
