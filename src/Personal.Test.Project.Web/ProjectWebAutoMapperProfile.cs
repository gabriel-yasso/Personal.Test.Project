using AutoMapper;
using Personal.Test.Project.Thoughts.Dtos;
using Personal.Test.Project.Web.Pages.Thoughts.ViewModels;

namespace Personal.Test.Project.Web;

public class ProjectWebAutoMapperProfile : Profile
{
    public ProjectWebAutoMapperProfile()
    {
        //Define your object mappings here, for the Web project
        CreateMap<CreateThoughtViewModel, CreateThoughtDto>();
        CreateMap<EditThoughtViewModel, UpdateThoughtDto>();
    }
}
