using MediatrVsBrighter.Api.Database.Entities;

namespace MediatrVsBrighter.Api.Features.Brighter.CreateProduct
{
    public interface ICreateProductRepository
    {
        Task AddAsync(Product product);
    }
}