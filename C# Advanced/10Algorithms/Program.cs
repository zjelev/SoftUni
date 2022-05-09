using System;
using System.Linq;

namespace _10Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] input = Console.ReadLine()
            // .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            // .Select(int.Parse)
            // .ToArray();

            // Console.WriteLine(ArraySumRecc(input));

            //Console.WriteLine(Fact(ushort.Parse(Console.ReadLine())));
        }

        // static void Recc(int x)
        // {
        //     if (Math.Abs(x) != 0)
        //     {
        //         Recc(Math.Abs(x) - 1);
        //     }
        //     Console.WriteLine(x);
        // }

        // static int ArraySumRecc(int[] arr, int index = 0)
        // {
        //     int sum = arr[index];
        //     if (index == arr.Length - 1)
        //     {
        //         return arr[index];
        //     }

        //     sum += ArraySumRecc(arr, index + 1);

        //     return sum;
        // }

        // static System.Numerics.BigInteger Fact(ushort n)
        // {
        //     if (n == 0)
        //     {
        //         return 1;
        //     }

        //     return n * Fact((ushort)(n - 1));
        // }

        
    }
}
