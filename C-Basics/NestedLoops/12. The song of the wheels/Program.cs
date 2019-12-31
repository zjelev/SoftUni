using System;

namespace _12._The_song_of_the_wheels
{
    class Program
    {
        static void Main(string[] args)
        {
            int controlNum = int.Parse(Console.ReadLine());

            int counter = 0;
            bool passFound = false;
            string password = string.Empty;

            for (int firstNum = 1; firstNum <= 9; firstNum++)
            {
                for (int secondNum = 1; secondNum <= 9; secondNum++)
                {
                    for (int thirdNum = 1; thirdNum <= 9; thirdNum++)
                    {
                        for (int fourthNum = 1; fourthNum <= 9; fourthNum++)
                        {
                            if ((firstNum * secondNum + thirdNum * fourthNum) == controlNum)
                            {
                                if ((firstNum < secondNum) && (thirdNum > fourthNum))
                                {
                                    Console.Write("" + firstNum + secondNum + thirdNum + fourthNum + " ");
                                    counter++;
                                    if (counter == 4)
                                    {
                                        passFound = true;
                                        password = "" + firstNum + secondNum + thirdNum + fourthNum;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
            if (passFound)
            {
                Console.Write($"Password: {password}");
            }
            else
            {
                Console.Write("No!");
            }
        }
    }
}
