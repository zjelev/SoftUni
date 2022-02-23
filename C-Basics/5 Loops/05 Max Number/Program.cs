using System;

namespace _05_Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftSum=0, rightSum=0;
            for (int i = 0; i < n; i++)
            {
                leftSum = leftSum + int.Parse(Console.ReadLine());
            }
            //Console.WriteLine("Left =" + leftSum);
            for (int i = 0; i < n; i++)
            {
                rightSum = rightSum + int.Parse(Console.ReadLine());
            }
            //Console.WriteLine("Left =" + rightSum);
            if (leftSum == rightSum)
            {
                Console.WriteLine("Yes, sum = " + rightSum);
            }
            else
            {
                Console.WriteLine("No, diff = " + Math.Abs(leftSum - rightSum));
            }
        }
    }
}