using System.Collections.Generic;
using favmovie.DbModels;

namespace favmovie.Interfaces
{
    public interface IActorsService
    {
        List<Actor> GetAll();
        List<Movie> GetMovies(int actorId);
        Actor GetById(int id);

        void AddNewActor(Actor actor);

        void SetActorMovie(int actorId,int movieId);

        bool UpdateActor(Actor actor);

        void Remove(int actorId); 
    }
}