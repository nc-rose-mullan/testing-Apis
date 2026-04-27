using Moq;
using TestingAPIsDemo.Repositories;
using TestingAPIsDemo.Services;

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

        // ACT

        // ASSERT
       
    }
}