using Xunit;

namespace Personal.Test.Project.EntityFrameworkCore;

[CollectionDefinition(ProjectTestConsts.CollectionDefinitionName)]
public class ProjectEntityFrameworkCoreCollection : ICollectionFixture<ProjectEntityFrameworkCoreFixture>
{

}
