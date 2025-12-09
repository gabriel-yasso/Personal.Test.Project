using Personal.Test.Project.PersonalTasks;
using Personal.Test.Project.PersonalTasks.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Personal.Test.Project
{
    public class PersonalTaskAppService : ApplicationService, IPersonalTaskAppService
    {
        private readonly IRepository<PersonalTask, Guid> _personalTaskRepository;
        public PersonalTaskAppService(IRepository<PersonalTask, Guid> repository) 
        {
            _personalTaskRepository = repository;
        }
        public async Task<List<PersonalTaskDto>> GetListAsync()
        {
            List<PersonalTask> PersonalTasks = await _personalTaskRepository.GetListAsync();
            List<PersonalTaskDto> dtos = ObjectMapper.Map<List<PersonalTask>, List<PersonalTaskDto>>(PersonalTasks);
            return dtos;
        }
        public async Task<PersonalTaskDto> CreateAsync(string title, string description)
        {
            var newPersonalTask = await _personalTaskRepository.InsertAsync(
                new PersonalTask
                {
                    Title = title,
                    Description = description
                });
            var dto = ObjectMapper.Map<PersonalTask, PersonalTaskDto>(newPersonalTask);
            return dto;
        }

        public async Task DeleteAsync(Guid id)
        {
            await _personalTaskRepository.DeleteAsync(id);
        }
    }
}
