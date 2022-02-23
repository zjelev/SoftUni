using System;

namespace _04._Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int stepsGoal = 10000;
            string command = "";

            int stepsSum = 0;
            int stepsPerDay = 0;

            while (stepsSum < stepsGoal)
            {
                command = Console.ReadLine();

                if (command == "Going home")
                {
                    stepsPerDay = int.Parse(Console.ReadLine());
                    stepsSum += stepsPerDay;
                    break;
                }
                else
                {
                    stepsPerDay = int.Parse(command);
                    stepsSum += stepsPerDay;
                }
            }

            if (stepsSum >= stepsGoal)
            {
                Console.WriteLine("Goal reached! Good job!");
            }
            else
            {
                Console.WriteLine($"{stepsGoal - stepsSum} more steps to reach goal.");
            }
        }
    }
}