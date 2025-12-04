using Personal.Test.Project.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Personal.Test.Project.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ProjectEntityFrameworkCoreModule),
    typeof(ProjectApplicationContractsModule)
)]
public class ProjectDbMigratorModule : AbpModule
{
}
