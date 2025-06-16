using MediatrVsBrighter.Api.Database.Entities;

namespace MediatrVsBrighter.Api.Features.Brighter.GetAll
{
    public interface IGetAllDatabaseQuery
    {
        Task<List<Product>> GetAllAsync(CancellationToken cancellationToken = default);
    }
}