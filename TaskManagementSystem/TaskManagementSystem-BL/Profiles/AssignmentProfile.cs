using AutoMapper;
using TaskManagementSystem_BL.DTOs.AssignmentDtos;
using TaskManagementSystem_Core.Entities;

namespace TaskManagementSystem_BL.Profiles
{
    public class AssignmentProfile : Profile
    {
        public AssignmentProfile() 
        {
            CreateMap<CreateAssignmentDto, Assignment>();
            CreateMap<UpdateAssignmentDto, Assignment>();
            CreateMap<Assignment, GetAssignmentDto>()
                .ForMember(l => l.Tag, d => d.MapFrom(t => t.Tags.Select(z => z.Name).ToList()));

        }
    }
}
