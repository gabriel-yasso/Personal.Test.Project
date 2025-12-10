using Personal.Test.Project.Thoughts.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Personal.Test.Project.Thoughts
{
    public class ThoughtAppService : ApplicationService, IThoughtAppService
    {
        private readonly IRepository<Thought, Guid> _thoughtRepository;
        public ThoughtAppService(IRepository<Thought, Guid> repository) 
        {
            _thoughtRepository = repository;
        }

        public async Task<List<ThoughtDto>> GetListAsync()
        {
            var thoughts = await _thoughtRepository.GetListAsync();
            var dtos = ObjectMapper.Map<List<Thought>, List<ThoughtDto>>(thoughts);
            return dtos;
        }

        public async Task<ThoughtDto> GetAsync(Guid id)
        {
            var thought =  await _thoughtRepository.GetAsync(id);
            var dto = ObjectMapper.Map<Thought, ThoughtDto>(thought);
            return dto;
        }

        public async Task<ThoughtDto> CreateAsync(CreateThoughtDto input)
        {
            var thought = new Thought(
            GuidGenerator.Create(),
            input.Content,
            input.Title
            );

            var newThough = await _thoughtRepository.InsertAsync(thought);
            var dto = ObjectMapper.Map<Thought, ThoughtDto>(newThough);
            return dto;
        }

        public async Task<ThoughtDto> UpdateAsync(Guid id, UpdateThoughtDto input)
        {
            var thought = await _thoughtRepository.GetAsync(id);
            ObjectMapper.Map(input, thought);
            var updatedThought = await _thoughtRepository.UpdateAsync(thought);
            var dto = ObjectMapper.Map<Thought, ThoughtDto>(updatedThought);
            return dto;
        }

        public async Task DeleteAsync(Guid id)
        {
            await _thoughtRepository.DeleteAsync(id);
        }
    }
}
