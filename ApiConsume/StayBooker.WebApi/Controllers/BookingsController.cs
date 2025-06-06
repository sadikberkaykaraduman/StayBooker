using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StayBooker.BusinessLayer.Abstract;
using StayBooker.DtoLayer.BookingDtos;
using StayBooker.EntityLayer.Conrete;
using System.Collections.Generic;

namespace StayBooker.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingsController : ControllerBase
    {
        private readonly IBookingService _bookingService;
        private readonly IMapper _mapper;

        public BookingsController(IBookingService bookingService, IMapper mapper)
        {
            _bookingService = bookingService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllBooking()
        {
            var booking = _bookingService.TGetAll();
            return Ok(_mapper.Map<List<ResultBookingDto>>(booking));
        }

        [HttpGet("{id}")]
        public IActionResult GetBookingById(int id)
        {
            var booking = _bookingService.TGetById(id);
            return Ok(_mapper.Map<GetBookingDto>(booking));
        }

        [HttpPost]
        public IActionResult CreateBooking(CreateBookingDto createBookingDto)
        {
            var booking = _mapper.Map<Booking>(createBookingDto);
            _bookingService.TInsert(booking);
            return Ok("Rezervation was added");
        }

        [HttpPut]
        public IActionResult UpdateBooking(UpdateBookingDto updateBookingDto)
        {
            var booking = _mapper.Map<Booking>(updateBookingDto);
            _bookingService.TUpdate(booking);
            return Ok("Rezervation was updated");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBooking(int id)
        {
            var booking = _bookingService.TGetById(id);
            _bookingService.TDelete(booking);
            return Ok("Rezervation was deleted");
        }

        [HttpGet("GetLast6Booking")]
        public IActionResult GetLast6Booking()
        {
            var booking = _bookingService.TGetLast6Booking();
            return Ok(_mapper.Map<List<ResultBookingDto>>(booking));
        }
    }
}
