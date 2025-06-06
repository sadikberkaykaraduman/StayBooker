using AutoMapper;
using StayBooker.EntityLayer.Conrete;
using StayBooker.WebUI.Dtos.GuestDtos;
using StayBooker.WebUI.Dtos.LoginDto;
using StayBooker.WebUI.Dtos.RegisterDtos;

namespace StayBooker.WebUI.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig() 
        {
            CreateMap<CreateRegisterDto, AppUser>().ReverseMap();

            CreateMap<LoginUserDto, AppUser>().ReverseMap();

            CreateMap<CreateGuestDto, Guest>().ReverseMap();
        }
    }
}
