using System.Threading;
using System.Threading.Tasks;

namespace MediatrVsBrighter.Api.Database
{
    public interface IUnitOfWork
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}