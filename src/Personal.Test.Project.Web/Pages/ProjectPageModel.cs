using Personal.Test.Project.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Personal.Test.Project.Web.Pages;

public abstract class ProjectPageModel : AbpPageModel
{
    protected ProjectPageModel()
    {
        LocalizationResourceType = typeof(ProjectResource);
    }
}
