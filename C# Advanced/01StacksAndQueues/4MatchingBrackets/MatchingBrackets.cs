using System;
using System.Collections.Generic;

namespace _4MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] expression = Console.ReadLine()
            //.Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .ToCharArray();

            Stack<int> indexes = new Stack<int>();

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    indexes.Push(expression[i]);
                }
                else if (expression[i] == ')')
                {
                    int start = indexes.Pop();
                    Console.WriteLine("{0}", string.Join("", expression)
                    .Substring(start, i - start + 1));
                }
            }
            //int desetichno = int.Parse(Console.ReadLine());
            //Console.WriteLine ("Hex: {0:X}", Desetichno);
        }
    }
}
