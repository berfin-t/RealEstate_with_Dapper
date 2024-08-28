using RealEstate_Dapper_Api.Dtos.BottomGridDtos;
using RealEstate_Dapper_Api.Dtos.TestimonialDtos;

namespace RealEstate_Dapper_Api.Repositories.Interfaces
{
    public interface ITestimonialRepository
    {
        Task<List<ResultTestimonialDto>> GetAllTestimonialAsync();
        void CreateTestimonialAsync(CreateTestimonialDto createTestimonialDto);
        void UpdateTestimonialAsync(UpdateTestimonialDto updateTestimonialDto);
        void DeleteTestimonialAsync(int id);
        Task<GetByIdTestimonialDto> GetTestimonial(int id);
    }
}
