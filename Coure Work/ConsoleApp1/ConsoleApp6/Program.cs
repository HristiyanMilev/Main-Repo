using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            long sum = 0;
            long squared = 0;
            long result = 0;

            const int N = 100;

            sum = N * (N + 1) / 2;
            squared = (N * (N + 1) * (2 * N + 1)) / 6;

            result = sum * sum - squared;
            Console.WriteLine(result);
        }
    }
}
