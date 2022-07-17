using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
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
            });
            IMapper mapper = config.CreateMapper();

            var artist = db.Artists
                // .Include(a => a.SongArtists)
                .FirstOrDefault();

            var artistViewModel = mapper.Map<ArtistWithCount>(artist);

            // db.Entry(artists).Collection(a => a.SongArtists).Load();

            // var artistWithCount = new ArtistWithCount();
            // artistWithCount.Name = artists.Name;
            // artistWithCount.SongsCount = artists.SongArtists.Count();

            Print(artistViewModel);
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