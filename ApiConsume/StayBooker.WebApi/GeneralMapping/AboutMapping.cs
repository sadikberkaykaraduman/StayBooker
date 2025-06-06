using AutoMapper;
using StayBooker.DtoLayer.AboutDtos;
using StayBooker.EntityLayer.Conrete;

namespace StayBooker.WebApi.GeneralMapping
{
    public class AboutMapping : Profile
    {
        public AboutMapping() 
        {
            CreateMap<ResultAboutDto, About>().ReverseMap();
            CreateMap<GetAboutDto, About>().ReverseMap();
            CreateMap<UpdateAboutDto, About>().ReverseMap();
            CreateMap<CreateAboutDto, About>().ReverseMap();
        }
    }
}
