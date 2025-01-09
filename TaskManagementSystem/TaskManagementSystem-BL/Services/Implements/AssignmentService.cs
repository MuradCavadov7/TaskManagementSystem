using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TaskManagementSystem_BL.DTOs.AssignmentDtos;
using TaskManagementSystem_BL.Exceptions.Common;
using TaskManagementSystem_BL.Services.Interfaces;
using TaskManagementSystem_Core.Entities;
using TaskManagementSystem_Core.Repositories;

namespace TaskManagementSystem_BL.Services.Implements
{
    public class AssignmentService(IAssignmentRepository _repo , IMapper _mapper) : IAssignmentService
    {
        public async Task<int> CreateAsync(CreateAssignmentDto dto)
        {
            if (await _repo.IsExistAsync(x => x.Title == dto.Title || x.Description == dto.Description))
                throw new ExistsException<Assignment>("Assignment is exist");
            var assignment = _mapper.Map<Assignment>(dto);
            await _repo.AddAsync(assignment);
            await _repo.SaveAsync();
            return assignment.Id;
        }

        public async Task DeleteAsync(int id)
        {
            var assignment = await _repo.GetByIdAsync(id);
            if (assignment is null) throw new NotFoundException<Assignment>("Assignment not found");
            _repo.Delete(assignment);
            await _repo.SaveAsync();
        }

        public async Task<IEnumerable<GetAssignmentDto>> GetAllAsync()
        {
            var entity = await _repo.GetAll()
                .Include(e => e.Employee)
                .Include(t => t.Topic)
                .Include(x => x.Tags)
                .ToListAsync();
            return _mapper.Map<IEnumerable<GetAssignmentDto>>(entity);
        }

        public async Task UpdateAsync(int id, UpdateAssignmentDto dto)
        {
            var assignment = await _repo.GetByIdAsync(id);
            if (assignment is null) throw new NotFoundException<Assignment>("Assignment not found");
            _mapper.Map(dto, assignment);
            await _repo.SaveAsync();

        }
    }
}
