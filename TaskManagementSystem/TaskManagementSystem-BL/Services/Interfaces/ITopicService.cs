using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagementSystem_BL.DTOs.EmployeeDtos;
using TaskManagementSystem_BL.DTOs.TopicDtos;

namespace TaskManagementSystem_BL.Services.Interfaces
{
    public interface ITopicService
    {
        Task<int> CreateAsync(CreateTopicDto dto);
        Task DeleteAsync(int id);
        Task UpdateAsync(int id, UpdateTopicDto dto);
        Task<IEnumerable<GetTopicDto>> GetAllAsync();
    }
}
