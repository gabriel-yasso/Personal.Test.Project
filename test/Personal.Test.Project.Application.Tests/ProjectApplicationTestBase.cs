using Volo.Abp.Modularity;

namespace Personal.Test.Project;

public abstract class ProjectApplicationTestBase<TStartupModule> : ProjectTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
