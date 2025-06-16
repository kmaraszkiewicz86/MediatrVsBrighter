using Carter;
using Database.Extensions;
using Mediatr.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDatabaseServices()
    .AddMediatrServices();

// Add Carter
builder.Services.AddCarter();

var app = builder.Build();

app.UseHttpsRedirection();
app.MapCarter();

app.Run();
