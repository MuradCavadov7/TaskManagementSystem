using TaskManagementSystem_BL.DTOs.AssignmentDtos;
using TaskManagementSystem_BL.DTOs.EmployeeDtos;

namespace TaskManagementSystem_BL.Services.Interfaces
{
    public interface IAssignmentService
    {
        Task<int> CreateAsync(CreateAssignmentDto dto);
        Task DeleteAsync(int id);
        Task UpdateAsync(int id, UpdateAssignmentDto dto);
        Task<IEnumerable<GetAssignmentDto>> GetAllAsync();
    }
}
