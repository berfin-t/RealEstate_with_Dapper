using RealEstate_Dapper_Api.Dtos.BottomGridDtos;
using RealEstate_Dapper_Api.Dtos.PopularLocationDtos;

namespace RealEstate_Dapper_Api.Repositories.Interfaces
{
    public interface IPopularLocationRepository
    {
        Task<List<ResultPopularLocationDto>> GetAllPopularLocationAsync();
        void CreatePopularLocationAsync(CreatePopularLocationDto createPopularLocationDto);
        void UpdatePopularLocationAsync(UpdatePopularLocationDto updatePopularLocationDto);
        void DeletePopularLocationAsync(int id);
        Task<GetByIdPopularLocationDto> GetPopularLocationAsync(int id);
    }
}
