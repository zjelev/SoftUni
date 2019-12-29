using System;

namespace _05.Axe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 5 * n;
            int left = 3 * n;
            int middle = 0;
            int right = width - left - middle - 2;
            //top
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('-', left), new string('-', middle), new string('-', right));
                right--;
                middle++;
            }
            //handle
            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}*{1}*{1}", new string('*', left), new string('-', middle-1));
            }
            //bottom
            for (int i = 0; i < n / 2 - 1; i++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('-', left), new string('-', middle - 1), new string('-', right+1));
                right--;
                left--;
                middle += 2;
            }
            //last line
            Console.WriteLine("{0}{1}{2}", new string('-', left), new string('*', middle+1), new string('-', right+1));
        }
    }
}