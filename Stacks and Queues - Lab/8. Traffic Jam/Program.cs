﻿using System;
using System.Collections.Generic;

namespace _8._Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<string> cars = new Queue<string>();

            int carsPassed = 0;

            string command;
            while ((command = Console.ReadLine()) != "end")
            {

                
                if (command == "green")
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (cars.Count == 0)
                        {
                            break;
                        }
                        Console.WriteLine($"{cars.Dequeue()} passed!");
                        carsPassed++;
                        
                    }
                }
                if (command != "green")
                {
                    cars.Enqueue(command);
                }
      
            }
            Console.WriteLine($"{carsPassed} cars passed the crossroads.");
        }
    }
}
