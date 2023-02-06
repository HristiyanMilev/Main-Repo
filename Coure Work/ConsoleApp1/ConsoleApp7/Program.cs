using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isPrime(int numm) 
            {
                if (numm <= 1)
                {
                    return false;
                }
                if (numm == 2)
                {
                    return false;
                }
                if (numm % 2 == 0)
                {
                    return false;
                }

                int counter = 3;
                while ((counter * counter) <= numm)
                {
                    if (numm % counter == 0)
                    {
                        return false;
                    }
                    else
                    {
                        counter += 2;
                    }
                }
                return true;
            }

            int numPrimes = 1;
            int numm = 1;

            while (numPrimes < 10001)
            {
                numm = numm + 2;
                if (isPrime(numm))
                {
                    numPrimes++;
                }
            }

            Console.WriteLine(numPrimes);
        }
    }
}
