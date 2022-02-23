using System;

namespace _09._Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int beginNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());

            int counter = 0;
            bool numIsFound = false;

            for (int firstNum = beginNum; firstNum <= endNum; firstNum++)
            {
                if (numIsFound)
                {
                    break;
                }
                for (int secondNum = beginNum; secondNum <= endNum; secondNum++)
                {
                    counter++;
                    if (firstNum + secondNum == magicNum)
                    {
                        numIsFound = true;
                        Console.WriteLine($"Combination N:{counter} ({firstNum} + {secondNum} = {magicNum})");
                        break;
                    }
                }
            }

            if (!numIsFound)
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicNum}");
            }
        }
    }
}
