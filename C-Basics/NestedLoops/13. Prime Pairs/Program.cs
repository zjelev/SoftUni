using System;

namespace _13._Prime_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstPairBegin = int.Parse(Console.ReadLine());
            int seconfPairBegin = int.Parse(Console.ReadLine());
            int firstPairInterval = int.Parse(Console.ReadLine());
            int secondPairInterval = int.Parse(Console.ReadLine());

            int firstPairEnd = firstPairBegin + firstPairInterval;
            int secondPairEnd = seconfPairBegin + secondPairInterval;

            for (int firstPair = firstPairBegin; firstPair <= firstPairEnd; firstPair++)

            {
                bool firstPairIsPrime = true;

                for (int i = 2; i <= firstPair / 2; i++)
                {
                    if (firstPair % i == 0)
                    {
                        firstPairIsPrime = false;
                        break;
                    }
                }

                for (int secondPair = seconfPairBegin; secondPair <= secondPairEnd; secondPair++)
                {
                    bool seconfPairIsPrime = true;

                    for (int i = 2; i <= secondPair / 2; i++)
                    {
                        if (secondPair % i == 0)
                        {
                            seconfPairIsPrime = false;
                            break;
                        }
                    }

                    if (firstPairIsPrime && seconfPairIsPrime)
                    {
                        Console.WriteLine("" + firstPair + secondPair);
                    }
                }
            }

        }
    }
}
