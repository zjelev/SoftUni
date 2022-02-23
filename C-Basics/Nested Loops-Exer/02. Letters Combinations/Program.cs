using System;

namespace _02.Letters_Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char z = char.Parse(Console.ReadLine());
            char x = char.Parse(Console.ReadLine());

            int counter = 0;
            for (char i = a; i <= z; i++)
            {
                for (char j = a; j <= z; j++)
                {
                    for (char k = a; k <= z; k++)
                    {
                        if (i != x && j != x && k != x)
                        {
                            Console.Write("" + i + j + k + " ");
                            counter++;
                        }
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}