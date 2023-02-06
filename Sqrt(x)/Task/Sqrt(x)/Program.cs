using System;

namespace Sqrt_x_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MySqrt(4)); //Case with 8 , Case with 2147395600
        }

        public static int MySqrt(int x)
        {
            if(x == 1)
            {
                return x;
            }
            for (double i = 0; i <= x; i++)
            {

                if (i * i > x)
                {
                    return Convert.ToInt32(i - 1);
                }
            }
            return 0;
        }
    }
}
