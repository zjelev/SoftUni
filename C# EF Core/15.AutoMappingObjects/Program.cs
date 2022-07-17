using System;
using System.Collections.Generic;
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
            var dbContext = new MusicXContext();
            var service = new ArtistsService(new MusicXContext());
            var artists = service.GetAllWithCount();
            Print(artists);
        }

        // View
        public static void Print(IEnumerable<ArtistWithCount> artists)
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
            public int SongsCount { get; set; }
        }
    }
}