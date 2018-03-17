using System.Collections.Generic;
using System.Linq;
using favmovie.DbModels;
using favmovie.Interfaces;

namespace favmovie.Services
{
    class MoviesService : IMoviesService
    {
        private static MoviesService _instance;
        private List<Movie> _movies;

        public MoviesService()
        {
            _movies = new List<Movie>{
                new Movie()
                {
                  Id = 1,
                   Title = "Super film",
                   Year = 1998,
                 },
                 new Movie()
                 {
                  Id = 2,
                  Title = "Super film2",
                  Year = 1998,
                },
            };
        }

        public MoviesService Instance()
        {
            if(_instance == null)
            {
                _instance = new MoviesService();
            }
            return _instance;
        }

        public void AddNewMovie(Movie movie)
        {
            _movies.Add(movie);
        }

        public List<Movie> GetAll()
        {
            return _movies;
        }

        public Movie GetById(int id)
        {
           Movie movieFound = _movies.Where(movie => movie.Id == id).SingleOrDefault();
           return movieFound;
        }

        public void Remove(int movieId)
        {
           Movie movieToRemove = GetById(movieId);
           _movies.Remove(movieToRemove);        
        }

        public bool UpdateMovie(Movie movie)
        {
            Movie movieToUpdate = GetById(movie.Id);
            movieToUpdate.Title = movie.Title;
            movieToUpdate.Year = movieToUpdate.Year;
            return true;
        }
    }
}
