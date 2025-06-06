using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StayBooker.BusinessLayer.Abstract;
using StayBooker.DtoLayer.WorkLocationDtos;
using StayBooker.EntityLayer.Conrete;
using System.Collections.Generic;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace StayBooker.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkLocationsController : ControllerBase
    {
        private readonly IWorkLocationService _workLocationService;
        private readonly IMapper _mapper;

        public WorkLocationsController(IWorkLocationService workLocationService, IMapper mapper)
        {
            _workLocationService = workLocationService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllWorklocation()
        {
            var workLocations = _workLocationService.TGetAll();
            return Ok(_mapper.Map<List<ResultWorkLocationDto>>(workLocations));
        }

        [HttpGet("{id}")]
        public IActionResult GetWorkLocationById(int id)
        {
            var workLocation = _workLocationService.TGetById(id);
            return Ok(_mapper.Map<GetWorkLocationDto>(workLocation));
        }

        [HttpPost]
        public IActionResult CreateWorkLocation(CreateWorkLocationDto createWorkLocationDto)
        {
            var workLocation = _mapper.Map<WorkLocation>(createWorkLocationDto);
            _workLocationService.TInsert(workLocation);
            return Ok("Location was added");
        }

        [HttpPut]
        public IActionResult UpdateWorkLocation(UpdateWorkLocationDto updateWorkLocationDto)
        {
            var workLocation = _mapper.Map<WorkLocation>(updateWorkLocationDto);
            _workLocationService.TUpdate(workLocation);
            return Ok("Location was updated");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteWorkLocation(int id)
        {
            var workLocation = _workLocationService.TGetById(id);
            _workLocationService.TDelete(workLocation);
            return Ok("Location was deleted");
        }
    }
}
