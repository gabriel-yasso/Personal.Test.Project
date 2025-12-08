using Personal.Test.Project.Notes.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Personal.Test.Project.Notes
{
    public class NotesAppService : ApplicationService, INotesAppService
    {
        private readonly IRepository<Note, Guid> _noteRepository;
        public NotesAppService(IRepository<Note, Guid> noteRepository) 
        {
            _noteRepository = noteRepository;
        }
        public async Task<List<NoteDto>> GetAllNotesAsync()
        {
            var notes = await _noteRepository.GetListAsync();
            return ObjectMapper.Map<List<Note>, List<NoteDto>>(notes);
        }
        public async Task<NoteDto> AddNoteAsync(string text)
        {
            var AddedNote = await _noteRepository.InsertAsync(
                new Note
                {
                    Text = text
                });
            return ObjectMapper.Map<Note, NoteDto>(AddedNote);
        }

        public async Task DeleteNoteAsync(Guid id)
        {
            await _noteRepository.DeleteAsync(id);
        }
    }
}
