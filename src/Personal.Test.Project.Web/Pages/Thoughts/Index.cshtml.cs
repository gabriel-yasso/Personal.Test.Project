using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Personal.Test.Project.Thoughts;
using Personal.Test.Project.Thoughts.Dtos;
using Personal.Test.Project.Web.Pages.Thoughts.ViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.ObjectMapping;

namespace Personal.Test.Project.Web.Pages.Thoughts
{
    public class IndexModel : ProjectPageModel
    {
        [BindProperty]
        public CreateThoughtViewModel ViewModel { get; set; }
        [BindProperty]
        public Guid Id { get; set; }
        public IThoughtAppService _service { get; set; }
        public IndexModel(IThoughtAppService service)
        {
            _service = service;
        }
        public List<ThoughtDto> Thoughts { get; set; }
        public async Task OnGet()
        {
            Thoughts = await _service.GetListAsync();
        }
        public async Task<IActionResult> OnPostDeleteAsync()
        {
            await _service.DeleteAsync(Id);
            return RedirectToPage();
        }
        public async Task<IActionResult> OnPostAsync() 
        { 
            var dto = ObjectMapper.Map<CreateThoughtViewModel, CreateThoughtDto>(ViewModel);
            await _service.CreateAsync(dto);
            return RedirectToPage();
        }
    }
}
