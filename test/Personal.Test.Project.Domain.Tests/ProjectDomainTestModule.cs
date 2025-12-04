using Volo.Abp.Modularity;

namespace Personal.Test.Project;

[DependsOn(
    typeof(ProjectDomainModule),
    typeof(ProjectTestBaseModule)
)]
public class ProjectDomainTestModule : AbpModule
{

}
