using MediatrVsBrighter.Api.Database.Entities;

namespace MediatrVsBrighter.Api.Features.Mediatr.CreateProduct
{
    public interface ICreateProductRepository
    {
        Task AddAsync(Product product);
    }
}
