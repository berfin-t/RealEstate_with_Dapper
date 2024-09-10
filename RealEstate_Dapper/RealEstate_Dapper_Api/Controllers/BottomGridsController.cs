using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_Api.Dtos.BottomGridDtos;
using RealEstate_Dapper_Api.Repositories.Interfaces;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BottomGridsController : ControllerBase
    {
        private readonly IBottomGridRepository _bottomGridRepository;

        public BottomGridsController(IBottomGridRepository bottomGridRepository)
        {
            _bottomGridRepository = bottomGridRepository;
        }

        [HttpPost]
        public async Task<IActionResult> CreateBottomGrid(CreateBottomGridDto createBottomGridDto)
        {
            _bottomGridRepository.CreateBottomGridAsync(createBottomGridDto);
            return Ok("Alt Izgara başarılı bir şekilde eklendi");
        }

        [HttpGet]
        public async Task<IActionResult> BottomGridList()
        {
            var values = await _bottomGridRepository.GetAllBottomGridAsync();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBottomGridById(int id)
        {
            var value = await _bottomGridRepository.GetBottomGridByIdAsync(id);
            return Ok(value);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteBottomGrid(int id)
        {
            _bottomGridRepository.DeleteBottomGridAsync(id);
            return Ok("Alt Izgara başarılı bir şekilde silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBottomGrid(UpdateBottomGridDto updateBottomGridDto)
        {
            _bottomGridRepository.UpdateBottomGridAsync(updateBottomGridDto);
            return Ok("Alt Izgara başarılı bir şekilde güncellendi");
        }
    }
}
