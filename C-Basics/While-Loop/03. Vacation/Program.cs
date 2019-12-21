using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int tabsOpen = int.Parse(Console.ReadLine());
            decimal salary = decimal.Parse(Console.ReadLine());

            for (int i = 0; i < tabsOpen; i++)
            {
                string siteOpen = Console.ReadLine();
                if (siteOpen == "Facebook")
                {
                    salary -= 150;
                }
                else if (siteOpen == "Instagram")
                {
                    salary -= 100;
                }
                else if (siteOpen == "Reddit")
                {
                    salary -= 50;
                }

                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
            }

            if (salary > 0)
            {
                Console.WriteLine(salary);
            }
        }
    }
}
