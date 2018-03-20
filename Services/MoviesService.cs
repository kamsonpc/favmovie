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
        private readonly DatabaseContex _appDbContex;
        public MoviesService(DatabaseContex appDbContex)
        {
            _appDbContex = appDbContex;
        }



        public void AddNewMovie(Movie movie)
        {
            _appDbContex.Movie.Add(movie);
            _appDbContex.SaveChanges();
        }

        public List<Movie> GetAll()
        {
            return _appDbContex.Movie.ToList();
        }

        public Movie GetById(int id)
        {
           Movie movieFound = _appDbContex.Movie.Where(movie => movie.Id == id).SingleOrDefault();
           return movieFound;
        }

        public void Remove(int movieId)
        {
           Movie movieToRemove = GetById(movieId);
          _appDbContex.Movie.Remove(movieToRemove);        
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
