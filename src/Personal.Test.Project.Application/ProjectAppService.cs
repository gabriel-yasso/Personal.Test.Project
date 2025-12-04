using Personal.Test.Project.Localization;
using Volo.Abp.Application.Services;

namespace Personal.Test.Project;

/* Inherit your application services from this class.
 */
public abstract class ProjectAppService : ApplicationService
{
    protected ProjectAppService()
    {
        LocalizationResource = typeof(ProjectResource);
    }
}
