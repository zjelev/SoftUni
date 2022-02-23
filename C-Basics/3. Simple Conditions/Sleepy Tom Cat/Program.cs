using System;

namespace Sleepy_Tom_Cat
{
    class Program
    {
        static void Main(string[] args)
        {
            int holidays = int.Parse(Console.ReadLine());
            int play = (365 - holidays) * 63 + holidays * 127;
            if (play > 30000)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", (play - 30000) / 60, (play - 30000) % 60);
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", (30000 - play) / 60, (30000 - play) % 60);
            }
        }
    }
}
