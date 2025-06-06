using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StayBooker.BusinessLayer.Abstract;
using StayBooker.DtoLayer.ContactDtos;
using StayBooker.EntityLayer.Conrete;
using System.Collections.Generic;

namespace StayBooker.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly IContactService _contactService;
        private readonly IMapper _mapper;

        public ContactsController(IContactService contactService, IMapper mapper)
        {
            _contactService = contactService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllContact()
        {
            var contacts = _contactService.TGetAll();
            return Ok(_mapper.Map<List<ResultContactDto>>(contacts));
        }

        [HttpGet("{id}")]
        public IActionResult GetContactByid(int id)
        {
            var contact = _contactService.TGetById(id);
            return Ok(_mapper.Map<GetContactDto>(contact));
        }

        [HttpPost]
        public IActionResult CreateContact(CreateContactDto createContactDto)
        {
            var contact = _mapper.Map<Contact>(createContactDto);
            _contactService.TInsert(contact);
            return Ok("Contact was added");
        }

        [HttpPut]
        public IActionResult UpdateContact(UpdateContactDto updateContactDto)
        {
            var contact = _mapper.Map<Contact>(updateContactDto);
            _contactService.TUpdate(contact);
            return Ok("Contact was updated");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteContact(int id)
        {
            var contact = _contactService.TGetById(id);
            _contactService.TDelete(contact);
            return Ok("Contact was deleted");
        }
    }
}
