﻿using System;
using System.Collections.Generic;
using System.Linq;
//using System.Linq;

namespace _2StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>(); //(Console.ReadLine().Split());
            string[] line = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int number = 0;

            while (line[0]?.ToLower() != "end")
            {
                if (int.TryParse(line[0], out number))
                {
                    foreach (var item in line)
                    {
                        stack.Push(int.Parse(item));
                    }
                }
                else
                {
                    string command = line[0]?.ToLower();

                    switch (command)
                    {
                        case "add":
                            for (int i = 1; i < line.Length; i++)                            
                            {
                                stack.Push(int.Parse(line[i]));
                            }
                            break;
                        case "remove":
                            int count = int.Parse(line[1]);
                            if (count > stack.Count)
                            {
                                break;
                            }
                            for (int i = 0; i < count; i++)
                            {
                                stack.Pop();
                            }
                            break;
                        default:
                            break;
                    }
                }
                line = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);                
            }
            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}