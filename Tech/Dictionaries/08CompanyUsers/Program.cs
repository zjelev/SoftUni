using System;
using System.Collections.Generic;
using System.Linq;

namespace _08CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            var companyUsers = new Dictionary<string, List<string>>();
            string[] input = Console.ReadLine().Split(' ');
            
            while (true)
            {
                string company = input[0];
                string user = input[2];
                if (!companyUsers.ContainsKey(company))
                {
                    companyUsers[company] = new List<string>();
                }
                
                if (!companyUsers[company].Contains(user))
                {
                    companyUsers[company].Add(user);
                }

                input = Console.ReadLine().Split(' ');

                if (input[0] == "End")
                {
                    break;
                }
            }

            /*foreach (var kvp in companyUsers)
            {
                Console.WriteLine($"{kvp.Key}");
                Console.WriteLine(string.Join(Environment.NewLine, kvp.Value
                .Select(x => $"-- {x}")));
            }*/

            
            Console.WriteLine(string.Join(Environment.NewLine, companyUsers
            .OrderBy(x => x.Key)
            .Select(x => $"{x.Key}{Environment.NewLine}-- {string.Join("\n-- ", x.Value)}")));
            
        }
    }
}
