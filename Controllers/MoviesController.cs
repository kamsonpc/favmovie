using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using favmovie.Interfaces;

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
        // GET api/values
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_movieService.GetAll());
        }

        // GET api/values/5
        [HttpGet("{movieId}")]
        public IActionResult Get(int movieId)
        {
            return Ok(_movieService.GetById(movieId));
        }
        
        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
