using MediatR;

namespace MediatrVsBrighter.Api.Features.Mediatr.GetAll
{
    public class GetAllProductsQueryHandler(IGetAllDatabaseQuery dbQuery) : IRequestHandler<GetAllProductsQuery, List<ProductDto>>
    {
        public async Task<List<ProductDto>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            var products = await dbQuery.GetAllAsync(cancellationToken);
            return products.Select(p => new ProductDto
            {
                Id = p.Id,
                Name = p.Name,
                Price = p.Price,
                Description = p.Description
            }).ToList();
        }
    }
}