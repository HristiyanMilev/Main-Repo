using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            uint n = 4000000;
            int fib = -0;
            int x = 1;
            int y = 1;
            long sum = 0;

            while (fib <= n)
            {
                fib = x + y;
                x = y;
                y = fib;

                if (fib % 2 == 0)
                {
                    sum += fib;
                }
                
            }
            Console.WriteLine(sum);
        }
    }
}
