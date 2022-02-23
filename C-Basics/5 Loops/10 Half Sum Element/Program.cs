using System;

namespace _10_Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int max = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num >= max)
                {
                    max = num;
                }
                sum = sum + num;
            }
            if (sum == max*2)
            {
                Console.Write("Yes" + "\n" + "Sum = " + max);
            }
            else
            {
                Console.Write("No" + "\n" + "Diff = " + Math.Abs(max - (sum - max)));
            }
        }
    }
}