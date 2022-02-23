using System;

namespace _06.Letters_Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char z = char.Parse(Console.ReadLine());
            char m = char.Parse(Console.ReadLine());
            int num = 0;
            for (char i = a; i <= z; i++)
            {
                if (i == m)
                {
                    i++;
                }
                for (char j = a; j <= z; j++)
                {
                    if (j == m)
                    {
                        j++;
                    }
                    for (char k = a; k <= z; k++)
                    {
                        if (k == m)
                        {
                            k++;
                        }
                        if (i<=z || j<=z || k<=z)
                        {
                            Console.Write(char.ToString(i) + char.ToString(j) + char.ToString(k));
                            num++;
                            Console.Write(" ");
                        }
                    }
                }
            }
            Console.Write(num);
        }
    }
}