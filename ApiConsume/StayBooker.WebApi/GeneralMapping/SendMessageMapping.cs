using AutoMapper;
using StayBooker.DtoLayer.SendMessageDtos;
using StayBooker.EntityLayer.Conrete;

namespace StayBooker.WebApi.GeneralMapping
{
    public class SendMessageMapping : Profile
    {
        public SendMessageMapping() 
        {
            CreateMap<ResultSendMessageDto, SendMessage>().ReverseMap();
            CreateMap<GetSendMessageDto, SendMessage>().ReverseMap();
            CreateMap<UpdateSendMessageDto, SendMessage>().ReverseMap();
            CreateMap<CreateSendMessageDto, SendMessage>().ReverseMap();
        }
    }
}
