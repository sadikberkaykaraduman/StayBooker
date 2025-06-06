using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StayBooker.BusinessLayer.Abstract;
using StayBooker.DtoLayer.SubscribeDtos;
using StayBooker.EntityLayer.Conrete;
using System.Collections.Generic;

namespace StayBooker.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscribesController : ControllerBase
    {
        private readonly ISubscribeService _subscribeService;
        private readonly IMapper _mapper;

        public SubscribesController(ISubscribeService subscribeService, IMapper mapper)
        {
            _subscribeService = subscribeService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllSubscribes()
        {
            var subscribes = _subscribeService.TGetAll();
            return Ok(_mapper.Map<List<ResultSubscribeDto>>(subscribes));
        }

        [HttpGet("{id}")]
        public IActionResult GetSubscribeById(int id)
        {
            var subscribe = _subscribeService.TGetById(id);
            return Ok(_mapper.Map<ResultSubscribeDto>(subscribe));
        }

        [HttpPost]
        public IActionResult CreateSubscribe(CreateSubscribeDto createSubscribeDto)
        {
            var subscribe = _mapper.Map<Subscribe>(createSubscribeDto);
            _subscribeService.TInsert(subscribe);
            return Ok("Subscribe Was Added");
        }

        [HttpPut]
        public IActionResult UpdateSubscribe(UpdateSubscribeDto updateSubscribeDto)
        {
            var subscribe = _mapper.Map<Subscribe>(updateSubscribeDto);
            _subscribeService.TUpdate(subscribe);
            return Ok("Subscribe Was Updated");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteSubscribe(int id)
        {
            var subscribe = _subscribeService.TGetById(id);
            _subscribeService.TDelete(subscribe);
            return Ok("Subscribe Was Deleted");
        }
    }
}
