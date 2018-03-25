using System.Collections.Generic;
using favmovie.DbModels;

namespace favmovie.Interfaces
{
    public interface IActorsService
    {
        List<Actor> GetAll();

        Actor GetById(int id);

        void AddNewActor(Actor actor);

        bool UpdateActor(Actor actor);

        void Remove(int actorId); 
    }
}