using System;

namespace _02.Magic_Combination
{
    class Program
    {
        static void Main(string[] args)
        {
            int magic = int.Parse(Console.ReadLine());
            for (int c1 = 1; c1 <= 9; c1++)
            {
                for (int c2 = 1; c2 <= 9; c2++)
                {
                    for (int c3 = 1; c3 <= 9; c3++)
                    {
                        for (int c4 = 0; c4 < 9; c4++)
                        {
                            for (int c5 = 0; c5 < 9; c5++)
                            {
                                for (int c6 = 0; c6 < 9; c6++)
                                {
                                    if (c1 * c2 * c3 * c4 * c5 * c6 == magic)
                                    {
                                        Console.Write("{0}{1}{2}{3}{4}{5} ", c1, c2, c3, c4, c5, c6);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            /*int c1 = 0, c2, c3, c4, c5, c6;
            while (c1<=9)
            {
                c2 = 0;
                while (c2 <= 9)
                {
                    c3 = 0;
                    while (c3 <= 9)
                    {
                        c4 = 0;
                        while (c4 <= 0)
                        {
                            c5 = 0;
                            while (c5 <= 0)
                            {
                                c6 = 0;
                                if (c1 * c2 * c3 * c4 * c5 * c6 == magic)
                                {
                                    Console.Write("{0}{1}{2}{3}{4}{5} ", c1, c2, c3, c4, c5, c6);
                                }
                                c6++;
                            }
                            c5++;
                        }
                        c4++;
                    }
                    c3++;
                }
                c2++;
            }
            c1++; */
        }
    }
}