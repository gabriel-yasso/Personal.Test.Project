using Personal.Test.Project.Thoughts.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Personal.Test.Project.Thoughts
{
    public interface IThoughtAppService : IApplicationService
    {
        Task<List<ThoughtDto>> GetListAsync();
        Task<ThoughtDto> GetAsync(Guid id);
        Task<ThoughtDto> CreateAsync(CreateThoughtDto input);
        Task DeleteAsync(Guid id);
        Task<ThoughtDto> UpdateAsync(Guid id, UpdateThoughtDto input);
    }
}
