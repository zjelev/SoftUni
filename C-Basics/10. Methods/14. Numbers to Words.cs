using System;

namespace _14._Numbers_to_Words
{
    class NumbersToWords
    {
        static string Digits (int i)
        {
            switch (i)
            {
                case 1: return "one"; break;
                case 2: return "two"; break;
                case 3: return "three"; break;
                case 4: return "four"; break;
                case 5: return "five"; break;
                case 6: return "six"; break;
                case 7: return "seven"; break;
                case 8: return "eight"; break;
                case 9: return "nine"; break;
                default: return ""; break;
            }
        }

        static string Digit11_19(int i)
        {
            switch (i)
            {
                case 1: return "eleven"; break;
                case 2: return "twelve"; break;
                case 3: return "thirteen"; break;
                case 5: return "fifteen"; break;
                case 4: 
                case 6: 
                case 7:
                case 9: return Digits(i) + "teen"; break;
                case 8: return "eighteen"; break;
                default: return ""; break;
            }
        }

        static string Digit20_90(int i)
        {
            switch (i)
            {
                case 2: return "twenty"; break;
                case 3: return "thirty"; break;
                case 5: return "fifty"; break;
                case 4:
                case 6:
                case 7:
                case 9: return Digits(i) + "ty"; break;
                case 8: return "eighty"; break;
                default: return ""; break;
            }
        }

        static void Letterize(int num)
        {
            if (num > 999)
            {
                Console.WriteLine("too large");
            }
            else if (num < -999)
            {
                Console.WriteLine("too small");
            }
            else if (num > 99 || num < -99)
            {
                int hundreds = Math.Abs(num / 100);
                int tens =  Math.Abs(num / 10 % 10);
                int singles = Math.Abs(num % 10 % 10);
                if (num < 0)
                {
                    Console.Write("minus ");
                }

                Console.Write((Digits(hundreds) + "-hundred"));

                if (tens > 0 || singles > 0)
                {
                    Console.Write(" and ");
                }

                if (tens == 0 && singles > 0)
                {
                    Console.Write(Digits(singles));
                }
                else if (tens == 1 && singles == 0)
                {
                    Console.Write("ten");
                }
                else if (tens == 1 && singles > 0)
                {
                    Console.Write(Digit11_19(singles));
                }
                else if (tens > 1 && singles == 0)
                {
                    Console.Write(Digit20_90(tens));
                }
                else if (tens > 1 && singles > 0)
                {
                    Console.Write(Digit20_90(tens) + " " + Digits(singles));
                }
                else
                {
                    Console.Write("");
                }
                Console.Write("\n");
            }
        }
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                Letterize(num);
            }
        }
    }
}
