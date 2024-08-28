using Dapper;
using RealEstate_Dapper_Api.Dtos.BottomGridDtos;
using RealEstate_Dapper_Api.Dtos.TestimonialDtos;
using RealEstate_Dapper_Api.Moodels.DapperContext;
using RealEstate_Dapper_Api.Repositories.Interfaces;

namespace RealEstate_Dapper_Api.Repositories
{
    public class TestimonialRepository : ITestimonialRepository
    {
        private readonly Context _context;

        public TestimonialRepository(Context context)
        {
            _context = context;
        }

        public async void CreateTestimonialAsync(CreateTestimonialDto createTestimonialDto)
        {
            string query = "insert into Testimonial (NameSurname, Title, Comment, Status) values (@nameSurname, @title, @comment, @status)";
            var parameters = new DynamicParameters();
            parameters.Add("@nameSurname", createTestimonialDto.NameSurname);
            parameters.Add("@title", createTestimonialDto.Title);
            parameters.Add("@comment", createTestimonialDto.Comment);
            parameters.Add("@status", createTestimonialDto.Status);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void DeleteTestimonialAsync(int id)
        {
            string query = "Delete From Testimonail Where TestimonialID=@testimonialID";
            var parameters = new DynamicParameters();
            parameters.Add("@testimonialID", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultTestimonialDto>> GetAllTestimonialAsync()
        {
            string query = "Select * From Testimonial";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultTestimonialDto>(query);

                return values.ToList();
            }
        }

        public async Task<GetByIdTestimonialDto> GetTestimonial(int id)
        {
            string query = "Select * From Testimonial Where TestimonialID=@testimonialID";
            var parameters = new DynamicParameters();
            parameters.Add("@testimoniallID", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetByIdTestimonialDto>(query, parameters);
                return values;
            }
        }

        public async void UpdateTestimonialAsync(UpdateTestimonialDto updateTestimonialDto)
        {
            string query = "Update Testimonial Set NameSurname=@nameSurname, Title=@title, Comment=@comment, Status=@status where TestimonialID=@testimonialID";
            var parameters = new DynamicParameters();
            parameters.Add("@testimonialID", updateTestimonialDto.TestimaonialID);
            parameters.Add("@nameSurname", updateTestimonialDto.NameSurname);
            parameters.Add("@title", updateTestimonialDto.Title);
            parameters.Add("@comment", updateTestimonialDto.Comment);
            parameters.Add("@status", updateTestimonialDto.Status);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
