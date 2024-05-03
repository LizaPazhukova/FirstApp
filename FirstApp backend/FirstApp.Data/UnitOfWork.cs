using FirstApp.Data.Interfaces;
using FirstApp.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Data;
using FirstApp.Data.Models;

namespace FirstApp.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        public FirstAppDBContext DbContext { get; private set; }

        private IRepository<Card>? _cardsRepository;
        private IRepository<List>? _listsRepository;

        public UnitOfWork(FirstAppDBContext context)
        {
            DbContext = context;
        }

        public IRepository<Card> Cards
        {
            get
            {
                return _cardsRepository ??= new Repository<Card>(DbContext);
            }
        }

        public IRepository<List> Lists
        {
            get
            {
                return _listsRepository ??= new Repository<List>(DbContext);
            }
        }

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return await DbContext.SaveChangesAsync(cancellationToken);
        }

        public void Dispose()
        {
            if (DbContext == null)
                return;

            if (DbContext.Database.GetDbConnection().State == ConnectionState.Open)
            {
                DbContext.Database.GetDbConnection().Close();
            }
            DbContext.Dispose();

            DbContext = null;
        }
    }
}
