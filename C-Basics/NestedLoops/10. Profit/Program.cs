using System;

namespace _10._Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            int coinsOneLev = int.Parse(Console.ReadLine());
            int coinsTwoLev = int.Parse(Console.ReadLine());
            int notesFiveLev = int.Parse(Console.ReadLine());
            int sumToPay = int.Parse(Console.ReadLine());

            for (int i = 0; i <= coinsOneLev; i++)
            {
                for (int j = 0; j <= coinsTwoLev ; j++)
                {
                    for (int k = 0; k <= notesFiveLev; k++)
                    {
                        if (i + j * 2 + k * 5 == sumToPay)
                        {
                            Console.WriteLine($"{i} * 1 lv. + {j} * 2 lv. + {k} * 5 lv. = {sumToPay} lv.");
                            break;
                        }
                    }
                    
                }
            }

        }
    }
}
