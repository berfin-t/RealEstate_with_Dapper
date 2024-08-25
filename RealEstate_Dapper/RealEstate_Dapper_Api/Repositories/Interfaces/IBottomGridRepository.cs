using RealEstate_Dapper_Api.Dtos.BottomGridDtos;
using RealEstate_Dapper_Api.Dtos.CategoryDtos;

namespace RealEstate_Dapper_Api.Repositories.Interfaces
{
    public interface IBottomGridRepository
    {
        Task<List<ResultBottomGridDto>> GetAllBottomGridAsync();
        void CreateBottomGridAsync(CreateBottomGridDto createBottomGridDto);
        void UpdateBottomGridAsync(UpdateBottomGridDto updateBottomGridDto);
        void DeleteBottomGridAsync(int id);
        Task<GetByIdBottomGridDto> GetBottomGrid(int id);
    }
}
