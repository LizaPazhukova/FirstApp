using AutoMapper;
using FirstApp.Data.Interfaces;
using FirstApp.Data.Models;
using FirstApp.Logic.DTO;
using FirstApp.Logic.Interfaces;

namespace FirstApp.Logic.Services
{
    public class ListService : IListService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public ListService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ListDTO>> GetAll()
        {
            var lists = await _unitOfWork.Lists.GetAllAsync();
           return _mapper.Map<IEnumerable<ListDTO>>(lists);
        }

        public async Task Add(ListDTO listDTO)
        {
            var list = _mapper.Map<List>(listDTO);
            await _unitOfWork.Lists.AddAsync(list);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
