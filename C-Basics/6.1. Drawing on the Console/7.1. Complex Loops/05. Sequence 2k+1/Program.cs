using System;

namespace _05.Sequence_2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            int n = int.Parse(Console.ReadLine());
            while (num<=n)
            {
                Console.WriteLine(num + ", ");
                num = 2 * num + 1;
            }
        }
    }
}
