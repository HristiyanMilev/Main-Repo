using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 0;
            int s = 1000;
            bool found = false;

            for (int a = 1; a < s / 3; a++)
            {
                for (int b = a; b < s/2; b++)
                {
                    c = s - a - b;
                    if (a * a + b * b == c * c)
                    {
                        found = true;
                        Console.WriteLine(a * b * c);
                        break;
                    }
                }
                
            }

            
        }
    }
}
