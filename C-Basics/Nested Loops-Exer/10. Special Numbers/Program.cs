//https://judge.softuni.bg/Contests/Practice/Index/1165#9

using System;

namespace _10._Special_Numbers
{
    class SpecialNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1111; i <= 9999; i++)
            {
                int current = i;
                int digit = 0;
                bool isSpecial = true;
                while (current > 0)
                {
                    digit = current % 10;
                    current /= 10;
                    
                    if (digit != 0)
                    {
                        if (n % digit != 0)
                        {
                            isSpecial = false;
                            break;
                        }
                    }
                    else 
                    {
                        isSpecial = false;
                        break;
                    }
                }
                if (isSpecial)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}