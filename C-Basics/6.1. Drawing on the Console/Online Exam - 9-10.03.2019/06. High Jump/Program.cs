//https://judge.softuni.bg/Contests/Practice/Index/1538#10

using System;

namespace _06._High_Jump
{
    class HighJump
    {
        static void Main(string[] args)
        {
            int desired = int.Parse(Console.ReadLine());
            int height = desired - 30;
            int jump = 0;
            int numJumps = 0;
            byte fail = 0;
            string output = "";
            while (height <= desired && fail < 3)
            {
                jump = int.Parse(Console.ReadLine());
                numJumps++;
                if (jump > height)
                {
                    height += 5;
                    fail = 0;
                }
                else
                {
                    fail++;
                }
            }
            if (jump > desired)
            {
                output = string.Format($"Tihomir succeeded, he jumped over {desired}cm after {numJumps} jumps.");
            }
            else
            {
                output = string.Format($"Tihomir failed at {height}cm after {numJumps} jumps.");
            }
            Console.WriteLine(output);
        }
    }
}