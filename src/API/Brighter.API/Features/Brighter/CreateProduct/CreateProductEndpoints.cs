using Carter;
using Paramore.Brighter;

namespace MediatrVsBrighter.Api.Features.Brighter.CreateProduct
{
    public class CreateProductEndpoints : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapPost("/brighter/products", async (CreateProductCommand command, IAmACommandProcessor commandProcessor) =>
            {
                await commandProcessor.SendAsync(command);
                return Results.Created($"/brighter/products", command);
            });
        }
    }
}