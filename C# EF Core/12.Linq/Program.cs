using System;
using System.Linq;
using LinqDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace LinqDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // dotnet add package Microsoft.EntityFrameworkCore.SqlServer -v 3.1.3
            // dotnet add package Microsoft.EntityFrameworkCore.Design -v 3.1.3
            // dotnet ef dbcontext scaffold "Server=.\SQLEXPRESS; Database=MusicX;Integrated Security=true;" Microsoft.EntityFrameworkCore.SqlServer -o Models

            Console.OutputEncoding = System.Text.Encoding.Unicode;
            var dbContext = new MusicXContext();

            var songs = dbContext.Songs
                // .Include(x => x.SongArtists) // joins all columns, so better use Select
                // .Include(x => x.Source)
                .Where(x => x.SongArtists.Count() > 3)
                .Select(x => new { // anonymous class - data can not be changed afterwards
                    x.Id, 
                    x.Name,
                    Artists = x.SongArtists.Select(x => x.Artist.Name),
                    //x.Source
                })
                // .Where(x => x.Source.Name == "User")
                .Take(25)
                // .OrderByDescending(x => x.Artists.Count())
                // .ThenBy(x => x.Name)
                //.AsEnumerable() // materializing method - like those starting with To, First, Single, Average, Min, Max, Count, Sum
                .ToList();

            // songs[0].Name = "Lone Survivor Changed";
            // dbContext.SaveChanges();

            foreach (var song in songs)
            {
                Console.WriteLine($"{string.Join(", ", song.Artists)} - {song.Id} {song.Name}");
            }
        }
    }
}
