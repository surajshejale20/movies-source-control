using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Movies.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieService _movieService;
        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [Route("get-all-movies")]
        [HttpGet]
        public IActionResult GetAllMovies()
        {
            var result = _movieService.GetAllMovies();
            if (result.Any())
                return Ok(result);

            return NoContent();
        }
    }
}
