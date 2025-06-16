using MediatrVsBrighter.Api.Database;
using MediatrVsBrighter.Api.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace MediatrVsBrighter.Api.Features.Brighter.GetAll
{
    public class GetAllDatabaseQuery : IGetAllDatabaseQuery
    {
        private readonly AppDbContext _context;

        public GetAllDatabaseQuery(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Product>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            return await _context.Products.ToListAsync(cancellationToken);
        }
    }
}