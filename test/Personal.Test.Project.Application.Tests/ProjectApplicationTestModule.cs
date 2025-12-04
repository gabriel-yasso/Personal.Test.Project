using Volo.Abp.Modularity;

namespace Personal.Test.Project;

[DependsOn(
    typeof(ProjectApplicationModule),
    typeof(ProjectDomainTestModule)
)]
public class ProjectApplicationTestModule : AbpModule
{

}
