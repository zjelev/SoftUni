using System;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal change = decimal.Parse(Console.ReadLine());
            int changeInCents = (int)(change * 100);
            //int coinCounter = 0;

            //int twoBGN = 0;
            //int oneBGN = 0;
            //int fiftyCent = 0;
            //int twentyCent = 0;
            //int tenCent = 0;
            //int fiveCent = 0;
            //int twoCent = 0;
            //int oneCent = 0;

            //if (changeincents / 200 > 0)
            //{
            //    twobgn = changeincents / 200;
            //    changeincents -= twobgn * 200;
            //}

            //if (changeincents / 100 > 0)
            //{
            //    onebgn = changeincents / 100;
            //    changeincents -= onebgn * 100;
            //}

            //if (changeincents / 50 > 0)
            //{
            //    fiftycent = changeincents / 50;
            //    changeincents -= fiftycent * 50;
            //}

            //if (changeincents / 20 > 0)
            //{
            //    twentycent = changeincents / 20;
            //    changeincents -= twentycent * 20;
            //}

            //if (changeincents / 10 > 0)
            //{
            //    tencent = changeincents / 10;
            //    changeincents -= tencent * 10;
            //}

            //if (changeincents / 5 > 0)
            //{
            //    fivecent = changeincents / 5;
            //    changeincents -= fivecent * 5;
            //}

            //if (changeincents / 2 > 0)
            //{
            //    twocent = changeincents / 2;
            //    changeincents -= twocent * 2;
            //}

            //if (changeincents > 0)
            //{
            //    onecent = changeincents;
            //    changeincents -= onecent;
            //}

            //coinCounter = twoBGN + oneBGN + fiftyCent + twentyCent + tenCent + fiveCent + twoCent + oneCent;
            //Console.WriteLine(coinCounter);

            int currentCoin = 200;
            int sumCoins = 0;
            int currentCoinNum = 0;

            while (changeInCents > 0)
            {
                if (changeInCents / currentCoin > 0)
                {
                    currentCoinNum = changeInCents / currentCoin;
                    changeInCents -= currentCoinNum * currentCoin;
                    sumCoins += currentCoinNum;
                }
                
                currentCoin /= 2;
                if (currentCoin == 25)
                {
                    currentCoin = 20;
                }

            }

            Console.WriteLine(sumCoins);
        }
    }
}