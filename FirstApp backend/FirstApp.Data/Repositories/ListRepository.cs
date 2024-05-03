using FirstApp.Data.Interfaces;
using FirstApp.Data.Models;

namespace FirstApp.Data.Repositories
{
    public class ListRepository : Repository<List>, IListRepository
    {
        public ListRepository(FirstAppDBContext dbContext) : base(dbContext)
        {
        }
    }
}
