using System;
using System.Linq;

namespace _4._Symbol_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[,] matrix = new string[n, n];
            bool isFound = false;

            for (int i = 0; i < n; i++)
            {
                string data = Console.ReadLine();

                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = (data[j].ToString());
                }
            }

            char secretChar = char.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                if (isFound)
                {
                    break;
                }
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i,j] == secretChar.ToString())
                    {
                        Console.WriteLine($"({i}, {j})");
                        isFound = true;
                        break;
                    }
                }
            }

            if (!isFound)
            {
                Console.WriteLine($"{secretChar} does not occur in the matrix");
            }

            
        }


    }
}
