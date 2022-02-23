//https://judge.softuni.bg/Contests/Practice/Index/1538#3

using System;

namespace _02._Skeleton
{
    class Skeleton
    {
        static void Main(string[] args)
        {
            int min = int.Parse(Console.ReadLine());
            int sec = int.Parse(Console.ReadLine());
            double lenght = double.Parse(Console.ReadLine());
            int sec100m = int.Parse(Console.ReadLine());

            int controlTime = min * 60 + sec;
            double timesReduced = lenght / 120;
            double secondsReduced = timesReduced * 2.5d;
            double timeOfAthlete = lenght / 100 * sec100m - secondsReduced;
            string output = string.Empty;
            if (timeOfAthlete >  controlTime)
            {
                output = string.Format("No, Marin failed! He was {0:f3} second slower.", 
                    timeOfAthlete - controlTime);
            }
            else
            {
                output = string.Format("Marin Bangiev won an Olympic quota!\nHis time is {0:f3}.", timeOfAthlete);
            }
            Console.WriteLine(output);
        }
    }
}