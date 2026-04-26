using Microsoft.AspNetCore.Mvc;
using TestingAPIsDemo.Models;
using TestingAPIsDemo.Services;

namespace TestingAPIsDemo.Controllers
{
    [Route("[controller]")]
    public class JokesController : ControllerBase
    {
        private readonly JokeService _jokeService = new JokeService();

        [HttpGet("{id}")]
        public IActionResult GetJokeById(int id)
        {
            return Ok(_jokeService.GetJokeById(id));
        }
    }
}
