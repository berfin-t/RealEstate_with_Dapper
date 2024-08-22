using RealEstate_Dapper_Api.Dtos.CategoryDtos;

namespace RealEstate_Dapper_Api.Repositories.Interfaces
{
    public interface ICategoryRepository
    {
        Task<List<ResultCategoryDto>> GetAllCategoryAsync();
        void CreateCategoryAsync(CreateCategoryDto createCategoryDto);
        void UpdateCategoryAsync(UpdateCategoryDto updateCategoryDto);
        void DeleteCategoryAsync(int id);
        Task<GetByIdCategoryDto> GetCategory(int id);
    }
}
