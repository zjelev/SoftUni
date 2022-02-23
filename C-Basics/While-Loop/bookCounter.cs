using System;

namespace While_Loop___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string bookSearched = Console.ReadLine();
            int capacity = int.Parse(Console.ReadLine());

            bool isFound = false;

            string picked = Console.ReadLine();
            int bookCounter = 0;

            while (bookCounter < capacity)
            {
                if (bookSearched == picked)
                {
                    isFound = true;
                    break;
                }
                picked = Console.ReadLine();
                bookCounter++;
            }

            if (isFound)
            {
                Console.WriteLine($"You checked {bookCounter} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {bookCounter} books.");
            }
        }
    }
}