using System;

namespace _02._Football_Kit
{
    class Program
    {
        static void Main(string[] args)
        {
            string team = Console.ReadLine();
            string souvenirType = Console.ReadLine();

            int boughtNum = int.Parse(Console.ReadLine());

            double boughtSum = 0;
            double price = 0;

            if (team == "Argentina")
            {
                if (souvenirType == "flags")
                {
                    price = 3.25;
                }
                else if (true)
                {

                }
            }
        }
    }
}
