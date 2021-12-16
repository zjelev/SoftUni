using System;
using System.Diagnostics;
using System.IO;

namespace BBBusers
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader("ShkoloNameMail.txt"))
            {
                using (var writer = new StreamWriter("Output.txt"))
                {        
                    Stopwatch sw = new Stopwatch();
                    sw.Start();
                    string line = reader.ReadLine();
                    int allUsers = 0;
                    int usersWithEmailsMMI = 0;
                    while (line != null)
                    {
                        allUsers++;
                        if (line.Contains("email.com"))
                        {
                            // string pattern = @"[\w-]+@([\w-]+\.)+[\w-]+";
                            // Regex regex = new Regex(pattern);
                            // string replacement = @".";
                            // newLine = regex.Replace(pattern, replacement);
                            
                            string[] lineArr = line.Split("\t", StringSplitOptions.RemoveEmptyEntries);
                            lineArr[lineArr.Length - 2] = lineArr[lineArr.Length - 2] + "\",\"" + lineArr[lineArr.Length - 1];
                            lineArr[lineArr.Length - 1] = String.Empty;
                            string newLine = string.Join(" ", lineArr).Trim();
                            newLine = string.Concat("docker exec greenlight-v2 bundle exec rake user:create[\"", newLine, "\",\"123456\",\"user\"]");
                            writer.WriteLine(newLine);
                            usersWithEmailsMMI++;                        
                        }
                        line = reader.ReadLine();
                    }
                    sw.Stop();
                    Console.WriteLine($"From {allUsers} users with e-mails {usersWithEmailsMMI} have e-mails ending in desired e-mail");
                    Console.WriteLine($"Conversion took {sw.ElapsedTicks} timer ticks.");
                }
            }
        }
    }
}
