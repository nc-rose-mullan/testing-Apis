using Microsoft.AspNetCore.Mvc;
using TestingAPIsDemo.Services;

namespace TestingAPIsDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JokesController : ControllerBase
    {
        private readonly JokeService _gameService;
        public JokesController(JokeService gameService)
        {
            _gameService = gameService;
        }
        [HttpGet]
        public Joke Index(int id)
        {
            return _gameService.GetJokeById(id);
        }
    }
}
