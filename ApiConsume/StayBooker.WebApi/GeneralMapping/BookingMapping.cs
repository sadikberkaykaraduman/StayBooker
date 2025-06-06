using AutoMapper;
using StayBooker.DtoLayer.BookingDtos;
using StayBooker.EntityLayer.Conrete;

namespace StayBooker.WebApi.GeneralMapping
{
    public class BookingMapping : Profile
    {
        public BookingMapping() 
        {
            CreateMap<ResultBookingDto, Booking>().ReverseMap();
            CreateMap<GetBookingDto, Booking>().ReverseMap();
            CreateMap<UpdateBookingDto, Booking>().ReverseMap();
            CreateMap<CreateBookingDto, Booking>().ReverseMap();
        }
    }
}
