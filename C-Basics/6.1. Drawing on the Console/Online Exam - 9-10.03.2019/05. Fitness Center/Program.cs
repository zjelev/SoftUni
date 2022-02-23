//https://judge.softuni.bg/Contests/Practice/Index/1538#9

using System;

namespace _05._Fitness_Center
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort visitors = ushort.Parse(Console.ReadLine());
            ushort back = 0, chest = 0, legs = 0, abs = 0, proteinShake = 0, proteinBar = 0;
            for (int i = 0; i < visitors; i++)
            {
                string activity = Console.ReadLine();
                if (activity == "Back")
                {
                    back++;
                }
                else if (activity == "Chest")
                {
                    chest++;
                }
                else if (activity == "Legs")
                {
                    legs++;
                }
                else if (activity == "Abs")
                {
                    abs++;
                }
                else if (activity == "Protein shake")
                {
                    proteinShake++;
                }
                else if (activity == "Protein bar")
                {
                    proteinBar++;
                }
            }
            string output = string.Format($"{back} - back\n{chest} - chest\n{legs} - legs\n" +
                $"{abs} - abs\n{proteinShake} - protein shake\n{proteinBar} - protein bar\n" +
                $"{1.0 * (back + chest + legs + abs) / visitors * 100:f2}% - work out\n" +
                $"{1.0 * (proteinShake + proteinBar) / visitors * 100:f2}% - protein");
            Console.WriteLine(output);
        }
    }
}