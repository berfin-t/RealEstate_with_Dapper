using RealEstate_Dapper_Api.Dtos.CategoryDtos;
using RealEstate_Dapper_Api.Dtos.ServiceDtos;

namespace RealEstate_Dapper_Api.Repositories.Interfaces
{
    public interface IServiceRepository
    {
        Task<List<ResultServiceDto>> GetAllServiceAsync();
        void CreateServiceAsync(CreateServiceDto createServiceDto);
        void UpdateServiceAsync(UpdateServiceDto updateServiceDto);
        void DeleteServiceAsync(int id);
        Task<GetByIdServiceDto> GetServiceByIdAsync(int id);
    }
}
