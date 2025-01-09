using AutoMapper;
using TaskManagementSystem_BL.DTOs.TopicDtos;
using TaskManagementSystem_Core.Entities;

namespace TaskManagementSystem_BL.Profiles
{
    public class TopicProfile : Profile
    {
        public TopicProfile() 
        {
            CreateMap<CreateTopicDto, Topic>();
            CreateMap<UpdateTopicDto, Topic>();
            CreateMap<Topic,GetTopicDto>()
                .ForMember(x=>x.Assignments,y=>y.MapFrom(z=>z.Assignments.Select(d=>d.Title).ToList()));
        }
    }
}
