using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using AutoMapping.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace AutoMapping
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            var db = new MusicXContext();
            // var service = new ArtistsService(db);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Artists, ArtistWithCount>();
                cfg.AddProfile(new SongsToViewModelProfile());
            });
            IMapper mapper = config.CreateMapper();

            var dbSong = db.Songs.Skip(9).ProjectTo<SongViewModel>(config).FirstOrDefault();
            var song = mapper.Map<SongViewModel>(dbSong);
            Print(song);

            // // Reverse mapping -> used when reading data from client
            // var inputModel = new SongViewModel { Name = "Test132", SourceName = "VBox7" };
            // var song = mapper.Map<Songs>(inputModel);
            // Print(song);
            // db.Songs.Add(song);
            // db.SaveChanges();

            // var artist = db.Artists
            //     // .Include(a => a.SongArtists)
            //     .FirstOrDefault();

            // var artistViewModel = mapper.Map<ArtistWithCount>(artist);

            // // Without Automapper
            // var artists = db.Songs.Select(x => new SongViewModel
            // {
            //     Name = x.Name,
            //     Artists = string.Join(", ", x.SongArtists.Select(x => x.Artist.Name))
            // }).Take(10).ToList();

            // // With AutoMapper
            // ArtistWithCount artistViewModel = db.Artists.Where(x => x.Id == 10)
            //     .ProjectTo<ArtistWithCount>(config) // == Select
            //     .FirstOrDefault();


            // db.Entry(artists).Collection(a => a.SongArtists).Load();

            // var artistWithCount = new ArtistWithCount();
            // artistWithCount.Name = artists.Name;
            // artistWithCount.SongsCount = artists.SongArtists.Count();

            // Print(artistViewModel);
        }

        // View
        public static void Print(object artists)
        {
            // foreach (var artist in artists)
            // {
            //     Console.WriteLine($"~~{artist.Name}~~ => {artist.SongsCount} song{(artist.SongsCount != 1 ? "s" : string.Empty)}");
            // }
            Console.WriteLine(JsonConvert.SerializeObject(artists, Formatting.Indented));
        }

        public class ArtistWithCount // DAO DTO
        {
            public string Name { get; set; }
            public int SongArtistsCount { get; set; }
            public DateTime CreatedOn { get; set; }
        }
    }
}