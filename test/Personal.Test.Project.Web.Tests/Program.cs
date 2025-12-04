using Microsoft.AspNetCore.Builder;
using Personal.Test.Project;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
builder.Environment.ContentRootPath = GetWebProjectContentRootPathHelper.Get("Personal.Test.Project.Web.csproj"); 
await builder.RunAbpModuleAsync<ProjectWebTestModule>(applicationName: "Personal.Test.Project.Web");

public partial class Program
{
}
