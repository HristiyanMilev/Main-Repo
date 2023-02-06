using System;
using System.Collections.Generic;

namespace _7._Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> players = new Queue<string>(Console.ReadLine().Split());

            int n = int.Parse(Console.ReadLine());
            int tosses = 1;

            while (players.Count != 1)
            {
                string child = players.Dequeue();
                if (tosses < n)
                {
                    tosses++;
                    players.Enqueue(child);
                }
                else
                {
                    Console.WriteLine($"Removed {child}");
                    tosses = 1;
                }
            }

            Console.WriteLine($"Last is {players.Dequeue()}");
             
        }
    }
}
