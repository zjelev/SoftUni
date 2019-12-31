using System;

namespace _01._Numbers_N_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int numResults = 0;
            int x1 = 0;
            int x2 = 0;
            int x3 = 0;
            int x4 = 0;
            int x5 = 0;
            int sum = 0;

            for (x1 = 0; x1 <= length; x1++)
            {
                for (x2 = 0; x2 <= length; x2++)
                {
                    for (x3 = 0; x3 <= length; x3++)
                    {
                        for (x4 = 0; x4 <= length; x4++)
                        {
                            if (sum == length)
                            {
                                numResults++;
                                break;
                            }
                            for (x5 = 0; x5 <= length; x5++)
                            {
                                sum = x1 + x2 + x3 + x4 + x5;
                                if (sum == length)
                                {
                                    numResults++;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine(numResults);
        }
    }
}