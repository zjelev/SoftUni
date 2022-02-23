using System;

namespace _05._The_song_of_the_wheels
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int count = 0;
            string pass = "";
            for (int a = 1; a <= 9; a++)
            {
                for (int b = 1; b <= 9; b++)
                {
                    for (int c = 1; c <= 9; c++)
                    {
                        for (int d = 1; d <= 9; d++)
                        {
                            if (((a*b) + (c*d) == m) && a<b && c>d)
                            {
                                Console.Write("" + a + b + c + d + " ");
                                count++;
                                if (count == 4)
                                {
                                    pass = string.Format($"{a}{b}{c}{d}");
                                }
                            }
                            
                        }
                    }
                }
            }
            if (count >= 4)
            {
                Console.WriteLine("\nPassword: " + pass);
            }
            else
            {
                Console.WriteLine("\nNo!");
            }
        }
    }
}
