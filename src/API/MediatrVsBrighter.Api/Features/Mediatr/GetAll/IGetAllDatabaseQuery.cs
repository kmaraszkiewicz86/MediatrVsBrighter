using MediatrVsBrighter.Api.Database.Entities;

namespace MediatrVsBrighter.Api.Features.Mediatr.GetAll
{
    public interface IGetAllDatabaseQuery
    {
        Task<List<Product>> GetAllAsync(CancellationToken cancellationToken = default);
    }
}