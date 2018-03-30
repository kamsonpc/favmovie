using System;
using System.Collections.Generic;

namespace favmovie.DbModels
{
    public class Movie
    {
        public int MovieId { get; set; }

        public string Title { get; set; }
        
        public int Rate { get; set; }

        public DateTime Premiere { get; set; }

        public string Description { get; set; }

        public ICollection<MovieActor> MovieActor { get; set; }



    }
}
