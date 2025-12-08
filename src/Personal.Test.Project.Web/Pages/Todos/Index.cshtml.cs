using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Personal.Test.Project.Todos;
using Personal.Test.Project.Todos.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Personal.Test.Project.Web.Pages.Todos
{
    public class IndexModel : ProjectPageModel
    {
        public List<TodoItemDto> TodoItems { get; set; }
        
        private readonly ITodoAppService _todoAppService;
        public IndexModel(ITodoAppService todoAppService)
        {
            _todoAppService = todoAppService;
        }
        public async Task OnGetAsync()
        {
            TodoItems = await _todoAppService.GetListAsync();
        }

    }
}
