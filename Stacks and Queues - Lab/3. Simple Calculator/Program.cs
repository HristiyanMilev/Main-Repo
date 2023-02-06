using System;
using System.Collections.Generic;

namespace _3._Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Stack<string> stack = new Stack<string>();
            
            for (int i = input.Length - 1; i >= 0; i--)
            {
                stack.Push(input[i]);
            }
            int count = stack.Count;
            int sum = 0;
            sum = int.Parse(stack.Pop());

            for (int i = 0; i < count; i++)
            {
                
                if (stack.Peek() == "+")
                {
                    stack.Pop();
                    sum += int.Parse(stack.Pop());
                    if (stack.Count == 0)
                    {
                        break;
                    }
                }

                if (stack.Peek() == "-")
                {
                    stack.Pop();
                    sum -= int.Parse(stack.Pop());
                    if (stack.Count == 0)
                {
                    break;
                }
                }
            }

            Console.WriteLine(sum);
        }
    }
}
