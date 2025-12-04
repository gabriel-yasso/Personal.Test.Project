using Personal.Test.Project.Samples;
using Xunit;

namespace Personal.Test.Project.EntityFrameworkCore.Domains;

[Collection(ProjectTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<ProjectEntityFrameworkCoreTestModule>
{

}
