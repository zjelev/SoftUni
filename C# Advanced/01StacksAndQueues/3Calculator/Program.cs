using System;
using System.Collections.Generic;
using System.Linq;

namespace _3Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string input = Console.ReadLine();
            string[] expression = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Stack<string> stack = new Stack<string>(expression.Reverse());

            
            while (stack.Count > 1)
            {

                int operand1 = int.Parse(stack.Pop());
                string operation = stack.Pop();
                int operand2 = int.Parse(stack.Pop());
                
                switch (operation)
                {
                    case "+":
                        stack.Push($"{operand1 + operand2}");
                        break;
                    case "-":
                        stack.Push($"{operand1 - operand2}");

                        break;
                }
                
            }

            Console.WriteLine(stack.Pop());
        }
    }
}
