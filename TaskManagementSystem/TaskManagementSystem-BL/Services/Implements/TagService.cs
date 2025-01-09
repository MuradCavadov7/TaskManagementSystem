using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagementSystem_BL.DTOs.TagDtos;
using TaskManagementSystem_BL.Exceptions.Common;
using TaskManagementSystem_BL.Services.Interfaces;
using TaskManagementSystem_Core.Entities;
using TaskManagementSystem_Core.Repositories;

namespace TaskManagementSystem_BL.Services.Implements
{
    public class TagService(ITagRepository _repo, IMapper _mapper) : ITagService
    {
        public async Task<int> CreateAsync(CreateTagDto dto)
        {
            if (await _repo.IsExistAsync(x => x.Name == dto.Name)) throw new ExistsException<Tag>(" IsExist");
            var tags = _mapper.Map<Tag>(dto);
            await _repo.AddAsync(tags);
            await _repo.SaveAsync();
            return tags.Id;


        }
    }
}
