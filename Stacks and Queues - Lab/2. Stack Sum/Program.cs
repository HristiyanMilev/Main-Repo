using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            Stack<int> stack = new Stack<int>(numbers);
            int sum = 0;
            string command = Console.ReadLine().ToLower();

            while (command != "end")
            {
                string[] cmdArg = command.Split();
                string typeCmd = cmdArg[0];
                if (typeCmd == "add")
                {
                    int firstNum = int.Parse(cmdArg[1]);
                    int secondNum = int.Parse(cmdArg[2]);

                    stack.Push(firstNum);
                    stack.Push(secondNum);
                }
                if (typeCmd == "remove")
                {
                    int num = int.Parse(cmdArg[1]);
                    if (num <= stack.Count) //(stack.Count < num)
                    {
                        for (int i = 0; i < num; i++)
                        {
                            stack.Pop();
                        }
                    }
                    
                }

                command = Console.ReadLine().ToLower();
            }

            foreach (var item in stack)
            {
                sum += item; // whilte --> sum += stack.Pop
            }
            Console.WriteLine($"Sum: {sum}");

            //Console.WriteLine(stack.Sum());
        }
    }
}
