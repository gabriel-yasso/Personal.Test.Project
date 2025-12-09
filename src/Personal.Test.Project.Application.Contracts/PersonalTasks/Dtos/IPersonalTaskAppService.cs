using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Personal.Test.Project.PersonalTasks.Dtos
{
    public interface IPersonalTaskAppService : IApplicationService
    {
        Task<List<PersonalTaskDto>> GetListAsync();
        Task<PersonalTaskDto> CreateAsync(string title, string description);
        Task DeleteAsync(Guid id);
    }
}
