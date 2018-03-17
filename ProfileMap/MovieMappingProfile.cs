using AutoMapper;
using favmovie.DbModels;
using favmovie.Models;

namespace favmovie.ProfileMap
{
    class MovieMappingProfile : Profile
    {
        public MovieMappingProfile()
        {
            CreateMap<MovieRequest, Movie>();
            CreateMap<Movie, MovieResponse>();
        }
    }
}