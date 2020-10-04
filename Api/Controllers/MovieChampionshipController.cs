using Domain.Entities.Movies;
using Domain.Entities.Movies.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Api.Controllers
{
    [Route("api/movies")]
    [ApiController]
    public class MovieChampionshipController : ControllerBase
    {
        [HttpPost("championship")]
        public IActionResult GetChampionshipResult(
            [FromServices] IMovieChampionshipService movieChampionshipService, 
            [FromBody] List<Movie> movies)
        {
            try
            {
                var response = movieChampionshipService.GetChampionshipResult(movies);

                return Ok(response);
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }
    }
}
