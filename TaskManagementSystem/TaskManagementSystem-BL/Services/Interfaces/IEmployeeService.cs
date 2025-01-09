using TaskManagementSystem_BL.DTOs.EmployeeDtos;

namespace TaskManagementSystem_BL.Services.Interfaces
{
    public interface IEmployeeService
    {
        Task<int> CreateAsync(CreateEmployeeDto dto);
        Task DeleteAsync(int id);
        Task UpdateAsync(int id, UpdateEmployeeDto dto);
        Task<IEnumerable<GetEmployeeDto>> GetAllAsync();
    }
}
