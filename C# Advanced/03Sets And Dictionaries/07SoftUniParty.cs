using System;
using System.Collections.Generic;

namespace SetsAndDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            var reservation = new HashSet<string>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "PARTY")
            {
                reservation.Add(input);
            }

            while ((input = Console.ReadLine()) != "END")
            {
                if (reservation.Contains(input))
                {
                    reservation.Remove(input);
                }
            }

            Console.WriteLine(reservation.Count);
            
            var vips = new HashSet<string>();
            var nonVips = new HashSet<string>();

            foreach (var quest in reservation)
            {
                if (quest[0] >= '0' && quest[0] <= '9')
                {
                    vips.Add(quest);
                }
                else
                {
                    nonVips.Add(quest);
                }
            }

            foreach (var guest in vips)
            {
                Console.WriteLine(guest);
            }

            foreach (var guest in nonVips)
            {
                Console.WriteLine(guest);
            }
        }
    }
}