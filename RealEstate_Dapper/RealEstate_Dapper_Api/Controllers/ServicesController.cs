using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_Api.Dtos.ServiceDtos;
using RealEstate_Dapper_Api.Repositories.Interfaces;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        private readonly IServiceRepository _serviceRepository;

        public ServicesController(IServiceRepository serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }

        [HttpPost]
        public async Task<IActionResult> CreateService(CreateServiceDto createServiceDto)
        {
            _serviceRepository.CreateServiceAsync(createServiceDto);
            return Ok("Servis başarılı bir şekilde eklendi");
        }

        [HttpGet]
        public async Task<IActionResult> ServiceyList()
        {
            var values = await _serviceRepository.GetAllServiceAsync();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetServiceById(int id)
        {
            var value = await _serviceRepository.GetServiceByIdAsync(id);
            return Ok(value);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteService(int id)
        {
            _serviceRepository.DeleteServiceAsync(id);
            return Ok("Service başarılı bir şekilde silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateService(UpdateServiceDto updateServiceDto)
        {
            _serviceRepository.UpdateServiceAsync(updateServiceDto);
            return Ok("Servis başarılı bir şekilde güncellendi");
        }
    }
}
