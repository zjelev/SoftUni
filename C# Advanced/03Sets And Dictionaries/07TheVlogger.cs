//07. The VLogger
using System;
using System.Collections.Generic;
using System.Linq;

namespace SetsAndDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
           string input = string.Empty;

           var vloggersFollow = new Dictionary<string, HashSet<string>>();
           var followersOfVlogger = new Dictionary<string, HashSet<string>>();

           while ((input = Console.ReadLine()) != "Statistics")
           {
                string[] token = input.Split(separator: new string[] {"The V-Logger" , " "},
                    StringSplitOptions.RemoveEmptyEntries);
                
                string vlogger = token[0];
                string command = token[1];
                
                if (command == "joined")
                {
                    if (!vloggersFollow.ContainsKey(vlogger))
                    {
                        vloggersFollow.Add(vlogger, new HashSet<string>());
                        followersOfVlogger.Add(vlogger, new HashSet<string>());
                    }
                }

                if (command == "followed")
                {
                    string leader = token[2];
                    
                    if ((vloggersFollow.ContainsKey(leader)) 
                        && (vloggersFollow.ContainsKey(vlogger)) 
                        && !vloggersFollow[leader].Contains(vlogger) 
                        && (vlogger != leader))
                    {
                        vloggersFollow[vlogger].Add(leader);
                        followersOfVlogger[leader].Add(vlogger);
                    }
                }
           }

           Console.WriteLine($"The V-Logger has a total of {vloggersFollow.Count} vloggers in its logs.");

           followersOfVlogger = followersOfVlogger.OrderByDescending(x => x.Value.Count).ToDictionary(x => x.Key, x => x.Value);

           int counter = 1;
           foreach (var vlogger in followersOfVlogger)
           {
            Console.WriteLine($"{counter++}. {vlogger.Key} : {vlogger.Value.Count} followers, {vloggersFollow[vlogger.Key].Count} following");
               
               if (vlogger.Key == followersOfVlogger.First().Key)
               {
                   foreach (var followers in followersOfVlogger[vlogger.Key])
                    {
                        Console.WriteLine($"*  {followers}");
                    }
               }
           }
        }
    }
}