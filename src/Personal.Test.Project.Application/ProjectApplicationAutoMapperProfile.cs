using AutoMapper;
using Personal.Test.Project.Notes.Dtos;
using Personal.Test.Project.PersonalTasks;
using Personal.Test.Project.PersonalTasks.Dtos;
using Personal.Test.Project.Thoughts;
using Personal.Test.Project.Thoughts.Dtos;

namespace Personal.Test.Project;

public class ProjectApplicationAutoMapperProfile : Profile
{
    public ProjectApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Note, NoteDto>();
        CreateMap<PersonalTask, PersonalTaskDto>();
        CreateMap<Thought, ThoughtDto>();
        CreateMap<UpdateThoughtDto, Thought>();
    }
}
