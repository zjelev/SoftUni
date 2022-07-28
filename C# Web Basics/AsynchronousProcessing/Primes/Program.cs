using System;
using System.Diagnostics;

namespace Primes
{
    class Program
    {
        static void Main(string[] args)
        {
            //new Thread(MyThreadMainMethod).Start();

            var sw = Stopwatch.StartNew();
            Console.WriteLine(
                CountPrimes(1, 30_000_000)
                //CountPrimesTwoThreads(1, 1000000)
                );
            Console.WriteLine(sw.Elapsed);
        }

        private static void MyThreadMainMethod()
        {
            //var thread1 = new Thread(incrementMyMoney);
            //thread1.Start();

            // decimal money = 0;

            //ThreadStart incrementMyMoney = () =>
            //{
            //    for (int i = 0; i < 10000; i++)
            //    {
            //        lock (lockObj)
            //        {
            //            money++;
            //        }
            //    }
            //};
        }

        private static int CountPrimes(int from, int to)
        {
            int count = 0;
            var lockObj = new object();
            // for (int i = from; i <= to; i++)
            Parallel.For(from, to + 1, (i) =>
            {
                bool isPrime = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    lock (lockObj)
                    {
                        count++;
                    }
                }
            });
            return count;
        }

        private static int CountPrimesTwoThreads(int from, int to)
        {
            object lockObj = new object();

            int count = 0;
            var thread2 = new Thread(() =>
            {
                for (int i = from; i <= to / 2; i++)
                {
                    bool isPrime = true;
                    for (int j = 2; j <= Math.Sqrt(i); j++)
                    {
                        if (i % j == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime)
                    {
                        lock (lockObj)
                        {
                            count++;
                        }
                    }
                }
            });
            thread2.Start();

            var thread3 = new Thread(() =>
            {
                for (int i = to / 2 + 1; i <= to; i++)
                {
                    bool isPrime = true;
                    for (int j = 2; j <= Math.Sqrt(i); j++)
                    {
                        if (i % j == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime)
                    {
                        lock (lockObj)
                        {
                            count++;
                        }
                    }
                }
            });
            thread3.Start();

            thread2.Join();
            thread3.Join();

            return count;
        }
    }
}