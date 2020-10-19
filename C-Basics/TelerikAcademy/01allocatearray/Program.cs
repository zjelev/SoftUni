using System;

namespace _01allocatearray
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] myArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                myArray[i] = i * 5;
                Console.WriteLine(myArray[i]);
            }
        }
    }
}
