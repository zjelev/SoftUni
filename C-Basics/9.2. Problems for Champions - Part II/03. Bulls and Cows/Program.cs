using System;

namespace _03.Bulls_and_Cows
{
    class Program
    {
        static void Main(string[] args)
        {
            int secret = int.Parse(Console.ReadLine());
            int targetBulls = int.Parse(Console.ReadLine());
            int targetCows = int.Parse(Console.ReadLine());
            bool solutionFound = false;
            //int guess1, guess2, guess3, guess4;
            //Console.WriteLine(secret1 + "" + "" + secret2 + "" + secret3 + "" + secret4);
            for (int guess1 = 1; guess1 <= 9; guess1++)
            {
                for (int guess2 = 1; guess2 <= 9; guess2++)
                {
                    for (int guess3 = 1; guess3 <= 9; guess3++)
                    {
                        for (int guess4 = 1; guess4 <= 9; guess4++)
                        {
                            int bullsNum = 0, cowsNum = 0;
                            int secret1 = secret / 1000;
                            int secret2 = secret / 100 % 10;
                            int secret3 = secret / 10 % 10;
                            int secret4 = secret % 10;
                            int digitToCheck1 = guess1; // to avoid
                            int digitToCheck2 = guess2; // repetitions
                            int digitToCheck3 = guess3; // of bulls
                            int digitToCheck4 = guess4; // and cows
                            //check for bulls
                            if (secret1 == digitToCheck1)
                            {
                                bullsNum++;
                                secret1 = -1;
                                digitToCheck1 = -2;
                            }
                            if (secret2 == digitToCheck2)
                            {
                                bullsNum++;
                                secret2 = -1;
                                digitToCheck2 = -2;
                            }
                            if (secret3 == digitToCheck3)
                            {
                                bullsNum++;
                                secret3 = -1;
                                digitToCheck3 = -2;
                            }
                            if (secret4 == digitToCheck4)
                            {
                                bullsNum++;
                                secret4 = -1;
                                digitToCheck4 = -2;
                            }
                            //check for cows
                            //1
                            if (secret1 == digitToCheck2)
                            {
                                cowsNum++;
                                digitToCheck2 = -2;
                            }
                            else if (secret1 == digitToCheck3)
                            {
                                cowsNum++;
                                digitToCheck3 = -2;
                            }
                            else if (secret1 == digitToCheck4)
                            {
                                cowsNum++;
                                digitToCheck4 = -2;
                            }
                            //2
                            if (secret2 == digitToCheck1)
                            {
                                cowsNum++;
                                digitToCheck1 = -2;
                            }
                            else if (secret2 == digitToCheck3)
                            {
                                cowsNum++;
                                digitToCheck3 = -2;
                            }
                            else if (secret2 == digitToCheck4)
                            {
                                cowsNum++;
                                digitToCheck4 = -2;
                            }
                            //3
                            if (secret3 == digitToCheck1)
                            {
                                cowsNum++;
                                digitToCheck1 = -2;
                            }
                            else if (secret3 == digitToCheck2)
                            {
                                cowsNum++;
                                digitToCheck2 = -2;
                            }
                            else if (secret3 == digitToCheck4)
                            {
                                cowsNum++;
                                digitToCheck4 = -2;
                            }
                            //4
                            if (secret4 == digitToCheck1)
                            {
                                cowsNum++;
                                digitToCheck1 = -2;
                            }
                            else if (secret4 == digitToCheck2)
                            {
                                cowsNum++;
                                digitToCheck2 = -2;
                            }
                            else if (secret4 == digitToCheck3)
                            {
                                cowsNum++;
                                digitToCheck3 = -2;
                            }
                            if(bullsNum == targetBulls && cowsNum == targetCows)
                            {
                                if (solutionFound)
                                {
                                    Console.Write(" ");
                                }
                                Console.Write(guess1 + "" + guess2 + "" + guess3 + "" + guess4);
                                solutionFound = true;
                            }
                        }
                    }
                }
            }
            if (!solutionFound)
            {
                Console.WriteLine("No");
            }
        }
    }
}