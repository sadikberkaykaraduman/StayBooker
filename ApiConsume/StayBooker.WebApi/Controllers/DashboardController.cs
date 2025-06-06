using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StayBooker.BusinessLayer.Abstract;

namespace StayBooker.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardController : ControllerBase
    {
        private readonly IStaffService _staffService;
        private readonly IBookingService _bookingService;
        private readonly IGuestService _guestService;
        private readonly IRoomService _roomService;

        public DashboardController(IStaffService staffService, IBookingService bookingService, IGuestService guestService, IRoomService roomService)
        {
            _staffService = staffService;
            _bookingService = bookingService;
            _guestService = guestService;
            _roomService = roomService;
        }

        [HttpGet("StaffCount")]
        public IActionResult StaffCount()
        {
            var count = _staffService.TStaffCount();
            return Ok(count);
        }

        [HttpGet("BookingCount")]
        public IActionResult BookingCount()
        {
            var count = _bookingService.TBookingCount();
            return Ok(count);
        }

        [HttpGet("GusetCount")]
        public IActionResult GusetCount()
        {
            var count = _guestService.TGuestCount();
            return Ok(count);
        }

        [HttpGet("RoomCount")]
        public IActionResult RoomCount()
        {
            var count = _roomService.TRoomCount();
            return Ok(count);
        }
    }
}
