using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_Api.Dtos.TestimonialDtos;
using RealEstate_Dapper_Api.Repositories.Interfaces;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialsController : ControllerBase
    {
        private readonly ITestimonialRepository _testimonialRepository;

        public TestimonialsController(ITestimonialRepository testimonialRepository)
        {
            _testimonialRepository = testimonialRepository;
        }

        [HttpPost]
        public async Task<IActionResult> CreateTestimonial(CreateTestimonialDto createTestimonialDto)
        {
            _testimonialRepository.CreateTestimonialAsync(createTestimonialDto);
            return Ok("Referans başarılı bir şekilde eklendi");
        }

        [HttpGet]
        public async Task<IActionResult> TestimonialList()
        {
            var values = await _testimonialRepository.GetAllTestimonialAsync();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTestimonialById(int id)
        {
            var value = await _testimonialRepository.GetTestimonialByIdAsync(id);
            return Ok(value);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteTestimonial(int id)
        {
            _testimonialRepository.DeleteTestimonialAsync(id);
            return Ok("Referans başarılı bir şekilde silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateTestimonial(UpdateTestimonialDto updateTestimonialDto)
        {
            _testimonialRepository.UpdateTestimonialAsync(updateTestimonialDto);
            return Ok("Referans başarılı bir şekilde güncellendi");
        }
    }
}
