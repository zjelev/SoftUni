using System;
using System.Collections.Generic;
using System.Linq;

namespace _09ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            var sideUsers = new Dictionary<string, List<string>>();

            while (input[0] != "Lumpawaroo")
            {
                string side = input[0];
                string user = input[2];
                
                if (!sideUsers.ContainsKey(side))
                {
                    sideUsers[side] = new List<string>();
                }
                else
                {
                    if (sideUsers[side].Contains(user))
                    {
                        
                    }
                    sideUsers[side].Add(user);
                }
                
                input = Console.ReadLine().Split(' ');
                
                if (input[0] == "Lumpawaroo")
                {
                    break;
                }

            }

        }
    }
}
