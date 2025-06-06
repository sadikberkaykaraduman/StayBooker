using AutoMapper;
using StayBooker.DtoLayer.RoomDtos;
using StayBooker.EntityLayer.Conrete;

namespace StayBooker.WebApi.GeneralMapping
{
    public class RoomMapping : Profile
    {
        public RoomMapping() 
        {
            CreateMap<Room, ResultRoomDto>().ReverseMap();
            CreateMap<Room, CreateRoomDto>().ReverseMap();
            CreateMap<Room, UpdateRoomDto>().ReverseMap();
            CreateMap<Room, GetRoomDto>().ReverseMap();
        }
    }
}
