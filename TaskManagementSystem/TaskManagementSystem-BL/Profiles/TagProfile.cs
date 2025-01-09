using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagementSystem_BL.DTOs.TagDtos;
using TaskManagementSystem_Core.Entities;

namespace TaskManagementSystem_BL.Profiles
{
    public class TagProfile : Profile
    {
        public TagProfile()
        {
            CreateMap<CreateTagDto, Tag>();

        }
    }
}
