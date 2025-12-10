using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Personal.Test.Project.Thoughts;
using Personal.Test.Project.Thoughts.Dtos;
using System;
using System.Threading.Tasks;

namespace Personal.Test.Project.Web.Pages.Thoughts
{
    public class DetailsModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }
        public ThoughtDto Thought { get; set; }
        private readonly IThoughtAppService _service;
        public DetailsModel(IThoughtAppService service)
        {
            _service = service;
        }
        public async Task OnGetAsync()
        {
            var dto = await _service.GetAsync(Id);
            Thought = dto;
        }
    }
}
