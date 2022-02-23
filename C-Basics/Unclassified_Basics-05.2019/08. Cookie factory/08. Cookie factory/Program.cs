using System;

namespace _08._Cookie_factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int numBatches = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numBatches; i++)
            {
                bool hasFlour = false;
                bool hasEggs = false;
                bool hasSugar = false;

                while (true)
                {
                    string input = Console.ReadLine();

                    if (input == "flour")
                    {
                        hasFlour = true;
                    }
                    if (input == "eggs")
                    {
                        hasEggs = true;
                    }
                    if (input == "sugar")
                    {
                        hasSugar = true;
                    }

                    if ((input == "Bake!") && (!hasFlour || !hasEggs || !hasSugar))
                    {
                        Console.WriteLine("The batter should contain flour, eggs and sugar!");
                    }
                    else if (input == "Bake!")
                    {
                        break;
                    }
                }

                if (hasFlour && hasEggs && hasSugar)
                {
                    Console.WriteLine($"Baking batch number {i}...");
                }

            }
        }
    }
}
