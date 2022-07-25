using System;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task Parallel Library(TPL)
            Task.Run(() =>
            {
                for (int i = 0; i < 1000; i++)
                {
                    Console.WriteLine(i);
                }
            }).ContinueWith((previousTask) =>
            {
                for (int i = 0; i < 1000; i++)
                {
                    Console.WriteLine(i);
                }
            });

            //for (int i = 0; i < 100; i++)
            //{
            //    //Task.Run
            //    new Thread
            //        (() =>
            //    {
            //        Thread.Sleep(100000);
            //    })
            //    .Start();
            //    ;
            //}
            Console.WriteLine();
        }
    }
}