using System;

namespace _07.Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            int counter = 0;
            double totalPresentationScore = 0;

            while (input != "Finish")
            {
                double presentationScore = 0;
                for (int i = 0; i < n; i++)
                {
                    presentationScore += double.Parse(Console.ReadLine());
                }
                double averagePresentationScore = presentationScore / n;
                Console.WriteLine($"{input} - {averagePresentationScore:f2}.");
                totalPresentationScore += averagePresentationScore;
                counter++;
                input = Console.ReadLine();
            }
            Console.WriteLine($"Student's final assessment is {totalPresentationScore/counter:f2}.");
        }
    }
}
