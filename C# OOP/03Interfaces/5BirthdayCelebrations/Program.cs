using System;
using System.Collections.Generic;

namespace BorderControl
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            List<IBirthable> tresspassers = new List<IBirthable>();

            while ((input = Console.ReadLine()) != "End")
            {
                string[] token = input.Split();
                IBirthable tresspasser;
                if (token[0] == "Citizen")
                {
                    tresspasser = new Citizen(token[1], 
                        int.Parse(token[2]), token[3], token[4]);
                    tresspassers.Add(tresspasser);
                }
                else if (token[0] == "Pet")
                {
                    tresspasser = new Pet(token[1], token[2]);
                    tresspassers.Add(tresspasser);
                }
            }
            string year = Console.ReadLine();
            foreach (var item in tresspassers)
            {
                if (item.Birthdate.Substring(6) == year)
                {
                    Console.WriteLine(item.Birthdate);
                }
            }
        }
    }
}
