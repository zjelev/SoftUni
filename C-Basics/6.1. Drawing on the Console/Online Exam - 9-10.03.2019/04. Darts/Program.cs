//https://judge.softuni.bg/Contests/Practice/Index/1538#7
using System;

namespace _04._Darts
{
    class Darts
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string field = "";
            short remainedPts = 301;
            short points = 0;
            short numSuccess = 0;
            short numFail = 0;
            string output = "";
            while (true)
            {
                field = Console.ReadLine();
                if (field == "Retire")
                {
                    break;
                }
                points = short.Parse(Console.ReadLine());
                switch (field)
                {
                    case "Double":
                        points *= 2;
                        break;
                    case "Triple":
                        points *= 3;
                        break;
                    default:
                        break;
                }
                remainedPts -= points;
                numSuccess++;
                if (remainedPts < 0)
                {
                    remainedPts += points;
                    numFail++;
                }
                else if (remainedPts == 0)
                {
                    output = string.Format("{0} won the leg with {1} shots.", name, numSuccess - numFail);
                    break;
                }
            };
            if (field == "Retire")
            {
                output = string.Format("{0} retired after {1} unsuccessful shots.", name, numFail);
            }
            Console.WriteLine(output);
        }
    }
}