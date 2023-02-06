using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string command;
            Queue<string> peopleLeft = new Queue<string>();

            while ((command = Console.ReadLine()) != "End")
            {
                if (command == "Paid")
                {
                    while (peopleLeft.Any())
                    {
                        Console.WriteLine(peopleLeft.Dequeue());
                    }
                   ;
                }
                if (command != "Paid")
                {
                    peopleLeft.Enqueue(command);
                }
                
                
            }
            Console.WriteLine($"{peopleLeft.Count} people remaining.");
        }
    }
}
