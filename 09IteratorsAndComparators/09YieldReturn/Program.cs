using System;
using System.Collections.Generic;

namespace _09YieldReturn
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> arr = GetArrEnum();
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }

        private static IEnumerable<int> GetArrEnum()
        {
            for (int i = 0; i < 10; i++)
            {
                yield return i;
            }
        }
    }
}
