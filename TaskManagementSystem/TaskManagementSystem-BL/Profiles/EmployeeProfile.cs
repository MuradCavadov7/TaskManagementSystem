using AutoMapper;
using TaskManagementSystem_BL.DTOs.EmployeeDtos;
using TaskManagementSystem_Core.Entities;

namespace TaskManagementSystem_BL.Profiles
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile() 
        {
            CreateMap<CreateEmployeeDto, Employee>();
            CreateMap<UpdateEmployeeDto, Employee>();
            CreateMap<Employee,GetEmployeeDto>()
                .ForMember(x=>x.Assignments,y=>y.MapFrom(z=>z.Assignments.Select(d=>d.Title).ToList()));
         
        }
    }
}
