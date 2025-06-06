using AutoMapper;
using StayBooker.DtoLayer.AppUser;
using StayBooker.EntityLayer.Conrete;

namespace StayBooker.WebApi.GeneralMapping
{
    public class AppUserManager : Profile
    {
        public AppUserManager() 
        {
            CreateMap<AppUserWithWorkLocationDto, AppUser>().ReverseMap();
        }
    }
}
