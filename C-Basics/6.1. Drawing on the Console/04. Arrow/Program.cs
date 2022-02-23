using System;

namespace _04.Arrow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int dots = n/2;
            int sharps = n;
            //top
            Console.WriteLine("{0}{1}{0}", new string('.', dots), new string('#', sharps));
            //upper
            for (int i = 0; i < n-2; i++)
            {
                Console.WriteLine("{0}#{1}#{0}", new string('.', dots), new string('.', sharps-2));
            }
            //middle
            Console.WriteLine("{0}{1}{0}", new string('#', dots+1), new string('.', sharps-2));
            //bottom
            for (int i = 1; i <= n-2; i++)
            {
                Console.WriteLine("{0}#{1}#{0}", new string('.', i), new string('.', 2*sharps-5));
                sharps -= 1;
            }
            //last line
            Console.WriteLine("{0}#{0}", new string('.', n - 1));
        }
    }
}