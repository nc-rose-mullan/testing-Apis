using Microsoft.AspNetCore.Mvc;
using Moq;
using TestingAPIsDemo.Controllers;
using TestingAPIsDemo.Models;
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
        Joke testJoke = new Joke() { Id = 100, Prompt = "Why did the someone do the something?", Response= "Because the blah blah blah lol lol lol" };

        int testId = 100;

        _jokeServiceMock.Setup(service => service.GetJokeById(testId)).Returns(testJoke);

        // ACT
        var output = _jokeController.GetJokeById(testId) as OkObjectResult;
        var joke = output?.Value as Joke;

        Assert.That(joke, Is.EqualTo(testJoke));
    }
}