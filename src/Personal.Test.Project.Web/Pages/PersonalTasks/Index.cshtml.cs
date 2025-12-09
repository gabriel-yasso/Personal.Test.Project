using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Personal.Test.Project.PersonalTasks.Dtos;
using Personal.Test.Project.Web.Pages.PersonalTasks.ViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Personal.Test.Project.Web.Pages.PersonalTasks
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public PersonalTaskViewModel ViewModel { get; set; }
        [BindProperty]
        public Guid Id { get; set; }
        public List<PersonalTaskDto> PersonalTasks { get; set; }
        private readonly IPersonalTaskAppService _service;
        public IndexModel(IPersonalTaskAppService service) 
        {
            _service = service;
        }
        public async Task OnGetAsync()
        {
            PersonalTasks = await _service.GetListAsync();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _service.CreateAsync(ViewModel.Title, ViewModel.Description);
            return RedirectToPage();
        }
        public async Task<IActionResult> OnPostDeleteAsync()
        {
            await _service.DeleteAsync(Id);
            return RedirectToPage();
        }
    }
}
