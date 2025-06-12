using Carter;
using FluentValidation;
using MediatrVsBrighter.Api.Database;
using Microsoft.EntityFrameworkCore;
using Paramore.Brighter.Extensions.DependencyInjection;
using CreateProductCommandBrighter = MediatrVsBrighter.Api.Features.Brighter.CreateProduct.CreateProductCommand;
using CreateProductRepositoryBrighter = MediatrVsBrighter.Api.Features.Brighter.CreateProduct.CreateProductRepository;
using CreateProductRepositoryMediatr = MediatrVsBrighter.Api.Features.Mediatr.CreateProduct.CreateProductRepository;
using ICreateProductRepositoryBrighter = MediatrVsBrighter.Api.Features.Brighter.CreateProduct.ICreateProductRepository;
using ICreateProductRepositoryMediatr = MediatrVsBrighter.Api.Features.Mediatr.CreateProduct.ICreateProductRepository;

var builder = WebApplication.CreateBuilder(args);

// Configure In-Memory Database
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseInMemoryDatabase("Test")); 

builder.Services.AddScoped<ICreateProductRepositoryMediatr, CreateProductRepositoryMediatr>();
builder.Services.AddScoped<ICreateProductRepositoryBrighter, CreateProductRepositoryBrighter>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

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
