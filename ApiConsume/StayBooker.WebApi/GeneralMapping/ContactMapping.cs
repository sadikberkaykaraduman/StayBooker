using AutoMapper;
using StayBooker.DtoLayer.ContactDtos;
using StayBooker.EntityLayer.Conrete;

namespace StayBooker.WebApi.GeneralMapping
{
    public class ContactMapping : Profile
    {
        public ContactMapping() 
        {
            CreateMap<ResultContactDto, Contact>().ReverseMap();
            CreateMap<UpdateContactDto, Contact>().ReverseMap();
            CreateMap<GetContactDto, Contact>().ReverseMap();
            CreateMap<CreateContactDto, Contact>().ReverseMap();
        }
    }
}
