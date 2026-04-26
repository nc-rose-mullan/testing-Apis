using TestingAPIsDemo.Models;
using TestingAPIsDemo.Repositories;

namespace TestingAPIsDemo.Services
{
    public class JokeService
    {
        private readonly JokeRepository _jokeRepository = new JokeRepository();
        public Joke GetJokeById(int id)
        {
            return _jokeRepository.FindJokeById(id);
        }
    }
}
