using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StayBooker.BusinessLayer.Abstract;
using StayBooker.DtoLayer.MessageCategoryDtos;
using StayBooker.EntityLayer.Conrete;
using System.Collections.Generic;

namespace StayBooker.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageCategorysController : ControllerBase
    {
        private readonly IMessageCategoryService _messageCategoryService;
        private readonly IMapper _mapper;

        public MessageCategorysController(IMessageCategoryService messageCategoryService, IMapper mapper)
        {
            _messageCategoryService = messageCategoryService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllMessageCategory()
        {
            var messageCategories = _messageCategoryService.TGetAll();
            return Ok(_mapper.Map<List<ResultMessageCategoryDto>>(messageCategories));
        }

        [HttpGet("{id}")]
        public IActionResult GetMessageCategoryById(int id)
        {
            var messageCategory = _messageCategoryService.TGetById(id);
            return Ok(_mapper.Map<GetMessageCategoryDto>(messageCategory));
        }

        [HttpPost]
        public IActionResult CreateMessageCategory(CreateMessageCategoryDto createMessageCategoryDto)
        {
            var messageCategory = _mapper.Map<MessageCategory>(createMessageCategoryDto);
            _messageCategoryService.TInsert(messageCategory);
            return Ok("Category was added");
        }

        [HttpPut]
        public IActionResult UpdateMessageCategory(UpdateMessageCategoryDto updateMessageCategoryDto)
        {
            var messageCategory = _mapper.Map<MessageCategory>(updateMessageCategoryDto);
            _messageCategoryService.TUpdate(messageCategory);
            return Ok("Category was updated");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteMessageCategory(int id)
        {
            var messageCategory = _messageCategoryService.TGetById(id);
            _messageCategoryService.TDelete(messageCategory);
            return Ok("Category was deleted");
        }
    }
}
