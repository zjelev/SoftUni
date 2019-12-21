using System;

namespace _01.Blank_Receipt
{
    class Program
    {
        static void PrintReceiptHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }
        static void PrintReceitBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }
        static void PrintReceiptFooter()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("(c) SoftUni");
        }
        static void PrintReceipt()
        {
            PrintReceiptHeader();
            PrintReceitBody();
            PrintReceiptFooter();
        }
        static void Main()
        {
            PrintReceipt();
        }
    }
}