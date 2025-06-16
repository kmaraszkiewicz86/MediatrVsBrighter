using MediatrVsBrighter.Api.Database;
using MediatrVsBrighter.Api.Database.Entities;

namespace MediatrVsBrighter.Api.Features.Mediatr.CreateProduct
{
    public class CreateProductRepository(AppDbContext context) : ICreateProductRepository
    {
        public async Task AddAsync(Product product)
        {
            await context.Products.AddAsync(product);
        }
    }
}
