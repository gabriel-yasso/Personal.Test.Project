using Personal.Test.Project.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Personal.Test.Project.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ProjectController : AbpControllerBase
{
    protected ProjectController()
    {
        LocalizationResource = typeof(ProjectResource);
    }
}
