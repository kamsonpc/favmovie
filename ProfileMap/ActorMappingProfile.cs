using AutoMapper;
using favmovie.DbModels;
using favmovie.Models;

namespace favmovie.ProfileMap
{
    class ActorMappingProfile : Profile
    {
        public ActorMappingProfile()
        {
            CreateMap<ActorRequest, Actor>();
            CreateMap<Actor, ActorResponse>();
        }
    }
}