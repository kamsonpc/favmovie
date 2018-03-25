using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using favmovie.DbModels;
using favmovie.Interfaces;
using favmovie.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace favmovie.Controllers
{
    
    [Route("api/[controller]")]
    public class ActorsController : Controller
    {   
        private readonly IActorsService _actorService;
        public ActorsController(IActorsService actorService)
        {
            _actorService = actorService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var actors = Mapper.Map<List<ActorResponse>>(_actorService.GetAll());
            return Ok(actors);
        }

        [HttpGet("{actorId}")]
        public IActionResult Get(int actorId)
        {
            return Ok(Mapper.Map<ActorResponse>(_actorService.GetById(actorId)));
        }

        [HttpPost]
        public IActionResult Post([FromBody]ActorRequest actor)
        {
            _actorService.AddNewActor(Mapper.Map<Actor>(actor));
            return Ok();
        }

        [HttpPut("{actorId}")]
        public IActionResult Put([FromBody]ActorRequest actorRequest,int actorId)
        {
            var actor = Mapper.Map<Actor>(actorRequest);
            actor.Id = actorId;
            if (_actorService.UpdateActor(actor))
            {
                return NoContent();
            }
            return BadRequest();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
             _actorService.Remove(id);
            return Ok();
        }
  }
}