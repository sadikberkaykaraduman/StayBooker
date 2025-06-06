using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StayBooker.BusinessLayer.Abstract;
using StayBooker.DtoLayer.RoomDtos;
using StayBooker.DtoLayer.ServiceDtos;
using StayBooker.EntityLayer.Conrete;
using System.Collections.Generic;

namespace StayBooker.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        private readonly IServiceService _serviceService;
        private readonly IMapper _mapper;

        public ServicesController(IServiceService serviceService, IMapper mapper)
        {
            _serviceService = serviceService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllServices()
        {
            var services = _serviceService.TGetAll();
            return Ok(_mapper.Map<List<ResultServiceDto>>(services));
        }

        [HttpGet("{id}")]
        public IActionResult GetServiceById(int id)
        {
            var service = _serviceService.TGetById(id);
            return Ok(_mapper.Map<ResultServiceDto>(service));
        }

        [HttpPost]
        public IActionResult CreateService(CreateServiceDto createServiceDto)
        {
            var service = _mapper.Map<Service>(createServiceDto);
            _serviceService.TInsert(service);
            return Ok("Service Was Added");
        }

        [HttpPut]
        public IActionResult UpdateService(UpdateServiceDto updateServiceDto)
        {
            var service = _mapper.Map<Service>(updateServiceDto);
            _serviceService.TUpdate(service);
            return Ok("Service Was Updated");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteService(int id)
        {
            var service = _serviceService.TGetById(id);
            _serviceService.TDelete(service);
            return Ok("Service Was Deleted");
        }
    }
}
