//https://judge.softuni.bg/Contests/Practice/Index/1382#1

using System;

namespace _02._Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int begin = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int match = int.Parse(Console.ReadLine());
            int count = 0;
            bool resultFound = false;
            for (int i = begin; i <= end; i++)
            {
                if (resultFound)
                {
                    break;
                }
                for (int j = begin; j <= end; j++)
                {
                    count++;
                    if (i + j == match)
                    {
                        Console.WriteLine($"Combination N:{count} ({i} + {j} = {match})");
                        resultFound = true;
                        break;
                    }
                }
            }
            if (!resultFound)
            {
                Console.WriteLine($"{count} combinations - neither equals {match}");
            }
        }
    }
}
