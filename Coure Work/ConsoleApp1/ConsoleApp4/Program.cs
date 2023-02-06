using System;
using System.Linq;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int makePalindrome(int firsHalf)
            {
                char[] reversed = firsHalf.ToString().Reverse().ToArray();
                return Convert.ToInt32(firsHalf + new string(reversed));
            }

            bool found = false;
            int firstHalf = 998, palin = 0;
            int[] factors = new int[2];
            while (!found)
            {
                firstHalf--;
                palin = makePalindrome(firstHalf);
                for (int i = 999; i > 99; i--)
                {
                    if ((palin / i) > 999 || i * i < palin)
                    {
                        break;
                    }

                    if ((palin % i) == 0)
                    {
                        found = true;
                        factors[0] = palin / i;
                        factors[1] = i;
                        break;
                    }
                }
            }
            Console.WriteLine("{0}",palin);
        }
    }
}
