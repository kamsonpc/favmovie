using System.Collections.Generic;

namespace favmovie.DbModels
{
    public class Actor
    {
        public int ActorId { get; set; }
        
        public string Name { get; set; }

        public string Surname { get; set; }

        public string Bio { get; set; }

        public int Age { get; set; }

        public ICollection<MovieActor> MovieActor { get; set; }
    }
}