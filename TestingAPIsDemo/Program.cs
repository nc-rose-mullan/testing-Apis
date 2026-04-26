using TestingAPIsDemo.Services;
using TestingAPIsDemo.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddScoped<JokeService>();
builder.Services.AddScoped<JokeRepository>();


var app = builder.Build();

app.MapControllers();

app.Run();
