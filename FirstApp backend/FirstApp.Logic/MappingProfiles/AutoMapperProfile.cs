using AutoMapper;
using FirstApp.Data.Models;
using FirstApp.Logic.DTO;

namespace FirstApp.Logic.MappingProfiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateTwoWaysMap<List, ListDTO>();
            CreateTwoWaysMap<Card, CardDTO>();
        }

        private void CreateTwoWaysMap<T1, T2>()
        {
            CreateMap<T1, T2>();
            CreateMap<T2, T1>();
        }
    }
}
