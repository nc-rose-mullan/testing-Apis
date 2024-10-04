using System.Text.Json;

namespace TestingAPIsDemo.Models
{
    public class JokeRepository
    {
        public Joke GetJoke(int id)
        {
            var jsonJokes = File.ReadAllText("Resources\\Jokes.json");
            var jokes = JsonSerializer.Deserialize<List<Joke>>(jsonJokes);
            return jokes.First(j => j.Id == id);
        }
    }
}
