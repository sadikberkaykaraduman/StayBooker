using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StayBooker.BusinessLayer.Abstract;
using StayBooker.DtoLayer.TestimonialDtos;
using StayBooker.EntityLayer.Conrete;
using System.Collections.Generic;

namespace StayBooker.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialsController : ControllerBase
    {
        private readonly ITestimonialService _testimonialService;
        private readonly IMapper _mapper;

        public TestimonialsController(ITestimonialService testimonialService, IMapper mapper)
        {
            _testimonialService = testimonialService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllTestimonials()
        {
            var testimonials = _testimonialService.TGetAll();
            return Ok(_mapper.Map<List<ResultTestimonialDto>>(testimonials));
        }

        [HttpGet("{id}")]
        public IActionResult GetTestimonialById(int id)
        {
            var testimonial = _testimonialService.TGetById(id);
            return Ok(_mapper.Map<ResultTestimonialDto>(testimonial));
        }

        [HttpPost]
        public IActionResult CreateTestimonial(CreateTestimonialDto createTestimonialDto)
        {
            var testimonial = _mapper.Map<Testimonial>(createTestimonialDto);
            _testimonialService.TInsert(testimonial);
            return Ok("Testimonial Was Added");
        }

        [HttpPut]
        public IActionResult UpdateTestimonial(UpdateTestimonialDto updateTestimonialDto)
        {
            var testimonial = _mapper.Map<Testimonial>(updateTestimonialDto);
            _testimonialService.TUpdate(testimonial);
            return Ok("Testimonial Was Updated");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTestimonial(int id)
        {
            var testimonial = _testimonialService.TGetById(id);
            _testimonialService.TDelete(testimonial);
            return Ok("Testimonial Was Deleted");
        }
    }
}
