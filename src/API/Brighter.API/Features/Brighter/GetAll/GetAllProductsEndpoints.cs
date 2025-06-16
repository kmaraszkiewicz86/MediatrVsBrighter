using Carter;
using Paramore.Brighter;

namespace MediatrVsBrighter.Api.Features.Brighter.GetAll
{
    public class GetAllProductsEndpoints : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapGet("/brighter/products", async (IAmACommandProcessor commandProcessor) =>
            {
                var result = await commandProcessor.CallAsync<GetAllProductsQuery, List<ProductDto>>(new GetAllProductsQuery());
                return Results.Ok(result);
            });
        }
    }
}