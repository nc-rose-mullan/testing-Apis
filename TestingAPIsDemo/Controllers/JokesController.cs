using Microsoft.AspNetCore.Mvc;
using TestingAPIsDemo.Services;

namespace TestingAPIsDemo.Controllers
{
    [Route("[controller]")]
    public class JokesController : ControllerBase
    {
        private readonly JokeService _gameService;
        public JokesController(JokeService gameService)
        {
            _gameService = gameService;
        }
        [HttpGet("{id}")]
        public Joke GetJokeById(int id)
        {
            return _gameService.GetJokeById(id);
        }
    }
}
