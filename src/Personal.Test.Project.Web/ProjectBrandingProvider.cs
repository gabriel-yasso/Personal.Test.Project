using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;
using Microsoft.Extensions.Localization;
using Personal.Test.Project.Localization;

namespace Personal.Test.Project.Web;

[Dependency(ReplaceServices = true)]
public class ProjectBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<ProjectResource> _localizer;

    public ProjectBrandingProvider(IStringLocalizer<ProjectResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
