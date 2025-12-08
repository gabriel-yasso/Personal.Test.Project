using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Personal.Test.Project.Notes;
using Personal.Test.Project.Notes.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Personal.Test.Project.Web.Pages.Notes
{
    public class IndexModel : PageModel
    {
        private readonly INotesAppService _service;
        public List<NoteDto> Notes { get; set; }
        public string Id { get; set; }
        public string Text { get; set; }

        public IndexModel(INotesAppService service)
        {
            _service = service;
        }
        public async Task OnGetAsync()
        {
            Notes = await _service.GetAllNotesAsync();
        }
        public async Task<IActionResult> OnPostAsync(string newNote)
        {
            await _service.AddNoteAsync(newNote);
            return RedirectToPage("/Notes/Index");
        }

        public async Task<IActionResult> OnPostDelete(Guid id)
        {
            await _service.DeleteNoteAsync(id);
            return RedirectToPage("/Notes/Index");
        }
    }
}
