//https://judge.softuni.bg/Contests/Practice/Index/1538#4

using System;

namespace _03._Gymnastics
{
    class Gymnastics
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string sport = Console.ReadLine();
            double difficulty = 9.1;
            double performance = 9.4;
            switch (country)
            {
                case "Russia":
                    {
                        switch (sport)
                        {
                            case "hoop":
                                {
                                    difficulty = 9.3;
                                    performance = 9.8;
                                }
                                break;
                            case "rope":
                                {
                                    difficulty = 9.6;
                                    performance = 9.0;
                                }
                                break;
                        }
                    }
                    break;
                case "Bulgaria":
                    {
                        switch (sport)
                        {
                            case "ribbon":
                                {
                                    difficulty = 9.6;
                                }
                                break;
                            case "hoop":
                                {
                                    difficulty = 9.55;
                                    performance = 9.75;
                                }
                                break;
                            case "rope":
                                {
                                    difficulty = 9.5;
                                }
                                break;
                        }
                    }
                    break;
                case "Italy":
                    {
                        switch (sport)
                        {
                            case "ribbon":
                                {
                                    difficulty = 9.2;
                                    performance = 9.5;
                                }
                                break;
                            case "hoop":
                                {
                                    difficulty = 9.45;
                                    performance = 9.35;
                                }
                                break;
                            case "rope":
                                {
                                    difficulty = 9.7;
                                    performance = 9.15;
                                }
                                break;
                        }
                    }
                    break;
                default:
                    break;
            }
            string output = string.Format("The team of {0} get {1:f3} on {2}.\n{3:f2}%", 
                country, difficulty + performance, sport, (20 - difficulty - performance) / 20 * 100);
            Console.WriteLine(output);
        }
    }
}