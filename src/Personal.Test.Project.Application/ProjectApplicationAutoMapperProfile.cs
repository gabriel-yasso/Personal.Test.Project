using AutoMapper;
using Personal.Test.Project.Notes.Dtos;

namespace Personal.Test.Project;

public class ProjectApplicationAutoMapperProfile : Profile
{
    public ProjectApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Note, NoteDto>();
    }
}
