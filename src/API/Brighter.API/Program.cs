using Brighter.Extensions;
using Carter;
using Database.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDatabaseServices()
    .AddBrighterServices();

// Add Carter
builder.Services.AddCarter();

var app = builder.Build();

app.UseHttpsRedirection();
app.MapCarter();

app.Run();
