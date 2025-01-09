using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TaskManagementSystem_BL.DTOs.EmployeeDtos;
using TaskManagementSystem_BL.Exceptions.Common;
using TaskManagementSystem_BL.Services.Interfaces;
using TaskManagementSystem_Core.Entities;
using TaskManagementSystem_Core.Repositories;

namespace TaskManagementSystem_BL.Services.Implements
{
    public class EmployeeService(IEmployeeRepository _repo,IMapper _mapper) : IEmployeeService
    {
        public async Task<int> CreateAsync(CreateEmployeeDto dto)
        {
            Employee employee = _mapper.Map<Employee>(dto);
             await _repo.AddAsync(employee);
             await _repo.SaveAsync();
            return employee.Id;
        }

        public  async Task DeleteAsync(int id)
        {
            var employee =  await _repo.GetByIdAsync(id);
            if(employee is null) throw new NotFoundException<Employee>("Employee is not found");
            _repo.Delete(employee);
            await _repo.SaveAsync();
        }

        public async Task<IEnumerable<GetEmployeeDto>> GetAllAsync()
        {
            var employee = await _repo.GetAll().Include(x=>x.Assignments).ToListAsync();
            return _mapper.Map<IEnumerable<GetEmployeeDto>>(employee);
        }

        public async Task UpdateAsync(int id, UpdateEmployeeDto dto)
        {
            var employee = await _repo.GetByIdAsync(id);
            if (employee is null) throw new NotFoundException<Employee>("Employee is not found");
            _mapper.Map(dto, employee);
            await _repo.SaveAsync();
        }
    }
}
