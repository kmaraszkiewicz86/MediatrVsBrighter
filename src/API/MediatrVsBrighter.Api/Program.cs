using Carter;
using FluentValidation;
using MediatrVsBrighter.Api.Database;
using MediatrVsBrighter.Api.Extensions;
using Microsoft.EntityFrameworkCore;
using Paramore.Brighter.Extensions.DependencyInjection;
using CreateProductCommandBrighter = MediatrVsBrighter.Api.Features.Brighter.CreateProduct.CreateProductCommand;

var builder = WebApplication.CreateBuilder(args);

// Configure In-Memory Database
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseInMemoryDatabase("Test"));

builder.Services.AddDatabaseClasses();

// Configure MediatR
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(Program).Assembly));

// Configure FluentValidation
builder.Services.AddValidatorsFromAssembly(typeof(Program).Assembly);

// Configure Brighter
builder.Services.AddBrighter()
    .AutoFromAssemblies(typeof(CreateProductCommandBrighter).Assembly);

// Add Carter
builder.Services.AddCarter();

var app = builder.Build();

app.UseHttpsRedirection();
app.MapCarter();

app.Run();
