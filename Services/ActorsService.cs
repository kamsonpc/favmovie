using System.Collections.Generic;
using System.Linq;
using favmovie.DbModels;
using favmovie.Interfaces;

namespace favmovie.Services
{
    public class ActorsService : IActorsService
    {
        private readonly DatabaseContex _appDbContex;
        public ActorsService(DatabaseContex appDbContex)
        {
            _appDbContex = appDbContex;            
        }
        public void AddNewActor(Actor actor)
        {
            _appDbContex.Actor.Add(actor);
              _appDbContex.SaveChanges();
        }

        public List<Actor> GetAll()
        {
            return _appDbContex.Actor.ToList();
        }

        public Actor GetById(int id)
        {
            var actorFound = _appDbContex.Actor.Where(a => a.Id == id).SingleOrDefault();
            return actorFound;
        }

        public void Remove(int actorId)
        {
           var actorFound =  GetById(actorId);
           _appDbContex.Actor.Remove(actorFound);
           _appDbContex.SaveChanges();
        }

        public bool UpdateActor(Actor actor)
        {
            var actorFound =  GetById(actor.Id);
            actorFound.Name = actor.Name;
            actorFound.Surname = actor.Surname;
            actorFound.Age = actor.Age;
            actorFound.Bio = actor.Bio;
            _appDbContex.SaveChanges();
            return true;
        }
    }
}