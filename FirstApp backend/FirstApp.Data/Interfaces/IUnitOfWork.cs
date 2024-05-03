using FirstApp.Data.Models;

namespace FirstApp.Data.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        FirstAppDBContext DbContext { get; }
        IRepository<Card> Cards { get; }
        IRepository<List> Lists { get; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
