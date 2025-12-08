using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Personal.Test.Project.Notes.Dtos;

namespace Personal.Test.Project.Notes
{
    public interface INotesAppService : IApplicationService
    {
        Task<List<NoteDto>> GetAllNotesAsync();
        Task<NoteDto> AddNoteAsync(string text);
        Task DeleteNoteAsync(Guid id);
    }
}
