using AutoMapper;
using StayBooker.DtoLayer.StaffDtos;
using StayBooker.EntityLayer.Conrete;

namespace StayBooker.WebApi.GeneralMapping
{
    public class StaffMapping : Profile
    {
        public StaffMapping()
        {
            CreateMap<Staff, ResultStaffDto>().ReverseMap();
            CreateMap<Staff, CreateStaffDto>().ReverseMap();
            CreateMap<Staff, UpdateStaffDto>().ReverseMap();
            CreateMap<Staff, GetStaffDto>().ReverseMap();
        }
    }
}
