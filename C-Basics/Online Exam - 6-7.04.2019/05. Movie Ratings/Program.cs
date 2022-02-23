//https://judge.softuni.bg/Contests/Practice/Index/1596#4

using System;

namespace _05._Movie_Ratings
{
    class Program
    {
        static void Main(string[] args)
        {
            byte numMovies = byte.Parse(Console.ReadLine());
            string bestMovie = "";
            string worstMovie = "";
            float highestRating = 1;
            float lowestRating = 10;
            float totalRating = 0;
            for (int i = 0; i < numMovies; i++)
            {
                string movie = Console.ReadLine();
                float rating = float.Parse(Console.ReadLine());
                totalRating += rating;
                if (rating > highestRating)
                {
                    highestRating = rating;
                    bestMovie = movie;
                }
                if (rating < lowestRating)
                {
                    lowestRating = rating;
                    worstMovie = movie;
                }
            }
            string output = string.Format($"{bestMovie} is with highest rating: {highestRating:f1}\n" +
                $"{worstMovie} is with lowest rating: {lowestRating:f1}\n" +
                $"Average rating: {totalRating / numMovies:f1}");
            Console.WriteLine(output);
        }
    }
}