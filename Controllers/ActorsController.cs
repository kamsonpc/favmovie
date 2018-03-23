using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace favmovie.Controllers
{
 [Route("api/[controller]")]
    public class ActorsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
  }
}