using FirstApp.Data.Interfaces;
using FirstApp.Data.Models;

namespace FirstApp.Data.Repositories
{
    public class CardRepository : Repository<Card>, ICardRepository
    {
        public CardRepository(FirstAppDBContext dbContext) : base(dbContext)
        {
        }
    }
}
