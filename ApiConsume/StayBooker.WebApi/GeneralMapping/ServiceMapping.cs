using AutoMapper;
using StayBooker.DtoLayer.ServiceDtos;
using StayBooker.EntityLayer.Conrete;

namespace StayBooker.WebApi.GeneralMapping
{
    public class ServiceMapping : Profile
    {
        public ServiceMapping() 
        {
            CreateMap<Service, ResultServiceDto>().ReverseMap();
            CreateMap<Service, CreateServiceDto>().ReverseMap();
            CreateMap<Service, UpdateServiceDto>().ReverseMap();
            CreateMap<Service, GetServiceDto>().ReverseMap();
        }
    }
}
