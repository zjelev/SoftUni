using System;

namespace _01.Distance
{
    class Program
    {
        static void Main(string[] args)
        {   /*
            decimal v = int.Parse(Console.ReadLine()) / 60m;
            decimal t1 = int.Parse(Console.ReadLine()) / 60m;
            decimal t2 = int.Parse(Console.ReadLine()) / 60m;
            decimal t3 = int.Parse(Console.ReadLine()) / 60m;
            decimal v2 = v + v / 10m;
            decimal v3 = v2 - v2 / 20m;
            decimal sHours = v * t1 + v2 * t2 + v3 * t3;
            Console.WriteLine("{0:f2}", sHours * 60m);
            */
            string initSpeedstr = Console.ReadLine();
            string firstIntervalstr = Console.ReadLine();
            string secondIntervalstr = Console.ReadLine();
            string thirdIntervalstr = Console.ReadLine();
            decimal minHour = 60m;
            int initSpeed = int.Parse(initSpeedstr);
            int firstInterval = int.Parse(firstIntervalstr);
            int secondInterval = int.Parse(secondIntervalstr);
            int thirdInterval = int.Parse(thirdIntervalstr);
            decimal firstIntervalHours = firstInterval / minHour;
            decimal firstDist = initSpeed * firstIntervalHours;
            decimal speedAfterIncrease = initSpeed + (initSpeed * 10 / 100m);
            decimal secondIntervalHours = secondInterval / minHour;
            decimal secondDistance = speedAfterIncrease * secondIntervalHours;
            decimal speedAfterDecrease = speedAfterIncrease - (speedAfterIncrease * 5 / 100m);
            decimal thirdIntervalHours = thirdInterval / minHour;
            decimal thirdDistance = speedAfterDecrease * thirdIntervalHours;
            decimal finalDistance = firstDist + secondDistance + thirdDistance;
            string finalResult = string.Format("{0:f2}", finalDistance);
            Console.WriteLine(finalResult);
            //*
        }
    }
}
//Console.WriteLine(string.Format("{0:f2}", (v* t1 + v*1.1m*t2 + v*1.1m*0.95m*t3) * minHour));