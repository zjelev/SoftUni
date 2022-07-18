using System.Linq;
using AutoMapper;
using AutoMapping.Models;

namespace AutoMapping
{
    public class SongsToViewModelProfile : Profile
    {
        public SongsToViewModelProfile()
        {
            this.CreateMap<Songs, SongViewModel>()
                    .ForMember(
                        x => x.Artists,
                        options => options.MapFrom(s => string.Join(", ", s.SongArtists.Select(x => x.Artist.Name))))
                    .ForMember(
                        x => x.LastModified, 
                        options => options.MapFrom(x => 
                            x.ModifiedOn ?? x.CreatedOn))
                    .ReverseMap();
        }
    }
}