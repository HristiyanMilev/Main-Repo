using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Print_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Queue<int> evenNumbers = new Queue<int>(inputArray.Where(x => x % 2 == 0));

            while (evenNumbers.Any())
            {
                if (evenNumbers.Count == 1)
                {
                    Console.WriteLine(evenNumbers.Dequeue()); 
                    break;
                }
                Console.Write(string.Join(", ", evenNumbers.Dequeue()));
                Console.Write(", ");
                
            }


        }
    }
}
