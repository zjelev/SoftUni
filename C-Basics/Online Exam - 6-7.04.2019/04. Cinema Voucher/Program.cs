//https://judge.softuni.bg/Contests/Practice/Index/1596#3

using System;

namespace _04._Cinema_Voucher
{
    class CinemaVoucher
    {
        static void Main(string[] args)
        {
            int voucher = int.Parse(Console.ReadLine());
            int price = 0;
            int tickets = 0;
            int all = 0;
            string purchase = Console.ReadLine();
            while (purchase != "End")
            {
                price += purchase[0];
                all++;
                if (purchase.Length > 8)
                    {
                        price += purchase[1];
                        if (price <= voucher)
                        {
                            tickets++;
                        }
                    }
                if (price > voucher)
                    {
                        all--;
                        break;
                    }
                purchase = Console.ReadLine();
            }
            Console.WriteLine(tickets);
            Console.WriteLine(all - tickets);
        }
    }
}