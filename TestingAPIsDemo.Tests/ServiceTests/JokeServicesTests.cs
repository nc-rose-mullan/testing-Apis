using Moq;
using TestingAPIsDemo.Repositories;
using TestingAPIsDemo.Services;
using TestingAPIsDemo.Models;

internal class JokeServicesTests
{
    private Mock<JokeRepository> _jokeRepositoryMock;
    private JokeService _jokeService;

    [SetUp]
    public void Setup()
    {
        _jokeRepositoryMock = new Mock<JokeRepository>();
        _jokeService = new JokeService(_jokeRepositoryMock.Object);
    }

    [Test]
    public void GetJokeById_ShouldReturnCorrectJoke()
    {
        // ARRANGE
        Joke testJoke = new Joke() { Id = 10, Prompt = "Hi", Response = "Hello" };
        int testJokeId = 10;

        _jokeRepositoryMock.Setup(repo => repo.FindJokeById(testJokeId)).Returns(testJoke);

        // ACT
        Joke output = _jokeService.GetJokeById(testJokeId);

        // ASSERT
        Assert.That(output, Is.EqualTo(testJoke));
    }
}