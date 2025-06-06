using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StayBooker.BusinessLayer.Abstract;
using StayBooker.DtoLayer.SendMessageDtos;
using StayBooker.EntityLayer.Conrete;
using System.Collections.Generic;

namespace StayBooker.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SendMessageController : ControllerBase
    {
        private readonly ISendMessageService _sendService;
        private readonly IMapper _mapper;

        public SendMessageController(ISendMessageService sendService, IMapper mapper)
        {
            _sendService = sendService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllSendMessage()
        {
            var sendMessages = _sendService.TGetAll();
            return Ok(_mapper.Map<List<ResultSendMessageDto>>(sendMessages));
        }

        [HttpGet("{id}")]
        public IActionResult GetSendMessageById(int id)
        {
            var sendMessage = _sendService.TGetById(id);
            return Ok(_mapper.Map<GetSendMessageDto>(sendMessage));
        }

        [HttpPost]
        public IActionResult CreateSendMessage(CreateSendMessageDto createSendMessageDto)
        {
            var sendMessage = _mapper.Map<SendMessage>(createSendMessageDto);
            _sendService.TInsert(sendMessage);
            return Ok("Message was added");
        }

        [HttpPut]
        public IActionResult UpdateSendMessage(UpdateSendMessageDto updateSendMessageDto)
        {
            var sendMessage = _mapper.Map<SendMessage>(updateSendMessageDto);
            _sendService.TUpdate(sendMessage);
            return Ok("Message was updated");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteSendMessage(int id)
        {
            var sendMessage = _sendService.TGetById(id);
            _sendService.TDelete(sendMessage);
            return Ok("Message was deleted");
        }
    }
}
