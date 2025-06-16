using Paramore.Brighter;
using MediatrVsBrighter.Api.Database.Entities;

namespace MediatrVsBrighter.Api.Features.Brighter.GetAll
{
    public class GetAllProductsQueryHandler : RequestHandlerAsync<GetAllProductsQuery, List<ProductDto>>
    {
        private readonly IGetAllDatabaseQuery _dbQuery;

        public GetAllProductsQueryHandler(IGetAllDatabaseQuery dbQuery)
        {
            _dbQuery = dbQuery;
        }

        public override async Task<List<ProductDto>> HandleAsync(GetAllProductsQuery request, CancellationToken cancellationToken = default)
        {
            var products = await _dbQuery.GetAllAsync(cancellationToken);
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