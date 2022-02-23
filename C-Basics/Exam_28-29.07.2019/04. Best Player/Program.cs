using System;

namespace _04._Best_Player
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxGoals = 0;
            string bestPlayer = "";
            string playerName = Console.ReadLine();

            while (playerName != "END")
            {
                int goalsScored = int.Parse(Console.ReadLine());

                if (goalsScored > maxGoals)
                {
                    maxGoals = goalsScored;
                    bestPlayer = playerName;
                }


                if (goalsScored >= 10)
                {
                    break;
                }

                playerName = Console.ReadLine();
            }

            Console.WriteLine($"{bestPlayer} is the best player!");

            if (maxGoals >= 3)
            {
                Console.WriteLine($"He has scored {maxGoals} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"He has scored {maxGoals} goals.");
            }
        }
    }
}
