using RealEstate_Dapper_Api.Dtos.EmployeeDtos;

namespace RealEstate_Dapper_Api.Repositories.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<List<ResultEmployeeDto>> GetAllEmployeeAsync();
        void CreateEmployeeAsync(CreateEmployeeDto createEmployeeDto);
        void UpdateEmployeeAsync(UpdateEmployeeDto updateEmployeeDto);
        void DeleteEmployeeAsync(int id);
        Task<GetByIdEmployeeDto> GetEmployee(int id);
    }
}
