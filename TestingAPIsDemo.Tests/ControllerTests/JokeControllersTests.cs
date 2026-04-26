using Moq;
using TestingAPIsDemo.Controllers;
using TestingAPIsDemo.Services;

public class JokesControllerTests
{
    private Mock<IJokeService> _jokeServiceMock;
    private JokesController _jokeController;

    [SetUp]
    public void SetUp()
    {
        _jokeServiceMock = new Mock<IJokeService>();
        _jokeController = new JokesController(_jokeServiceMock.Object);
    }

    [Test]
    public void GetJokeById_ShouldReturnCorrectJoke()
    {
        // ARRANGE

        // ACT

        // ASSERT

    }
}