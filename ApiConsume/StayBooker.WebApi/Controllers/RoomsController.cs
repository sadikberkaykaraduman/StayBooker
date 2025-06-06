using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StayBooker.BusinessLayer.Abstract;
using StayBooker.DtoLayer.RoomDtos;
using StayBooker.EntityLayer.Conrete;
using System.Collections.Generic;

namespace StayBooker.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomsController : ControllerBase
    {
        private readonly IRoomService _roomService;
        private readonly IMapper _mapper;
        public RoomsController(IRoomService roomService, IMapper mapper)
        {
            _roomService = roomService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllRooms()
        {
            var rooms = _roomService.TGetAll();
            return Ok(_mapper.Map<List<ResultRoomDto>>(rooms));
        }

        [HttpGet("{id}")]
        public IActionResult GetRoomById(int id)
        {
            var room = _roomService.TGetById(id);
            return Ok(_mapper.Map<ResultRoomDto>(room));
        }

        [HttpPost]
        public IActionResult CreateRoom(CreateRoomDto createRoomDto)
        {
            var room = _mapper.Map<Room>(createRoomDto);
            _roomService.TInsert(room);
            return Ok("Room Was Added");
        }

        [HttpPut]
        public IActionResult UpdateRoom(UpdateRoomDto updateRoomDto)
        {
            var room = _mapper.Map<Room>(updateRoomDto);
            _roomService.TUpdate(room);
            return Ok("Room Was Updated");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteRoom(int id)
        {
            var room = _roomService.TGetById(id);
            _roomService.TDelete(room);
            return Ok("Room Was Deleted");
        }
    }
}
