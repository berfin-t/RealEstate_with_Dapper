using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_Api.Dtos.PopularLocationDtos;
using RealEstate_Dapper_Api.Repositories.Interfaces;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PopularLocationsController : ControllerBase
    {
        private readonly IPopularLocationRepository _popularLocationRepository;

        public PopularLocationsController(IPopularLocationRepository popularLocationRepository)
        {
            _popularLocationRepository = popularLocationRepository;
        }

        [HttpPost]
        public async Task<IActionResult> CreatePopularLocation(CreatePopularLocationDto createPopularLocationDto)
        {
            _popularLocationRepository.CreatePopularLocationAsync(createPopularLocationDto);
            return Ok("Popüler Lokasyonlar başarılı bir şekilde eklendi");
        }

        [HttpGet]
        public async Task<IActionResult> PopularLocationList()
        {
            var values = await _popularLocationRepository.GetAllPopularLocationAsync();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPopularLocationById(int id)
        {
            var value = await _popularLocationRepository.GetPopularLocationAsync(id);
            return Ok(value);
        }

        [HttpDelete]
        public async Task<IActionResult> DeletePopularLocation(int id)
        {
            _popularLocationRepository.DeletePopularLocationAsync(id);
            return Ok("Popüler Lokasyon başarılı bir şekilde silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdatePopularLocation(UpdatePopularLocationDto updatePopularLocation)
        {
            _popularLocationRepository.UpdatePopularLocationAsync(updatePopularLocation);
            return Ok("Popüler Lokasyon başarılı bir şekilde güncellendi");
        }
    }
}
