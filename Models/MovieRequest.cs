using System;
using System.Collections.Generic;

namespace favmovie.Models
{
    public class MovieRequest
    {
        public string Title { get; set; }
        
        public int Rate { get; set; }

        public DateTime Premiere { get; set; }

        public string Description { get; set; }  
    }
}