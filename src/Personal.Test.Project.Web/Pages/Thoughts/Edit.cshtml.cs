using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Personal.Test.Project.Thoughts;
using Personal.Test.Project.Thoughts.Dtos;
using Personal.Test.Project.Web.Pages.Thoughts.ViewModels;
using System;
using System.Threading.Tasks;

namespace Personal.Test.Project.Web.Pages.Thoughts
{
    public class EditModel : ProjectPageModel
    {
        [BindProperty]
        public EditThoughtViewModel ViewModel { get; set; }
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }
        private readonly IThoughtAppService _service;
        public EditModel(IThoughtAppService service)
        {
            _service = service;
        }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPostAsync()
        {
            var Thought = await _service.GetAsync(Id);
            var Dto = ObjectMapper.Map<ThoughtDto, UpdateThoughtDto>(Thought);
            ObjectMapper.Map(ViewModel, Dto);
            await _service.UpdateAsync(Id, Dto);

            return RedirectToPage("/Thoughts/Index");
        }
    }
}
