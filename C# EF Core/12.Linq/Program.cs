using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using LinqDemo.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

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

            // // var songs = dbContext.Songs
            // //     // .Include(x => x.SongArtists) // joins all columns, so better use Select
            // //     // .Include(x => x.Source)
            // //     .Where(x => x.SongArtists.Count() > 3)
            // //     .Select(x => new { // anonymous class - data can not be changed afterwards
            // //         x.Id, 
            // //         x.Name,
            // //         Artists = x.SongArtists.Select(x => x.Artist.Name),
            // //         //x.Source
            // //     })
            // //     // .Where(x => x.Source.Name == "User")
            // //     .Take(25)
            // //     // .OrderByDescending(x => x.Artists.Count())
            // //     // .ThenBy(x => x.Name)
            // //     //.AsEnumerable() // materializing method - like those starting with To, First, Single, Average, Min, Max, Count, Sum
            // //     .ToList();

            // // // songs[0].Name = "Lone Survivor Changed";
            // // // dbContext.SaveChanges();

            // // // Projection makes LEFT JOIN
            // // var joinSongsWithSources = dbContext.Songs
            // //     .Select(x => new
            // //     {
            // //         SongName = x.Name,
            // //         SourceName = x.Source.Name
            // //     }).ToList();

            // // // Join makes INNER JOIN
            // // var joinSongsWithSources = dbContext.Songs.Join(
            // //     dbContext.Sources,
            // //     songs => songs.SourceId,
            // //     sources => sources.Id,
            // //     (songs, sources) => new
            // //     {
            // //         SongName = songs.Name,
            // //         SourceName = sources.Name
            // //     })
            // //     .ToList();

            // // foreach (var songSource in joinSongsWithSources)
            // // {
            // //     Console.WriteLine($"{songSource.SongName} - {songSource.SourceName}");
            // // }


            // // var songsGroups = dbContext.Songs
            // //     .GroupBy(x => x.Name.Substring(0, 1))
            // //     .Select(x => new{
            // //         FirstLetter = x.Key,
            // //         Count = x.Count(),
            // //         FirstSong = x.Min(s => s.Name)
            // //     })
            // //     .Where(x => x.Count > 100) // HAVING
            // //     .OrderByDescending(x => x.Count)
            // //     .ToList();

            // // foreach (var group in songsGroups)
            // // {
            // //     Console.WriteLine($"{group.FirstLetter} => {group.Count} - {group.FirstSong}"); // only aggregate function over the group
            // // }

            // // var songGroups = dbContext.Artists
            // //     .Where(a => a.Name.StartsWith("Z"))
            // //     // SelectMany squeeses the 2-dimensional collection (done with Select) into 1-dimentional e.g. List<List<T>> => List<T>
            // //     .SelectMany(a => //new  
            // //     //{
            // //         //Artist = a.Name,
            // //         // Song = 
            // //         a.SongArtists.Select(sa => sa.Song.Name)
            // //     //}
            // //     ).ToList();

            // // foreach (var group in songGroups)
            // // {
            // //     Console.WriteLine(
            // //     //group.Artist + " " +
            // //      string.Join(", ", group
            // //      //.Song
            // //      ));
            // // }

            // // Result(View) Models 2:30 //

            // // GroupBy without Select does not make sense
            // var groupBy2 = dbContext.Songs
            //     .GroupBy(s => new { Name = s.Name, Source = s.Source.Name })
            //     .Where(s => s.Count() > 15)
            //     .Select(s => new { s.Key, Count = s.Count() })
            //     .ToList()
            //     ;

            // foreach (var group in groupBy2)
            // {
            //     Console.WriteLine(group.Key + " " + group.Count);
            // }

            // // 2:55 IEnumerable 
            // Func<Songs, bool> predicate = x => x.Name.Length > 30;
            // // IQuerable
            // Expression<Func<Songs, bool>> predicate1 = x => x.Name.Length > 30;

            // // 3.15 Dapper - micro ORM on ADO.NET, make "pure" sql queries and save results in objects

            // 13. Advanced Querying
            // var searchString = Console.ReadLine();// "' OR 1=1 --"; // _bv%
            var dbContextOther = new MusicXContext();

            var songs = dbContext.Songs
                // With parameter
                // .FromSqlRaw("SELECT * FROM [Songs] WHERE Name LIKE {0}", searchString) // LIKE '" + searchString + "'") => SQL Injection
                // .FromSqlInterpolated($"SELECT * FROM [Songs] WHERE Name LIKE {searchString}")
                // .AsNoTracking() //when we are sure we'll not modify it and want speed
                //  // Eager loading
                // .Include(s => s.Source)
                // .Include(s => s.SongArtists)
                // .ThenInclude(x => x.Artist)
                // .ThenInclude(x => x.ArtistMetadata)
                .Where(s => s.Name.Contains("а") || s.Name.Contains("е"))
                //.UpdateFromQuery(song => new Songs {Name = song.Name + "BG"})
                // // Recommended  loading
                .Select(s => new
                {
                    s.Name,
                    SourceName = s.Source.Name,
                    Artist = s.SongArtists.Select(sa => sa.Artist.Name).FirstOrDefault()
                })
                .ToList()
                //.FirstOrDefault()
                ;

            // var changedName = "Abbi Cura Di Me Changed";
            // int deleted = 1;
            // dbContext.Database
            //     .ExecuteSqlInterpolated(
            //         // $"UPDATE [Songs] SET Name = {changedName} WHERE Name LIKE {searchString}");
            //       $"EXEC SetIsDeleted {deleted}");

            // dbContext.Entry(songs).State = EntityState.Detached;
            //songs.Name = "Осъдени души 12";
            // dbContext.Entry(songs).State = EntityState.Modified;
            //song.Source = new Sources { Name = "New source" };
            // dbContext.SongMetadata.Where(x => x.SongId <= 10).DeleteFromQuery();
            // dbContext.SaveChanges();

            // // Explicit loading - works on 1 nav. property on 1 object, used rarely
            // dbContext.Entry(songs).Reference(x => x.Source).Load();
            // dbContext.Entry(songs).Collection(x => x.SongMetadata).Load();

            // // Lazy loading - beware of N+1 problem!
            // dotnet add package Microsoft.EntityFrameworkCore.Proxies
            // OnConfiguring options.UseLazyLoadingProxies()
            // all nav properties must be virtualdotnet

            foreach (var song in songs)
            {
                Console.WriteLine(
                // {string.Join(", ", song.Artists)} - {song.Id} 
                song.Name + " "
                //+ song.Source?.Name + " "
                //+ song.SongMetadata.Count
                );
            }
        }
    }
}