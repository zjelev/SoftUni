using System;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int volume = width * lenght * height;
            int numBoxes = 0;

            string input = Console.ReadLine();

            while (input != "Done")
            {
                numBoxes += int.Parse(input);
                if (numBoxes > volume)
                {
                    Console.WriteLine($"No more free space! You need {numBoxes - volume} Cubic meters more.");
                    break;
                }
                input = Console.ReadLine();
            }

            if (input == "Done")
            {
                Console.WriteLine($"{volume - numBoxes} Cubic meters left.");
            }
        }
    }
}
