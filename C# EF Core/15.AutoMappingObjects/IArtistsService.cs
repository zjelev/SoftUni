using System.Collections.Generic;
using System.Linq;
using AutoMapping.Models;

namespace AutoMapping
{
    interface IArtistsService
    {
        IEnumerable<Program.ArtistWithCount> GetAllWithCount();
    }

    class ArtistsService : IArtistsService
    {
        private readonly MusicXContext context;

        public ArtistsService(MusicXContext context)
        {
            this.context = context;
        }
        public IEnumerable<Program.ArtistWithCount> GetAllWithCount()
        {
            var artists = context.Artists.Select(x => new Program.ArtistWithCount
            {
                Name = x.Name,
                SongsCount = x.SongArtists.Count()
            }).ToList();

            return artists;
        }
    }
}