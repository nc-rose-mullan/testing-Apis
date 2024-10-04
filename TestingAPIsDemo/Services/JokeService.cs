using TestingAPIsDemo.Models;

namespace TestingAPIsDemo.Services
{
    public class JokeService
    {
        private readonly JokeRepository _jokeRepository;
        public JokeService(JokeRepository jokeRepository)
        {
            _jokeRepository = jokeRepository;
        }
        public Joke GetJokeById(int id)
        {
            return _jokeRepository.GetJoke(id);
        }
    }
}
