using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagementSystem_BL.DTOs.TagDtos;

namespace TaskManagementSystem_BL.Services.Interfaces
{
    public interface ITagService
    {
        Task<int> CreateAsync(CreateTagDto dto);
    }
}
