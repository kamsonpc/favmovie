using System.Collections.Generic;
using favmovie.DbModels;

namespace favmovie.Interfaces
{
    public interface IMoviesService
    {
        List<Movie> GetAll();

        Movie GetById(int id);

        void AddNewMovie(Movie movie);

        bool UpdateMovie(Movie movie);

        void Remove(int movieId);
    }
}