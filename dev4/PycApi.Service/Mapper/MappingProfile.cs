using AutoMapper;
using PycApi.Data;
using PycApi.Dto;
using System.ComponentModel;

namespace PycApi.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ContainerDto, Container>().ReverseMap();

            CreateMap<VehicleDto, Vehicle>().ReverseMap();

        }

    }
}
