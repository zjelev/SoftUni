using System;

namespace _07._Name_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            int nameMaxValue = int.MinValue;
            string nameWinner = "";
            string name = Console.ReadLine();

            while (name != "STOP")
            {
                int nameValue = 0;
                
                for (int i = 0; i < name.Length; i++)
                {
                    nameValue += name[i];
                }

                if (nameValue > nameMaxValue)
                {
                    nameMaxValue = nameValue;
                    nameWinner = name;
                }

                name = Console.ReadLine();
            }

            Console.WriteLine($"Winner is {nameWinner} - {nameMaxValue}!");
        }
    }
}
