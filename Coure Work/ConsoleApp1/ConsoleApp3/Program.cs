using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            const long numm = 600851475143;
            long largestFact = 0;
            for (long i = 2; i < numm; i++)
            {
                if (numm % i == 0)
                {// It is a divisor
                    bool isPrime = true;
                    for (long j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime)
                    {
                        largestFact = i;
                    }
                }
            }
            Console.WriteLine(largestFact);
        }
    }
}
