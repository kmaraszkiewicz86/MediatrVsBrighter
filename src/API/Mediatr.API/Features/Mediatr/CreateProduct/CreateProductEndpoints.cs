﻿using Carter;
using MediatR;

namespace MediatrVsBrighter.Api.Features.Mediatr.CreateProduct
{
    public class CreateProductEndpoints : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapPost("/mediatr/products", async (CreateProductCommand command, IMediator mediator) =>
            {
                var result = await mediator.Send(command);
                return Results.Created($"/products/{result.Id}", result);
            });
        }
    }
}
