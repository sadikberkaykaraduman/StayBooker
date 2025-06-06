using AutoMapper;
using StayBooker.DtoLayer.GuestDtos;
using StayBooker.EntityLayer.Conrete;

namespace StayBooker.WebApi.GeneralMapping
{
    public class GuestMapping : Profile
    {
        public GuestMapping() 
        {
            CreateMap<ResultGuestDto, Guest>().ReverseMap();
            CreateMap<GetGuestDto, Guest>().ReverseMap();
            CreateMap<UpdateGuestDto, Guest>().ReverseMap();
            CreateMap<CreateGuestDto, Guest>().ReverseMap();
        }
    }
}
