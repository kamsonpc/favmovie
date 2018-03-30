using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using favmovie.Interfaces;
using favmovie.DbModels;
using AutoMapper;
using favmovie.Models;

namespace favmovie.Controllers
{
    [Route("api/[controller]")]
    public class MoviesController : Controller
    {
        private readonly IMoviesService _movieService;

        public MoviesController(IMoviesService moviesService)
        {
            _movieService = moviesService;
        }
        
        [HttpGet]
        public IActionResult GetAll()
        {
            var movies = Mapper.Map<List<MovieResponse>>(_movieService.GetAll());
            return Ok(movies);
        }

        [HttpGet("{movieId}")]
        public IActionResult Get(int movieId)
        {
            return Ok(Mapper.Map<MovieResponse>(_movieService.GetById(movieId)));
        }
        
        [HttpPost]
        public IActionResult Post([FromBody]MovieRequest movie)
        {
            _movieService.AddNewMovie(Mapper.Map<Movie>(movie));
            return Ok();
        }

        // PUT api/values/5
        [HttpPut("{movieId}")]
        public IActionResult Put([FromBody]MovieRequest movieRequest,int movieId)
        {
            var movie = Mapper.Map<Movie>(movieRequest);
            movie.MovieId = movieId;
            if (_movieService.UpdateMovie(movie))
            {
                return NoContent();
            }

            return BadRequest();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
             _movieService.Remove(id);
            return Ok();
        }
    }
}
