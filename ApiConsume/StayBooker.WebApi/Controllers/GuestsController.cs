using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StayBooker.BusinessLayer.Abstract;
using StayBooker.DtoLayer.GuestDtos;
using StayBooker.EntityLayer.Conrete;
using System.Collections.Generic;

namespace StayBooker.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuestsController : ControllerBase
    {
        private readonly IGuestService _guestService;
        private readonly IMapper _mapper;

        public GuestsController(IGuestService guestService, IMapper mapper)
        {
            _guestService = guestService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllGuest()
        {
            var guests = _guestService.TGetAll();
            return Ok(_mapper.Map<List<ResultGuestDto>>(guests));
        }

        [HttpGet("{id}")]
        public IActionResult GetGuestById(int id)
        {
            var guest = _guestService.TGetById(id);
            return Ok(_mapper.Map<GetGuestDto>(guest));
        }

        [HttpPost]
        public IActionResult CreateGuest(CreateGuestDto createGuestDto)
        {
            var guest = _mapper.Map<Guest>(createGuestDto);
            _guestService.TInsert(guest);
            return Ok("Geust was added");
        }

        [HttpPut]
        public IActionResult UpdateGuest(UpdateGuestDto updateGuestDto)
        {
            var guest = _mapper.Map<Guest>(updateGuestDto);
            _guestService.TUpdate(guest);
            return Ok("Guest was updated");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteGuest(int id)
        {
            var guest = _guestService.TGetById(id);
            _guestService.TDelete(guest);
            return Ok("Guest was deleted");
        }
    }
}
