using System;
using System.Collections.Generic;

namespace _4._Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<int> stack = new Stack<int>();


            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    stack.Push(i);
                }
                if (input[i] == ')')
                {
                    int openBracket = stack.Pop();      
                    for (int k = openBracket; k <= i; k++)
                    {
                        Console.Write(input[k]); ;
                    }
                    Console.WriteLine();
                }
            }

            
        }
    }
}
