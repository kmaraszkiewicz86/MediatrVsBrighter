using Carter;
using FluentValidation;
using MediatrVsBrighter.Api.Database;
using MediatrVsBrighter.Api.Features.Mediatr.CreateProduct;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Configure In-Memory Database
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseInMemoryDatabase("YourProjectDb")); 

builder.Services.AddScoped<ICreateProductRepository, CreateProductRepository>();

// Configure MediatR
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(Program).Assembly));

// Configure FluentValidation
// Automatycznie rejestruje wszystkie walidatory, kt�re dziedzicz� po AbstractValidator
builder.Services.AddValidatorsFromAssembly(typeof(Program).Assembly);

// Dodaj Carter do us�ug
builder.Services.AddCarter(); // Rejestruje wszystkie CarterModules w assembly


// Add services to the container.
var app = builder.Build();

app.UseHttpsRedirection();

// U�yj Cartera do mapowania endpoint�w
app.MapCarter(); // Mapuje endpointy z zarejestrowanych CarterModules

app.Run();
