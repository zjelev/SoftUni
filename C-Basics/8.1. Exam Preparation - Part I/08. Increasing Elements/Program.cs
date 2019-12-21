using System;

namespace _08.Increasing_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int n = int.Parse(Console.ReadLine());
                int longest = 0, a = 0, aPrev = 0, currentLongest = 0;
                for (int i = 0; i < n; i++)
                {
                    a = int.Parse(Console.ReadLine());
                    if (a > aPrev)
                    {
                        currentLongest++;
                    }
                    else
                    {
                        currentLongest = 1;
                    }
                    if (currentLongest > longest)
                    {
                        longest = currentLongest;
                    }
                    aPrev = a;
                }
                Console.WriteLine(longest);

            }
        }
    }
}