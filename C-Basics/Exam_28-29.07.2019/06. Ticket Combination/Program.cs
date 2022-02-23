using System;

namespace _06._Ticket_Combination
{
    class Program
    {
        static void Main(string[] args)
        {
            int combinationNum = int.Parse(Console.ReadLine());
            int counterComb = 0;

            for (int stadiumName = 'B'; stadiumName <= 'L'; stadiumName += 2)
            {
                for (int sectorName = 'f'; sectorName >= 'a'; sectorName--)
                {
                    for (int entrance = 'A'; entrance <= 'C'; entrance++)
                    {
                        for (int row = 1; row <= 10; row++)
                        {
                            for (int seat = 10; seat >= 1; seat--)
                            {
                                counterComb++;
                                if (counterComb == combinationNum)
                                {
                                    string ticketCombination = ((char)stadiumName).ToString() +
                                        (char)sectorName + (char)entrance + row.ToString() + seat.ToString();
                                    Console.WriteLine($"Ticket combination: {ticketCombination}");

                                    int prizeSum = stadiumName + sectorName + entrance + row + seat;
                                    Console.WriteLine($"Prize: {prizeSum} lv.");

                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
