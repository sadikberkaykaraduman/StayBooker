using AutoMapper;
using StayBooker.DtoLayer.MessageCategoryDtos;
using StayBooker.EntityLayer.Conrete;

namespace StayBooker.WebApi.GeneralMapping
{
    public class MessageCategoryMapping : Profile
    {
        public MessageCategoryMapping() 
        {
            CreateMap<ResultMessageCategoryDto, MessageCategory>().ReverseMap();
            CreateMap<GetMessageCategoryDto, MessageCategory>().ReverseMap();
            CreateMap<UpdateMessageCategoryDto, MessageCategory>().ReverseMap();
            CreateMap<CreateMessageCategoryDto, MessageCategory>().ReverseMap();
        }
    }
}
