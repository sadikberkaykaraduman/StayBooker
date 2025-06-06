using AutoMapper;
using StayBooker.DtoLayer.SubscribeDtos;
using StayBooker.EntityLayer.Conrete;

namespace StayBooker.WebApi.GeneralMapping
{
    public class SubscribeMapping : Profile
    {
        public SubscribeMapping()
        {
            CreateMap<Subscribe, ResultSubscribeDto>().ReverseMap();
            CreateMap<Subscribe, CreateSubscribeDto>().ReverseMap();
            CreateMap<Subscribe, UpdateSubscribeDto>().ReverseMap();
            CreateMap<Subscribe, GetSubscribeDto>().ReverseMap();
        }
    }
}
