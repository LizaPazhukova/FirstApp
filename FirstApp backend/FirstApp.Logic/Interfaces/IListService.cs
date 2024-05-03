using FirstApp.Logic.DTO;

namespace FirstApp.Logic.Interfaces
{
    public interface IListService
    {
        Task Add(ListDTO list);
    }
}
