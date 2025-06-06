using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StayBooker.BusinessLayer.Abstract;
using StayBooker.DtoLayer.AboutDtos;
using StayBooker.EntityLayer.Conrete;
using System.Collections.Generic;

namespace StayBooker.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutsController : ControllerBase
    {
        private readonly IAboutService _aboutService;
        private readonly IMapper _mapper;

        public AboutsController(IAboutService aboutService, IMapper mapper)
        {
            _aboutService = aboutService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllAbout()
        {
            var abouts = _aboutService.TGetAll();
            return Ok(_mapper.Map<List<ResultAboutDto>>(abouts));
        }

        [HttpGet("{id}")]
        public IActionResult GetAboutById(int id)
        {
            var about = _aboutService.TGetById(id);
            return Ok(_mapper.Map<GetAboutDto>(about));
        }

        [HttpPost]
        public IActionResult CreateAbout(CreateAboutDto createAboutDto)
        {
            var about = _mapper.Map<About>(createAboutDto);
            _aboutService.TInsert(about);
            return Ok("About was added");
        }

        [HttpPut]
        public IActionResult UpdateAbout(UpdateAboutDto updateAboutDto) 
        {
            var about = _mapper.Map<About>(updateAboutDto);
            _aboutService.TUpdate(about);
            return Ok("About was updated");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteRoom(int id)
        {
            var room = _aboutService.TGetById(id);
            _aboutService.TDelete(room);
            return Ok("About Was Deleted");
        }
    }
}
