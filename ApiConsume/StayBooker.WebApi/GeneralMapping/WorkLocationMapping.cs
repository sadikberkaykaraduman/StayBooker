using AutoMapper;
using StayBooker.DtoLayer.WorkLocationDtos;
using StayBooker.EntityLayer.Conrete;

namespace StayBooker.WebApi.GeneralMapping
{
    public class WorkLocationMapping : Profile
    {
        public WorkLocationMapping() 
        {
            CreateMap<ResultWorkLocationDto, WorkLocation>().ReverseMap();
            CreateMap<GetWorkLocationDto, WorkLocation>().ReverseMap();
            CreateMap<UpdateWorkLocationDto, WorkLocation>().ReverseMap();
            CreateMap<CreateWorkLocationDto, WorkLocation>().ReverseMap();
        }
    }
}
