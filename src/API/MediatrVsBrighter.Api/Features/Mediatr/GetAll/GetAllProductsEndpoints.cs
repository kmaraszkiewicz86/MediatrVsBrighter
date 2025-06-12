using Carter;
using MediatR;

namespace MediatrVsBrighter.Api.Features.Mediatr.GetAll
{
    public class GetAllProductsEndpoints : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapGet("/mediatr/products", async (IMediator mediator) =>
            {
                var result = await mediator.Send(new GetAllProductsQuery());
                return Results.Ok(result);
            });
        }
    }
}