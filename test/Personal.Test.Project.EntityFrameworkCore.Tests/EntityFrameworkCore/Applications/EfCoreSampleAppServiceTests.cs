using Personal.Test.Project.Samples;
using Xunit;

namespace Personal.Test.Project.EntityFrameworkCore.Applications;

[Collection(ProjectTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<ProjectEntityFrameworkCoreTestModule>
{

}
