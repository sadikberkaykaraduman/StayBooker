using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StayBooker.BusinessLayer.Abstract;
using StayBooker.DtoLayer.StaffDtos;
using StayBooker.EntityLayer.Conrete;
using System.Collections.Generic;

namespace StayBooker.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffsController : ControllerBase
    {
        private readonly IStaffService _staffService;
        private readonly IMapper _mapper;

        public StaffsController(IStaffService staffService, IMapper mapper)
        {
            _staffService = staffService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllStaffs()
        {
            var staffs = _staffService.TGetAll();
            return Ok(_mapper.Map<List<ResultStaffDto>>(staffs));
        }

        [HttpGet("{id}")]
        public IActionResult GetStaffById(int id)
        {
            var staff = _staffService.TGetById(id);
            return Ok(_mapper.Map<ResultStaffDto>(staff));
        }

        [HttpPost]
        public IActionResult CreateStaff(CreateStaffDto createStaffDto)
        {
            var staff = _mapper.Map<Staff>(createStaffDto);
            _staffService.TInsert(staff);
            return Ok("Staff Was Added");
        }

        [HttpPut]
        public IActionResult UpdateStaff(UpdateStaffDto updateStaffDto)
        {
            var staff = _mapper.Map<Staff>(updateStaffDto);
            _staffService.TUpdate(staff);
            return Ok("Staff Was Updated");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteStaff(int id)
        {
            var staff = _staffService.TGetById(id);
            _staffService.TDelete(staff);
            return Ok("Staff Was Deleted");
        }

        [HttpGet("GetLast4Staff")]
        public IActionResult GetLast4Staff()
        {
            var staffs = _staffService.TGetLast4Staff();
            return Ok(_mapper.Map<List<ResultStaffDto>>(staffs));
        }
    }
}
