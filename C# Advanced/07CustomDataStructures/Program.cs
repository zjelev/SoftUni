using System;
using System.Collections.Generic;

namespace CustomDataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<int> list = new List<int>();
            // CustomList customList = new CustomList();
            // customList.Add(10);
            // customList.Add(20);            
            // customList.Add(30);
            // customList.Add(40);            
            // customList.Add(50);
            // customList.Add(60);
            // customList.Add(70);
            // customList.Add(80);
            
            // customList.RemoveAt(1);
            // customList.RemoveAt(1);
            // customList.RemoveAt(1);
            // customList.RemoveAt(1);
            // customList[1] = 100;
            // customList.Insert(4, 125);
            // customList.Swap(1, 2);

            // for (int i = 0; i < customList.Count; i++)
            // {
            //     Console.WriteLine(customList[i]);
            // }

            // CustomStack customStack = new CustomStack();
            // customStack.Push(5);
            // customStack.Push(6);
            // customStack.Push(678);
            // customStack.Push(67);

            // customStack.Pop();
            // customStack.Pop();

            Console.WriteLine(Fibonacci(20));
        }

        public static int Fibonacci(int n)
        {
            int prev;
            int prev2;

            if (n <= 2)
            {
                return 1;
            }
            else
            {
                prev = Fibonacci(n - 1);
                prev2 = Fibonacci(n - 2);
            }
            return prev + prev2;
        }
    }
}
