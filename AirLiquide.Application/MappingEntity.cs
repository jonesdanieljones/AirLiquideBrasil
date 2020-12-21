using AirLiquide.Application.DTO;
using AirLiquide.Domain.Entities;
using AutoMapper;

namespace AirLiquide.Application
{
    public class MappingEntity : Profile
    {
        public MappingEntity()
        {

            CreateMap<ClienteDTO, Cliente>().ReverseMap();

        }
    }
}
