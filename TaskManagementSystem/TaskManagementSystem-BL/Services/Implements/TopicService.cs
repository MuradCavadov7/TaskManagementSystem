using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TaskManagementSystem_BL.DTOs.TopicDtos;
using TaskManagementSystem_BL.Exceptions.Common;
using TaskManagementSystem_BL.Services.Interfaces;
using TaskManagementSystem_Core.Entities;
using TaskManagementSystem_Core.Repositories;

namespace TaskManagementSystem_BL.Services.Implements
{
    public class TopicService(ITopicRepository _repo , IMapper _mapper) : ITopicService
    {
        public async Task<int> CreateAsync(CreateTopicDto dto)
        {
            if (await _repo.IsExistAsync(x => x.Name == dto.Name)) throw new ExistsException<Topic>("Topic is exist");
            var topic = _mapper.Map<Topic>(dto);
            await _repo.AddAsync(topic);
            await _repo.SaveAsync();
            return topic.Id;
        }

        public async Task DeleteAsync(int id)
        {
            var topic = await _repo.GetByIdAsync(id);
            if (topic is null) throw new NotFoundException<Topic>("Topic is not found");
            _repo.Delete(topic);
            await _repo.SaveAsync();
        }

        public async Task<IEnumerable<GetTopicDto>> GetAllAsync()
        {
            var topic = await _repo.GetAll().Include(x=>x.Assignments).ToListAsync();
            return _mapper.Map<IEnumerable<GetTopicDto>>(topic);
        }

        public async Task UpdateAsync(int id, UpdateTopicDto dto)
        {
            var topic = await _repo.GetByIdAsync(id);
            if (topic is null) throw new NotFoundException<Topic>("Topic is not found");
            _mapper.Map(topic, dto);
            await _repo.SaveAsync();
        }
    }
}
